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

namespace DVLD.Applications.International_Driving_License {
    public partial class Frm_IssueNewInternationalLicense : SalForm, IEnforcePermissions {
        public event Action ForceExit, DataSaved;
        private DateTime _registeredApplicationDate;

        public Frm_IssueNewInternationalLicense() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
            _ResetApplicationInfoFields();
        }

        public Frm_IssueNewInternationalLicense(int localDrivingLicenseID) {
            LocalDrivingLicense _localLicense = LocalDrivingLicense.Find(localDrivingLicenseID);

            if (_localLicense is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
            ctrl_LocalLicenseInfoCardWithFilter1.LoadDirectlyFromObject(_localLicense); //This doesn't invoke the LicenseFound event
            ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(_localLicense.IsActive);
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound(bool localLicenseActive) {
            if (timer1.Enabled)
                _SetIssueButtonAnimation(false);

            _ResetApplicationInfoFields();
            ll_showLicensesHistory.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);

            if (LocalDrivingLicense.FindLicenseClass(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID) != LicenseClasses.Class3_OrdinaryDrivingLicense) {
                btn_issue.Enabled = ll_showInterLicenseInfo.Enabled = false;
                MessageBox.Show(Str_FrmIssueNewInternationalLicense.canOnlyIssueClass3, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();

                return;
            }

            if (!localLicenseActive) {
                btn_issue.Enabled = false;
                ll_showInterLicenseInfo.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo) && InternationalDrivingLicense.DoesExist_ByLocalLicense(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID);
                MessageBox.Show(Str_FrmIssueNewInternationalLicense.chosenLicenseInvactive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!Visible)
                    Close();

                return;
            }

            InternationalDrivingLicense _activeInterLicense = InternationalDrivingLicense.FindActiveLicense_ByDriverId(ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.DriverID);

            if (_activeInterLicense is null || _activeInterLicense.IssuedUsingLocalLicenseID != ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID) {
                DateTime _licenseExpirationDate = ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.ExpirationDate;

                lbl_localLicenseID.Text = ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID.ToString();

                if (DateTime.Now > _licenseExpirationDate) {
                    lbl_expirationDate.MatchParentForeColor = false;
                    lbl_expirationDate.ForeColor = Color.Red;
                } else
                    lbl_expirationDate.MatchParentForeColor = true;

                lbl_expirationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_licenseExpirationDate);
                btn_issue.Enabled = true;
                ll_showInterLicenseInfo.Enabled = false;

                if (_activeInterLicense != null && !timer1.Enabled)
                    _SetIssueButtonAnimation(true);
            } else {
                _FillApplicationInfoFields(_activeInterLicense);
                btn_issue.Enabled = false;
                ll_showInterLicenseInfo.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo);

                MessageBox.Show(Str_FrmIssueNewInternationalLicense.activeInterLicenseAlreadyExists, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _SetIssueButtonAnimation(bool enabled) {
            timer1.Enabled = enabled;
            btn_issue.FlatAppearance.BorderColor = Color.Black;
            toolTip1.SetToolTip(btn_issue, enabled ? Str_FrmIssueNewInternationalLicense.anActiveInterLicenseExist_LocalInvactive : string.Empty);
        }

        private void _FillApplicationInfoFields(InternationalDrivingLicense interLicense) {
            DVLD_Business.Application _interLicenseAppInfo = interLicense.ApplicationInfo;

            _registeredApplicationDate = _interLicenseAppInfo.ApplicationDate;
            lbl_interLicenseAppID.Text = interLicense.ApplicationID.ToString();
            lbl_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_registeredApplicationDate);
            lbl_issueDate.Text = BusinessUtils.DateTimeUtils.FormatDate(interLicense.IssueDate);
            lbl_fees.Text = _interLicenseAppInfo.FeesPaid.ToString("C2");
            lbl_interLicenseID.Text = interLicense.InternationalLicenseID.ToString();
            lbl_localLicenseID.Text = interLicense.IssuedUsingLocalLicenseID.ToString();

            if (DateTime.Now > interLicense.ExpirationDate) {
                lbl_expirationDate.MatchParentForeColor = false;
                lbl_expirationDate.ForeColor = Color.Red;
            } else
                lbl_expirationDate.MatchParentForeColor = true;

            lbl_expirationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(interLicense.ExpirationDate);

            User _createdBy = interLicense.CreatedByUserInfo;

            if (_createdBy is null) {
                lbl_createdBy.MatchParentForeColor = false;
                lbl_createdBy.ForeColor = Color.Red;
                lbl_createdBy.Text = Resources.txt_unknownField;
            } else {
                lbl_createdBy.MatchParentForeColor = true;
                lbl_createdBy.Text = _createdBy.Username;
            }
        }

        private void _ResetApplicationInfoFields() {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                return;
            }

            _registeredApplicationDate = DateTime.Now;
            lbl_expirationDate.MatchParentForeColor = true;
            lbl_interLicenseAppID.Text = lbl_issueDate.Text = lbl_interLicenseID.Text = lbl_localLicenseID.Text = lbl_expirationDate.Text = Resources.txt_unknownField;
            lbl_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_registeredApplicationDate);
            lbl_fees.Text = ApplicationType.GetFees(ApplicationTypes.NewInternationLicense).ToString("C2");
            lbl_createdBy.Text = _activeUser.Username;
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound() {
            if (timer1.Enabled)
                _SetIssueButtonAnimation(false);
            _ResetApplicationInfoFields();
            btn_issue.Enabled = ll_showLicensesHistory.Enabled = ll_showInterLicenseInfo.Enabled = false;

            MessageBox.Show(Str_FrmIssueNewInternationalLicense.localLicenseNotFound, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke();

        private void button_issue_Click(object sender, EventArgs e) {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ForceExit?.Invoke();
                return;
            }

            if (InternationalDrivingLicense.DoesActiveInternationalLicenseExist_ByLocalLicense(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID)) {
                btn_issue.Enabled = false;
                ll_showInterLicenseInfo.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo);

                MessageBox.Show(Str_FrmIssueNewInternationalLicense.activeInterLicenseAlreadyExists, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SystemSounds.Beep.Play();

            if (MessageBox.Show(Str_FrmIssueNewInternationalLicense.issueLicenseConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                DVLD_Business.Application _newApplication = new DVLD_Business.Application() {
                    ApplicantPersonID = ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.DriverInfo.PersonID,
                    ApplicationDate = _registeredApplicationDate,
                    UpdateStatusDate = DateTime.Now,
                    ApplicationStatus = ApplicationStatus.Completed,
                    ApplicationTypeID = ApplicationTypes.NewInternationLicense,
                    CreatedByUserID = _activeUser.UserID,
                    FeesPaid = ApplicationType.GetFees(ApplicationTypes.NewInternationLicense)
                };

                if (!_newApplication.Save()) {
                    MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                InternationalDrivingLicense _newLicense = _newApplication.IssueNewInternationalLicense(ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID);
                
                if (_newLicense is null) {
                    DVLD_Business.Application.Delete(_newApplication.BaseApplicationID);
                    MessageBox.Show(Str_FrmIssueNewInternationalLicense.savingLicenseFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    if (timer1.Enabled)
                        _SetIssueButtonAnimation(false);

                    ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = false;
                    lbl_interLicenseAppID.Text = _newApplication.BaseApplicationID.ToString();
                    lbl_interLicenseID.Text = _newLicense.InternationalLicenseID.ToString();
                    lbl_issueDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_newLicense.IssueDate);
                    ll_showInterLicenseInfo.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo);
                    btn_issue.Enabled = false;

                    DataSaved?.Invoke();

                    MessageBox.Show(Str_FrmIssueNewInternationalLicense.savedSuccessfullyWithID + _newLicense.InternationalLicenseID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ll_showLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(ctrl_LocalLicenseInfoCardWithFilter1.SelectedLocalDrivingLicense.DriverInfo.PersonID)) {
                _frmShowDriverLicenseHistory.ForceExit += _frmShowDriverLicenseHistory_ForceExit;
                _frmShowDriverLicenseHistory.DataSaved += _frmShowDriverLicenseHistory_PersonSaved;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.DataSaved -= _frmShowDriverLicenseHistory_PersonSaved;
                _frmShowDriverLicenseHistory.ForceExit -= _frmShowDriverLicenseHistory_ForceExit;
            }
        }

        private void _frmShowDriverLicenseHistory_ForceExit() => ForceExit?.Invoke();

        private void ll_showInterLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            int.TryParse(lbl_interLicenseID.Text, out int _interLicenseID);
            using (Frm_ShowInternationalLicenseInformation _frmShowInterLicenseInfo = new Frm_ShowInternationalLicenseInformation(_interLicenseID == 0 ? -1 : _interLicenseID)) {
                if (_frmShowInterLicenseInfo.IsDisposed)
                    return;

                _frmShowInterLicenseInfo.DataSaved += _RefreshEverything;
                _frmShowInterLicenseInfo.ShowDialog();
                _frmShowInterLicenseInfo.DataSaved -= _RefreshEverything;
            }
        }

        private void _frmShowDriverLicenseHistory_PersonSaved() => _RefreshEverything();

        private void Frm_IssueNewInternationalLicense_Activated(object sender, EventArgs e) => ctrl_LocalLicenseInfoCardWithFilter1.SetFocused();

        private void timer1_Tick(object sender, EventArgs e) =>
            btn_issue.FlatAppearance.BorderColor = Color.FromArgb(255 - btn_issue.FlatAppearance.BorderColor.R, 0, 0);

        private void Frm_IssueNewInternationalLicense_Load(object sender, EventArgs e) => toolTip1.ToolTipTitle = Resources.msg_notice;

        private void _RefreshEverything() {
            ctrl_LocalLicenseInfoCardWithFilter1.RefreshSelectedRecord();
            DataSaved?.Invoke();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                if (ctrl_LocalLicenseInfoCardWithFilter1.LocalDrivingLicenseID == -1)
                    ctrl_LocalLicenseInfoCardWithFilter1.PerformSearch();
                else if (btn_issue.Enabled)
                    button_issue_Click(btn_issue, EventArgs.Empty);

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_LocalLicenseInfoCardWithFilter1.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
