using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace DVLD_DataAccess {
    public static class ApplicationDataAccess {
        public static int AddNewApplication(int applicantPersonID, byte applicationTypeID, DateTime applicationDate, byte applicationStatus, DateTime? UpdateStatusDate, decimal feesPaid, int createdByUserID) {
            const string QUERY = "INSERT INTO Applications (ApplicantPersonID, ApplicationTypeID, ApplicationDate, ApplicationStatus, UpdateStatusDate, FeesPaid, CreatedByUserID) " +
                                 "VALUES " +
                                 "(@ApplicantPersonID, @ApplicationTypeID, @ApplicationDate, @ApplicationStatus, @UpdateStatusDate, @FeesPaid, @CreatedByUserID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicantPersonID", applicantPersonID);
                _command.Parameters.AddWithValue("ApplicationTypeID", applicationTypeID);
                _command.Parameters.AddWithValue("ApplicationDate", applicationDate);
                _command.Parameters.AddWithValue("ApplicationStatus", applicationStatus);
                _command.Parameters.AddWithValue("FeesPaid", feesPaid);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);

                if (UpdateStatusDate is null)
                    _command.Parameters.AddWithValue("UpdateStatusDate", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("UpdateStatusDate", UpdateStatusDate);

                try {
                    _connection.Open();

                    if (_command.ExecuteNonQuery() == 0)
                        return -1;

                    return DataAccessUtils.SelectGlobalIdentity(_connection);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DeleteApplication(int applicationID) {
            const string QUERY = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationID", applicationID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindApplication(int applicationID, ref int applicantPersonID, ref int createdByUserID, ref byte applicationTypeID, ref byte applicationStatus, ref DateTime applicationDate, ref DateTime? UpdateStatusDate, ref decimal feesPaid) {
            const string QUERY = "SELECT TOP 1 * FROM Applications WHERE ApplicationID = @ApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationID", applicationID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            applicantPersonID = (int) _reader["ApplicantPersonID"];
                            applicationTypeID = (byte) _reader["ApplicationTypeID"];
                            applicationDate = (DateTime) _reader["ApplicationDate"];
                            applicationStatus = (byte) _reader["ApplicationStatus"];
                            UpdateStatusDate = _reader["UpdateStatusDate"] as DateTime?;
                            feesPaid = (decimal) _reader["FeesPaid"];
                            createdByUserID = (int) _reader["CreatedByUserID"];
                                 
                            return true;
                        }

                        return false;
                    }
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static DataTable GetAllApplications_Arabic() =>
            DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_AllApplications_AR ORDER BY ApplicationID ASC");

        public static DataTable GetAllApplications_Default() =>
            DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_AllApplications ORDER BY ApplicationID ASC");

        public static bool UpdateApplicationInfo(int applicationID, byte applicationStatus, DateTime? UpdateStatusDate) {
            const string QUERY = "UPDATE Applications SET " +
                                  "ApplicationStatus = @ApplicationStatus, UpdateStatusDate = @UpdateStatusDate " +
                                  "WHERE ApplicationID = @ApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationID", applicationID);
                _command.Parameters.AddWithValue("ApplicationStatus", applicationStatus);

                if (UpdateStatusDate is null)
                    _command.Parameters.AddWithValue("UpdateStatusDate", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("UpdateStatusDate", UpdateStatusDate);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool UpdateApplicationStatus(int baseApplicationID, byte newStatus) {
            const string QUERY = "UPDATE Applications SET ApplicationStatus = @NewStatus, " +
                "UpdateStatusDate = @UpdateStatusDate WHERE ApplicationID = @BaseApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseApplicationID", baseApplicationID);
                _command.Parameters.AddWithValue("NewStatus", newStatus);

                if (newStatus == 1)
                    _command.Parameters.AddWithValue("UpdateStatusDate", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("UpdateStatusDate", DateTime.Now);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static class Charting {
            public static short GetHighestApplicationYear() => DataAccessUtils.ExecuteForSmallInt("SELECT CAST (MAX(YEAR(UpdateStatusDate)) AS SMALLINT) FROM Applications");

            public static short GetOldestApplicationYear() => DataAccessUtils.ExecuteForSmallInt("SELECT CAST (MIN(YEAR(UpdateStatusDate)) AS SMALLINT) FROM Applications");

            public static DataView GetApplicationTypesPerMonths(short year, byte applicationStatus, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "MonthName";

                _query = $@"SELECT {_query}, appTypes.ApplicationTypeID, TotalApplications = (SELECT COUNT(*) FROM Applications WHERE MONTH(UpdateStatusDate) = Months.MonthID AND appTypes.ApplicationTypeID = ApplicationTypeID AND ApplicationStatus = @ApplicationStatus AND YEAR(UpdateStatusDate) = @Year)
                                    FROM ApplicationTypes appTypes CROSS JOIN Months
                                    ORDER BY Months.MonthID ASC, appTypes.ApplicationTypeID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("ApplicationStatus", applicationStatus);
                    _command.Parameters.AddWithValue("Year", year);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetOverallApplicationsPerMonths(short year, byte applicationStatus, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "MonthName";

                _query = $@"SELECT {_query}, OverallTotal = (SELECT COUNT(*) FROM Applications WHERE MONTH(UpdateStatusDate) = Months.MonthID AND ApplicationStatus = @ApplicationStatus AND YEAR(UpdateStatusDate) = @Year) 
                            FROM Months ORDER BY Months.MonthID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("ApplicationStatus", applicationStatus);
                    _command.Parameters.AddWithValue("Year", year);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetApplicationTypesPerDays(short year, byte month, byte applicationStatus) {
                const string QUERY = @"DECLARE @StartDate DATE = DATEFROMPARTS(@Year, @Month, 1);
                                WITH T1 AS (
                                	SELECT Date = DATEADD(DAY, v.number, @StartDate), ApplicationTypeID
                                	FROM master..spt_values v CROSS JOIN ApplicationTypes
                                	WHERE v.type = 'P' AND v.number < DAY(EOMONTH(@StartDate))
                                )
                                SELECT T1.*, TotalApplications = (SELECT COUNT(*) FROM Applications WHERE ApplicationTypeID = T1.ApplicationTypeID AND ApplicationStatus = @ApplicationStatus AND CAST (UpdateStatusDate AS DATE) = T1.Date)
                                FROM T1";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);
                    _command.Parameters.AddWithValue("Month", month);
                    _command.Parameters.AddWithValue("ApplicationStatus", applicationStatus);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetOverallApplicationsPerDays(short year, byte month, byte applicationStatus) {
                const string QUERY = @"DECLARE @StartDate DATE = DATEFROMPARTS(@Year, @Month, 1);
                                WITH T2 AS (
                                	SELECT Date = DATEADD(DAY, v.number, @StartDate)
                                	FROM master..spt_values v
                                	WHERE v.type = 'P' AND v.number < DAY(EOMONTH(@StartDate))
                                )
                                SELECT T2.*, OverallTotal = (SELECT COUNT(*) FROM Applications WHERE ApplicationStatus = @ApplicationStatus AND CAST (UpdateStatusDate AS DATE) = T2.Date)
                                FROM T2";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);
                    _command.Parameters.AddWithValue("Month", month);
                    _command.Parameters.AddWithValue("ApplicationStatus", applicationStatus);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetTotalApplicationsAllTime() {
                const string QUERY = @"SELECT ApplicationTypes.ApplicationTypeID, TotalApplications = COUNT(*)
                                FROM ApplicationTypes
                                LEFT OUTER JOIN Applications ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
                                GROUP BY ApplicationTypes.ApplicationTypeID";

                return DataAccessUtils.ExecuteForDataView(QUERY);
            }

            public static DataView GetTotalApplicationStatusPerMonths(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT Months.{_query}, 
                            	TotalNewApplications = COUNT(CASE WHEN ApplicationStatus = 1 THEN 1 END),
                            	TotalCompletedApplications = COUNT(CASE WHEN ApplicationStatus = 2 THEN 1 END),
                            	TotalCancelledApplications = COUNT(CASE WHEN ApplicationStatus = 3 THEN 1 END)
                            FROM Months LEFT JOIN Applications Apps
                            ON MONTH(Apps.ApplicationDate) = Months.MonthID AND Apps.ApplicationTypeID = 1 AND Apps.ApplicationDate >= DATEFROMPARTS(@Year, 1, 1) AND Apps.ApplicationDate < DATEFROMPARTS(@Year + 1, 1, 1)
                            GROUP BY Months.MonthID, Months.{_query}
                            ORDER BY Months.MonthID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetTotalApplicationStatusAllTime() => DataAccessUtils.ExecuteForDataView("SELECT ApplicationStatus, TotalApplications = COUNT(*) FROM Applications GROUP BY ApplicationStatus");

            public static object GetLocalLicenseApplications(short year, byte month) {
                const string QUERY = @"SELECT localApps.LocalDrivingLicenseApplicationID, apps.ApplicationDate, apps.ApplicationStatus, apps.FeesPaid, Users.Username AS CreatedBy
                            FROM Applications apps
                            INNER JOIN LocalDrivingLicenseApplications localApps ON apps.ApplicationID = localApps.ApplicationID
                            INNER JOIN Users ON Apps.CreatedByUserID = Users.UserID
                            WHERE YEAR(apps.ApplicationDate) = @Year AND MONTH(apps.ApplicationDate) = @Month
                            ORDER BY localApps.LocalDrivingLicenseApplicationID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);
                    _command.Parameters.AddWithValue("Month", month);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetPerMonthApplicationTypesRevenues(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT 
                            	Months.{_query}, 
                            	TotalRevenue_NewLocalLicense = SUM(CASE WHEN apps.ApplicationTypeID = 1 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue_RenewLicense = SUM(CASE WHEN apps.ApplicationTypeID = 2 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue_ReplaceLostLicense = SUM(CASE WHEN apps.ApplicationTypeID = 3 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue_ReplaceDamagedLicense = SUM(CASE WHEN apps.ApplicationTypeID = 4 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue_ReleaseDetainedLicense = SUM(CASE WHEN apps.ApplicationTypeID = 5 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue_NewInterLicense = SUM(CASE WHEN apps.ApplicationTypeID = 6 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue_RetakeFailedTest = SUM(CASE WHEN apps.ApplicationTypeID = 7 THEN apps.FeesPaid ELSE 0 END),
                            	TotalRevenue = ISNULL(SUM(apps.FeesPaid), 0)
                            FROM Months LEFT JOIN Applications apps
                            ON MONTH(apps.ApplicationDate) = Months.MonthID AND apps.ApplicationDate >= DATEFROMPARTS(@Year, 1, 1) AND apps.ApplicationDate < DATEFROMPARTS(@Year + 1, 1, 1)
                            GROUP BY Months.MonthID, Months.{_query}
                            ORDER BY Months.MonthID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("Year", year);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table.DefaultView;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataView GetAllTimeApplicationTypesRevenues() => DataAccessUtils.ExecuteForDataView(
                @"SELECT appTypes.ApplicationTypeID, ISNULL(SUM(apps.FeesPaid), 0) AS TotalRevenue
                FROM ApplicationTypes appTypes LEFT JOIN Applications apps
                ON apps.ApplicationTypeID = appTypes.ApplicationTypeID
                GROUP BY appTypes.ApplicationTypeID
                ORDER BY appTypes.ApplicationTypeID"
            );
        }
    }
}
