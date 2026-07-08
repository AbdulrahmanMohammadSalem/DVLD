using DVLD.String_Resources.Chart_Controls;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Users {
    public partial class Frm_UserPermissions : SalForm {
        private readonly DVLD_Business.Permissions _Permissions;

        public Frm_UserPermissions(User user) {
            InitializeComponent();

            _Permissions = user.PermissionsInfo;
            Text += user.Username;
        }

        private void Frm_UserPermissions_Load(object sender, EventArgs e) => listBox1.SelectedIndex = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            groupBox1.Text = listBox1.SelectedItem.ToString();

            switch (listBox1.SelectedIndex) {
                case 0: //People Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.People);
                    break;
                case 1: //Users Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.Users);
                    break;
                case 2: //Drivers Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.Drivers);
                    break;
                case 3: //Local License Apps Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.LocalLicenseApps);
                    break;
                case 4: //Inter License Apps Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.InterLicenseApps);
                    break;
                case 5: //Tests Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.Tests_TestAppoints);
                    break;
                case 6: //Licenses Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.Licenses);
                    break;
                case 7: //License Detention Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.LicenseDetention);
                    break;
                case 8: //Dashboard Access
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.Dashboard);
                    break;
                case 9: //Reports Access
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.Reports);
                    break;
                case 10: //Lookup Tables Management
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.LookupTables);
                    break;
                case 11: //Application Settings Access
                    lbl_permissionsDisplay.Text = _ConstructPermissionsTextDisplay(_Permissions.ApplicationSettings);
                    break;
            }
        }

        private string _ConstructPermissionsTextDisplay(ApplicationSettingsAccess applicationSettingsAccess) {
            lbl_noAccess.Visible = applicationSettingsAccess == ApplicationSettingsAccess.NoAccess;
            
            if (applicationSettingsAccess == ApplicationSettingsAccess.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (applicationSettingsAccess.HasFlag(ApplicationSettingsAccess.ChangeLanguage))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.changeLanguage}");

            if (applicationSettingsAccess.HasFlag(ApplicationSettingsAccess.ChangeColorMode))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.changeColorMode}");

            if (applicationSettingsAccess.HasFlag(ApplicationSettingsAccess.CreateNewTheme))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.createNewTheme}");

            if (applicationSettingsAccess.HasFlag(ApplicationSettingsAccess.EditThemeValues))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.editThemeValues}");

            if (applicationSettingsAccess.HasFlag(ApplicationSettingsAccess.RenameTheme))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.renameTheme}");

            if (applicationSettingsAccess.HasFlag(ApplicationSettingsAccess.DeleteTheme))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.deleteTheme}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(LookupTablesManagement lookupTablesManagement) {
            lbl_noAccess.Visible = lookupTablesManagement == LookupTablesManagement.NoAccess;

            if (lookupTablesManagement == LookupTablesManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.ApplicationTypes_ViewAllData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.appTypes} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.viewAllData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.appTypes} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.updateData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.ApplicationTypes_ExportData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.appTypes} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.exportData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.TestTypes_ViewAllData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.testTypes} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.viewAllData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.testTypes} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.updateData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.TestTypes_ExportData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.testTypes} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.exportData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.LicenseClasses_ViewAllData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.licenseClasses} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.viewAllData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.licenseClasses} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.updateData}");

            if (lookupTablesManagement.HasFlag(LookupTablesManagement.LicenseClasses_ExportData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.licenseClasses} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.exportData}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(ReportsAccess reportsAccess) {
            lbl_noAccess.Visible = reportsAccess == ReportsAccess.NoAccess;

            if (reportsAccess == ReportsAccess.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (reportsAccess.HasFlag(ReportsAccess.PersonHistoryReport))
                _builder.AppendLine($"✓ {BusinessUtils.Mapping.GetReportTitle(ReportTypes.PersonHistoryReport)}");

            if (reportsAccess.HasFlag(ReportsAccess.LocalLicenseApplicationDetailsReport))
                _builder.AppendLine($"✓ {BusinessUtils.Mapping.GetReportTitle(ReportTypes.LocalLicenseAppDetailsReport)}");

            if (reportsAccess.HasFlag(ReportsAccess.DriverProfileReport))
                _builder.AppendLine($"✓ {BusinessUtils.Mapping.GetReportTitle(ReportTypes.DriverProfileReport)}");

            if (reportsAccess.HasFlag(ReportsAccess.TestAttemptsReport))
                _builder.AppendLine($"✓ {BusinessUtils.Mapping.GetReportTitle(ReportTypes.TestAttemptsReport)}");

            if (reportsAccess.HasFlag(ReportsAccess.LicenseDetentionReport))
                _builder.AppendLine($"✓ {BusinessUtils.Mapping.GetReportTitle(ReportTypes.LicensesDetentionReport)}");

            if (reportsAccess.HasFlag(ReportsAccess.UserActivityReport))
                _builder.AppendLine($"✓ {BusinessUtils.Mapping.GetReportTitle(ReportTypes.UserActivityReport)}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(DashboardAccess dashboardAccess) {
            lbl_noAccess.Visible = dashboardAccess == DashboardAccess.NoAccess;

            if (dashboardAccess == DashboardAccess.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (dashboardAccess.HasFlag(DashboardAccess.TotalApplicationsOverTime))
                _builder.AppendLine($"✓ {Str_CtrlChartTotalApplicationsWithTime.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.LocalLicenseApplicationsStatus))
                _builder.AppendLine($"✓ {Str_CtrlChartNewLocalLicenseAppStatus.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.TestAppointmentsLoad))
                _builder.AppendLine($"✓ {Str_CtrlChartTestAppointmentsLoad.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.TestResultsRates_AverageAttemptsToPass))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.testResultsRates_avgAttemptsToPass}");

            if (dashboardAccess.HasFlag(DashboardAccess.RevenueByServiceType))
                _builder.AppendLine($"✓ {Str_CtrlChartRevenueByServiceType.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.RevenueByTestType))
                _builder.AppendLine($"✓ {Str_CtrlChartRevenueByTestType.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.RevenueByLicenseClass))
                _builder.AppendLine($"✓ {Str_CtrlChartRevenueByLicenseClass.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.LicenseDetentionFineFees))
                _builder.AppendLine($"✓ {Str_CtrlChartLicenseDetainFineFees.chartTitle}");

            if (dashboardAccess.HasFlag(DashboardAccess.SystemWideRevenue))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.systemWideRevenue}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(LicenseDetentionManagement licenseDetentionManagement) {
            lbl_noAccess.Visible = licenseDetentionManagement == LicenseDetentionManagement.NoAccess;

            if (licenseDetentionManagement == LicenseDetentionManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (licenseDetentionManagement.HasFlag(LicenseDetentionManagement.ViewAllDetainedLicenses))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.viewAllDetainedLicenses}");
            
            if (licenseDetentionManagement.HasFlag(LicenseDetentionManagement.DetainLicense))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.detainLicense}");

            if (licenseDetentionManagement.HasFlag(LicenseDetentionManagement.ReleaseDetainedLicense))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.releaseDetainedLicense}");

            if (licenseDetentionManagement.HasFlag(LicenseDetentionManagement.ExportDetainedLicensesData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportDetainedLicensesData}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(LicensesManagement licensesManagement) {
            lbl_noAccess.Visible = licensesManagement == LicensesManagement.NoAccess;

            if (licensesManagement == LicensesManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (licensesManagement.HasFlag(LicensesManagement.ViewAllLocalLicenses))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.viewAllLocalLicenses}");

            if (licensesManagement.HasFlag(LicensesManagement.IssueLocalLicenseFirstTime))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.issueLocalLicenseFirstTime}");

            if (licensesManagement.HasFlag(LicensesManagement.IssueLicenseReplacement))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.issueLicenseReplacement}");

            if (licensesManagement.HasFlag(LicensesManagement.RenewLicense))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.renewLicense}");

            if (licensesManagement.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.showFullLocalLicenseInfo}");

            if (licensesManagement.HasFlag(LicensesManagement.ExportLocalLicensesData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportLocalLicensesData}");

            if (licensesManagement.HasFlag(LicensesManagement.ViewAllInterLicenses))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.viewAllInterLicenses}");

            if (licensesManagement.HasFlag(LicensesManagement.ShowFullInterLicenseInfo))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.showFullInterLicenseInfo}");

            if (licensesManagement.HasFlag(LicensesManagement.ExportInterLicensesData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportInterLicensesData}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(Tests_TestAppointsManagement tests_testAppointsManagement) {
            lbl_noAccess.Visible = tests_testAppointsManagement == Tests_TestAppointsManagement.NoAccess;

            if (tests_testAppointsManagement == Tests_TestAppointsManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.visionTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.seeAllAppoints}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Vision_CreateNewAppointment))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.visionTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.createNewAppoint}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.visionTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.updateAppointInfo}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Vision_TakeTest))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.visionTests} {Str_FrmUserPermissions.arrow} {Str_FrmTestAppointments.takeTest}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Vision_ExportAppointmentsdata))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.visionTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.exportAppointsData}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.writtenTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.seeAllAppoints}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Written_CreateNewAppointment))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.writtenTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.createNewAppoint}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Written_UpdateAppointmentInfo))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.writtenTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.updateAppointInfo}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Written_TakeTest))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.writtenTests} {Str_FrmUserPermissions.arrow} {Str_FrmTestAppointments.takeTest}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Written_ExportAppointmentsdata))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.writtenTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.exportAppointsData}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.drivingTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.seeAllAppoints}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Driving_CreateNewAppointment))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.drivingTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.createNewAppoint}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.drivingTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.updateAppointInfo}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Driving_TakeTest))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.drivingTests} {Str_FrmUserPermissions.arrow} {Str_FrmTestAppointments.takeTest}");

            if (tests_testAppointsManagement.HasFlag(Tests_TestAppointsManagement.Driving_ExportAppointmentsdata))
                _builder.AppendLine($"✓ {Str_CtrlChartTestTypesPassRates.drivingTests} {Str_FrmUserPermissions.arrow} {Str_FrmUserPermissions.exportAppointsData}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(InterLicenseAppsManagement interLicenseAppsManagement) {
            lbl_noAccess.Visible = interLicenseAppsManagement == InterLicenseAppsManagement.NoAccess;

            if (interLicenseAppsManagement == InterLicenseAppsManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (interLicenseAppsManagement.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeAllInterLicenseApps}");

            if (interLicenseAppsManagement.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.createNewInterLicenseApp}");

            if (interLicenseAppsManagement.HasFlag(InterLicenseAppsManagement.ExportInterLicenseAppsData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportInterLicenseAppData}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(LocalLicenseAppsManagement localLicenseAppsManagement) {
            lbl_noAccess.Visible = localLicenseAppsManagement == LocalLicenseAppsManagement.NoAccess;

            if (localLicenseAppsManagement == LocalLicenseAppsManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeAllLocalLicenseApps}");

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.CreateNewLocalLicenseApp))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.createNewLocalLicenseApp}");

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.viewFullAppDetails}");

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.ExportLocalLicenseAppsData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportLocalLicenseAppsData}");

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.EditAppInfo))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.editAppInfo}");

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.DeleteApp))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.deleteApp}");

            if (localLicenseAppsManagement.HasFlag(LocalLicenseAppsManagement.CancelApp))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.cancelApp}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(DriversManagement driversManagement) {
            lbl_noAccess.Visible = driversManagement == DriversManagement.NoAccess;

            if (driversManagement == DriversManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (driversManagement.HasFlag(DriversManagement.SeeAllDrivers))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeAllDrivers}");

            if (driversManagement.HasFlag(DriversManagement.ExportDriversData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportDriversData}");

            if (driversManagement.HasFlag(DriversManagement.ShowDriverTestsHistory_Vision))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeDriversVisionTestsHistory}");

            if (driversManagement.HasFlag(DriversManagement.ShowDriverTestsHistory_Written))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeDriverWrittenTestsHistory}");

            if (driversManagement.HasFlag(DriversManagement.ShowDriverTestsHistory_Driving))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeDriverDrivingTestsHistory}");

            if (driversManagement.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeDriverLocalLicensesHistory}");

            if (driversManagement.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeDriverInterLicensesHistory}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(UsersManagement usersManagement) {
            lbl_noAccess.Visible = usersManagement == UsersManagement.NoAccess;

            if (usersManagement == UsersManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (usersManagement.HasFlag(UsersManagement.SeeAllUsers))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeAllUsers}");

            if (usersManagement.HasFlag(UsersManagement.AddNewUser))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.addNewUser}");

            if (usersManagement.HasFlag(UsersManagement.EditUsername))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.editUsername}");

            if (usersManagement.HasFlag(UsersManagement.Activate_DeactiveUsers))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.activate_deactivateUser}");

            if (usersManagement.HasFlag(UsersManagement.ChangeUserPassword))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.changeUserPassword}");

            if (usersManagement.HasFlag(UsersManagement.ChangeUserPermissions))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.changeUserPermissions}");

            if (usersManagement.HasFlag(UsersManagement.DeleteUser))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.deleteUser}");

            if (usersManagement.HasFlag(UsersManagement.ExportUsersData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportUsersData}");

            return _builder.ToString();
        }

        private string _ConstructPermissionsTextDisplay(PeopleManagement peopleManagement) {
            lbl_noAccess.Visible = peopleManagement == PeopleManagement.NoAccess;

            if (peopleManagement == PeopleManagement.FullAccess)
                groupBox1.Text += $" ({Str_FrmUserPermissions.fullAccess})";
            else if (lbl_noAccess.Visible) {
                groupBox1.Text += $" ({Str_FrmUserPermissions.noAccess})";
                return string.Empty;
            }

            var _builder = new StringBuilder();

            if (peopleManagement.HasFlag(PeopleManagement.SeeAllPeople))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seeAllPeople}");

            if (peopleManagement.HasFlag(PeopleManagement.SeePersonalInfoCards))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.seePersonalInfoCards}");

            if (peopleManagement.HasFlag(PeopleManagement.AddNewPerson))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.addNewPerson}");

            if (peopleManagement.HasFlag(PeopleManagement.EditPersonalInfo))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.editPersonalInfo}");

            if (peopleManagement.HasFlag(PeopleManagement.DeletePerson))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.deletePerson}");

            if (peopleManagement.HasFlag(PeopleManagement.SendEmail))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.sendEmail}");

            if (peopleManagement.HasFlag(PeopleManagement.PhoneCall))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.phoneCall}");

            if (peopleManagement.HasFlag(PeopleManagement.ExportPeopleData))
                _builder.AppendLine($"✓ {Str_FrmUserPermissions.exportPeopleData}");

            return _builder.ToString();
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index >= 0) {
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                e.DrawBackground();

                using (var _stringFormat = new StringFormat { Alignment = listBox1.RightToLeft == RightToLeft.Yes ? StringAlignment.Far : StringAlignment.Near, LineAlignment = StringAlignment.Center})
                using (var _brush = new SolidBrush(e.ForeColor))
                    e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), listBox1.Font, e.State == DrawItemState.Selected ? Brushes.White : _brush, e.Bounds, _stringFormat);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
