using DVLD_DataAccess;
using System;

namespace DVLD_Business {
    public enum DrivingLicenseIssueReasons : byte {
        FirstTime = 1, ReplacementForLost = 2, ReplacementForDamaged = 3, Renewal = 4
    }

    public abstract class License {
        internal Modes _ActiveMode = Modes.AddNew; //By default

        protected int BaseLicenseID { get; set; } = -1; //By default
        public int DriverID { get; set; } = -1; //By default
        public int ApplicationID { get; set; } = -1; //By default
        public DrivingLicenseIssueReasons IssueReason { get; set; } = DrivingLicenseIssueReasons.FirstTime; //By default
        public DateTime IssueDate { get; set; } = new DateTime(0); //By default
        public DateTime ExpirationDate { get; set; } = new DateTime(0); //By default
        public bool IsActive { get; set; } = false; //By default
        public bool IsDetained { get => LicenseDetentionDataAccess.CheckDetainedLicense(BaseLicenseID); }
        public int CreatedByUserID { get; set; } = -1; //By default

        public Driver DriverInfo { get => Driver.Find(DriverID); }
        public Application ApplicationInfo { get => Application.Find(ApplicationID); }
        public User CreatedByUserInfo { get => User.Find(CreatedByUserID); }

        protected License(int baseLicenseID, int driverID, int applicationID, DrivingLicenseIssueReasons issueReason, ref DateTime issueDate, ref DateTime expirationDate, bool isActive, int createdByUserID) {
            BaseLicenseID = baseLicenseID;
            DriverID = driverID;
            ApplicationID = applicationID;
            IssueReason = issueReason;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;

            _ActiveMode = Modes.Update;
        }

        protected License() { }

        public static bool Delete(int baseLicenseID) => LicenseDataAccess.DeleteLicense(baseLicenseID);

        public virtual bool Save() => _ActiveMode == Modes.AddNew ? _AddNewLicense() : _UpdateLicense();

        protected bool _AddNewLicense() => (BaseLicenseID = LicenseDataAccess.AddNewLicense(DriverID, ApplicationID, (byte) IssueReason, IssueDate, ExpirationDate, IsActive, CreatedByUserID)) != -1;

        protected bool _UpdateLicense() => LicenseDataAccess.UpdateLicenseInfo(BaseLicenseID, DriverID, ApplicationID, (byte) IssueReason, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
    
        protected static bool FindBaseLicense(int baseLicenseID, ref int driverID, ref int applicationID, ref byte issueReason, ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID) =>
            LicenseDataAccess.FindBaseLicenseInfo(baseLicenseID, ref driverID, ref applicationID, ref issueReason, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID);

        public bool CheckIfActive() {
            DateTime _now = DateTime.Now;

            if (IsActive && (_now < IssueDate || _now > ExpirationDate)) {
                LicenseDataAccess.SetLicenseActivity(BaseLicenseID, false);
                return IsActive = false;
            }

            return IsActive;
        }

        public static int DeactivateAllExpiredLicenses() =>
            LicenseDataAccess.DeactivateAllExpiredLicenses();

        public bool Deactivate() {
            bool _originalValue = IsActive;
            IsActive = false;

            if (!LicenseDataAccess.SetLicenseActivity(BaseLicenseID, false)) {
                IsActive = _originalValue;
                return false;
            }

            return true;
        }

        public bool Activate() {
            bool _originalValue = IsActive;
            IsActive = true;

            if (!LicenseDataAccess.SetLicenseActivity(BaseLicenseID, true)) {
                IsActive = _originalValue;
                return false;
            }

            return true;
        }
    }
}
