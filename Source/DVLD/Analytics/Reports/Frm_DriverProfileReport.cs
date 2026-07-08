using DVLD.Analytics.Reports.Complementary_Forms;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.Driver.Reporting;

namespace DVLD.Analytics.Reports {
    public partial class Frm_DriverProfileReport : ReportFormBase, IEnforcePermissions {
        private string _activeUsername;
        private DriverProfileReportSections _selectedSections = DriverProfileReportSections.All;

        public Frm_DriverProfileReport() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonFound(int personID) {
            bool _isDriver = Driver.DoesExistByPersonID(personID);

            btn_export.Enabled = btn_print.Enabled = _isDriver;

            if (!_isDriver)
                MessageBox.Show(Str_FrmReport.selectedPersonNotDriver, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonNotFound() => btn_export.Enabled = btn_print.Enabled = false;

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => OnPersonSaved(personID);

        private void btn_export_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.ExportMigraDocDocument(ConstructDriverProfileReport(new DriverProfileReportInfo(Driver.FindIdByPersonId(ctrl_PersonInfoCardWithFilter1.PersonID), _documentExportSettings, _selectedSections, (DesiredLicenseTypes) cb_desiredLicenseType.SelectedIndex), _activeUsername, Settings.Default.CurrentLanguage), _documentExportSettings.FullPath)) {
                    PresentationUtils.DisplayBubbleNotification_ReportExportSuccess(_documentExportSettings.FullPath);

                    if (_documentExportSettings.OpenAfterSaving)
                        BusinessUtils.FileUtils.StartProcess(_documentExportSettings.FullPath);
                } else
                    MessageBox.Show(Str_FrmReport.exportFileFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SetPrintingButtonsEnabled(true);
            }
        }

        private void _SetPrintingButtonsEnabled(bool value) {
            btn_export.Enabled = btn_print.Enabled = value;
            btn_export.Cursor = btn_print.Cursor = value ? Cursors.Default : Cursors.WaitCursor;
            UseWaitCursor = !value;
        }

        private void btn_print_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                _SetPrintingButtonsEnabled(false);

                var _documentExportSettings = ctrl_DocumentExportSettings1.GetExportSettings();

                if (BusinessUtils.Exporting.PerformMigraDocDocumentPrint(ConstructDriverProfileReport(new DriverProfileReportInfo(Driver.FindIdByPersonId(ctrl_PersonInfoCardWithFilter1.PersonID), _documentExportSettings, _selectedSections, (DesiredLicenseTypes) cb_desiredLicenseType.SelectedIndex), _activeUsername, Settings.Default.CurrentLanguage)))
                    PresentationUtils.DisplayBubbleNotification_ReportExportSuccess(_documentExportSettings.FullPath);
                else
                    MessageBox.Show(Str_FrmReport.printDocumentFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
            
            if (_selectedSections == DriverProfileReportSections.None) {
                MessageBox.Show(Str_FrmReport.chooseOneOptionAtLeast, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void chk_includeDriverInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeDriverInfo.Checked)
                _selectedSections |= DriverProfileReportSections.DriverInfo;
            else
                _selectedSections &= ~DriverProfileReportSections.DriverInfo;
        }

        private void chk_includeActiveLicenses_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeActiveLicenses.Checked)
                _selectedSections |= DriverProfileReportSections.ActiveLicenses;
            else
                _selectedSections &= ~DriverProfileReportSections.ActiveLicenses;
        }

        private void chk_includeInactiveLicenses_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeInactiveLicenses.Checked)
                _selectedSections |= DriverProfileReportSections.InactiveLicenses;
            else
                _selectedSections &= ~DriverProfileReportSections.InactiveLicenses;
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
