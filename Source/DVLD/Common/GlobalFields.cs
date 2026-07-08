using DVLD.Properties;
using DVLD_Business;
using Salem.Controls.Renderers;
using System.Globalization;

namespace DVLD.Common {
    internal static class GlobalFields {
        internal static int ActiveUserID = -1;
        
        internal static User ActiveUserInfo => User.Find(ActiveUserID);

        internal static DVLD_Business.Permissions ActiveUserPermissions = null;

        public static CultureInfo CurrentCulture => Settings.Default.CurrentLanguage == SupportedLanguages.English ? EnglishCulture : ArabicCulture;

        internal static (string text, string caption) LoginScreenMessageBoxInfo = (null, null);

        internal static SalToolStripRenderer ToolStripRenderer;

        internal static CultureInfo EnglishCulture, ArabicCulture;

        internal static string[] InstalledFontFamilies;

        internal static readonly char[] InvalidFileNameChars = new char[] {
            '<', '>', ':', '"', '/', '\\', '|', '?', '*'
        };

        internal static readonly string[] InvalidFileNames = new string[] {
            "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5",
            "COM6", "COM7", "COM8", "COM9", "COM¹", "COM²", "COM³", "LPT1", "LPT2",
            "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9", "LPT¹", "LPT²", "LPT³"
        };
    }
}
