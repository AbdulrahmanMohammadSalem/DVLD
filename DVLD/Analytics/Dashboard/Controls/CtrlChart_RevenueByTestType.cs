using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class CtrlChart_RevenueByTestType : UserControl, ICtrlChart {
        private DataView _dvPerMonthRevenues, _dvAllTimeRevenues;

        public CtrlChart_RevenueByTestType() {
            InitializeComponent();

            _ApplyChartLocalizationSettings();
            chart1.Series["perMonthTotalRevenue"].BackSecondaryColor = Settings.Default.SurfaceBackColor;
            chart1.Series["perMonthTotalRevenue"].MarkerColor = Settings.Default.BaseForeColor;
            Settings.Default.ApplyChartStyleSettings(chart1);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            BackColor = Settings.Default.SurfaceBackColor;
            chart1.Series["perMonthTotalRevenue"].BackSecondaryColor = Settings.Default.SurfaceBackColor;
            chart1.Series["perMonthTotalRevenue"].MarkerColor = Settings.Default.BaseForeColor;
            Settings.Default.ApplyChartStyleSettings(chart1);
        }

        private void CtrlChart_RevenueByTestType_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });
            }
        }

        private void num_year_ValueChanged(object sender, EventArgs e) => _ReworkEverything();

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Cursor = Cursors.Default;
            btn_refresh.Enabled = true;
        }

        private void num_year_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void CtrlChart_RevenueByTestType_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.RevenueByTestType)) {
                _ReworkEverything();
                RefreshDataFiltering();
            }
        }

        private void _ReworkEverything() {
            _ReloadAllData();
            _BindAllData();
        }

        private void _BindAllData() {
            _BindData_PerMonthRevenues();
            _BindData_AllTimeRevenues();
        }

        private void _BindData_AllTimeRevenues() {
            var _series = chart1.Series["allTimeTotalRevenue"];

            _series.Points.DataBind(_dvAllTimeRevenues, "TestTypeID", "TotalRevenue", null);

            _series.Points[0].Color = Color.FromArgb(65, 140, 240);
            _series.Points[0].LegendText = Str_CtrlChartTestTypesPassRates.visionTests;

            _series.Points[1].Color = Color.FromArgb(252, 180, 65);
            _series.Points[1].LegendText = Str_CtrlChartTestTypesPassRates.writtenTests;

            _series.Points[2].Color = Color.FromArgb(224, 64, 10);
            _series.Points[2].LegendText = Str_CtrlChartTestTypesPassRates.drivingTests;

            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English)
                _series.ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}\n#PERCENT{{P2}} {Str_CtrlChartRevenueByServiceType.outOf} #TOTAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
            else
                _series.ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}\n‏#PERCENT{{P2}} {Str_CtrlChartRevenueByServiceType.outOf} #TOTAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
        }

        private void _BindData_PerMonthRevenues() {
            string _xField = Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["perMonthTotalRevenue"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue", null);
            chart1.Series["visionTests"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_VisionTests", null);
            chart1.Series["writtenTests"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_WrittenTests", null);
            chart1.Series["drivingTests"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_DrivingTests", null);

            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.Application.Charting.GetOldestAppYear();
            num_year.Maximum = DVLD_Business.Application.Charting.GetHighestAppYear();

            _dvPerMonthRevenues = DVLD_Business.TestType.Charting.GetPerMonthTestTypesRevenues((short) num_year.Value, Settings.Default.CurrentLanguage);
            _dvAllTimeRevenues = DVLD_Business.TestType.Charting.GetAllTimeTestTypesRevenues();
        }

        private void CtrlChart_RevenueByTestType_Resize(object sender, EventArgs e) => Invalidate();

        private void rb_revenueComposition_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["visionTests"].Enabled = chart1.Series["writtenTests"].Enabled = chart1.Series["drivingTests"].Enabled = rb_revenueComposition.Checked;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void rb_totalRevenue_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["perMonthTotalRevenue"].Enabled = rb_totalRevenue.Checked;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        public void RefreshDataFiltering() {
            if (!chart1.Enabled) {
                foreach (var _series in chart1.Series)
                    _series.Enabled = false;

                return;
            }

            chart1.Series["visionTests"].Enabled = chart1.Series["writtenTests"].Enabled = chart1.Series["drivingTests"].Enabled = rb_revenueComposition.Checked;
            chart1.Series["perMonthTotalRevenue"].Enabled = rb_totalRevenue.Checked;
            chart1.Series["allTimeTotalRevenue"].Enabled = true;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void chart1_EnabledChanged(object sender, EventArgs e) {
            RefreshDataFiltering();

            lbl_chartIsDisabled.Visible = !chart1.Enabled;
            chart1.Titles[1].Visible = chart1.Enabled;
            pb_help.Image = chart1.Enabled ? Resources.Help_24 : Resources.Help_Disabled_24;
        }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartRevenueByTestType.chartTitle;
                chart1.Titles[1].Text = Str_CtrlChartTotalApplicationsWithTime.allTime;

                chart1.ChartAreas[0].AxisY.Title = Str_CtrlChartRevenueByServiceType.revenue;

                chart1.Series["visionTests"].LegendText = Str_CtrlChartTestTypesPassRates.visionTests;
                chart1.Series["writtenTests"].LegendText = Str_CtrlChartTestTypesPassRates.writtenTests;
                chart1.Series["drivingTests"].LegendText = Str_CtrlChartTestTypesPassRates.drivingTests;
                chart1.Series["perMonthTotalRevenue"].LegendText = Str_CtrlChartRevenueByServiceType.totalRevenue;

                for (int i = 0; i < 4; i++)
                    chart1.Series[i].ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}";

                chart1.Series["perMonthTotalRevenue"].ToolTip = $"‏#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
            }
        }
    }
}
