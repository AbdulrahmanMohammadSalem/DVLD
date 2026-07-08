using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class LicenseDataAccess {
        public static int AddNewLicense(int driverID, int applicationID, byte issueReason, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID) {
            const string QUERY = "INSERT INTO Licenses (DriverID, ApplicationID, IssueReason, IssueDate, ExpirationDate, IsActive, CreatedByUserID) " +
                                 "VALUES (@DriverID, @ApplicationID, @IssueReason, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);
                _command.Parameters.AddWithValue("ApplicationID", applicationID);
                _command.Parameters.AddWithValue("IssueReason", issueReason);
                _command.Parameters.AddWithValue("IssueDate", issueDate);
                _command.Parameters.AddWithValue("ExpirationDate", expirationDate);
                _command.Parameters.AddWithValue("IsActive", isActive);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);

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

        public static int DeactivateAllExpiredLicenses() =>
            DataAccessUtils.ExecuteForNonQuery("UPDATE Licenses SET IsActive = 0 WHERE GETDATE() > ExpirationDate");

        public static bool SetLicenseActivity(int baseLicenseID, bool newIsActive) {
            const string QUERY = "UPDATE Licenses SET IsActive = @NewIsActive WHERE LicenseID = @BaseLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("NewIsActive", newIsActive);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DeleteLicense(int baseLicenseID) {
            const string QUERY = "DELETE FROM Licenses WHERE LicenseID = @BaseLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LicenseID", baseLicenseID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindBaseLicenseInfo(int baseLicenseID, ref int driverID, ref int applicationID, ref byte issueReason, ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID) {
            const string QUERY = "SELECT TOP 1 * FROM Licenses WHERE LicenseID = @BaseLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            driverID = (int) _reader["DriverID"];
                            applicationID = (int) _reader["ApplicationID"];
                            issueReason = (byte) _reader["IssueReason"];
                            issueDate = (DateTime) _reader["IssueDate"];
                            expirationDate = (DateTime) _reader["ExpirationDate"];
                            isActive = (bool) _reader["IsActive"];
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

        public static bool UpdateLicenseInfo(int baseLicenseID, int driverID, int applicationID, byte issueReason, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID) {
            const string QUERY = "UPDATE Licenses SET DriverID = @DriverID, ApplicationID = @ApplicationID, IssueReason = @IssueReason, " +
                                 "IssueDate = @IssueDate, ExpirationDate = @ExpirationDate, IsActive = @IsActive, " +
                                 "CreatedByUserID = @CreatedByUserID WHERE LicenseID = @BaseLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("DriverID", driverID);
                _command.Parameters.AddWithValue("ApplicationID", applicationID);
                _command.Parameters.AddWithValue("IssueReason", issueReason);
                _command.Parameters.AddWithValue("IssueDate", issueDate);
                _command.Parameters.AddWithValue("ExpirationDate", expirationDate);
                _command.Parameters.AddWithValue("IsActive", isActive);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }
    }
}
