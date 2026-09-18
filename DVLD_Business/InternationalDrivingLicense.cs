using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business {
    public class InternationalDrivingLicense : License {
        public int InternationalLicenseID { get; private set; } = -1; //By default
        public int IssuedUsingLocalLicenseID { get; set; } = -1; //By default

        public LocalDrivingLicense IssuedUsingLocalLicenseInfo { get => LocalDrivingLicense.Find(IssuedUsingLocalLicenseID); }
        
        public InternationalDrivingLicense() { }

        private InternationalDrivingLicense(int internationalLicenseID, int baseLicenseID, int applicationID, int issuedUsingLocalLicenseID, int driverID, DrivingLicenseIssueReasons issueReason, ref DateTime issueDate, ref DateTime expirationDate, bool isActive, int createdByuserID) : base(baseLicenseID, driverID, applicationID, issueReason, ref issueDate, ref expirationDate, isActive, createdByuserID) {
            InternationalLicenseID = internationalLicenseID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
        }

        public override bool Save() {
            if (!base.Save()) //This will create the base Application record in the Applications table
                return false;

            if (_ActiveMode == Modes.AddNew) {
                if (!_AddNewLicense()) {
                    Delete(BaseLicenseID);
                    
                    return false;
                }

                //De-activating all other licenses:
                InternationalDrivingLicenseDataAccess.DeactivateAllInterLicensesExcept(DriverID, BaseLicenseID);

                _ActiveMode = Modes.Update;
                return true;
            }

            return _UpdateLicense();
        }

        protected new bool _AddNewLicense() => (InternationalLicenseID = InternationalDrivingLicenseDataAccess.AddNewInternationalDrivingLicense(BaseLicenseID, IssuedUsingLocalLicenseID)) != -1;

        protected new bool _UpdateLicense() => InternationalDrivingLicenseDataAccess.UpdateInternationalDrivingLicenseInfo(InternationalLicenseID, BaseLicenseID, IssuedUsingLocalLicenseID);

        public static bool DoesActiveInternationalLicenseExist_ByLocalLicense(int localLicenseID) =>
            InternationalDrivingLicenseDataAccess.DoesActiveInternationalLicenseExist_ByLocalLicense(localLicenseID);

        public static bool DoesExist_ByLocalLicense(int localDrivingLicenseID) =>
            InternationalDrivingLicenseDataAccess.DoesInternationalLicenseExist_ByLocalLicense(localDrivingLicenseID);

        public static DataTable GetPreferredInternationalAppsView() {
            DeactivateAllExpiredLicenses();
            return InternationalDrivingLicenseDataAccess.GetPreferredInternationalAppsView();
        }

        public static DataView GetPreferredInternationalLicensesView(int driverID) {
            DeactivateAllExpiredLicenses();
            return InternationalDrivingLicenseDataAccess.GetPreferredInternationalLicensesView(driverID);
        }

        public static InternationalDrivingLicense Find(int internationalLicenseID) {
            if (internationalLicenseID == -1)
                return null;

            int _baseLicenseID = -1, _driverID = -1, _applicationID = -1, _createdByuserID = -1, _issuedUsingLocalLicenseID = -1;
            byte _issueReason = 0;
            DateTime _issueDate = new DateTime(0), _expirationDate = new DateTime(0);
            bool _isActive = false;

            if (InternationalDrivingLicenseDataAccess.FindInternationalLicenseInfo(internationalLicenseID, ref _baseLicenseID, ref _issuedUsingLocalLicenseID))
                if (FindBaseLicense(_baseLicenseID, ref _driverID, ref _applicationID, ref _issueReason, ref _issueDate, ref _expirationDate, ref _isActive, ref _createdByuserID))
                    return new InternationalDrivingLicense(internationalLicenseID, _baseLicenseID, _applicationID, _issuedUsingLocalLicenseID, _driverID, (DrivingLicenseIssueReasons) _issueReason, ref _issueDate, ref _expirationDate, _isActive, _createdByuserID);

            return null;
        }

        public static int FindActiveLicenseID_ByLocalLicenseID(int localLicenseID) =>
            InternationalDrivingLicenseDataAccess.FindActiveLicenseID_ByLocalLicenseID(localLicenseID);

        public static InternationalDrivingLicense FindActiveLicense_ByLocalLicense(int issuedUsingLocalLicenseID) {
            int _internationalLicenseID = -1, _baseLicenseID = -1, _driverID = -1, _applicationID = -1, _createdByuserID = -1;
            byte _issueReason = 0;
            DateTime _issueDate = new DateTime(0), _expirationDate = new DateTime(0);
            bool _isActive = false;

            if (InternationalDrivingLicenseDataAccess.FindActiveLicenseInfo_ByLocalLicense(issuedUsingLocalLicenseID, ref _internationalLicenseID, ref _baseLicenseID))
                if (FindBaseLicense(_baseLicenseID, ref _driverID, ref _applicationID, ref _issueReason, ref _issueDate, ref _expirationDate, ref _isActive, ref _createdByuserID))
                    return new InternationalDrivingLicense(_internationalLicenseID, _baseLicenseID, _applicationID, issuedUsingLocalLicenseID, _driverID, (DrivingLicenseIssueReasons) _issueReason, ref _issueDate, ref _expirationDate, _isActive, _createdByuserID);

            return null;
        }

        public static InternationalDrivingLicense FindActiveLicense_ByDriverId(int driverID) {
            int _internationalLicenseID = -1, _baseLicenseID = -1, _applicationID = -1, _createdByuserID = -1, _issuedUsingLocalLicenseID = -1;
            byte _issueReason = 0;
            DateTime _issueDate = new DateTime(0), _expirationDate = new DateTime(0);
            bool _isActive = false;

            if (InternationalDrivingLicenseDataAccess.FindActiveLicenseInfo_ByDriverId(driverID, ref _internationalLicenseID, ref _baseLicenseID, ref _issuedUsingLocalLicenseID))
                if (FindBaseLicense(_baseLicenseID, ref driverID, ref _applicationID, ref _issueReason, ref _issueDate, ref _expirationDate, ref _isActive, ref _createdByuserID))
                    return new InternationalDrivingLicense(_internationalLicenseID, _baseLicenseID, _applicationID, _issuedUsingLocalLicenseID, driverID, (DrivingLicenseIssueReasons) _issueReason, ref _issueDate, ref _expirationDate, _isActive, _createdByuserID);

            return null;
        }

        public static DataView GetAllInternationalLicenses() =>
            InternationalDrivingLicenseDataAccess.GetAllInternationalLicenses();
    }
}
