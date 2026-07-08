using System;
using System.Data.SqlClient;
using System.Drawing;

namespace DVLD_DataAccess {
    public static class ThemeDataAccess {
        public static int AddNewTheme(string themeName, int lightColorPaletteID, int darkColorPaletteID, bool isUserDefined) {
            const string QUERY = "INSERT INTO Themes (ThemeName, LightColorPaletteID, DarkColorPaletteID, IsUserDefined) " +
                "VALUES (@ThemeName, @LightColorPaletteID, @DarkColorPaletteID, @IsUserDefined)";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ThemeName", themeName);
                _command.Parameters.AddWithValue("LightColorPaletteID", lightColorPaletteID);
                _command.Parameters.AddWithValue("DarkColorPaletteID", darkColorPaletteID);
                _command.Parameters.AddWithValue("IsUserDefined", isUserDefined);

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

        public static bool DeleteTheme(int themeID) {
            const string QUERY = "DELETE FROM Themes WHERE ThemeID = @ThemeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ThemeID", themeID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool DoesThemeExist(string themeName) {
            const string QUERY = "SELECT TOP 1 R = 1 FROM Themes WHERE ThemeName = @ThemeName";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ThemeName", themeName);

                try {
                    _connection.Open();

                    return _command.ExecuteScalar() != null;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindThemeInfo(int themeID, ref string themeName, ref int lightColorPaletteID, ref int darkColorPaletteID, ref bool isUserDefined) {
            const string QUERY = "SELECT TOP 1 * FROM Themes WHERE ThemeID = @ThemeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ThemeID", themeID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            themeName = _reader["ThemeName"] as string;
                            lightColorPaletteID = (int) _reader["LightColorPaletteID"];
                            darkColorPaletteID = (int) _reader["DarkColorPaletteID"];
                            isUserDefined = (bool) _reader["IsUserDefined"];
                            
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

        public static bool FindThemeInfo(string themeName, ref int themeID, ref int lightColorPaletteID, ref int darkColorPaletteID, ref bool isUserDefined) {
            const string QUERY = "SELECT TOP 1 * FROM Themes WHERE ThemeName = @ThemeName";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ThemeName", themeName);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            themeID = (int) _reader["ThemeID"];
                            lightColorPaletteID = (int) _reader["LightColorPaletteID"];
                            darkColorPaletteID = (int) _reader["DarkColorPaletteID"];
                            isUserDefined = (bool) _reader["IsUserDefined"];

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

        public static string[] GetAllThemeNames() =>
            DataAccessUtils.ExecuteForStringArray("SELECT ThemeName FROM Themes ORDER BY ThemeID ASC");

        public static bool UpdateThemeInfo(int themeID, string themeName, int lightColorPaletteID, int darkColorPaletteID, bool isUserDefined) {
            const string QUERY = "UPDATE Themes SET " +
                "ThemeName = @ThemeName, LightColorPaletteID = @LightColorPaletteID, DarkColorPaletteID = @DarkColorPaletteID, IsUserDefined = @IsUserDefined " +
                "WHERE ThemeID = @ThemeID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ThemeID", themeID);
                _command.Parameters.AddWithValue("ThemeName", themeName);
                _command.Parameters.AddWithValue("LightColorPaletteID", lightColorPaletteID);
                _command.Parameters.AddWithValue("DarkColorPaletteID", darkColorPaletteID);
                _command.Parameters.AddWithValue("IsUserDefined", isUserDefined);

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
