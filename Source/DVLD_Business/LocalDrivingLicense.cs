using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business {
    public class LocalDrivingLicense : License {
        private LocalDrivingLicense(int localDrivingLicenseID, int baseLicenseID, int driverID, int applicationID, DrivingLicenseIssueReasons issueReason, ref DateTime issueDate, ref DateTime expirationDate, bool isActive, int createdByUserID, LicenseClasses licenseClassID, decimal? licenseClassPaidFees, string notes) : base(baseLicenseID, driverID, applicationID, issueReason, ref issueDate, ref expirationDate, isActive, createdByUserID) {
            LocalDrivingLicenseID = localDrivingLicenseID;
            LicenseClassID = licenseClassID;
            LicenseClassPaidFees = licenseClassPaidFees;
            Notes = notes;
        }

        public LocalDrivingLicense() { }

        public int LocalDrivingLicenseID { get; private set; } = -1; //By default
        public LicenseClasses LicenseClassID { get; set; } = LicenseClasses.Class1_SmallMotorcycleLicense; //By default
        public decimal? LicenseClassPaidFees { get; set; } = 0; //By default
        public string Notes { get; set; } = null; //By default -- This field is NULLable in the database

        public LicenseClass LicenseClassInfo { get => LicenseClass.Find(LicenseClassID); }

        public static bool DoesActiveLicenseExistForPerson(int personID, LicenseClasses licenseClassID) =>
            LocalDrivingLicenseDataAccess.DoesActiveLicenseExistForPerson(personID, (byte) licenseClassID);

        public static LocalDrivingLicense Find(int localDrivingLicenseID) {
            if (localDrivingLicenseID == -1)
                return null;

            int _baseLicenseID = -1, _driverID = -1, _createdByUserID = -1, _applicationID = -1;
            byte _issueReason = 0, _licenseClassID = 0;
            DateTime _issueDate = new DateTime(0), _expirationDate = new DateTime(0);
            bool _isActive = false;
            decimal? _licenseClassPaidFees = 0;
            string _notes = "";

            if (LocalDrivingLicenseDataAccess.FindLocalLicenseInfo(localDrivingLicenseID, ref _baseLicenseID, ref _licenseClassID, ref _licenseClassPaidFees, ref _notes))
                if (FindBaseLicense(_baseLicenseID, ref _driverID, ref _applicationID, ref _issueReason, ref _issueDate, ref _expirationDate, ref _isActive, ref _createdByUserID))
                    return new LocalDrivingLicense(localDrivingLicenseID, _baseLicenseID, _driverID, _applicationID, (DrivingLicenseIssueReasons) _issueReason, ref _issueDate, ref _expirationDate, _isActive, _createdByUserID, (LicenseClasses) _licenseClassID, _licenseClassPaidFees, _notes);

            return null;
        }

        public override bool Save() {
            if (!base.Save())
                return false;

            if (_ActiveMode == Modes.AddNew) {
                if (!_AddNewLicense()) {
                    Delete(BaseLicenseID);
                    return false;
                }

                _ActiveMode = Modes.Update;
                return true;
            }

            return _UpdateLicense();
        }

        protected new bool _AddNewLicense() => (LocalDrivingLicenseID = LocalDrivingLicenseDataAccess.AddNewLocalDrivingLicense(BaseLicenseID, (byte) LicenseClassID, LicenseClassPaidFees, Notes)) != -1;

        protected new bool _UpdateLicense() => LocalDrivingLicenseDataAccess.UpdateLocalDrivingLicenseInfo(LocalDrivingLicenseID, BaseLicenseID, (byte) LicenseClassID, LicenseClassPaidFees, Notes);

        public static int FindLocalLicenseID_ByLocalDrivingLicenseAppID(int localDrivingLicenseAppID, LicenseClasses licenseClassID) =>
            LocalDrivingLicenseDataAccess.FindLicenseID_ByLocalDrivingLicenseAppID(localDrivingLicenseAppID, (byte) licenseClassID);

        public static DataView GetPreferredLocalLicensesView(int driverID, SupportedLanguages language) {
            DeactivateAllExpiredLicenses();
            return language == SupportedLanguages.Arabic ? LocalDrivingLicenseDataAccess.GetPreferredLocalLicensesView_Arabic(driverID) : LocalDrivingLicenseDataAccess.GetPreferredLocalLicensesView_Default(driverID);
        }

        public static bool DoesLicenseExistForPerson(int personID, LicenseClasses licenseClassID) =>
            LocalDrivingLicenseDataAccess.DoesLicenseExistForPerson(personID, (byte) licenseClassID);

        public static bool CheckIfActive(int localDrivingLicenseID) =>
            LocalDrivingLicenseDataAccess.CheckIfLicenseActive(localDrivingLicenseID);

        public static LicenseClasses FindLicenseClass(int localDrivingLienseID) =>
            (LicenseClasses) LocalDrivingLicenseDataAccess.FindLicenseClass(localDrivingLienseID);

        public static int FindActiveIdByDriverId(int driverID, LicenseClasses licenseClass) =>
            LocalDrivingLicenseDataAccess.FindActiveLicenseIdByDriverId(driverID, (byte) licenseClass);

        public static bool DoesDriverOwnActiveLocalLicenseOfClass(int driverID, LicenseClasses licenseClassID) =>
            LocalDrivingLicenseDataAccess.DoesDriverOwnActiveLocalLicenseOfClass(driverID, (byte) licenseClassID);

        public LocalDrivingLicense RenewLicense(int activeUserID, DateTime desiredApplicationDate, string notes) {
            if (CheckIfActive())
                throw new InvalidOperationException("Cannot use this object to renew a license because it's active");

            Application _renewApplication = new Application {
                ApplicantPersonID = DriverInfo.PersonID,
                ApplicationDate = desiredApplicationDate,
                ApplicationStatus = ApplicationStatus.Completed,
                ApplicationTypeID = ApplicationTypes.RenewLicense,
                CreatedByUserID = activeUserID,
                FeesPaid = ApplicationType.GetFees(ApplicationTypes.RenewLicense),
                UpdateStatusDate = desiredApplicationDate
            };

            if (!_renewApplication.Save())
                return null;

            DateTime _now = DateTime.Now;

            LocalDrivingLicense _newLicense = new LocalDrivingLicense {
                CreatedByUserID = activeUserID,
                DriverID = DriverID,
                ApplicationID = _renewApplication.BaseApplicationID,
                IssueDate = _now,
                ExpirationDate = _now.AddYears(LicenseClassInfo.DefaultValidityLength),
                IsActive = true,
                IssueReason = DrivingLicenseIssueReasons.Renewal,
                LicenseClassID = LicenseClassID,
                LicenseClassPaidFees = null,
                Notes = notes
            };

            if (!_newLicense.Save()) {
                Application.Delete(_renewApplication.BaseApplicationID);
                return null;
            }

            return _newLicense;
        }

        public LocalDrivingLicense IssueReplacement(int activeUserID, DateTime _desiredApplicationDate, DrivingLicenseIssueReasons issueReason) {
            if (!CheckIfActive())
                throw new InvalidOperationException("Cannot use this object to issue a replacement because it's not active.");

            ApplicationTypes _applicationTypeID = issueReason == DrivingLicenseIssueReasons.ReplacementForLost ? ApplicationTypes.ReplacementForLostLicense : ApplicationTypes.ReplacementForDamagedLicense;

            Application _replacementApp = new Application {
                ApplicantPersonID = DriverInfo.PersonID,
                ApplicationDate = _desiredApplicationDate,
                ApplicationStatus = ApplicationStatus.Completed,
                ApplicationTypeID = _applicationTypeID,
                CreatedByUserID = activeUserID,
                FeesPaid = ApplicationType.GetFees(_applicationTypeID),
                UpdateStatusDate = _desiredApplicationDate
            };

            if (!_replacementApp.Save())
                return null;

            LocalDrivingLicense _newLicense = new LocalDrivingLicense {
                ApplicationID = _replacementApp.BaseApplicationID,
                CreatedByUserID = activeUserID,
                DriverID = DriverID,
                IssueDate = DateTime.Now,
                ExpirationDate = ExpirationDate,
                IsActive = true,
                IssueReason = issueReason,
                LicenseClassID = LicenseClassID,
                LicenseClassPaidFees = null,
                Notes = Notes
            };

            if (_newLicense.Save()) {
                Deactivate();
                return _newLicense;
            }

            Application.Delete(_replacementApp.BaseApplicationID);
            return null;
        }

        public static DataView GetAllLocalLicenses(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? LocalDrivingLicenseDataAccess.GetAllLocalLicenses_AR() : LocalDrivingLicenseDataAccess.GetAllLocalLicenses_Default();

        public static int GetBaseLicenseID(int localDrivingLicenseID) =>
            LocalDrivingLicenseDataAccess.FindBaseLicenseID(localDrivingLicenseID);

        public static int GetLocalLicenseID(int baseLicenseID) =>
            LocalDrivingLicenseDataAccess.FindLocalLicenseID(baseLicenseID);

        public static int FindDriverId(int localDrivingLicenseID) =>
            LocalDrivingLicenseDataAccess.FindDriverId(localDrivingLicenseID);

        public static int FindPersonId(int localDrivingLicenseID) =>
            LocalDrivingLicenseDataAccess.FindPersonId(localDrivingLicenseID);

        public static decimal GetClassPaidFeesByApplication(int baseApplicationID) =>
            LocalDrivingLicenseDataAccess.GetClassPaidFeesByApplication(baseApplicationID);
    }
}
