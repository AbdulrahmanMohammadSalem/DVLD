using DVLD_Business.Properties;
using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using Salem.Extensions.External;
using System;
using System.Data;

namespace DVLD_Business {
    public class LicenseDetention {
        private Modes _ActiveMode = Modes.AddNew; //By default

        private LicenseDetention(int detainID, int baseLicenseID, decimal fineFees, ref string detainReason, ref DateTime detainDate, int createdByUserID, bool isReleased, ref DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID) {
            DetainID = detainID;
            BaseLicenseID = baseLicenseID;
            FineFees = fineFees;
            DetainReason = detainReason;
            DetainDate = detainDate;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;

            _ActiveMode = Modes.Update;
        }

        public LicenseDetention() { }

        public int DetainID { get; private set; } = -1; //By default
        public int BaseLicenseID { get; set; } = -1; //By default
        public decimal FineFees { get; set; } = 0; //By default
        public string DetainReason { get; set; } = string.Empty; //By default
        public DateTime DetainDate { get; set; } = new DateTime(0); //By default
        public int CreatedByUserID { get; set; } = -1; //By default
        public bool IsReleased { get; set; } = false; //By default
        public DateTime? ReleaseDate { get; set; } = null; //By default
        public int? ReleasedByUserID { get; set; } = null; //By default
        public int? ReleaseApplicationID { get; set; } = null; //By default

        public LocalDrivingLicense LocalDrivingLicenseInfo => LocalDrivingLicense.Find(LocalDrivingLicense.GetLocalLicenseID(BaseLicenseID));
        public User CreatedByUserInfo => User.Find(CreatedByUserID);
        public User ReleasedByUserInfo => ReleasedByUserID is null ? null : User.Find(ReleasedByUserID.Value);
        public Application ReleaseApplicationInfo => ReleaseApplicationID is null ? null : Application.Find(ReleaseApplicationID.Value);

        public static bool CheckIfDetained(int localDrivingLicenseID) =>
            LicenseDetentionDataAccess.CheckDetainedLicense(LocalDrivingLicense.GetBaseLicenseID(localDrivingLicenseID));

        public static LicenseDetention DetainLicense(int localDrivingLicenseID, string detainReason, decimal fineFees, int _createdByUserID, DateTime registeredDetainDateTime) {
            LicenseDetention _licenseDetain = new LicenseDetention {
                BaseLicenseID = LocalDrivingLicense.GetBaseLicenseID(localDrivingLicenseID),
                CreatedByUserID = _createdByUserID,
                FineFees = fineFees,
                DetainReason = detainReason,
                DetainDate = registeredDetainDateTime
            };

            return _licenseDetain.Save() ? _licenseDetain : null;
        }

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewLicenseDetain()) {
                    _ActiveMode = Modes.Update;

                    return true;
                }

                return false;
            }

            return _UpdateLicenseDetain();
        }

        private bool _AddNewLicenseDetain() => (DetainID = LicenseDetentionDataAccess.AddNewLicenseDetain(BaseLicenseID, FineFees, DetainReason, DetainDate, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)) != -1;

        private bool _UpdateLicenseDetain() => LicenseDetentionDataAccess.UpdateLicenseDetainInfo(DetainID, BaseLicenseID, FineFees, DetainReason, DetainDate, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

        public static LicenseDetention FindByLicenseId(int localDrivingLicenseID) {
            int baseLicenseID = LocalDrivingLicense.GetBaseLicenseID(localDrivingLicenseID);

            int _detainID = -1, _createdByUserID = -1;
            decimal _fineFees = 0;
            string _detainReason = "";
            DateTime _detainDate = new DateTime(0);
            bool _isReleased = false;
            DateTime? _releaseDate = null;
            int? _releasedByUserID = null, _releaseApplicationID = null;

            if (LicenseDetentionDataAccess.FindInfoByLicenseId(baseLicenseID, ref _detainID, ref _fineFees, ref _detainReason, ref _detainDate, ref _createdByUserID, ref _isReleased, ref _releaseDate, ref _releasedByUserID, ref _releaseApplicationID))
                return new LicenseDetention(_detainID, baseLicenseID, _fineFees, ref _detainReason, ref _detainDate, _createdByUserID, _isReleased, ref _releaseDate, _releasedByUserID, _releaseApplicationID);

            return null;
        }

        public bool ReleaseLicense(DateTime registeredReleaseDate, int releasedByUserID, out int releaseAppID) {
            releaseAppID = -1;

            if (IsReleased)
                return false;

            Application _releaseApplication = new Application {
                ApplicantPersonID = LocalDrivingLicenseInfo.DriverInfo.PersonID,
                ApplicationDate = registeredReleaseDate,
                ApplicationStatus = ApplicationStatus.Completed,
                ApplicationTypeID = ApplicationTypes.ReleaseDetainedLicense,
                CreatedByUserID = releasedByUserID,
                FeesPaid = ApplicationType.GetFees(ApplicationTypes.ReleaseDetainedLicense),
                UpdateStatusDate = registeredReleaseDate
            };

            if (_releaseApplication.Save()) {
                IsReleased = true;
                ReleasedByUserID = releasedByUserID;
                ReleaseDate = registeredReleaseDate;
                ReleaseApplicationID = releaseAppID = _releaseApplication.BaseApplicationID;

                return LicenseDetentionDataAccess.ReleaseLicense(DetainID, releasedByUserID, registeredReleaseDate, _releaseApplication.BaseApplicationID);
            }

            return false;
        }

        public static DataTable GetAllLicenseDetains() =>
            LicenseDetentionDataAccess.GetAllLicenseDetains();

        public static class Charting {
            public static DataView GetAllTimeTotalFees() => LicenseDetentionDataAccess.Charting.GetAllTimeTotalFees();

            public static short GetHighestYear() => LicenseDetentionDataAccess.Charting.GetHighestYear();

            public static short GetLowestYear() => LicenseDetentionDataAccess.Charting.GetLowestYear();

            public static DataView GetPerMonthTotalFees(short year, SupportedLanguages language) => LicenseDetentionDataAccess.Charting.GetPerMonthTotalFees(year, language == SupportedLanguages.Arabic);
        }

        public static class Reporting {
            [Flags]
            public enum LicenseDetentionReportSections : byte {
                None = 0, DriverInfo = 1, LicenseInfo = 2, DetentionHistory = 4,
                All = DriverInfo | LicenseInfo | DetentionHistory
            }

            public readonly struct LicenseDetentionReportInfo {
                public LicenseDetentionReportInfo(int localLicenseID, DocumentExportSettings exportSettings, LicenseDetentionReportSections reportSections, (DateTime StartDate, DateTime EndDate)? dateRange) {
                    LocalLicenseID = localLicenseID;
                    ExportSettings = exportSettings;
                    ReportSections = reportSections;
                    DateRange = dateRange;
                }

                public int LocalLicenseID { get; }
                public DocumentExportSettings ExportSettings { get; }
                public LicenseDetentionReportSections ReportSections { get; }
                public (DateTime StartDate, DateTime EndDate)? DateRange { get; }
            }

            public static Document ConstructLicenseDetentionReport(LicenseDetentionReportInfo reportInfo, string createdByUsername, SupportedLanguages language) {
                var _localLicenseInfo = LocalDrivingLicense.Find(reportInfo.LocalLicenseID);

                if (_localLicenseInfo is null)
                    return null;

                var _document = new Document {
                    Info = {
                        Title = Str_LicenseDetentionReport.reportTitle,
                        Subject = $"{Str_LicenseDetentionReport.reportSubject_1}{_localLicenseInfo.LocalDrivingLicenseID}{Str_LicenseDetentionReport.reportSubject_2}{_localLicenseInfo.DriverID}.",
                        Author = Resources.reportAuthor
                    }
                };

                byte _sectionCounter = 0;
                bool _rightToLeft = language == SupportedLanguages.Arabic;
                var _exportSettings = reportInfo.ExportSettings;
                var _section = BusinessUtils.Reporting.SetupCommonDocumentSettings(_document, ref _exportSettings, ReportTypes.LicensesDetentionReport, createdByUsername, language);
                var _gridHeaderCellColor = BusinessUtils.Reporting.GridHeaderColor[_exportSettings.Colorful ? 0 : 1];
                var _infoCardBackColor = BusinessUtils.Reporting.InfoCardColor[_exportSettings.Colorful ? 0 : 1];
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

                if (reportInfo.ReportSections.HasFlag(LicenseDetentionReportSections.DriverInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_DriverProfileReport.h_driverInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddDriverInfoCard(_section, _localLicenseInfo.DriverInfo, _exportSettings.Colorful, language);
                }

                if (reportInfo.ReportSections.HasFlag(LicenseDetentionReportSections.LicenseInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_LicenseDetentionReport.h_licenseInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddLocalLicenseInfoCard(_section, _localLicenseInfo, _exportSettings.Colorful, language);
                }

                if (reportInfo.ReportSections.HasFlag(LicenseDetentionReportSections.DetentionHistory)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_LicenseDetentionReport.h_detentionHistory), StyleNames.Heading1);
                    _dataTable = GetDetentionsView(_localLicenseInfo.LocalDrivingLicenseID, reportInfo.DateRange);
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

                    _section.AddParagraph(FormatTableCaption(Str_PersonHistoryReport.h_detentions, FormatDateRange(reportInfo.DateRange)), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                return _document;
            }

            private static DataTable GetDetentionsView(int localLicenseID, (DateTime StartDate, DateTime EndDate)? dateRange) {
                var _table = LicenseDetentionDataAccess.Reporting.GetDetentionsView(localLicenseID, dateRange);

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
        }
    }
}
