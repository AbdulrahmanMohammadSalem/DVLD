using DVLD.Analytics.Reports.Complementary_Forms;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.LocalDrivingLicenseApp.Reporting;

namespace DVLD.Analytics.Reports {
    public partial class Frm_LocalLicenseAppDetailsReport : ReportFormBase {
        private LocalLicenseAppDetailsReportSections _selectedSections = LocalLicenseAppDetailsReportSections.All;
        private string _activeUsername;

        public Frm_LocalLicenseAppDetailsReport() => InitializeComponent();

        private void ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved(int personID) => OnPersonSaved(personID);

        private void ll_selectApp_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            using (Frm_SelectLocalLicenseApplication _frmSelectApp = new Frm_SelectLocalLicenseApplication()) {
                _frmSelectApp.PersonSaved += _frmSelectApp_PersonSaved;

                if (_frmSelectApp.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID = _frmSelectApp.SelectedLocalLicenseAppID;
                    btn_export.Enabled = btn_print.Enabled = true;
                    btn_export.Focus();
                }

                _frmSelectApp.PersonSaved -= _frmSelectApp_PersonSaved;
            }
        }

        private void _frmSelectApp_PersonSaved(int personID) {
            ctrl_LocalDrivingLicenseAppInfoCard1.ReloadCard();
            OnPersonSaved(personID);
        }

        private void _SetPrintingButtonsEnabled(bool value) {
            btn_export.Enabled = btn_print.Enabled = value;
            btn_export.Cursor = btn_print.Cursor = value ? Cursors.Default : Cursors.WaitCursor;
            UseWaitCursor = !value;
        }

        private void btn_export_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.ExportMigraDocDocument(ConstructApplicationDetailsReport(new LocalLicenseAppDetailsReportInfo(_documentExportSettings, ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID, _selectedSections), _activeUsername, Settings.Default.CurrentLanguage), _documentExportSettings.FullPath)) {
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

                if (BusinessUtils.Exporting.PerformMigraDocDocumentPrint(ConstructApplicationDetailsReport(new LocalLicenseAppDetailsReportInfo(_documentExportSettings, ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID, _selectedSections), _activeUsername, Settings.Default.CurrentLanguage)))
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
            
            if (_selectedSections == LocalLicenseAppDetailsReportSections.None) {
                MessageBox.Show(Str_FrmReport.chooseOneOptionAtLeast, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void chk_includeAppInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeAppInfo.Checked)
                _selectedSections |= LocalLicenseAppDetailsReportSections.ApplicationInfo;
            else
                _selectedSections &= ~LocalLicenseAppDetailsReportSections.ApplicationInfo;
        }

        private void chk_includeApplicantInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeApplicantInfo.Checked)
                _selectedSections |= LocalLicenseAppDetailsReportSections.ApplicantInfo;
            else
                _selectedSections &= ~LocalLicenseAppDetailsReportSections.ApplicantInfo;
        }

        private void chk_includeTestInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeTestInfo.Checked)
                _selectedSections |= LocalLicenseAppDetailsReportSections.TestInfo;
            else
                _selectedSections &= ~LocalLicenseAppDetailsReportSections.TestInfo;
        }

        private void chk_includeFeesSammary_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeFeesSammary.Checked)
                _selectedSections |= LocalLicenseAppDetailsReportSections.FeesSammary;
            else
                _selectedSections &= ~LocalLicenseAppDetailsReportSections.FeesSammary;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
