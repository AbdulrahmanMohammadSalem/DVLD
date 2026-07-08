using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD.Tests;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications.Local_Driving_License.Layouts {
    public partial class Layout_ManageLocalDrivingLicenseApps : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private DataTable _dtAllLocalDrivingLicenseApps;

        public Layout_ManageLocalDrivingLicenseApps() {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == SupportedLanguages.English)
                cb_inputFilterBy.Height += 3;

            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_localDrivingLicenseApps);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            cb_inputFilterBy.Tag = false; //DigitsOnly = false
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_localDrivingLicenseApps); 

        private enum FilterByOptions : byte {
            None, LocalDrivingLicenseApplicationID, ClassName, NationalNum, 
            FullName, ApplicationDate, PassedTestsCount, ApplicationStatus
        }

        private void Layout_ManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps)) {
                cb_filterBy.SelectedIndex = 0;
                ReloadAllData();

                _SetupTableHeader();
            }
        }

        private void _SetupTableHeader() {
            dgv_localDrivingLicenseApps.Columns[7].Visible = false; //LicenseClassID

            dgv_localDrivingLicenseApps.Columns[0].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.localDrivingLicenseAppID;
            dgv_localDrivingLicenseApps.Columns[0].Width = 60;

            dgv_localDrivingLicenseApps.Columns[1].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.licenseClass;
            dgv_localDrivingLicenseApps.Columns[1].Width = 170;

            dgv_localDrivingLicenseApps.Columns[2].HeaderText = Str_LayoutManagePeople.nationalNum;
            dgv_localDrivingLicenseApps.Columns[2].Width = 100;

            dgv_localDrivingLicenseApps.Columns[3].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_localDrivingLicenseApps.Columns[3].Width = 210;

            dgv_localDrivingLicenseApps.Columns[4].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.applicationDate;
            dgv_localDrivingLicenseApps.Columns[4].Width = 110;

            dgv_localDrivingLicenseApps.Columns[5].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.numOfTestPassed;
            dgv_localDrivingLicenseApps.Columns[5].Width = 100;

            dgv_localDrivingLicenseApps.Columns[6].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.status;
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_localDrivingLicenseApps.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter == FilterByOptions.LocalDrivingLicenseApplicationID || _selectedFilter == FilterByOptions.NationalNum || _selectedFilter == FilterByOptions.PassedTestsCount) {
                if (!((bool) cb_inputFilterBy.Tag)) {
                    cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress;
                    cb_inputFilterBy.Tag = true;
                }
            } else if ((bool) cb_inputFilterBy.Tag) {
                cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress;
                cb_inputFilterBy.Tag = false;
            }

            if (_selectedFilter == FilterByOptions.ClassName || _selectedFilter == FilterByOptions.ApplicationStatus) {
                SupportedLanguages _lang = Settings.Default.CurrentLanguage;

                cb_inputFilterBy.Items.Clear();
                cb_inputFilterBy.Items.Add(Str_LayoutManagePeople.all);
                cb_inputFilterBy.Items.AddRange(_selectedFilter == FilterByOptions.ClassName ? LicenseClass.GetAllLicenseClassNames(_lang) : new string[3] { Str_LayoutManageLocalDrivingLicenseApps._new, Str_LayoutManageLocalDrivingLicenseApps.completed, Str_LayoutManageLocalDrivingLicenseApps.cancelled });

                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_inputFilterBy.DropDownWidth = _selectedFilter == FilterByOptions.ClassName ? 300 : 207;
                cb_inputFilterBy.SelectedIndex = 0;
            } else
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.Simple;

            cb_inputFilterBy.Visible = _selectedFilter != FilterByOptions.None;
            cb_inputFilterBy.Text = string.Empty; //To clear filtering and show all records
        }

        private void ComboBox_inputFilterBy_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void comboBox_inputFilterBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void button_addNewLocalDrivingLicenseApp_Click(object sender, EventArgs e) => _DisplayAddNewLocalDrivingLicenseAppDialog();

        private void _DisplayAddNewLocalDrivingLicenseAppDialog() {
            using (Frm_AddEditLocalDrivingLicenseApplication _frmAddNewLDLApp = new Frm_AddEditLocalDrivingLicenseApplication()) {
                _frmAddNewLDLApp.ForceExit += OnForceExit;
                _frmAddNewLDLApp.DataSaved += ReloadAllData;
                _frmAddNewLDLApp.ShowDialog();
                _frmAddNewLDLApp.DataSaved -= ReloadAllData;
                _frmAddNewLDLApp.ForceExit -= OnForceExit;
            }
        }

        private void newApplicationToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayAddNewLocalDrivingLicenseAppDialog();

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_AddEditLocalDrivingLicenseApplication _frmEditLocalDrivingLicenseApplication = new Frm_AddEditLocalDrivingLicenseApplication((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value)) {
                if (_frmEditLocalDrivingLicenseApplication.IsDisposed)
                    return;

                _frmEditLocalDrivingLicenseApplication.DataSaved += ReloadAllData;
                _frmEditLocalDrivingLicenseApplication.ShowDialog();
                _frmEditLocalDrivingLicenseApplication.DataSaved -= ReloadAllData;
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails))
                _ShowCurrentRowDetails();
        }

        private void _ShowCurrentRowDetails() {
            using (Frm_ShowLocalDrivingLicenseAppInformation _frmShowLocalDrivingLicenseAppInformation = new Frm_ShowLocalDrivingLicenseAppInformation((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value)) {
                if (_frmShowLocalDrivingLicenseAppInformation.IsDisposed)
                    return;

                _frmShowLocalDrivingLicenseAppInformation.PersonSaved += _frmShowLocalDrivingLicenseAppInformation_PersonSaved;
                _frmShowLocalDrivingLicenseAppInformation.ShowDialog();
                _frmShowLocalDrivingLicenseAppInformation.PersonSaved -= _frmShowLocalDrivingLicenseAppInformation_PersonSaved;
            }
        }

        private void _frmShowLocalDrivingLicenseAppInformation_PersonSaved(int personID) => ReloadAllData();

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(Str_LayoutManageLocalDrivingLicenseApps.applicationDeleteConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                if (LocalDrivingLicenseApp.Delete((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value)) {
                    ReloadAllData();
                    MessageBox.Show(Str_LayoutManageLocalDrivingLicenseApps.applicationDeletedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Resources.msg_errorDeleting, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadAllData() {
            _dtAllLocalDrivingLicenseApps = LocalDrivingLicenseApp.GetPreferredApplicationsView(Settings.Default.CurrentLanguage);
        
            dgv_localDrivingLicenseApps.DataSource = _dtAllLocalDrivingLicenseApps;
        
            RefreshDataFiltering();
        }

        public void RefreshDataFiltering() {
            if (cb_inputFilterBy.Text == string.Empty || cb_filterBy.SelectedIndex == (int) FilterByOptions.None || ((cb_filterBy.SelectedIndex == (int) FilterByOptions.ClassName || cb_filterBy.SelectedIndex == (int) FilterByOptions.ApplicationStatus) && cb_inputFilterBy.SelectedIndex == 0))
                _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = string.Empty;
            else {
                FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

                if (_selectedFilter == FilterByOptions.LocalDrivingLicenseApplicationID || _selectedFilter == FilterByOptions.PassedTestsCount)
                    _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = $"{_selectedFilter} = '{cb_inputFilterBy.Text}'";
                else if (_selectedFilter == FilterByOptions.ApplicationStatus)
                    _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = $"ApplicationStatus = {cb_inputFilterBy.SelectedIndex}";
                else if (_selectedFilter == FilterByOptions.ClassName) {
                    string _identifier = Settings.Default.CurrentLanguage == SupportedLanguages.Arabic ? _selectedFilter.ToString() + "AR" : _selectedFilter.ToString();

                    _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = $"{_identifier} LIKE '%{cb_inputFilterBy.Text}%'";
                } else if (_selectedFilter == FilterByOptions.ApplicationDate) {
                    if (DateTime.TryParseExact(cb_inputFilterBy.Text, BusinessUtils.DateTimeUtils.DateSearchFormat, null, System.Globalization.DateTimeStyles.None, out var _result))
                        _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                    else
                        _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = string.Empty;
                } else
                    _dtAllLocalDrivingLicenseApps.DefaultView.RowFilter = $"{_selectedFilter} LIKE '%{cb_inputFilterBy.Text}%'";
            }

            label_numOfRecords.Text = dgv_localDrivingLicenseApps.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_localDrivingLicenseApps.RowCount == 0;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) => ReloadAllData();

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void dgv_localDrivingLicenseApps_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails))
                _ShowCurrentRowDetails(); 
        }

        private void dgv_localDrivingLicenseApps_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_localDrivingLicenseApps.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (dgv_localDrivingLicenseApps.Columns[e.ColumnIndex].Name == "ApplicationStatus") {
                ApplicationStatus _status = (ApplicationStatus) e.Value;

                e.CellStyle.ForeColor = BusinessUtils.Mapping.GetApplicationStatusColor(_status);
                e.Value = BusinessUtils.Mapping.GetApplicationStatusString(_status);
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold | FontStyle.Italic);
                e.FormattingApplied = true;
            } else if (dgv_localDrivingLicenseApps.Columns[e.ColumnIndex].Name == "PassedTestsCount") {
                e.CellStyle.ForeColor = BusinessUtils.Mapping.GetPassedTestsColor((byte) e.Value);
                e.Value = $"{e.Value}/3";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (dgv_localDrivingLicenseApps.SelectedCells.Count == 0) {
                showApplicationDetailsToolStripMenuItem.Enabled = editApplicationToolStripMenuItem.Enabled = 
                    deleteApplicationToolStripMenuItem.Enabled = cancelApplicationToolStripMenuItem.Enabled = 
                    scheduleTestToolStripMenuItem.Enabled = issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled =
                    showLicenseToolStripMenuItem.Enabled = showPersonLicenseHistoryToolStripMenuItem.Enabled = false;

                return;
            }

            var _currentPermissions = GlobalFields.ActiveUserPermissions;
            ApplicationStatus _selectedApplicationStatus = (ApplicationStatus) dgv_localDrivingLicenseApps.CurrentRow.Cells["ApplicationStatus"].Value;
            byte _selectedNumPassedTests = (byte) dgv_localDrivingLicenseApps.CurrentRow.Cells["PassedTestsCount"].Value;

            deleteApplicationToolStripMenuItem.Enabled = _currentPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.DeleteApp) && _selectedApplicationStatus != ApplicationStatus.Completed;
            cancelApplicationToolStripMenuItem.Enabled = _currentPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.CancelApp) && _selectedApplicationStatus == ApplicationStatus.New;
            editApplicationToolStripMenuItem.Enabled = _currentPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.EditAppInfo) && _selectedApplicationStatus == ApplicationStatus.New && _selectedNumPassedTests == 0;
            scheduleTestToolStripMenuItem.Enabled = _selectedApplicationStatus == ApplicationStatus.New && _selectedNumPassedTests < 3;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = _currentPermissions.Licenses.HasFlag(LicensesManagement.IssueLocalLicenseFirstTime) && _selectedApplicationStatus == ApplicationStatus.New && _selectedNumPassedTests == 3;
            showLicenseToolStripMenuItem.Enabled = _currentPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo) && _selectedApplicationStatus == ApplicationStatus.Completed;
            
            if (scheduleTestToolStripMenuItem.Enabled) {
                visionTestToolStripMenuItem.Enabled = (_currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_CreateNewAppointment) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_TakeTest) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_ExportAppointmentsdata)) && GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails) && _selectedNumPassedTests == 0;
                writtenTestToolStripMenuItem.Enabled = (_currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_CreateNewAppointment) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_UpdateAppointmentInfo) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_TakeTest) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_ExportAppointmentsdata)) && GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails) && _selectedNumPassedTests == 1;
                drivingTestToolStripMenuItem.Enabled = (_currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_CreateNewAppointment) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_TakeTest) || _currentPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_ExportAppointmentsdata)) && GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails) && _selectedNumPassedTests == 2;

                scheduleTestToolStripMenuItem.Enabled = visionTestToolStripMenuItem.Enabled || writtenTestToolStripMenuItem.Enabled || drivingTestToolStripMenuItem.Enabled;
            }
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e) =>
            visionTestToolStripMenuItem.Enabled = writtenTestToolStripMenuItem.Enabled = drivingTestToolStripMenuItem.Enabled = false;

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!LocalDrivingLicenseApp.DoesExist((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value)) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(Str_LayoutManageLocalDrivingLicenseApps.applicationCancelConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                if (LocalDrivingLicenseApp.UpdateStatus((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value, ApplicationStatus.Cancelled)) {
                    ReloadAllData();
                    MessageBox.Show(Str_LayoutManageLocalDrivingLicenseApps.doneSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void testAppointmentToolStripMenuItem_Click(object sender, EventArgs e) {
            TestTypes _chosenTestType = (TestTypes) byte.Parse(((ToolStripMenuItem) sender).Tag.ToString());

            using (Frm_TestAppointments _frmTestAppointments = new Frm_TestAppointments((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value, _chosenTestType)) {
                if (_frmTestAppointments.IsDisposed)
                    return;

                _frmTestAppointments.ForceExit += OnForceExit;
                _frmTestAppointments.DataSaved += ReloadAllData;
                _frmTestAppointments.ShowDialog();
                _frmTestAppointments.DataSaved -= ReloadAllData;
                _frmTestAppointments.ForceExit -= OnForceExit;
            }
        }

        private void showPersonTestsHistoryToolStripMenuItem6_Click(object sender, EventArgs e) {
            int _applicantPersonID = LocalDrivingLicenseApp.FindApplicantPersonID((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value);

            if (_applicantPersonID == -1) {
                MessageBox.Show(Str_LayoutManageLocalDrivingLicenseApps.applicantInfoNotFound, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Frm_ShowPersonTestsHistory _frmShowPersonTestsHistory = new Frm_ShowPersonTestsHistory(_applicantPersonID)) {
                if (_frmShowPersonTestsHistory.IsDisposed)
                    return;

                _frmShowPersonTestsHistory.DataSaved += ReloadAllData;
                _frmShowPersonTestsHistory.ForceExit += OnForceExit;
                _frmShowPersonTestsHistory.ShowDialog();
                _frmShowPersonTestsHistory.ForceExit -= OnForceExit;
                _frmShowPersonTestsHistory.DataSaved -= ReloadAllData;
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_IssueLocalDrivingLicenseFirstTime _frmIssueDrivingLicenseFirstTime = new Frm_IssueLocalDrivingLicenseFirstTime((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value)) {
                if (_frmIssueDrivingLicenseFirstTime.IsDisposed)
                    return;

                _frmIssueDrivingLicenseFirstTime.ForceExit += OnForceExit;
                _frmIssueDrivingLicenseFirstTime.DataSaved += ReloadAllData;
                _frmIssueDrivingLicenseFirstTime.ShowDialog();
                _frmIssueDrivingLicenseFirstTime.DataSaved -= ReloadAllData;
                _frmIssueDrivingLicenseFirstTime.ForceExit -= OnForceExit;
            }
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowLocalLicenseInformation _frmShowLocalLicenseInfo = new Frm_ShowLocalLicenseInformation(LocalDrivingLicense.FindLocalLicenseID_ByLocalDrivingLicenseAppID((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value, (LicenseClasses) dgv_localDrivingLicenseApps.CurrentRow.Cells[7].Value))) {
                if (_frmShowLocalLicenseInfo.IsDisposed)
                    return;

                _frmShowLocalLicenseInfo.PersonSaved += _frmShowLocalDrivingLicenseAppInformation_PersonSaved;
                _frmShowLocalLicenseInfo.ShowDialog();
                _frmShowLocalLicenseInfo.PersonSaved -= _frmShowLocalDrivingLicenseAppInformation_PersonSaved;
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            int _applicantPersonID = LocalDrivingLicenseApp.FindApplicantPersonID((int) dgv_localDrivingLicenseApps.CurrentRow.Cells[0].Value);

            if (_applicantPersonID == -1) {
                MessageBox.Show(Str_LayoutManageLocalDrivingLicenseApps.applicantInfoNotFound, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(_applicantPersonID)) {
                if (_frmShowDriverLicenseHistory.IsDisposed)
                    return;

                _frmShowDriverLicenseHistory.ForceExit += OnForceExit;
                _frmShowDriverLicenseHistory.DataSaved += _frmShowDriverLicenseHistory_DataSaved;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.DataSaved -= _frmShowDriverLicenseHistory_DataSaved;
                _frmShowDriverLicenseHistory.ForceExit -= OnForceExit;
            }
        }

        private void _frmShowDriverLicenseHistory_DataSaved() => ReloadAllData();

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;

            base.OnCloseRequested(showBackground);
        }

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManageLocalDrivingLicenseApps.localDrivingLicenseApps, (_dtAllLocalDrivingLicenseApps ?? LocalDrivingLicenseApp.GetPreferredApplicationsView(Settings.Default.CurrentLanguage)).DefaultView);

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_inputFilterBy.Enabled = dgv_localDrivingLicenseApps.Enabled = ll_refreshData.Enabled = refreshToolStripMenuItem.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps);
            newApplicationToolStripMenuItem.Enabled = btn_addNewLocalDrivingLicenseApp.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.CreateNewLocalLicenseApp);
            showApplicationDetailsToolStripMenuItem.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails);
            ll_exportData.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ExportLocalLicenseAppsData);
            editApplicationToolStripMenuItem.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.EditAppInfo);
            deleteApplicationToolStripMenuItem.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.DeleteApp);
            cancelApplicationToolStripMenuItem.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.CancelApp);

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.IssueLocalLicenseFirstTime) && permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails);
            showLicenseToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);

            showPersonLicenseHistoryToolStripMenuItem.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
            showPersonTestsHistoryToolStripMenuItem6.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Vision) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Written) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Driving);

            lbl_noDataAvailable.Text = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
