using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD_Business;
using Salem.Drawing;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class Ctrl_SystemWideRevenue : UserControl, ICtrlChart {
        private DataTable _dtSystemWideRevenue;
        private bool _isAdditionalLineDrawn = false;
        private readonly Font _latinModernMath = new Font("Latin Modern Math (Modified)", 22, FontStyle.Bold);

        private enum RevenueSourceTypesFilterOptions : byte {
            All, Application, TestAppointment, LocalLicenseIssuance, DetentionFinePayment
        }

        public Ctrl_SystemWideRevenue() {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == SupportedLanguages.English) {
                cb_sourceType.Location = new Point(132, 88);
                dt_date.Location = new Point(132, 132);
            }

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_revenue);
            dgv_revenue.Columns[0].HeaderCell.Style.SelectionBackColor = Settings.Default.GridHeaderCellColor;
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            BackColor = Settings.Default.SurfaceBackColor;
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_revenue);
            dgv_revenue.Columns[0].HeaderCell.Style.SelectionBackColor = Settings.Default.GridHeaderCellColor;
        }

        private void Ctrl_SystemWideRevenue_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.SystemWideRevenue)) {
                _ReloadAllData();
                _SetupTableHeader();
                lbl_noDataAvailable.Visible = dgv_revenue.RowCount == 0;
            }
        }

        private void _SetupTableHeader() {
            dgv_revenue.Columns[0].Width = 45;

            dgv_revenue.Columns[1].HeaderText = Str_CtrlSystemWideRevenue.dateTime;
            dgv_revenue.Columns[1].Width = 190;

            dgv_revenue.Columns[2].HeaderText = Str_CtrlSystemWideRevenue.revenueSource;
            dgv_revenue.Columns[2].Width = 315;

            dgv_revenue.Columns[3].HeaderText = Str_CtrlSystemWideRevenue.sourceType;
            dgv_revenue.Columns[3].Width = 230;

            dgv_revenue.Columns[4].HeaderText = Str_CtrlSystemWideRevenue.amount;
            dgv_revenue.Columns[4].Width = 95;

            dgv_revenue.Columns[5].HeaderText = Str_CtrlSystemWideRevenue.registeredBy;
        }

        private void _ReworkEverything() {
            _ReloadAllData();
            RefreshDataFiltering();
        }

        private void _ReloadAllData() {
            bool _wasEmpty = dgv_revenue.RowCount == 0;

            _dtSystemWideRevenue = BusinessUtils.Charting.GetSystemWideRevenue(Settings.Default.CurrentLanguage);
            dgv_revenue.DataSource = _dtSystemWideRevenue;

            if (dgv_revenue.RowCount == 0) {
                if (!_wasEmpty)
                    dgv_revenue.Height--;
            } else if (_isAdditionalLineDrawn)
                dgv_revenue.Height++;
        }

        private void Ctrl_SystemWideRevenue_Paint(object sender, PaintEventArgs e) {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            
            DrawingHelpers.DrawSimpleBorder(e.Graphics, new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1), Settings.Default.SurfaceBorderColor, 1);

            using (var _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                if (dgv_revenue.RowCount == 0) {
                    e.Graphics.DrawLine(_pen, 0, dgv_revenue.Bottom, Width - 1, dgv_revenue.Bottom);
                    _isAdditionalLineDrawn = true;
                } else
                    _isAdditionalLineDrawn = false;

                if (!dgv_revenue.Visible) {
                    using (var _brush = new HatchBrush(HatchStyle.ForwardDiagonal, Settings.Default.SurfaceBorderColor, Settings.Default.SurfaceBackColor))
                        e.Graphics.FillRectangle(_brush, dgv_revenue.Bounds);

                    e.Graphics.DrawLine(_pen, 0, dgv_revenue.Top, Width - 1, dgv_revenue.Top);
                    e.Graphics.DrawLine(_pen, 0, dgv_revenue.Bottom, Width - 1, dgv_revenue.Bottom);
                }
            }

            var _sumRect = new Rectangle(15, Height - 77, Width - 30, 76);

            using (var _brush = new SolidBrush(Enabled ? Settings.Default.BaseForeColor : Settings.Default.InactiveForeColor))
            using (var _stringFormat = new StringFormat { Alignment = RightToLeft == RightToLeft.Yes ? StringAlignment.Far : StringAlignment.Near, LineAlignment = StringAlignment.Center }) {
                if (DesignMode || !Enabled) {
                    if (RightToLeft == RightToLeft.Yes) {
                        _sumRect.Offset(-1, 4);
                        e.Graphics.DrawString($"\u0080\u0080\u0080 = \u2210", _latinModernMath, _brush, _sumRect, _stringFormat);
                    }
                    else
                        e.Graphics.DrawString($"\u2211 = ???", _latinModernMath, _brush, _sumRect, _stringFormat);
                } else {
                    object _sum = _dtSystemWideRevenue.Compute("SUM(Amount)", _dtSystemWideRevenue.DefaultView.RowFilter);

                    if (RightToLeft == RightToLeft.Yes)
                        e.Graphics.DrawString($"{Convert.ToDecimal(_sum == DBNull.Value ? 0 : _sum):C2} = \u2210", _latinModernMath, _brush, _sumRect, _stringFormat);
                    else
                        e.Graphics.DrawString($"\u2211 = {Convert.ToDecimal(_sum == DBNull.Value ? 0 : _sum):C2}", _latinModernMath, _brush, _sumRect, _stringFormat);
                }
            }
        }

        private void cb_sourceType_SelectedIndexChanged(object sender, EventArgs e) {
            cb_source.SelectedIndex = -1;
            cb_source.Items.Clear();
            cb_source.Items.Add($"({Resources.txt_all})");

            var _selectedSourceType = (RevenueSourceTypesFilterOptions) cb_sourceType.SelectedIndex;

            switch (_selectedSourceType) {
                case RevenueSourceTypesFilterOptions.Application:
                    cb_source.Items.AddRange(ApplicationType.GetTypeTitles(Settings.Default.CurrentLanguage));
                    cb_source.Enabled = true;
                    break;
                case RevenueSourceTypesFilterOptions.TestAppointment:
                    cb_source.Items.AddRange(TestType.GetTestTypeTitles(Settings.Default.CurrentLanguage));
                    cb_source.Enabled = true;
                    break;
                case RevenueSourceTypesFilterOptions.LocalLicenseIssuance:
                    cb_source.Items.AddRange(LicenseClass.GetAllLicenseClassNames(Settings.Default.CurrentLanguage));
                    cb_source.Enabled = true;
                    break;
                default:
                    cb_source.Enabled = false;
                    break;
            }

            cb_source.SelectedIndex = 0;
        }

        public void RefreshDataFiltering() {
            var _selectedSourceType = (RevenueSourceTypesFilterOptions) cb_sourceType.SelectedIndex;
            string _rowFilter = string.Empty;
            bool _hasAppended = false;

            if (_selectedSourceType != RevenueSourceTypesFilterOptions.All) {
                _rowFilter += $"SourceType = '{_GetSourceTypeString(_selectedSourceType)}'";
                
                if (cb_source.SelectedIndex > 0)
                    _rowFilter += $" AND RevenueSource = '{cb_source.Text}'";

                _hasAppended = true;
            }

            if (dt_date.Checked) {
                if (_hasAppended)
                    _rowFilter += " AND ";

                _rowFilter += $"DateTime >= #{dt_date.Value:yyyy-MM-dd}# AND DateTime < #{dt_date.Value.AddDays(1):yyyy-MM-dd}#";
                _hasAppended = true;
            }

            if (txt_registeredBy.TextLength > 0) {
                if (_hasAppended)
                    _rowFilter += " AND ";

                _rowFilter += $"RegisteredBy LIKE '{txt_registeredBy.Text}%'";
            }

            _dtSystemWideRevenue.DefaultView.RowFilter = _rowFilter;
            lbl_noDataAvailable.Visible = dgv_revenue.RowCount == 0;

            Invalidate();
        }

        private object _GetSourceTypeString(RevenueSourceTypesFilterOptions sourceType) {
            switch (sourceType) {
                case RevenueSourceTypesFilterOptions.Application: return Str_CtrlSystemWideRevenue.filter_application;
                case RevenueSourceTypesFilterOptions.TestAppointment: return Str_CtrlSystemWideRevenue.filter_testAppointment;
                case RevenueSourceTypesFilterOptions.LocalLicenseIssuance: return Str_CtrlSystemWideRevenue.filter_localLicenseIssuance;
                case RevenueSourceTypesFilterOptions.DetentionFinePayment: return Str_CtrlSystemWideRevenue.filter_detentionFinePayment;
                default: return Resources.txt_unknownField;
            }
        }

        public void RefreshChart() => _ReworkEverything();

        private void cb_source_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_source.SelectedIndex == -1)
                return;

            RefreshDataFiltering();
        }

        private void dt_date_ValueChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void dt_date_CheckBoxCheckedChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void txt_registeredBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void dgv_revenue_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 0) {
                e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = Settings.Default.GridHeaderCellColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.BackColor.IsLight() ? Color.Black : Color.White;
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            } else if (dgv_revenue.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (dgv_revenue.Columns[e.ColumnIndex].ValueType == typeof(decimal)) {
                e.Value = ((decimal) e.Value).ToString("C2");
                e.FormattingApplied = true;
            }
        }

        private void dgv_revenue_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (Settings.Default.CurrentLanguage == SupportedLanguages.English) {
                if (e.RowIndex >= 0 || e.ColumnIndex == 0)
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;

                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_revenue.ColumnCount - 1 && !dgv_revenue.IsVScrollVisible())
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            } else {
                if (e.RowIndex >= 0 || e.ColumnIndex == 0)
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_revenue.ColumnCount - 1 && !dgv_revenue.IsVScrollVisible())
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        private void ll_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReworkEverything();

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(lbl_title.Text, (_dtSystemWideRevenue ?? BusinessUtils.Charting.GetSystemWideRevenue(Settings.Default.CurrentLanguage)).DefaultView);

        private void Ctrl_SystemWideRevenue_Resize(object sender, EventArgs e) => Invalidate();

        private void Ctrl_SystemWideRevenue_EnabledChanged(object sender, EventArgs e) {
            dgv_revenue.Visible = Enabled;
            lbl_noDataAvailable.Visible = Enabled && dgv_revenue.RowCount == 0;
            Invalidate();
        }
    }
}
