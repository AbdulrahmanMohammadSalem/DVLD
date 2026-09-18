namespace DVLD_Business {
    public struct DocumentExportSettings {
        public DocumentExportSettings(string fullPath, string preferredFontFamily, (float WidthMillimeter, float HeightMillimeter) pageDimensions, (float HorizontalMillimeter, float VerticalMillimeter) pageMargins, bool openAfterSaving, bool includeDateTime, bool includeDvldLogo, bool colorful) {
            FullPath = fullPath;
            PreferredFontFamily = preferredFontFamily;
            PageSize = pageDimensions;
            PageMargins = pageMargins;
            OpenAfterSaving = openAfterSaving;
            IncludeDateTime = includeDateTime;
            IncludeDvldLogo = includeDvldLogo;
            Colorful = colorful;
        }

        public string FullPath { get; }
        public string PreferredFontFamily { get; }
        public (float WidthMillimeter, float HeightMillimeter) PageSize { get; }
        public (float HorizontalMillimeter, float VerticalMillimeter) PageMargins { get; }
        public bool OpenAfterSaving { get; }
        public bool IncludeDateTime { get; }
        public bool IncludeDvldLogo { get; }
        public bool Colorful { get; }
    }
}
