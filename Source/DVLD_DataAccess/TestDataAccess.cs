using System.Data.SqlClient;
using System;
using System.Data;
using System.CodeDom;
using DVLD_DataAccess.Properties;

namespace DVLD_DataAccess {
    public static class TestDataAccess {
        public static int AddNewTest(int testAppointmentID, bool testResults, string notes, int createdByUserID) {
            const string QUERY = "INSERT INTO Tests (TestAppointmentID, TestResults, Notes, CreatedByUserID) " +
                "VALUES (@TestAppointmentID, @TestResults, @Notes, @CreatedByUserID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestAppointmentID", testAppointmentID);
                _command.Parameters.AddWithValue("TestResults", testResults);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);

                if (notes is null)
                    _command.Parameters.AddWithValue("Notes", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("Notes", notes);

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

        public static bool CheckForPassedTest(int localDrivingLicenseAppID, byte testTypeID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM Tests " +
                "INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID " +
                "WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID AND Tests.TestResults = 1";

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

        public static bool DeleteTest(int testID) {
            const string QUERY = "DELETE FROM Tests WHERE TestID = @TestID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestID", testID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindByAppointment(int testAppointmentID, ref int testID, ref int createdByUserID, ref bool testResults, ref string notes) {
            const string QUERY = "SELECT TOP 1 * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("TestAppointmentID", testAppointmentID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            testID = (int) _reader["TestID"];
                            createdByUserID = (int) _reader["CreatedByUserID"];
                            testResults = (bool) _reader["TestResults"];
                            notes = _reader["Notes"] as string;

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
    
        public static class Charting {
            public static DataView GetAllTimeTestResults(bool useArabic) {
                string[] _resultsTxt = new string[2] { StringResources.pass, StringResources.fail };

                return DataAccessUtils.ExecuteForDataView(
                    $@"SELECT R1.*, OverallTotal = R1.TotalVisionTests + R1.TotalWrittenTests + R1.TotalDrivingTests
                        FROM (
                        	SELECT TOP 2 
                                TestResult = (CASE WHEN Tests.TestResults = 1 THEN '{_resultsTxt[0]}' ELSE '{_resultsTxt[1]}' END),
                        	    TotalVisionTests = COUNT(CASE WHEN TestAppointments.TestTypeID = 1 THEN 1 END),
                        	    TotalWrittenTests = COUNT(CASE WHEN TestAppointments.TestTypeID = 2 THEN 1 END),
                        	    TotalDrivingTests = COUNT(CASE WHEN TestAppointments.TestTypeID = 3 THEN 1 END)
                        	FROM Tests INNER JOIN TestAppointments
                        	ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                        	GROUP BY Tests.TestResults
                        	ORDER BY Tests.TestResults DESC
                        ) R1"
                );
            }

            public static DataView GetAverageAttemptsToPass(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT R.*, TotalAvgAttempts = R.AvgVisionAttempts + R.AvgWrittenAttempts + R.AvgDrivingAttempts
                            FROM (
                            	SELECT R1.{_query}, 
                            		AvgVisionAttempts = ROUND(CAST(R1.TotalVisionAttempts AS FLOAT) / ISNULL(NULLIF(R1.TotalApplications, 0), 1), 2),
                            		AvgWrittenAttempts = ROUND(CAST(R1.TotalWrittenAttempts AS FLOAT) / ISNULL(NULLIF(R1.TotalApplications, 0), 1), 2),
                            		AvgDrivingAttempts = ROUND(CAST(R1.TotalDrivingAttempts AS FLOAT) / ISNULL(NULLIF(R1.TotalApplications, 0), 1), 2)
                            	FROM (
                            		SELECT Months.{_query}, 
                            			TotalVisionAttempts = COUNT(CASE WHEN T.TestTypeID = 1 THEN 1 END),
                            			TotalWrittenAttempts = COUNT(CASE WHEN T.TestTypeID = 2 THEN 1 END),
                            			TotalDrivingAttempts = COUNT(CASE WHEN T.TestTypeID = 3 THEN 1 END),
                            			TotalApplications = COUNT (DISTINCT T.LocalDrivingLicenseApplicationID)
                            		FROM Months LEFT JOIN (
                            			SELECT TestAppointments.LocalDrivingLicenseApplicationID, TestAppointments.TestTypeID, TestAppointments.AppointmentDate, Tests.TestResults
                            			FROM TestAppointments INNER JOIN Tests
                            			ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            			WHERE YEAR(TestAppointments.AppointmentDate) = @Year
                            		) T
                            		ON Months.MonthID = MONTH(T.AppointmentDate)
                            		GROUP BY Months.{_query}, Months.MonthID
                            	) R1
                            ) R";

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

            public static DataView GetPerMonthTestResults(byte month, short year, bool useArabic) {
                string[] _resultsTxt = new string[2] { StringResources.pass, StringResources.fail };

                string _query = $@"DECLARE @StartDate DATE = DATEFROMPARTS(@Year, @Month, 1);
                            DECLARE @EndDate DATE = DATEADD(MONTH, 1, @StartDate)
                            
                            SELECT R1.*, OverallTotal = R1.TotalVisionTests + R1.TotalWrittenTests + R1.TotalDrivingTests
                            FROM (
                            	SELECT TOP 2 TestResult = (CASE WHEN Tests.TestResults = 1 THEN '{_resultsTxt[0]}' ELSE '{_resultsTxt[1]}' END),
                            	TotalVisionTests = COUNT(CASE WHEN TestAppointments.TestTypeID = 1 THEN 1 END),
                            	TotalWrittenTests = COUNT(CASE WHEN TestAppointments.TestTypeID = 2 THEN 1 END),
                            	TotalDrivingTests = COUNT(CASE WHEN TestAppointments.TestTypeID = 3 THEN 1 END)
                            	FROM Tests INNER JOIN TestAppointments
                            	ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID  AND TestAppointments.AppointmentDate >= @StartDate AND TestAppointments.AppointmentDate < @EndDate
                            	GROUP BY Tests.TestResults
                            	ORDER BY Tests.TestResults DESC
                            ) R1";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
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

            public static DataView GetTestPassRates(short year, bool useArabic) {
                string _query = useArabic ? "MonthNameAR" : "ShortMonthName";

                _query = $@"SELECT Months.{_query}, 
                                	VisionPassRate = ROUND(CAST(COUNT(CASE WHEN T.TestTypeID = 1 AND T.TestResults = 1 THEN 1 END) AS FLOAT) * 100 / ISNULL(NULLIF(COUNT(CASE WHEN T.TestTypeID = 1 THEN 1 END), 0), 1), 2),
                                	WrittenPassRate = ROUND(CAST(COUNT(CASE WHEN T.TestTypeID = 2 AND T.TestResults = 1 THEN 1 END) AS FLOAT) * 100 / ISNULL(NULLIF(COUNT(CASE WHEN T.TestTypeID = 2 THEN 1 END), 0), 1), 2),
                                	DrivingPassRate = ROUND(CAST(COUNT(CASE WHEN T.TestTypeID = 3 AND T.TestResults = 1 THEN 1 END) AS FLOAT) * 100 / ISNULL(NULLIF(COUNT(CASE WHEN T.TestTypeID = 3 THEN 1 END), 0), 1), 2),
	                                TotalPassRate = ROUND(CAST(COUNT(CASE WHEN T.TestResults = 1 THEN 1 END) AS FLOAT) * 100 / ISNULL(NULLIF(COUNT(TestTypeID), 0), 1), 2)
                                FROM Months LEFT JOIN (
                                	SELECT TestAppointments.AppointmentDate, TestAppointments.TestTypeID, Tests.TestResults 
                                	FROM TestAppointments INNER JOIN Tests 
                                	ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID 
                                	WHERE YEAR(TestAppointments.AppointmentDate) = @Year
                                ) T
                                ON Months.MonthID = MONTH(T.AppointmentDate)
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
