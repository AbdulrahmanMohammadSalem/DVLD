using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Tests {
    public partial class Frm_TestAppointments : SalForm, IEnforcePermissions {
        public event Action DataSaved, ForceExit;
        private readonly TestTypes _ActiveTestType;
        private readonly Tests_TestAppointsManagement _ActiveSeeAllAppointsPermission, _ActiveCreateNewAppointPermission, _ActiveUpdateAppointPermission, _ActiveTakeTestPermission, _ActiveSeeTestResultPermission, _ActiveExportDataPermission;

        private bool TakeTestViable => editToolStripMenuItem.Enabled && DateTime.Compare(DateTime.Now, (DateTime) dgv_appointments.CurrentRow.Cells[1].Value) > 0;

        public Frm_TestAppointments(int localDrivingLicenseAppID, TestTypes testType) {
            InitializeComponent();
            _ProcessNoDataAvailableLabel(lbl_noDataAvailable);

            _ActiveTestType = testType;

            switch (_ActiveTestType) {
                case TestTypes.VisionTest:
                    _ActiveSeeAllAppointsPermission = Tests_TestAppointsManagement.Vision_SeeAllAppointments;
                    _ActiveCreateNewAppointPermission = Tests_TestAppointsManagement.Vision_CreateNewAppointment;
                    _ActiveUpdateAppointPermission = Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo;
                    _ActiveTakeTestPermission = Tests_TestAppointsManagement.Vision_TakeTest;
                    _ActiveSeeTestResultPermission = Tests_TestAppointsManagement.Vision_SeeTestResult;
                    _ActiveExportDataPermission = Tests_TestAppointsManagement.Vision_ExportAppointmentsdata;
                    break;
                case TestTypes.WrittenTest:
                    _ActiveSeeAllAppointsPermission = Tests_TestAppointsManagement.Written_SeeAllAppointments;
                    _ActiveCreateNewAppointPermission = Tests_TestAppointsManagement.Written_CreateNewAppointment;
                    _ActiveUpdateAppointPermission = Tests_TestAppointsManagement.Written_UpdateAppointmentInfo;
                    _ActiveTakeTestPermission = Tests_TestAppointsManagement.Written_TakeTest;
                    _ActiveSeeTestResultPermission = Tests_TestAppointsManagement.Written_SeeTestResult;
                    _ActiveExportDataPermission = Tests_TestAppointsManagement.Written_ExportAppointmentsdata;
                    break;
                case TestTypes.DrivingTest:
                    _ActiveSeeAllAppointsPermission = Tests_TestAppointsManagement.Driving_SeeAllAppointments;
                    _ActiveCreateNewAppointPermission = Tests_TestAppointsManagement.Driving_CreateNewAppointment;
                    _ActiveUpdateAppointPermission = Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo;
                    _ActiveTakeTestPermission = Tests_TestAppointsManagement.Driving_TakeTest;
                    _ActiveSeeTestResultPermission = Tests_TestAppointsManagement.Driving_SeeTestResult;
                    _ActiveExportDataPermission = Tests_TestAppointsManagement.Driving_ExportAppointmentsdata;
                    break;
                default:
                    _ActiveSeeAllAppointsPermission = _ActiveCreateNewAppointPermission = _ActiveUpdateAppointPermission = _ActiveTakeTestPermission = _ActiveSeeTestResultPermission = _ActiveExportDataPermission = Tests_TestAppointsManagement.NoAccess;
                    break;
            }

            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
            
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_appointments);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID = localDrivingLicenseAppID;

            if (ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID == -1) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_appointments); 

        private void Frm_TestAppointments_Load(object sender, EventArgs e) {
            _SetDefaultValues();

            if (GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveSeeAllAppointsPermission)) {
                _ReloadAllData();
                _HandleTableHeader();
            }
        }

        private void _HandleTableHeader() {
            dgv_appointments.Columns[0].HeaderText = Str_FrmTestAppointments.appointmentID;
            dgv_appointments.Columns[1].HeaderText = Str_FrmTestAppointments.appointmentDate;
            dgv_appointments.Columns[2].HeaderText = Str_FrmTestAppointments.totalPaidFees;
            dgv_appointments.Columns[3].HeaderText = Str_FrmTestAppointments.isLocked;
        }

        private void _ReloadAllData() {
            dgv_appointments.DataSource = TestAppointment.GetPreferredAppointmentsView(ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID, _ActiveTestType);
            label_numOfRecords.Text = dgv_appointments.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_appointments.RowCount == 0;
        }

        private void _SetDefaultValues() {
            switch (_ActiveTestType) {
                case TestTypes.VisionTest:
                    Text = lbl_title.Text = Str_FrmTestAppointments.visionTestAppointments;
                    pictureBox1.Image = Resources.Vision_512;
                    break;
                case TestTypes.WrittenTest:
                    Text = lbl_title.Text = Str_FrmTestAppointments.writtenTestAppointments;
                    pictureBox1.Image = Resources.Written_Test_512;
                    break;
                case TestTypes.DrivingTest:
                    Text = lbl_title.Text = Str_FrmTestAppointments.streetTestAppointments;
                    pictureBox1.Image = Resources.driving_test_512;
                    break;
            }
        }

        private void ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved(int _) => DataSaved?.Invoke();

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllData();

        private void button_addNewAppointment_Click(object sender, EventArgs e) {
            int _lDLAppID = ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID;

            if (TestAppointment.DoesActiveAppointmentExist(_lDLAppID, _ActiveTestType)) {
                MessageBox.Show(Str_FrmTestAppointments.anOpenAppointmentAlreadyExists, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Test.CheckForPassedTest(_lDLAppID, _ActiveTestType)) {
                MessageBox.Show(Str_FrmTestAppointments.applicantAlreadyPassedTest, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Frm_ScheduleTest _frmScheduleTest = new Frm_ScheduleTest(_lDLAppID, _ActiveTestType)) {
                if (_frmScheduleTest.IsDisposed)
                    return;

                _frmScheduleTest.ForceExit += _InvokeForceExit;
                _frmScheduleTest.DataSaved += _ReloadAllData;
                _frmScheduleTest.ShowDialog();
                _frmScheduleTest.DataSaved -= _ReloadAllData;
                _frmScheduleTest.ForceExit -= _InvokeForceExit;
            }
        }

        private void _PerformDataSaved() {
            ctrl_LocalDrivingLicenseAppInfoCard1.ReloadCard();
            _ReloadAllData();
            DataSaved?.Invoke();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayEditSelectedRow();

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_TakeTest _frmTakeTest = new Frm_TakeTest((int) dgv_appointments.CurrentRow.Cells[0].Value)) {
                if (_frmTakeTest.IsDisposed)
                    return;

                _frmTakeTest.ForceExit += _InvokeForceExit;
                _frmTakeTest.DataSaved += _PerformDataSaved;
                _frmTakeTest.ShowDialog();
                _frmTakeTest.DataSaved -= _PerformDataSaved;
                _frmTakeTest.ForceExit -= _InvokeForceExit;
            }
        }

        private void _InvokeForceExit() => ForceExit?.Invoke();

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (dgv_appointments.SelectedCells.Count == 0) {
                editToolStripMenuItem.Enabled = takeTest_showTestResultToolStripMenuItem.Enabled = false;
                return;
            }

            editToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveUpdateAppointPermission);

            if ((byte) dgv_appointments.CurrentRow.Cells[3].Value == 0) { //Open
                takeTest_showTestResultToolStripMenuItem.Text = Str_FrmTestAppointments.takeTest;
                takeTest_showTestResultToolStripMenuItem.Enabled = TakeTestViable;

                if (TakeTestViable)
                    takeTest_showTestResultToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveTakeTestPermission);
                else
                    timer1.Start();
            } else {
                takeTest_showTestResultToolStripMenuItem.Text = Str_FrmTestAppointments.showTestResults;
                takeTest_showTestResultToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveSeeTestResultPermission);
            }
        }

        private void dgv_appointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_appointments.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (dgv_appointments.Columns[e.ColumnIndex].Name == "IsLocked") {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold | FontStyle.Italic);

                if ((byte) e.Value == 0) { //Open
                    e.CellStyle.ForeColor = Color.ForestGreen;
                    e.Value = Str_FrmTestAppointments.open;
                } else { //Closed
                    e.CellStyle.ForeColor = Color.Red;
                    e.Value = Str_FrmTestAppointments.closed;
                }

                e.FormattingApplied = true;
            }
        }

        private void _DisplayEditSelectedRow() {
            using (Frm_ScheduleTest _frmScheduleTest = new Frm_ScheduleTest((int) dgv_appointments.CurrentRow.Cells[0].Value)) {
                if (_frmScheduleTest.IsDisposed)
                    return;

                //No need to use _PerformDataSaved
                _frmScheduleTest.ForceExit += _InvokeForceExit;
                _frmScheduleTest.DataSaved += _ReloadAllData;
                _frmScheduleTest.ShowDialog();
                _frmScheduleTest.DataSaved -= _ReloadAllData;
                _frmScheduleTest.ForceExit -= _InvokeForceExit;
            }
        }

        private void Frm_TestAppointments_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_FrmTestAppointments.testAppointments, dgv_appointments.DataSource as DataView ?? TestAppointment.GetPreferredAppointmentsView(ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID, _ActiveTestType));

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e) => timer1.Stop();

        private void timer1_Tick(object sender, EventArgs e) {
            takeTest_showTestResultToolStripMenuItem.Enabled = TakeTestViable;
            timer1.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveTakeTestPermission) && !takeTest_showTestResultToolStripMenuItem.Enabled;
        }

        private void dgv_appointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveUpdateAppointPermission))
                _DisplayEditSelectedRow();
        }

        private void _ProcessNoDataAvailableLabel(Label lbl) {
            lbl.AutoSize = false;
            lbl.Width = dgv_appointments.Width - 20;
            lbl.Location = new Point(dgv_appointments.Location.X + 10, lbl.Location.Y);
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_appointments.Enabled = dgv_appointments.Enabled = linkLabel_refreshData.Enabled = permissions.Tests_TestAppoints.HasFlag(_ActiveSeeAllAppointsPermission);
            btn_addNewAppointment.Enabled = permissions.Tests_TestAppoints.HasFlag(_ActiveCreateNewAppointPermission);
            ll_exportData.Enabled = permissions.Tests_TestAppoints.HasFlag(_ActiveExportDataPermission);
            editToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_ActiveUpdateAppointPermission);
            
            
            lbl_noDataAvailable.Text = permissions.Tests_TestAppoints.HasFlag(_ActiveSeeAllAppointsPermission) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
