using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class LocalDrivingLicenseDataAccess {
        public static int AddNewLocalDrivingLicense(int baseLicenseID, byte licenseClassID, decimal? licenseClassPaidFees, string notes) {
            const string QUERY = "INSERT INTO LocalLicenses (BaseLicenseID, LicenseClassID, LicenseClassPaidFees, Notes) " +
                                 "VALUES (@BaseLicenseID, @LicenseClassID, @LicenseClassPaidFees, @Notes)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                if (notes is null)
                    _command.Parameters.AddWithValue("Notes", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("Notes", notes);

                if (licenseClassPaidFees is null)
                    _command.Parameters.AddWithValue("LicenseClassPaidFees", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("LicenseClassPaidFees", licenseClassPaidFees);

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

        public static bool DoesActiveLicenseExistForPerson(int personID, byte licenseClassID) {
            const string QUERY = "SELECT R = 1 FROM LocalLicenses " +
                                 "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                                 "INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID " +
                                 "INNER JOIN People ON Drivers.PersonID = People.PersonID " +
                                 "WHERE People.PersonID = @PersonID AND LocalLicenses.LicenseClassID = @LicenseClassID AND Licenses.IsActive = 1";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindLicenseID_ByLocalDrivingLicenseAppID(int localDrivingLicenseAppID, byte licenseClassID) {
            const string QUERY = "SELECT TOP 1 LocalLicenses.LocalLicenseID FROM LocalLicenses " +
                "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE Licenses.ApplicationID = (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) AND LocalLicenses.LicenseClassID = @LicenseClassID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseApplicationID", localDrivingLicenseAppID);
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

        public static bool FindLocalLicenseInfo(int localDrivingLicenseID, ref int baseLicenseID, ref byte licenseClassID, ref decimal? licenseClassPaidFees, ref string notes) {
            const string QUERY = "SELECT TOP 1 * FROM LocalLicenses WHERE LocalLicenseID = @LocalDrivingLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            baseLicenseID = (int) _reader["BaseLicenseID"];
                            licenseClassID = (byte) _reader["LicenseClassID"];
                            licenseClassPaidFees = _reader["LicenseClassPaidFees"] == DBNull.Value ? null : (decimal?) _reader["LicenseClassPaidFees"];
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

        private static DataView _GetPreferredLocalLicensesView_Generic(int driverID, string columnName) {
            string query = $"SELECT LocalLicenses.LocalLicenseID, Licenses.ApplicationID AS LocalDrivingLicenseApplicationID, LicenseClasses.{columnName}, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive, LocalLicenses.LicenseClassID " +
                            "FROM LocalLicenses " +
                            "INNER JOIN LicenseClasses ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID " +
                            "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                            "WHERE Licenses.DriverID = @DriverID " +
                            "ORDER BY Licenses.IsActive DESC";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(query, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

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

        public static DataView GetPreferredLocalLicensesView_Arabic(int driverID) =>
            _GetPreferredLocalLicensesView_Generic(driverID, "ClassNameAR");

        public static DataView GetPreferredLocalLicensesView_Default(int driverID) =>
            _GetPreferredLocalLicensesView_Generic(driverID, "ClassName");

        public static bool UpdateLocalDrivingLicenseInfo(int localDrivingLicenseID, int baseLicenseID, byte licenseClassID, decimal? licenseClassPaidFees, string notes) {
            const string QUERY = "UPDATE LocalLicenses " +
                                 "SET BaseLicenseID = @BaseLicenseID, LicenseClassID = @LicenseClassID, LicenseClassPaidFees = @LicenseClassPaidFees, Notes = @Notes " +
                                 "WHERE LocalLicenseID = @LocalDrivingLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseID", localDrivingLicenseID);
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                if (notes is null)
                    _command.Parameters.AddWithValue("Notes", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("Notes", notes);

                if (licenseClassPaidFees is null)
                    _command.Parameters.AddWithValue("LicenseClassPaidFees", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("LicenseClassPaidFees", licenseClassPaidFees);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesLicenseExistForPerson(int personID, byte licenseClassID) {
            const string QUERY = "SELECT R = 1 FROM LocalLicenses " +
                                 "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                                 "INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID " +
                                 "INNER JOIN People ON Drivers.PersonID = People.PersonID " +
                                 "WHERE People.PersonID = @PersonID AND LocalLicenses.LicenseClassID = @LicenseClassID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool CheckIfLicenseActive(int localDrivingLicenseID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM LocalLicenses " +
                "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE LocalLicenses.LocalLicenseID = @LocalLicenseID AND Licenses.IsActive = 1 AND GETDATE() BETWEEN Licenses.IssueDate AND Licenses.ExpirationDate";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();
                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static byte FindLicenseClass(int localDrivingLicenseID) {
            const string QUERY = "SELECT TOP 1 LicenseClassID FROM LocalLicenses WHERE LocalLicenseID = @LocalLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();

                    return (byte) (_command.ExecuteScalar() ?? 0);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindActiveLicenseIdByDriverId(int driverID, byte licenseClass) {
            const string QUERY = "SELECT TOP 1 LocalLicenses.LocalLicenseID FROM LocalLicenses " +
                "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE Licenses.DriverID = @DriverID AND LocalLicenses.LicenseClassID = @LicenseClassID AND Licenses.IsActive = 1";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClass);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesDriverOwnActiveLocalLicenseOfClass(int driverID, byte licenseClassID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM LocalLicenses " +
                "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE Licenses.DriverID = @DriverID AND Licenses.IsActive = 1 AND LocalLicenses.LicenseClassID = @LicenseClassID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);
                _command.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static DataView GetAllLocalLicenses_AR() =>
            DataAccessUtils.ExecuteForDataView("SELECT * FROM VU_LocalLicenses_AR ORDER BY IsActive DESC");

        public static DataView GetAllLocalLicenses_Default() =>
            DataAccessUtils.ExecuteForDataView("SELECT * FROM VU_LocalLicenses_Default ORDER BY IsActive DESC");

        public static int FindBaseLicenseID(int localDrivingLicenseID) {
            const string QUERY = "SELECT TOP 1 BaseLicenseID FROM LocalLicenses WHERE LocalLicenseID = @LocalDrivingLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindLocalLicenseID(int baseLicenseID) {
            const string QUERY = "SELECT TOP 1 LocalLicenseID FROM LocalLicenses WHERE BaseLicenseID = @BaseLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseLicenseID", baseLicenseID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindDriverId(int localDrivingLicenseID) {
            const string QUERY = "SELECT TOP 1 Licenses.DriverID FROM LocalLicenses " +
                "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "WHERE LocalLicenses.LocalLicenseID = @LocalDrivingLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindPersonId(int localDrivingLicenseID) {
            const string QUERY = "SELECT TOP 1 People.PersonID FROM LocalLicenses " +
                "INNER JOIN Licenses ON LocalLicenses.BaseLicenseID = Licenses.LicenseID " +
                "INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID " +
                "INNER JOIN People ON Drivers.PersonID = People.PersonID " +
                "WHERE LocalLicenses.LocalLicenseID = @LocalDrivingLicenseID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("LocalDrivingLicenseID", localDrivingLicenseID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static decimal GetClassPaidFeesByApplication(int baseApplicationID) {
            const string QUERY = @"SELECT TOP 1 LocalLicenses.LicenseClassPaidFees
                                   FROM LocalLicenses INNER JOIN Licenses
                                   ON LocalLicenses.BaseLicenseID = Licenses.LicenseID
                                   WHERE Licenses.ApplicationID = @BaseApplicationID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseApplicationID", baseApplicationID);

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
    }
}
