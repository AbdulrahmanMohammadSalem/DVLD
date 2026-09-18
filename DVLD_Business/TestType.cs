using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business {
    public enum TestTypes : byte {
        Unknown = 0, VisionTest = 1, WrittenTest = 2, DrivingTest = 3
    }

    public class TestType {
        private TestType(TestTypes testTypeID, ref string title, ref string titleAR, ref string description, ref string descriptionAR, ref decimal fees) {
            ID = testTypeID;
            Title = title;
            TitleAR = titleAR;
            Description = description;
            DescriptionAR = descriptionAR;
            Fees = fees;
        }

        public TestTypes ID { get; set; } = TestTypes.VisionTest; //By default
        public string Title { get; } = null; //By default
        public string TitleAR { get; } = null; //By default
        public string Description { get; } = null; //By default
        public string DescriptionAR { get; } = null; //By default
        public decimal Fees { get; set; } = 0;

        public static TestType Find(TestTypes testTypeID) {
            string _title = "", _titleAR = "", _description = "", _descriptionAR = "";
            decimal _fees = 0;

            if (TestTypeDataAccess.FindTestType((byte) testTypeID, ref _title, ref _titleAR, ref _description, ref _descriptionAR, ref _fees))
                return new TestType(testTypeID, ref _title, ref _titleAR, ref _description, ref _descriptionAR, ref _fees);

            return null;
        }

        public bool Save() => TestTypeDataAccess.UpdateTestTypeFees((byte) ID, Fees);
        
        public static DataView GetAllTestTypes(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? TestTypeDataAccess.GetAllTestTypes_Arabic() : TestTypeDataAccess.GetAllTestTypes_Default();
        
        public static decimal GetFees(TestTypes testTypeID) =>
            TestTypeDataAccess.GetTestTypeFees((byte) testTypeID);

        public string GetTitle(SupportedLanguages language) => language == SupportedLanguages.Arabic ? TitleAR : Title;

        public static string[] GetTestTypeTitles(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? TestTypeDataAccess.GetTestTypeTitles_Arabic() : TestTypeDataAccess.GetTestTypeTitles_Default();

        public static class Charting {
            public static DataView GetAllTimeTestTypesRevenues() => TestTypeDataAccess.Charting.GetAllTimeTestTypesRevenues();

            public static DataView GetPerMonthTestTypesRevenues(short year, SupportedLanguages language) => TestTypeDataAccess.Charting.GetPerMonthTestTypesRevenues(year, language == SupportedLanguages.Arabic);
        }
    }
}
