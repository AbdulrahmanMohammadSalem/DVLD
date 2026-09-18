using DVLD.Analytics.Reports.Complementary_Forms;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.People.Controls;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.LicenseDetention.Reporting;

namespace DVLD.Analytics.Reports {
    public partial class Frm_LicenseDetentionReport : ReportFormBase, IEnforcePermissions {
        private LicenseDetentionReportSections _selectedSections = LicenseDetentionReportSections.All;
        private string _activeUsername;

        public Frm_LicenseDetentionReport() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void chk_includeDriverInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeDriverInfo.Checked)
                _selectedSections |= LicenseDetentionReportSections.DriverInfo;
            else
                _selectedSections &= ~LicenseDetentionReportSections.DriverInfo;
        }

        private void chk_includeLicenseInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeLicenseInfo.Checked)
                _selectedSections |= LicenseDetentionReportSections.LicenseInfo;
            else
                _selectedSections &= ~LicenseDetentionReportSections.LicenseInfo;
        }

        private void chk_includeDetentionHistory_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeDetentionHistory.Checked)
                _selectedSections |= LicenseDetentionReportSections.DetentionHistory;
            else
                _selectedSections &= ~LicenseDetentionReportSections.DetentionHistory;
        }

        private void rb_customRange_CheckedChanged(object sender, EventArgs e) => gb_dateRange.Enabled = rb_customRange.Checked;

        private void btn_export_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.ExportMigraDocDocument(ConstructLicenseDetentionReport(new LicenseDetentionReportInfo(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID, _documentExportSettings, _selectedSections, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage), _documentExportSettings.FullPath)) {
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

                if (BusinessUtils.Exporting.PerformMigraDocDocumentPrint(ConstructLicenseDetentionReport(new LicenseDetentionReportInfo(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID, _documentExportSettings, _selectedSections, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage)))
                    PresentationUtils.DisplayBubbleNotification_ReportExportSuccess(_documentExportSettings.FullPath);
                else
                    MessageBox.Show(Str_FrmReport.exportFileFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetPrintingButtonsEnabled(true);
            }
        }

        private void _SetPrintingButtonsEnabled(bool value) {
            btn_export.Enabled = btn_print.Enabled = value;
            btn_export.Cursor = btn_print.Cursor = value ? Cursors.Default : Cursors.WaitCursor;
            UseWaitCursor = !value;
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
            
            if (_selectedSections == LicenseDetentionReportSections.None) {
                MessageBox.Show(Str_FrmReport.chooseOneOptionAtLeast, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (rb_customRange.Checked && dt_endDate.Value < dt_startDate.Value) {
                MessageBox.Show(Str_FrmReport.invalidDateRange, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(bool licenseActive) => btn_export.Enabled = btn_print.Enabled = true;

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound() {
            btn_export.Enabled = btn_print.Enabled = false;
            MessageBox.Show(Str_FrmIssueNewInternationalLicense.localLicenseNotFound, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved(int personID) => OnPersonSaved(personID);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter && ctrl_LocalLicenseInfoCardWithFilter1.Focused) {
                ctrl_LocalLicenseInfoCardWithFilter1.PerformSearch();

                if (ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense != null)
                    btn_export.Focus();

                return true;
            }

            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_LocalLicenseInfoCardWithFilter1.Enabled = permissions.Licenses.HasFlag(DVLD_Business.Permissions.LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
