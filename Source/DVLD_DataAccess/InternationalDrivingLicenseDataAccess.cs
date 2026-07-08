using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class InternationalDrivingLicenseDataAccess {
        public static int AddNewInternationalDrivingLicense(int baseLicenseID, int issuedUsingLocalLicenseID) {
            const string QUERY = "INSERT INTO InternationalLicenses (BaseLicenseID, IssuedUsingLocalLicenseID) " +
                "VALUES (@BaseLicenseID, @IssuedUsingLocalLicenseID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);

                try {
                    _connection.Open();

                    if (_command.ExecuteNonQuery() > 0)
                        return DataAccessUtils.SelectGlobalIdentity(_connection);

                    return -1;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DeactivateAllInterLicensesExcept(int driverID, int baseLicenseID) {
            const string QUERY = "UPDATE Licenses SET Licenses.IsActive = 0 " +
                "FROM Licenses INNER JOIN InternationalLicenses ON Licenses.LicenseID = InternationalLicenses.BaseLicenseID " +
                "WHERE Licenses.DriverID = @DriverID AND InternationalLicenses.BaseLicenseID <> @BaseLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);

                try {
                    _connection.Open();

                    _command.ExecuteNonQuery();
                    return true;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesActiveInternationalLicenseExist_ByLocalLicense(int localLicenseID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM InternationalLicenses " +
                "INNER JOIN Licenses ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE InternationalLicenses.IssuedUsingLocalLicenseID = @LocalLicenseID AND Licenses.IsActive = 1";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalLicenseID", localLicenseID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception herre...
                    throw;
                }
            }
        }

        public static bool DoesInternationalLicenseExist_ByLocalLicense(int localDrivingLicenseID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @LocalLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception herre...
                    throw;
                }
            }
        }

        public static int FindActiveLicenseID_ByLocalLicenseID(int localLicenseID) {
            const string QUERY = "SELECT TOP 1 InternationalLicenses.InternationalLicenseID " +
                "FROM InternationalLicenses " +
                "INNER JOIN Licenses ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE InternationalLicenses.IssuedUsingLocalLicenseID = @LocalLicenseID AND Licenses.IsActive = 1 AND GETDATE() BETWEEN Licenses.IssueDate AND Licenses.ExpirationDate";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalLicenseID", localLicenseID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindActiveLicenseInfo_ByDriverId(int driverID, ref int internationalLicenseID, ref int baseLicenseID, ref int issuedUsingLocalLicenseID) {
            const string QUERY = "SELECT TOP 1 InternationalLicenses.* FROM InternationalLicenses " +
                "INNER JOIN Licenses ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE Licenses.IsActive = 1 AND Licenses.DriverID = @DriverID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            internationalLicenseID = (int) _reader["InternationalLicenseID"];
                            baseLicenseID = (int) _reader["BaseLicenseID"];
                            issuedUsingLocalLicenseID = (int) _reader["IssuedUsingLocalLicenseID"];

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

        public static bool FindActiveLicenseInfo_ByLocalLicense(int issuedUsingLocalDrivingLicenseID, ref int internationalLicenseID, ref int baseLicenseID) {
            const string QUERY = "SELECT TOP 1 * FROM InternationalLicenses " +
                "INNER JOIN Licenses ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE InternationalLicenses.IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID AND Licenses.IsActive = 1";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("IssuedUsingLocalLicenseID", issuedUsingLocalDrivingLicenseID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            internationalLicenseID = (int) _reader["InternationalLicenseID"];
                            baseLicenseID = (int) _reader["BaseLicenseID"];

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

        public static bool FindInternationalLicenseInfo(int internationalLicenseID, ref int baseLicenseID, ref int issuedUsingLocalLicenseID) {
            const string QUERY = "SELECT TOP 1 * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("InternationalLicenseID", internationalLicenseID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            baseLicenseID = (int) _reader["BaseLicenseID"];
                            issuedUsingLocalLicenseID = (int) _reader["IssuedUsingLocalLicenseID"];

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

        public static DataView GetAllInternationalLicenses() =>
            DataAccessUtils.ExecuteForDataView("SELECT * FROM VU_InternationalLicenses ORDER BY IsActive DESC");

        public static DataTable GetPreferredInternationalAppsView() =>
            DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_InternationalLicenseApplications ORDER BY InternationalLicenseID ASC");

        public static DataView GetPreferredInternationalLicensesView(int driverID) {
            const string QUERY = "SELECT InternationalLicenses.InternationalLicenseID, Licenses.ApplicationID, " +
                "InternationalLicenses.IssuedUsingLocalLicenseID, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive " +
                "FROM InternationalLicenses " +
                "INNER JOIN Licenses ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE Licenses.DriverID = @DriverID " +
                "ORDER BY Licenses.IsActive DESC, InternationalLicenses.InternationalLicenseID ASC";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

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

        public static bool UpdateInternationalDrivingLicenseInfo(int internationalLicenseID, int baseLicenseID, int issuedUsingLocalLicenseID) {
            const string QUERY = "UPDATE InternationalLicenses " +
                                 "SET BaseLicenseID = @BaseLicenseID, IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID " +
                                 "WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("InternationalLicenseID", internationalLicenseID);
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID);

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
