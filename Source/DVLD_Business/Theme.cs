using DVLD_DataAccess;
using System;

namespace DVLD_Business {
    public class Theme {
        private Modes _ActiveMode = Modes.AddNew;

        private Theme(int appThemeID, ref string appThemeName, int lightColorPaletteID, int darkColorPaletteID, bool isUserDefined) {
            ThemeID = appThemeID;
            ThemeName = appThemeName;
            LightColorPaletteID = lightColorPaletteID;
            DarkColorPaletteID = darkColorPaletteID;
            IsUserDefined = isUserDefined;

            _ActiveMode = Modes.Update;
        }

        public Theme() { }

        public int ThemeID { get; private set; } = 1; //By default
        public string ThemeName { get; set; } = "Simple"; //By default
        public int LightColorPaletteID { get; set; } = 1; //By default
        public int DarkColorPaletteID { get; set; } = 2; //By default
        public bool IsUserDefined { get; set; } = false; //By default

        public override string ToString() => $"[AppThemeID = {ThemeID}, AppThemeName = \"{ThemeName}\", LightColorPaletteID = {LightColorPaletteID}, DarkColorPaletteID = {DarkColorPaletteID}, IsUserDefined = {IsUserDefined}]";

        public ThemeColorPalette LightColorPaletteInfo => ThemeColorPalette.Find(LightColorPaletteID);
        public ThemeColorPalette DarkColorPaletteInfo => ThemeColorPalette.Find(DarkColorPaletteID);

        public static Theme Find(int themeID) {
            string _themeName = string.Empty;
            int _lightColorPaletteID = -1, _darkColorPaletteID = -1;
            bool _isUserDefined = false;

            if (ThemeDataAccess.FindThemeInfo(themeID, ref _themeName, ref _lightColorPaletteID, ref _darkColorPaletteID, ref _isUserDefined))
                return new Theme(themeID, ref _themeName, _lightColorPaletteID, _darkColorPaletteID, _isUserDefined);

            return null;
        }

        public static string[] GetAllThemeNames() =>
            ThemeDataAccess.GetAllThemeNames();

        public static Theme Find(string themeName) {
            int _themeID = -1, _lightColorPaletteID = -1, _darkColorPaletteID = -1;
            bool _isUserDefined = false;

            if (ThemeDataAccess.FindThemeInfo(themeName, ref _themeID, ref _lightColorPaletteID, ref _darkColorPaletteID, ref _isUserDefined))
                return new Theme(_themeID, ref themeName, _lightColorPaletteID, _darkColorPaletteID, _isUserDefined);

            return null;
        }

        public static bool DoesExist(string themeName) =>
            ThemeDataAccess.DoesThemeExist(themeName);

        public Theme BranchIntoNewTheme(string newThemeName) {
            ThemeColorPalette _lightPaletteCopy = LightColorPaletteInfo.CreateCopy();

            if (_lightPaletteCopy is null)
                return null;

            ThemeColorPalette _darkPaletteCopy = DarkColorPaletteInfo.CreateCopy();

            if (_darkPaletteCopy is null) {
                ThemeColorPalette.Delete(_lightPaletteCopy.ColorPaletteID);
                return null;
            }

            Theme _newTheme = new Theme {
                ThemeName = newThemeName,
                LightColorPaletteID = _lightPaletteCopy.ColorPaletteID,
                DarkColorPaletteID = _darkPaletteCopy.ColorPaletteID,
                IsUserDefined = true
            };

            if (!_newTheme.Save()) {
                ThemeColorPalette.Delete(_lightPaletteCopy.ColorPaletteID);
                ThemeColorPalette.Delete(_darkPaletteCopy.ColorPaletteID);
                return null;
            }

            return _newTheme;
        }

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewTheme()) {
                    _ActiveMode = Modes.Update;
                    return true;
                }

                return false;
            }

            return _UpdateTheme();
        }

        private bool _UpdateTheme() => ThemeDataAccess.UpdateThemeInfo(ThemeID, ThemeName, LightColorPaletteID, DarkColorPaletteID, IsUserDefined);

        private bool _AddNewTheme() => (ThemeID = ThemeDataAccess.AddNewTheme(ThemeName, LightColorPaletteID, DarkColorPaletteID, IsUserDefined)) != -1;

        public bool Delete() => ThemeDataAccess.DeleteTheme(ThemeID) & ThemeColorPalette.Delete(LightColorPaletteID) & ThemeColorPalette.Delete(DarkColorPaletteID);

        public static Theme CreateNew(string themeName) {
            ThemeColorPalette _lightPalette = ThemeColorPalette.CreateNewPalette(Salem.Drawing.ColorModes.Light);

            if (_lightPalette is null)
                return null;

            ThemeColorPalette _darkPalette = ThemeColorPalette.CreateNewPalette(Salem.Drawing.ColorModes.Dark);

            if (_darkPalette is null) {
                ThemeColorPalette.Delete(_lightPalette.ColorPaletteID);
                return null;
            }

            Theme _newTheme = new Theme {
                ThemeName = themeName,
                LightColorPaletteID = _lightPalette.ColorPaletteID,
                DarkColorPaletteID = _darkPalette.ColorPaletteID,
                IsUserDefined = true,
            };

            if (_newTheme.Save())
                return _newTheme;

            ThemeColorPalette.Delete(_lightPalette.ColorPaletteID);
            ThemeColorPalette.Delete(_darkPalette.ColorPaletteID);

            return null;
        }
    }
}
