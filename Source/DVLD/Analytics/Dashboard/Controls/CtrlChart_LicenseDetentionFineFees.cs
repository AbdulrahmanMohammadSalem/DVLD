using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class CtrlChart_LicenseDetentionFineFees : UserControl, ICtrlChart {
        private DataView _dvPerMonthRevenues, _dvAllTimeRevenues;

        public CtrlChart_LicenseDetentionFineFees() {
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

        private void CtrlChart_LicenseDetainFineFees_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.LicenseDetentionFineFees)) {
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

            _series.Points.DataBind(_dvAllTimeRevenues, "IsReleased", "TotalFees", null);

            _series.Points[0].Color = Color.FromArgb(252, 180, 65);
            _series.Points[0].LegendText = Str_CtrlChartLicenseDetainFineFees.unreleasedLicenses;
            
            _series.Points[1].Color = Color.FromArgb(65, 140, 240);
            _series.Points[1].LegendText = Str_CtrlChartLicenseDetainFineFees.releasedLicenses;

            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English)
                _series.ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}\n#PERCENT{{P2}} {Str_CtrlChartRevenueByServiceType.outOf} #TOTAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
            else
                _series.ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}\n‏#PERCENT{{P2}} {Str_CtrlChartRevenueByServiceType.outOf} #TOTAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
        }

        private void _BindData_PerMonthRevenues() {
            string _xField = Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["perMonthTotalRevenue"].Points.DataBind(_dvPerMonthRevenues, _xField, "GrandTotalFees", null);
            chart1.Series["releasedLicenses"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalFees_ReleasedLicenses", null);
            chart1.Series["unreleasedLicenses"].Points.DataBind(_dvPerMonthRevenues, _xField, "TotalFees_UnreleasedLicenses", null);

            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.LicenseDetention.Charting.GetLowestYear();
            num_year.Maximum = DVLD_Business.LicenseDetention.Charting.GetHighestYear();

            _dvPerMonthRevenues = DVLD_Business.LicenseDetention.Charting.GetPerMonthTotalFees((short) num_year.Value, Settings.Default.CurrentLanguage);
            _dvAllTimeRevenues = DVLD_Business.LicenseDetention.Charting.GetAllTimeTotalFees();
        }

        private void CtrlChart_LicenseDetainFineFees_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });
            }
        }

        private void CtrlChart_LicenseDetainFineFees_Resize(object sender, EventArgs e) => Invalidate();

        private void chart1_EnabledChanged(object sender, EventArgs e) {
            RefreshDataFiltering();

            lbl_chartIsDisabled.Visible = !chart1.Enabled;
            chart1.Titles[1].Visible = chart1.Enabled;
            pb_help.Image = chart1.Enabled ? Resources.Help_24 : Resources.Help_Disabled_24;
        }

        private void num_year_ValueChanged(object sender, EventArgs e) => _ReworkEverything();

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Cursor = Cursors.Default;
            btn_refresh.Enabled = true;
        }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        private void rb_feesComposition_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["releasedLicenses"].Enabled = chart1.Series["unreleasedLicenses"].Enabled = rb_feesCategories.Checked;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void rb_summation_CheckedChanged(object sender, EventArgs e) {
            chart1.Series["perMonthTotalRevenue"].Enabled = rb_summation.Checked;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        public void RefreshDataFiltering() {
            if (!chart1.Enabled) {
                foreach (var _series in chart1.Series)
                    _series.Enabled = false;

                return;
            }

            chart1.Series["releasedLicenses"].Enabled = chart1.Series["unreleasedLicenses"].Enabled = rb_feesCategories.Checked;
            chart1.Series["perMonthTotalRevenue"].Enabled = rb_summation.Checked;
            chart1.Series["allTimeTotalRevenue"].Enabled = true;
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void num_year_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartLicenseDetainFineFees.chartTitle;
                chart1.Titles[1].Text = Str_CtrlChartTotalApplicationsWithTime.allTime;

                chart1.ChartAreas[0].AxisY.Title = Str_CtrlChartLicenseDetainFineFees.fees;

                chart1.Series["releasedLicenses"].LegendText = Str_CtrlChartLicenseDetainFineFees.releasedLicenses;
                chart1.Series["unreleasedLicenses"].LegendText = Str_CtrlChartLicenseDetainFineFees.unreleasedLicenses;
                chart1.Series["perMonthTotalRevenue"].LegendText = Str_CtrlChartLicenseDetainFineFees.summation;

                chart1.Series["releasedLicenses"].LegendToolTip = Str_CtrlChartLicenseDetainFineFees.releasedLicensesLegendToolTip;
                chart1.Series["unreleasedLicenses"].LegendToolTip = Str_CtrlChartLicenseDetainFineFees.unreleasedLicensesLegendToolTip;

                chart1.Series["releasedLicenses"].ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.totalRevenue}";
                chart1.Series["unreleasedLicenses"].ToolTip = $"[#LEGENDTEXT]\n#VAL{{C2}} {Str_CtrlChartLicenseDetainFineFees.totalFees}";
                chart1.Series["perMonthTotalRevenue"].ToolTip = $"‏#VAL{{C2}} {Str_CtrlChartRevenueByServiceType.grandTotal}";
            }
        }
    }
}
