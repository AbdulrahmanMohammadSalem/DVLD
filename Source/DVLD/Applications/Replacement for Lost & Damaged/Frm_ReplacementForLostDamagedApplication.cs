using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Media;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications.Replacement_for_Lost_Damaged {
    public partial class Frm_ReplacementForLostDamagedApplication : SalForm, IEnforcePermissions {
        public event Action ForceExit, DataSaved;

        private DateTime _registeredApplicationDate;
        private LocalDrivingLicense _newLicense = null;

        public Frm_ReplacementForLostDamagedApplication() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            rb_lostLicense.Tag = DrivingLicenseIssueReasons.ReplacementForLost;
            rb_damagedLicense.Tag = DrivingLicenseIssueReasons.ReplacementForDamaged;
            lbl_title.Text = rb_lostLicense.Checked ? Str_FrmReplacementForLostDamagedApplication.title_replacementForLost : Str_FrmReplacementForLostDamagedApplication.title_replacementForDamaged;
           
            _ResetApplicationInfoFields();
        }

        public Frm_ReplacementForLostDamagedApplication(int localDrivingLicenseID) : this() {
            ctrl_LocalLicenseInfoCardWithFilter1.SearchForLicense(localDrivingLicenseID);
            ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(bool isLocalLicenseActive) {
            _ResetApplicationInfoFields();
            rb_lostLicense.Checked = true;
            ll_showDriverLicenseHistory.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
            btn_issueReplacement.Enabled = gb_replacementFor.Enabled = isLocalLicenseActive;
            lbl_oldLicenseID.Text = ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID.ToString();

            if (!isLocalLicenseActive) {
                MessageBox.Show(Str_FrmReplacementForLostDamagedApplication.licenseNotActive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();
            }
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound() {
            rb_lostLicense.Checked = true;
            _ResetApplicationInfoFields();
            gb_replacementFor.Enabled = ll_showDriverLicenseHistory.Enabled = ll_showNewLicenseInfo.Enabled = btn_issueReplacement.Enabled = false;
            MessageBox.Show(Str_FrmIssueNewInternationalLicense.localLicenseNotFound, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!Visible)
                Close();
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved(int personID) => _RefreshEverything();

        private void Frm_ReplacementForLostDamagedApplication_Activated(object sender, EventArgs e) => ctrl_LocalLicenseInfoCardWithFilter1.SetFocused();

        private void ll_showDriverLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.DriverInfo.PersonID)) {
                _frmShowDriverLicenseHistory.ForceExit += _frmShowDriverLicenseHistory_ForceExit;
                _frmShowDriverLicenseHistory.DataSaved += _RefreshEverything;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.DataSaved -= _RefreshEverything;
                _frmShowDriverLicenseHistory.ForceExit -= _frmShowDriverLicenseHistory_ForceExit;
            }
        }

        private void _frmShowDriverLicenseHistory_ForceExit() => ForceExit?.Invoke();

        private void _RefreshEverything() {
            ctrl_LocalLicenseInfoCardWithFilter1.RefreshSelectedRecord();
            DataSaved?.Invoke();
        }

        private void btn_issueReplacement_Click(object sender, EventArgs e) {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                return;
            }

            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmReplacementForLostDamagedApplication.issueReplacementConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _newLicense = ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.IssueReplacement(_activeUser.UserID, _registeredApplicationDate, rb_lostLicense.Checked ? DrivingLicenseIssueReasons.ReplacementForLost : DrivingLicenseIssueReasons.ReplacementForDamaged);

            if (_newLicense is null)
                MessageBox.Show(Str_FrmIssueNewInternationalLicense.savingLicenseFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = gb_replacementFor.Enabled = btn_issueReplacement.Enabled = false;
                ctrl_LocalLicenseInfoCardWithFilter1.RefreshSelectedRecord();
                ll_showNewLicenseInfo.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
                lbl_licenseReplacementAppID.Text = _newLicense.ApplicationID.ToString();
                lbl_newLicenseID.Text = _newLicense.LocalDrivingLicenseID.ToString();
                DataSaved?.Invoke();

                MessageBox.Show(Str_FrmRenewLocalDrivingLicense.licenseRenewedSuccessfullyWithID + _newLicense.LocalDrivingLicenseID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _ResetApplicationInfoFields() {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                return;
            }

            lbl_licenseReplacementAppID.Text = lbl_newLicenseID.Text = lbl_oldLicenseID.Text = Resources.txt_unknownField;
            lbl_createdBy.Text = _activeUser.Username;
            lbl_applicationFees.Text = (rb_lostLicense.Checked ? ApplicationType.GetFees(ApplicationTypes.ReplacementForLostLicense) : ApplicationType.GetFees(ApplicationTypes.ReplacementForDamagedLicense)).ToString("C2");

            if (ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense is null)
                lbl_applicationDate.Text = lbl_oldLicenseID.Text = Resources.txt_unknownField;
            else {
                lbl_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_registeredApplicationDate = DateTime.Now);
                lbl_oldLicenseID.Text = ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID.ToString();
            }
        }

        private void rb_replacementFor_CheckedChanged(object sender, EventArgs e) {
            RadioButton _rbSender = (RadioButton) sender;
            DrivingLicenseIssueReasons _selectedReason = (DrivingLicenseIssueReasons) _rbSender.Tag;

            if (_rbSender.Checked) {
                lbl_applicationFees.Text = ApplicationType.GetFees(_selectedReason == DrivingLicenseIssueReasons.ReplacementForLost ? ApplicationTypes.ReplacementForLostLicense : ApplicationTypes.ReplacementForDamagedLicense).ToString("C2");
                lbl_title.Text = _selectedReason == DrivingLicenseIssueReasons.ReplacementForLost ? Str_FrmReplacementForLostDamagedApplication.title_replacementForLost : Str_FrmReplacementForLostDamagedApplication.title_replacementForDamaged;
            }
        }

        private void ll_showNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowLocalLicenseInformation _frmShowLocalDrivingLicenseInfo = new Frm_ShowLocalLicenseInformation(_newLicense is null ? -1 : _newLicense.LocalDrivingLicenseID)) {
                if (_frmShowLocalDrivingLicenseInfo.IsDisposed)
                    return;

                _frmShowLocalDrivingLicenseInfo.PersonSaved += ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved;
                _frmShowLocalDrivingLicenseInfo.ShowDialog();
                _frmShowLocalDrivingLicenseInfo.PersonSaved -= ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                if (ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID == -1)
                    ctrl_LocalLicenseInfoCardWithFilter1.PerformSearch();
                else if (btn_issueReplacement.Enabled)
                    btn_issueReplacement_Click(btn_issueReplacement, EventArgs.Empty);

                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_LocalLicenseInfoCardWithFilter1.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
