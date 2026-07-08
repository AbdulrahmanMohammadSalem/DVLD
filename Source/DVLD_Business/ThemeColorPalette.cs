using DVLD_DataAccess;
using Salem.Drawing;
using System;
using System.Drawing;

namespace DVLD_Business {
    public class ThemeColorPalette {
        private Modes _ActiveMode = Modes.AddNew;

        public int ColorPaletteID { get; private set; }
        public Color BaseBackColor { get; set; }
        public Color SurfaceBackColor { get; set; }
        public Color BaseForeColor { get; set; }
        public Color AccentForeColor { get; set; }
        public Color BaseLinkColor { get; set; }
        public Color InactiveForeColor { get; set; }
        public Color StrongForeColor { get; set; }
        public Color MainMenuStripColor { get; set; }
        public Color GridHeaderCellColor { get; set; }
        public Color GridHeaderCellHighlightColor { get; set; }
        public Color SurfaceBorderColor { get; set; }
        public Color SurfaceHoverColor { get; set; }
        public Color InactiveTabBackColor { get; set; }
        public Color MenuStripItemBorderColor { get; set; }
        public Color MenuStripItemHoverBackColor { get; set; }
        public byte DateTimePickerStyle { get; set; }
        public byte SyncTextBoxStyle { get; set; }
        public byte TitleBarColorMode { get; set; }

        private ThemeColorPalette(int paletteID, ref Color baseBackColor, ref Color surfaceBackColor, ref Color baseForeColor, ref Color accentForeColor, ref Color baseLinkColor, ref Color inactiveForeColor, ref Color strongForeColor, ref Color mainMenuStripColor, ref Color gridHeaderCellColor, ref Color gridHeaderCellHighlightColor, ref Color surfaceBorderColor, ref Color surfaceHoverColor, ref Color inactiveTabBackColor, ref Color menuStripItemBorderColor, ref Color menuStripItemHoverBackColor, byte dateTimePickerStyle, byte syncTextBoxStyle, byte titleBarColorMode) {
            ColorPaletteID = paletteID;
            BaseBackColor = baseBackColor;
            SurfaceBackColor = surfaceBackColor;
            BaseForeColor = baseForeColor;
            AccentForeColor = accentForeColor;
            BaseLinkColor = baseLinkColor;
            InactiveForeColor = inactiveForeColor;
            StrongForeColor = strongForeColor;
            MainMenuStripColor = mainMenuStripColor;
            GridHeaderCellColor = gridHeaderCellColor;
            GridHeaderCellHighlightColor = gridHeaderCellHighlightColor;
            SurfaceBorderColor = surfaceBorderColor;
            SurfaceHoverColor = surfaceHoverColor;
            InactiveTabBackColor = inactiveTabBackColor;
            MenuStripItemBorderColor = menuStripItemBorderColor;
            MenuStripItemHoverBackColor = menuStripItemHoverBackColor;
            DateTimePickerStyle = dateTimePickerStyle;
            SyncTextBoxStyle = syncTextBoxStyle;
            TitleBarColorMode = titleBarColorMode;

            _ActiveMode = Modes.Update;
        }

        public ThemeColorPalette() { }

        public static ThemeColorPalette Find(int paletteID) {
            if (paletteID == -1)
                return null;

            byte _dateTimePickerStyle = 0, _syncTextBoxStyle = 0, _TitleBarColorMode = 0;
            Color _baseBackColor = Color.Empty, _surfaceBackColor = Color.Empty, _baseForeColor = Color.Empty;
            Color _accentForeColor = Color.Empty, _baseLinkColor = Color.Empty, _inactiveForeColor = Color.Empty;
            Color _strongForeColor = Color.Empty, _mainMenuStripColor = Color.Empty, _gridHeaderCellColor = Color.Empty;
            Color _gridHeaderCellHighlightColor = Color.Empty, _surfaceBorderColor = Color.Empty, _surfaceHoverColor = Color.Empty;
            Color _inactiveTabBackColor = Color.Empty, _menuStripItemBorderColor = Color.Empty, _menuStripItemHoverBackColor = Color.Empty;

            if (ThemeColorPaletteDataAccess.FindPaletteInfo(paletteID, ref _baseBackColor, ref _surfaceBackColor, ref _baseForeColor, ref _accentForeColor, ref _baseLinkColor, ref _inactiveForeColor, ref _strongForeColor, ref _mainMenuStripColor, ref _gridHeaderCellColor, ref _gridHeaderCellHighlightColor, ref _surfaceBorderColor, ref _surfaceHoverColor, ref _inactiveTabBackColor, ref _menuStripItemBorderColor, ref _menuStripItemHoverBackColor, ref _dateTimePickerStyle, ref _syncTextBoxStyle, ref _TitleBarColorMode))
                return new ThemeColorPalette(paletteID, ref _baseBackColor, ref _surfaceBackColor, ref _baseForeColor, ref _accentForeColor, ref _baseLinkColor, ref _inactiveForeColor, ref _strongForeColor, ref _mainMenuStripColor, ref _gridHeaderCellColor, ref _gridHeaderCellHighlightColor, ref _surfaceBorderColor, ref _surfaceHoverColor, ref _inactiveTabBackColor, ref _menuStripItemBorderColor, ref _menuStripItemHoverBackColor, _dateTimePickerStyle, _syncTextBoxStyle, _TitleBarColorMode);

            return null;
        }

        internal ThemeColorPalette CreateCopy() {
            ThemeColorPalette _newPalette = new ThemeColorPalette {
                BaseBackColor = BaseBackColor,
                SurfaceBackColor = SurfaceBackColor,
                BaseForeColor = BaseForeColor,
                AccentForeColor = AccentForeColor,
                BaseLinkColor = BaseLinkColor,
                InactiveForeColor = InactiveForeColor,
                StrongForeColor = StrongForeColor,
                MainMenuStripColor = MainMenuStripColor,
                GridHeaderCellColor = GridHeaderCellColor,
                GridHeaderCellHighlightColor = GridHeaderCellHighlightColor,
                SurfaceBorderColor = SurfaceBorderColor,
                SurfaceHoverColor = SurfaceHoverColor,
                InactiveTabBackColor = InactiveTabBackColor,
                MenuStripItemBorderColor = MenuStripItemBorderColor,
                MenuStripItemHoverBackColor = MenuStripItemHoverBackColor,
                DateTimePickerStyle = DateTimePickerStyle,
                SyncTextBoxStyle = SyncTextBoxStyle,
                TitleBarColorMode = TitleBarColorMode
            };

            if (_newPalette.Save())
                return _newPalette;

            return null;
        }

        public bool Save() {
            if (_ActiveMode == Modes.AddNew) {
                if (_AddNewColorPalette()) {
                    _ActiveMode = Modes.Update;
                    return true;
                }

                return false;
            }

            return _UpdateColorPalette();
        }

        private bool _UpdateColorPalette() => ThemeColorPaletteDataAccess.UpdateColorPalette(ColorPaletteID, BaseBackColor, SurfaceBackColor, BaseForeColor, AccentForeColor, BaseLinkColor, InactiveForeColor, StrongForeColor, MainMenuStripColor, GridHeaderCellColor, GridHeaderCellHighlightColor, SurfaceBorderColor, SurfaceHoverColor, InactiveTabBackColor, MenuStripItemBorderColor, MenuStripItemHoverBackColor, DateTimePickerStyle, SyncTextBoxStyle, TitleBarColorMode);

        private bool _AddNewColorPalette() => (ColorPaletteID = ThemeColorPaletteDataAccess.AddNewColorPalette(BaseBackColor, SurfaceBackColor, BaseForeColor, AccentForeColor, BaseLinkColor, InactiveForeColor, StrongForeColor, MainMenuStripColor, GridHeaderCellColor, GridHeaderCellHighlightColor, SurfaceBorderColor, SurfaceHoverColor, InactiveTabBackColor, MenuStripItemBorderColor, MenuStripItemHoverBackColor, DateTimePickerStyle, SyncTextBoxStyle, TitleBarColorMode)) != -1;

        internal static bool Delete(int colorPaletteID) =>
            ThemeColorPaletteDataAccess.DeletePalette(colorPaletteID);

        public static ThemeColorPalette CreateNewPalette(ColorModes colorMode) {
            ThemeColorPalette _newPalette = new ThemeColorPalette {
                BaseBackColor = Color.Black,
                SurfaceBackColor = Color.Black,
                BaseForeColor = Color.Black,
                AccentForeColor = Color.Black,
                BaseLinkColor = Color.Black,
                InactiveForeColor = Color.Black,
                StrongForeColor = Color.Black,
                MainMenuStripColor = Color.Black,
                GridHeaderCellColor = Color.Black,
                GridHeaderCellHighlightColor = Color.Black,
                SurfaceBorderColor = Color.Black,
                SurfaceHoverColor = Color.Black,
                InactiveTabBackColor = Color.Black,
                MenuStripItemBorderColor = Color.Black,
                MenuStripItemHoverBackColor = Color.Black,
                TitleBarColorMode = (byte) colorMode
            };

            if (colorMode == ColorModes.Light) {
                _newPalette.DateTimePickerStyle = 9;
                _newPalette.SyncTextBoxStyle = 5;
            } else {
                _newPalette.DateTimePickerStyle = 11;
                _newPalette.SyncTextBoxStyle = 6;
            }

            if (_newPalette.Save())
                return _newPalette;

            return null;
        }
    }
}
