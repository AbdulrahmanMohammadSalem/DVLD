using DVLD_DataAccess;

namespace DVLD_Business {
    public sealed class Country {
        public int CountryID { get; }
        public string CountryName { get; }
        public string CountryNameAR { get; }

        private Country(int countryID, ref string countryName, ref string countryNameAR) {
            CountryID = countryID;
            CountryName = countryName;
            CountryNameAR = countryNameAR;
        }

        public static Country Find(int countryID) {
            if (countryID == -1)
                return null;

            string countryName = string.Empty, countryNameAR = string.Empty;

            if (CountryDataAccess.FindById(countryID, ref countryName, ref countryNameAR))
                return new Country(countryID, ref countryName, ref countryNameAR);

            return null;
        }

        public static Country FindByDefaultName(string countryName) {
            int countryID = -1;
            string countryNameAR = string.Empty;

            if (CountryDataAccess.FindByDefaultName(countryName, ref countryID, ref countryNameAR))
                return new Country(countryID, ref countryName, ref countryNameAR);

            return null;
        }

        public static Country FindByArabicName(string countryNameAR) {
            int countryID = -1;
            string countryName = string.Empty;

            if (CountryDataAccess.FindByArabicName(countryNameAR, ref countryID, ref countryName))
                return new Country(countryID, ref countryName, ref countryNameAR);

            return null;
        }

        public static string[] GetAllCountryNames(SupportedLanguages language) =>
             language == SupportedLanguages.Arabic ? CountryDataAccess.GetAllCountryArabicNames() : CountryDataAccess.GetAllCountryDefaultNames();
    }
}
