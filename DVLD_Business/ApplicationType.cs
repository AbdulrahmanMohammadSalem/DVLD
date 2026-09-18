using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business {
    public class ApplicationType {
        public ApplicationTypes ID { get; private set; }
        public string Title { get; } = null; //By default
        public string TitleAR { get; } = null; //By default
        public decimal Fees { get; set; } = 0; //By default

        private ApplicationType(ApplicationTypes applicationTypeID, ref string applicationTypeTitle, ref string applicationTypeTitleAR, ref decimal applicationTypeFees) {
            ID = applicationTypeID;
            Title = applicationTypeTitle;
            TitleAR = applicationTypeTitleAR;
            Fees = applicationTypeFees;
        }

        public static DataView GetAllApplicationTypes(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? ApplicationTypeDataAccess.GetAllApplicationTypes_Arabic() : ApplicationTypeDataAccess.GetAllApplicationTypes_Default();

        public static ApplicationType Find(ApplicationTypes applicationTypeID) {
            string _title = "", _titleAR = "";
            decimal _fees = 0;

            if (ApplicationTypeDataAccess.FindApplicationType((int) applicationTypeID, ref _title, ref _titleAR, ref _fees))
                return new ApplicationType(applicationTypeID, ref _title, ref _titleAR, ref _fees);

            return null;
        }

        public bool Save() => ApplicationTypeDataAccess.UpdateApplicationTypeFees((int) ID, Fees);

        public string GetTitle(SupportedLanguages language) => language == SupportedLanguages.Arabic ? TitleAR : Title;

        public static string[] GetTypeTitles(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? ApplicationTypeDataAccess.GetTypeTitles_AR() : ApplicationTypeDataAccess.GetTypeTitles_Default();

        public static decimal GetFees(ApplicationTypes applicationTypeID) =>
            ApplicationTypeDataAccess.GetApplicationTypeFees((byte) applicationTypeID);
    }
}
