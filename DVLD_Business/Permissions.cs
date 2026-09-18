using DVLD_DataAccess;
using System;

namespace DVLD_Business {
    public class Permissions {
        [Flags]
        public enum PeopleManagement : short {
            SeeAllPeople = 1,
            /// <summary>
            /// This includes showing the full data of drivers and users.
            /// </summary>
            SeePersonalInfoCards = 2, 
            AddNewPerson = 4,
            EditPersonalInfo = 8,
	        DeletePerson = 16, 
            SendEmail = 32, 
            PhoneCall = 64, 
            ExportPeopleData = 128,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum UsersManagement : short {
            SeeAllUsers = 1,
            AddNewUser = 2,
            EditUsername = 4,
            Activate_DeactiveUsers = 8,
            ChangeUserPassword = 16,
            SeeUserPermissions = 32,
            ChangeUserPermissions = 64,
            DeleteUser = 128,
            ExportUsersData = 256,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum DriversManagement : sbyte {
            SeeAllDrivers = 1,
            ShowDriverLicenseHistory_Local = 2,
            ShowDriverLicenseHistory_Inter = 4,
            ShowDriverTestsHistory_Vision = 8,
            ShowDriverTestsHistory_Written = 16,
            ShowDriverTestsHistory_Driving = 32,
            ExportDriversData = 64,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum LocalLicenseAppsManagement : sbyte {
            SeeAllLocalLicenseApps = 1,
            CreateNewLocalLicenseApp = 2,
            ViewFullAppDetails = 4,
            EditAppInfo = 8,
            DeleteApp = 16,
            CancelApp = 32,
            ExportLocalLicenseAppsData = 64,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum InterLicenseAppsManagement : sbyte {
            SeeAllInterLicenseApps = 1,
            CreateNewInterLicenseApp_IssueInterLicense = 2,
            ExportInterLicenseAppsData = 4,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum Tests_TestAppointsManagement : int {
            Vision_SeeAllAppointments = 1,
            Vision_ExportAppointmentsdata = 2,
            Vision_CreateNewAppointment = 4,
            Vision_UpdateAppointmentInfo = 8,
            Vision_TakeTest = 16,
            Vision_SeeTestResult = 32,
            Written_SeeAllAppointments = 64,
            Written_ExportAppointmentsdata = 128,
            Written_CreateNewAppointment = 256,
            Written_UpdateAppointmentInfo = 512,
            Written_TakeTest = 1024,
            Written_SeeTestResult = 2048,
            Driving_SeeAllAppointments = 4096,
            Driving_ExportAppointmentsdata = 8192,
            Driving_CreateNewAppointment = 16384,
            Driving_UpdateAppointmentInfo = 32768,
            Driving_TakeTest = 65536,
            Driving_SeeTestResult = 131072,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum LicensesManagement : short {
            ViewAllLocalLicenses = 1,
            IssueLocalLicenseFirstTime = 2,
            IssueLicenseReplacement = 4,
            RenewLicense = 8,
            ShowFullLocalLicenseInfo = 16,
            ExportLocalLicensesData = 32,
            ViewAllInterLicenses = 64,
            ShowFullInterLicenseInfo = 128,
            ExportInterLicensesData = 256,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum LicenseDetentionManagement : sbyte {
            ViewAllDetainedLicenses = 1,
            DetainLicense = 2,
            ReleaseDetainedLicense = 4,
            ExportDetainedLicensesData = 8,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum LookupTablesManagement : short {
            ApplicationTypes_ViewAllData = 1,
            ApplicationTypes_ViewUpdateData = 2,
            ApplicationTypes_ExportData = 4,
            TestTypes_ViewAllData = 8,
            TestTypes_ViewUpdateData = 16,
            TestTypes_ExportData = 32,
            LicenseClasses_ViewAllData = 64,
            LicenseClasses_ViewUpdateData = 128,
            LicenseClasses_ExportData = 256,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum ApplicationSettingsAccess : sbyte {
            ChangeLanguage = 1,
            ChangeColorMode = 2,
            ChangeTheme = 4,
            /// <summary>
            /// This includes both branching and creating from scratch.
            /// </summary>
            CreateNewTheme = 8,
            EditThemeValues = 16,
            RenameTheme = 32,
            DeleteTheme = 64,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum DashboardAccess : short {
            TotalApplicationsOverTime = 1,
            LocalLicenseApplicationsStatus = 2,
            TestAppointmentsLoad = 4,
            TestResultsRates_AverageAttemptsToPass = 8,
            RevenueByServiceType = 16,
            RevenueByTestType = 32,
            RevenueByLicenseClass = 64,
            LicenseDetentionFineFees = 128,
            SystemWideRevenue = 256,
            NoAccess = 0, FullAccess = -1
        }

        [Flags]
        public enum ReportsAccess : sbyte {
            PersonHistoryReport = 1,
            LocalLicenseApplicationDetailsReport = 2,
            DriverProfileReport = 4,
            TestAttemptsReport = 8,
            LicenseDetentionReport = 16,
            UserActivityReport = 32,
            NoAccess = 0, FullAccess = -1
        }

        public Permissions() { }

        private Permissions(int permissionsID, PeopleManagement people, UsersManagement users, DriversManagement drivers, LocalLicenseAppsManagement localDrivingLicenseApplications, InterLicenseAppsManagement internationalDrivingLicenseApplications, Tests_TestAppointsManagement tests_TestAppoints, LicenseDetentionManagement licenseDetention, LicensesManagement licenses, LookupTablesManagement lookupTables, ApplicationSettingsAccess applicationSettings, DashboardAccess dashboard, ReportsAccess reports) {
            PermissionsID = permissionsID;
            People = people;
            Users = users;
            Drivers = drivers;
            LocalLicenseApps = localDrivingLicenseApplications;
            InterLicenseApps = internationalDrivingLicenseApplications;
            Tests_TestAppoints = tests_TestAppoints;
            LicenseDetention = licenseDetention;
            Licenses = licenses;
            LookupTables = lookupTables;
            ApplicationSettings = applicationSettings;
            Dashboard = dashboard;
            Reports = reports;

            _ActiveMode = Modes.Update;
        }

        private Modes _ActiveMode = Modes.AddNew; //By default

        public int PermissionsID { get; private set; }
        public PeopleManagement People { get; set; } = PeopleManagement.NoAccess; //By default
        public UsersManagement Users { get; set; } = UsersManagement.NoAccess; //By default
        public DriversManagement Drivers { get; set; } = DriversManagement.NoAccess; //By default
        public LocalLicenseAppsManagement LocalLicenseApps { get; set; } = LocalLicenseAppsManagement.NoAccess; //By default
        public InterLicenseAppsManagement InterLicenseApps { get; set; } = InterLicenseAppsManagement.NoAccess; //By default
        public Tests_TestAppointsManagement Tests_TestAppoints { get; set; } = Tests_TestAppointsManagement.NoAccess; //By default
        public LicensesManagement Licenses { get; set; } = LicensesManagement.NoAccess; //By default
        public LicenseDetentionManagement LicenseDetention { get; set; } = LicenseDetentionManagement.NoAccess; //By default
        public LookupTablesManagement LookupTables { get; set; } = LookupTablesManagement.NoAccess; //By default
        public ApplicationSettingsAccess ApplicationSettings { get; set; } = ApplicationSettingsAccess.NoAccess; //By default
        public DashboardAccess Dashboard { get; set; } = DashboardAccess.NoAccess; //By default
        public ReportsAccess Reports { get; set; } = ReportsAccess.NoAccess; //By default

        public static Permissions Find(int permissionsID) {
            short _peopleManagement = 0, _userManagement = 0, _licensesManagement = 0, _dashboardAccess = 0, _lookupTablesManagement = 0;
            sbyte _driverManagement = 0, _localLicenseAppsManagement = 0, _interLicenseAppsManagement = 0, _licenseDetentionManagement = 0, _applicationSettingsAccess = 0, _reportsAccess = 0;
            int _tests_testAppointsManagement = 0;

            if (PermissionsDataAccess.FindPermissionsInfo(permissionsID, ref _peopleManagement, ref _userManagement, ref _driverManagement, ref _localLicenseAppsManagement, ref _interLicenseAppsManagement, ref _tests_testAppointsManagement, ref _licenseDetentionManagement, ref _licensesManagement, ref _lookupTablesManagement, ref _applicationSettingsAccess, ref _dashboardAccess, ref _reportsAccess))
                return new Permissions(permissionsID, (PeopleManagement) _peopleManagement, (UsersManagement) _userManagement, (DriversManagement) _driverManagement, (LocalLicenseAppsManagement) _localLicenseAppsManagement, (InterLicenseAppsManagement) _interLicenseAppsManagement, (Tests_TestAppointsManagement) _tests_testAppointsManagement, (LicenseDetentionManagement) _licenseDetentionManagement, (LicensesManagement) _licensesManagement, (LookupTablesManagement) _lookupTablesManagement, (ApplicationSettingsAccess) _applicationSettingsAccess, (DashboardAccess) _dashboardAccess, (ReportsAccess) _reportsAccess);
            
            return null;
        }

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewPermissions()) {
                    _ActiveMode = Modes.Update;
                    return true;
                }

                return false;
            }

            return _UpdatePermissions();
        }

        private bool _UpdatePermissions() => PermissionsDataAccess.UpdatePermissionsInfo(PermissionsID, (short) People, (short) Users, (sbyte) Drivers, (sbyte) LocalLicenseApps, (sbyte) InterLicenseApps, (int) Tests_TestAppoints, (sbyte) Licenses, (sbyte) LicenseDetention, (short) LookupTables, (sbyte) ApplicationSettings, (short) Dashboard, (sbyte) Reports);

        private bool _AddNewPermissions() => (PermissionsID = PermissionsDataAccess.AddNewPermissions((short) People, (short) Users, (sbyte) Drivers, (sbyte) LocalLicenseApps, (sbyte) InterLicenseApps, (int) Tests_TestAppoints, (sbyte) Licenses, (sbyte) LicenseDetention, (short) LookupTables, (sbyte) ApplicationSettings, (short) Dashboard, (sbyte) Reports)) != -1;

        public static bool Delete(int permissionsID) =>
            PermissionsDataAccess.DeletePermissions(permissionsID);

        public Permissions Clone() => new Permissions(PermissionsID, People, Users, Drivers, LocalLicenseApps, InterLicenseApps, Tests_TestAppoints, LicenseDetention, Licenses, LookupTables, ApplicationSettings, Dashboard, Reports);

        public bool DeepEquals(Permissions other) => People == other.People && Users == other.Users && Drivers == other.Drivers && LocalLicenseApps == other.LocalLicenseApps && InterLicenseApps == other.InterLicenseApps && Tests_TestAppoints == other.Tests_TestAppoints && Licenses == other.Licenses && LicenseDetention == other.LicenseDetention && LookupTables == other.LookupTables && ApplicationSettings == other.ApplicationSettings && Dashboard == other.Dashboard && Reports == other.Reports;
    }
}
