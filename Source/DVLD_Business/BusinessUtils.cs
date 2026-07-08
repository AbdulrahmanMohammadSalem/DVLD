using DVLD_Business.Properties;
using DVLD_Business.Report_Strings;
using DVLD_DataAccess;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using Salem.Extensions;
using Salem.Extensions.External;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MigraObjModel = MigraDoc.DocumentObjectModel;

namespace DVLD_Business {
    public static class BusinessUtils {
        public static class FileUtils {
            public static bool CheckFileExists(string filePath) => File.Exists(filePath);

            public static bool DeleteFile(string filePath) {
                try {
                    File.Delete(filePath);
                    return true;
                } catch (IOException) {
                    return false;
                }
            }


            private const string PersonImageDirectory = @"C:\ProgramData\DVLD\Person-Images\";

            /// <summary>
            /// This method returns the new full path
            /// </summary>
            public static string StorePersonImageAsGuid(string imagePath) {
                string _newPath = Path.Combine(PersonImageDirectory, Guid.NewGuid().ToString() + Path.GetExtension(imagePath));

                Directory.CreateDirectory(PersonImageDirectory);
                File.Copy(imagePath, _newPath);

                return _newPath;
            }

            public static void HighlightFileInExplorer(string fileName) => Process.Start("explorer.exe", $"/select, \"{fileName}\"");

            public static void StartProcess(string filename) {
                Process.Start(new ProcessStartInfo {
                    FileName = filename,
                    UseShellExecute = true
                });
            }

            internal static string ConvertToBase64String(string fileName) {
                try {
                    return Convert.ToBase64String(File.ReadAllBytes(fileName));
                } catch (Exception) {
                    return null;
                }
            }
        }

        public static class DateTimeUtils {
            public static readonly string DateFormat = $"MMM dd{Resources.comma} yyyy";
            public static readonly string DateSearchFormat = "d/M/yyyy";

            public static string FormatDate(DateTime dt) => dt.ToString(DateFormat);

            public static string FormatDateTime(DateTime dt, bool includeSeconds = false) => dt.ToString($"{DateFormat} h:mm{(includeSeconds ? ":ss" : "")} tt");

            public static string FormatTime(DateTime dt) => dt.ToString("h:mm tt");

            public static DateTime GetFullDateTime(DateTime dt_date, DateTime dt_time) =>
                new DateTime(dt_date.Year, dt_date.Month, dt_date.Day, dt_time.Hour, dt_time.Minute, dt_time.Second);

            public static DateTime GetMinDate(DateTime dt1, DateTime dt2) => DateTime.Compare(dt1, dt2) < 0 ? dt1 : dt2;
        }

        public static class Mapping {
            public static Color GetApplicationStatusColor(ApplicationStatus applicationStatus) {
                switch (applicationStatus) {
                    case ApplicationStatus.New: return Color.Purple;
                    case ApplicationStatus.Completed: return Color.ForestGreen;
                    case ApplicationStatus.Cancelled: return Color.Red;
                    default: return SystemColors.WindowText;
                }
            }

            public static string GetApplicationStatusString(ApplicationStatus applicationStatus) {
                switch (applicationStatus) {
                    case ApplicationStatus.New: return Resources._new;
                    case ApplicationStatus.Completed: return Resources.completed;
                    case ApplicationStatus.Cancelled: return Resources.cancelled;
                    default: throw new ArgumentOutOfRangeException("applicationStatus", "Invalid status passed. The accepted values are [New,Completed,Cancelled]");
                }
            }

            public static Color GetPassedTestsColor(byte numOfPassedTests) {
                switch (numOfPassedTests) {
                    case 0: return Color.Red;
                    case 3: return Color.Green;
                    default: return Color.Orange;
                }
            }

            public static string GetReportTitle(ReportTypes reportType) {
                switch (reportType) {
                    case ReportTypes.PersonHistoryReport: return Str_PersonHistoryReport.reportTitle;
                    case ReportTypes.LocalLicenseAppDetailsReport: return Str_LDLAppDetailsReport.reportTitle;
                    case ReportTypes.DriverProfileReport: return Str_DriverProfileReport.reportTitle;
                    case ReportTypes.TestAttemptsReport: return Str_TestAttemptsReport.reportTitle;
                    case ReportTypes.LicensesDetentionReport: return Str_LicenseDetentionReport.reportTitle;
                    case ReportTypes.UserActivityReport: return Str_UserActivityReport.reportTitle;
                    default: throw new ArgumentOutOfRangeException(nameof(reportType));
                }
            }

            public static string GetIssueReasonString(DrivingLicenseIssueReasons issueReason) {
                switch (issueReason) {
                    case DrivingLicenseIssueReasons.FirstTime: return Resources.issueNewLicense;
                    case DrivingLicenseIssueReasons.ReplacementForLost: return Resources.replacementForLost;
                    case DrivingLicenseIssueReasons.ReplacementForDamaged: return Resources.replacementForDamaged;
                    case DrivingLicenseIssueReasons.Renewal: return Resources.renewal;
                    default: throw new ArgumentOutOfRangeException(nameof(issueReason));
                }
            }
        }

        public static class Exporting {
            public static void PerformCsvExport(string defaultFileName, DataView dataSource) {
                using (SaveFileDialog sfd = new SaveFileDialog() { DefaultExt = "csv", Filter = "Comma-Separated Values File (*.csv)|*.csv", Title = "Export Data", FileName = defaultFileName }) {
                    NotifyIcon ni = new NotifyIcon {
                        BalloonTipIcon = ToolTipIcon.Info,
                        BalloonTipText = Resources.dataExportedSuccessfully,
                        BalloonTipTitle = Resources.success,
                        Icon = Resources.DVLD_Icon,
                        Visible = true
                    };

                    ni.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
                    ni.BalloonTipClosed += NotifyIcon1_BalloonTipClosed;

                    if (sfd.ShowDialog() == DialogResult.OK) {
                        if (_ExportToCsv(dataSource, sfd.FileName)) {
                            ni.Tag = sfd.FileName;
                            ni.Visible = true;
                            ni.ShowBalloonTip(0);
                        } else
                            MessageBox.Show(Resources.dataExportFailed, Resources.unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            public static void PerformChartExport(Chart chart, Color backColor) {
                using (SaveFileDialog sfd = new SaveFileDialog() { DefaultExt = "png", Filter = "Image File(*.jpg;*.jpeg;*.png;*.tiff;*.bmp)|*.jpg;*.jpeg;*.png;*.tiff;*.bmp|PDF Document(*.pdf)|*.pdf", Title = "Export Chart", FileName = chart.Titles[0].Text }) {
                    NotifyIcon ni = new NotifyIcon() { BalloonTipIcon = ToolTipIcon.Info, BalloonTipText = Resources.chartExportedSuccessfully, BalloonTipTitle = Resources.success, Icon = Resources.DVLD_Icon, Visible = true };

                    ni.BalloonTipClicked += NotifyIcon1_BalloonTipClicked;
                    ni.BalloonTipClosed += NotifyIcon1_BalloonTipClosed;

                    if (sfd.ShowDialog() == DialogResult.OK) {
                        if (_ExportChart(chart, sfd.FileName, backColor)) {
                            ni.Tag = sfd.FileName;
                            ni.Visible = true;
                            ni.ShowBalloonTip(0);
                        } else
                            MessageBox.Show(Resources.dataExportFailed, Resources.unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private static bool _ExportToCsv(DataView source, string path) {
                if (source.Count == 0)
                    return false;

                StringBuilder _builder = new StringBuilder();
                int columnCount = source.Table.Columns.Count;

                _builder.Append(source.Table.Columns[0].ColumnName);

                for (int i = 1; i < columnCount; i++)
                    _builder.Append($",{source.Table.Columns[i].ColumnName}");

                _builder.AppendLine();

                for (int i = 0; i < source.Count; i++) {
                    _builder.Append(source[i][0]);

                    for (int j = 1; j < columnCount; j++)
                        _builder.Append($",{source[i][j]}");

                    _builder.AppendLine();
                }

                try { File.WriteAllText(path, _builder.ToString(), Encoding.UTF8); } catch (Exception) { return false; }

                return true;
            }

            private static void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e) {
                var _sender = (NotifyIcon) sender;

                FileUtils.HighlightFileInExplorer(_sender.Tag.ToString());

                _EndNotifyIcon(_sender);
            }

            private static void NotifyIcon1_BalloonTipClosed(object sender, EventArgs e) => _EndNotifyIcon((NotifyIcon) sender);

            private static void _EndNotifyIcon(NotifyIcon ni) {
                ni.Visible = false;

                ni.BalloonTipClicked -= NotifyIcon1_BalloonTipClicked;
                ni.BalloonTipClosed -= NotifyIcon1_BalloonTipClosed;

                ni.Dispose();
            }

            private static bool _ExportChart(Chart chart, string fileName, Color backColor) {
                string _extension = Path.GetExtension(fileName);

                if (_extension != ".pdf") { //Image File
                    try {
                        chart.SaveImage(fileName, _GetChartImageFormat(_extension));
                    } catch (Exception) {
                        return false;
                    }

                    return true;
                }

                var _document = new MigraObjModel.Document();
                var _section = _document.AddSection();

                _section.PageSetup.PageWidth = (chart.Width + 75) * 0.75;
                _section.PageSetup.PageHeight = (chart.Height + 75) * 0.75;
                _section.PageSetup.TopMargin = _section.PageSetup.LeftMargin = 0;

                var _textFrame = _section.AddTextFrame();

                _textFrame.FillFormat.Color = new MigraObjModel.Color(backColor.R, backColor.G, backColor.B);
                _textFrame.Width = _section.PageSetup.PageWidth;
                _textFrame.Height = _section.PageSetup.PageHeight;
                _textFrame.Left = ShapePosition.Left;
                _textFrame.Top = ShapePosition.Top;
                _textFrame.RelativeHorizontal = RelativeHorizontal.Page;
                _textFrame.RelativeVertical = RelativeVertical.Page;
                _textFrame.WrapFormat.Style = WrapStyle.Through;

                using (var _stream = new MemoryStream()) {
                    chart.SaveImage(_stream, ChartImageFormat.Png);

                    var _image = _section.AddImage($"base64:{Convert.ToBase64String(_stream.ToArray())}");

                    _image.Left = ShapePosition.Center;
                    _image.RelativeHorizontal = RelativeHorizontal.Page;
                    _image.Top = ShapePosition.Center;
                    _image.RelativeVertical = RelativeVertical.Page;
                }

                var _renderer = new PdfDocumentRenderer { Document = _document };

                _renderer.RenderDocument();
                _renderer.Save(fileName);

                return true;
            }

            private static ChartImageFormat _GetChartImageFormat(string extension) {
                switch (extension) {
                    case ".png": return ChartImageFormat.Png;
                    case ".jpg":
                    case ".jpeg": return ChartImageFormat.Jpeg;
                    case ".tiff": return ChartImageFormat.Tiff;
                    case ".bmp": return ChartImageFormat.Bmp;
                    default: throw new ArgumentOutOfRangeException(nameof(extension));
                }
            }

            public static bool ExportMigraDocDocument(MigraObjModel.Document document, string fullPath) {
                var _pdfRenderer = new PdfDocumentRenderer { Document = document };

                _pdfRenderer.RenderDocument();

                try {
                    _pdfRenderer.Save(fullPath);
                } catch (Exception) {
                    return false;
                }

                return true;
            }

            public static bool PerformMigraDocDocumentPrint(MigraObjModel.Document document) {
                var _docRenderer = new DocumentRenderer(document);

                _docRenderer.PrepareDocument();

                using (MigraDocPrintDocument _migraPrintDoc = new MigraDocPrintDocument(_docRenderer) { DocumentName = document.Info.Title })
                using (PrintDialog _printDialog = new PrintDialog { UseEXDialog = true, Document = _migraPrintDoc, AllowSelection = true, AllowSomePages = true }) {
                    if (_printDialog.ShowDialog() == DialogResult.OK) {
                        try {
                            _migraPrintDoc.Print();
                        } catch (Exception) {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public static class Charting {
            public static DataTable GetSystemWideRevenue(SupportedLanguages language) => language == SupportedLanguages.Arabic ? DataAccessUtils.Charting.GetSystemWideRevenue_Arabic() : DataAccessUtils.Charting.GetSystemWideRevenue_Default();
        }

        internal static class Reporting {
            internal const string NormalBoldStyle = "NormalBold";
            internal const string NormalItalicStyle = "NormalItalic";
            internal const string TableCellStyle = "TableCell";
            internal const string TableHeaderCellStyle = "TableCellBold";
            internal const string TableLowerCaptionStyle = "TableLowerCaption";
            internal const string EmptyGridPlaceholderStyle = "EmptyGridPlaceholder";
            internal const string TableSammaryCaptionStyle = "TableSammaryCaption";

            internal const float NormalFontSize = 11F;
            internal const float NormalBoldFontSize = 10.5F;
            internal const float UpperHeaderFontSize = 16F;
            internal const float LowerHeaderFontSize = 10F;
            internal const float Heading1FontSize = 12F;
            internal const float Heading2FontSize = 10.5F;
            internal const float TableCellFontSize = 6.5F;
            internal const float FooterFontSize = 6.5F;
            internal const float PageNumFontSize = 9.5F;

            internal static readonly MigraObjModel.Color[] TitleColor = new MigraObjModel.Color[] { MigraObjModel.Colors.RoyalBlue, MigraObjModel.Colors.Black };
            internal static readonly MigraObjModel.Color[] InfoCardColor = new MigraObjModel.Color[] { MigraObjModel.Colors.AliceBlue, MigraObjModel.Colors.WhiteSmoke };
            internal static readonly MigraObjModel.Color[] GridHeaderColor = new MigraObjModel.Color[] { MigraObjModel.Colors.LightBlue, MigraObjModel.Colors.LightGray };

            internal static void AddReportFooter(MigraObjModel.Section section, ref DocumentExportSettings exportSettings) {
                var _footerTable = section.Footers.Primary.AddTable();
                var _col1 = _footerTable.AddColumn();
                var _col2 = _footerTable.AddColumn();
                var _row = _footerTable.AddRow();
                var _leftParagraph = _row[0].AddParagraph($"{Path.GetFileName(exportSettings.FullPath)}\n");
                var _rightParagraph = _row[1].AddParagraph();

                var _myHyperlink = _leftParagraph.AddHyperlink("https://AbdulrahmanMohammadSalem.github.io", MigraObjModel.HyperlinkType.Url);
                _myHyperlink.AddText("Abdulrahman Mohammad Salem");
                
                _leftParagraph.AddText(" -- ");
                
                var _hisHyperlink = _leftParagraph.AddHyperlink("https://ProgrammingAdvices.com", MigraObjModel.HyperlinkType.Url);
                _hisHyperlink.AddText("ProgrammingAdvices.com");

                _rightParagraph.AddPageField();

                _footerTable.Rows.LeftIndent = MigraObjModel.Unit.FromMillimeter(-exportSettings.PageMargins.HorizontalMillimeter);

                _col1.Width = _col2.Width = MigraObjModel.Unit.FromMillimeter(exportSettings.PageSize.WidthMillimeter / 2);

                _leftParagraph.Style = MigraObjModel.StyleNames.Footer;
                _leftParagraph.Format.LeftIndent = MigraObjModel.Unit.FromMillimeter(2);
                _leftParagraph.Format.Alignment = MigraObjModel.ParagraphAlignment.Left;

                _rightParagraph.Format.Alignment = MigraObjModel.ParagraphAlignment.Right;
                _rightParagraph.Format.Font.Size = MigraObjModel.Unit.FromPoint(PageNumFontSize);
                _rightParagraph.Format.RightIndent = MigraObjModel.Unit.FromMillimeter(3);
            }

            internal static void SetupPageSetup(MigraObjModel.Section section, ref DocumentExportSettings exportSettings) {
                section.PageSetup.PageWidth = MigraObjModel.Unit.FromMillimeter(exportSettings.PageSize.WidthMillimeter);
                section.PageSetup.PageHeight = MigraObjModel.Unit.FromMillimeter(exportSettings.PageSize.HeightMillimeter);
                section.PageSetup.LeftMargin = section.PageSetup.RightMargin = MigraObjModel.Unit.FromMillimeter(exportSettings.PageMargins.HorizontalMillimeter);
                section.PageSetup.HeaderDistance = section.PageSetup.TopMargin = section.PageSetup.BottomMargin = MigraObjModel.Unit.FromMillimeter(exportSettings.PageMargins.VerticalMillimeter);
                section.PageSetup.FooterDistance = MigraObjModel.Unit.FromMillimeter(2);
            }
            
            internal static void SetupHeading1Style(MigraObjModel.Document document) {
                var _heading1Style = document.Styles[MigraObjModel.StyleNames.Heading1];

                _heading1Style.Font.Size = MigraObjModel.Unit.FromPoint(Heading1FontSize);
                _heading1Style.Font.Bold = true;
                _heading1Style.ParagraphFormat.SpaceBefore = MigraObjModel.Unit.FromMillimeter(9);
                _heading1Style.ParagraphFormat.SpaceAfter = MigraObjModel.Unit.FromMillimeter(3);
            }

            internal static void SetupHeading2Style(MigraObjModel.Document document) {
                var _heading2Style = document.Styles[MigraObjModel.StyleNames.Heading2];

                _heading2Style.Font.Size = MigraObjModel.Unit.FromPoint(Heading2FontSize);
                _heading2Style.Font.Italic = true;
                _heading2Style.ParagraphFormat.SpaceBefore = MigraObjModel.Unit.FromMillimeter(3);
                _heading2Style.ParagraphFormat.LeftIndent = MigraObjModel.Unit.FromMillimeter(4);
            }

            internal static void SetupFooterStyle(MigraObjModel.Document document) {
                var _footerStyle = document.Styles[MigraObjModel.StyleNames.Footer];

                _footerStyle.ParagraphFormat.Font.Size = MigraObjModel.Unit.FromPoint(FooterFontSize);
                _footerStyle.ParagraphFormat.Font.Color = MigraObjModel.Colors.DimGray;
                _footerStyle.ParagraphFormat.Font.Italic = true;
            }

            internal static void SetupHeaderStyle(MigraObjModel.Document document, ref DocumentExportSettings exportSettings) {
                var _headerStyle = document.Styles[MigraObjModel.StyleNames.Header];

                _headerStyle.ParagraphFormat.SpaceBefore = MigraObjModel.Unit.Zero;
                _headerStyle.ParagraphFormat.LineSpacingRule = MigraObjModel.LineSpacingRule.Multiple;
                _headerStyle.ParagraphFormat.LineSpacing = 1.06;
                _headerStyle.ParagraphFormat.Alignment = MigraObjModel.ParagraphAlignment.Center;
                _headerStyle.ParagraphFormat.Font.Size = MigraObjModel.Unit.FromPoint(LowerHeaderFontSize);
                _headerStyle.ParagraphFormat.Font.Italic = true;
                _headerStyle.ParagraphFormat.Font.Color = TitleColor[exportSettings.Colorful ? 0 : 1];
                _headerStyle.ParagraphFormat.Borders.DistanceFromBottom = MigraObjModel.Unit.FromMillimeter(1.5);
                _headerStyle.ParagraphFormat.Borders.Bottom = new MigraObjModel.Border {
                    Color = MigraObjModel.Colors.Black,
                    Width = MigraObjModel.Unit.FromPoint(0.7),
                    Style = MigraObjModel.BorderStyle.Single
                };
            }

            internal static void SetupNormalStyle(MigraObjModel.Document document, ref DocumentExportSettings exportSettings, SupportedLanguages language) {
                var _normalStyle = document.Styles[MigraObjModel.StyleNames.Normal];

                _normalStyle.Font.Name = exportSettings.PreferredFontFamily;
                _normalStyle.Font.Size = MigraObjModel.Unit.FromPoint(NormalFontSize);
                _normalStyle.ParagraphFormat.Alignment = language == SupportedLanguages.English ? MigraObjModel.ParagraphAlignment.Left : MigraObjModel.ParagraphAlignment.Right;
            }

            internal static void SetupCustomStyles(MigraObjModel.Document document) {
                document.AddStyle(NormalBoldStyle, MigraObjModel.StyleNames.Normal);
                document.AddStyle(NormalItalicStyle, MigraObjModel.StyleNames.Normal);
                document.AddStyle(TableCellStyle, MigraObjModel.StyleNames.Normal);
                document.AddStyle(TableHeaderCellStyle, TableCellStyle);
                document.AddStyle(TableLowerCaptionStyle, TableCellStyle);
                document.AddStyle(EmptyGridPlaceholderStyle, MigraObjModel.StyleNames.Normal);
                document.AddStyle(TableSammaryCaptionStyle, TableCellStyle);

                document.Styles[NormalBoldStyle].Font.Bold = true;
                document.Styles[NormalBoldStyle].Font.Size = MigraObjModel.Unit.FromPoint(NormalBoldFontSize);

                document.Styles[NormalItalicStyle].Font.Italic = true;

                document.Styles[TableCellStyle].Font.Size = MigraObjModel.Unit.FromPoint(TableCellFontSize);

                document.Styles[TableHeaderCellStyle].Font.Bold = true;
                document.Styles[TableHeaderCellStyle].ParagraphFormat.Alignment = MigraObjModel.ParagraphAlignment.Center;

                document.Styles[TableLowerCaptionStyle].ParagraphFormat.Alignment = MigraObjModel.ParagraphAlignment.Center;
                document.Styles[TableLowerCaptionStyle].ParagraphFormat.SpaceBefore = MigraObjModel.Unit.FromMillimeter(0.8);
                document.Styles[TableLowerCaptionStyle].ParagraphFormat.Font.Color = MigraObjModel.Colors.DimGray;
                document.Styles[TableLowerCaptionStyle].ParagraphFormat.Font.Italic = true;
                document.Styles[TableLowerCaptionStyle].ParagraphFormat.SpaceAfter = MigraObjModel.Unit.FromMillimeter(3);

                document.Styles[EmptyGridPlaceholderStyle].ParagraphFormat.Alignment = MigraObjModel.ParagraphAlignment.Center;
                document.Styles[EmptyGridPlaceholderStyle].ParagraphFormat.Font.Size = MigraObjModel.Unit.FromPoint(NormalFontSize + 1);
                document.Styles[EmptyGridPlaceholderStyle].ParagraphFormat.Font.Color = MigraObjModel.Colors.DimGray;
                document.Styles[EmptyGridPlaceholderStyle].ParagraphFormat.Font.Bold = true;
                document.Styles[EmptyGridPlaceholderStyle].ParagraphFormat.Font.Italic = true;

                document.Styles[TableSammaryCaptionStyle].Font.Bold = true;
                document.Styles[TableSammaryCaptionStyle].ParagraphFormat.Alignment = MigraObjModel.ParagraphAlignment.Center;
            }

            internal static void AddReportTitle(MigraObjModel.Section headerSec, ref DocumentExportSettings exportSettings, string reportTitle, string createdByUsername, SupportedLanguages language) {
                var _headerParagraph = headerSec.AddParagraph("", MigraObjModel.StyleNames.Header);
                Func<string, string> TransformText;

                if (language == SupportedLanguages.English)
                    TransformText = str => str;
                else
                    TransformText = str => str.ReshapeForPrinting();

                _headerParagraph.AddFormattedText(TransformText(reportTitle), new MigraObjModel.Font { Bold = true, Italic = false, Size = MigraObjModel.Unit.FromPoint(UpperHeaderFontSize) });
                _headerParagraph.AddText($"\n{TransformText(createdByUsername)}");

                if (exportSettings.IncludeDateTime)
                    _headerParagraph.AddText($" - {TransformText(DateTimeUtils.FormatDateTime(DateTime.Now))}");

                if (exportSettings.IncludeDvldLogo) {
                    var _imageLogo = exportSettings.Colorful ? Resources.DVLD_Logo : Resources.DVLD_Logo_Grayscale;
                    var _dvldLogo1 = headerSec.AddImage($"base64:{Convert.ToBase64String(_imageLogo)}");
                    var _dvldLogo2 = headerSec.AddImage($"base64:{Convert.ToBase64String(_imageLogo)}");

                    _dvldLogo1.Width = _dvldLogo2.Width = MigraObjModel.Unit.FromCentimeter(2);
                    _dvldLogo1.Top = _dvldLogo2.Top = MigraObjModel.Unit.FromMillimeter(2);
                    _dvldLogo1.RelativeHorizontal = _dvldLogo2.RelativeHorizontal = RelativeHorizontal.Page;
                    _dvldLogo1.RelativeVertical = _dvldLogo2.RelativeVertical = RelativeVertical.Page;
                    _dvldLogo1.Left = MigraObjModel.Unit.FromMillimeter(2);
                    _dvldLogo2.Left = MigraObjModel.Unit.FromMillimeter(exportSettings.PageSize.WidthMillimeter - _dvldLogo2.Width.Millimeter - 2);
                }
            }

            internal static MigraObjModel.Section SetupCommonDocumentSettings(MigraObjModel.Document document, ref DocumentExportSettings exportSettings, ReportTypes reportType, string createdByUsername, SupportedLanguages language) {
                var _headerSec = document.AddSection();

                //Styles:
                SetupNormalStyle(document, ref exportSettings, language);
                SetupHeaderStyle(document, ref exportSettings);
                SetupFooterStyle(document);
                SetupHeading1Style(document);
                SetupHeading2Style(document);
                SetupCustomStyles(document);

                //Page Setup:
                SetupPageSetup(_headerSec, ref exportSettings);

                //Contents:
                AddReportTitle(_headerSec, ref exportSettings, Mapping.GetReportTitle(reportType), createdByUsername, language);
                AddReportFooter(_headerSec, ref exportSettings);
                
                return _headerSec;
            }

            internal static Cell AddInfoCard(MigraObjModel.Section section, Dictionary<string, string> dict, bool colorful, (byte field, byte image) columnWidths, bool rightToLeft = false) {
                var _table = section.AddTable();
                var _col1 = _table.AddColumn();
                var _col2 = _table.AddColumn();
                var _col3 = _table.AddColumn();
                byte _fieldColIndex = (byte) (rightToLeft ? 2 : 0), _imageColIndex = (byte) (2 - _fieldColIndex);

                _table.Columns[_fieldColIndex].Width = MigraObjModel.Unit.FromMillimeter(columnWidths.field);
                _table.Columns[_imageColIndex].Width = MigraObjModel.Unit.FromMillimeter(columnWidths.image);
                _col2.Width = MigraObjModel.Unit.FromMillimeter(section.PageSetup.PageWidth.Millimeter - section.PageSetup.LeftMargin.Millimeter - section.PageSetup.RightMargin.Millimeter - columnWidths.field - columnWidths.image);

                Func<string, string> GetFieldText, TransformText;

                if (rightToLeft) {
                    GetFieldText = str => $"{(str[str.Length - 1] == '؟' ? "" : ":")}{str.ReshapeForPrinting()} •";
                    TransformText = str => str.ReshapeForPrinting();

                    _table.Columns[_fieldColIndex].RightPadding = MigraObjModel.Unit.FromMillimeter(7);
                }
                else {
                    GetFieldText = str => $"• {str}{(str[str.Length - 1] == '?' ? "" : ":")}";
                    TransformText = str => str;

                    _table.Columns[_fieldColIndex].LeftPadding = MigraObjModel.Unit.FromMillimeter(7);
                }

                foreach (var _dataPoint in dict) {
                    var _row = _table.AddRow();

                    _row[_fieldColIndex].AddParagraph(GetFieldText(_dataPoint.Key)).Style = NormalBoldStyle;

                    if (_dataPoint.Value is null)
                        _row[1].AddParagraph(TransformText(Resources.notSetField)).Style = NormalItalicStyle;
                    else
                        _row[1].AddParagraph(TransformText(_dataPoint.Value));

                    _row.TopPadding = _row.BottomPadding = MigraObjModel.Unit.FromMillimeter(1);
                }

                _table.Shading.Color = InfoCardColor[colorful ? 0 : 1];
                _table.Rows.LeftIndent = MigraObjModel.Unit.Zero;
                _table.Rows[dict.Count - 1].Borders.Bottom.Style = MigraObjModel.BorderStyle.Single;
                _table.Rows[dict.Count - 1].Borders.Bottom.Color = MigraObjModel.Colors.DimGray;
                _table.Rows[0].TopPadding = _table.Rows[dict.Count - 1].BottomPadding = MigraObjModel.Unit.FromMillimeter(3);
                _table[0, _imageColIndex].MergeDown = dict.Count - 1;

                _col1.Borders.Left.Style = _col1.Borders.Top.Style = MigraObjModel.BorderStyle.Single;
                _col1.Borders.Left.Color = _col1.Borders.Top.Color = MigraObjModel.Colors.DimGray;

                _col2.Borders.Top.Style = MigraObjModel.BorderStyle.Single;
                _col2.Borders.Top.Color = MigraObjModel.Colors.DimGray;

                _col3.Borders.Right.Style = _col3.Borders.Top.Style = MigraObjModel.BorderStyle.Single;
                _col3.Borders.Right.Color = _col3.Borders.Top.Color = MigraObjModel.Colors.DimGray;
                
                return _table[0, _imageColIndex];
            }

            internal static void InsertImageCenterInTableCell(Cell cell, string imagePath, bool colorful) {
                var _imageParagraph = cell.AddParagraph();
                MigraObjModel.Shapes.Image _migraImage;

                if (!colorful && FileUtils.CheckFileExists(imagePath)) {
                    using (var _original = System.Drawing.Image.FromFile(imagePath))
                        _migraImage = cell.AddImage($"base64:{Convert.ToBase64String(_original.ToGrayscale().ToArray(ImageFormat.Png))}");
                } else
                    _migraImage = cell.AddImage(imagePath);

                cell.VerticalAlignment = VerticalAlignment.Center;
                _imageParagraph.Format.Alignment = MigraObjModel.ParagraphAlignment.Center;
                _migraImage.Width = MigraObjModel.Unit.FromMillimeter(cell.Column.Width.Millimeter - 10);
                _migraImage.LineFormat.Width = MigraObjModel.Unit.FromPoint(0.5);
                _migraImage.LineFormat.Color = MigraObjModel.Colors.DimGray;
                _migraImage.FillFormat.Color = MigraObjModel.Colors.White;
            }

            internal static Table AddDataGrid(MigraObjModel.Section section, DataTable dataTable, bool colorful, bool rightToLeft = false, bool includeSecondsInDateFormat = false) {
                if (dataTable.Rows.Count == 0) {
                    AddEmptyTablePlaceholder(section, rightToLeft);
                    return null;
                }
                
                Func<int, int> MapToDataTableCol;
                Func<string, string> TransformString;
                float _columnWidthMillimeter = (float) ((section.PageSetup.PageWidth.Millimeter - section.PageSetup.LeftMargin.Millimeter - section.PageSetup.RightMargin.Millimeter) / dataTable.Columns.Count);
                var _table = section.AddTable();

                for (int i = 0; i < dataTable.Columns.Count; i++)
                    _table.AddColumn(MigraObjModel.Unit.FromMillimeter(_columnWidthMillimeter));

                if (rightToLeft) {
                    MapToDataTableCol = i => _table.Columns.Count - i - 1;
                    TransformString = str => str.ReshapeForPrinting();
                }
                else {
                    MapToDataTableCol = i => i;
                    TransformString = str => str;
                }

                for (int i = 0; i <= dataTable.Rows.Count; i++) {
                    var _row = _table.AddRow();

                    _row.TopPadding = _row.BottomPadding = MigraObjModel.Unit.FromMillimeter(1);
                    _row.VerticalAlignment = VerticalAlignment.Center;
                }

                for (int i = 0; i < _table.Columns.Count; i++)
                    _table[0, i].AddParagraph(TransformString(dataTable.Columns[MapToDataTableCol(i)].Caption)).Style = TableHeaderCellStyle;

                for (int i = 0; i < dataTable.Rows.Count; i++)
                    for (int j = 0; j < _table.Columns.Count; j++) {
                        if (dataTable.Rows[i][MapToDataTableCol(j)] == DBNull.Value) {
                            var _emptyParagraph = _table[i + 1, j].AddParagraph("–");

                            _emptyParagraph.Format.Alignment = MigraObjModel.ParagraphAlignment.Center;
                            _emptyParagraph.Format.Font.Color = colorful ? MigraObjModel.Colors.Red : new MigraObjModel.Color(76, 76, 76);
                        }
                        else if (dataTable.Columns[MapToDataTableCol(j)].DataType == typeof(DateTime))
                            _table[i + 1, j].AddParagraph(TransformString(DateTimeUtils.FormatDateTime((DateTime) dataTable.Rows[i][MapToDataTableCol(j)], includeSecondsInDateFormat))).Style = TableCellStyle;
                        else if (dataTable.Columns[MapToDataTableCol(j)].DataType == typeof(decimal))
                            _table[i + 1, j].AddParagraph(((decimal) dataTable.Rows[i][MapToDataTableCol(j)]).ToString("C2")).Style = TableCellStyle;
                        else
                            _table[i + 1, j].AddParagraph(TransformString(dataTable.Rows[i][MapToDataTableCol(j)].ToString())).Style = TableCellStyle;
                    }

                _table.Rows[0].HeadingFormat = true;
                _table.Rows[0].Shading.Color = GridHeaderColor[colorful ? 0 : 1];

                _table.Rows.LeftIndent = MigraObjModel.Unit.Zero;
                _table.Borders.Color = MigraObjModel.Colors.DimGray;
                _table.Borders.Visible = true;

                return _table;
            }

            private static void AddEmptyTablePlaceholder(MigraObjModel.Section section, bool rightToLeft) {
                var _txtFrame = section.AddTextFrame();

                _txtFrame.Width = section.PageSetup.PageWidth.Point - section.PageSetup.LeftMargin.Point - section.PageSetup.RightMargin.Point;
                _txtFrame.Height = MigraObjModel.Unit.FromCentimeter(3.65);
                _txtFrame.LineFormat.Width = 0.5;
                _txtFrame.LineFormat.Color = MigraObjModel.Colors.DimGray;
                _txtFrame.LineFormat.DashStyle = DashStyle.Dash;
                _txtFrame.FillFormat.Color = MigraObjModel.Colors.WhiteSmoke;

                _txtFrame.AddTable().AddColumn(_txtFrame.Width);

                var _row = (_txtFrame.Elements[0] as Table).AddRow();

                _row.VerticalAlignment = VerticalAlignment.Center;
                _row.HeightRule = RowHeightRule.Exactly;
                _row.Height = _txtFrame.Height;

                if (rightToLeft)
                    _row[0].AddParagraph(Resources.noDataAvailable.ReshapeForPrinting()).Style = EmptyGridPlaceholderStyle;
                else
                    _row[0].AddParagraph(Resources.noDataAvailable).Style = EmptyGridPlaceholderStyle;
            }

            internal static void AddPersonInfoCard(MigraObjModel.Section section, Person personInfo, bool colorful, SupportedLanguages language) {
                var _dict = new Dictionary<string, string> {
                    [Str_PersonHistoryReport.field_personID] = personInfo.PersonID.ToString(),
                    [Str_PersonHistoryReport.field_nationalNum] = personInfo.NationalNum,
                    [Str_PersonHistoryReport.field_fullName] = personInfo.FullName,
                    [Str_PersonHistoryReport.field_gender] = personInfo.Gender.ToString(),
                    [Str_PersonHistoryReport.field_dateOfBirth] = DateTimeUtils.FormatDate(personInfo.DateOfBirth),
                    [Str_PersonHistoryReport.field_address] = personInfo.Address,
                    [Str_PersonHistoryReport.field_phoneNum] = personInfo.PhoneNumber,
                    [Str_PersonHistoryReport.field_email] = personInfo.Email,
                    [Str_PersonHistoryReport.field_nationality] = personInfo.NationalityCountryInfo.CountryName
                };

                var _imageCell = AddInfoCard(section, _dict, colorful, (42, 38), language == SupportedLanguages.Arabic);

                if (personInfo.ImagePath != null && FileUtils.CheckFileExists(personInfo.ImagePath))
                    InsertImageCenterInTableCell(_imageCell, personInfo.ImagePath, colorful);
            }

            internal static void AddLocalLicenseAppInfoCard(MigraObjModel.Section section, LocalDrivingLicenseApp localLicenseAppInfo, bool colorful, SupportedLanguages language) {
                Func<string, string> TransformText;

                if (language == SupportedLanguages.English)
                    TransformText = text => text;
                else
                    TransformText = text => text.ReshapeForPrinting();

                var _createdByUser = localLicenseAppInfo.CreatedByUserInfo;
                var _dict = new Dictionary<string, string> {
                    { Str_LDLAppDetailsReport.field_localDrivingLicenseAppID, localLicenseAppInfo.LDLAppID.ToString() },
                    { Str_LDLAppDetailsReport.field_appliedForLicense, localLicenseAppInfo.LicenseClassInfo.GetClassName(language) },
                    { Str_LDLAppDetailsReport.field_numPassedTests, localLicenseAppInfo.NumOfPassedTests.ToString() }
                };

                AddInfoCard(section, _dict, colorful, (55, 1), language == SupportedLanguages.Arabic);
                section.AddParagraph(TransformText(Str_LDLAppDetailsReport.cap_drivingLicenseAppInfo), TableLowerCaptionStyle);

                _dict.Clear();
                
                _dict.Add(Str_LDLAppDetailsReport.field_baseAppID, localLicenseAppInfo.BaseApplicationID.ToString());
                _dict.Add(Str_LDLAppDetailsReport.field_appType, localLicenseAppInfo.ApplicationTypeInfo.GetTitle(language));
                _dict.Add(Str_LDLAppDetailsReport.field_applicantName, localLicenseAppInfo.ApplicantInfo.FullName);
                _dict.Add(Str_LDLAppDetailsReport.field_status, localLicenseAppInfo.ApplicationStatus.ToString());
                _dict.Add(Str_LDLAppDetailsReport.field_applicationDate, DateTimeUtils.FormatDateTime(localLicenseAppInfo.ApplicationDate));
                _dict.Add(Str_LDLAppDetailsReport.field_fees, localLicenseAppInfo.FeesPaid.ToString("C2"));
                _dict.Add(Str_LDLAppDetailsReport.field_statusUpdateDate, localLicenseAppInfo.UpdateStatusDate.HasValue ? DateTimeUtils.FormatDateTime(localLicenseAppInfo.UpdateStatusDate.Value) : Resources.notSetField);
                _dict.Add(Str_PersonHistoryReport.col_createdBy, _createdByUser is null ? Resources.notSetField : localLicenseAppInfo.CreatedByUserInfo.Username);

                AddInfoCard(section, _dict, colorful, (55, 1), language == SupportedLanguages.Arabic);
                section.AddParagraph(TransformText(Str_LDLAppDetailsReport.cap_appBasicInfo), TableLowerCaptionStyle);
            }

            internal static void AddDriverInfoCard(MigraObjModel.Section section, Driver driverInfo, bool colorful, SupportedLanguages language) {
                var _createdByUser = driverInfo.CreatedByUserInfo;
                Func<string, string> TransformText;

                if (language == SupportedLanguages.English)
                    TransformText = text => text;
                else
                    TransformText = text => text.ReshapeForPrinting();

                AddPersonInfoCard(section, driverInfo.PersonInfo, colorful, language);
                section.AddParagraph(TransformText(Str_DriverProfileReport.cap_personalInfo), TableLowerCaptionStyle);

                var _dict = new Dictionary<string, string> {
                    { Str_DriverProfileReport.field_driverID, driverInfo.DriverID.ToString() },
                    { Str_PersonHistoryReport.col_createdBy, _createdByUser is null ? Resources.notSetField : _createdByUser.Username },
                    { Str_DriverProfileReport.field_dateCreated, DateTimeUtils.FormatDateTime(driverInfo.DateCreated) }
                };

                AddInfoCard(section, _dict, colorful, (42, 1), language == SupportedLanguages.Arabic);
                section.AddParagraph(TransformText(Str_DriverProfileReport.h_driverInfo), TableLowerCaptionStyle);
            }

            internal static void AddLocalLicenseInfoCard(MigraObjModel.Section section, LocalDrivingLicense licenseInfo, bool colorful, SupportedLanguages language) {
                var _createdByUser = licenseInfo.CreatedByUserInfo;
                var _personInfo = licenseInfo.DriverInfo.PersonInfo;

                var _dict = new Dictionary<string, string> {
                    { Str_LicenseDetentionReport.field_licenseID, licenseInfo.LocalDrivingLicenseID.ToString() },
                    { Str_PersonHistoryReport.col_class, licenseInfo.LicenseClassInfo.GetClassName(language) },
                    { Str_PersonHistoryReport.field_fullName, _personInfo.FullName },
                    { Str_PersonHistoryReport.field_nationalNum, _personInfo.NationalNum },
                    { Str_PersonHistoryReport.field_dateOfBirth, DateTimeUtils.FormatDate(_personInfo.DateOfBirth) },
                    { Str_PersonHistoryReport.field_gender, _personInfo.Gender.ToString() },
                    { Str_DriverProfileReport.field_driverID, licenseInfo.DriverID.ToString() },
                    { Str_PersonHistoryReport.col_issueDate, DateTimeUtils.FormatDateTime(licenseInfo.IssueDate) },
                    { Str_PersonHistoryReport.col_expirationDate, DateTimeUtils.FormatDateTime(licenseInfo.ExpirationDate) },
                    { Str_PersonHistoryReport.col_isActive, licenseInfo.CheckIfActive() ? Resources.yes : Resources.no },
                    { Str_LicenseDetentionReport.field_isDetained, licenseInfo.CheckIfActive() ? Resources.yes : Resources.no },
                    { Str_PersonHistoryReport.col_issueReason, Mapping.GetIssueReasonString(licenseInfo.IssueReason) },
                    { Str_PersonHistoryReport.col_issueNotes, licenseInfo.Notes is null ? Resources.notSetField : licenseInfo.Notes },
                    { Str_PersonHistoryReport.col_createdBy, _createdByUser is null ? Resources.notSetField : _createdByUser.Username }
                };

                var _imageCell = AddInfoCard(section, _dict, colorful, (46, 38), language == SupportedLanguages.Arabic);

                if (_personInfo.ImagePath != null && FileUtils.CheckFileExists(_personInfo.ImagePath))
                    InsertImageCenterInTableCell(_imageCell, _personInfo.ImagePath, colorful);
            }

            internal static void AddUserInfoCard(MigraObjModel.Section section, User userInfo, bool colorful, SupportedLanguages language) {
                Func<string, string> TransformText;

                if (language == SupportedLanguages.English)
                    TransformText = text => text;
                else
                    TransformText = text => text.ReshapeForPrinting();

                AddPersonInfoCard(section, userInfo.PersonInfo, colorful, language);
                section.AddParagraph(TransformText(Str_DriverProfileReport.cap_personalInfo), TableLowerCaptionStyle);

                var _dict = new Dictionary<string, string> {
                    { Str_UserActivityReport.field_userID, userInfo.UserID.ToString() },
                    { Str_UserActivityReport.field_username, userInfo.Username },
                    { Str_UserActivityReport.field_isActive, userInfo.IsActive ? Resources.yes : Resources.no }
                };

                AddInfoCard(section, _dict, colorful, (42, 1), language == SupportedLanguages.Arabic);
                section.AddParagraph(TransformText(Str_UserActivityReport.cap_loginInfo), TableLowerCaptionStyle);
            }

            internal static void AddSammaryRow(Table table, string caption, decimal value, byte captionSpan, bool rightToLeft) {
                var _sammaryRow = table.AddRow();

                Cell _captionCell;
                Cell _valueCell;
                Func<string, string> TransformText;

                if (rightToLeft) {
                    _captionCell = table[table.Rows.Count - 1, table.Columns.Count - captionSpan];
                    _valueCell = table[table.Rows.Count - 1, 0];
                    TransformText = text => text.ReshapeForPrinting();
                } else {
                    _captionCell = table[table.Rows.Count - 1, 0];
                    _valueCell = table[table.Rows.Count - 1, captionSpan];
                    TransformText = text => text;
                }

                _captionCell.AddParagraph(TransformText(caption)).Style = TableSammaryCaptionStyle;

                var _valueParagraph = _valueCell.AddParagraph(value.ToString("C2"));

                _valueParagraph.Style = TableCellStyle;
                _valueParagraph.Format.Alignment = MigraObjModel.ParagraphAlignment.Center;
                _sammaryRow.VerticalAlignment = VerticalAlignment.Center;
                _sammaryRow.TopPadding = _sammaryRow.BottomPadding = MigraObjModel.Unit.FromMillimeter(2);
                _captionCell.MergeRight = captionSpan - 1;
                _valueCell.MergeRight = table.Columns.Count - captionSpan - 1;
            }

            internal static void FormatHyphenedRows(Table table, ref string[] arrCategories, MigraObjModel.Color backColor, bool rightToLeft) {
                int i = 0;
                Cell _cell;
                Func<string, string> TransformText;

                if (rightToLeft)
                    TransformText = text => text.ReshapeForPrinting();
                else
                    TransformText = text => text;

                foreach (var row in table.Rows.Cast<Row>()) {
                    if (((row[rightToLeft ? table.Columns.Count - 1 : 0].Elements[0] as MigraObjModel.Paragraph).Elements[0] as MigraObjModel.Text).Content.In("-", "-1", "1-")) {
                        _cell = row[0];

                        row.VerticalAlignment = VerticalAlignment.Center;
                        row.TopPadding = row.BottomPadding = MigraObjModel.Unit.FromMillimeter(2);
                        row.Shading.Color = backColor;

                        _cell.MergeRight = table.Columns.Count - 1;
                        _cell.Elements.Clear();
                        _cell.AddParagraph(TransformText(arrCategories[i++])).Style = TableSammaryCaptionStyle;

                        if (i == arrCategories.Length)
                            i = 0;
                    }
                }
            }
        }
    }
}
