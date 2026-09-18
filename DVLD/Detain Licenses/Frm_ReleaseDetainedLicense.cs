using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Detain_Licenses {
    public partial class Frm_ReleaseDetainedLicense : SalForm, IEnforcePermissions {
        public event Action ForceExit, DataSaved;
        private DateTime _registeredReleaseDate;
        private LicenseDetention _licenseDetain;

        public Frm_ReleaseDetainedLicense() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        public Frm_ReleaseDetainedLicense(int localDrivingLicenseID) : this() {
            ctrl_LocalLicenseInfoCardWithFilter1.SearchForLicense(localDrivingLicenseID);
            ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                if (ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID == -1)
                    ctrl_LocalLicenseInfoCardWithFilter1.PerformSearch();
                else
                    btn_release_Click(btn_release, EventArgs.Empty);

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke();

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(bool isLicenseActive) {
            ll_showLicenseHistory.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);

            //----    Filling Detain Details:
            _licenseDetain = LicenseDetention.FindByLicenseId(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID);

            if (_licenseDetain is null || _licenseDetain.IsReleased) {
                btn_release.Enabled = false;
                MessageBox.Show(Str_FrmReleaseDetainedLicense.licenseNotDetained, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();
                
                return;
            }

            if (!isLicenseActive)
                MessageBox.Show(Str_FrmReleaseDetainedLicense.licenseHasExpired, Resources.msg_notice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            User _createdByUser = User.Find(_licenseDetain.CreatedByUserID);

            lbl_detainID.Text = _licenseDetain.DetainID.ToString();
            lbl_detainDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_licenseDetain.DetainDate);
            lbl_detainReason.Text = _licenseDetain.DetainReason;
            lbl_fineFees.Text = _licenseDetain.FineFees.ToString("C2");
            lbl_licenseID.Text = LocalDrivingLicense.GetLocalLicenseID(_licenseDetain.BaseLicenseID).ToString();
            
            if (_createdByUser is null) {
                lbl_createdBy.MatchParentForeColor = false;
                lbl_createdBy.ForeColor = Color.Red;
                lbl_createdBy.Text = Resources.txt_unknownField;
            } else {
                lbl_createdBy.MatchParentForeColor = true;
                lbl_createdBy.Text = _createdByUser.Username;
            }

            //----    Filling Release Application Details:
            decimal _applicationFees = ApplicationType.GetFees(ApplicationTypes.ReleaseDetainedLicense);

            lbl_applicationFees.Text = _applicationFees.ToString("C2");
            lbl_totalFees.Text = (_licenseDetain.FineFees + _applicationFees).ToString("C2");
            _registeredReleaseDate = DateTime.Now;
            lbl_releaseDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_registeredReleaseDate);
            _HandleActiveUser();
            btn_release.Enabled = true;
        }

        private void Frm_ReleaseDetainedLicense_Load(object sender, EventArgs e) => _HandleActiveUser();

        private bool _HandleActiveUser() {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                Close();
                return false;
            }

            lbl_releasedBy.Text = _activeUser.Username;
            return true;
        }

        private void btn_release_Click(object sender, EventArgs e) {
            if (!_HandleActiveUser())
                return;

            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmReleaseDetainedLicense.releaseLicenseConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!_licenseDetain.ReleaseLicense(_registeredReleaseDate, GlobalFields.ActiveUserID, out int releaseAppID))
                MessageBox.Show(Str_FrmReleaseDetainedLicense.licenseReleaseFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = btn_release.Enabled = false;
                ctrl_LocalLicenseInfoCardWithFilter1.SetIsDetainedLabel(false);
                lbl_releaseAppID.Text = releaseAppID.ToString();
                DataSaved?.Invoke();

                MessageBox.Show(Str_FrmReleaseDetainedLicense.licenseReleasedSuccessfullyWithID + releaseAppID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ll_showLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.DriverInfo.PersonID)) {
                _frmShowDriverLicenseHistory.DataSaved += _frmShowDriverLicenseHistory_DataSaved;
                _frmShowDriverLicenseHistory.ForceExit += _frmShowDriverLicenseHistory_ForceExit;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.ForceExit -= _frmShowDriverLicenseHistory_ForceExit;
                _frmShowDriverLicenseHistory.DataSaved -= _frmShowDriverLicenseHistory_DataSaved;
            }
        }

        private void _frmShowDriverLicenseHistory_ForceExit() => ForceExit?.Invoke();

        private void _frmShowDriverLicenseHistory_DataSaved() {
            ctrl_LocalLicenseInfoCardWithFilter1.RefreshSelectedRecord();
            DataSaved?.Invoke();
        }

        private void lbl_detainReason_TextChanged(object sender, EventArgs e) {

        }

        private void Frm_ReleaseDetainedLicense_Activated(object sender, EventArgs e) => ctrl_LocalLicenseInfoCardWithFilter1.SetFocused();

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound() {
            _licenseDetain = null;
            ll_showLicenseHistory.Enabled = btn_release.Enabled = false;
            lbl_detainID.Text = lbl_detainDate.Text = lbl_detainReason.Text = lbl_fineFees.Text = lbl_applicationFees.Text = lbl_totalFees.Text = lbl_licenseID.Text = lbl_createdBy.Text = lbl_releaseAppID.Text = lbl_releaseDate.Text = Resources.txt_unknownField;
            _HandleActiveUser();

            MessageBox.Show(Str_FrmIssueNewInternationalLicense.localLicenseNotFound, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!Visible)
                Close();
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_LocalLicenseInfoCardWithFilter1.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
