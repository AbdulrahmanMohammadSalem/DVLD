using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Detain_Licenses {
    public partial class Frm_DetainLicense : SalForm, IEnforcePermissions {
        public event Action DataSaved, ForceExit;
        private DateTime _registeredDetainDateTime;

        public Frm_DetainLicense() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        public Frm_DetainLicense(int localDrivingLicenseID) : this() {
            ctrl_LocalLicenseInfoCardWithFilter1.SearchForLicense(localDrivingLicenseID);
            ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
        }

        private void txt_fineFees_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

        private void ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke();

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(bool isLicenseActive) {
            if (!_HandleCreatedByField())
                return;

            _registeredDetainDateTime = DateTime.Now;

            lbl_detainDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_registeredDetainDateTime);
            lbl_licenseID.Text = ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID.ToString();
            txt_detainReason.Text = txt_fineFees.Text = string.Empty;
            txt_detainReason.Enabled = txt_fineFees.Enabled = false;
            ll_showLicenseHistory.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);

            if (!isLicenseActive) {
                MessageBox.Show(Str_FrmDetainLicense.selectedLicenseNotActive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();
                
                return;
            }
            
            LicenseDetention _detain = LicenseDetention.FindByLicenseId(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID);
            
            if (_detain != null && !_detain.IsReleased) {
                User _createdByUser = User.Find(_detain.CreatedByUserID);

                lbl_detainID.Text = _detain.DetainID.ToString();
                lbl_detainDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_detain.DetainDate);
                txt_detainReason.Text = _detain.DetainReason;
                txt_fineFees.Text = _detain.FineFees.ToString("C2");
                
                if (_createdByUser is null) {
                    lbl_createdBy.MatchParentForeColor = false;
                    lbl_createdBy.ForeColor = Color.Red;
                    lbl_createdBy.Text = Resources.txt_unknownField;
                } else {
                    lbl_createdBy.MatchParentForeColor = true;
                    lbl_createdBy.Text = _createdByUser.Username;
                }

                MessageBox.Show(Str_FrmDetainLicense.selectedLicenseAlreadyDetained, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                txt_detainReason.Enabled = txt_fineFees.Enabled = btn_detain.Enabled = true;
        }

        private void Frm_DetainLicense_Load(object sender, EventArgs e) => _HandleCreatedByField();

        private bool _HandleCreatedByField() {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                Close();
                return false;
            }

            lbl_createdBy.Text = _activeUser.Username;
            return true;
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

        private void txt_detainNotes_Validating(object sender, CancelEventArgs e) => _ValidateDetainNotes();
            
        private bool _ValidateDetainNotes() {
            txt_detainReason.Text = txt_detainReason.Text.Trim();

            if (txt_detainReason.Text == string.Empty) {
                errorProvider1.SetError(txt_detainReason, Resources.txt_requiredField);
                return false;
            }

            return true;
        }

        private void txt_fineFees_Validating(object sender, CancelEventArgs e) {
            if (txt_fineFees.Text == string.Empty)
                errorProvider1.SetError(txt_fineFees, Resources.txt_requiredField);
            else if (!decimal.TryParse(txt_fineFees.Text, out _)) {
                errorProvider1.SetError(txt_fineFees, Resources.txt_enterValidDecimalValue);
                e.Cancel = true;
            }
        }

        private bool _ValidateFineFees() {
            if (txt_fineFees.Text == string.Empty || decimal.Parse(txt_fineFees.Text) == 0) {
                errorProvider1.SetError(txt_fineFees, Resources.txt_requiredField);
                return false;
            }
            
            if (!decimal.TryParse(txt_fineFees.Text, out _)) {
                errorProvider1.SetError(txt_fineFees, Resources.txt_enterValidDecimalValue);
                return false;
            }

            return true;
        }

        private void txt_detainNotes_TextChanged(object sender, EventArgs e) => errorProvider1.SetError((Control) sender, string.Empty);

        private void btn_detain_Click(object sender, EventArgs e) {
            if (!_ValidateInputFields())
                return;

            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmDetainLicense.detainLicenseConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!_HandleCreatedByField())
                return;

            LicenseDetention _detainOperation = LicenseDetention.DetainLicense(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID, txt_detainReason.Text, decimal.Parse(txt_fineFees.Text), GlobalFields.ActiveUserID, _registeredDetainDateTime);

            if (_detainOperation is null)
                MessageBox.Show(Str_FrmDetainLicense.detainFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                txt_detainReason.Enabled = txt_fineFees.Enabled = btn_detain.Enabled = ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
                ctrl_LocalLicenseInfoCardWithFilter1.SetIsDetainedLabel(true);
                lbl_detainID.Text = _detainOperation.DetainID.ToString();
                DataSaved?.Invoke();

                MessageBox.Show(Str_FrmDetainLicense.detainSucceededWithID + _detainOperation.DetainID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool _ValidateInputFields() => _ValidateFineFees() & _ValidateDetainNotes();

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound() {
            lbl_detainID.Text = lbl_detainDate.Text = lbl_licenseID.Text = Resources.txt_unknownField;
            txt_detainReason.Text = txt_fineFees.Text = string.Empty;
            ll_showLicenseHistory.Enabled = btn_detain.Enabled = false;

            MessageBox.Show(Str_FrmIssueNewInternationalLicense.localLicenseNotFound, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!Visible)
                Close();
        }

        private void Frm_DetainLicense_Activated(object sender, EventArgs e) => ctrl_LocalLicenseInfoCardWithFilter1.SetFocused();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                if (ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID == -1)
                    ctrl_LocalLicenseInfoCardWithFilter1.PerformSearch();
                else if (btn_detain.Enabled)
                    btn_detain_Click(btn_detain, EventArgs.Empty);

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_LocalLicenseInfoCardWithFilter1.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
