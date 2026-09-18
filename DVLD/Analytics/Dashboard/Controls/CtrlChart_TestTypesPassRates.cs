using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class CtrlChart_TestTypesPassRates : UserControl, ICtrlChart {
        private DataView _dvTestPassRates, _dvAvgAttempts, _dvAllTimeTestResults, _dvPerMonthTestResults;
        private byte _selectedMonthNum = (byte) DateTime.Now.Month;

        public CtrlChart_TestTypesPassRates() {
            InitializeComponent();
            chart1.ChartAreas[0].Tag = true; //Handle Secondary Axes

            _ApplyChartLocalizationSettings();
            Settings.Default.ApplyChartStyleSettings(chart1);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_testPassRates;
                chart1.Titles[1].Text = Str_CtrlChartTestTypesPassRates.selectedMonth;
                chart1.Titles[2].Text = Str_CtrlChartTotalApplicationsWithTime.allTime;

                chart1.ChartAreas[1].AxisX.Title = chart1.ChartAreas[2].AxisX.Title = Str_CtrlChartTestTypesPassRates.testResult;
                chart1.ChartAreas[0].AxisY.Title = Str_CtrlChartTestTypesPassRates.passRate;
                chart1.ChartAreas[0].AxisY2.Title = Str_CtrlChartTestTypesPassRates.avgAttempts;
                chart1.ChartAreas[1].AxisY.Title = chart1.ChartAreas[2].AxisY.Title = Str_CtrlChartTestTypesPassRates.totalTests;

                chart1.Series["visionTests"].LegendText = chart1.Series["perMonthVisionResults"].LegendText = chart1.Series["allTimeVisionResults"].LegendText = Str_CtrlChartTestTypesPassRates.visionTests;
                chart1.Series["writtenTests"].LegendText = chart1.Series["perMonthWrittenResults"].LegendText = chart1.Series["allTimeWrittenResults"].LegendText = Str_CtrlChartTestTypesPassRates.writtenTests;
                chart1.Series["drivingTests"].LegendText = chart1.Series["perMonthDrivingResults"].LegendText = chart1.Series["allTimeDrivingResults"].LegendText = Str_CtrlChartTestTypesPassRates.drivingTests;
                chart1.Series["overallTotal"].LegendText = chart1.Series["perMonthOverallTotalResults"].LegendText = chart1.Series["allTimeOverallTotalResults"].LegendText = Str_CtrlChartTotalApplicationsWithTime.overallTotal;

                chart1.Series["avgVisionAttempts"].LegendText = Str_CtrlChartTestTypesPassRates.avgVisionTestAttempts;
                chart1.Series["avgWrittenAttempts"].LegendText = Str_CtrlChartTestTypesPassRates.avgWrittenTestAttempts;
                chart1.Series["avgDrivingAttempts"].LegendText = Str_CtrlChartTestTypesPassRates.avgDrivingTestAttempts;
                chart1.Series["totalAvg"].LegendText = Str_CtrlChartTestTypesPassRates.totalAvgAttempts;

                for (int i = 4; i < 12; i++)
                    chart1.Series[i].ToolTip = $"[#LEGENDTEXT - #VALX]\n‏#VAL {Str_CtrlChartTotalApplicationsWithTime.inTotal}";

                for (int i = 12; i < 16; i++)
                    chart1.Series[i].ToolTip = $"[#LEGENDTEXT]\n‏#VAL {Str_CtrlChartTestTypesPassRates.attemptsOnAvg}";
            }
        }

        private void Default_SettingsSaving(object sender, System.ComponentModel.CancelEventArgs e) {
            BackColor = Settings.Default.SurfaceBackColor;
            Settings.Default.ApplyChartStyleSettings(chart1);
        }

        private void CtrlChart_Tests_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.TestResultsRates_AverageAttemptsToPass)) {
                _ReworkEverything();
                RefreshDataFiltering();
            }
        }

        private void _ReworkEverything() {
            _ReloadAllData();
            _BindAllData();
        }

        private void _BindAllData() {
            _BindData_TestTypesPassRates();
            _BindData_AverageAttempts();
            _BindData_PerMonthTestResults();
            _BindData_AllTimeTestResults();
        }

        private void _BindData_AverageAttempts() {
            string _xField = Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["avgVisionAttempts"].Points.DataBind(_dvAvgAttempts, _xField, "AvgVisionAttempts", null);
            chart1.Series["avgWrittenAttempts"].Points.DataBind(_dvAvgAttempts, _xField, "AvgWrittenAttempts", null);
            chart1.Series["avgDrivingAttempts"].Points.DataBind(_dvAvgAttempts, _xField, "AvgDrivingAttempts", null);
            chart1.Series["totalAvg"].Points.DataBind(_dvAvgAttempts, _xField, "TotalAvgAttempts", null);

            chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_avgAttempts;
        }

        private void _BindData_AllTimeTestResults() {
            lbl_noDataAvailable_allTime.Visible = Enabled && _dvAllTimeTestResults.Count == 0;

            chart1.Series["allTimeVisionResults"].Points.DataBind(_dvAllTimeTestResults, "TestResult", "TotalVisionTests", null);
            chart1.Series["allTimeWrittenResults"].Points.DataBind(_dvAllTimeTestResults, "TestResult", "TotalWrittenTests", null);
            chart1.Series["allTimeDrivingResults"].Points.DataBind(_dvAllTimeTestResults, "TestResult", "TotalDrivingTests", null);
            chart1.Series["allTimeOverallTotalResults"].Points.DataBind(_dvAllTimeTestResults, "TestResult", "OverallTotal", null);
        }

        private void _BindData_PerMonthTestResults() {
            lbl_noDataAvailable_perMonth.Visible = Enabled && _dvPerMonthTestResults.Count == 0;

            chart1.Series["perMonthVisionResults"].Points.DataBind(_dvPerMonthTestResults, "TestResult", "TotalVisionTests", null);
            chart1.Series["perMonthWrittenResults"].Points.DataBind(_dvPerMonthTestResults, "TestResult", "TotalWrittenTests", null);
            chart1.Series["perMonthDrivingResults"].Points.DataBind(_dvPerMonthTestResults, "TestResult", "TotalDrivingTests", null);
            chart1.Series["perMonthOverallTotalResults"].Points.DataBind(_dvPerMonthTestResults, "TestResult", "OverallTotal", null);

            chart1.ChartAreas[1].Tag = _selectedMonthNum;
            chart1.Titles[1].Text = $"{DateTimeFormatInfo.CurrentInfo.GetMonthName(_selectedMonthNum)} ({num_year.Value})";
        }

        private void _BindData_TestTypesPassRates() {
            string _xField = Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["visionTests"].Points.DataBind(_dvTestPassRates, _xField, "VisionPassRate", null);
            chart1.Series["writtenTests"].Points.DataBind(_dvTestPassRates, _xField, "WrittenPassRate", null);
            chart1.Series["drivingTests"].Points.DataBind(_dvTestPassRates, _xField, "DrivingPassRate", null);
            chart1.Series["overallTotal"].Points.DataBind(_dvTestPassRates, _xField, "TotalPassRate", null);

            chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_testPassRates;
            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.TestAppointment.Charting.GetOldestAppointmentYear();
            num_year.Maximum = DVLD_Business.TestAppointment.Charting.GetHighestAppointmentYear();

            _ReloadData_TestPassRates();
            _ReloadData_AverageAttempts();
            _ReloadData_PerMonthTestResults();
            _ReloadData_AllTimeTestResults();
        }

        private void _ReloadData_AverageAttempts() => _dvAvgAttempts = DVLD_Business.Test.Charting.GetAvgAttemptsToPass((short) num_year.Value, Settings.Default.CurrentLanguage);

        private void _ReloadData_AllTimeTestResults() => _dvAllTimeTestResults = DVLD_Business.Test.Charting.GetAllTimeTestResults(Settings.Default.CurrentLanguage);

        private void _ReloadData_PerMonthTestResults() => _dvPerMonthTestResults = DVLD_Business.Test.Charting.GetPerMonthTestResults(_selectedMonthNum, (short) num_year.Value, Settings.Default.CurrentLanguage);

        private void _ReloadData_TestPassRates() => _dvTestPassRates = DVLD_Business.Test.Charting.GetTestPassRates((short) num_year.Value, Settings.Default.CurrentLanguage);

        private void CtrlChart_Tests_Resize(object sender, EventArgs e) => Invalidate();

        private void CtrlChart_Tests_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Enabled = true;
            btn_refresh.Cursor = Cursors.Default;
        }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        public void RefreshDataFiltering() {
            if (!chart1.Enabled) {
                foreach (var _series in chart1.Series)
                    _series.Enabled = false;

                return;
            }

            chart1.Series["perMonthVisionResults"].Enabled = chart1.Series["allTimeVisionResults"].Enabled = chk_visionTests.Checked;
            chart1.Series["perMonthWrittenResults"].Enabled = chart1.Series["allTimeWrittenResults"].Enabled = chk_writtenTests.Checked;
            chart1.Series["perMonthDrivingResults"].Enabled = chart1.Series["allTimeDrivingResults"].Enabled = chk_drivingTests.Checked;
            chart1.Series["perMonthOverallTotalResults"].Enabled = chart1.Series["allTimeOverallTotalResults"].Enabled = chk_overallTotal.Checked;

            if (rb_testPassRates.Checked) {
                chart1.Series["visionTests"].Enabled = chk_visionTests.Checked;
                chart1.Series["writtenTests"].Enabled = chk_writtenTests.Checked;
                chart1.Series["drivingTests"].Enabled = chk_drivingTests.Checked;
                chart1.Series["overallTotal"].Enabled = chk_overallTotal.Checked;

                chart1.Series["avgVisionAttempts"].Enabled = chart1.Series["avgWrittenAttempts"].Enabled = chart1.Series["avgDrivingAttempts"].Enabled = chart1.Series["totalAvg"].Enabled = false;
                chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_testPassRates;
            } else {
                chart1.Series["avgVisionAttempts"].Enabled = chk_visionTests.Checked;
                chart1.Series["avgWrittenAttempts"].Enabled = chk_writtenTests.Checked;
                chart1.Series["avgDrivingAttempts"].Enabled = chk_drivingTests.Checked;
                chart1.Series["totalAvg"].Enabled = chk_overallTotal.Checked;

                chart1.Series["visionTests"].Enabled = chart1.Series["writtenTests"].Enabled = chart1.Series["drivingTests"].Enabled = chart1.Series["overallTotal"].Enabled = false;
                chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_avgAttempts;
            }

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e) {
            var _xAxis = chart1.ChartAreas[0].AxisX;
            var _stripLine = _xAxis.StripLines[0];
            var _hitTestResult = chart1.HitTest(e.X, e.Y);

            if (_hitTestResult.ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel) && _hitTestResult.ChartArea == chart1.ChartAreas[0]) {
                _selectedMonthNum = (byte) Math.Round(_xAxis.PixelPositionToValue(e.X), MidpointRounding.AwayFromZero);

                if (_selectedMonthNum == 0 || _selectedMonthNum == 13)
                    _stripLine.IntervalOffset = -1;
                else
                    _stripLine.IntervalOffset = _selectedMonthNum - 0.5;
            } else {
                _stripLine.IntervalOffset = -1;
                _selectedMonthNum = Convert.ToByte((chart1.ChartAreas[1].Tag ?? DateTime.Now.Month));
            }
        }

        private void chk_visionTests_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["perMonthVisionResults"].Enabled = chart1.Series["allTimeVisionResults"].Enabled = chk_visionTests.Checked; 

            if (rb_testPassRates.Checked) {
                chart1.Series["visionTests"].Enabled = chk_visionTests.Checked;
                chart1.Series["avgVisionAttempts"].Enabled = false;
            } else {
                chart1.Series["avgVisionAttempts"].Enabled = chk_visionTests.Checked;
                chart1.Series["visionTests"].Enabled = false;
            }

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void chk_writtenTests_CheckedChanged(object sender, EventArgs e){ 
            chart1.Series["perMonthWrittenResults"].Enabled = chart1.Series["allTimeWrittenResults"].Enabled = chk_writtenTests.Checked;

            if (rb_testPassRates.Checked) {
                chart1.Series["writtenTests"].Enabled = chk_writtenTests.Checked;
                chart1.Series["avgWrittenAttempts"].Enabled = false;
            } else {
                chart1.Series["avgWrittenAttempts"].Enabled = chk_writtenTests.Checked;
                chart1.Series["writtenTests"].Enabled = false;
            }

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void chk_drivingTests_CheckedChanged(object sender, EventArgs e){
            chart1.Series["perMonthDrivingResults"].Enabled = chart1.Series["allTimeDrivingResults"].Enabled = chk_drivingTests.Checked;

            if (rb_testPassRates.Checked) {
                chart1.Series["drivingTests"].Enabled = chk_drivingTests.Checked;
                chart1.Series["avgDrivingAttempts"].Enabled = false;
            } else {
                chart1.Series["avgDrivingAttempts"].Enabled = chk_drivingTests.Checked;
                chart1.Series["drivingTests"].Enabled = false;
            }

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void chk_overallTotal_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["perMonthOverallTotalResults"].Enabled = chart1.Series["allTimeOverallTotalResults"].Enabled = chk_overallTotal.Checked;

            if (rb_testPassRates.Checked) {
                chart1.Series["overallTotal"].Enabled = chk_overallTotal.Checked;
                chart1.Series["totalAvg"].Enabled = false;
            } else {
                chart1.Series["totalAvg"].Enabled = chk_overallTotal.Checked;
                chart1.Series["overallTotal"].Enabled = false;
            }

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void num_appYear_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void chart1_EnabledChanged(object sender, EventArgs e) {
            RefreshDataFiltering();

            if (chart1.Enabled) {
                pb_help.Image = Resources.Help_24;
                chart1.Titles[0].ForeColor = Settings.Default.BaseForeColor;
                lbl_chartIsDisabled.Visible = false;
                chart1.Titles[1].Visible = chart1.Titles[2].Visible = true;
                lbl_noDataAvailable_perMonth.Visible = _dvPerMonthTestResults.Count == 0;
                lbl_noDataAvailable_allTime.Visible = _dvAllTimeTestResults.Count == 0;
            } else {
                pb_help.Image = Resources.Help_Disabled_24;
                chart1.Titles[0].ForeColor = Settings.Default.InactiveForeColor;
                lbl_chartIsDisabled.Visible = true;
                chart1.Titles[1].Visible = chart1.Titles[2].Visible = lbl_noDataAvailable_perMonth.Visible = lbl_noDataAvailable_allTime.Visible = false;
            }
        }

        private void rb_testPassRates_CheckedChanged(object sender, EventArgs e) {
            if (rb_testPassRates.Checked) {
                chart1.Series["visionTests"].Enabled = chk_visionTests.Checked;
                chart1.Series["writtenTests"].Enabled = chk_writtenTests.Checked;
                chart1.Series["drivingTests"].Enabled = chk_drivingTests.Checked;
                chart1.Series["overallTotal"].Enabled = chk_overallTotal.Checked;

                chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_testPassRates;
            } else
                chart1.Series["visionTests"].Enabled = chart1.Series["writtenTests"].Enabled = chart1.Series["drivingTests"].Enabled = chart1.Series["overallTotal"].Enabled = false;

            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);

        private void rb_avgAttempts_CheckedChanged(object sender, EventArgs e) {
            if (rb_avgAttempts.Checked) {
                chart1.Series["avgVisionAttempts"].Enabled = chk_visionTests.Checked;
                chart1.Series["avgWrittenAttempts"].Enabled = chk_writtenTests.Checked;
                chart1.Series["avgDrivingAttempts"].Enabled = chk_drivingTests.Checked;
                chart1.Series["totalAvg"].Enabled = chk_overallTotal.Checked;

                chart1.Titles[0].Text = Str_CtrlChartTestTypesPassRates.chartTitle_avgAttempts;
            } else
                chart1.Series["avgVisionAttempts"].Enabled = chart1.Series["avgWrittenAttempts"].Enabled = chart1.Series["avgDrivingAttempts"].Enabled = chart1.Series["totalAvg"].Enabled = false;
            
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e) {
            var _hitTestResult = chart1.HitTest(e.X, e.Y);

            if (_hitTestResult.ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel) && _hitTestResult.ChartArea == chart1.ChartAreas[0]) {
                _ReloadData_PerMonthTestResults();
                _BindData_PerMonthTestResults();
            }
        }

        private void chart1_MouseLeave(object sender, EventArgs e) {
            chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = -1;
            _selectedMonthNum = Convert.ToByte((chart1.ChartAreas[1].Tag ?? DateTime.Now.Month));
        }
    }
}
