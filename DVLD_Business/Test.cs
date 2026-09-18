using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business {
    /// <summary>
    /// This type only supports AddNew mode due to not being allowed to update it based on the requirements.
    /// </summary>
    public class Test {
        private Test(int testID, int testAppointmentID, bool testResults, ref string notes, int createdByUserID) {
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResults = testResults;
            Notes = notes;
            CreatedByUserID = createdByUserID;
        }
        public Test() { }

        public int TestID { get; private set; } = -1; //By default
        public int TestAppointmentID { get; set; } = -1; //By default
        public bool TestResults { get; set; } = false; //By default
        public string Notes { get; set; } = null;
        public int CreatedByUserID { get; set; } = -1;

        public TestAppointment TestAppointmentInfo { get => TestAppointment.Find(TestAppointmentID); }
        public User CreatedByUserInfo { get => User.Find(CreatedByUserID); }

        /// <summary>
        /// Checks whether a person has passed a certain test type within a certain application.
        /// </summary>
        public static bool CheckForPassedTest(int localDrivingLicenseAppID, TestTypes testType) =>
            TestDataAccess.CheckForPassedTest(localDrivingLicenseAppID, (byte) testType);

        /// <summary>
        /// This type only supports AddNew mode due to not being allowed to update it based on the requirements.
        /// </summary>
        /// <returns>A boolean indicating whether the saving succeeded or not.</returns>
        public bool Save() {
            //Inserting the new Test record:
            TestID = TestDataAccess.AddNewTest(TestAppointmentID, TestResults, Notes, CreatedByUserID);

            if (TestID == -1)
                return false;

            //Locking the underlaying Appointment record:
            if (!TestAppointment.LockAppointment(TestAppointmentID)) {
                TestDataAccess.DeleteTest(TestID);
                return false;
            }

            return true;
        }

        public static Test FindByAppointment(int testAppointmentID) {
            if (testAppointmentID == -1)
                return null;

            int _testID = -1, _createdByUserID = -1;
            bool _testResults = false;
            string _notes = null;

            if (TestDataAccess.FindByAppointment(testAppointmentID, ref _testID, ref _createdByUserID, ref _testResults, ref _notes))
                return new Test(_testID, testAppointmentID, _testResults, ref _notes, _createdByUserID);

            return null;
        }

        public static class Charting {
            public static DataView GetAllTimeTestResults(SupportedLanguages language) => TestDataAccess.Charting.GetAllTimeTestResults(language == SupportedLanguages.Arabic);

            public static DataView GetAvgAttemptsToPass(short year, SupportedLanguages language) => TestDataAccess.Charting.GetAverageAttemptsToPass(year, language == SupportedLanguages.Arabic);

            public static DataView GetPerMonthTestResults(byte month, short year, SupportedLanguages language) => TestDataAccess.Charting.GetPerMonthTestResults(month, year, language == SupportedLanguages.Arabic);

            public static DataView GetTestPassRates(short year, SupportedLanguages language) => TestDataAccess.Charting.GetTestPassRates(year, language == SupportedLanguages.Arabic);
        }
    }
}
