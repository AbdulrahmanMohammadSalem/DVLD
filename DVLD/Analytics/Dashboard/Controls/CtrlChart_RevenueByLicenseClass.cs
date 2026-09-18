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
    public partial class CtrlChart_RevenueByLicenseClass : UserControl, ICtrlChart {
        private DataView _dvPerMonthRevenues, _dvAllTimeRevenues;

        public CtrlChart_RevenueByLicenseClass() {
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

        private void CtrlChart_RevenueByLicenseClass_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.RevenueByLicenseClass)) {
                _ReworkEverything();
                RefreshDataFiltering();
            }
        }

        private void CtrlChart_RevenueByLicenseClass_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });
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

            _series.Points.DataBind(_dvAllTimeRevenues, "LicenseClassID", "TotalRevenue", null);

            _series.Points[0].Color = Color.FromArgb(65, 140, 240);
            _series.Points[0].LegendText = Str_CtrlChartRevenueByLicenseClass.class1;

            _series.Points[1].Color = Color.FromArgb(252, 180, 65);
            _series.Points[1].LegendText = Str_CtrlChartRevenueByLicenseClass.class2;

            _series.Points[2].Color = Color.FromArgb(224, 64, 10);
            _series.Points[2].LegendText = Str_CtrlChartRevenueByLicenseClass.class3;

            _series.Points[3].Color = Color.FromArgb(5, 100, 146);
            _series.Points[3].LegendText = Str_CtrlChartRevenueByLicenseClass.class4;

            _series.Points[4].Color = Color.FromArgb(128, 128, 128);
            _series.Points[4].LegendText = Str_CtrlChartRevenueByLicenseClass.class5;

            _series.Points[5].Color = Color.FromArgb(26, 59, 105);
            _series.Points[5].LegendText = Str_CtrlChartRevenueByLicenseClass.class6;

            _series.Points[6].Color = Color.FromArgb(148, 195, 9);
            _series.Points[6].LegendText = Str_CtrlChartRevenueByLicenseClass.class7;

            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English)
                _series.ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}\n#PERCENT{{P2}} {Str_CtrlChartRevenueByServiceType.outOf} #TOTAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
            else
                _series.ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}\n‏#PERCENT{{P2}} {Str_CtrlChartRevenueByServiceType.outOf} #TOTAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
        }

        private void _BindData_PerMonthRevenues() {
            string _xField = Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["perMonthTotalRevenue"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue", null);
            chart1.Series["class1"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_SmallMotorcycles", null);
            chart1.Series["class2"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_HeavyMotorcycles", null);
            chart1.Series["class3"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_Ordinary", null);
            chart1.Series["class4"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_Commercial", null);
            chart1.Series["class5"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_Agricultural", null);
            chart1.Series["class6"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_SmallMediumBuses", null);
            chart1.Series["class7"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalRevenue_TruckHeavyVehicles", null);

            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.Application.Charting.GetOldestAppYear();
            num_year.Maximum = DVLD_Business.Application.Charting.GetHighestAppYear();

            _dvPerMonthRevenues = DVLD_Business.LicenseClass.Charting.GetPerMonthLicenseClassesRevenues((short) num_year.Value, Settings.Default.CurrentLanguage);
            _dvAllTimeRevenues = DVLD_Business.LicenseClass.Charting.GetAllTimeLicenseClassesRevenues();
        }

        private void num_year_ValueChanged(object sender, EventArgs e) => _ReworkEverything();

        private void num_year_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void rb_revenueComposition_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["class1"].Enabled = chart1.Series["class2"].Enabled = chart1.Series["class3"].Enabled = chart1.Series["class4"].Enabled = chart1.Series["class5"].Enabled = chart1.Series["class6"].Enabled = chart1.Series["class7"].Enabled = rb_revenueComposition.Checked;
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

            chart1.Series["class1"].Enabled = chart1.Series["class2"].Enabled = chart1.Series["class3"].Enabled = chart1.Series["class4"].Enabled = chart1.Series["class5"].Enabled = chart1.Series["class6"].Enabled = chart1.Series["class7"].Enabled = rb_revenueComposition.Checked;
            chart1.Series["perMonthTotalRevenue"].Enabled = rb_totalRevenue.Checked;
            chart1.Series["allTimeTotalRevenue"].Enabled = true;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Cursor = Cursors.Default;
            btn_refresh.Enabled = true;
        }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        private void chart1_EnabledChanged(object sender, EventArgs e) {
            RefreshDataFiltering();

            lbl_chartIsDisabled.Visible = !chart1.Enabled;
            chart1.Titles[1].Visible = chart1.Enabled;
            pb_help.Image = chart1.Enabled ? Resources.Help_24 : Resources.Help_Disabled_24;
        }

        private void CtrlChart_RevenueByLicenseClass_Resize(object sender, EventArgs e) => Invalidate();

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartRevenueByLicenseClass.chartTitle;
                chart1.Titles[1].Text = Str_CtrlChartTotalApplicationsWithTime.allTime;

                chart1.ChartAreas[0].AxisY.Title = Str_CtrlChartRevenueByServiceType.revenue;

                chart1.Series["class1"].LegendText = Str_CtrlChartRevenueByLicenseClass.class1;
                chart1.Series["class2"].LegendText = Str_CtrlChartRevenueByLicenseClass.class2;
                chart1.Series["class3"].LegendText = Str_CtrlChartRevenueByLicenseClass.class3;
                chart1.Series["class4"].LegendText = Str_CtrlChartRevenueByLicenseClass.class4;
                chart1.Series["class5"].LegendText = Str_CtrlChartRevenueByLicenseClass.class5;
                chart1.Series["class6"].LegendText = Str_CtrlChartRevenueByLicenseClass.class6;
                chart1.Series["class7"].LegendText = Str_CtrlChartRevenueByLicenseClass.class7;
                chart1.Series["perMonthTotalRevenue"].LegendText = Str_CtrlChartRevenueByServiceType.totalRevenue;

                for (int i = 0; i < 7; i++)
                    chart1.Series[i].ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}";

                chart1.Series["perMonthTotalRevenue"].ToolTip = $"‏#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
            }
        }
    }
}
