using DVLD.Analytics.Reports.Complementary_Forms;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.Person.Reporting;

namespace DVLD.Analytics.Reports {
    public partial class Frm_PersonHistoryReport : ReportFormBase, IEnforcePermissions {
        private PersonHistoryReportSections _selectedSections = PersonHistoryReportSections.All;
        private string _activeUsername;

        public Frm_PersonHistoryReport() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void rb_customRange_CheckedChanged(object sender, EventArgs e) => gb_dateRange.Enabled = rb_customRange.Checked;

        private void ctrl_PersonInfoCardWithFilter1_PersonFound(int personID) => btn_export.Enabled = btn_print.Enabled = true;

        private void ctrl_PersonInfoCardWithFilter1_PersonNotFound() => btn_export.Enabled = btn_print.Enabled = false;

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => OnPersonSaved(personID);

        private void _SetPrintingButtonsEnabled(bool value) {
            btn_export.Enabled = btn_print.Enabled = value;
            btn_export.Cursor = btn_print.Cursor = value ? Cursors.Default : Cursors.WaitCursor;
            UseWaitCursor = !value;
        }

        private void btn_export_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.ExportMigraDocDocument(ConstructPersonHistoryReport(new PersonHistoryReportInfo(ctrl_PersonInfoCardWithFilter1.PersonID, _documentExportSettings, _selectedSections, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage), _documentExportSettings.FullPath)) {
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

                if (BusinessUtils.Exporting.PerformMigraDocDocumentPrint(ConstructPersonHistoryReport(new PersonHistoryReportInfo(ctrl_PersonInfoCardWithFilter1.PersonID, _documentExportSettings, _selectedSections, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage)))
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
            
            if (_selectedSections == PersonHistoryReportSections.None) {
                MessageBox.Show(Str_FrmReport.chooseOneOptionAtLeast, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (rb_customRange.Checked && dt_endDate.Value < dt_startDate.Value) {
                MessageBox.Show(Str_FrmReport.invalidDateRange, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void chk_includePersonalInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includePersonalInfo.Checked)
                _selectedSections |= PersonHistoryReportSections.PersonalInfo;
            else
                _selectedSections &= ~PersonHistoryReportSections.PersonalInfo;
        }

        private void chk_includeApps_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeApps.Checked)
                _selectedSections |= PersonHistoryReportSections.Applications;
            else
                _selectedSections &= ~PersonHistoryReportSections.Applications;
        }

        private void chk_includeLocalLicenses_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeLocalLicenses.Checked)
                _selectedSections |= PersonHistoryReportSections.LocalLicenses;
            else
                _selectedSections &= ~PersonHistoryReportSections.LocalLicenses;
        }

        private void chk_includeInterLicenses_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeInterLicenses.Checked)
                _selectedSections |= PersonHistoryReportSections.InternationalLicenses;
            else
                _selectedSections &= ~PersonHistoryReportSections.InternationalLicenses;
        }

        private void chk_includeTests_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeTests.Checked)
                _selectedSections |= PersonHistoryReportSections.Tests;
            else
                _selectedSections &= ~PersonHistoryReportSections.Tests;
        }

        private void chk_includeDetentions_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeDetentions.Checked)
                _selectedSections |= PersonHistoryReportSections.Detentions;
            else
                _selectedSections &= ~PersonHistoryReportSections.Detentions;
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
