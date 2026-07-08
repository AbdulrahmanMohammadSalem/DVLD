using DVLD.Analytics.Reports.Complementary_Forms;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.User.Reporting;

namespace DVLD.Analytics.Reports {
    public partial class Frm_UserActivityReport : ReportFormBase, IEnforcePermissions {
        private UserActivityReportSections _selectedSections = UserActivityReportSections.All;
        private string _activeUsername;

        public Frm_UserActivityReport() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => OnPersonSaved(personID);

        private void ctrl_PersonInfoCardWithFilter1_PersonFound(int personID) {
            bool _isUser = User.DoesExistByPersonID(personID);
            
            btn_export.Enabled = btn_print.Enabled = _isUser;

            if (!_isUser)
                MessageBox.Show(Str_FrmReport.selectedPersonNotUser, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonNotFound() => btn_export.Enabled = btn_print.Enabled = false;

        private void chk_includeUserInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeUserInfo.Checked)
                _selectedSections |= UserActivityReportSections.UserInfo;
            else
                _selectedSections &= ~UserActivityReportSections.UserInfo;
        }

        private void chk_includeBasicActionCounts_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeBasicActionCounts.Checked)
                _selectedSections |= UserActivityReportSections.BasicActionCounts;
            else
                _selectedSections &= ~UserActivityReportSections.BasicActionCounts;
        }

        private void chk_includDetailedActionCounts_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeDetailedActionCounts.Checked)
                _selectedSections |= UserActivityReportSections.DetailedActionCounts;
            else
                _selectedSections &= ~UserActivityReportSections.DetailedActionCounts;
        }

        private void chk_includeCategorizedActivities_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeCategorizedActivities.Checked)
                _selectedSections |= UserActivityReportSections.CategorizedActivities;
            else
                _selectedSections &= ~UserActivityReportSections.CategorizedActivities;
        }

        private void chk_includeActivityTimeline_CheckedChanged(object sender, EventArgs e) {
            if (chk_includeActivityTimeline.Checked)
                _selectedSections |= UserActivityReportSections.ActivityTimeline;
            else
                _selectedSections &= ~UserActivityReportSections.ActivityTimeline;

            cb_timelineOrder.Enabled = chk_includeActivityTimeline.Checked;
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

                if (BusinessUtils.Exporting.ExportMigraDocDocument(ConstructUserActivityReport(new UserActivityReportInfo(User.FindIdByPersonId(ctrl_PersonInfoCardWithFilter1.PersonID), _documentExportSettings, _selectedSections, (OrderModes) cb_timelineOrder.SelectedIndex, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage), _documentExportSettings.FullPath)) {
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

                if (BusinessUtils.Exporting.PerformMigraDocDocumentPrint(ConstructUserActivityReport(new UserActivityReportInfo(User.FindIdByPersonId(ctrl_PersonInfoCardWithFilter1.PersonID), _documentExportSettings, _selectedSections, (OrderModes) cb_timelineOrder.SelectedIndex, rb_customRange.Checked ? (dt_startDate.Value, dt_endDate.Value) : ((DateTime, DateTime)?) null), _activeUsername, Settings.Default.CurrentLanguage)))
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
            
            if (_selectedSections == UserActivityReportSections.None) {
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
