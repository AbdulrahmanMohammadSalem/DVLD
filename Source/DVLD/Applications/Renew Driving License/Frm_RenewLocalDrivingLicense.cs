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

namespace DVLD.Applications.Renew_Driving_License {
    public partial class Frm_RenewLocalDrivingLicense : SalForm, IEnforcePermissions {
        public event Action DataSaved, ForceExit;
        private DateTime _registeredApplicationDate;
        private LocalDrivingLicense _selectedLicense = null, _renewedLicense = null;

        public Frm_RenewLocalDrivingLicense() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
            _ResetApplicationInfoFields();
        }

        public Frm_RenewLocalDrivingLicense(int localDrivingLicenseID) : this() {
            ctrl_LocalLicenseInfoCardWithFilter1.SearchForLicense(localDrivingLicenseID);
            ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke();

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(bool isLicenseActive) {
            _selectedLicense = ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense;
            ll_showLicenseHistory.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
            txt_notes.Enabled = false;
            txt_notes.Text = _selectedLicense.Notes;

            if (isLicenseActive) {
                MessageBox.Show(Str_FrmRenewLocalDrivingLicense.selectedLicenseNotExpired + BusinessUtils.DateTimeUtils.FormatDateTime(_selectedLicense.ExpirationDate), Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();

                return;
            }
            
            if (LocalDrivingLicense.DoesDriverOwnActiveLocalLicenseOfClass(_selectedLicense.DriverID, _selectedLicense.LicenseClassID)) {
                MessageBox.Show(Str_FrmRenewLocalDrivingLicense.driverHasAnotherActiveLicense, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();
                
                return;
            }

            lbl_licenseFees.Text = LicenseClass.GetFees(_selectedLicense.LicenseClassID).ToString("C2");
            lbl_totalFees.Text = (decimal.Parse(lbl_applicationFees.Text) + decimal.Parse(lbl_licenseFees.Text)).ToString();
            lbl_oldLicenseID.Text = _selectedLicense.LocalDrivingLicenseID.ToString();
            btn_renew.Enabled = txt_notes.Enabled = true;
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound() {
            _selectedLicense = _renewedLicense = null;
            ll_showLicenseHistory.Enabled = btn_renew.Enabled = txt_notes.Enabled = false;
            txt_notes.Text = string.Empty;
            _ResetApplicationInfoFields();
            MessageBox.Show(Str_FrmIssueNewInternationalLicense.localLicenseNotFound, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!Visible)
                Close();
        }

        private void _ResetApplicationInfoFields() {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                return;
            }

            _registeredApplicationDate = DateTime.Now;
            lbl_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_registeredApplicationDate);
            lbl_applicationFees.Text = ApplicationType.GetFees(ApplicationTypes.RenewLicense).ToString("C2");
            lbl_createdBy.Text = _activeUser.Username;
            lbl_renewAppID.Text = lbl_issueDate.Text = lbl_licenseFees.Text = lbl_newLicenseID.Text = lbl_oldLicenseID.Text = lbl_newExpirationDate.Text = lbl_totalFees.Text = Resources.txt_unknownField;
            txt_notes.Text = string.Empty;
        }

        private void ll_showLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(_selectedLicense.DriverInfo.PersonID)) {
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

        private void btn_renew_Click(object sender, EventArgs e) {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                return;
            }

            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmRenewLocalDrivingLicense.renewLicenseConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _renewedLicense = _selectedLicense.RenewLicense(_activeUser.UserID, _registeredApplicationDate, txt_notes.Text);

            if (_renewedLicense is null)
                MessageBox.Show(Str_FrmIssueNewInternationalLicense.savingLicenseFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                lbl_renewAppID.Text = _renewedLicense.ApplicationID.ToString();
                lbl_issueDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_renewedLicense.IssueDate);
                lbl_newLicenseID.Text = _renewedLicense.LocalDrivingLicenseID.ToString();
                lbl_newExpirationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_renewedLicense.ExpirationDate);

                ll_showRenewedLicenseInfo.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
                ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = btn_renew.Enabled = txt_notes.Enabled = false;
                DataSaved?.Invoke();

                MessageBox.Show(Str_FrmRenewLocalDrivingLicense.licenseRenewedSuccessfullyWithID + _renewedLicense.LocalDrivingLicenseID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_RenewLocalDrivingLicense_Activated(object sender, EventArgs e) => ctrl_LocalLicenseInfoCardWithFilter1.SetFocused();

        private void ll_showRenewedLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowLocalLicenseInformation _frmShowLocalLicenseInfo = new Frm_ShowLocalLicenseInformation(_renewedLicense.LocalDrivingLicenseID)) {
                if (_frmShowLocalLicenseInfo.IsDisposed)
                    return;

                _frmShowLocalLicenseInfo.PersonSaved += _frmShowLocalLicenseInfo_PersonSaved;
                _frmShowLocalLicenseInfo.ShowDialog();
                _frmShowLocalLicenseInfo.PersonSaved -= _frmShowLocalLicenseInfo_PersonSaved;
            }
        }

        private void _frmShowLocalLicenseInfo_PersonSaved(int personID) => _RefreshEverything();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter && ctrl_LocalLicenseInfoCardWithFilter1.Focused) {
                ctrl_LocalLicenseInfoCardWithFilter1.PerformSearch();

                if (ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense != null)
                    txt_notes.Focus();

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_LocalLicenseInfoCardWithFilter1.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
