using DVLD.Common;
using DVLD.Properties;
using Microsoft.Win32;
using Salem.Drawing;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace DVLD {
    internal static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeCultures();
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English ? GlobalFields.EnglishCulture : GlobalFields.ArabicCulture;

            var _loadingScreen = new Frm_Loading();
            _loadingScreen.Show();
            _loadingScreen.Refresh();
            
            InitializeOtherFields();

            DVLD_Business.Theme _savedTheme = DVLD_Business.Theme.Find(Settings.Default.CurrentThemeID);
            
            Settings.Default.ApplyColorPaletteSettings(Settings.Default.GetCurrentColorMode() == ColorModes.Light ? _savedTheme.LightColorPaletteInfo : _savedTheme.DarkColorPaletteInfo);
            Settings.Default.ApplyToolStripRendererStyleSettings(GlobalFields.ToolStripRenderer);

            //Application.Run(new Frm_Test());

            Settings.Default.SettingsSaving += Default_SettingsSaving;
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;

            KillLoadingScreen(_loadingScreen);
            StartApplicationMainLoop();
            
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            SystemEvents.UserPreferenceChanged -= SystemEvents_UserPreferenceChanged;
        }

        private static void KillLoadingScreen(Frm_Loading loadingScreen) {
            loadingScreen.Close();
            loadingScreen.Dispose();
        }

        private static void InitializeOtherFields() {
            GlobalFields.InstalledFontFamilies = DrawingHelpers.GetInstalledFontFamilyNames(false, System.Drawing.FontStyle.Regular);
            GlobalFields.ToolStripRenderer = new Salem.Controls.Renderers.SalToolStripRenderer();
        }

        private static void InitializeCultures() {
            GlobalFields.EnglishCulture = new CultureInfo("en");
            GlobalFields.ArabicCulture = new CultureInfo("ar");
            GlobalFields.ArabicCulture.DateTimeFormat.Calendar = new GregorianCalendar();
            GlobalFields.ArabicCulture.NumberFormat.CurrencySymbol = "$";
            GlobalFields.ArabicCulture.NumberFormat.CurrencyPositivePattern = 0;
        }

        private static void StartApplicationMainLoop() {
            Frm_MainScreen _frmMainScreen;
            Login.Frm_LoginScreen _frmLoginScreen;

            do {
                Application.Run(_frmLoginScreen = new Login.Frm_LoginScreen());

                if (_frmLoginScreen.LoginSuccessful)
                    Application.Run(_frmMainScreen = new Frm_MainScreen());
                else
                    _frmMainScreen = null;
            } while (_frmMainScreen != null && _frmMainScreen.SignOut);
        }

        private static void Default_SettingsSaving(object sender, System.ComponentModel.CancelEventArgs e) => 
            Settings.Default.ApplyToolStripRendererStyleSettings(GlobalFields.ToolStripRenderer);

        private static void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e) {
            if (Settings.Default.CurrentThemeColorMode == ColorModes.System && e.Category == UserPreferenceCategory.Color) {
                DVLD_Business.Theme _savedTheme = DVLD_Business.Theme.Find(Settings.Default.CurrentThemeID);
                Settings.Default.ApplyColorPaletteSettings(DrawingHelpers.GetSystemTheme() == ColorModes.Light ? _savedTheme.LightColorPaletteInfo : _savedTheme.DarkColorPaletteInfo);
                Settings.Default.Save();
            }
        }
    }
}
