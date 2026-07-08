using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class ApplicationTypeDataAccess {
        public static bool FindApplicationType(int applicationTypeID, ref string title, ref string titleAR, ref decimal fees) {
            const string QUERY = "SELECT TOP 1 * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationTypeID", applicationTypeID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            title = _reader["ApplicationTypeTitle"] as string;
                            titleAR = _reader["ApplicationTypeTitleAR"] as string;
                            fees = (decimal) _reader["ApplicationTypeFees"];

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

        public static DataView GetAllApplicationTypes_Arabic() =>
            DataAccessUtils.ExecuteForDataView("SELECT ApplicationTypeID, ApplicationTypeTitleAR, ApplicationTypeFees FROM ApplicationTypes");

        public static DataView GetAllApplicationTypes_Default() =>
            DataAccessUtils.ExecuteForDataView("SELECT ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees FROM ApplicationTypes");

        public static decimal GetApplicationTypeFees(byte applicationTypeID) {
            const string QUERY = "SELECT TOP 1 ApplicationTypeFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationTypeID", applicationTypeID);

                try {
                    _connection.Open();

                    return (decimal) (_command.ExecuteScalar() ?? -1);
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static string[] GetTypeTitles_AR() =>
            DataAccessUtils.ExecuteForStringArray("SELECT ApplicationTypeTitleAR FROM ApplicationTypes");

        public static string[] GetTypeTitles_Default() =>
            DataAccessUtils.ExecuteForStringArray("SELECT ApplicationTypeTitle FROM ApplicationTypes");

        public static bool UpdateApplicationTypeFees(int applicationTypeID, decimal newFees) {
            const string QUERY = "UPDATE ApplicationTypes SET " +
                                 "ApplicationTypeFees = @NewFees " +
                                 "WHERE ApplicationTypeID = @ApplicationTypeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ApplicationTypeID", applicationTypeID);
                _command.Parameters.AddWithValue("NewFees", newFees);

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
