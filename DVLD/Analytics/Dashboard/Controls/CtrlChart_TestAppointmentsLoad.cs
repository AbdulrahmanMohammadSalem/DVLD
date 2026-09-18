using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Chart_Controls;
using DVLD.String_Resources.Forms;
using DVLD.String_Resources.Layouts;
using DVLD.Tests;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static DVLD_Business.Permissions;

namespace DVLD.Analytics.Dashboard.Controls {
    public partial class CtrlChart_TestAppointmentsLoad : UserControl, ICtrlChart {
        public event Action DataSaved, ForceExit;

        private DataView _dvTotalAppointmentsPerMonths;
        private byte _selectedMonthNum = (byte) DateTime.Now.Month;
        private bool _isAdditionalLineDrawn = false;

        private bool TakeTestViable => editToolStripMenuItem.Enabled && DateTime.Compare(DateTime.Now, (DateTime) dgv_appointments.CurrentRow.Cells[3].Value) > 0;

        public CtrlChart_TestAppointmentsLoad() {
            InitializeComponent();

            _ApplyChartLocalizationSettings();
            Settings.Default.ApplyChartStyleSettings(chart1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_appointments);
            dgv_appointments.Columns[0].HeaderCell.Style.SelectionBackColor = Settings.Default.GridHeaderCellColor;
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            BackColor = Settings.Default.SurfaceBackColor;
            Settings.Default.ApplyChartStyleSettings(chart1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_appointments);
            dgv_appointments.Columns[0].HeaderCell.Style.SelectionBackColor = Settings.Default.GridHeaderCellColor;
        }

        private void num_year_ValueChanged(object sender, EventArgs e) => _ReworkEverything();

        private void num_year_Enter(object sender, EventArgs e) => ActiveControl = null;

        private void chart1_EnabledChanged(object sender, EventArgs e) {
            foreach (var _series in chart1.Series)
                _series.Enabled = chart1.Enabled;

            if (chart1.Enabled) {
                pb_help.Image = Resources.Help_24;
                chart1.Titles[0].ForeColor = Settings.Default.BaseForeColor;
                dgv_appointments.Visible = true;
                _BindDgvData();
                lbl_chartIsDisabled.Visible = false;
            } else {
                pb_help.Image = Resources.Help_Disabled_24;
                chart1.Titles[0].ForeColor = Settings.Default.InactiveForeColor;
                dgv_appointments.DataSource = null;
                lbl_chartIsDisabled.Visible = true;
                dgv_appointments.Height--;
                dgv_appointments.Visible = lbl_noDataAvailable.Visible = false;
                Invalidate();
            }
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e) {
            if (chart1.HitTest(e.X, e.Y).ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel))
                _BindDgvData();
        }

        private void chart1_MouseLeave(object sender, EventArgs e) {
            chart1.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = 0;
            _selectedMonthNum = Convert.ToByte(dgv_appointments.Tag ?? DateTime.Now.Month);
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e) {
            var _xAxis = chart1.ChartAreas[0].AxisX;
            var _stripLine = _xAxis.StripLines[0];

            if (chart1.HitTest(e.X, e.Y).ChartElementType.In(ChartElementType.StripLines, ChartElementType.PlottingArea, ChartElementType.Gridlines, ChartElementType.DataPoint, ChartElementType.DataPointLabel)) {
                _selectedMonthNum = (byte) Math.Round(_xAxis.PixelPositionToValue(e.Y), MidpointRounding.AwayFromZero);
                _stripLine.IntervalOffset = _selectedMonthNum + 0.11;
            } else {
                _stripLine.IntervalOffset = 0;
                _selectedMonthNum = Convert.ToByte(dgv_appointments.Tag ?? DateTime.Now.Month);
            }
        }

        private void _BindDgvData() {
            bool _handleHeader = dgv_appointments.DataSource is null;
            bool _wasEmpty = dgv_appointments.RowCount == 0;

            dgv_appointments.DataSource = TestAppointment.Charting.GetAllTestAppointments((short) num_year.Value, _selectedMonthNum);

            if (_handleHeader)
                _SetupTableHeaders();

            dgv_appointments.Tag = _selectedMonthNum;
            lbl_noDataAvailable.Visible = dgv_appointments.RowCount == 0;

            if (lbl_noDataAvailable.Visible) {
                if (!_wasEmpty)
                    dgv_appointments.Height--;
            } else if (_isAdditionalLineDrawn)
                dgv_appointments.Height++;

            Invalidate();
        }

        private void dgv_appointments_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (Settings.Default.CurrentLanguage == SupportedLanguages.English) {
                if (e.RowIndex >= 0 || e.ColumnIndex == 0)
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;

                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_appointments.ColumnCount - 1 && !dgv_appointments.IsVScrollVisible())
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            } else {
                if (e.RowIndex >= 0 || e.ColumnIndex == 0)
                    e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;

                if (e.RowIndex >= 0 && e.ColumnIndex == dgv_appointments.ColumnCount - 1 && !dgv_appointments.IsVScrollVisible())
                    e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        private void CtrlChart_TestAppointmentsLoad_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.Dashboard.HasFlag(DVLD_Business.Permissions.DashboardAccess.TestAppointmentsLoad))
                _ReworkEverything();
        }

        private void _SetupTableHeaders() {
            dgv_appointments.Columns["TestTypeImage"].DisplayIndex = 2;

            dgv_appointments.Columns["RowNum"].Width = 35;

            dgv_appointments.Columns[2].HeaderText = Str_CtrlChartTestAppointmentsLoad.testAppointmentID;
            dgv_appointments.Columns[2].Width = 90;

            dgv_appointments.Columns["TestTypeImage"].Width = 75;
            
            dgv_appointments.Columns[3].HeaderText = Str_CtrlChartTestAppointmentsLoad.appointmentDate;
            dgv_appointments.Columns[3].Width = 135;

            dgv_appointments.Columns[4].HeaderText = Str_LayoutShowAllApplications.createdBy;
            dgv_appointments.Columns[4].Width = 90;

            dgv_appointments.Columns[5].HeaderText = Resources.txt_isLocked;

            dgv_appointments.Columns["TestTypeID"].Visible = false;
        }

        private void _ReworkEverything() {
            _ReloadAllData();
            _BindAllData();
        }

        private void _BindAllData() {
            string _xField = Settings.Default.CurrentLanguage == SupportedLanguages.English ? "ShortMonthName" : "MonthNameAR";

            chart1.Series["totalVisionAppointments"].Points.DataBind(_dvTotalAppointmentsPerMonths, _xField, "TotalVisionAppointments", null);
            chart1.Series["totalWrittenAppointments"].Points.DataBind(_dvTotalAppointmentsPerMonths, _xField, "TotalWrittenAppointments", null);
            chart1.Series["totalDrivingAppointments"].Points.DataBind(_dvTotalAppointmentsPerMonths, _xField, "TotalDrivingAppointments", null);

            chart1.ChartAreas[0].AxisX.Title = $"{Str_CtrlChartTotalApplicationsWithTime.months} ({num_year.Value})";

            _BindDgvData();
        }

        private void _ReloadAllData() {
            num_year.Minimum = DVLD_Business.Application.Charting.GetOldestAppYear();
            num_year.Maximum = DVLD_Business.Application.Charting.GetHighestAppYear();

            _dvTotalAppointmentsPerMonths = TestAppointment.Charting.GetTotalTestAppointmentsPerMonths((short) num_year.Value, Settings.Default.CurrentLanguage);
        }

        private void CtrlChart_TestAppointmentsLoad_Paint(object sender, PaintEventArgs e) {
            using (Pen _pen = new Pen(Settings.Default.SurfaceBorderColor)) {
                e.Graphics.DrawLines(_pen, new Point[] {
                    new Point(0, chart1.Height),
                    new Point(0, Height - 1),
                    new Point(Width - 1, Height - 1),
                    new Point(Width - 1, chart1.Height)
                });

                if (dgv_appointments.RowCount == 0) {
                    e.Graphics.DrawLine(_pen, 0, dgv_appointments.Bottom, Width - 1, dgv_appointments.Bottom);
                    _isAdditionalLineDrawn = true;
                } else
                    _isAdditionalLineDrawn = false;
            }

            if (!dgv_appointments.Visible) {
                using (var _brush = new HatchBrush(HatchStyle.ForwardDiagonal, Settings.Default.SurfaceBorderColor, Settings.Default.SurfaceBackColor))
                    e.Graphics.FillRectangle(_brush, dgv_appointments.Bounds);
            }
        }

        private void CtrlChart_TestAppointmentsLoad_Resize(object sender, EventArgs e) => Invalidate();

        public void RefreshDataFiltering() { /*Do nothing*/ }

        public void RefreshChart() => btn_refresh_Click(btn_refresh, EventArgs.Empty);

        private void btn_refresh_Click(object sender, EventArgs e) {
            btn_refresh.Enabled = false;
            btn_refresh.Cursor = Cursors.No;
            _ReworkEverything();
            btn_refresh.Cursor = Cursors.Default;
            btn_refresh.Enabled = true;
        }

        private void _ApplyChartLocalizationSettings() {
            if (Settings.Default.CurrentLanguage == SupportedLanguages.Arabic) {
                helpToolTip.ToolTipTitle = Resources.msg_help;

                chart1.Titles[0].Text = Str_CtrlChartTestAppointmentsLoad.chartTitle;
                chart1.ChartAreas[0].AxisY.Title = Str_CtrlChartTestAppointmentsLoad.appointments;

                chart1.Series[0].LegendText = Str_CtrlChartTestAppointmentsLoad.visionTestAppoints;
                chart1.Series[1].LegendText = Str_CtrlChartTestAppointmentsLoad.writtenTestAppoints;
                chart1.Series[2].LegendText = Str_CtrlChartTestAppointmentsLoad.drivingTestAppoints;

                foreach (var _series in chart1.Series)
                    _series.ToolTip = $"[#LEGENDTEXT]\n#VAL {Str_CtrlChartTestAppointmentsLoad.totalAppointments}";
            }
        }

        private void dgv_appointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex == 0) {
                e.CellStyle.BackColor = e.CellStyle.SelectionBackColor = Settings.Default.GridHeaderCellColor;
                e.CellStyle.SelectionForeColor = e.CellStyle.BackColor.IsLight() ? Color.Black : Color.White;
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            } else if (dgv_appointments.Columns[e.ColumnIndex].Name == "TestTypeImage") {
                (e.Value, dgv_appointments[e.ColumnIndex, e.RowIndex].ToolTipText) = _GetTestTypeDisplayInfo((TestTypes) dgv_appointments["TestTypeID", e.RowIndex].Value);
                e.FormattingApplied = true;
            }
        }

        private (Bitmap icon, string toolTipText) _GetTestTypeDisplayInfo(TestTypes testTypeID) {
            switch (testTypeID) {
                case TestTypes.VisionTest: return (Resources.Vision_16, Str_CtrlChartTestAppointmentsLoad.visionTest);
                case TestTypes.WrittenTest: return (Resources.Written_16, Str_CtrlChartTestAppointmentsLoad.writtenTest);
                case TestTypes.DrivingTest: return (Resources.Street_16, Str_CtrlChartTestAppointmentsLoad.drivingTest);
                default: return (Resources.Question_16, Resources.txt_unknownField);
            }
        }

        private void dgv_appointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Tests_TestAppointsManagement _desiredPermission;

            switch ((byte) dgv_appointments.CurrentRow.Cells["TestTypeID"].Value) {
                case 1:
                    _desiredPermission = Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo;
                    break;
                case 2:
                    _desiredPermission = Tests_TestAppointsManagement.Written_UpdateAppointmentInfo;
                    break;
                case 3:
                    _desiredPermission = Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo;
                    break;
                default:
                    _desiredPermission = Tests_TestAppointsManagement.NoAccess;
                    break;
            }


            if (GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_desiredPermission))
                _DisplayEditSelectedRow();
        }
        
        private void _DisplayEditSelectedRow() {
            using (Frm_ScheduleTest _frmScheduleTest = new Frm_ScheduleTest((int) dgv_appointments.CurrentRow.Cells[2].Value)) {
                if (_frmScheduleTest.IsDisposed)
                    return;

                _frmScheduleTest.ForceExit += _frmScheduleTest_ForceExit;
                _frmScheduleTest.DataSaved += _frmScheduleTest_DataSaved;
                _frmScheduleTest.ShowDialog();
                _frmScheduleTest.DataSaved -= _frmScheduleTest_DataSaved;
                _frmScheduleTest.ForceExit -= _frmScheduleTest_ForceExit;
            }
        }

        private void _frmScheduleTest_DataSaved() => DataSaved?.Invoke();

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (dgv_appointments.SelectedCells.Count == 0) {
                editToolStripMenuItem.Enabled = takeTestToolStripMenuItem.Enabled = false;
                return;
            }

            editToolStripMenuItem.Enabled = true;

            if ((bool) dgv_appointments.CurrentRow.Cells[5].Value) { //IsLocked
                takeTestToolStripMenuItem.Text = Str_FrmTestAppointments.showTestResults;
                takeTestToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled;
            } else {
                takeTestToolStripMenuItem.Text = Str_FrmTestAppointments.takeTest;
                takeTestToolStripMenuItem.Enabled = TakeTestViable;

                if (TakeTestViable)
                    takeTestToolStripMenuItem.Enabled = true;
                else
                    timer1.Start();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayEditSelectedRow();

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_TakeTest _frmTakeTest = new Frm_TakeTest((int) dgv_appointments.CurrentRow.Cells[2].Value)) {
                if (_frmTakeTest.IsDisposed)
                    return;

                _frmTakeTest.ForceExit += _frmScheduleTest_ForceExit;
                _frmTakeTest.DataSaved += _frmScheduleTest_DataSaved;
                _frmTakeTest.ShowDialog();
                _frmTakeTest.DataSaved -= _frmScheduleTest_DataSaved;
                _frmTakeTest.ForceExit -= _frmScheduleTest_ForceExit;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            takeTestToolStripMenuItem.Enabled = TakeTestViable;
            timer1.Enabled = !takeTestToolStripMenuItem.Enabled;
        }

        private void btn_export_Click(object sender, EventArgs e) => BusinessUtils.Exporting.PerformChartExport(chart1, Settings.Default.BaseBackColor);

        private void _frmScheduleTest_ForceExit() => ForceExit?.Invoke();
    }
}
