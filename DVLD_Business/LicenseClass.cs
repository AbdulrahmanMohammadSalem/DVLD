using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business {
    public enum LicenseClasses : byte {
        Class1_SmallMotorcycleLicense = 1, Class2_HeavyMotorcycleLicense = 2,
        Class3_OrdinaryDrivingLicense = 3, Class4_CommercialDrivingLicense = 4,
        Class5_AgriculturalDrivingLicense = 5, Class6_SmallAndMediumBusLicense = 6,
        Class7_TruckAndHeavyVehicleLicense = 7
    }

    public class LicenseClass {
        private LicenseClass(LicenseClasses licenseClassID, ref string className, ref string classNameAR, ref string classDescription, ref string classDescriptionAR, byte minimumAllowedAge, byte defaultValidityLength, ref decimal classFees) {
            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassNameAR = classNameAR;
            ClassDescription = classDescription;
            ClassDescriptionAR = classDescriptionAR;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
        }

        public LicenseClasses LicenseClassID { get; } = LicenseClasses.Class1_SmallMotorcycleLicense; //By default
        public string ClassName { get; } = null; //By default
        public string ClassNameAR { get; } = null; //By default
        public string ClassDescription { get; } = null; //By default
        public string ClassDescriptionAR { get; } = null; //By default
        public byte MinimumAllowedAge { get; set; } = 0; //By default
        public byte DefaultValidityLength { get; set; } = 0; //By default
        public decimal ClassFees { get; set; } = 0; //By default

        public static string[] GetAllLicenseClassNames(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? LicenseClassDataAccess.GetAllLicenseClassNames_Arabic() : LicenseClassDataAccess.GetAllLicenseClassNames_Default();

        public static LicenseClass Find(LicenseClasses licenseClassID) {
            string _className = "", _classNameAR = "", _classDescription = "", _classDescriptionAR = "";
            byte _minimumAllowedAge = 0, _defaultValidityLength = 0;
            decimal _classFees = 0;

            if (LicenseClassDataAccess.FindLicenseClass((byte) licenseClassID, ref _className, ref _classNameAR, ref _classDescription, ref _classDescriptionAR, ref _minimumAllowedAge, ref _defaultValidityLength, ref _classFees))
                return new LicenseClass(licenseClassID, ref _className, ref _classNameAR, ref _classDescription, ref _classDescriptionAR, _minimumAllowedAge, _defaultValidityLength, ref _classFees);

            return null;
        }

        public static DataView GetAllLicenseClasses(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? LicenseClassDataAccess.GetAllLicenseClasses_Arabic() : LicenseClassDataAccess.GetAllLicenseClasses_Default();

        public bool Save() => LicenseClassDataAccess.UpdateLicenseClassData((byte) LicenseClassID, MinimumAllowedAge, DefaultValidityLength, ClassFees);

        public string GetClassName(SupportedLanguages language) => language == SupportedLanguages.Arabic ? ClassNameAR : ClassName;

        public static decimal GetFees(LicenseClasses licenseClassID) => LicenseClassDataAccess.GetClassFees((byte) licenseClassID);

        public static class Charting {
            public static DataView GetAllTimeLicenseClassesRevenues() => LicenseClassDataAccess.Charting.GetAllTimeLicenseClassesRevenues();

            public static DataView GetPerMonthLicenseClassesRevenues(short year, SupportedLanguages language) => LicenseClassDataAccess.Charting.GetPerMonthLicenseClassesRevenues(year, language == SupportedLanguages.Arabic);
        }
    }
}
