using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class DriverDataAccess {
        public static int AddNewDriver(int personID, int createdByUserID, DateTime dateCreated) {
            const string QUERY = "INSERT INTO Drivers (PersonID, CreatedByUserID, DateCreated) " +
                                 "VALUES (@PersonID, @CreatedByUserID, @DateCreated)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("CreatedByUserID", createdByUserID);
                _command.Parameters.AddWithValue("DateCreated", dateCreated);

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
        
        public static bool UpdateDriverInfo(int driverID, int newPersonID, int newCreatedByUserID, DateTime newDateCreated) {
            const string QUERY = "UPDATE Drivers SET PersonID = @NewPersonID, " +
                "CreatedByUserID = @NewCreatedByUserID, DateCreated = @NewDateCreated " +
                "WHERE DriverID = @DriverID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);
                _command.Parameters.AddWithValue("NewPersonID", newPersonID);
                _command.Parameters.AddWithValue("NewCreatedByUserID", newCreatedByUserID);
                _command.Parameters.AddWithValue("NewDateCreated", newDateCreated);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindDriver(int driverID, ref int personID, ref int createdByUserID, ref DateTime dateCreated) {
            const string QUERY = "SELECT TOP 1 * FROM Drivers WHERE DriverID = @DriverID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            personID = (int) _reader["PersonID"];
                            createdByUserID = (int) _reader["CreatedByUserID"];
                            dateCreated = (DateTime) _reader["DateCreated"];

                            return true;
                        }

                        return false;
                    }
                } catch (Exception) {

                    throw;
                }
            }
        }

        public static bool DeleteDriver(int driverID) {
            const string QUERY = "DELETE FROM Drivers WHERE DriverID = @DriverID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {

                    throw;
                }
            }
        }

        public static int FindDriverIdByPerson(int personID) {
            const string QUERY = "SELECT DriverID FROM Drivers WHERE PersonID = @PersonID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesDriverExist(int driverID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM Drivers WHERE DriverID = @DriverID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static DataTable GetAllDrivers() =>
            DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_AllDrivers");

        public static bool DeleteDriverIfNoLicensesAssigned(int personID) {
            const string QUERY = "DELETE FROM Drivers WHERE Drivers.PersonID = @PersonID AND " +
                "NOT EXISTS(SELECT TOP 1 R = 1 FROM Licenses WHERE Licenses.DriverID = Drivers.DriverID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);

                try {
                    _connection.Open();
                    
                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindPersonId(int driverID) {
            const string QUERY = "SELECT PersonID FROM Drivers WHERE DriverID = @DriverID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("DriverID", driverID);

                try {
                    _connection.Open();

                    return (int) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesDriverExistByPersonID(int personID) {
            const string QUERY = "SELECT TOP 1 1 FROM Drivers WHERE PersonID = @PersonID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static class Reporting {
            public static DataTable GetDriverInterLicenseHistory(int driverID, bool isActive) {
                const string QUERY = @"SELECT 
                                            InternationalLicenses.InternationalLicenseID, 
                                            Licenses.ApplicationID,
                                            InternationalLicenses.IssuedUsingLocalLicenseID, 
                                            Licenses.IssueDate,
                                            Licenses.ExpirationDate,
                                            CreatedBy = Users.Username
                                       FROM InternationalLicenses INNER JOIN Licenses 
                                       ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID LEFT JOIN Users
                                       ON Licenses.CreatedByUserID = Users.UserID
                                       WHERE Licenses.DriverID = @DriverID AND Licenses.IsActive = @IsActive
                                       ORDER BY InternationalLicenses.InternationalLicenseID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                    _command.Parameters.AddWithValue("DriverID", driverID);
                    _command.Parameters.AddWithValue("IsActive", isActive);

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

            public static DataTable GetDriverLocalLicenseHistory(int driverID, bool isActive, bool useArabic) {
                string _query = $@"SELECT 
                                        LocalLicenses.LocalLicenseID,
                                        LocalDrivingLicenseApplicationID = Licenses.ApplicationID, 
                                        LicenseClass = LicenseClasses.{(useArabic ? "ClassNameAR" : "ClassName")},
                                        Licenses.IssueDate, 
                                        Licenses.ExpirationDate, 
                                        CreatedBy = Users.Username
                                   FROM LocalLicenses INNER JOIN LicenseClasses 
                                   ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN Licenses 
                                   ON LocalLicenses.BaseLicenseID = Licenses.LicenseID LEFT JOIN Users
                                   ON Licenses.CreatedByUserID = Users.UserID
                                   WHERE Licenses.DriverID = @DriverID AND Licenses.IsActive = @IsActive
                                   ORDER BY LocalLicenses.LocalLicenseID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("DriverID", driverID);
                    _command.Parameters.AddWithValue("IsActive", isActive);

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
        }
    }
}
