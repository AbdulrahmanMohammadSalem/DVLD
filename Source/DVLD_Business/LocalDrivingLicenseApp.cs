using DVLD_Business.Properties;
using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel;
using Salem.Extensions.External;
using System;
using System.Data;

namespace DVLD_Business {
    public class LocalDrivingLicenseApp : Application {
        public int LDLAppID { get; private set; } = -1; //By default
        public LicenseClasses LicenseClassID { get; set; } = LicenseClasses.Class1_SmallMotorcycleLicense; //By default
        public byte NumOfPassedTests { get => LocalDrivingLicenseAppDataAccess.GetNumOfPassedTests(LDLAppID); }

        public LicenseClass LicenseClassInfo { get => LicenseClass.Find(LicenseClassID); }

        public LocalDrivingLicenseApp() : base() { }

        private LocalDrivingLicenseApp(int localDrivingLicenseAppID, int applicationID, int applicantPersonID, DateTime applicationDate, ApplicationStatus applicationStatus, DateTime? UpdateStatusDate, decimal feesPaid, int createdByUserID, LicenseClasses licenseClassID) : base(applicationID, applicantPersonID, ApplicationTypes.NewLocalLicense, ref applicationDate, applicationStatus, ref UpdateStatusDate, ref feesPaid, createdByUserID) {
            LDLAppID = localDrivingLicenseAppID;
            LicenseClassID = licenseClassID;
        }

        public static new bool Delete(int localDrivingLicenseAppID) {
            //We will only delete the associated record from the Applications table.
            //This will cascade-delete the corresponding record from the LocalDrivingLicenseApplications table.

            return LocalDrivingLicenseAppDataAccess.Delete(localDrivingLicenseAppID);
        }

        public static new LocalDrivingLicenseApp Find(int localDrivingLicenseAppID) {
            if (localDrivingLicenseAppID == -1)
                return null;

            byte _licenseClassID = 0;
            int _applicationID = -1;

            if (LocalDrivingLicenseAppDataAccess.FindApplication(localDrivingLicenseAppID, ref _applicationID, ref _licenseClassID)) {
                Application _application = Application.Find(_applicationID);

                return new LocalDrivingLicenseApp(localDrivingLicenseAppID, _applicationID, _application.ApplicantPersonID, _application.ApplicationDate, _application.ApplicationStatus, _application.UpdateStatusDate, _application.FeesPaid, _application.CreatedByUserID, (LicenseClasses) _licenseClassID);
            }

            return null;
        }

        public static DataTable GetPreferredApplicationsView(SupportedLanguages language) =>
            language == SupportedLanguages.Arabic ? LocalDrivingLicenseAppDataAccess.GetPreferredApplicationsView_Arabic() : LocalDrivingLicenseAppDataAccess.GetPreferredApplicationsView_Default();

        public override bool Save() {
            Modes _originalMode = _ActiveMode;

            if (!base.Save())
                return false;

            //_ActiveMode is now officially Update, so we use _originalMode

            if (_originalMode == Modes.AddNew) {
                if (!_AddNewLocalDrivingLicenseApp()) {
                    Application.Delete(BaseApplicationID);
                    _ActiveMode = Modes.AddNew;

                    return false;
                }

                return true;
            }

            return _UpdateApplicationInfo();
        }

        private bool _UpdateApplicationInfo() =>
            LocalDrivingLicenseAppDataAccess.UpdateApplication(LDLAppID, (byte) LicenseClassID);

        private bool _AddNewLocalDrivingLicenseApp() => (LDLAppID = LocalDrivingLicenseAppDataAccess.AddNewApplication(BaseApplicationID, (byte) LicenseClassID)) != -1;

        public static int FindIdForActive(int personID, LicenseClasses licenseClassID) =>
            LocalDrivingLicenseAppDataAccess.FindActiveApplicationID(personID, (byte) licenseClassID);

        public static bool DoesExist(int localDrivingLicenseAppID) =>
            LocalDrivingLicenseAppDataAccess.DoesApplicationExist(localDrivingLicenseAppID);

        public static new bool UpdateStatus(int localDrivingLicenseAppID, ApplicationStatus newStatus) =>
            LocalDrivingLicenseAppDataAccess.UpdateApplicationStatus(localDrivingLicenseAppID, (byte) newStatus);

        public static int FindApplicantPersonID(int localDrivingLicenseAppID) =>
            LocalDrivingLicenseAppDataAccess.FindApplicantPersonID(localDrivingLicenseAppID);

        public int IssueLicenseFirstTime(string notes, int createdByUserID) {
            //Changing the status of this object to "Completed":
            if (!MakeCompleted())
                return -1;

            //Creating a new Driver if not exists:
            int _driverID = Driver.FindIdByPersonId(ApplicantPersonID);

            if (_driverID == -1) {
                Driver _newDriver = new Driver {
                    CreatedByUserID = createdByUserID,
                    DateCreated = DateTime.Now,
                    PersonID = ApplicantPersonID
                };

                if (!_newDriver.Save()) {
                    MakeNew();
                    return -1;
                }

                _driverID = _newDriver.DriverID;
            }

            //Creating the Local Driving License:
            LocalDrivingLicense _newLocalLicense = new LocalDrivingLicense {
                CreatedByUserID = createdByUserID,
                DriverID = _driverID,
                ApplicationID = BaseApplicationID,
                IssueDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddYears(LicenseClassInfo.DefaultValidityLength),
                IsActive = true,
                IssueReason = DrivingLicenseIssueReasons.FirstTime,
                LicenseClassID = LicenseClassID,
                LicenseClassPaidFees = LicenseClass.GetFees(LicenseClassID),
                Notes = notes
            };

            if (!_newLocalLicense.Save()) {
                MakeNew();
                Driver.DeleteIfNoLicensesAssigned(ApplicantPersonID);
                return -1;
            }

            return _newLocalLicense.LocalDrivingLicenseID;
        }

        public static int FindLocalDrivingLicenseApplicationID(int baseApplicationID) =>
            LocalDrivingLicenseAppDataAccess.FindLocalDrivingLicenseApplicationID(baseApplicationID);

        public static DataTable GetPreferredApplicationsView(int applicantPersonID, SupportedLanguages language)=>
            language == SupportedLanguages.Arabic ? LocalDrivingLicenseAppDataAccess.GetPreferredApplicationsView_Arabic(applicantPersonID) : LocalDrivingLicenseAppDataAccess.GetPreferredApplicationsView_Default(applicantPersonID);

        public static class Reporting {
            [Flags]
            public enum LocalLicenseAppDetailsReportSections : byte {
                None = 0, ApplicationInfo = 1, ApplicantInfo = 2, TestInfo = 4, FeesSammary = 8,
                All = ApplicationInfo | ApplicantInfo | TestInfo | FeesSammary
            }

            public readonly struct LocalLicenseAppDetailsReportInfo {
                public LocalLicenseAppDetailsReportInfo(DocumentExportSettings exportSettings, int localLicenseAppID, LocalLicenseAppDetailsReportSections reportSections) {
                    ExportSettings = exportSettings;
                    LocalLicenseAppID = localLicenseAppID;
                    ReportSections = reportSections;
                }

                public DocumentExportSettings ExportSettings { get; }
                public int LocalLicenseAppID { get; }
                public LocalLicenseAppDetailsReportSections ReportSections { get; }
            }

            public static Document ConstructApplicationDetailsReport(LocalLicenseAppDetailsReportInfo reportInfo, string createdByUsername, SupportedLanguages language) {
                var _localLicenseAppInfo = Find(reportInfo.LocalLicenseAppID);

                if (_localLicenseAppInfo is null)
                    return null;

                var _document = new Document {
                    Info = {
                        Title = Str_LDLAppDetailsReport.reportTitle,
                        Subject = $"{Str_LDLAppDetailsReport.reportSubject_1}{_localLicenseAppInfo.LDLAppID}.",
                        Author = Resources.reportAuthor
                    }
                };

                byte _sectionCounter = 0;
                bool _rightToLeft = language == SupportedLanguages.Arabic;
                var _exportSettings = reportInfo.ExportSettings;
                var _section = BusinessUtils.Reporting.SetupCommonDocumentSettings(_document, ref _exportSettings, ReportTypes.LocalLicenseAppDetailsReport, createdByUsername, language);
                Func<int, int, string, string> FormatSectionTitle;
                Func<string, string> TransformText;

                if (_rightToLeft) {
                    FormatSectionTitle = (num, subNum, title) => subNum == 0 ? $":{title.ReshapeForPrinting()} -{num}" : $":{title.ReshapeForPrinting()} -{subNum}-{num}";
                    TransformText = text => text.ReshapeForPrinting();
                } else {
                    FormatSectionTitle = (num, subNum, title) => subNum == 0 ? $"{num}. {title}:" : $"{num}.{subNum}. {title}:";
                    TransformText = text => text;
                }

                if (reportInfo.ReportSections.HasFlag(LocalLicenseAppDetailsReportSections.ApplicationInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_LDLAppDetailsReport.h_applicationInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddLocalLicenseAppInfoCard(_section, _localLicenseAppInfo, _exportSettings.Colorful, language);
                }

                if (reportInfo.ReportSections.HasFlag(LocalLicenseAppDetailsReportSections.ApplicantInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_LDLAppDetailsReport.h_applicantInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddPersonInfoCard(_section, _localLicenseAppInfo.ApplicantInfo, _exportSettings.Colorful, language);
                }

                if (reportInfo.ReportSections.HasFlag(LocalLicenseAppDetailsReportSections.TestInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_LDLAppDetailsReport.h_testInfo), StyleNames.Heading1);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 1, Str_LDLAppDetailsReport.h_visionTestAppoints), StyleNames.Heading2);
                    BusinessUtils.Reporting.AddDataGrid(_section, GetTestAppointmentsTable(_localLicenseAppInfo.LDLAppID, TestTypes.VisionTest), _exportSettings.Colorful, _rightToLeft);
                    _section.AddParagraph(TransformText(Str_LDLAppDetailsReport.h_visionTestAppoints), BusinessUtils.Reporting.TableLowerCaptionStyle);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 2, Str_LDLAppDetailsReport.h_writtenTestAppoints), StyleNames.Heading2);
                    BusinessUtils.Reporting.AddDataGrid(_section, GetTestAppointmentsTable(_localLicenseAppInfo.LDLAppID, TestTypes.WrittenTest), _exportSettings.Colorful, _rightToLeft);
                    _section.AddParagraph(TransformText(Str_LDLAppDetailsReport.h_writtenTestAppoints), BusinessUtils.Reporting.TableLowerCaptionStyle);

                    _section.AddParagraph(FormatSectionTitle(_sectionCounter, 3, Str_LDLAppDetailsReport.h_drivingTestAppoints), StyleNames.Heading2);
                    BusinessUtils.Reporting.AddDataGrid(_section, GetTestAppointmentsTable(_localLicenseAppInfo.LDLAppID, TestTypes.DrivingTest), _exportSettings.Colorful, _rightToLeft);
                    _section.AddParagraph(TransformText(Str_LDLAppDetailsReport.h_drivingTestAppoints), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(LocalLicenseAppDetailsReportSections.FeesSammary)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Resources.feesSammary), StyleNames.Heading1);

                    int _totalAmount;
                    decimal _totalAmountPaidFees;

                    using (var _feesSammaryTable = new DataTable()) {
                        _feesSammaryTable.Columns.Add("OrderNum", typeof(byte));
                        _feesSammaryTable.Columns.Add("Product", typeof(string));
                        _feesSammaryTable.Columns.Add("AvgUnitPrice", typeof(decimal));
                        _feesSammaryTable.Columns.Add("Amount", typeof(byte));
                        _feesSammaryTable.Columns.Add("Total", typeof(decimal));

                        _feesSammaryTable.Columns["OrderNum"].Caption = Resources.orderNum;
                        _feesSammaryTable.Columns["Product"].Caption = Str_LDLAppDetailsReport.col_product;
                        _feesSammaryTable.Columns["AvgUnitPrice"].Caption = Str_LDLAppDetailsReport.col_avgUnitPrice;
                        _feesSammaryTable.Columns["Amount"].Caption = Str_LDLAppDetailsReport.col_amount;
                        _feesSammaryTable.Columns["Total"].Caption = Str_LDLAppDetailsReport.col_total;

                        _feesSammaryTable.Rows.Add(1, Str_LDLAppDetailsReport.localLicenseApp, _localLicenseAppInfo.FeesPaid, 1, _localLicenseAppInfo.FeesPaid);
                        
                        _totalAmount = TestAppointment.GetTotalAppointments(_localLicenseAppInfo.LDLAppID, TestTypes.VisionTest);
                        _totalAmountPaidFees = TestAppointment.GetTotalAppointmentsPaidFees(_localLicenseAppInfo.LDLAppID, TestTypes.VisionTest);
                        _feesSammaryTable.Rows.Add(2, Str_LDLAppDetailsReport.visionTestAppoint, _totalAmount == 0 ? TestType.GetFees(TestTypes.VisionTest) : _totalAmountPaidFees / _totalAmount, _totalAmount, _totalAmountPaidFees);

                        _totalAmount = TestAppointment.GetTotalAppointments(_localLicenseAppInfo.LDLAppID, TestTypes.WrittenTest);
                        _totalAmountPaidFees = TestAppointment.GetTotalAppointmentsPaidFees(_localLicenseAppInfo.LDLAppID, TestTypes.WrittenTest);
                        _feesSammaryTable.Rows.Add(3, Str_LDLAppDetailsReport.writtenTestAppoint, _totalAmount == 0 ? TestType.GetFees(TestTypes.WrittenTest) : _totalAmountPaidFees / _totalAmount, _totalAmount, _totalAmountPaidFees);

                        _totalAmount = TestAppointment.GetTotalAppointments(_localLicenseAppInfo.LDLAppID, TestTypes.DrivingTest);
                        _totalAmountPaidFees = TestAppointment.GetTotalAppointmentsPaidFees(_localLicenseAppInfo.LDLAppID, TestTypes.DrivingTest);
                        _feesSammaryTable.Rows.Add(4, Str_LDLAppDetailsReport.drivingTestAppoint, _totalAmount == 0 ? TestType.GetFees(TestTypes.DrivingTest) : _totalAmountPaidFees / _totalAmount, _totalAmount, _totalAmountPaidFees);

                        _totalAmount = TestAppointment.GetTotalRetakeTestApps(_localLicenseAppInfo.LDLAppID, TestTypes.DrivingTest);
                        _totalAmountPaidFees = TestAppointment.GetTotalRetakeTestAppsPaidFees(_localLicenseAppInfo.LDLAppID, TestTypes.DrivingTest);
                        _feesSammaryTable.Rows.Add(5, Str_LDLAppDetailsReport.retakeTestApp, _totalAmount == 0 ? ApplicationType.GetFees(ApplicationTypes.RetakeFailedTest) : _totalAmountPaidFees / _totalAmount, _totalAmount, _totalAmountPaidFees);

                        _totalAmountPaidFees = LocalDrivingLicense.GetClassPaidFeesByApplication(_localLicenseAppInfo.BaseApplicationID);

                        if (_rightToLeft)
                            _feesSammaryTable.Rows.Add(6, $"{Str_LDLAppDetailsReport.licenseClass} ){Str_LDLAppDetailsReport.classAbbr}{(byte) _localLicenseAppInfo.LicenseClassID}(", _totalAmountPaidFees == 0 ? LicenseClass.GetFees(_localLicenseAppInfo.LicenseClassID) : _totalAmountPaidFees, _totalAmountPaidFees > 0 ? 1 : 0, _totalAmountPaidFees);
                        else
                            _feesSammaryTable.Rows.Add(6, $"{Str_LDLAppDetailsReport.licenseClass} ({Str_LDLAppDetailsReport.classAbbr}{(byte) _localLicenseAppInfo.LicenseClassID})", _totalAmountPaidFees == 0 ? LicenseClass.GetFees(_localLicenseAppInfo.LicenseClassID) : _totalAmountPaidFees, _totalAmountPaidFees > 0 ? 1 : 0, _totalAmountPaidFees);

                        _totalAmountPaidFees = (decimal) _feesSammaryTable.Compute("SUM(Total)", "");

                        var _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, _feesSammaryTable, _exportSettings.Colorful, _rightToLeft);

                        BusinessUtils.Reporting.AddSammaryRow(_migraTable, Resources.grandTotal, _totalAmountPaidFees, 1, _rightToLeft);
                    }
                }

                return _document;
            }

            private static DataTable GetTestAppointmentsTable(int localDrivingLicenseAppID, TestTypes testTypeID) {
                var _table = LocalDrivingLicenseAppDataAccess.Reporting.GetTestAppointmentsTable(localDrivingLicenseAppID, (byte) testTypeID);

                _table.Columns["TestAppointmentID"].Caption = Str_LDLAppDetailsReport.col_testAppointID;
                _table.Columns["AppointmentDate"].Caption = Str_PersonHistoryReport.col_appointDate;
                _table.Columns["TotalFeesPaid"].Caption = Str_LDLAppDetailsReport.col_totalPaidFees;
                _table.Columns["IsLocked"].Caption = Str_PersonHistoryReport.col_isLocked;
                _table.Columns["AppointCreatedBy"].Caption = Str_PersonHistoryReport.col_appointCreatedBy;
                _table.Columns["TestCreatedBy"].Caption = Str_PersonHistoryReport.col_testCreatedBy;

                return _table;
            }
        }
    }
}
