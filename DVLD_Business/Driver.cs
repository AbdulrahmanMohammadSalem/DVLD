using DVLD_Business.Properties;
using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel;
using Salem.Extensions.External;
using System;
using System.Data;

namespace DVLD_Business {
    public class Driver {
        private Modes _ActiveMode = Modes.AddNew; //By default

        public Driver() { }

        private Driver(int driverID, int personID, int createdByUserID, ref DateTime dateCreated) {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            DateCreated = dateCreated;

            _ActiveMode = Modes.Update;
        }

        public int DriverID { get; private set; } = -1; //By default
        public int PersonID { get; set; } = -1; //By default
        public int CreatedByUserID { get; set; } = -1; //By default
        public DateTime DateCreated { get; set; } = new DateTime(0); //By default

        public Person PersonInfo { get => Person.Find(PersonID); }
        public User CreatedByUserInfo { get => User.Find(CreatedByUserID); }

        public static bool Delete(int driverID) => DriverDataAccess.DeleteDriver(driverID);

        public static bool DeleteIfNoLicensesAssigned(int personID) =>
            DriverDataAccess.DeleteDriverIfNoLicensesAssigned(personID);

        public static bool DoesExist(int driverID) =>
            DriverDataAccess.DoesDriverExist(driverID);

        public static bool DoesExistByPersonID(int personID) =>
            DriverDataAccess.DoesDriverExistByPersonID(personID);

        public static Driver Find(int driverID) {
            if (driverID == -1)
                return null;

            int _personID = -1, _createdByUserID = -1;
            DateTime _dateCreated = new DateTime(0);

            if (DriverDataAccess.FindDriver(driverID, ref _personID, ref _createdByUserID, ref _dateCreated))
                return new Driver(driverID, _personID, _createdByUserID, ref _dateCreated);

            return null;
        }

        public static int FindIdByPersonId(int personID) =>
            DriverDataAccess.FindDriverIdByPerson(personID);

        public static int FindPersonID(int driverID) =>
            DriverDataAccess.FindPersonId(driverID);

        public static DataTable GetAllDrivers() =>
            DriverDataAccess.GetAllDrivers();

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewDriver()) {
                    _ActiveMode = Modes.Update;

                    return true;
                }

                return false;
            }

            return _UpdateDriver();
        }

        private bool _AddNewDriver() => (DriverID = DriverDataAccess.AddNewDriver(PersonID, CreatedByUserID, DateCreated)) != -1;

        private bool _UpdateDriver() => DriverDataAccess.UpdateDriverInfo(DriverID, PersonID, CreatedByUserID, DateCreated);

        public static class Reporting {
            [Flags]
            public enum DriverProfileReportSections : byte {
                None = 0, DriverInfo = 1, ActiveLicenses = 2, InactiveLicenses = 4, All = DriverInfo | ActiveLicenses | InactiveLicenses
            }

            public enum DesiredLicenseTypes : byte {
                Local, International, Both
            }

            public readonly struct DriverProfileReportInfo {
                public DriverProfileReportInfo(int driverID, DocumentExportSettings exportSettings, DriverProfileReportSections reportSections, DesiredLicenseTypes desiredLicenseTypes) {
                    DriverID = driverID;
                    ExportSettings = exportSettings;
                    ReportSections = reportSections;
                    DesiredLicenseTypes = desiredLicenseTypes;
                }

                public int DriverID { get; }
                public DocumentExportSettings ExportSettings { get; }
                public DriverProfileReportSections ReportSections { get; }
                public DesiredLicenseTypes DesiredLicenseTypes { get; }
            }

            public static Document ConstructDriverProfileReport(DriverProfileReportInfo reportInfo, string createdByUsername, SupportedLanguages language) {
                var _driverInfo = Find(reportInfo.DriverID);

                if (_driverInfo is null)
                    return null;

                var _document = new Document {
                    Info = {
                        Title = Str_DriverProfileReport.reportTitle,
                        Subject = $"{Str_DriverProfileReport.reportSubject_1}{_driverInfo.DriverID}.",
                        Author = Resources.reportAuthor
                    }
                };

                byte _sectionCounter = 0;
                bool _rightToLeft = language == SupportedLanguages.Arabic;
                var _exportSettings = reportInfo.ExportSettings;
                var _section = BusinessUtils.Reporting.SetupCommonDocumentSettings(_document, ref _exportSettings, ReportTypes.DriverProfileReport, createdByUsername, language);
                Func<int, int, string, string> FormatSectionTitle;
                Func<string, string> TransformText;

                if (_rightToLeft) {
                    FormatSectionTitle = (num, subNum, title) => subNum == 0 ? $":{title.ReshapeForPrinting()} -{num}" : $":{title.ReshapeForPrinting()} -{subNum}-{num}";
                    TransformText = text => text.ReshapeForPrinting();
                } else {
                    FormatSectionTitle = (num, subNum, title) => subNum == 0 ? $"{num}. {title}:" : $"{num}.{subNum}. {title}:";
                    TransformText = text => text;
                }

                if (reportInfo.ReportSections.HasFlag(DriverProfileReportSections.DriverInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_driverInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddDriverInfoCard(_section, _driverInfo, _exportSettings.Colorful, language);
                }

                License.DeactivateAllExpiredLicenses();

                if (reportInfo.ReportSections.HasFlag(DriverProfileReportSections.ActiveLicenses)) {
                    switch (reportInfo.DesiredLicenseTypes) {
                        case DesiredLicenseTypes.Local:
                            _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_activeLicenses_local), StyleNames.Heading1);
                            AddActiveLocalLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, language);
                            break;
                        case DesiredLicenseTypes.International:
                            _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_activeLicenses_inter), StyleNames.Heading1);
                            AddActiveInterLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, _rightToLeft);
                            break;
                        case DesiredLicenseTypes.Both:
                            _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_activeLicenses), StyleNames.Heading1);

                            _section.AddParagraph(FormatSectionTitle(_sectionCounter, 1, Str_PersonHistoryReport.h_localLicenses), StyleNames.Heading2);
                            AddActiveLocalLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, language);

                            _section.AddParagraph(FormatSectionTitle(_sectionCounter, 2, Str_PersonHistoryReport.h_interLicenses), StyleNames.Heading2);
                            AddActiveInterLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, _rightToLeft);
                            break;
                    }
                }

                if (reportInfo.ReportSections.HasFlag(DriverProfileReportSections.InactiveLicenses)) {
                    switch (reportInfo.DesiredLicenseTypes) {
                        case DesiredLicenseTypes.Local:
                            _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_inactiveLicenses_local), StyleNames.Heading1);
                            AddInactiveLocalLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, language);
                            break;
                        case DesiredLicenseTypes.International:
                            _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_inactiveLicenses_inter), StyleNames.Heading1);
                            AddInactiveInterLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, _rightToLeft);
                            break;
                        case DesiredLicenseTypes.Both:
                            _section.AddParagraph(FormatSectionTitle(++_sectionCounter, 0, Str_DriverProfileReport.h_inactiveLicenses), StyleNames.Heading1);

                            _section.AddParagraph(FormatSectionTitle(_sectionCounter, 1, Str_PersonHistoryReport.h_localLicenses), StyleNames.Heading2);
                            AddInactiveLocalLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, language);

                            _section.AddParagraph(FormatSectionTitle(_sectionCounter, 2, Str_PersonHistoryReport.h_interLicenses), StyleNames.Heading2);
                            AddInactiveInterLicenses(_section, _driverInfo.DriverID, _exportSettings.Colorful, TransformText, _rightToLeft);
                            break;
                    }
                }

                return _document;
            }

            private static void AddActiveInterLicenses(Section section, int driverID, bool colorful, Func<string, string> TransformText, bool rightToLeft) {
                BusinessUtils.Reporting.AddDataGrid(section, GetDriverInterLicenseHistory(driverID, true), colorful, rightToLeft);
                section.AddParagraph(TransformText(Str_DriverProfileReport.cap_activeInterLicenses), BusinessUtils.Reporting.TableLowerCaptionStyle);
            }

            private static void AddActiveLocalLicenses(Section section, int driverID, bool colorful, Func<string, string> TransformText, SupportedLanguages language) {
                BusinessUtils.Reporting.AddDataGrid(section, GetDriverLocalLicenseHistory(driverID, true, language), colorful, language == SupportedLanguages.Arabic);
                section.AddParagraph(TransformText(Str_DriverProfileReport.cap_activeLocalLicenses), BusinessUtils.Reporting.TableLowerCaptionStyle);
            }

            private static void AddInactiveInterLicenses(Section section, int driverID, bool colorful, Func<string, string> TransformText, bool rightToLeft) {
                BusinessUtils.Reporting.AddDataGrid(section, GetDriverInterLicenseHistory(driverID, false), colorful, rightToLeft);
                section.AddParagraph(TransformText(Str_DriverProfileReport.cap_inactiveInterLicenses), BusinessUtils.Reporting.TableLowerCaptionStyle);
            }

            private static void AddInactiveLocalLicenses(Section section, int driverID, bool colorful, Func<string, string> TransformText, SupportedLanguages language) {
                BusinessUtils.Reporting.AddDataGrid(section, GetDriverLocalLicenseHistory(driverID, false, language), colorful, language == SupportedLanguages.Arabic);
                section.AddParagraph(TransformText(Str_DriverProfileReport.cap_inactiveLocalLicenses), BusinessUtils.Reporting.TableLowerCaptionStyle);
            }

            private static DataTable GetDriverInterLicenseHistory(int driverID, bool isActive) {
                var _table = DriverDataAccess.Reporting.GetDriverInterLicenseHistory(driverID, isActive);

                _table.Columns["InternationalLicenseID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["ApplicationID"].Caption = Str_PersonHistoryReport.col_appID;
                _table.Columns["IssuedUsingLocalLicenseID"].Caption = Str_PersonHistoryReport.col_assocLocalLicenseID;
                _table.Columns["IssueDate"].Caption = Str_PersonHistoryReport.col_issueDate;
                _table.Columns["ExpirationDate"].Caption = Str_PersonHistoryReport.col_expirationDate;
                _table.Columns["CreatedBy"].Caption = Str_PersonHistoryReport.col_createdBy;

                return _table;
            }

            private static DataTable GetDriverLocalLicenseHistory(int driverID, bool isActive, SupportedLanguages language) {
                var _table = DriverDataAccess.Reporting.GetDriverLocalLicenseHistory(driverID, isActive, language == SupportedLanguages.Arabic);

                _table.Columns["LocalLicenseID"].Caption = Str_PersonHistoryReport.col_id;
                _table.Columns["LocalDrivingLicenseApplicationID"].Caption = Str_PersonHistoryReport.col_appID;
                _table.Columns["LicenseClass"].Caption = Str_PersonHistoryReport.col_class;
                _table.Columns["IssueDate"].Caption = Str_PersonHistoryReport.col_issueDate;
                _table.Columns["ExpirationDate"].Caption = Str_PersonHistoryReport.col_expirationDate;
                _table.Columns["CreatedBy"].Caption = Str_PersonHistoryReport.col_createdBy;

                return _table;
            }
        }
    }
}
