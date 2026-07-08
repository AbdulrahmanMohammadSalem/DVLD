using DVLD_DataAccess.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class LocalDrivingLicenseAppDataAccess {
        public static int AddNewApplication(int applicationID, byte licenseClassID) {
            const string QUERY = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) " +
                                 "VALUES " +
                                 "(@ApplicationID, @LicenseClassID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationID", applicationID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

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

        public static bool Delete(int localDrivingLicenseAppID) {
            const string QUERY = "DELETE FROM Applications " +
                "WHERE ApplicationID = (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesApplicationExist(int localDrivingLicenseAppID) {
            const string QUERY = "SELECT R = 1 FROM LocalDrivingLicenseApplications " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindApplication(int localDrivingLicenseAppID, ref int applicationID, ref byte licenseClassID) {
            const string QUERY = "SELECT TOP 1 * FROM LocalDrivingLicenseApplications " +
                "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            applicationID = (int) _reader["ApplicationID"];
                            licenseClassID = (byte) _reader["LicenseClassID"];

                            return true;
                        }

                        return false;
                    }
                } catch (Exception) {

                    throw;
                }
            }
        }

        public static int FindApplicationID(int localDrivingLicenseAppID) {
            const string QUERY = "SELECT TOP 1 ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseAppID", localDrivingLicenseAppID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindActiveApplicationID(int personID, byte licenseClassID) {
            const string QUERY = "SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID " +
                                 "FROM LocalDrivingLicenseApplications " +
                                 "INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID " +
                                 "WHERE Applications.ApplicantPersonID = @PersonID AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID AND Applications.ApplicationStatus = 1";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static DataTable GetPreferredApplicationsView_Arabic() {
            return DataAccessUtils.ExecuteForDataTable(
                @"SELECT 
                    LocalDrivingLicenseApplicationID, 
                    ClassNameAR, 
                    NationalNum, 
                    FullName, 
                    ApplicationDate,
                    PassedTestsCount, 
                    ApplicationStatus,
                    LicenseClassID
                FROM VU_LocalDrivingLicenseApplications_AR"
            );
        }

        public static DataTable GetPreferredApplicationsView_Default() {
            return DataAccessUtils.ExecuteForDataTable(
                @"SELECT 
                    LocalDrivingLicenseApplicationID, 
                    ClassName, 
                    NationalNum, 
                    FullName, 
                    ApplicationDate,
                    PassedTestsCount, 
                    ApplicationStatus,
                    LicenseClassID
                FROM VU_LocalDrivingLicenseApplications"
            );
        }

        public static DataTable GetPreferredApplicationsView_Arabic(int applicantPersonID) {
            const string QUERY = @"SELECT 
                                    LocalDrivingLicenseApplicationID, 
                                    ClassNameAR, 
                                    ApplicationDate,
                                    PassedTestsCount, 
                                    ApplicationStatus
                                FROM VU_LocalDrivingLicenseApplications_AR
                                WHERE ApplicantPersonID = @ApplicantPersonID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicantPersonID", applicantPersonID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader())
                    using (DataTable _table = new DataTable()) {
                        _table.Load(_reader);

                        return _table;
                    }
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static DataTable GetPreferredApplicationsView_Default(int applicantPersonID) {
            const string QUERY = @"SELECT 
                                    LocalDrivingLicenseApplicationID, 
                                    ClassName, 
                                    ApplicationDate,
                                    PassedTestsCount, 
                                    ApplicationStatus
                                FROM VU_LocalDrivingLicenseApplications
                                WHERE ApplicantPersonID = @ApplicantPersonID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicantPersonID", applicantPersonID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader())
                    using (DataTable _table = new DataTable()) {
                        _table.Load(_reader);

                        return _table;
                    }
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool UpdateApplication(int localDrivingLicenseAppID, byte licenseClassID) {
            const string QUERY = "Update LocalDrivingLicenseApplications SET " +
                                 "LicenseClassID = @LicenseClassID " +
                                 "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static byte GetNumOfPassedTests(int localDrivingLicenseAppID) {
            const string QUERY = "SELECT PassedTestsCount " +
                                 "FROM VU_LocalDrivingLicenseApplications " +
                                 "WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseAppID", localDrivingLicenseAppID);

                try {
                    _connection.Open();

                    return (byte) (_command.ExecuteScalar() ?? 0);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindApplicantPersonID(int localDrivingLicenseAppID) {
            const string QUERY = "SELECT TOP 1 Applications.ApplicantPersonID FROM LocalDrivingLicenseApplications " +
                "INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID " +
                "WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseAppID", localDrivingLicenseAppID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool UpdateApplicationStatus(int localDrivingLicenseAppID, byte newStatus) {
            const string QUERY = "UPDATE Applications SET ApplicationStatus = @NewStatus, UpdateStatusDate = @UpdateStatusDate " +
                "WHERE ApplicationID = (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseAppID", localDrivingLicenseAppID);
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

        public static int FindLocalDrivingLicenseApplicationID(int baseApplicationID) {
            const string QUERY = "SELECT TOP 1 LocalDrivingLicenseApplicationID " +
                "FROM LocalDrivingLicenseApplications WHERE ApplicationID = @BaseApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseApplicationID", baseApplicationID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static class Reporting {
            public static DataTable GetTestAppointmentsTable(int localDrivingLicenseAppID, byte testTypeID) {
                string _query = $@"SELECT 
                                    appoints.TestAppointmentID,
                                    appoints.AppointmentDate,
                                    (appoints.FeesPaid + ISNULL(Applications.FeesPaid, 0)) AS TotalFeesPaid,
                                    IsLocked = CASE WHEN appoints.IsLocked = 1 THEN '{StringResources.yes}' ELSE '{StringResources.no}' END,
                                    AppointCreatedBy = appointUsers.Username,
                                    TestCreatedBy = testUsers.Username
                                FROM TestAppointments appoints LEFT JOIN Applications 
                                ON appoints.RetakeFailedTestApplicationID = Applications.ApplicationID LEFT JOIN Tests
                                ON appoints.TestAppointmentID = Tests.TestAppointmentID LEFT JOIN Users appointUsers
                                ON appoints.CreatedByUserID = appointUsers.UserID LEFT JOIN Users testUsers
                                ON Tests.CreatedByUserID = testUsers.UserID
                                WHERE appoints.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND appoints.TestTypeID = @TestTypeID 
                                ORDER BY appoints.IsLocked ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
                    _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                    try {
                        _connection.Open();

                        using (SqlDataReader _reader = _command.ExecuteReader())
                        using (DataTable _result = new DataTable()) {
                            _result.Load(_reader);

                            return _result;
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
