using DVLD_DataAccess.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class UserDataAccess {
        public static bool DeleteUser(int userID) {
            const string QUERY = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("UserID", userID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesUserExistByPersonID(int personID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM Users WHERE PersonID = @PersonID";

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

        public static bool FindUserById(int userID, ref int personID, ref string username, ref string password, ref bool isActive, ref int permissionsID) {
            const string QUERY = "SELECT TOP 1 * FROM Users WHERE UserID = @UserID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("UserID", userID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            personID = (int) _reader["PersonID"];
                            username = _reader["Username"] as string;
                            password = _reader["Password"] as string;
                            isActive = (bool) _reader["IsActive"];
                            permissionsID = (int) _reader["PermissionsID"];

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

        public static bool FindUserByUsernameAndPassword(ref string username, ref string password, ref int userID, ref int personID, ref bool isActive, ref int permissionsID) {
            const string QUERY = "SELECT TOP 1 * FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("Username", username);
                _command.Parameters.AddWithValue("Password", password);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            userID = (int) _reader["UserID"];
                            personID = (int) _reader["PersonID"];
                            isActive = (bool) _reader["IsActive"];
                            permissionsID = (int) _reader["PermissionsID"];

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

        public static DataView GetAllUsers() => DataAccessUtils.ExecuteForDataView("SELECT * FROM VU_AllUsers");

        public static int AddNewUser(int personID, string username, string password, bool isActive, int permissionsID) {
            const string QUERY = "INSERT INTO Users (PersonID, Username, Password, IsActive, PermissionsID) VALUES " +
                                    "(@PersonID, @Username, @Password, @IsActive, @PermissionsID)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("Username", username);
                _command.Parameters.AddWithValue("Password", password);
                _command.Parameters.AddWithValue("IsActive", isActive);
                _command.Parameters.AddWithValue("PermissionsID", permissionsID);

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

        public static bool UpdateUser(int userID, int personID, string username, string password, bool isActive, int permissionsID) {
            const string QUERY = "UPDATE Users " +
                                "SET PersonID = @PersonID, Username = @Username, Password = @Password, IsActive = @IsActive, PermissionsID = @PermissionsID " +
                                "WHERE UserID = @UserID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("UserID", userID);
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("Username", username);
                _command.Parameters.AddWithValue("Password", password);
                _command.Parameters.AddWithValue("IsActive", isActive);
                _command.Parameters.AddWithValue("PermissionsID", permissionsID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesUserExist(string username) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM Users WHERE Username = @Username";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("Username", username);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool UpdateUserPassword(int userId, ref string newPassword) {
            const string QUERY = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("UserID", userId);
                _command.Parameters.AddWithValue("NewPassword", newPassword);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static int FindUserIdByPersonId(int personID) {
            const string QUERY = "SELECT TOP 1 UserID FROM Users WHERE PersonID = @PersonID";

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

        public static bool CheckIfUsersAvailable() => DataAccessUtils.ExecuteForBoolean("SELECT 1 WHERE EXISTS(SELECT TOP 1 1 FROM Users)");

        public static int FindPermissionsId(int userID) {
            const string QUERY = "SELECT TOP 1 PermissionsID FROM Users WHERE UserID = @UserID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("UserID", userID);

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
            public static DataTable GetActivityTimeline(int userID, bool ascending, (DateTime StartDate, DateTime EndDate)? dateRange, bool useArabic) {
                string _query = $@"SELECT DateTime, EntityID, EntityType, Specification, Description
                                   FROM VU_UserActivities{(useArabic ? "_AR" : "")}
                                   WHERE DoneByUserID = @UserID {(dateRange.HasValue ? "AND DateTime BETWEEN @StartDate AND @EndDate" : "")}
                                   ORDER BY DateTime {(ascending ? "ASC" : "DESC")}";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("UserID", userID);

                    if (dateRange.HasValue) {
                        _command.Parameters.AddWithValue("StartDate", dateRange.Value.StartDate);
                        _command.Parameters.AddWithValue("EndDate", dateRange.Value.EndDate);
                    }

                    try {
                        _connection.Open();

                        using (var _reader = _command.ExecuteReader())
                        using (var _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataTable GetBasicActionCounts(int userID, (DateTime StartDate, DateTime EndDate)? dateRange) {
                string _query = $@"SELECT [Action], [Count] FROM (
                                	SELECT [Order] = 1, [Action] = '{StringResources.field_applicationsCreated}', [Count] = COUNT(*)
                                	FROM Applications
                                	WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND Applications.ApplicationDate BETWEEN @StartDate AND @EndDate" : "")}
                                	UNION
                                	SELECT [Order] = 2, [Action] = '{StringResources.field_testAppointsCreated}', [Count] = COUNT(*)
                                	FROM TestAppointments
                                	WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND AppointmentDate BETWEEN @StartDate AND @EndDate" : "")}
                                	UNION
                                	SELECT [Order] = 3, [Action] = '{StringResources.field_testResultsCreated}', [Count] = COUNT(*)
                                	FROM Tests INNER JOIN TestAppointments appoints
                                    ON Tests.TestAppointmentID = appoints.TestAppointmentID
                                	WHERE Tests.CreatedByUserID = @UserID {(dateRange.HasValue ? "AND appoints.AppointmentDate BETWEEN @StartDate AND @EndDate" : "")}
                                	UNION
                                	SELECT [Order] = 4, [Action] = '{StringResources.field_licensesCreated}', [Count] = COUNT(*)
                                	FROM Licenses
                                	WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND Licenses.IssueDate BETWEEN @StartDate AND @EndDate" : "")}
                                	UNION
                                	SELECT [Order] = 5, [Action] = '{StringResources.field_driversCreated}', [Count] = COUNT(*)
                                	FROM Drivers
                                	WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND Drivers.DateCreated BETWEEN @StartDate AND @EndDate" : "")}
                                	UNION
                                	SELECT [Order] = 6, [Action] = '{StringResources.field_licenseDetentionOperations}', [Count] = (SELECT COUNT(*) FROM DetainedLicenses WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND DetainedLicenses.DetainDate BETWEEN @StartDate AND @EndDate" : "")}) + (SELECT COUNT(*) FROM DetainedLicenses WHERE ReleasedByUserID = @UserID {(dateRange.HasValue ? "AND DetainedLicenses.ReleaseDate BETWEEN @StartDate AND @EndDate" : "")})
                                ) R
                                ORDER BY [Order] ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("UserID", userID);

                    if (dateRange.HasValue) {
                        _command.Parameters.AddWithValue("StartDate", dateRange.Value.StartDate);
                        _command.Parameters.AddWithValue("EndDate", dateRange.Value.EndDate);
                    }

                    try {
                        _connection.Open();

                        using (var _reader = _command.ExecuteReader())
                        using (var _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataTable GetCategorizedActionCounts(int userID, (DateTime StartDate, DateTime EndDate)? dateRange, bool useArabic) {
                string s = useArabic ? "AR" : "";
                string _query = $@"                             --APPLICATION CREATIONS
                                SELECT [Action] = '-', [Count] = 0
                                UNION ALL
                                SELECT [Action] = appTypes.ApplicationTypeTitle{s}, [Count] = COUNT(*)
                                FROM Applications apps LEFT JOIN ApplicationTypes appTypes
                                ON apps.ApplicationTypeID = appTypes.ApplicationTypeID
                                WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND apps.ApplicationDate BETWEEN @StartDate AND @EndDate" : "")}
                                GROUP BY appTypes.ApplicationTypeTitle{s}
                                UNION ALL
                                                                --TEST APPOINTMENT CREATIONS
                                SELECT '-', 0
                                UNION ALL
                                SELECT [Action], [Count] FROM (
                                	SELECT [Order] = TestTypes.TestTypeID, [Action] = TestTypes.TestTypeTitle{s}, [Count] = COUNT(*)
                                	FROM TestAppointments appoints LEFT JOIN TestTypes
                                	ON appoints.TestTypeID = TestTypes.TestTypeID
                                	WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND appoints.AppointmentDate BETWEEN @StartDate AND @EndDate" : "")}
                                	GROUP BY TestTypes.TestTypeID, TestTypes.TestTypeTitle{s}
                                ) R
                                UNION ALL
                                                                --TEST RESULTS CREATIONS
                                SELECT [Action] = '-', [Count] = 0
                                UNION ALL
                                SELECT [Action], [Count] FROM (
                                	SELECT [Order] = TestTypes.TestTypeID, [Action] = TestTypes.TestTypeTitle{s}, [Count] = COUNT(*)
                                	FROM Tests INNER JOIN TestAppointments appoints
                                	ON Tests.TestAppointmentID = appoints.TestAppointmentID LEFT JOIN TestTypes
                                	ON appoints.TestTypeID = TestTypes.TestTypeID
                                	WHERE Tests.CreatedByUserID = @UserID {(dateRange.HasValue ? "AND appoints.AppointmentDate BETWEEN @StartDate AND @EndDate" : "")}
                                	GROUP BY TestTypes.TestTypeID, TestTypes.TestTypeTitle{s}
                                ) R
                                UNION ALL
                                                                --LICENSE CREATIONS (LOCAL)
                                SELECT [Action] = '-', [Count] = 0
                                UNION ALL
                                SELECT [Action] = LicenseClasses.ClassName{s}, [Count] = COUNT(*)
                                FROM LocalLicenses INNER JOIN Licenses
                                ON LocalLicenses.BaseLicenseID = Licenses.LicenseID LEFT JOIN LicenseClasses
                                ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID
                                WHERE Licenses.CreatedByUserID = @UserID {(dateRange.HasValue ? "AND Licenses.IssueDate BETWEEN @StartDate AND @EndDate" : "")}
                                GROUP BY LicenseClasses.ClassName{s}
                                UNION ALL
                                                                --LICESNE CREATIONS (INTERNATIONAL)
                                SELECT [Action] = '-', [Count] = 0
                                UNION ALL
                                SELECT [Action] = '{StringResources.interLicense}', [Count] = COUNT(*)
                                FROM InternationalLicenses INNER JOIN Licenses
                                ON InternationalLicenses.BaseLicenseID = Licenses.LicenseID
                                WHERE Licenses.CreatedByUserID = @UserID {(dateRange.HasValue ? "AND Licenses.IssueDate BETWEEN @StartDate AND @EndDate" : "")}
                                HAVING COUNT(*) > 0
                                UNION ALL
                                                                --DRIVER CREATION
                                SELECT [Action] = '-', [Count] = 0
                                UNION ALL
                                SELECT [Action] = Countries.CountryName{s}, [Count] = COUNT(*)
                                FROM Drivers INNER JOIN People
                                ON Drivers.PersonID = People.PersonID LEFT JOIN Countries
                                ON People.NationalityCountryID = Countries.CountryID
                                WHERE Drivers.CreatedByUserID = @UserID {(dateRange.HasValue ? "AND Drivers.DateCreated BETWEEN @StartDate AND @EndDate" : "")}
                                GROUP BY Countries.CountryName{s}
                                UNION ALL
                                                                --LICENSE DETENTION OPERATIONS
                                SELECT [Action] = '-', [Count] = 0
                                UNION ALL
                                SELECT * FROM (SELECT [Action] = '{StringResources.detentions}', [Count] = (SELECT COUNT(*) FROM DetainedLicenses WHERE CreatedByUserID = @UserID {(dateRange.HasValue ? "AND DetainDate BETWEEN @StartDate AND @EndDate" : "")})) T WHERE T.[Count] > 0
                                UNION ALL
                                SELECT * FROM (SELECT [Action] = '{StringResources.releases}', [Count] = (SELECT COUNT(*) FROM DetainedLicenses WHERE ReleasedByUserID = @UserID {(dateRange.HasValue ? "AND ReleaseDate BETWEEN @StartDate AND @EndDate" : "")})) T WHERE T.[Count] > 0";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("UserID", userID);

                    if (dateRange.HasValue) {
                        _command.Parameters.AddWithValue("StartDate", dateRange.Value.StartDate);
                        _command.Parameters.AddWithValue("EndDate", dateRange.Value.EndDate);
                    }

                    try {
                        _connection.Open();

                        using (var _reader = _command.ExecuteReader())
                        using (var _table = new DataTable()) {
                            _table.Load(_reader);

                            return _table;
                        }
                    } catch (Exception) {
                        //Log the exception here...
                        throw;
                    }
                }
            }

            public static DataTable GetCategorizedActivities(int userID, (DateTime StartDate, DateTime EndDate)? dateRange, bool useArabic) {
                string _query = $@"SELECT EntityID, EntityType, DateTime, Specification, Description
                                   FROM VU_UserActivities{(useArabic ? "_AR" : "")}
                                   WHERE DoneByUserID = -1 OR DoneByUserID = @UserID {(dateRange.HasValue ? "AND DateTime BETWEEN @StartDate AND @EndDate" : "")}";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("UserID", userID);

                    if (dateRange.HasValue) {
                        _command.Parameters.AddWithValue("StartDate", dateRange.Value.StartDate);
                        _command.Parameters.AddWithValue("EndDate", dateRange.Value.EndDate);
                    }

                    try {
                        _connection.Open();

                        using (var _reader = _command.ExecuteReader())
                        using (var _table = new DataTable()) {
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
