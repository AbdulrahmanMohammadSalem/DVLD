using DVLD.Analytics.Dashboard;
using DVLD.Analytics.Reports;
using DVLD.Application_Settings;
using DVLD.Applications;
using DVLD.Applications.International_Driving_License;
using DVLD.Applications.Local_Driving_License;
using DVLD.Applications.Local_Driving_License.Layouts;
using DVLD.Applications.Renew_Driving_License;
using DVLD.Applications.Replacement_for_Lost_Damaged;
using DVLD.Applications.Test_Types;
using DVLD.Common;
using DVLD.Detain_Licenses;
using DVLD.Detain_Licenses.Layouts;
using DVLD.Drivers.Layouts;
using DVLD.Interfaces;
using DVLD.Licenses.Layouts;
using DVLD.Licenses.License_Classes;
using DVLD.People;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD.Tests;
using DVLD.Users;
using DVLD_Business;
using Salem.Extensions;
using Salem.Controls;
using Salem.Controls.Renderers;
using Salem.Drawing;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DVLD.Analytics.Reports.Complementary_Forms;
using System.Media;
using static DVLD_Business.Permissions;

namespace DVLD {
    public partial class Frm_MainScreen : SalForm, IEnforcePermissions {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public bool SignOut { get; private set; } = false;

        private ClosableLayout ActiveLayout { get; set; } = null;

        public Frm_MainScreen() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            Default_SettingsSaving(null, null);

            toolStripContainer1.RightToolStripPanel.Tag = BorderSides.Left;
            toolStripContainer1.LeftToolStripPanel.Tag = BorderSides.Right;
            toolStripContainer1.TopToolStripPanel.Tag = BorderSides.Bottom;
            toolStripContainer1.BottomToolStripPanel.Tag = BorderSides.Top;

            GlobalFields.ToolStripRenderer.ToolStripBorderSides = BorderSides.Bottom;
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            menuStrip_mainOptions.Renderer = GlobalFields.ToolStripRenderer;
            
            License.DeactivateAllExpiredLicenses();
        }

        private void Default_SettingsSaving(object sender, System.ComponentModel.CancelEventArgs e) {
            BackColor = toolStripContainer1.ContentPanel.BackColor = pictureBox1.BackColor = Settings.Default.CurrentThemeID == 19 ? Settings.Default.BaseBackColor : Settings.Default.SurfaceBackColor; //Office 2019
            pictureBox1.Image = BackColor.IsLight() ? Resources.Final_Background_Black : Resources.Final_Background_White;
        }

        private void MenuStrip_mainOptions_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ManagePeople>();

        private void ClearActiveLayout(bool showBackground) {
            pictureBox1.Visible = showBackground;

            ActiveLayout.CloseRequested -= ClearActiveLayout;
            ActiveLayout.ForceExit -= _PerformLogout;
            ActiveLayout.ActiveUserPermissionsChanged -= EnforcePermissions;

            Controls.Remove(ActiveLayout);

            ActiveLayout.Dispose();
            ActiveLayout = null;
        }

        private void _DisplayLayout<TLayout>() where TLayout : ClosableLayout, new() {
            if (ActiveLayout != null) {
                if (ActiveLayout is TLayout)
                    return;

                ClearActiveLayout(false);
            } else
                pictureBox1.Visible = false;

            ActiveLayout = new TLayout { Dock = DockStyle.Fill };

            ActiveLayout.CloseRequested += ClearActiveLayout;
            ActiveLayout.ForceExit += _PerformLogout;
            ActiveLayout.ActiveUserPermissionsChanged += EnforcePermissions;

            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.Controls.Add(ActiveLayout);
            ActiveLayout.BringToFront();
            toolStripContainer1.ContentPanel.ResumeLayout();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ManageUsers>();

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _PerformLogout();
                return;
            }

            using (Frm_ShowUserInformation _frmShowUserInfo = new Frm_ShowUserInformation(_activeUser)) {
                _frmShowUserInfo.UserSaved += _frmShowUserInfo_UserSaved;
                _frmShowUserInfo.ShowDialog();
                _frmShowUserInfo.UserSaved -= _frmShowUserInfo_UserSaved;
            }
        }

        private void _frmShowUserInfo_UserSaved(int userID) => _frm_DataSaved();

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _PerformLogout();
                return;
            }

            using (Frm_ChangeUserPassword _frmChangePassword = new Frm_ChangeUserPassword(_activeUser)) {
                _frmChangePassword.UserSaved += _frmShowUserInfo_UserSaved;
                _frmChangePassword.ShowDialog();
                _frmChangePassword.UserSaved -= _frmShowUserInfo_UserSaved;
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e) {
            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmMainScreen.signoutConfirmation, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                _PerformLogout();
        }
        
        private void _PerformLogout() {
            GlobalFields.ActiveUserID = -1;
            SignOut = true;
            Close();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ManageLocalDrivingLicenseApps>();

        private void manageApplicationTypesToolStripMenuItem_Click_1(object sender, EventArgs e) {
            using (Frm_ManageApplicationTypes _frmManageApplicationTypes = new Frm_ManageApplicationTypes())
                _frmManageApplicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem1_Click(object sender, EventArgs e) {
            using (Frm_ManageTestTypes _frmManageTestTypes = new Frm_ManageTestTypes())
                _frmManageTestTypes.ShowDialog();
        }

        private void manageLicenseClassesToolStripMenuItem1_Click(object sender, EventArgs e) {
            using (Frm_ManageLicenseClasses _frmManageLicenseClasses = new Frm_ManageLicenseClasses())
                _frmManageLicenseClasses.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_AddEditLocalDrivingLicenseApplication _frmAddNewLDLApp = new Frm_AddEditLocalDrivingLicenseApplication()) {
                _frmAddNewLDLApp.ForceExit += _PerformLogout;
                _frmAddNewLDLApp.DataSaved += _frm_DataSaved;
                _frmAddNewLDLApp.ShowDialog();
                _frmAddNewLDLApp.DataSaved -= _frm_DataSaved;
                _frmAddNewLDLApp.ForceExit -= _PerformLogout;
            }
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ManageDrivers>();

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowPersonTestsHistory _frmRetakeTest = new Frm_ShowPersonTestsHistory()) {
                _frmRetakeTest.DataSaved += _frm_DataSaved;
                _frmRetakeTest.ForceExit += _PerformLogout;
                _frmRetakeTest.ShowDialog();
                _frmRetakeTest.ForceExit -= _PerformLogout;
                _frmRetakeTest.DataSaved -= _frm_DataSaved;
            }
        }

        private void allApplicationsAcrossTheSystemToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ShowAllApplications>();

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ManageInternationalDrivingLicenseApps>();

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_IssueNewInternationalLicense _frmNewInterLicense = new Frm_IssueNewInternationalLicense()) {
                _frmNewInterLicense.DataSaved += _frm_DataSaved;
                _frmNewInterLicense.ForceExit += _PerformLogout;
                _frmNewInterLicense.ShowDialog();
                _frmNewInterLicense.ForceExit -= _PerformLogout;
                _frmNewInterLicense.DataSaved -= _frm_DataSaved;
            }
        }

        private void viewAllLicensesToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ShowAllLicenses>();

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_RenewLocalDrivingLicense _frmRenewLocalDrivingLicense = new Frm_RenewLocalDrivingLicense()) {
                _frmRenewLocalDrivingLicense.DataSaved += _frm_DataSaved;
                _frmRenewLocalDrivingLicense.ForceExit += _PerformLogout;
                _frmRenewLocalDrivingLicense.ShowDialog();
                _frmRenewLocalDrivingLicense.ForceExit -= _PerformLogout;
                _frmRenewLocalDrivingLicense.DataSaved -= _frm_DataSaved;
            }
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ReplacementForLostDamagedApplication _frmReplacementLostDamagedApp = new Frm_ReplacementForLostDamagedApplication()) {
                _frmReplacementLostDamagedApp.DataSaved += _frm_DataSaved;
                _frmReplacementLostDamagedApp.ForceExit += _PerformLogout;
                _frmReplacementLostDamagedApp.ShowDialog();
                _frmReplacementLostDamagedApp.ForceExit -= _PerformLogout;
                _frmReplacementLostDamagedApp.DataSaved -= _frm_DataSaved;
            }
        }

        private void Frm_MainScreen_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;

        private void menuStrip_mainOptions_ParentChanged(object sender, EventArgs e) {
            if (menuStrip_mainOptions.Parent != null)
                ((SalToolStripRenderer) menuStrip_mainOptions.Renderer).ToolStripBorderSides = (BorderSides) menuStrip_mainOptions.Parent.Tag;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ApplicationSettings _frmSettings = new Frm_ApplicationSettings())
                _frmSettings.ShowDialog();
        }

        private void _frm_DataSaved() => ((IDataConsumer) ActiveLayout).ReloadAllData();

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_DetainLicense _frmDetainLicense = new Frm_DetainLicense()) {
                _frmDetainLicense.DataSaved += _frm_DataSaved;
                _frmDetainLicense.ForceExit += _PerformLogout;
                _frmDetainLicense.ShowDialog();
                _frmDetainLicense.DataSaved -= _frm_DataSaved;
                _frmDetainLicense.ForceExit -= _PerformLogout;
            }
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ReleaseDetainedLicense _frmReleaseDetainedLicense = new Frm_ReleaseDetainedLicense()) {
                _frmReleaseDetainedLicense.DataSaved += _frm_DataSaved;
                _frmReleaseDetainedLicense.ForceExit += _PerformLogout;
                _frmReleaseDetainedLicense.ShowDialog();
                _frmReleaseDetainedLicense.ForceExit -= _PerformLogout;
                _frmReleaseDetainedLicense.DataSaved -= _frm_DataSaved;
            }
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_ManageDetainedLicenses>();

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayLayout<Layout_Dashboard>();

        private void _frmPersonHistoryReport_PersonSaved(int personID) => ((IDataConsumer) ActiveLayout).ReloadAllData();

        private void personHistoryReportToolStripMenuItem_Click(object sender, EventArgs e) => _LaunchReportForm<Frm_PersonHistoryReport>();

        private void localLicenseApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e) => _LaunchReportForm<Frm_LocalLicenseAppDetailsReport>();

        private void driverProfileReportToolStripMenuItem_Click(object sender, EventArgs e) => _LaunchReportForm<Frm_DriverProfileReport>();

        private void testAttemptsReportToolStripMenuItem_Click(object sender, EventArgs e) => _LaunchReportForm<Frm_TestAttemptsReport>();

        private void licenseDetentionReportToolStripMenuItem_Click(object sender, EventArgs e) => _LaunchReportForm<Frm_LicenseDetentionReport>();

        private void userActivityReportToolStripMenuItem_Click(object sender, EventArgs e) => _LaunchReportForm<Frm_UserActivityReport>();

        private void _LaunchReportForm<TForm>() where TForm : ReportFormBase, new() {
            using (TForm _frmReport = new TForm()) {
                _frmReport.PersonSaved += _frmPersonHistoryReport_PersonSaved;
                _frmReport.ForceExit += _PerformLogout;
                _frmReport.ShowDialog();
                _frmReport.ForceExit -= _PerformLogout;
                _frmReport.PersonSaved -= _frmPersonHistoryReport_PersonSaved;
            }
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            btn_newLocalLicenseApp.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.CreateNewLocalLicenseApp);
            btn_newInterLicenseApp.Enabled = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense);
            btn_newDrivingLicenseMenu.Enabled = btn_newLocalLicenseApp.Enabled || btn_newInterLicenseApp.Enabled;

            btn_renewLicenseApp.Enabled = permissions.Licenses.HasFlag(LicensesManagement.RenewLicense);
            btn_replaceLicenseApp.Enabled = permissions.Licenses.HasFlag(LicensesManagement.IssueLicenseReplacement);
            btn_releaseDetainedLicenseApp1.Enabled = btn_releaseDetainedLicenseApp2.Enabled = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ReleaseDetainedLicense);
            btn_retakeTest.Enabled = permissions.Tests_TestAppoints != Tests_TestAppointsManagement.NoAccess;
            btn_viewAllLicenses.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ViewAllLocalLicenses) || permissions.Licenses.HasFlag(LicensesManagement.ViewAllInterLicenses);
            btn_drivingLicenseServicesMenu.Enabled = btn_newDrivingLicenseMenu.Enabled || btn_renewLicenseApp.Enabled || btn_replaceLicenseApp.Enabled || btn_releaseDetainedLicenseApp1.Enabled || btn_retakeTest.Enabled || btn_viewAllLicenses.Enabled;

            btn_manageLocalLicenseApps.Enabled = permissions.LocalLicenseApps != LocalLicenseAppsManagement.NoAccess;
            btn_manageInterLicenseApps.Enabled = permissions.InterLicenseApps != InterLicenseAppsManagement.NoAccess;
            btn_viewAllApps.Enabled = btn_manageLocalLicenseApps.Enabled && btn_manageInterLicenseApps.Enabled;
            btn_manageAppsMenu.Enabled = btn_manageLocalLicenseApps.Enabled || btn_manageInterLicenseApps.Enabled;

            btn_manageLicenseDetentions.Enabled = permissions.LicenseDetention != LicenseDetentionManagement.NoAccess;
            btn_detainLicense.Enabled = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.DetainLicense);
            btn_detainLicensesMenu.Enabled = btn_manageLicenseDetentions.Enabled || btn_detainLicense.Enabled || btn_releaseDetainedLicenseApp2.Enabled;

            btn_dashboard.Enabled = permissions.Dashboard != DashboardAccess.NoAccess;
            btn_personHistoryReport.Enabled = permissions.Reports.HasFlag(ReportsAccess.PersonHistoryReport);
            btn_localLicenseAppDetailsReport.Enabled = permissions.Reports.HasFlag(ReportsAccess.LocalLicenseApplicationDetailsReport);
            btn_driverProfileReport.Enabled = permissions.Reports.HasFlag(ReportsAccess.DriverProfileReport);
            btn_testAttemptsReports.Enabled = permissions.Reports.HasFlag(ReportsAccess.TestAttemptsReport);
            btn_licenseDetentionReport.Enabled = permissions.Reports.HasFlag(ReportsAccess.LicenseDetentionReport);
            btn_userActivityReport.Enabled = permissions.Reports.HasFlag(ReportsAccess.UserActivityReport);
            btn_reportsMenu.Enabled = permissions.Reports != ReportsAccess.NoAccess;
            btn_analyticsMenu.Enabled = btn_dashboard.Enabled || btn_reportsMenu.Enabled;

            btn_manageAppTypes.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData) || permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ExportData);
            btn_manageTestTypes.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData) || permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ExportData);
            btn_manageLicenseClasses.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData) || permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ExportData);
            btn_lookupTablesMenu.Enabled = permissions.LookupTables != LookupTablesManagement.NoAccess;

            btn_servicesMenu.Enabled = btn_drivingLicenseServicesMenu.Enabled || btn_manageAppsMenu.Enabled || btn_detainLicensesMenu.Enabled || btn_analyticsMenu.Enabled || btn_lookupTablesMenu.Enabled;
            btn_managePeople.Enabled = permissions.People != PeopleManagement.NoAccess;
            btn_manageDrivers.Enabled = permissions.Drivers != DriversManagement.NoAccess;
            btn_manageUsers.Enabled = permissions.Users != UsersManagement.NoAccess;
            btn_applicationSettings.Enabled = permissions.ApplicationSettings != ApplicationSettingsAccess.NoAccess;
        }
    }
}
