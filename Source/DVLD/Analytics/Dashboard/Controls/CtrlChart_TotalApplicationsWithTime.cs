using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class CtrlChart_TotalApplicationsWithTime : UserControl, ICtrlChart {
        private DataView _dvAppTypesPerMonths, _dvOverallAppsPerMonths, _dvAppTypesPerDays, _dvOverallAppsPerDays, _dvTotalAppsAllTime;
        private byte _selectedMonthNum = (byte) DateTime.Now.Month;

        public CtrlChart_TotalApplicationsWithTime() {
            InitializeComponent();

            Settings.Default.ApplyChartStyleSettings(chart1);
            _ApplyChartLocalizationSettings();
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            BackColor = Settings.Default.SurfaceBackColor;
            Settings.Default.ApplyChartStyleSettings(chart1);
        }

        private void CtrlChart_TotalApplicationsWithTime_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });
            }
        }

        private void CtrlChart_TotalApplicationsWithTime_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.TotalApplicationsOverTime)) {
                _selectedMonthNum = (byte) DateTime.Now.Month;
                _ScrollQuarters((short) (_selectedMonthNum / 3));
                _ReworkEverything();
            }
        }

        private void num_appYear_ValueChanged(object sender, EventArgs e) => _ReworkEverything();

        private void cb_appStatus_SelectedIndexChanged(object sender, EventArgs e) => _ReworkEverything();

        private void num_appYear_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void _ReworkEverything() {
            _ReloadAllData();
            _BindAllData();
        }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        private void _BindAllData() {
            _BindData_TotalAppsPerMonths();
            _BindData_TotalAppsPerDays();
            _BindData_TotalAppsAllTime();
        }

        private void _BindData_TotalAppsAllTime() {
            var _series = chart1.Series["totalAppsAllTime"];

            _series.Points.DataBind(_dvTotalAppsAllTime, "ApplicationTypeID", "TotalApplications", null);

            _series.Points[0].Color = Color.FromArgb(65, 140, 240);
            _series.Points[0].LegendText = Str_CtrlChartTotalApplicationsWithTime.newLocalLicense;

            _series.Points[1].Color = Color.FromArgb(252, 180, 65);
            _series.Points[1].LegendText = Str_CtrlChartTotalApplicationsWithTime.renewLicense;

            _series.Points[2].Color = Color.FromArgb(224, 64, 10);
            _series.Points[2].LegendText = Str_CtrlChartTotalApplicationsWithTime.replaceLostLicense;

            _series.Points[3].Color = Color.FromArgb(5, 100, 146);
            _series.Points[3].LegendText = Str_CtrlChartTotalApplicationsWithTime.replaceDamagedLicense;

            _series.Points[4].Color = Color.FromArgb(128, 128, 128);
            _series.Points[4].LegendText = Str_CtrlChartTotalApplicationsWithTime.releaseDetainedLicense;

            _series.Points[5].Color = Color.FromArgb(26, 59, 105);
            _series.Points[5].LegendText = Str_CtrlChartTotalApplicationsWithTime.newInterLicense;

            _series.Points[6].Color = Color.FromArgb(148, 195, 9);
            _series.Points[6].LegendText = Str_CtrlChartTotalApplicationsWithTime.retakeFailedTest;

            _series.ToolTip = $"[#LEGENDTEXT]\n#VAL {Str_CtrlChartTotalApplicationsWithTime.totalApplications}\n#PERCENT{{P2}}";
        }

        private void _BindData_TotalAppsPerDays() {
            if (!_selectedMonthNum.Between<byte>(1, 12))
                _selectedMonthNum = (byte) DateTime.Now.Month;
            
            for (ApplicationTypes _appTypeID = ApplicationTypes.NewLocalLicense; _appTypeID <= ApplicationTypes.RetakeFailedTest; _appTypeID++) {
                _dvAppTypesPerDays.RowFilter = $"ApplicationTypeID = {(byte) _appTypeID}";
                chart1.Series[(int) _appTypeID + 7].Points.DataBind(_dvAppTypesPerDays, "Date", "TotalApplications", null);
            }
            
            chart1.Series["overallTotalDays"].Points.DataBind(_dvOverallAppsPerDays, "Date", "OverallTotal", null);
            chart1.ChartAreas[1].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.days} ({DateTimeFormatInfo.CurrentInfo.GetMonthName(_selectedMonthNum)})";
            chart1.ChartAreas[1].Tag = _selectedMonthNum;
        }

        private void _BindData_TotalAppsPerMonths() {
            string _monthColumnName = Settings.Default.CurrentLanguage == SupportedLanguages.Arabic ? "MonthNameAR" : "MonthName";
            
            for (ApplicationTypes _appTypeID = ApplicationTypes.NewLocalLicense; _appTypeID <= ApplicationTypes.RetakeFailedTest; _appTypeID++) {
                _dvAppTypesPerMonths.RowFilter = $"ApplicationTypeID = {(byte) _appTypeID}";
                chart1.Series[(int) _appTypeID - 1].Points.DataBind(_dvAppTypesPerMonths, _monthColumnName, "TotalApplications", null);
            }

            chart1.Series["overallTotal"].Points.DataBind(_dvOverallAppsPerMonths, _monthColumnName, "OverallTotal", null);
            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.Application.Charting.GetOldestAppYear();
            num_year.Maximum = DVLD_Business.Application.Charting.GetHighestAppYear();

            _ReloadData_TotalAppsPerMonths();
            _ReloadData_TotalAppsPerDays();
            _ReloadData_TotalAppsAllTime();
        }

        private void _ReloadData_TotalAppsAllTime() => _dvTotalAppsAllTime = DVLD_Business.Application.Charting.GetTotalAppsAllTime();

        private void _ReloadData_TotalAppsPerDays() {
            if (!_selectedMonthNum.Between<byte>(1, 12))
                _selectedMonthNum = (byte) DateTime.Now.Month;

            _dvAppTypesPerDays = DVLD_Business.Application.Charting.GetAppTypesPerDays((short) num_year.Value, _selectedMonthNum, (ApplicationStatus) (cb_appStatus.SelectedIndex + 2));
            _dvOverallAppsPerDays = DVLD_Business.Application.Charting.GetOverallAppsPerDays((short) num_year.Value, _selectedMonthNum, (ApplicationStatus) (cb_appStatus.SelectedIndex + 2));
        }

        private void _ReloadData_TotalAppsPerMonths() {
            _dvAppTypesPerMonths = DVLD_Business.Application.Charting.GetAppTypesPerMonths((short) num_year.Value, (ApplicationStatus) (cb_appStatus.SelectedIndex + 2), Settings.Default.CurrentLanguage);
            _dvOverallAppsPerMonths = DVLD_Business.Application.Charting.GetOverallAppsPerMonths((short) num_year.Value, (ApplicationStatus) (cb_appStatus.SelectedIndex + 2), Settings.Default.CurrentLanguage);
        }

        public void RefreshDataFiltering() {
            if (!chart1.Enabled) {
                foreach (var _series in chart1.Series)
                    _series.Enabled = false;

                return;
            }

            chart1.Series["newLocalLicense"].Enabled = chart1.Series["newLocalLicenseDays"].Enabled = chk_newLocalLicense.Checked;
            chart1.Series["newInterLicense"].Enabled = chart1.Series["newInterLicenseDays"].Enabled = chk_newInterLicense.Checked;
            chart1.Series["replaceLostLicense"].Enabled = chart1.Series["replaceLostLicenseDays"].Enabled = chk_replaceLostLicense.Checked;
            chart1.Series["replaceDamagedLicense"].Enabled = chart1.Series["replaceDamagedLicenseDays"].Enabled = chk_replaceDamagedLicense.Checked;
            chart1.Series["renewLicense"].Enabled = chart1.Series["renewLicenseDays"].Enabled = chk_renewLicense.Checked;
            chart1.Series["releaseDetainedLicense"].Enabled = chart1.Series["releaseDetainedLicenseDays"].Enabled = chk_releaseDetainedLicense.Checked;
            chart1.Series["retakeFailedTest"].Enabled = chart1.Series["retakeFailedTestDays"].Enabled = chk_retakeFailedTest.Checked;
            chart1.Series["overallTotal"].Enabled = chart1.Series["overallTotalDays"].Enabled = chk_overallTotal.Checked;
        }

        private void chk_newLocalLicense_CheckedChanged(object sender, EventArgs e) => chart1.Series["newLocalLicense"].Enabled = chart1.Series["newLocalLicenseDays"].Enabled = chk_newLocalLicense.Checked;

        private void chk_newInterLicense_CheckedChanged(object sender, EventArgs e) => chart1.Series["newInterLicense"].Enabled = chart1.Series["newInterLicenseDays"].Enabled = chk_newInterLicense.Checked;

        private void chk_replaceLostLicense_CheckedChanged(object sender, EventArgs e) => chart1.Series["replaceLostLicense"].Enabled = chart1.Series["replaceLostLicenseDays"].Enabled = chk_replaceLostLicense.Checked;

        private void chk_replaceDamagedLicense_CheckedChanged(object sender, EventArgs e) => chart1.Series["replaceDamagedLicense"].Enabled = chart1.Series["replaceDamagedLicenseDays"].Enabled = chk_replaceDamagedLicense.Checked;

        private void chk_renewLicense_CheckedChanged(object sender, EventArgs e) => chart1.Series["renewLicense"].Enabled = chart1.Series["renewLicenseDays"].Enabled = chk_renewLicense.Checked;

        private void chk_releaseDetainedLicense_CheckedChanged(object sender, EventArgs e) => chart1.Series["releaseDetainedLicense"].Enabled = chart1.Series["releaseDetainedLicenseDays"].Enabled = chk_releaseDetainedLicense.Checked;

        private void chk_retakeFailedTest_CheckedChanged(object sender, EventArgs e) => chart1.Series["retakeFailedTest"].Enabled = chart1.Series["retakeFailedTestDays"].Enabled = chk_retakeFailedTest.Checked;

        private void chk_overallTotal_CheckedChanged(object sender, EventArgs e) => chart1.Series["overallTotal"].Enabled = chart1.Series["overallTotalDays"].Enabled = chk_overallTotal.Checked;

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Cursor = Cursors.Default;
            btn_refresh.Enabled = true;
        }

        private void ll_appTypesPerMonths_nextQuarter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ScrollQuarters(1);

        private void ll_appTypesPerMonths_prevQuarter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ScrollQuarters(-1);

        private void _ScrollQuarters(short quarters) {
            chart1.ChartAreas[0].AxisX.ScaleView.Position += quarters * 3;
            ll_nextQuarter.Enabled = chart1.ChartAreas[0].AxisX.ScaleView.Position < 10;
            ll_prevQuarter.Enabled = chart1.ChartAreas[0].AxisX.ScaleView.Position > 1;
        }

        private void CtrlChart_TotalApplicationsWithTime_Resize(object sender, EventArgs e) => Invalidate();

        private void chart1_MouseClick(object sender, MouseEventArgs e) {
            var _hitTestResult = chart1.HitTest(e.X, e.Y);

            if (_hitTestResult.ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel) && _hitTestResult.ChartArea == chart1.ChartAreas[0]) {
                _ReloadData_TotalAppsPerDays();
                _BindData_TotalAppsPerDays();
            }
        }

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);

        private void chrt_appTypesPerMonths_EnabledChanged(object sender, EventArgs e) {
            RefreshDataFiltering();

            if (chart1.Enabled) {
                pb_help.Image = Resources.Help_24;
                chart1.Titles[0].ForeColor = Settings.Default.BaseForeColor;
                lbl_chartIsDisabled.Visible = false;
                chart1.Titles[1].Visible = true;
            } else {
                pb_help.Image = Resources.Help_Disabled_24;
                chart1.Titles[0].ForeColor = Settings.Default.InactiveForeColor;
                lbl_chartIsDisabled.Visible = true;
                chart1.Titles[1].Visible = false;
            }
        }

        private void chrt_appTypesPerMonths_MouseMove(object sender, MouseEventArgs e) {
            var _xAxis = chart1.ChartAreas[0].AxisX;
            var _stripLine = _xAxis.StripLines[0];
            var _hitTestResult = chart1.HitTest(e.X, e.Y);

            if (_hitTestResult.ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel) && _hitTestResult.ChartArea == chart1.ChartAreas[0]) {
                _selectedMonthNum = (byte) Math.Round(_xAxis.PixelPositionToValue(e.X), MidpointRounding.AwayFromZero);
                _stripLine.IntervalOffset = _selectedMonthNum == 0 || _selectedMonthNum == 13 ? -1 : _selectedMonthNum - 0.5;
            } else {
                _stripLine.IntervalOffset = -1;
                _selectedMonthNum = Convert.ToByte((chart1.ChartAreas[1].Tag ?? DateTime.Now.Month));
            }
        }

        private void chrt_appTypesPerMonths_MouseLeave(object sender, EventArgs e) {
            chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = -1;
            _selectedMonthNum = Convert.ToByte(chart1.ChartAreas[1].Tag ?? DateTime.Now.Month);
        }

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartTotalApplicationsWithTime.chartTitle;
                chart1.Titles[1].Text = Str_CtrlChartTotalApplicationsWithTime.allTime;

                chart1.Series["newLocalLicense"].LegendText = chart1.Series["newLocalLicenseDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.newLocalLicense;
                chart1.Series["newInterLicense"].LegendText = chart1.Series["newInterLicenseDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.newInterLicense;
                chart1.Series["replaceLostLicense"].LegendText = chart1.Series["replaceLostLicenseDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.replaceLostLicense;
                chart1.Series["replaceDamagedLicense"].LegendText = chart1.Series["replaceDamagedLicenseDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.replaceDamagedLicense;
                chart1.Series["renewLicense"].LegendText = chart1.Series["renewLicenseDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.renewLicense;
                chart1.Series["releaseDetainedLicense"].LegendText = chart1.Series["releaseDetainedLicenseDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.releaseDetainedLicense;
                chart1.Series["retakeFailedTest"].LegendText = chart1.Series["retakeFailedTestDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.retakeFailedTest;
                chart1.Series["overallTotal"].LegendText = chart1.Series["overallTotalDays"].LegendText = Str_CtrlChartTotalApplicationsWithTime.overallTotal;

                for (int i = 0; i < chart1.Series.Count - 1; i++)
                    chart1.Series[i].ToolTip = $"[#LEGENDTEXT]\n‏#VAL {Str_CtrlChartTotalApplicationsWithTime.inTotal}";

                foreach (var _chartArea in chart1.ChartAreas) {
                    _chartArea.AxisY.Title = Str_CtrlChartTotalApplicationsWithTime.totalApplications;
                    _chartArea.AxisY2.Title = Str_CtrlChartTotalApplicationsWithTime.overallTotal;
                }
            }
        }
    }
}
