using DVLD_Business.Properties;
using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using Salem.Extensions.External;
using System;
using System.Data;

namespace DVLD_Business {
    public sealed class User {
        private Modes _ActiveMode = Modes.AddNew; //Default value

        public User() {}

        private User(int userID, int personID, ref string username, ref string password, bool isActive, int permissionsID) {
            UserID = userID;
            PersonID = personID;
            Username = username;
            Password = password;
            IsActive = isActive;
            PermissionsID = permissionsID;

            _ActiveMode = Modes.Update;
        }

        public int UserID { get; private set; } = -1; //Default value
        public int PersonID { get; set; } = -1; //Default value
        public string Username { get; set; } = null; //Default value
        public string Password { get; set; } = null; //Default value
        public bool IsActive { get; set; } = false; //Default value
        public int PermissionsID { get; set; } = -1; //Default value

        public Person PersonInfo => Person.Find(PersonID);
        public Permissions PermissionsInfo => Permissions.Find(PermissionsID);

        public static bool Delete(int userID) {
            int _permissionsID = FindPermissionsId(userID);
            return UserDataAccess.DeleteUser(userID) & Permissions.Delete(_permissionsID); //DO NOT SUBSTUTE THE VARIABLE WITH ITS DIFINITION YOU IDIOT!
        }

        public static int FindPermissionsId(int userID) =>
            UserDataAccess.FindPermissionsId(userID);

        public static bool DoesExistByPersonID(int personID) =>
            UserDataAccess.DoesUserExistByPersonID(personID);

        public static User Find(int userID) {
            if (userID == -1)
                return null;

            int personID = -1, permissions = 0;
            string username = string.Empty, password = string.Empty;
            bool isActive = false;

            if (UserDataAccess.FindUserById(userID, ref personID, ref username, ref password, ref isActive, ref permissions))
                return new User(userID, personID, ref username, ref password, isActive, permissions);

            return null;
        }

        public static DataView GetAllUsers() =>
            UserDataAccess.GetAllUsers();

        private bool _AddNewUser() =>
            (UserID = UserDataAccess.AddNewUser(PersonID, Username, Password, IsActive, PermissionsID)) != -1;

        private bool _UpdateUser() => UserDataAccess.UpdateUser(UserID, PersonID, Username, Password, IsActive, PermissionsID);

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewUser()) {
                    _ActiveMode = Modes.Update;
                    return true;
                }

                return false;
            }

            return _UpdateUser();
        }

        public static bool DoesExist(string username) =>
            UserDataAccess.DoesUserExist(username);

        public static User Find(string username, string password) {
            int userID = -1, personID = -1, permissions = 0;
            bool isActive = false;

            if (UserDataAccess.FindUserByUsernameAndPassword(ref username, ref password, ref userID, ref personID, ref isActive, ref permissions))
                return new User(userID, personID, ref username, ref password, isActive, permissions);

            return null;
        }

        public bool UpdatePassword(string newPassword) {
            if (_ActiveMode == Modes.AddNew)
                throw new ArgumentException("This User instance doesn't have an associated record in the database. It is in the AddNew mode.");

            if (UserDataAccess.UpdateUserPassword(UserID, ref newPassword)) {
                Password = newPassword;
                return true;
            }

            return false;
        }

        public static int FindIdByPersonId(int personID) =>
            UserDataAccess.FindUserIdByPersonId(personID);

        public static bool CheckIfUsersAvailable() =>
            UserDataAccess.CheckIfUsersAvailable();

        public static class Reporting {
            [Flags]
            public enum UserActivityReportSections : byte {
                None = 0, UserInfo = 1, BasicActionCounts = 2, DetailedActionCounts = 4, CategorizedActivities = 8, ActivityTimeline = 16,
                All = UserInfo | BasicActionCounts | DetailedActionCounts | CategorizedActivities | ActivityTimeline
            }

            public enum OrderModes : byte {
                Ascending, Descending
            }

            public readonly struct UserActivityReportInfo {
                public UserActivityReportInfo(int userID, DocumentExportSettings exportSettings, UserActivityReportSections reportSections, OrderModes activityTimelineOrderMode, (DateTime StartDate, DateTime EndDate)? dateRange) {
                    UserID = userID;
                    ExportSettings = exportSettings;
                    ReportSections = reportSections;
                    ActivityTimelineOrderModes = activityTimelineOrderMode;
                    DateRange = dateRange;
                }

                public int UserID { get; }
                public DocumentExportSettings ExportSettings { get; }
                public UserActivityReportSections ReportSections { get; }
                public OrderModes ActivityTimelineOrderModes { get; }
                public (DateTime StartDate, DateTime EndDate)? DateRange { get; }
            }

            public static Document ConstructUserActivityReport(UserActivityReportInfo reportInfo, string createdByUsername, SupportedLanguages language) {
                var _userInfo = Find(reportInfo.UserID);

                if (_userInfo is null)
                    return null;

                var _document = new Document {
                    Info = {
                        Title = Str_UserActivityReport.reportTitle,
                        Subject = $"{Str_UserActivityReport.reportSubject_1}{_userInfo.UserID}.",
                        Author = Resources.reportAuthor
                    }
                };

                byte _sectionCounter = 0;
                bool _rightToLeft = language == SupportedLanguages.Arabic;
                var _exportSettings = reportInfo.ExportSettings;
                var _section = BusinessUtils.Reporting.SetupCommonDocumentSettings(_document, ref _exportSettings, ReportTypes.UserActivityReport, createdByUsername, language);
                Func<int, string, string> FormatSectionTitle;
                Func<(DateTime, DateTime)?, string> FormatDateRange;
                Func<string, string, string> FormatTableCaption;
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

                if (reportInfo.ReportSections.HasFlag(UserActivityReportSections.UserInfo)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_UserActivityReport.h_userInfo), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddUserInfoCard(_section, _userInfo, _exportSettings.Colorful, language);
                }

                string _dateRangeTxt = FormatDateRange(reportInfo.DateRange);

                if (reportInfo.ReportSections.HasFlag(UserActivityReportSections.BasicActionCounts)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_UserActivityReport.h_basicActionCounts), StyleNames.Heading1);
                    BusinessUtils.Reporting.AddDataGrid(_section, GetBasicActionCounts(_userInfo.UserID, reportInfo.DateRange), _exportSettings.Colorful, _rightToLeft);
                    _section.AddParagraph(FormatTableCaption(Str_UserActivityReport.h_basicActionCounts, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                var _arrCategories = new string[] {
                    Str_UserActivityReport.applicationCreations,
                    Str_UserActivityReport.testAppointmentCreations,
                    Str_UserActivityReport.testResultsCreations,
                    Str_UserActivityReport.localLicenseCreations,
                    Str_UserActivityReport.internationalLicenseCreations,
                    Str_UserActivityReport.driverCreations_perNationality,
                    Str_UserActivityReport.licenseDetentionOperations
                };

                if (reportInfo.ReportSections.HasFlag(UserActivityReportSections.DetailedActionCounts)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_UserActivityReport.h_detailedActionCounts), StyleNames.Heading1);

                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, GetCategorizedActionCounts(_userInfo.UserID, reportInfo.DateRange, language), _exportSettings.Colorful, _rightToLeft);
                    BusinessUtils.Reporting.FormatHyphenedRows(_migraTable, ref _arrCategories, BusinessUtils.Reporting.InfoCardColor[_exportSettings.Colorful ? 0 : 1], _rightToLeft);

                    _section.AddParagraph(FormatTableCaption(Str_UserActivityReport.h_detailedActionCounts, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(UserActivityReportSections.CategorizedActivities)) {
                    _section.AddParagraph(FormatSectionTitle(++_sectionCounter, Str_UserActivityReport.h_categorizedActivities), StyleNames.Heading1);

                    _migraTable = BusinessUtils.Reporting.AddDataGrid(_section, GetCategorizedActivities(_userInfo.UserID, reportInfo.DateRange, language), _exportSettings.Colorful, _rightToLeft, true);
                    BusinessUtils.Reporting.FormatHyphenedRows(_migraTable, ref _arrCategories, BusinessUtils.Reporting.InfoCardColor[_exportSettings.Colorful ? 0 : 1], _rightToLeft);

                    _section.AddParagraph(FormatTableCaption(Str_UserActivityReport.h_categorizedActivities, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                if (reportInfo.ReportSections.HasFlag(UserActivityReportSections.ActivityTimeline)) {
                    if (_rightToLeft)
                        _section.AddParagraph(FormatSectionTitle(++_sectionCounter, $"{Str_UserActivityReport.h_activityTimeline} ){(reportInfo.ActivityTimelineOrderModes == OrderModes.Ascending ? Str_UserActivityReport.ascending : Str_UserActivityReport.descending)}("), StyleNames.Heading1);
                    else
                        _section.AddParagraph(FormatSectionTitle(++_sectionCounter, $"{Str_UserActivityReport.h_activityTimeline} ({(reportInfo.ActivityTimelineOrderModes == OrderModes.Ascending ? Str_UserActivityReport.ascending : Str_UserActivityReport.descending)})"), StyleNames.Heading1);

                    BusinessUtils.Reporting.AddDataGrid(_section, GetActivityTimeline(_userInfo.UserID, reportInfo.ActivityTimelineOrderModes, reportInfo.DateRange, language), _exportSettings.Colorful, _rightToLeft, true);
                    _section.AddParagraph(FormatTableCaption(Str_UserActivityReport.h_activityTimeline, _dateRangeTxt), BusinessUtils.Reporting.TableLowerCaptionStyle);
                }

                return _document;
            }

            private static DataTable GetActivityTimeline(int userID, OrderModes ActivityTimeline, (DateTime StartDate, DateTime EndDate)? dateRange, SupportedLanguages language) {
                var _table = UserDataAccess.Reporting.GetActivityTimeline(userID, ActivityTimeline == OrderModes.Ascending, dateRange, language == SupportedLanguages.Arabic);

                _table.Columns["EntityID"].Caption = Str_UserActivityReport.cap_entityID;
                _table.Columns["EntityType"].Caption = Str_UserActivityReport.cap_entityType;
                _table.Columns["DateTime"].Caption = Str_PersonHistoryReport.col_dateTime;
                _table.Columns["Specification"].Caption = Str_UserActivityReport.cap_specification;
                _table.Columns["Description"].Caption = Str_UserActivityReport.cap_description;

                return _table;
            }

            private static DataTable GetCategorizedActivities(int userID, (DateTime StartDate, DateTime EndDate)? dateRange, SupportedLanguages language) {
                var _table = UserDataAccess.Reporting.GetCategorizedActivities(userID, dateRange, language == SupportedLanguages.Arabic);

                _table.Columns["EntityID"].Caption = Str_UserActivityReport.cap_entityID;
                _table.Columns["EntityType"].Caption = Str_UserActivityReport.cap_entityType;
                _table.Columns["DateTime"].Caption = Str_PersonHistoryReport.col_dateTime;
                _table.Columns["Specification"].Caption = Str_UserActivityReport.cap_specification;
                _table.Columns["Description"].Caption = Str_UserActivityReport.cap_description;

                return _table;
            }

            private static DataTable GetCategorizedActionCounts(int userID, (DateTime StartDate, DateTime EndDate)? dateRange, SupportedLanguages language) {
                var _table = UserDataAccess.Reporting.GetCategorizedActionCounts(userID, dateRange, language == SupportedLanguages.Arabic);

                _table.Columns["Action"].Caption = Str_UserActivityReport.col_action;
                _table.Columns["Count"].Caption = Str_UserActivityReport.col_count;

                return _table;
            }

            private static DataTable GetBasicActionCounts(int userID, (DateTime startDate, DateTime endDate)? dateRange) {
                var _table = UserDataAccess.Reporting.GetBasicActionCounts(userID, dateRange);

                _table.Columns["Action"].Caption = Str_UserActivityReport.col_action;
                _table.Columns["Count"].Caption = Str_UserActivityReport.col_count;

                return _table;
            }
        }
    }
}
