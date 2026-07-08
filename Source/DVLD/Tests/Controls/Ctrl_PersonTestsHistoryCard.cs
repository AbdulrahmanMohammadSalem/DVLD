using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD.String_Resources.Layouts;
using DVLD.String_Resources.User_Controls;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Tests.Controls {
    public partial class Ctrl_PersonTestsHistoryCard : UserControl, IEnforcePermissions {
        public event Action DataSaved, ForceExit;
        private byte _lastEditedDgvTag = 0;
        private int _personID = -1;

        [DefaultValue(-1)]
        public int PersonID {
            get => _personID;
            set {
                if (value == -1 || !Person.DoesExist(value)) {
                    _personID = -1;

                    dgv_visionHistory.DataSource = dgv_writtenHistory.DataSource = dgv_drivingHistory.DataSource = null;
                    lbl_visionNumOfRecords.Text = lbl_writtenNumOfRecords.Text = lbl_drivingNumOfRecords.Text = Resources.txt_unknownField;
                    lbl_visionNoDataAvailable.Visible = lbl_writtenNoDataAvailable.Visible = lbl_drivingNoDataAvailable.Visible = true;
                    ll_visionRefreshData.Enabled = ll_writtenRefreshData.Enabled = ll_drivingRefreshData.Enabled = ll_visionExportData.Enabled = ll_writtenExportData.Enabled = ll_drivingExportData.Enabled = false;
                } else {
                    _personID = value;

                    if (GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments))
                        _ReloadVisionData();

                    if (GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments))
                        _ReloadWrittenData();

                    if (GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments))
                        _ReloadDrivingData();
                }
            }
        }

        public Ctrl_PersonTestsHistoryCard() {
            InitializeComponent();
            ll_visionExportData.Enabled = ll_writtenExportData.Enabled = ll_drivingExportData.Enabled = false;

            _ProcessNoDataAvailableLabel(lbl_visionNoDataAvailable);
            _ProcessNoDataAvailableLabel(lbl_writtenNoDataAvailable);
            _ProcessNoDataAvailableLabel(lbl_drivingNoDataAvailable);

            if (GlobalFields.ActiveUserPermissions != null)
                EnforcePermissions(GlobalFields.ActiveUserPermissions);

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;

            if (Settings.Default.CurrentLanguage == SupportedLanguages.Arabic) {
                ll_visionExportData.Location = ll_writtenExportData.Location = ll_drivingExportData.Location = new Point(ll_visionRefreshData.Location.X + ll_visionRefreshData.Width + 6, ll_visionRefreshData.Location.Y);
                ll_visionExportData.Anchor = ll_writtenExportData.Anchor = ll_drivingExportData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }

            Settings.Default.ApplyTabControlStyleSettings(tabControl1); 
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_visionHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_writtenHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_drivingHistory);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            if (tabControl1.RightToLeft == RightToLeft.Yes) {
                tabControl1.TabLocation = Manina.Windows.Forms.TabLocation.TopRight;
                tabControl1.ReverseTabsOrder();
                tabControl1.SelectedTab = tp_drivingTests;
                tabControl1.SelectedTab = tp_visionTests;
            }

            dgv_visionHistory.Tag = (byte) 0;
            dgv_writtenHistory.Tag = (byte) 1;
            dgv_drivingHistory.Tag = (byte) 2;
        }

        private void _SetupTableHeader(DataGridView dgv) {
            dgv.Columns[0].HeaderText = Resources.txt_localDrivingLicenseAppID;
            dgv.Columns[1].HeaderText = Str_FrmTestAppointments.appointmentID;
            dgv.Columns[2].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.licenseClass;
            dgv.Columns[3].HeaderText = Str_FrmTestAppointments.appointmentDate;
            dgv.Columns[4].HeaderText = Str_FrmTestAppointments.totalPaidFees;
            dgv.Columns[5].HeaderText = Resources.txt_isLocked;
        }

        private void _ReloadDrivingData() {
            dgv_drivingHistory.DataSource = TestAppointment.GetPreferredTestHistoryView(_personID, TestTypes.DrivingTest, Settings.Default.CurrentLanguage);
            _SetupTableHeader(dgv_drivingHistory);
            lbl_drivingNumOfRecords.Text = dgv_drivingHistory.RowCount.ToString();
            lbl_drivingNoDataAvailable.Visible = dgv_drivingHistory.RowCount == 0;
            ll_drivingRefreshData.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments);
            ll_drivingExportData.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_ExportAppointmentsdata);
        }

        private void _ReloadWrittenData() {
            dgv_writtenHistory.DataSource = TestAppointment.GetPreferredTestHistoryView(_personID, TestTypes.WrittenTest, Settings.Default.CurrentLanguage);
            _SetupTableHeader(dgv_writtenHistory);
            lbl_writtenNumOfRecords.Text = dgv_writtenHistory.RowCount.ToString();
            lbl_writtenNoDataAvailable.Visible = dgv_writtenHistory.RowCount == 0;
            ll_writtenRefreshData.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments);
            ll_writtenExportData.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_ExportAppointmentsdata);
        }

        private void _ReloadVisionData() {
            dgv_visionHistory.DataSource = TestAppointment.GetPreferredTestHistoryView(_personID, TestTypes.VisionTest, Settings.Default.CurrentLanguage);
            _SetupTableHeader(dgv_visionHistory);
            lbl_visionNumOfRecords.Text = dgv_visionHistory.RowCount.ToString();
            lbl_visionNoDataAvailable.Visible = dgv_visionHistory.RowCount == 0;
            ll_visionRefreshData.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments);
            ll_visionExportData.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_ExportAppointmentsdata);
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_visionHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_writtenHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_drivingHistory);
        }

        private void ll_visionRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadVisionData();

        private void ll_writtenRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadWrittenData();

        private void ll_drivingRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadDrivingData();

        private void dgv_visionHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo))
                _DisplayEditSelectedRow(dgv_visionHistory);
        }

        private void dgv_writtenHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_UpdateAppointmentInfo))
                _DisplayEditSelectedRow(dgv_writtenHistory);
        }

        private void dgv_drivingHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo))
                _DisplayEditSelectedRow(dgv_drivingHistory);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            DataGridView _dgv_source = (DataGridView) contextMenuStrip1.SourceControl;
            Tests_TestAppointsManagement _updateAppointPermission, _seeTestResultPermission, _takeTestPermission;

            if (_dgv_source.RowCount == 0) {
                editToolStripMenuItem.Enabled = takeTest_seeTestResultToolStripMenuItem.Enabled = false;
                return;
            }

            switch ((byte) _dgv_source.Tag) {
                case 0: //Vision
                    _updateAppointPermission = Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo;
                    _seeTestResultPermission = Tests_TestAppointsManagement.Vision_SeeTestResult;
                    _takeTestPermission = Tests_TestAppointsManagement.Vision_TakeTest;
                    break;
                case 1: //Written
                    _updateAppointPermission = Tests_TestAppointsManagement.Written_UpdateAppointmentInfo;
                    _seeTestResultPermission = Tests_TestAppointsManagement.Written_SeeTestResult;
                    _takeTestPermission = Tests_TestAppointsManagement.Written_TakeTest;
                    break;
                case 2: //Driving
                    _updateAppointPermission = Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo;
                    _seeTestResultPermission = Tests_TestAppointsManagement.Driving_SeeTestResult;
                    _takeTestPermission = Tests_TestAppointsManagement.Driving_TakeTest;
                    break;
                default:
                    _updateAppointPermission = _seeTestResultPermission = _takeTestPermission = Tests_TestAppointsManagement.NoAccess;
                    break;
            }

            editToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_updateAppointPermission) && _dgv_source.SelectedCells.Count > 0;

            if ((bool) _dgv_source.CurrentRow.Cells[5].Value) { //Locked
                takeTest_seeTestResultToolStripMenuItem.Text = Str_FrmTestAppointments.showTestResults;
                takeTest_seeTestResultToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_seeTestResultPermission) && _dgv_source.SelectedCells.Count > 0;
            } else {
                takeTest_seeTestResultToolStripMenuItem.Text = Str_FrmTestAppointments.takeTest;
                takeTest_seeTestResultToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Tests_TestAppoints.HasFlag(_takeTestPermission) && _dgv_source.SelectedCells.Count > 0 && DateTime.Compare(DateTime.Now, (DateTime) _dgv_source.CurrentRow.Cells[3].Value) > 0;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayEditSelectedRow((DataGridView) contextMenuStrip1.SourceControl);
        
        private void _DisplayEditSelectedRow(DataGridView dgv_source) {
            using (Frm_ScheduleTest _frmScheduleTest = new Frm_ScheduleTest((int) dgv_source.CurrentRow.Cells[1].Value)) {
                if (_frmScheduleTest.IsDisposed)
                    return;

                _lastEditedDgvTag = (byte) dgv_source.Tag;

                _frmScheduleTest.DataSaved += _ReloadConcernedData;
                _frmScheduleTest.ShowDialog();
                _frmScheduleTest.DataSaved -= _ReloadConcernedData;
            }
        }

        private void _ReloadConcernedData() {
            switch (_lastEditedDgvTag) {
                case 0: //Vision
                    _ReloadVisionData();
                    return;
                case 1: //Written
                    _ReloadWrittenData();
                    return;
                case 2: //Driving
                    _ReloadDrivingData();
                    return;
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e) {
            DataGridView _dgv_source = (DataGridView) contextMenuStrip1.SourceControl;

            using (Frm_TakeTest _frmTakeTest = new Frm_TakeTest((int) _dgv_source.CurrentRow.Cells[1].Value)) {
                if (_frmTakeTest.IsDisposed)
                    return;

                _lastEditedDgvTag = (byte) _dgv_source.Tag;

                _frmTakeTest.ForceExit += _frmTakeTest_ForceExit;
                _frmTakeTest.DataSaved += _PerformDataSaved;
                _frmTakeTest.ShowDialog();
                _frmTakeTest.DataSaved -= _PerformDataSaved;
                _frmTakeTest.ForceExit -= _frmTakeTest_ForceExit;
            }
        }

        private void _frmTakeTest_ForceExit() => ForceExit?.Invoke();

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (((DataGridView) sender).Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            }
        }

        private void ll_visionExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_CtrlPersonTestsHistoryCard.visionTestsHistory, dgv_visionHistory.DataSource as DataView ?? TestAppointment.GetPreferredTestHistoryView(_personID, TestTypes.VisionTest, Settings.Default.CurrentLanguage));

        private void ll_writtenExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_CtrlPersonTestsHistoryCard.writtenTestsHistory, dgv_writtenHistory.DataSource as DataView ?? TestAppointment.GetPreferredTestHistoryView(_personID, TestTypes.WrittenTest, Settings.Default.CurrentLanguage));

        private void ll_drivingExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_CtrlPersonTestsHistoryCard.drivingTestsHistory, dgv_drivingHistory.DataSource as DataView ?? TestAppointment.GetPreferredTestHistoryView(_personID, TestTypes.DrivingTest, Settings.Default.CurrentLanguage));

        private void _PerformDataSaved() {
            _ReloadConcernedData();
            DataSaved?.Invoke();
        }

        private void _ProcessNoDataAvailableLabel(Label lbl) {
            lbl.AutoSize = false;
            lbl.Width = dgv_visionHistory.Width - 20;
            lbl.Location = new Point(dgv_visionHistory.Location.X + 10, lbl.Location.Y);
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_visionTestAppoints.Enabled = dgv_visionHistory.Enabled = permissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments);
            lbl_visionNoDataAvailable.Text = permissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;

            lbl_writtenTestAppoints.Enabled = dgv_writtenHistory.Enabled = permissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments);
            lbl_writtenNoDataAvailable.Text = permissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
            
            lbl_drivingTestAppoints.Enabled = dgv_drivingHistory.Enabled = permissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments);
            lbl_drivingNoDataAvailable.Text = permissions.Tests_TestAppoints.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
