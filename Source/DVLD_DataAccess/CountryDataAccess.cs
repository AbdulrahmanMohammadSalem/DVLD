using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DVLD_DataAccess {
    public static class CountryDataAccess {
        public static bool FindById(int countryID, ref string countryName, ref string countryNameAR) {
            const string QUERY = "SELECT CountryName, CountryNameAR FROM Countries WHERE CountryID = @CountryID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("CountryID", countryID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            countryName = _reader["CountryName"] as string;
                            countryNameAR = _reader["CountryNameAR"] as string;

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

        public static bool FindByDefaultName(string countryName, ref int countryID, ref string countryNameAR) {
            const string QUERY = "SELECT CountryID, CountryNameAR FROM Countries WHERE CountryName = @CountryName";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("CountryName", countryName);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            countryID = (byte) _reader["CountryID"];
                            countryNameAR = _reader["CountryNameAR"] as string;

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


        public static bool FindByArabicName(string countryNameAR, ref int countryID, ref string countryName) {
            const string QUERY = "SELECT CountryID, CountryName FROM Countries WHERE CountryNameAR = @CountryNameAR";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("CountryNameAR", countryNameAR);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            countryID = (byte) _reader["CountryID"];
                            countryName = _reader["CountryName"] as string;

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

        public static string[] GetAllCountryDefaultNames() =>
            DataAccessUtils.ExecuteForStringArray("SELECT CountryName FROM Countries");

        public static string[] GetAllCountryArabicNames() =>
            DataAccessUtils.ExecuteForStringArray("SELECT CountryNameAR FROM Countries");
    }
}
