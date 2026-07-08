using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class TestAppointmentDataAccess {
        public static int AddNewAppointment(byte testTypeID, int localDrivingLicenseAppID, DateTime appointmentDate, decimal feesPaid, int createdByUserID, bool isLocked, int? retakeFailedTestAppID) {
            const string QUERY = "INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, FeesPaid, CreatedByUserID, IsLocked, RetakeFailedTestApplicationID) VALUES " +
                "(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @FeesPaid, @CreatedByUserID, @IsLocked, @RetakeFailedTestApplicationID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("AppointmentDate", appointmentDate);
                _command.Parameters.AddWithValue("FeesPaid", feesPaid);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);
                _command.Parameters.AddWithValue("IsLocked", isLocked);

                if (retakeFailedTestAppID is null)
                    _command.Parameters.AddWithValue("RetakeFailedTestApplicationID", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("RetakeFailedTestApplicationID", retakeFailedTestAppID.Value);

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

        public static bool DoesActiveAppointmentExist(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM TestAppointments " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 0";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindTestAppointment(int testAppointmentID, ref byte testTypeID, ref int localDrivingLicenseAppID, ref int createdByUserID, ref DateTime appointmentDate, ref decimal feesPaid, ref bool isLocked, ref int? retakeFailedTestAppID) {
            const string QUERY = "SELECT TOP 1 * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestAppointmentID", testAppointmentID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            testTypeID = (byte) _reader["TestTypeID"];
                            localDrivingLicenseAppID = (int) _reader["LocalDrivingLicenseApplicationID"];
                            createdByUserID = (int) _reader["CreatedByUserID"];
                            appointmentDate = (DateTime) _reader["AppointmentDate"];
                            feesPaid = (decimal) _reader["FeesPaid"];
                            isLocked = (bool) _reader["IsLocked"];
                            retakeFailedTestAppID = _reader["RetakeFailedTestApplicationID"] as int?;

                            return true;
                        }

                        return false;
                    }
                } catch (Exception) {

                    throw;
                }
            }
        }

        public static DataView GetPreferredAppointmentsView(int localDrivingLicenseAppID, byte testTypeID) {
            //We used the LEFT JOIN because we want all the Appointment records regardless of whether it has a RetakeFailedApplication attached or not.
            //We also used the ISNULL function to handle if the Appointment doesn't have a RetakeFailedApplication attached to it.
            const string QUERY = "SELECT TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, (TestAppointments.FeesPaid + ISNULL(Applications.FeesPaid, 0)) AS TotalFeesPaid, CAST(TestAppointments.IsLocked AS TINYINT) AS IsLocked " +
                "FROM TestAppointments " +
                "LEFT JOIN Applications ON TestAppointments.RetakeFailedTestApplicationID = Applications.ApplicationID " +
                "WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID " +
                "ORDER BY TestAppointments.IsLocked ASC";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader())
                    using (DataTable _result = new DataTable()) {
                        _result.Load(_reader);

                        return _result.DefaultView;
                    }
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        private static DataView _GetPreferredTestHistoryView_Generic(int personID, byte testTypeID, string columnName) {
            string query = "SELECT TestAppointments.LocalDrivingLicenseApplicationID, TestAppointments.TestAppointmentID, " +
                $"LicenseClasses.{columnName}, TestAppointments.AppointmentDate, TotalFeesPaid = TestAppointments.FeesPaid + ISNULL(retakeApps.FeesPaid, 0), " +
                "TestAppointments.IsLocked FROM TestAppointments " +
                "LEFT JOIN Applications retakeApps ON TestAppointments.RetakeFailedTestApplicationID = retakeApps.ApplicationID " +
                "INNER JOIN LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID " +
                "INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID " +
                "INNER JOIN Applications apps ON LocalDrivingLicenseApplications.ApplicationID = apps.ApplicationID " +
                "WHERE apps.ApplicantPersonID = @PersonID AND TestAppointments.TestTypeID = @TestTypeID " +
                "ORDER BY TestAppointments.IsLocked ASC";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

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

        public static DataView GetPreferredTestHistoryView_Default(int personID, byte testTypeID) =>
            _GetPreferredTestHistoryView_Generic(personID, testTypeID, "ClassName");

        public static DataView GetPreferredTestHistoryView_Arabic(int personID, byte testTypeID) =>
            _GetPreferredTestHistoryView_Generic(personID, testTypeID, "ClassNameAR");

        public static int GetTotalTrials(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = "SELECT COUNT(*) FROM TestAppointments " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 1";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    return (int) _command.ExecuteScalar();
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int GetTotalAppointments(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = "SELECT COUNT(*) FROM TestAppointments " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    return (int) _command.ExecuteScalar();
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static decimal GetTotalAppointmentsPaidFees(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = "SELECT SUM(FeesPaid) FROM TestAppointments " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    object _result = _command.ExecuteScalar();

                    return Convert.ToDecimal(_result == DBNull.Value ? 0 : _result);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int GetTotalRetakeTestApplications(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = @"SELECT COUNT(RetakeFailedTestApplicationID)
                                   FROM TestAppointments
                                   WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    return (int) _command.ExecuteScalar();
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static decimal GetTotalRetakeTestApplicationssPaidFees(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = @"SELECT SUM(apps.FeesPaid)
                                   FROM TestAppointments INNER JOIN Applications apps
                                   ON TestAppointments.RetakeFailedTestApplicationID = apps.ApplicationID
                                   WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                try {
                    _connection.Open();

                    object _result = _command.ExecuteScalar();

                    return Convert.ToDecimal(_result == DBNull.Value ? 0 : _result);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool LockAppointment(int testAppointmentID) {
            const string QUERY = "UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestAppointmentID", testAppointmentID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool UpdateTestAppointment(int testAppointmentID, byte testTypeID, int localDrivingLicenseAppID, DateTime appointmentDate, decimal feesPaid, int createdByUserID, bool isLocked, int? retakeFailedTestAppID) {
            const string QUERY = "UPDATE TestAppointments SET " +
                "TestTypeID = @TestTypeID, LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, " +
                "AppointmentDate = @AppointmentDate, FeesPaid = @FeesPaid, CreatedByUserID = @CreatedByUserID, " +
                "IsLocked = @IsLocked, RetakeFailedTestApplicationID = @RetakeFailedTestApplicationID " +
                "WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestAppointmentID", testAppointmentID);
                _command.Parameters.AddWithValue("TestTypeID", testTypeID);
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("AppointmentDate", appointmentDate);
                _command.Parameters.AddWithValue("FeesPaid", feesPaid);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);
                _command.Parameters.AddWithValue("IsLocked", isLocked);

                if (retakeFailedTestAppID is null)
                    _command.Parameters.AddWithValue("RetakeFailedTestApplicationID", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("RetakeFailedTestApplicationID", retakeFailedTestAppID.Value);

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
            public static object GetAllTestAppointments(short year, byte month) {
                const string QUERY = @"DECLARE @StartDate DATE = DATEFROMPARTS(@Year, @Month, 1);
                                    DECLARE @EndDate DATE = DATEADD(MONTH, 1, @StartDate);
                                    
                                    SELECT TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, Users.Username, TestAppointments.IsLocked, TestAppointments.TestTypeID
                                    FROM TestAppointments INNER JOIN Users
                                    ON Users.UserID = TestAppointments.CreatedByUserID
                                    WHERE TestAppointments.AppointmentDate >= @StartDate AND TestAppointments.AppointmentDate < @EndDate
                                    ORDER BY TestAppointments.IsLocked ASC, TestAppointments.TestAppointmentID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                    _command.Parameters.AddWithValue("Month", month);
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

            public static short GetHighestAppointmentYear() {
                const string QUERY = @"SELECT YEAR(MAX(TestAppointments.AppointmentDate))
                                FROM TestAppointments INNER JOIN Tests
                                ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID";

                return DataAccessUtils.ExecuteForSmallInt(QUERY);
            }

            public static short GetOldestAppointmentYear() {
                const string QUERY = @"SELECT YEAR(MIN(TestAppointments.AppointmentDate))
                                FROM TestAppointments INNER JOIN Tests
                                ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID";

                return DataAccessUtils.ExecuteForSmallInt(QUERY);
            }

            public static DataView GetTotalTestAppointmentsPerMonths(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT 
                            	Months.{_query},
                            	TotalVisionAppointments = COUNT(CASE WHEN TestAppointments.TestTypeID = 1 THEN 1 END),
                            	TotalWrittenAppointments = COUNT(CASE WHEN TestAppointments.TestTypeID = 2 THEN 1 END),
                            	TotalDrivingAppointments = COUNT(CASE WHEN TestAppointments.TestTypeID = 3 THEN 1 END)
                            FROM Months LEFT JOIN TestAppointments
                            ON Months.MonthID = MONTH(TestAppointments.AppointmentDate) AND TestAppointments.AppointmentDate >= DATEFROMPARTS(@Year, 1, 1) AND TestAppointments.AppointmentDate < DATEFROMPARTS(@Year + 1, 1, 1)
                            GROUP BY Months.{_query}, Months.MonthID
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
        }
    }
}
