using DVLD.Analytics.Reports.Complementary_Forms;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.TestAppointment.Reporting;

namespace DVLD.Analytics.Reports {
    public partial class Frm_TestAttemptsReport : ReportFormBase, IEnforcePermissions {
        private TestAttemptsReportSections _selectedSections = TestAttemptsReportSections.All;
        private string _activeUsername;

        public Frm_TestAttemptsReport() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonFound(int personID) {
            btn_export.Enabled = btn_print.Enabled = true;
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonNotFound() => btn_export.Enabled = btn_print.Enabled = false;

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => OnPersonSaved(personID);

        private void chk_includePersonalInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includePersonalInfo.Checked)
                _selectedSections |= TestAttemptsReportSections.PersonalInfo;
            else
                _selectedSections &= ~TestAttemptsReportSections.PersonalInfo;
        }

        private void chk_includeVisionTestAttempts_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeVisionTestAttempts.Checked)
                _selectedSections |= TestAttemptsReportSections.VisionTestAttempts;
            else
                _selectedSections &= ~TestAttemptsReportSections.VisionTestAttempts;
        }

        private void chk_includeWrittenTestAttempts_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeWrittenTestAttempts.Checked)
                _selectedSections |= TestAttemptsReportSections.WrittenTestAttempts;
            else
                _selectedSections &= ~TestAttemptsReportSections.WrittenTestAttempts;
        }

        private void chk_includeDrivingTestAttempts_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeDrivingTestAttempts.Checked)
                _selectedSections |= TestAttemptsReportSections.DrivingTestAttempts;
            else
                _selectedSections &= ~TestAttemptsReportSections.DrivingTestAttempts;
        }

        private void rb_customRange_CheckedChanged(object sender, EventArgs e) => gb_dateRange.Enabled = rb_customRange.Checked;

        private void _SetPrintingButtonsEnabled(bool value) {
            btn_export.Enabled = btn_print.Enabled = value;
            btn_export.Cursor = btn_print.Cursor = value ? Cursors.Default : Cursors.WaitCursor;
            UseWaitCursor = !value;
        }

        private void btn_export_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.ExportMigraDocDocument(ConstructTestAttemptsReport(new TestAttemptsReportInfo(ctrl_PersonInfoCardWithFilter1.PersonID, _documentExportSettings, _selectedSections, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage), _documentExportSettings.FullPath)) {
                    PresentationUtils.DisplayBubbleNotification_ReportExportSuccess(_documentExportSettings.FullPath);

                    if (_documentExportSettings.OpenAfterSaving)
                        BusinessUtils.FileUtils.StartProcess(_documentExportSettings.FullPath);
                } else
                    MessageBox.Show(Str_FrmReport.exportFileFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetPrintingButtonsEnabled(true);
            }
        }

        private void btn_print_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.PerformMigraDocDocumentPrint(ConstructTestAttemptsReport(new TestAttemptsReportInfo(ctrl_PersonInfoCardWithFilter1.PersonID, _documentExportSettings, _selectedSections, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage)))
                    PresentationUtils.DisplayBubbleNotification_ReportExportSuccess(_documentExportSettings.FullPath);
                else
                    MessageBox.Show(Str_FrmReport.exportFileFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetPrintingButtonsEnabled(true);
            }
        }

        public override bool ValidateChildren() {
            var _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnForceExit();
                return false;
            }

            _activeUsername = _activeUser.Username;

            if (!ctrl_DocumentExportSettings1.ValidateFields()) {
                MessageBox.Show(Str_FrmReport.invalidExportSettings, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            if (_selectedSections == TestAttemptsReportSections.None) {
                MessageBox.Show(Str_FrmReport.chooseOneOptionAtLeast, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (rb_customRange.Checked && dt_endDate.Value < dt_startDate.Value) {
                MessageBox.Show(Str_FrmReport.invalidDateRange, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter && ctrl_PersonInfoCardWithFilter1.Focused) {
                ctrl_PersonInfoCardWithFilter1.PerformSearch();

                if (ctrl_PersonInfoCardWithFilter1.SelectedPerson != null)
                    btn_export.Focus();

                return true;
            }

            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_PersonInfoCardWithFilter1.Enabled = permissions.People.HasFlag(DVLD_Business.Permissions.PeopleManagement.SeePersonalInfoCards);
    }
}
