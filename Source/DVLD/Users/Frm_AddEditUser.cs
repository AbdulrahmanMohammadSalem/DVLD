using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Permissions;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Manina.Windows.Forms;
using Salem.Controls;
using Salem.Extensions;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using static DVLD_Business.Permissions;

namespace DVLD.Users {
    public partial class Frm_AddEditUser : SalForm, IEnforcePermissions {
        public bool ForceExit { get; private set; } = false;

        public event Action<int> DataSaved;
        public event Action<DVLD_Business.Permissions> ActiveUserPermissionsChanged;

        private Modes _ActiveMode = Modes.AddNew; //By default
        private User _User = null; //By default
        private DVLD_Business.Permissions _UserPermissions = null;

        private DVLD_Business.Permissions CurrentPermissions => new DVLD_Business.Permissions {
            People = (PeopleManagement) _GetPermissionsValue(cb_peopleManagement, ll_peopleManagement),
            Users = (UsersManagement) _GetPermissionsValue(cb_usersManagement, ll_usersManagement),
            Drivers = (DriversManagement) _GetPermissionsValue(cb_driversManagement, ll_driversManagement),
            LocalLicenseApps = (LocalLicenseAppsManagement) _GetPermissionsValue(cb_localLicenseAppsManagement, ll_localLicenseAppsManagement),
            InterLicenseApps = (InterLicenseAppsManagement) _GetPermissionsValue(cb_interLicenseAppsManagement, ll_interLicenseAppsManagement),
            Tests_TestAppoints = (Tests_TestAppointsManagement) _GetPermissionsValue(cb_testsManagement, ll_testsManagement),
            Licenses = (LicensesManagement) _GetPermissionsValue(cb_licensesManagement, ll_licensesManagement),
            LicenseDetention = (LicenseDetentionManagement) _GetPermissionsValue(cb_licenseDetentionManagement, ll_licenseDetentionManagement),
            Dashboard = (DashboardAccess) _GetPermissionsValue(cb_dashboardAccess, ll_dashboardAccess),
            Reports = (ReportsAccess) _GetPermissionsValue(cb_reportsAccess, ll_reportsAccess),
            LookupTables = (LookupTablesManagement) _GetPermissionsValue(cb_lookupTablesManagement, ll_lookupTablesManagement),
            ApplicationSettings = (ApplicationSettingsAccess) _GetPermissionsValue(cb_applicationSettingsAccess, ll_applicationSettingsAccess)
        };

        public Frm_AddEditUser() {
            InitializeComponent();
            ctrl_PersonCardWithFilter1.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);

            if (tabControl1.RightToLeft == RightToLeft.Yes) {
                button_next.Image = Resources.Prev_32;
                tabControl1.ReverseTabsOrder();
                tabControl1.TabLocation = TabLocation.TopRight;
                tabControl1.SelectedTab = tab_loginInfo;
                tabControl1.SelectedTab = tab_personalInfo;
            } else
                button_next.Image = Resources.Next_32;

            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
        }

        public Frm_AddEditUser(int userID) : this() {
            _User = User.Find(userID);

            if (_User is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); //This will dispose the object -- We must check if it got disposed of when calling this constructor
                return;
            }

            _UserPermissions = _User.PermissionsInfo;
            _ActiveMode = Modes.Update;

            EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void Frm_AddEditUser_Load(object sender, EventArgs e) {
            if (_ActiveMode == Modes.AddNew)
                _InitializePermissionsLinkLableTags();
            else {
                ctrl_PersonCardWithFilter1.PersonID = _User.PersonInfo.PersonID;
                ctrl_PersonCardWithFilter1.EnableFiltering = false;
                //Other control Enabled property is set in the EnforePermissions method
                lbl_userID.Text = _User.UserID.ToString();
                txt_username.Text = _User.Username;
                textBox_password.Text = textBox_confirmPassword.Text = _User.Password;
                chk_isActive.Checked = _User.IsActive;
                textBox_password.Enabled = textBox_confirmPassword.Enabled = false;
                Text = Str_FrmAddEditUser.updateUser;
                label_title.Text = Str_FrmAddEditUser.updateUserInfo;

                _PopulatePermissionsControls();
            }
        }

        private void button_next_Click(object sender, EventArgs e) {
            if (ctrl_PersonCardWithFilter1.PersonID == -1) {
                MessageBox.Show(Str_FrmAddEditUser.youMustFirstChoosePerson, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ActiveMode == Modes.AddNew) {
                if (User.DoesExistByPersonID(ctrl_PersonCardWithFilter1.PersonID)) {
                    MessageBox.Show(Str_FrmAddEditUser.personAlreadyRegisteredAsUser, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pnl_loginInfoFields.Enabled = pnl_permissions.Enabled = true;
            }

            tabControl1.SelectedIndex = 1; //Permissions Tab
        }

        private void ctrl_PersonCardWithFilter1_PersonFound(int personID) { 
            if (_ActiveMode == Modes.AddNew) {
                _ResetLoginInfoPanel();
                _ResetPermissionsPanel();
            }
        }

        private void ctrl_PersonCardWithFilter1_PersonNotFound() {
            if (_ActiveMode == Modes.AddNew) {
                _ResetLoginInfoPanel();
                _ResetPermissionsPanel();
            }
        }

        private void ctrl_PersonCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke(_User.UserID);

        private void _ResetLoginInfoPanel() {
            errorProvider1.Clear();
            txt_username.Text = textBox_password.Text = textBox_confirmPassword.Text = string.Empty;
            chk_isActive.Checked = true;
            pnl_loginInfoFields.Enabled = false;
        }

        private void textBox_toClearError_TextChanged(object sender, EventArgs e) => errorProvider1.SetError((TextBox) sender, string.Empty);

        private void textBox_confirmPassword_Validating(object sender, CancelEventArgs e) {
            if (textBox_password.Text != string.Empty && textBox_confirmPassword.Text != string.Empty && textBox_confirmPassword.Text != textBox_password.Text) {
                errorProvider1.SetError(textBox_confirmPassword, Str_FrmAddEditUser.invalidConfirmPasswordInput);
                e.Cancel = true;
                //textBox_confirmPassword.Focus();
            }
        }

        private void textBox_username_Validating(object sender, CancelEventArgs e) => e.Cancel = !_ValidateUsernameInput();

        private bool _ValidateUsernameInput() {
            txt_username.Text = txt_username.Text.Trim();

            if (_ActiveMode == Modes.Update && txt_username.Text == _User.Username)
                return true;

            if (txt_username.Text == string.Empty) {
                errorProvider1.SetError(txt_username, Resources.txt_requiredField);
                return false;
            }

            if (User.DoesExist(txt_username.Text)) {
                errorProvider1.SetError(txt_username, Str_FrmAddEditUser.usernameAlreadyChosen);
                return false;
            }

            return true;
        }

        private void textBox_password_Validating(object sender, CancelEventArgs e) {
            if (textBox_password.Text == string.Empty)
                errorProvider1.SetError(textBox_password, Resources.txt_requiredField);
        }

        private void button_save_Click(object sender, EventArgs e) {
            if (_ActiveMode == Modes.AddNew ? !(pnl_loginInfoFields.Enabled && _ValidateLoginFields()) : !_ValidateLoginFields()) {
                MessageBox.Show(Resources.msg_incompleteCredentials, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_username.Text = txt_username.Text.Trim();
            int _permissionsID;

            if (_User is null) { //AddNew mode
                _User = new User();
                _UserPermissions = CurrentPermissions;

                if (_UserPermissions.Save())
                    _permissionsID = _UserPermissions.PermissionsID;
                else {
                    MessageBox.Show(Str_FrmAddEditUser.userSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
                _permissionsID = _User.PermissionsID;

            _User.PersonID = ctrl_PersonCardWithFilter1.PersonID;
            _User.Username = txt_username.Text;
            _User.Password = textBox_password.Text;
            _User.IsActive = chk_isActive.Checked;
            _User.PermissionsID = _permissionsID;

            if (_User.UserID == GlobalFields.ActiveUserID && !_User.IsActive) { //Definite UpdateMode
                if (MessageBox.Show(Str_FrmAddEditUser.attemptingDeactivatingActiveUser, Resources.msg_warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    if (_User.Save()) {
                        GlobalFields.LoginScreenMessageBoxInfo = (Resources.msg_userSavedSuccessfully, Resources.msg_success);
                        ForceExit = true;
                        Close();
                    }
                    else
                        MessageBox.Show(Str_FrmAddEditUser.userSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (_UserPermissions.Save() & _User.Save()) { //No short-circuiting
                DataSaved?.Invoke(_User.UserID);

                ctrl_PersonCardWithFilter1.EnableFiltering = false;
                textBox_password.Enabled = textBox_confirmPassword.Enabled = false;

                if (_ActiveMode == Modes.AddNew) {
                    _ActiveMode = Modes.Update;
                    lbl_userID.Text = _User.UserID.ToString();
                    Text = Str_FrmAddEditUser.updateUser;
                    label_title.Text = Str_FrmAddEditUser.updateUserInfo;
                    MessageBox.Show(Str_FrmAddEditUser.userSavedSuccessfullyWithID + _User.UserID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    if (_User.UserID == GlobalFields.ActiveUserID && !_UserPermissions.DeepEquals(GlobalFields.ActiveUserPermissions)) {
                        GlobalFields.ActiveUserPermissions = _UserPermissions.Clone(); //To enable further notification after this save operation
                        ActiveUserPermissionsChanged?.Invoke(_UserPermissions);
                        EnforcePermissions(GlobalFields.ActiveUserPermissions); //This is mandatory
                    }

                    MessageBox.Show(Resources.msg_userSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                if (_ActiveMode == Modes.AddNew)
                    Delete(_permissionsID);

                MessageBox.Show(Str_FrmAddEditUser.userSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _ValidateLoginFields() {
            bool _result = true;

            if (!_ValidateUsernameInput())
                _result = false;

            if (textBox_password.Text == string.Empty) {
                _result = false;
                errorProvider1.SetError(textBox_password, Resources.txt_requiredField);
            }

            if (textBox_password.Text != string.Empty && textBox_confirmPassword.Text != textBox_password.Text) {
                _result = false;
                errorProvider1.SetError(textBox_confirmPassword, Str_FrmAddEditUser.invalidConfirmPasswordInput);
            }

            return _result;
        }

        private void Frm_AddEditUser_Activated(object sender, EventArgs e) => ctrl_PersonCardWithFilter1.SetFocused();

        private void tabControl1_PageChanged(object sender, PageChangedEventArgs e) => btn_save.FlatAppearance.BorderSize = tabControl1.SelectedTab == tab_personalInfo ? 1 : 2;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                if (tabControl1.SelectedTab != tab_personalInfo) {
                    btn_save.PerformClick();
                    return true;
                }

                if (ctrl_PersonCardWithFilter1.Focused) {
                    ctrl_PersonCardWithFilter1.PerformSearch();

                    if (ctrl_PersonCardWithFilter1.PersonID != -1)
                        ActiveControl = button_next;

                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void _ResetPermissionsPanel() {
            _InitializePermissionsLinkLableTags();
            _ResetPermissionsComboBoxesSelection();

            pnl_permissions.Enabled = false;
        }

        private void _ResetPermissionsComboBoxesSelection() {
            cb_peopleManagement.SelectedIndex = 0;
            cb_usersManagement.SelectedIndex = 0;
            cb_driversManagement.SelectedIndex = 0;
            cb_localLicenseAppsManagement.SelectedIndex = 0;
            cb_interLicenseAppsManagement.SelectedIndex = 0;
            cb_testsManagement.SelectedIndex = 0;
            cb_licensesManagement.SelectedIndex = 0;
            cb_licenseDetentionManagement.SelectedIndex = 0;
            cb_dashboardAccess.SelectedIndex = 0;
            cb_reportsAccess.SelectedIndex = 0;
            cb_lookupTablesManagement.SelectedIndex = 0;
            cb_applicationSettingsAccess.SelectedIndex = 0;
        }

        private void _InitializePermissionsLinkLableTags() {
            ll_peopleManagement.Tag = PeopleManagement.NoAccess;
            ll_usersManagement.Tag = UsersManagement.NoAccess;
            ll_driversManagement.Tag = DriversManagement.NoAccess;
            ll_localLicenseAppsManagement.Tag = LocalLicenseAppsManagement.NoAccess;
            ll_interLicenseAppsManagement.Tag = InterLicenseAppsManagement.NoAccess;
            ll_testsManagement.Tag = Tests_TestAppointsManagement.NoAccess;
            ll_licensesManagement.Tag = LicensesManagement.NoAccess;
            ll_licenseDetentionManagement.Tag = LicenseDetentionManagement.NoAccess;
            ll_dashboardAccess.Tag = DashboardAccess.NoAccess;
            ll_reportsAccess.Tag = ReportsAccess.NoAccess;
            ll_lookupTablesManagement.Tag = LookupTablesManagement.NoAccess;
            ll_applicationSettingsAccess.Tag = ApplicationSettingsAccess.NoAccess;
        }

        private void _PopulatePermissionsControls() {
            ll_peopleManagement.Tag = _UserPermissions.People;
            ll_usersManagement.Tag = _UserPermissions.Users;
            ll_driversManagement.Tag = _UserPermissions.Drivers;
            ll_localLicenseAppsManagement.Tag = _UserPermissions.LocalLicenseApps;
            ll_interLicenseAppsManagement.Tag = _UserPermissions.InterLicenseApps;
            ll_testsManagement.Tag = _UserPermissions.Tests_TestAppoints;
            ll_licensesManagement.Tag = _UserPermissions.Licenses;
            ll_licenseDetentionManagement.Tag = _UserPermissions.LicenseDetention;
            ll_dashboardAccess.Tag = _UserPermissions.Dashboard;
            ll_reportsAccess.Tag = _UserPermissions.Reports;
            ll_lookupTablesManagement.Tag = _UserPermissions.LookupTables;
            ll_applicationSettingsAccess.Tag = _UserPermissions.ApplicationSettings;

            cb_peopleManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.People);
            cb_usersManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.Users);
            cb_driversManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.Drivers);
            cb_localLicenseAppsManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.LocalLicenseApps);
            cb_interLicenseAppsManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.InterLicenseApps);
            cb_testsManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.Tests_TestAppoints);
            cb_licensesManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.Licenses);
            cb_licenseDetentionManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.LicenseDetention);
            cb_dashboardAccess.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.Dashboard);
            cb_reportsAccess.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.Reports);
            cb_lookupTablesManagement.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.LookupTables);
            cb_applicationSettingsAccess.SelectedIndex = _GetCorrespondingSelectedIndex((short) _UserPermissions.ApplicationSettings);
        }

        private int _GetCorrespondingSelectedIndex(int permissions) {
            switch (permissions) {
                case -1: return 0; //Full Access
                case 0: return 1; //No Access
                default: return 2; //Custom Settings
            }
        }

        private static int _GetPermissionsValue(SalDropDownList cb, LinkLabel ll) {
            switch (cb.SelectedIndex) {
                case 0: return -1; //Full Access
                case 1: return 0; //No Access
                default: return Convert.ToInt32(ll.Tag); //Custom Settings
            }
        }

        private void cb_peopleManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_peopleManagement.Enabled = cb_peopleManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.People = (PeopleManagement) _GetPermissionsValue(cb_peopleManagement, ll_peopleManagement);
        }

        private void cb_usersManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_usersManagement.Enabled = cb_usersManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.Users = (UsersManagement) _GetPermissionsValue(cb_usersManagement, ll_usersManagement);
        }

        private void cb_driversManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_driversManagement.Enabled = cb_driversManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.Drivers = (DriversManagement) _GetPermissionsValue(cb_driversManagement, ll_driversManagement);
        }

        private void cb_localLicenseAppsManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_localLicenseAppsManagement.Enabled = cb_localLicenseAppsManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.LocalLicenseApps = (LocalLicenseAppsManagement) _GetPermissionsValue(cb_localLicenseAppsManagement, ll_localLicenseAppsManagement);
        }

        private void cb_interLicenseAppsManagement_SelectedIndexChanged_1(object sender, EventArgs e) {
            ll_interLicenseAppsManagement.Enabled = cb_interLicenseAppsManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.InterLicenseApps = (InterLicenseAppsManagement) _GetPermissionsValue(cb_interLicenseAppsManagement, ll_interLicenseAppsManagement);
        }

        private void cb_testsManagement_SelectedIndexChanged(object sender, EventArgs e){ 
            ll_testsManagement.Enabled = cb_testsManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.Tests_TestAppoints = (Tests_TestAppointsManagement) _GetPermissionsValue(cb_testsManagement, ll_testsManagement);
        }

        private void cb_licensesManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_licensesManagement.Enabled = cb_licensesManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.Licenses = (LicensesManagement) _GetPermissionsValue(cb_licensesManagement, ll_licensesManagement);
        }

        private void cb_licenseDetentionManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_licenseDetentionManagement.Enabled = cb_licenseDetentionManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.LicenseDetention = (LicenseDetentionManagement) _GetPermissionsValue(cb_licenseDetentionManagement, ll_licenseDetentionManagement);
        }

        private void cb_dashboardAccess_SelectedIndexChanged(object sender, EventArgs e) {
            ll_dashboardAccess.Enabled = cb_dashboardAccess.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.Dashboard = (DashboardAccess) _GetPermissionsValue(cb_dashboardAccess, ll_dashboardAccess);
        }

        private void cb_reportsAccess_SelectedIndexChanged(object sender, EventArgs e) { 
            ll_reportsAccess.Enabled = cb_reportsAccess.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.Reports = (ReportsAccess) _GetPermissionsValue(cb_reportsAccess, ll_reportsAccess);
        }

        private void cb_lookupTablesManagement_SelectedIndexChanged(object sender, EventArgs e) {
            ll_lookupTablesManagement.Enabled = cb_lookupTablesManagement.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.LookupTables = (LookupTablesManagement) _GetPermissionsValue(cb_lookupTablesManagement, ll_lookupTablesManagement);
        }

        private void cb_applicationSettingsAccess_SelectedIndexChanged(object sender, EventArgs e) {
            ll_applicationSettingsAccess.Enabled = cb_applicationSettingsAccess.SelectedIndex == 2;

            if (_ActiveMode == Modes.Update)
                _UserPermissions.ApplicationSettings = (ApplicationSettingsAccess) _GetPermissionsValue(cb_applicationSettingsAccess, ll_applicationSettingsAccess);
        }

        private void ll_peopleManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmPeopleManagement = new Frm_PeopleManagement((PeopleManagement) ll_peopleManagement.Tag))
                if (_frmPeopleManagement.ShowDialog() == DialogResult.OK) {
                    ll_peopleManagement.Tag = _frmPeopleManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.People = _frmPeopleManagement.SelectedPermissions;
                }
        }

        private void ll_usersManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmUserManagement = new Frm_UsersManagement((UsersManagement) ll_usersManagement.Tag))
                if (_frmUserManagement.ShowDialog() == DialogResult.OK) {
                    ll_usersManagement.Tag = _frmUserManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.Users = _frmUserManagement.SelectedPermissions;
                }
        }

        private void ll_driversManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmDriversManagement = new Frm_DriversManagement((DriversManagement) ll_driversManagement.Tag))
                if (_frmDriversManagement.ShowDialog() == DialogResult.OK) {
                    ll_driversManagement.Tag = _frmDriversManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.Drivers = _frmDriversManagement.SelectedPermissions;
                }
        }

        private void ll_localLicenseAppsManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmLocalLicenseAppsManagement = new Frm_LocalLicenseAppsManagement((LocalLicenseAppsManagement) ll_localLicenseAppsManagement.Tag))
                if (_frmLocalLicenseAppsManagement.ShowDialog() == DialogResult.OK) {
                    ll_localLicenseAppsManagement.Tag = _frmLocalLicenseAppsManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.LocalLicenseApps = _frmLocalLicenseAppsManagement.SelectedPermissions;
                }
        }

        private void ll_interLicenseAppsManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmInterLicenseAppsManagement = new Frm_InterLicenseAppsManagement((InterLicenseAppsManagement) ll_interLicenseAppsManagement.Tag))
                if (_frmInterLicenseAppsManagement.ShowDialog() == DialogResult.OK) {
                    ll_interLicenseAppsManagement.Tag = _frmInterLicenseAppsManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.InterLicenseApps = _frmInterLicenseAppsManagement.SelectedPermissions;
                }
        }

        private void ll_testsManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmTestsManagement = new Frm_TestsManagement((Tests_TestAppointsManagement) ll_testsManagement.Tag))
                if (_frmTestsManagement.ShowDialog() == DialogResult.OK) {
                    ll_testsManagement.Tag = _frmTestsManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.Tests_TestAppoints = _frmTestsManagement.SelectedPermissions;
                }
        }

        private void ll_licensesManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmLicensesManagement = new Frm_LicensesManagement((LicensesManagement) ll_licensesManagement.Tag))
                if (_frmLicensesManagement.ShowDialog() == DialogResult.OK) {
                    ll_licensesManagement.Tag = _frmLicensesManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.Licenses = _frmLicensesManagement.SelectedPermissions;
                }
        }

        private void ll_licenseDetentionManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmLicenseDetentionManagement = new Frm_LicenseDetentionManagement((LicenseDetentionManagement) ll_licenseDetentionManagement.Tag)) 
                if (_frmLicenseDetentionManagement.ShowDialog() == DialogResult.OK) {
                    ll_licenseDetentionManagement.Tag = _frmLicenseDetentionManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.LicenseDetention = _frmLicenseDetentionManagement.SelectedPermissions;
                }
        }

        private void ll_dashboardAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmDashboardAccess = new Frm_DashboardAccess((DashboardAccess) ll_dashboardAccess.Tag))
                if (_frmDashboardAccess.ShowDialog() == DialogResult.OK) {
                    ll_dashboardAccess.Tag = _frmDashboardAccess.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.Dashboard = _frmDashboardAccess.SelectedPermissions;
                }
        }

        private void ll_reportsAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmReportsAccess = new Frm_ReportsAccess((ReportsAccess) ll_reportsAccess.Tag))
                if (_frmReportsAccess.ShowDialog() == DialogResult.OK) {
                    ll_reportsAccess.Tag = _frmReportsAccess.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.Reports = _frmReportsAccess.SelectedPermissions;
                }
        }

        private void ll_lookupTablesManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmLookupTablesManagement = new Frm_LookupTablesManagement((LookupTablesManagement) ll_lookupTablesManagement.Tag))
                if (_frmLookupTablesManagement.ShowDialog() == DialogResult.OK) {
                    ll_lookupTablesManagement.Tag = _frmLookupTablesManagement.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.LookupTables = _frmLookupTablesManagement.SelectedPermissions;
                }
        }

        private void ll_applicationSettingsAccess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmApplicationSettingsAccess = new Frm_ApplicationSettingsAccess((ApplicationSettingsAccess) ll_applicationSettingsAccess.Tag))
                if (_frmApplicationSettingsAccess.ShowDialog() == DialogResult.OK) {
                    ll_applicationSettingsAccess.Tag = _frmApplicationSettingsAccess.SelectedPermissions;

                    if (_ActiveMode == Modes.Update)
                        _UserPermissions.ApplicationSettings = _frmApplicationSettingsAccess.SelectedPermissions;
                }
        }

        /// <summary>
        /// This method is only called in UpdateMode
        /// </summary>
        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            ctrl_PersonCardWithFilter1.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            pnl_permissions.Enabled = permissions.Users.HasFlag(UsersManagement.ChangeUserPermissions) && permissions.Users.HasFlag(UsersManagement.SeeUserPermissions);
            lbl_username.Enabled = txt_username.Enabled = _User.UserID == GlobalFields.ActiveUserID || permissions.Users.HasFlag(UsersManagement.EditUsername);
            chk_isActive.Enabled = permissions.Users.HasFlag(UsersManagement.Activate_DeactiveUsers);
            pnl_loginInfoFields.Enabled = permissions.Users.HasFlag(UsersManagement.EditUsername) || permissions.Users.HasFlag(UsersManagement.Activate_DeactiveUsers);
            btn_save.Enabled = permissions.Users.HasFlag(UsersManagement.EditUsername) || permissions.Users.HasFlag(UsersManagement.Activate_DeactiveUsers) || permissions.Users.HasFlag(UsersManagement.ChangeUserPermissions);
        }
    }
}
