using DVLD_DataAccess;
using System;
using System.Data;
using System.Net.NetworkInformation;

namespace DVLD_Business {
    public enum ApplicationStatus : byte {
        Unknown = 0, New = 1, Completed = 2, Cancelled = 3
    }

    public enum ApplicationTypes : byte {
        NewLocalLicense = 1, RenewLicense, ReplacementForLostLicense, ReplacementForDamagedLicense,
        ReleaseDetainedLicense, NewInternationLicense, RetakeFailedTest
    }

    public class Application {
        internal Modes _ActiveMode = Modes.AddNew;

        protected Application(int applicationID, int applicantPersonID, ApplicationTypes applicationTypeID, ref DateTime applicationDate, ApplicationStatus applicationStatus, ref DateTime? updateStatusDate, ref decimal feesPaid, int createdByUserID) {
            BaseApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationTypeID = applicationTypeID;
            ApplicationDate = applicationDate;
            ApplicationStatus = applicationStatus;
            UpdateStatusDate = updateStatusDate;
            FeesPaid = feesPaid;
            CreatedByUserID = createdByUserID;

            _ActiveMode = Modes.Update;
        }

        public Application() { }

        public int BaseApplicationID { get; private set; } = -1; //By default
        public int ApplicantPersonID { get; set; } = -1; //By default
        public ApplicationTypes ApplicationTypeID { get; set; }
        public DateTime ApplicationDate { get; set; } = new DateTime(0); //By default
        public ApplicationStatus ApplicationStatus { get; set; } = ApplicationStatus.New; //By default
        public DateTime? UpdateStatusDate { get; set; } = null; //By default
        public decimal FeesPaid { get; set; } = 0; //By default
        public int CreatedByUserID { get; set; } = -1; //By default

        public Person ApplicantInfo { get => Person.Find(ApplicantPersonID); }
        public ApplicationType ApplicationTypeInfo { get => ApplicationType.Find(ApplicationTypeID); }
        public User CreatedByUserInfo { get => User.Find(CreatedByUserID); }

        public virtual bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewApplication()) {
                    _ActiveMode = Modes.Update;
                    return true;
                }

                return false;
            }

            return _UpdateApplication();
        }

        private bool _UpdateApplication() => ApplicationDataAccess.UpdateApplicationInfo(BaseApplicationID, (byte) ApplicationStatus, UpdateStatusDate);

        private bool _AddNewApplication() => (BaseApplicationID = ApplicationDataAccess.AddNewApplication(ApplicantPersonID, (byte) ApplicationTypeID, ApplicationDate, (byte) ApplicationStatus, UpdateStatusDate, FeesPaid, CreatedByUserID)) != -1;

        public static bool Delete(int applicationID) =>
            ApplicationDataAccess.DeleteApplication(applicationID);

        public static Application Find(int applicationID) {
            int _applicantPersonID = -1, _createdByUserID = -1;
            byte _applicationTypeID = 0, _applicationStatus = 0;
            DateTime _applicationDate = new DateTime(0);
            DateTime? _UpdateStatusDate = null;
            decimal _feesPaid = 0;

            if (ApplicationDataAccess.FindApplication(applicationID, ref _applicantPersonID, ref _createdByUserID, ref _applicationTypeID, ref _applicationStatus, ref _applicationDate, ref _UpdateStatusDate, ref _feesPaid))
                return new Application(applicationID, _applicantPersonID, (ApplicationTypes) _applicationTypeID, ref _applicationDate, (ApplicationStatus) _applicationStatus, ref _UpdateStatusDate, ref _feesPaid, _createdByUserID);

            return null;
        }

        public static DataTable GetAllApplications(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? ApplicationDataAccess.GetAllApplications_Arabic() : ApplicationDataAccess.GetAllApplications_Default();

        /// <summary>
        /// This will clear the StatusUpdateDate from the record concerned
        /// </summary>
        public bool MakeNew() {
            if (ApplicationStatus == ApplicationStatus.New)
                return true;

            if (ApplicationDataAccess.UpdateApplicationStatus(BaseApplicationID, (byte) ApplicationStatus.New)) {
                ApplicationStatus = ApplicationStatus.New;
                return true;
            }

            return false;
        }

        public bool MakeCancelled() {
            if (ApplicationStatus == ApplicationStatus.Cancelled)
                return true;

            if (ApplicationDataAccess.UpdateApplicationStatus(BaseApplicationID, (byte) ApplicationStatus.Cancelled)) {
                ApplicationStatus = ApplicationStatus.Cancelled;
                return true;
            }

            return false;
        }

        public bool MakeCompleted() {
            if (ApplicationStatus == ApplicationStatus.Completed)
                return true;

            if (ApplicationDataAccess.UpdateApplicationStatus(BaseApplicationID, (byte) ApplicationStatus.Completed)) {
                ApplicationStatus = ApplicationStatus.Completed;
                return true;
            }

            return false;
        }

        public static bool UpdateStatus(int baseApplicationID, ApplicationStatus newStatus) =>
            ApplicationDataAccess.UpdateApplicationStatus(baseApplicationID, (byte) newStatus);

        public InternationalDrivingLicense IssueNewInternationalLicense(int localDrivingLicenseID) {
            if (ApplicationTypeID != ApplicationTypes.NewInternationLicense)
                throw new InvalidOperationException("Cannot use this object to issue a new international license.");

            InternationalDrivingLicense _newInternationaLicense = new InternationalDrivingLicense() {
                ApplicationID = BaseApplicationID,
                CreatedByUserID = CreatedByUserID,
                DriverID = Driver.FindIdByPersonId(ApplicantPersonID),
                ExpirationDate = LocalDrivingLicense.Find(localDrivingLicenseID).ExpirationDate,
                IsActive = true,
                IssueDate = DateTime.Now,
                IssuedUsingLocalLicenseID = localDrivingLicenseID,
                IssueReason = DrivingLicenseIssueReasons.FirstTime
            };

            return _newInternationaLicense.Save() ? _newInternationaLicense : null;
        }

        public static class Charting {
            public static short GetHighestAppYear() => ApplicationDataAccess.Charting.GetHighestApplicationYear();

            public static short GetOldestAppYear() => ApplicationDataAccess.Charting.GetOldestApplicationYear();
            
            public static DataView GetAppTypesPerMonths(short year, ApplicationStatus appStatus, SupportedLanguages language) => ApplicationDataAccess.Charting.GetApplicationTypesPerMonths(year, (byte) appStatus, language == SupportedLanguages.Arabic);

            public static DataView GetOverallAppsPerMonths(short year, ApplicationStatus appStatus, SupportedLanguages language) => ApplicationDataAccess.Charting.GetOverallApplicationsPerMonths(year, (byte) appStatus, language == SupportedLanguages.Arabic);

            public static DataView GetAppTypesPerDays(short year, byte month, ApplicationStatus appStatus) => ApplicationDataAccess.Charting.GetApplicationTypesPerDays(year, month, (byte) appStatus);

            public static DataView GetOverallAppsPerDays(short year, byte month, ApplicationStatus appStatus) => ApplicationDataAccess.Charting.GetOverallApplicationsPerDays(year, month, (byte) appStatus);

            public static DataView GetTotalAppsAllTime() => ApplicationDataAccess.Charting.GetTotalApplicationsAllTime();

            public static DataView GetTotalAppStatusPerMonths(short year, SupportedLanguages language) => ApplicationDataAccess.Charting.GetTotalApplicationStatusPerMonths(year, language == SupportedLanguages.Arabic);

            public static DataView GetTotalAppStatusAllTime() => ApplicationDataAccess.Charting.GetTotalApplicationStatusAllTime();

            public static object GetLocalLicenseApps(short year, byte month) => ApplicationDataAccess.Charting.GetLocalLicenseApplications(year, month);

            public static DataView GetPerMonthApplicationTypesRevenues(short year, SupportedLanguages language) => ApplicationDataAccess.Charting.GetPerMonthApplicationTypesRevenues(year, language == SupportedLanguages.Arabic);

            public static DataView GetAllTimeApplicationTypesRevenues() => ApplicationDataAccess.Charting.GetAllTimeApplicationTypesRevenues();
        }
    }

}
