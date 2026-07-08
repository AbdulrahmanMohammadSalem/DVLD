using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel;
using System;
using System.Data;
using System.Diagnostics;
using Salem.Extensions.External;
using DVLD_Business.Properties;
using MigraDoc.DocumentObjectModel.Tables;

namespace DVLD_Business {

    public sealed class Person {
        private Modes _ActiveMode = Modes.AddNew; //Default value

        private Person(int personID, ref string nationalNum, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, char gender, ref DateTime dateOfBirth, ref string address, ref string phoneNumber, ref string email, int nationalityCountryID, ref string imagePath) {
            PersonID = personID;
            NationalNum = nationalNum;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;

            _ActiveMode = Modes.Update;
        }

        public int PersonID { get; private set; } = -1; //Default value
        public string NationalNum { get; set; } = null; //Default value
        public string FirstName { get; set; } = null; //Default value
        public string SecondName { get; set; } = null; //Default value
        public string ThirdName { get; set; } = null; //Default value
        public string LastName { get; set; } = null; //Default value
        public char Gender { get; set; } = '\0'; //Default value
        public DateTime DateOfBirth { get; set; } = new DateTime(0); //Default value
        public string Address { get; set; } = null; //Default value
        public string PhoneNumber { get; set; } = null; //Default value
        public string Email { get; set; } = null; //Default value
        public int NationalityCountryID { get; set; } = -1; //Default value
        public string ImagePath { get; set; } = null; //Default value

        public Country NationalityCountryInfo => Country.Find(NationalityCountryID);
        public string FullName  => FirstName + ' ' + SecondName + ' ' + (ThirdName is null ? string.Empty : ThirdName + ' ') + LastName;
        public byte Age => (byte) (DateTime.Now.Year - DateOfBirth.Year);

        public Person() {}

        public static bool DoesExist(string nationalNum) =>
            PersonDataAccess.DoesPersonExist(ref nationalNum);

        public static bool DoesExist(int personID) =>
            PersonDataAccess.DoesPersonExist(personID);

        public static Person Find(int personID) {
            if (personID == -1)
                return null;

            int nationalityCountryID = -1;
            string nationalNum = string.Empty, firstName = string.Empty, secondName = string.Empty, thirdName = string.Empty, lastName = string.Empty, address = string.Empty, phoneNumber = string.Empty, email = string.Empty, imagePath = string.Empty;
            char gender = '\0';
            DateTime dateOfBirth = new DateTime(0);

            if (PersonDataAccess.FindById(personID, ref nationalNum, ref firstName, ref secondName, ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref address, ref phoneNumber, ref email, ref nationalityCountryID, ref imagePath))
                return new Person(personID, ref nationalNum, ref firstName, ref secondName, ref thirdName, ref lastName, gender, ref dateOfBirth, ref address, ref phoneNumber, ref email, nationalityCountryID, ref imagePath);

            return null;
        }

        public static Person Find(string nationalNum) {
            int personID = -1, nationalityCountryID = -1;
            string firstName = string.Empty, secondName = string.Empty, thirdName = string.Empty, lastName = string.Empty, address = string.Empty, phoneNumber = string.Empty, email = string.Empty, imagePath = string.Empty;
            char gender = '\0';
            DateTime dateOfBirth = new DateTime(0);

            if (PersonDataAccess.FindByNationalNum(ref nationalNum, ref personID, ref firstName, ref secondName, ref thirdName, ref lastName, ref gender, ref dateOfBirth, ref address, ref phoneNumber, ref email, ref nationalityCountryID, ref imagePath))
                return new Person(personID, ref nationalNum, ref firstName, ref secondName, ref thirdName, ref lastName, gender, ref dateOfBirth, ref address, ref phoneNumber, ref email, nationalityCountryID, ref imagePath);

            return null;
        }

        public static DataTable GetAllPeople(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? PersonDataAccess.GetAllPeople_Arabic() : PersonDataAccess.GetAllPeople_Default();

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewPerson()) {
                    _ActiveMode = Modes.Update;
                    return true;
                }

                return false;
            }
            
            return _UpdatePerson();
        }

        private bool _UpdatePerson() => PersonDataAccess.UpdatePerson(PersonID, NationalNum, FirstName, SecondName, ThirdName, LastName, Gender, DateOfBirth, Address, PhoneNumber, Email, NationalityCountryID, ImagePath);

        private bool _AddNewPerson() =>
            (PersonID = PersonDataAccess.AddNewPerson(NationalNum, FirstName, SecondName, ThirdName, LastName, Gender, DateOfBirth, Address, PhoneNumber, Email, NationalityCountryID, ImagePath)) != -1;

        public static bool Delete(int personID) =>
            PersonDataAccess.DeletePerson(personID);

        public static void PhoneCall(string phoneNum) => Process.Start($"tel:{phoneNum}");

        public static void SendEmail(string address) {
            Process.Start(new ProcessStartInfo {
                FileName = $"https://mail.google.com/mail/?view=cm&fs=1&to={address}",
                UseShellExecute = true
            });
        }

        public static class Reporting {
            [Flags]
            public enum PersonHistoryReportSections : byte {
                None = 0, PersonalInfo = 1, Applications = 2, LocalLicenses = 4, InternationalLicenses = 8, Tests = 16,
                Detentions = 32, All = PersonalInfo | Applications | LocalLicenses | InternationalLicenses | Tests | Detentions
            }

            public readonly struct PersonHistoryReportInfo {
                public PersonHistoryReportInfo(int personID, DocumentExportSettings exportSettings, PersonHistoryReportSections reportSectionFlags, (DateTime StartDate, DateTime EndDate)? dateRange) {
                    PersonID = personID;
                    ExportSettings = exportSettings;
                    ReportSections = reportSectionFlags;
                    DateRange = dateRange;
                }

                public int PersonID { get; }
                public DocumentExportSettings ExportSettings { get; }
                public PersonHistoryReportSections ReportSections { get; }
                public (DateTime StartDate, DateTime EndDate)? DateRange { get; }
            }

            public static Document ConstructPersonHistoryReport(PersonHistoryReportInfo reportInfo, string createdByUsername, SupportedLanguages language) {
                var _personInfo = Find(reportInfo.PersonID);
                
                if (_personInfo is null)
                    return null;

                var _document = new Document {
                    Info = {
                        Title = Str_PersonHistoryReport.reportTitle,
                        Subject = $"{Str_PersonHistoryReport.reportSubject_1}{_personInfo.PersonID}{Str_PersonHistoryReport.reportSubject_2}{_personInfo.NationalNum}{Str_TestAttemptsReport.reportSubject_end}",
                        Author = Resources.reportAuthor
                    }
                };

                byte _sectionCounter = 0;
                bool _rightToLeft = language == SupportedLanguages.Arabic;
                var _exportSettings = reportInfo.ExportSettings;
                var _section = BusinessUtils.Reporting.SetupCommonDocumentSettings(_document, ref _exportSettings, ReportTypes.PersonHistoryReport, createdByUsername, language);
                Func<int, int, string, string> FormatSectionTitle;
                Func<(DateTime, DateTime)?, string> FormatDateRange;
                Func<string, string, string> FormatTableCaption;
                DataTable _dataTable;
                Table _migraTable;

                if (_rightToLeft) {
                    FormatSectionTitle = (num, subNum, title) => subNum == 0 ? $":{title.ReshapeForPrinting()} -{num}" : $":{title.ReshapeForPrinting()} -{subNum}-{num}";
                    FormatDateRange = dateRange => reportInfo.DateRange == null ? $"({Str_PersonHistoryReport.allTime.ReshapeForPrinting()})" : $"({BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.EndDate).ReshapeForPrinting()} {Str_PersonHistoryReport.upUntil.ReshapeForPrinting()} {BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.StartDate).ReshapeForPrinting()} {Str_PersonHistoryReport.from.ReshapeForPrinting()})";
                    FormatTableCaption = (title, dateRange) => $"{dateRange} {title.ReshapeForPrinting()}";
                } else {
                    FormatSectionTitle = (num, subNum, title) => subNum == 0 ? $"{num}. {title}:" : $"{num}.{subNum}. {title}:";
                    FormatDateRange = dateRange => reportInfo.DateRange == null ? $"({Str_PersonHistoryReport.allTime})" : $"({Str_PersonHistoryReport.from} {BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.StartDate)} {Str_PersonHistoryReport.upUntil} {BusinessUtils.DateTimeUtils.FormatDate(reportInfo.DateRange.Value.EndDate)})";
                    FormatTableCaption = (title, dateRange) => $"{title} {dateRange}";
                }

                if (reportInfo.ReportSections.HasFlag(PersonHistoryReportSections.PersonalInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_PersonHistoryReport.h_personalInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddPersonInfoCard(_section, _personInfo, _exportSettings.Colorful, language);
                }

                string _dateRangeTxt = FormatDateRange(reportInfo.DateRange);

                if (reportInfo.ReportSections.HasFlag(PersonHistoryReportSections.Applications)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_PersonHistoryReport.h_apps), StyleNames.Heading1);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 1, Str_PersonHistoryReport.h_localLicenseApps), StyleNames.Heading2);
                    _dataTable = GetLocalLicenseAppsView(_personInfo.PersonID, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(FeesPaid)", ""), 2, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_localLicenseApps, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 2, Str_PersonHistoryReport.h_otherApps), StyleNames.Heading2);
                    _dataTable = GetOtherAppsView(_personInfo.PersonID, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(FeesPaid)", ""), 1, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_otherApps, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(PersonHistoryReportSections.LocalLicenses)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_PersonHistoryReport.h_localLicenses), StyleNames.Heading1);
                    _dataTable = GetLocalLicensesView(_personInfo.PersonID, reportInfo.DateRange);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(LicenseClassPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_localLicenses, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(PersonHistoryReportSections.InternationalLicenses)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_PersonHistoryReport.h_interLicenses), StyleNames.Heading1);
                    _dataTable = GetInterLicensesView(_personInfo.PersonID, reportInfo.DateRange);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(FeesPaid)", ""), 2, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_interLicenses, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(PersonHistoryReportSections.Tests)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_PersonHistoryReport.h_tests), StyleNames.Heading1);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 1, Str_PersonHistoryReport.h_visionTests), StyleNames.Heading2);
                    _dataTable = GetTestsView(_personInfo.PersonID, TestTypes.VisionTest, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(TotalPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_visionTests, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 2, Str_PersonHistoryReport.h_writtenTests), StyleNames.Heading2);
                    _dataTable = GetTestsView(_personInfo.PersonID, TestTypes.WrittenTest, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(TotalPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_writtenTests, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                    
                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 3, Str_PersonHistoryReport.h_drivingTests), StyleNames.Heading2);
                    _dataTable = GetTestsView(_personInfo.PersonID, TestTypes.DrivingTest, reportInfo.DateRange, language);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);
                    if (_migraTable != null) BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, (decimal) _dataTable.Compute("SUM(TotalPaidFees)", ""), 3, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_drivingTests, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }
                
                if (reportInfo.ReportSections.HasFlag(PersonHistoryReportSections.Detentions)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_PersonHistoryReport.h_detentions), StyleNames.Heading1);
                    _dataTable = GetDetentionsView(_personInfo.PersonID, reportInfo.DateRange);
                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _dataTable, _exportSettings.Colorful, _rightToLeft);

                    if (_migraTable != null) {
                        object _aggregationResult = _dataTable.Compute("SUM(FineFees)", "ReleaseApplicationID IS NULL");
                        decimal _totalPendingFineFees = _aggregationResult == DBNull.Value ? 0 : (decimal) _aggregationResult;
                        BusinessUtils.Reporting.AddSammaryRow(_migraTable, Str_PersonHistoryReport.totalPendingFineFees, _totalPendingFineFees, 3, _rightToLeft);

                        _aggregationResult = _dataTable.Compute("SUM(FineFees)", "ReleaseApplicationID IS NOT NULL");
                        decimal _totalPaidFineFees = _aggregationResult == DBNull.Value ? 0 : (decimal) _aggregationResult;
                        BusinessUtils.Reporting.AddSammaryRow(_migraTable, Str_PersonHistoryReport.totalPaidFineFees, _totalPaidFineFees, 3, _rightToLeft);

                        BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, _totalPendingFineFees + _totalPaidFineFees, 3, _rightToLeft);
                    }

                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_detentions, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                return _document;
            }
            
            private static DataTable GetDetentionsView(int personID, (DateTime StartDate, DateTime EndDate)? dateRange) {
                var _table = PersonDataAccess.Reporting.GetDetentionsView(personID, ref dateRange);

                _table.Columns["DetainID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["LocalLicenseID"].Caption = Str_PersonHistoryReport.col_localLicenseID;
                _table.Columns["FineFees"].Caption = Str_PersonHistoryReport.col_fineFees;
                _table.Columns["DetainReason"].Caption = Str_PersonHistoryReport.col_detainReason;
                _table.Columns["DetainDate"].Caption = Str_PersonHistoryReport.col_detainDate;
                _table.Columns["CreatedBy"].Caption = Str_PersonHistoryReport.col_createdBy;
                _table.Columns["IsReleased"].Caption = Str_PersonHistoryReport.col_isReleased;
                _table.Columns["ReleaseDate"].Caption = Str_PersonHistoryReport.col_releaseDate;
                _table.Columns["ReleasedBy"].Caption = Str_PersonHistoryReport.col_releasedBy;
                _table.Columns["ReleaseApplicationID"].Caption = Str_PersonHistoryReport.col_releaseAppID;

                return _table;
            }

            internal static DataTable GetTestsView(int personID, TestTypes testTypeID, (DateTime StartDate, DateTime EndDate)? dateRange, SupportedLanguages language) {
                var _table = PersonDataAccess.Reporting.GetTestsView(personID, (byte) testTypeID, ref dateRange, language == SupportedLanguages.Arabic);

                _table.Columns["TestAppointmentID"].Caption = Str_PersonHistoryReport.col_testAppointID;
                _table.Columns["LocalDrivingLicenseApplicationID"].Caption = Str_PersonHistoryReport.col_localLicenseAppID;
                _table.Columns["ClassName"].Caption = Str_PersonHistoryReport.col_class;
                _table.Columns["AppointmentDate"].Caption = Str_PersonHistoryReport.col_appointDate;
                _table.Columns["TestResult"].Caption = Str_PersonHistoryReport.col_testResult;
                _table.Columns["IsLocked"].Caption = Str_PersonHistoryReport.col_isLocked;
                _table.Columns["ApplicationID"].Caption = Str_PersonHistoryReport.col_retakeAppID;
                _table.Columns["TotalPaidFees"].Caption = Str_PersonHistoryReport.col_totalPaidFees;
                _table.Columns["AppointCreatedBy"].Caption = Str_PersonHistoryReport.col_appointCreatedBy;
                _table.Columns["TestCreatedBy"].Caption = Str_PersonHistoryReport.col_testCreatedBy;

                return _table;
            }

            private static DataTable GetInterLicensesView(int personID, (DateTime StartDate, DateTime EndDate)? dateRange) {
                License.DeactivateAllExpiredLicenses();

                var _table = PersonDataAccess.Reporting.GetInternationalLicensesView(personID, ref dateRange);
                
                _table.Columns["InternationalLicenseID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["IssueDate"].Caption = Str_PersonHistoryReport.col_issueDate;
                _table.Columns["ExpirationDate"].Caption = Str_PersonHistoryReport.col_expirationDate;
                _table.Columns["IsActive"].Caption = Str_PersonHistoryReport.col_isActive;
                _table.Columns["ApplicationID"].Caption = Str_PersonHistoryReport.col_appID;
                _table.Columns["FeesPaid"].Caption = Str_PersonHistoryReport.col_paidFees;
                _table.Columns["IssuedUsingLocalLicenseID"].Caption = Str_PersonHistoryReport.col_assocLocalLicenseID;
                _table.Columns["Username"].Caption = Str_PersonHistoryReport.col_createdBy;

                return _table;
            }

            private static DataTable GetLocalLicensesView(int personID, (DateTime StartDate, DateTime EndDate)? dateRange) {
                License.DeactivateAllExpiredLicenses();

                var _table = PersonDataAccess.Reporting.GetLocalLicensesView(personID, ref dateRange);

                _table.Columns["LocalLicenseID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["ClassName"].Caption = Str_PersonHistoryReport.col_class;
                _table.Columns["IssueReason"].Caption = Str_PersonHistoryReport.col_issueReason;
                _table.Columns["IssueDate"].Caption = Str_PersonHistoryReport.col_issueDate;
                _table.Columns["ExpirationDate"].Caption = Str_PersonHistoryReport.col_expirationDate;
                _table.Columns["IsActive"].Caption = Str_PersonHistoryReport.col_isActive;
                _table.Columns["Notes"].Caption = Str_PersonHistoryReport.col_issueNotes;
                _table.Columns["LicenseClassPaidFees"].Caption = Str_PersonHistoryReport.col_firstTimeFees;
                _table.Columns["Username"].Caption = Str_PersonHistoryReport.col_createdBy;

                return _table;
            }

            private static DataTable GetOtherAppsView(int personID, (DateTime StartDate, DateTime EndDate)? dateRange, SupportedLanguages language) {
                var _table = PersonDataAccess.Reporting.GetOtherAppsView(personID, ref dateRange, language == SupportedLanguages.Arabic);

                _table.Columns["ApplicationID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["ApplicationTypeTitle"].Caption = Str_PersonHistoryReport.col_type;
                _table.Columns["ApplicationDate"].Caption = Str_PersonHistoryReport.col_dateTime;
                _table.Columns["FeesPaid"].Caption = Str_PersonHistoryReport.col_fees;
                _table.Columns["Username"].Caption = Str_PersonHistoryReport.col_createdBy;

                return _table;
            }

            public static DataTable GetLocalLicenseAppsView(int personID, (DateTime StartDate, DateTime EndDate)? dateRange, SupportedLanguages language) {
                var _table = PersonDataAccess.Reporting.GetLocalLicenseApplicationsView(personID, ref dateRange, language == SupportedLanguages.Arabic);

                _table.Columns["LocalDrivingLicenseApplicationID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["ClassName"].Caption = Str_PersonHistoryReport.col_class;
                _table.Columns["ApplicationDate"].Caption = Str_PersonHistoryReport.col_dateTime;
                _table.Columns["PassedTestCount"].Caption = Str_PersonHistoryReport.col_passedTests;
                _table.Columns["ApplicationStatus"].Caption = Str_PersonHistoryReport.col_status;
                _table.Columns["UpdateStatusDate"].Caption = Str_PersonHistoryReport.col_updateDate;
                _table.Columns["FeesPaid"].Caption = Str_PersonHistoryReport.col_fees;
                _table.Columns["Username"].Caption = Str_PersonHistoryReport.col_createdBy;

                return _table;
            }
        }
    }
}
