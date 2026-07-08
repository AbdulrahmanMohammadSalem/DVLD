using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class PermissionsDataAccess {
        public static int AddNewPermissions(short peopleManagement, short usersManagement, sbyte driversManagement, sbyte localLicenseAppsManagement, sbyte interLicenseAppsManagement, int tests_testAppointsManagement, short licensesManagement, sbyte licenseDetentionManagement, short lookupTablesManagement, sbyte applicationSettingsAccess, short dashboardAccess, sbyte reportsAccess) {
            const string QUERY = @"INSERT INTO [dbo].[Permissions]
                                         ([People]
                                         ,[Users]
                                         ,[Drivers]
                                         ,[LocalDrivingLicenseApplications]
                                         ,[InternationalDrivingLicenseApplications]
                                         ,[Tests_TestAppointments]
                                         ,[LicenseDetention]
                                         ,[Licenses]
                                         ,[Dashboard]
                                         ,[Reports]
                                         ,[LookupTables]
                                         ,[ApplicationSettings])
                                   VALUES
                                         (@People
                                         ,@Users
                                         ,@Drivers
                                         ,@LocalLicenseApps
                                         ,@InterLicenseApps
                                         ,@Tests_TestAppoints
                                         ,@LicenseDetention
                                         ,@Licenses
                                         ,@Dashboard
                                         ,@Reports
                                         ,@LookupTables
                                         ,@ApplicationSettings)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("People", peopleManagement);
                _command.Parameters.AddWithValue("Users", usersManagement);
                _command.Parameters.AddWithValue("Drivers", (short) driversManagement);
                _command.Parameters.AddWithValue("LocalLicenseApps", (short) localLicenseAppsManagement);
                _command.Parameters.AddWithValue("InterLicenseApps", (short) interLicenseAppsManagement);
                _command.Parameters.AddWithValue("Tests_TestAppoints", tests_testAppointsManagement);
                _command.Parameters.AddWithValue("LicenseDetention", (short) licenseDetentionManagement);
                _command.Parameters.AddWithValue("Licenses", licensesManagement);
                _command.Parameters.AddWithValue("Dashboard", dashboardAccess);
                _command.Parameters.AddWithValue("Reports", (short) reportsAccess);
                _command.Parameters.AddWithValue("LookupTables", lookupTablesManagement);
                _command.Parameters.AddWithValue("ApplicationSettings", (short) applicationSettingsAccess);

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

        public static bool DeletePermissions(int permissionsID) {
            const string QUERY = "DELETE FROM Permissions WHERE PermissionsID = @PermissionsID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
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

        public static bool FindPermissionsInfo(int permissionsID, ref short peopleManagement, ref short usersManagement, ref sbyte driversManagement, ref sbyte localLicenseAppsManagement, ref sbyte interLicenseAppsManagement, ref int tests_testAppointsManagement, ref sbyte licenseDetentionManagement, ref short licensesManagement, ref short lookupTablesManagement, ref sbyte applicationSettingsAccess, ref short dashboardAccess, ref sbyte reportsAccess) {
            const string QUERY = "SELECT TOP 1 * FROM Permissions WHERE PermissionsID = @PermissionsID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PermissionsID", permissionsID);

                try {
                    _connection.Open();

                    using (var _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            peopleManagement = (short) _reader["People"];
                            usersManagement = (short) _reader["Users"];
                            driversManagement = Convert.ToSByte(_reader["Drivers"]);
                            localLicenseAppsManagement = Convert.ToSByte(_reader["LocalDrivingLicenseApplications"]);
                            interLicenseAppsManagement = Convert.ToSByte(_reader["InternationalDrivingLicenseApplications"]);
                            tests_testAppointsManagement = (int) _reader["Tests_TestAppointments"];
                            licenseDetentionManagement = Convert.ToSByte(_reader["LicenseDetention"]);
                            licensesManagement = (short) _reader["Licenses"];
                            lookupTablesManagement = (short) _reader["LookupTables"];
                            applicationSettingsAccess = Convert.ToSByte(_reader["ApplicationSettings"]);
                            dashboardAccess = (short) _reader["Dashboard"];
                            reportsAccess = Convert.ToSByte(_reader["Reports"]);

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

        public static bool UpdatePermissionsInfo(int permissionsID, short peopleManagement, short usersManagement, sbyte driversManagement, sbyte localLicenseAppsManagement, sbyte interLicenseAppsManagement, int tests_testAppointsManagement, short licensesManagement, sbyte licenseDetentionManagement, short lookupTablesManagement, sbyte applicationSettingsAccess, short dashboardAccess, sbyte reportsAccess) {
            const string QUERY = @"UPDATE [dbo].[Permissions]
                                   SET [People] = @People
                                        ,[Users] = @Users
                                        ,[Drivers] = @Drivers
                                        ,[LocalDrivingLicenseApplications] = @LocalLicenseApps
                                        ,[InternationalDrivingLicenseApplications] = @InterLicenseApps
                                        ,[Tests_TestAppointments] = @Tests_TestAppoints
                                        ,[LicenseDetention] = @LicenseDetention
                                        ,[Licenses] = @Licenses
                                        ,[Dashboard] = @Dashboard
                                        ,[Reports] = @Reports
                                        ,[LookupTables] = @LookupTables
                                        ,[ApplicationSettings] = @ApplicationSettings
                                   WHERE [PermissionsID] = @PermissionID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PermissionID", permissionsID);
                _command.Parameters.AddWithValue("People", peopleManagement);
                _command.Parameters.AddWithValue("Users", usersManagement);
                _command.Parameters.AddWithValue("Drivers", (short) driversManagement);
                _command.Parameters.AddWithValue("LocalLicenseApps", (short) localLicenseAppsManagement);
                _command.Parameters.AddWithValue("InterLicenseApps", (short) interLicenseAppsManagement);
                _command.Parameters.AddWithValue("Tests_TestAppoints", tests_testAppointsManagement);
                _command.Parameters.AddWithValue("LicenseDetention", (short) licenseDetentionManagement);
                _command.Parameters.AddWithValue("Licenses", licensesManagement);
                _command.Parameters.AddWithValue("Dashboard", dashboardAccess);
                _command.Parameters.AddWithValue("Reports", (short) reportsAccess);
                _command.Parameters.AddWithValue("LookupTables", lookupTablesManagement);
                _command.Parameters.AddWithValue("ApplicationSettings", (short) applicationSettingsAccess);

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
