using DVLD_Business.Properties;
using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using Salem.Extensions.External;
using System;
using System.Data;
using static DVLD_Business.Person.Reporting;

namespace DVLD_Business {
    public class TestAppointment {
        private Modes _ActiveMode = Modes.AddNew; //By default

        public int TestAppointmentID { get; private set; } = -1; //By default
        public TestTypes TestTypeID { get; set; } = TestTypes.VisionTest; //By default
        public int LocalDrivingLicenseAppID { get; set; } = -1; //By default
        public DateTime AppointmentDate { get; set; } = new DateTime(0); //By default
        public decimal FeesPaid { get; set; } = 0; //By default
        public int CreatedByUserID { get; set; } = -1; //By default
        public bool IsLocked { get; set; } = false; //By default
        public int? RetakeFailedTestAppID { get; set; } = null;

        public TestType TestTypeInfo { get => TestType.Find(TestTypeID); }
        public LocalDrivingLicenseApp LocalDrivingLicenseAppInfo { get => LocalDrivingLicenseApp.Find(LocalDrivingLicenseAppID); }
        public User CreatedByUserInfo { get => User.Find(CreatedByUserID); }
        public Application RetakeFailedTestAppInfo { get => RetakeFailedTestAppID is null ? null : Application.Find(RetakeFailedTestAppID.Value); }

        public TestAppointment() { }

        private TestAppointment(int testAppointmentID, TestTypes testTypeID, int localDrivingLicenseAppID, ref DateTime appointmentDate, ref decimal feesPaid, int createdByUserID, bool isLocked, ref int? retakeFailedTestAppID) {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseAppID = localDrivingLicenseAppID;
            AppointmentDate = appointmentDate;
            FeesPaid = feesPaid;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeFailedTestAppID = retakeFailedTestAppID;

            _ActiveMode = Modes.Update;
        }

        public static bool DoesActiveAppointmentExist(int localDrivingLicenseAppID, TestTypes activeTestType) =>
            TestAppointmentDataAccess.DoesActiveAppointmentExist(localDrivingLicenseAppID, (byte) activeTestType);

        public static DataView GetPreferredAppointmentsView(int localDrivingLicenseAppID, TestTypes testTypeID) =>
            TestAppointmentDataAccess.GetPreferredAppointmentsView(localDrivingLicenseAppID, (byte) testTypeID);

        public static int GetTotalTrials(int localDrivingLicenseAppID, TestTypes testTypeID) =>
            TestAppointmentDataAccess.GetTotalTrials(localDrivingLicenseAppID, (byte) testTypeID);

        public static int GetTotalAppointments(int localDrivingLicenseAppID, TestTypes testTypeID) =>
            TestAppointmentDataAccess.GetTotalAppointments(localDrivingLicenseAppID, (byte) testTypeID);

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewAppointment()) {
                    _ActiveMode = Modes.Update;

                    return true;
                }

                return false;
            }

            return _UpdateTestAppointment();
        }

        private bool _UpdateTestAppointment() => TestAppointmentDataAccess.UpdateTestAppointment(TestAppointmentID, (byte) TestTypeID, LocalDrivingLicenseAppID, AppointmentDate, FeesPaid, CreatedByUserID, IsLocked, RetakeFailedTestAppID);

        private bool _AddNewAppointment() => (TestAppointmentID = TestAppointmentDataAccess.AddNewAppointment((byte) TestTypeID, LocalDrivingLicenseAppID, AppointmentDate, FeesPaid, CreatedByUserID, IsLocked, RetakeFailedTestAppID)) != -1;

        public static TestAppointment Find(int testAppointmentID) {
            if (testAppointmentID == -1)
                return null;

            byte _testTypeID = 0;
            int _localDrivingLicenseAppID = -1, _createdByUserID = -1;
            DateTime _appointmentDate = new DateTime(0);
            decimal _feesPaid = 0;
            bool _isLocked = false;
            int? _retakeFailedTestAppID = null;

            if (TestAppointmentDataAccess.FindTestAppointment(testAppointmentID, ref _testTypeID, ref _localDrivingLicenseAppID, ref _createdByUserID, ref _appointmentDate, ref _feesPaid, ref _isLocked, ref _retakeFailedTestAppID))
                return new TestAppointment(testAppointmentID, (TestTypes) _testTypeID, _localDrivingLicenseAppID, ref _appointmentDate, ref _feesPaid, _createdByUserID, _isLocked, ref _retakeFailedTestAppID);

            return null;
        }

        public static bool LockAppointment(int testAppointmentID) =>
            TestAppointmentDataAccess.LockAppointment(testAppointmentID);

        public static DataView GetPreferredTestHistoryView(int personID, TestTypes testTypeID, SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? TestAppointmentDataAccess.GetPreferredTestHistoryView_Arabic(personID, (byte) testTypeID) : TestAppointmentDataAccess.GetPreferredTestHistoryView_Default(personID, (byte) testTypeID);

        public static decimal GetTotalAppointmentsPaidFees(int localDrivingLicenseAppID, TestTypes testTypeID) =>
            TestAppointmentDataAccess.GetTotalAppointmentsPaidFees(localDrivingLicenseAppID, (byte) testTypeID);

        public static int GetTotalRetakeTestApps(int localDrivingLicenseAppID, TestTypes testTypeID) =>
            TestAppointmentDataAccess.GetTotalRetakeTestApplications(localDrivingLicenseAppID, (byte) testTypeID);

        public static decimal GetTotalRetakeTestAppsPaidFees(int localDrivingLicenseAppID, TestTypes testTypeID) =>
            TestAppointmentDataAccess.GetTotalRetakeTestApplicationssPaidFees(localDrivingLicenseAppID, (byte) testTypeID);

        public static class Charting {
            public static object GetAllTestAppointments(short year, byte month) => TestAppointmentDataAccess.Charting.GetAllTestAppointments(year, month);

            public static short GetHighestAppointmentYear() => TestAppointmentDataAccess.Charting.GetHighestAppointmentYear();

            public static short GetOldestAppointmentYear() => TestAppointmentDataAccess.Charting.GetOldestAppointmentYear();

            public static DataView GetTotalTestAppointmentsPerMonths(short year, SupportedLanguages language) => TestAppointmentDataAccess.Charting.GetTotalTestAppointmentsPerMonths(year, language == SupportedLanguages.Arabic);
        }

        public static class Reporting {
            [Flags]
            public enum TestAttemptsReportSections : byte {
                None = 0, PersonalInfo = 1, VisionTestAttempts = 2, WrittenTestAttempts = 4, DrivingTestAttempts = 8, 
                All = PersonalInfo | VisionTestAttempts | WrittenTestAttempts | DrivingTestAttempts
            }

            public readonly struct TestAttemptsReportInfo {
                public TestAttemptsReportInfo(int personID, DocumentExportSettings exportSettings, TestAttemptsReportSections reportSections, (DateTime StartDate, DateTime EndDate)? dateRange) {
                    PersonID = personID;
                    ExportSettings = exportSettings;
                    ReportSections = reportSections;
                    DateRange = dateRange;
                }

                public int PersonID { get; }
                public DocumentExportSettings ExportSettings { get; }
                public TestAttemptsReportSections ReportSections { get; }
                public (DateTime StartDate, DateTime EndDate)? DateRange { get; }
            }

            public static Document ConstructTestAttemptsReport(TestAttemptsReportInfo reportInfo, string createdByUsername, SupportedLanguages language) {
                var _personInfo = Person.Find(reportInfo.PersonID);

                if (_personInfo is null)
                    return null;

                var _document = new Document {
                    Info = {
                        Title = Str_TestAttemptsReport.reportTitle,
                        Subject = $"{Str_TestAttemptsReport.reportSubject_1}{_personInfo.PersonID}{Str_PersonHistoryReport.reportSubject_2}{_personInfo.NationalNum}{Str_TestAttemptsReport.reportSubject_end}",
                        Author = Resources.reportAuthor
                    }
                };

                byte _sectionCounter = 0;
                bool _rightToLeft = language == SupportedLanguages.Arabic;
                var _exportSettings = reportInfo.ExportSettings;
                var _section = BusinessUtils.Reporting.SetupCommonDocumentSettings(_document, ref _exportSettings, ReportTypes.TestAttemptsReport, createdByUsername, language);
                Func<int, string, string> FormatSectionTitle;
                Func<(DateTime, DateTime)?, string> FormatDateRange;
                Func<string, string, string> FormatTableCaption;
                DataTable _dataTable;
                Table _migraTable;

                if (_rightToLeft) {
                    FormatSectionTitle = (num, title) => $":{title.ReshapeForPrinting()} -{num}";
                    FormatDateRange = dateRange => reportInfo.DateRange == null ? $"({Str_PersonHistoryReport.allTime.ReshapeForPrinting()})" : $"({BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.EndDate).ReshapeForPrinting()} {Str_PersonHistoryReport.upUntil.ReshapeForPrinting()} {BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.StartDate).ReshapeForPrinting()} {Str_PersonHistoryReport.from.ReshapeForPrinting()})";
                    FormatTableCaption = (title, dateRange) => $"{dateRange} {title.ReshapeForPrinting()}";
                } else {
                    FormatSectionTitle = (num, title) => $"{num}. {title}:";
                    FormatDateRange = dateRange => reportInfo.DateRange == null ? $"({Str_PersonHistoryReport.allTime})" : $"({Str_PersonHistoryReport.from} {BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.StartDate)} {Str_PersonHistoryReport.upUntil} {BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.EndDate)})";
                    FormatTableCaption = (title, dateRange) => $"{title} {dateRange}";
                }

                if (reportInfo.ReportSections.HasFlag(TestAttemptsReportSections.PersonalInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_PersonHistoryReport.h_personalInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddPersonInfoCard(_section, _personInfo, _exportSettings.Colorful, language);
                }

                string _dateRangeTxt = FormatDateRange(reportInfo.DateRange);

                if (reportInfo.ReportSections.HasFlag(TestAttemptsReportSections.VisionTestAttempts)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_PersonHistoryReport.h_visionTests), StyleNames.Heading1);
                    _dataTable = GetTestsView(_personInfo.PersonID, TestTypes.VisionTest, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(TotalPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_visionTests, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(TestAttemptsReportSections.WrittenTestAttempts)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_PersonHistoryReport.h_writtenTests), StyleNames.Heading1);
                    _dataTable = GetTestsView(_personInfo.PersonID, TestTypes.WrittenTest, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(TotalPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_writtenTests, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(TestAttemptsReportSections.DrivingTestAttempts)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_PersonHistoryReport.h_drivingTests), StyleNames.Heading1);
                    _dataTable = GetTestsView(_personInfo.PersonID, TestTypes.DrivingTest, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(TotalPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_drivingTests, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                return _document;
            }
        }
    }
}
