using Salem;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;

namespace DVLD_DataAccess {
    public class ThemeColorPaletteDataAccess {
        public static int AddNewColorPalette(Color baseBackColor, Color surfaceBackColor, Color baseForeColor, Color accentForeColor, Color baseLinkColor, Color inactiveForeColor, Color strongForeColor, Color mainMenuStripColor, Color gridHeaderCellColor, Color gridHeaderCellHighlightColor, Color surfaceBorderColor, Color surfaceHoverColor, Color inactiveTabBackColor, Color menuStripItemBorderColor, Color menuStripItemHoverBackColor, byte dateTimePickerStyle, byte syncTextBoxStyle, byte titleBarColorMode) {
            const string QUERY = "INSERT INTO ThemeColorPalettes (BaseBackColor, SurfaceBackColor, BaseForeColor, AccentForeColor, BaseLinkColor, InactiveForeColor, StrongForeColor, MainMenuStripColor, GridHeaderCellColor, GridHeaderCellHighlightColor, SurfaceBorderColor, SurfaceHoverColor, InactiveTabBackColor, MenuStripItemBorderColor, MenuStripItemHoverBackColor, DateTimePickerStyle, SyncTextBoxStyle, TitleBarColorMode) " +
                "VALUES (@BaseBackColor, @SurfaceBackColor, @BaseForeColor, @AccentForeColor, @BaseLinkColor, @InactiveForeColor, @StrongForeColor, @MainMenuStripColor, @GridHeaderCellColor, @GridHeaderCellHighlightColor, @SurfaceBorderColor, @SurfaceHoverColor, @InactiveTabBackColor, @MenuStripItemBorderColor, @MenuStripItemHoverBackColor, @DateTimePickerStyle, @SyncTextBoxStyle, @TitleBarColorMode)";
            
            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("BaseBackColor", baseBackColor.ToHex(false));
                _command.Parameters.AddWithValue("SurfaceBackColor", surfaceBackColor.ToHex(false));
                _command.Parameters.AddWithValue("BaseForeColor", baseForeColor.ToHex(false));
                _command.Parameters.AddWithValue("AccentForeColor", accentForeColor.ToHex(false));
                _command.Parameters.AddWithValue("BaseLinkColor", baseLinkColor.ToHex(false));
                _command.Parameters.AddWithValue("InactiveForeColor", inactiveForeColor.ToHex(false));
                _command.Parameters.AddWithValue("StrongForeColor", strongForeColor.ToHex(false));
                _command.Parameters.AddWithValue("MainMenuStripColor", mainMenuStripColor.ToHex(false));
                _command.Parameters.AddWithValue("GridHeaderCellColor", gridHeaderCellColor.ToHex(false));
                _command.Parameters.AddWithValue("GridHeaderCellHighlightColor", gridHeaderCellHighlightColor.ToHex(false));
                _command.Parameters.AddWithValue("SurfaceBorderColor", surfaceBorderColor.ToHex(false));
                _command.Parameters.AddWithValue("SurfaceHoverColor", surfaceHoverColor.ToHex(false));
                _command.Parameters.AddWithValue("InactiveTabBackColor", inactiveTabBackColor.ToHex(false));
                _command.Parameters.AddWithValue("MenuStripItemBorderColor", menuStripItemBorderColor.ToHex(false));
                _command.Parameters.AddWithValue("MenuStripItemHoverBackColor", menuStripItemHoverBackColor.ToHex(false));
                _command.Parameters.AddWithValue("DateTimePickerStyle", dateTimePickerStyle);
                _command.Parameters.AddWithValue("SyncTextBoxStyle", syncTextBoxStyle);
                _command.Parameters.AddWithValue("TitleBarColorMode", titleBarColorMode);

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

        public static bool DeletePalette(int paletteID) {
            const string QUERY = "DELETE FROM ThemeColorPalettes WHERE ColorPaletteID = @PaletteID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PaletteID", paletteID);

                try {
                    _connection.Open();

                    return _command.ExecuteNonQuery() > 0;
                } catch (Exception) {
                    //Log the exception here...
                    throw;
                }
            }
        }

        public static bool FindPaletteInfo(int paletteID, ref Color baseBackColor, ref Color surfaceBackColor, ref Color baseForeColor, ref Color accentForeColor, ref Color baseLinkColor, ref Color inactiveForeColor, ref Color strongForeColor, ref Color mainMenuStripColor, ref Color gridHeaderCellColor, ref Color gridHeaderCellHighlightColor, ref Color surfaceBorderColor, ref Color surfaceHoverColor, ref Color inactiveTabBackColor, ref Color menuStripItemBorderColor, ref Color menuStripItemHoverBackColor, ref byte dateTimePickerStyle, ref byte syncTextBoxStyle, ref byte _titleBarColorMode) {
            const string QUERY = "SELECT TOP 1 * FROM ThemeColorPalettes WHERE ColorPaletteID = @PaletteID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("PaletteID", paletteID);

                try {
                    _connection.Open();

                    using (SqlDataReader _reader = _command.ExecuteReader()) {
                        if (_reader.Read()) {
                            _titleBarColorMode = (byte) _reader["TitleBarColorMode"];
                            dateTimePickerStyle = (byte) _reader["DateTimePickerStyle"];
                            syncTextBoxStyle = (byte) _reader["SyncTextBoxStyle"];
                            baseBackColor = Color.FromArgb(int.Parse((string) _reader["BaseBackColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            surfaceBackColor = Color.FromArgb(int.Parse((string) _reader["SurfaceBackColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            baseForeColor = Color.FromArgb(int.Parse((string) _reader["BaseForeColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            baseLinkColor = Color.FromArgb(int.Parse((string) _reader["BaseLinkColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            accentForeColor = Color.FromArgb(int.Parse((string) _reader["AccentForeColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            inactiveForeColor = Color.FromArgb(int.Parse((string) _reader["InactiveForeColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            strongForeColor = Color.FromArgb(int.Parse((string) _reader["StrongForeColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            mainMenuStripColor = Color.FromArgb(int.Parse((string) _reader["MainMenuStripColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            gridHeaderCellColor = Color.FromArgb(int.Parse((string) _reader["GridHeaderCellColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            surfaceBorderColor = Color.FromArgb(int.Parse((string) _reader["SurfaceBorderColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            gridHeaderCellHighlightColor = Color.FromArgb(int.Parse((string) _reader["GridHeaderCellHighlightColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            surfaceHoverColor = Color.FromArgb(int.Parse((string) _reader["SurfaceHoverColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            inactiveTabBackColor = Color.FromArgb(int.Parse((string) _reader["InactiveTabBackColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            menuStripItemBorderColor = Color.FromArgb(int.Parse((string) _reader["MenuStripItemBorderColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
                            menuStripItemHoverBackColor = Color.FromArgb(int.Parse((string) _reader["menuStripItemHoverBackColor"], NumberStyles.HexNumber) | unchecked((int) 0xFF000000));
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

        public static bool UpdateColorPalette(int colorPaletteID, Color baseBackColor, Color surfaceBackColor, Color baseForeColor, Color accentForeColor, Color baseLinkColor, Color inactiveForeColor, Color strongForeColor, Color mainMenuStripColor, Color gridHeaderCellColor, Color gridHeaderCellHighlightColor, Color surfaceBorderColor, Color surfaceHoverColor, Color inactiveTabBackColor, Color menuStripItemBorderColor, Color menuStripItemHoverBackColor, byte dateTimePickerStyle, byte syncTextBoxStyle, byte titleBarColorMode) {
            const string QUERY = @"
            UPDATE ThemeColorPalettes SET
                BaseBackColor = @BaseBackColor,
                SurfaceBackColor = @SurfaceBackColor,
                BaseForeColor = @BaseForeColor,
                AccentForeColor = @AccentForeColor,
                BaseLinkColor = @BaseLinkColor,
                InactiveForeColor = @InactiveForeColor,
                StrongForeColor = @StrongForeColor,
                MainMenuStripColor = @MainMenuStripColor,
                GridHeaderCellColor = @GridHeaderCellColor,
                GridHeaderCellHighlightColor = @GridHeaderCellHighlightColor,
                SurfaceBorderColor = @SurfaceBorderColor,
                SurfaceHoverColor = @SurfaceHoverColor,
                InactiveTabBackColor = @InactiveTabBackColor,
                MenuStripItemBorderColor = @MenuStripItemBorderColor,
                MenuStripItemHoverBackColor = @MenuStripItemHoverBackColor,
                DateTimePickerStyle = @DateTimePickerStyle,
                SyncTextBoxStyle = @SyncTextBoxStyle,
                TitleBarColorMode = @TitleBarColorMode
            WHERE ColorPaletteID = @ColorPaletteID";

            using (SqlConnection _connection = new SqlConnection(DataAccessSettings.ConnectionString))
            using (SqlCommand _command = new SqlCommand(QUERY, _connection)) {
                _command.Parameters.AddWithValue("ColorPaletteID", colorPaletteID);
                _command.Parameters.AddWithValue("BaseBackColor", baseBackColor.ToHex(false));
                _command.Parameters.AddWithValue("SurfaceBackColor", surfaceBackColor.ToHex(false));
                _command.Parameters.AddWithValue("BaseForeColor", baseForeColor.ToHex(false));
                _command.Parameters.AddWithValue("AccentForeColor", accentForeColor.ToHex(false));
                _command.Parameters.AddWithValue("BaseLinkColor", baseLinkColor.ToHex(false));
                _command.Parameters.AddWithValue("InactiveForeColor", inactiveForeColor.ToHex(false));
                _command.Parameters.AddWithValue("StrongForeColor", strongForeColor.ToHex(false));
                _command.Parameters.AddWithValue("MainMenuStripColor", mainMenuStripColor.ToHex(false));
                _command.Parameters.AddWithValue("GridHeaderCellColor", gridHeaderCellColor.ToHex(false));
                _command.Parameters.AddWithValue("GridHeaderCellHighlightColor", gridHeaderCellHighlightColor.ToHex(false));
                _command.Parameters.AddWithValue("SurfaceBorderColor", surfaceBorderColor.ToHex(false));
                _command.Parameters.AddWithValue("SurfaceHoverColor", surfaceHoverColor.ToHex(false));
                _command.Parameters.AddWithValue("InactiveTabBackColor", inactiveTabBackColor.ToHex(false));
                _command.Parameters.AddWithValue("MenuStripItemBorderColor", menuStripItemBorderColor.ToHex(false));
                _command.Parameters.AddWithValue("MenuStripItemHoverBackColor", menuStripItemHoverBackColor.ToHex(false));
                _command.Parameters.AddWithValue("DateTimePickerStyle", dateTimePickerStyle);
                _command.Parameters.AddWithValue("SyncTextBoxStyle", syncTextBoxStyle);
                _command.Parameters.AddWithValue("TitleBarColorMode", titleBarColorMode);

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
