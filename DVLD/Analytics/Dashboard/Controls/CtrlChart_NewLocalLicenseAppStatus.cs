using DVLD.Applications.Local_Driving_License;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class CtrlChart_NewLocalLicenseAppStatus : UserControl, ICtrlChart {
        public event Action<int> PersonSaved;

        private DataView _dvTotalAppsPerMonths;
        private byte _selectedMonthNum = (byte) DateTime.Now.Month;
        private bool _isAdditionalLineDrawn = false;

        public CtrlChart_NewLocalLicenseAppStatus() {
            InitializeComponent();

            _ApplyChartLocalizationSettings();
            Settings.Default.ApplyChartStyleSettings(chart1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_apps);
            dgv_apps.Columns[0].HeaderCell.Style.SelectionBackColor = Settings.Default.GridHeaderCellColor;
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            BackColor = Settings.Default.SurfaceBackColor;
            Settings.Default.ApplyChartStyleSettings(chart1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_apps);
            dgv_apps.Columns[0].HeaderCell.Style.SelectionBackColor = Settings.Default.GridHeaderCellColor;
        }

        private void CtrlChart_NewLocalLicenseAppStatus_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });

                if (dgv_apps.RowCount == 0) {
                    e.Graphics.DrawLine(_pen, 0, dgv_apps.Bottom, Width - 1, dgv_apps.Bottom);
                    _isAdditionalLineDrawn = true;
                } else
                    _isAdditionalLineDrawn = false;
            }

            if (!dgv_apps.Visible) {
                using (var _brush = new HatchBrush(HatchStyle.ForwardDiagonal, Settings.Default.SurfaceBorderColor, Settings.Default.SurfaceBackColor))
                    e.Graphics.FillRectangle(_brush, dgv_apps.Bounds);
            }
        }

        private void num_appYear_ValueChanged(object sender, EventArgs e) => _ReworkEverything();

        private void num_appYear_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void CtrlChart_NewLocalLicenseAppStatus_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.LocalLicenseApplicationsStatus))
                _ReworkEverything();
        }

        private void _SetupTableHeaders() {
            dgv_apps.Columns[0].Width = 35;

            dgv_apps.Columns[1].HeaderText = Str_CtrlChartNewLocalLicenseAppStatus.appID;
            dgv_apps.Columns[1].Width = 85;

            dgv_apps.Columns[2].HeaderText = Str_CtrlChartNewLocalLicenseAppStatus.date;
            dgv_apps.Columns[2].Width = 160;

            dgv_apps.Columns[3].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.status;
            dgv_apps.Columns[3].Width = 98;

            dgv_apps.Columns[4].HeaderText = Str_CtrlChartNewLocalLicenseAppStatus.fees;
            dgv_apps.Columns[4].Width = 80;

            dgv_apps.Columns[5].HeaderText = Str_LayoutShowAllApplications.createdBy;
        }

        private void _ReworkEverything() {
            _ReloadAllData();
            _BindAllData();
        }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        private void _BindAllData() {
            string _xField = Settings.Default.CurrentLanguage == SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["totalNewApps"].Points.DataBind(_dvTotalAppsPerMonths, _xField, "TotalNewApplications", null);
            chart1.Series["totalCompletedApps"].Points.DataBind(_dvTotalAppsPerMonths, _xField, "TotalCompletedApplications", null);
            chart1.Series["totalCancelledApps"].Points.DataBind(_dvTotalAppsPerMonths, _xField, "TotalCancelledApplications", null);

            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";

            _BindDgvData();
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.Application.Charting.GetOldestAppYear();
            num_year.Maximum = DVLD_Business.Application.Charting.GetHighestAppYear();

            _dvTotalAppsPerMonths = DVLD_Business.Application.Charting.GetTotalAppStatusPerMonths((short) num_year.Value, Settings.Default.CurrentLanguage);
        }

        private void chart1_EnabledChanged(object sender, EventArgs e) {
            foreach (var _series in chart1.Series)
                _series.Enabled = chart1.Enabled;

            if (chart1.Enabled) {
                pb_help.Image = Resources.Help_24;
                chart1.Titles[0].ForeColor = Settings.Default.BaseForeColor;
                dgv_apps.Visible = true;
                _BindDgvData();
                lbl_chartIsDisabled.Visible = false;
            } else {
                pb_help.Image = Resources.Help_Disabled_24;
                chart1.Titles[0].ForeColor = Settings.Default.InactiveForeColor;
                dgv_apps.DataSource = null;
                lbl_chartIsDisabled.Visible = true;
                dgv_apps.Height--;
                dgv_apps.Visible = lbl_noDataAvailable.Visible = false;
                Invalidate();
            }
        }

        private void CtrlChart_NewLocalLicenseAppStatus_Resize(object sender, EventArgs e) => Invalidate();

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Cursor = Cursors.Default;
            btn_refresh.Enabled = true;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e) {
            var _xAxis = chart1.ChartAreas[0].AxisX;
            var _stripLine = _xAxis.StripLines[0];

            if (chart1.HitTest(e.X, e.Y).ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel)) {
                _selectedMonthNum = (byte) Math.Round(_xAxis.PixelPositionToValue(e.Y), MidpointRounding.AwayFromZero);
                _stripLine.IntervalOffset = _selectedMonthNum + 0.11;
            } else {
                _stripLine.IntervalOffset = 0;
                _selectedMonthNum = Convert.ToByte(dgv_apps.Tag ?? DateTime.Now.Month);
            }
        }

        private void chart1_MouseLeave(object sender, EventArgs e) {
            chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = 0;
            _selectedMonthNum = Convert.ToByte(dgv_apps.Tag ?? DateTime.Now.Month);
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e) {
            if (chart1.HitTest(e.X, e.Y).ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel))
                _BindDgvData();
        }

        private void _BindDgvData() {
            bool _handleHeader = dgv_apps.DataSource is null;
            bool _wasEmpty = dgv_apps.RowCount == 0;

            dgv_apps.DataSource = DVLD_Business.Application.Charting.GetLocalLicenseApps((short) num_year.Value, _selectedMonthNum);

            if (_handleHeader)
                _SetupTableHeaders();

            dgv_apps.Tag = _selectedMonthNum;
            lbl_noDataAvailable.Visible = dgv_apps.RowCount == 0;

            if (lbl_noDataAvailable.Visible) {
                if (!_wasEmpty)
                    dgv_apps.Height--;
            } else if (_isAdditionalLineDrawn)
                dgv_apps.Height++;

            Invalidate();
        }

        private void dgv_apps_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (Settings.Default.CurrentLanguage == SupportedLanguages.English) {
                if (e.RowIndex >= 0 || e.ColumnIndex == 0)
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;

                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_apps.ColumnCount - 1 && !dgv_apps.IsVScrollVisible())
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            } else {
                if (e.RowIndex >= 0 || e.ColumnIndex == 0)
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_apps.ColumnCount - 1 && !dgv_apps.IsVScrollVisible())
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        private void dgv_apps_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 0) {
                e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = Settings.Default.GridHeaderCellColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.BackColor.IsLight() ? Color.Black : Color.White;
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            } else if (dgv_apps.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (dgv_apps.Columns[e.ColumnIndex].Name == "ApplicationStatus") {
                ApplicationStatus _status = (ApplicationStatus) e.Value;

                e.CellStyle.ForeColor = BusinessUtils.Mapping.GetApplicationStatusColor(_status);
                e.Value = BusinessUtils.Mapping.GetApplicationStatusString(_status);
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold | FontStyle.Italic);
                e.FormattingApplied = true;
            }
        }

        private void dgv_apps_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(DVLD_Business.Permissions.LocalLicenseAppsManagement.ViewFullAppDetails)) {
                using (Frm_ShowLocalDrivingLicenseAppInformation _frmShowAppInfo = new Frm_ShowLocalDrivingLicenseAppInformation((int) dgv_apps.CurrentRow.Cells[1].Value)) {
                    if (_frmShowAppInfo.IsDisposed)
                        return;

                    _frmShowAppInfo.PersonSaved += _frmShowAppInfo_PersonSaved;
                    _frmShowAppInfo.ShowDialog();
                    _frmShowAppInfo.PersonSaved -= _frmShowAppInfo_PersonSaved;
                }
            }
        }

        private void _frmShowAppInfo_PersonSaved(int personID) => PersonSaved?.Invoke(personID);

        public void RefreshDataFiltering() { /*Do nothing*/ }

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartNewLocalLicenseAppStatus.chartTitle;
                chart1.ChartAreas[0].AxisY.Title = Str_CtrlChartNewLocalLicenseAppStatus.yAxisTitle;

                chart1.Series[0].LegendText = BusinessUtils.Mapping.GetApplicationStatusString(ApplicationStatus.New);
                chart1.Series[1].LegendText = BusinessUtils.Mapping.GetApplicationStatusString(ApplicationStatus.Completed);
                chart1.Series[2].LegendText = BusinessUtils.Mapping.GetApplicationStatusString(ApplicationStatus.Cancelled);

                foreach (var _series in chart1.Series)
                    _series.ToolTip = $"[#LEGENDTEXT]\n#VAL {Str_CtrlChartTotalApplicationsWithTime.totalApplications}";
            }
        }

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);
    }
}
