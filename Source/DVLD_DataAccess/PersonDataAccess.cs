using DVLD_DataAccess.Properties;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {

    public static class PersonDataAccess {
        public static int AddNewPerson(string nationalNum, string firstName, string secondName, string thirdName, string lastName, char gender, DateTime dateOfBirth, string address, string phoneNumber, string email, int nationalityCountryID, string imagePath) {
            const string QUERY = "INSERT INTO People (NationalNum, FirstName, SecondName, ThirdName, LastName, Gender, DateOfBirth, Address, PhoneNumber, Email, NationalityCountryID, ImagePath) " +
                "VALUES " +
                "(@NationalNum, @FirstName, @SecondName, @ThirdName, @LastName, @Gender, @DateOfBirth, @Address, @PhoneNumber, @Email, @NationalityCountryID, @ImagePath)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("NationalNum", nationalNum);
                _command.Parameters.AddWithValue("FirstName", firstName);
                _command.Parameters.AddWithValue("SecondName", secondName);
                _command.Parameters.AddWithValue("LastName", lastName);
                _command.Parameters.AddWithValue("Gender", gender);
                _command.Parameters.AddWithValue("DateOfBirth", dateOfBirth);
                _command.Parameters.AddWithValue("Address", address);
                _command.Parameters.AddWithValue("PhoneNumber", phoneNumber);
                _command.Parameters.AddWithValue("NationalityCountryID", nationalityCountryID);

                if (email is null)
                    _command.Parameters.AddWithValue("Email", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("Email", email);

                if (thirdName is null)
                    _command.Parameters.AddWithValue("ThirdName", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ThirdName", thirdName);

                if (imagePath is null)
                    _command.Parameters.AddWithValue("ImagePath", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ImagePath", imagePath);

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

        public static bool DeletePerson(int personID) {
            const string QUERY = "DELETE FROM People WHERE PersonID = @PersonID";

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

        public static bool DoesPersonExist(ref string nationalNum) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM People WHERE NationalNum = @NationalNum";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("NationalNum", nationalNum);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesPersonExist(int personID) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM People WHERE PersonID = @PersonID";

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

        public static bool FindById(int personID, ref string nationalNum, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref char gender, ref DateTime dateOfBirth, ref string address, ref string phoneNumber, ref string email, ref int nationalityCountryID, ref string imagePath) {
            const string QUERY = "SELECT TOP 1 * FROM People WHERE PersonID = @PersonID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            nationalNum = _reader["NationalNum"] as string;
                            firstName = _reader["FirstName"] as string;
                            secondName = _reader["SecondName"] as string;
                            thirdName = _reader["ThirdName"] as string;
                            lastName = _reader["LastName"] as string;
                            gender = (_reader["Gender"] as string)[0];
                            dateOfBirth = (DateTime) _reader["DateOfBirth"];
                            address = _reader["Address"] as string;
                            phoneNumber = _reader["PhoneNumber"] as string;
                            email = _reader["Email"] as string;
                            nationalityCountryID = (byte) _reader["NationalityCountryID"];
                            imagePath = _reader["ImagePath"] as string;

                            return true;
                        } else
                            return false;
                    }

                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindByNationalNum(ref string nationalNum, ref int personID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref char gender, ref DateTime dateOfBirth, ref string address, ref string phoneNumber, ref string email, ref int nationalityCountryID, ref string imagePath) {
            const string QUERY = "SELECT TOP 1 * FROM People WHERE NationalNum = @NationalNum";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("NationalNum", nationalNum);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            personID = (int) _reader["PersonID"];
                            firstName = _reader["FirstName"] as string;
                            secondName = _reader["SecondName"] as string;
                            thirdName = _reader["ThirdName"] as string;
                            lastName = _reader["LastName"] as string;
                            gender = (_reader["Gender"] as string)[0];
                            dateOfBirth = (DateTime) _reader["DateOfBirth"];
                            address = _reader["Address"] as string;
                            phoneNumber = _reader["PhoneNumber"] as string;
                            email = _reader["Email"] as string;
                            nationalityCountryID = (byte) _reader["NationalityCountryID"];
                            imagePath = _reader["ImagePath"] as string;

                            return true;
                        } else
                            return false;
                    }

                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static DataTable GetAllPeople_Arabic() => DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_AllPeople_AR");

        public static DataTable GetAllPeople_Default() => DataAccessUtils.ExecuteForDataTable("SELECT * FROM VU_AllPeople");

        public static bool UpdatePerson(int personID, string nationalNum, string firstName, string secondName, string thirdName, string lastName, char gender, DateTime dateOfBirth, string address, string phoneNumber, string email, int nationalityCountryID, string imagePath) {
            const string QUERY = "UPDATE People " +
                "SET NationalNum = @NationalNum," +
                " FirstName = @FirstName," +
                " SecondName = @SecondName," +
                " ThirdName = @ThirdName," +
                " LastName = @LastName," +
                " Gender = @Gender," +
                " DateOfBirth = @DateOfBirth," +
                " Address = @Address," +
                " PhoneNumber = @PhoneNumber," +
                " Email = @Email," +
                " NationalityCountryID = @NationalityCountryID," +
                " ImagePath = @ImagePath " +
                "WHERE PersonID = @PersonID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PersonID", personID);
                _command.Parameters.AddWithValue("NationalNum", nationalNum);
                _command.Parameters.AddWithValue("FirstName", firstName);
                _command.Parameters.AddWithValue("SecondName", secondName);
                _command.Parameters.AddWithValue("LastName", lastName);
                _command.Parameters.AddWithValue("Gender", gender);
                _command.Parameters.AddWithValue("DateOfBirth", dateOfBirth);
                _command.Parameters.AddWithValue("Address", address);
                _command.Parameters.AddWithValue("PhoneNumber", phoneNumber);
                _command.Parameters.AddWithValue("NationalityCountryID", nationalityCountryID);

                if (email is null)
                    _command.Parameters.AddWithValue("Email", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("Email", email);

                if (thirdName is null)
                    _command.Parameters.AddWithValue("ThirdName", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ThirdName", thirdName);

                if (imagePath is null)
                    _command.Parameters.AddWithValue("ImagePath", DBNull.Value);
                else
                    _command.Parameters.AddWithValue("ImagePath", imagePath);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }

        }

        public static class Reporting {
            public static DataTable GetDetentionsView(int personID, ref (DateTime StartDate, DateTime EndDate)? dateRange) {
                string _query = $@"SELECT 
                                	detentions.DetainID,
                                	LocalLicenseID = (
                                		SELECT TOP 1 LocalLicenses.LocalLicenseID 
                                		FROM LocalLicenses INNER JOIN Licenses
                                		ON LocalLicenses.BaseLicenseID = Licenses.LicenseID
                                		WHERE Licenses.LicenseID = detentions.BaseLicenseID
                                	),
                                	detentions.FineFees,
                                	detentions.DetainReason,
                                	detentions.DetainDate,
                                	CreatedBy = detainUsers.Username,
                                	IsReleased = CASE WHEN detentions.IsReleased = 1 THEN '{StringResources.yes}' ELSE '{StringResources.no}' END,
                                	detentions.ReleaseDate,
                                	ReleasedBy = releaseUsers.Username,
                                	detentions.ReleaseApplicationID
                                FROM DetainedLicenses detentions LEFT JOIN Users detainUsers
                                ON detentions.CreatedByUserID = detainUsers.UserID LEFT JOIN Users releaseUsers
                                ON detentions.ReleasedByUserID = releaseUsers.UserID INNER JOIN Licenses
                                ON detentions.BaseLicenseID = Licenses.LicenseID INNER JOIN Drivers
                                ON Licenses.DriverID = Drivers.DriverID
                                WHERE Drivers.PersonID = @PersonID  {(dateRange != null ? "AND detentions.DetainDate BETWEEN @StartDate AND @EndDate" : "")}
                                ORDER BY detentions.IsReleased ASC, detentions.DetainID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("PersonID", personID);

                    if (dateRange != null) {
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

            public static DataTable GetInternationalLicensesView(int personID, ref (DateTime StartDate, DateTime EndDate)? dateRange) {
                string _query = $@"SELECT 
                                	interLicenses.InternationalLicenseID,
                                	Licenses.IssueDate,
                                	Licenses.ExpirationDate,
                                	IsActive = CASE WHEN Licenses.IsActive = 1 AND GETDATE() < Licenses.ExpirationDate THEN '{StringResources.yes}' ELSE '{StringResources.no}' END,
                                	Licenses.ApplicationID,
                                    apps.FeesPaid,
                                	interLicenses.IssuedUsingLocalLicenseID,
                                	Users.Username
                                FROM InternationalLicenses interLicenses INNER JOIN Licenses
                                ON interLicenses.BaseLicenseID = Licenses.LicenseID INNER JOIN Users
                                ON Licenses.CreatedByUserID = Users.UserID INNER JOIN Drivers
                                ON Licenses.DriverID = Drivers.DriverID INNER JOIN Applications apps
                                ON Licenses.ApplicationID = apps.ApplicationID
                                WHERE Drivers.PersonID = @PersonID  {(dateRange != null ? "AND Licenses.IssueDate BETWEEN @StartDate AND @EndDate" : "")}
                                ORDER BY Licenses.IsActive DESC, interLicenses.InternationalLicenseID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("PersonID", personID);

                    if (dateRange != null) {
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

            public static DataTable GetLocalLicenseApplicationsView(int personID, ref (DateTime StartDate, DateTime EndDate)? dateRange, bool useArabic) {
                string _query = $@"SELECT 
                                     	ldlApps.LocalDrivingLicenseApplicationID,
                                     	ClassName = LicenseClasses.{(useArabic ? "ClassNameAR" : "ClassName")},
                                     	apps.ApplicationDate,
                                     	PassedTestCount = (
                                     		SELECT COUNT(CASE WHEN Tests.TestResults = 1 THEN 1 END)
                                     		FROM Tests INNER JOIN TestAppointments
                                     		ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID AND Tests.TestResults = 1
                                     		WHERE TestAppointments.LocalDrivingLicenseApplicationID = ldlApps.LocalDrivingLicenseApplicationID
                                     	),
                                     	ApplicationStatus = CASE WHEN apps.ApplicationStatus = 1 THEN '{StringResources.app_new}' WHEN apps.ApplicationStatus = 2 THEN '{StringResources.app_completed}' WHEN apps.ApplicationStatus = 3 THEN '{StringResources.app_cancelled}' END,
                                     	apps.UpdateStatusDate,
                                     	apps.FeesPaid,
                                     	Users.Username
                                     FROM LocalDrivingLicenseApplications ldlApps INNER JOIN Applications apps
                                     ON ldlApps.ApplicationID = apps.ApplicationID INNER JOIN LicenseClasses
                                     ON ldlApps.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN Users
                                     ON apps.CreatedByUserID = Users.UserID
                                     WHERE apps.ApplicantPersonID = @PersonID {(dateRange != null ? "AND apps.ApplicationDate BETWEEN @StartDate AND @EndDate" : "")}
                                     ORDER BY ldlApps.LocalDrivingLicenseApplicationID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("PersonID", personID);

                    if (dateRange != null) {
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

            public static DataTable GetLocalLicensesView(int personID, ref (DateTime StartDate, DateTime EndDate)? dateRange) {
                string _query = $@"SELECT 
                                	LocalLicenses.LocalLicenseID,
                                	LicenseClasses.ClassName, 
                                	IssueReason = CASE WHEN Licenses.IssueReason = 1 THEN '{StringResources._new}' WHEN Licenses.IssueReason = 2 THEN '{StringResources.replacementForLost}' WHEN Licenses.IssueReason = 3 THEN '{StringResources.replacementForDamaged}' WHEN Licenses.IssueReason = 4 THEN '{StringResources.renewal}' END,
                                	Licenses.IssueDate,
                                	Licenses.ExpirationDate,
                                	IsActive = CASE WHEN Licenses.IsActive = 1 AND GETDATE() < Licenses.ExpirationDate THEN '{StringResources.yes}' ELSE '{StringResources.no}' END,
                                	LocalLicenses.Notes,
                                	LocalLicenses.LicenseClassPaidFees,
                                	Users.Username
                                FROM LocalLicenses INNER JOIN LicenseClasses
                                ON LocalLicenses.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN Licenses
                                ON LocalLicenses.BaseLicenseID = Licenses.LicenseID INNER JOIN Users
                                ON Licenses.CreatedByUserID = Users.UserID INNER JOIN Drivers
                                ON Licenses.DriverID = Drivers.DriverID
                                WHERE Drivers.PersonID = @PersonID {(dateRange != null ? "AND Licenses.IssueDate BETWEEN @StartDate AND @EndDate" : "")}
                                ORDER BY Licenses.IsActive DESC, LocalLicenses.LocalLicenseID";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("PersonID", personID);

                    if (dateRange != null) {
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

            public static DataTable GetOtherAppsView(int personID, ref (DateTime StartDate, DateTime EndDate)? dateRange, bool useArabic) {
                string _query = $@"SELECT 
                                     	apps.ApplicationID,
                                     	ApplicationTypeTitle = appTypes.{(useArabic ? "ApplicationTypeTitleAR" : "ApplicationTypeTitle")},
                                     	apps.ApplicationDate,
                                     	apps.FeesPaid,
                                     	Users.Username
                                     FROM Applications apps INNER JOIN ApplicationTypes appTypes
                                     ON apps.ApplicationTypeID = appTypes.ApplicationTypeID INNER JOIN Users
                                     ON apps.CreatedByUserID = Users.UserID
                                     WHERE apps.ApplicationTypeID <> 1 AND apps.ApplicantPersonID = @PersonID {(dateRange != null ? "AND apps.ApplicationDate BETWEEN @StartDate AND @EndDate" : "")}";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("PersonID", personID);

                    if (dateRange != null) {
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

            public static DataTable GetTestsView(int personID, byte testTypeID, ref (DateTime StartDate, DateTime EndDate)? dateRange, bool useArabic) {
                string _query = $@"SELECT 
                                	appoints.TestAppointmentID,
                                	appoints.LocalDrivingLicenseApplicationID, 
                                	ClassName = LicenseClasses.{(useArabic ? "ClassNameAR" : "ClassName")}, 
                                	appoints.AppointmentDate, 
                                	TestResult = CASE WHEN Tests.TestResults = 1 THEN '{StringResources.pass}' ELSE '{StringResources.fail}' END,
                                	IsLocked = CASE WHEN appoints.IsLocked = 1 THEN '{StringResources.yes}' ELSE '{StringResources.no}' END,
                                	retakeApps.ApplicationID,
                                	TotalPaidFees = appoints.FeesPaid + ISNULL(retakeApps.FeesPaid, 0),
                                	AppointCreatedBy = appointUsers.Username,
                                	TestCreatedBy = testUsers.Username
                                FROM TestAppointments appoints LEFT JOIN Applications retakeApps 
                                ON appoints.RetakeFailedTestApplicationID = retakeApps.ApplicationID LEFT JOIN Tests
                                ON Tests.TestAppointmentID = appoints.TestAppointmentID INNER JOIN LocalDrivingLicenseApplications
                                ON appoints.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN LicenseClasses 
                                ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN Applications apps 
                                ON LocalDrivingLicenseApplications.ApplicationID = apps.ApplicationID LEFT JOIN Users appointUsers
                                ON appoints.CreatedByUserID = appointUsers.UserID LEFT JOIN Users testUsers
                                ON Tests.CreatedByUserID = testUsers.UserID
                                WHERE apps.ApplicantPersonID = @PersonID AND appoints.TestTypeID = @TestTypeID {(dateRange != null ? "AND apps.ApplicationDate BETWEEN @StartDate AND @EndDate" : "")}
                                ORDER BY appoints.LocalDrivingLicenseApplicationID ASC, appoints.TestAppointmentID ASC";

                using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
                using (SqlCommand _command = new SqlCommand(_query, _connection)) {
                    _command.Parameters.AddWithValue("PersonID", personID);
                    _command.Parameters.AddWithValue("TestTypeID", testTypeID);

                    if (dateRange != null) {
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
