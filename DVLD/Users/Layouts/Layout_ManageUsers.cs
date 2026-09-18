using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Users {
    public partial class Layout_ManageUsers : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private DataView _dvAllUsers;

        public Layout_ManageUsers() {
            InitializeComponent();
            _ProcessNoDataAvailableLabel(lbl_noDataAvailable);
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            cb_inputFilterBy.Items.AddRange(new string[3] { Resources.txt_all, Str_LayoutManageUsers.isActive_yes, Str_LayoutManageUsers.isActive_no });
            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_users);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            cb_inputFilterBy.Tag = false; //DigitsOnly = false
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_users); 

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        private enum FilterByOptions : byte {
            None, UserID, PersonID, FullName, Username, IsActive
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void Layout_ManageUsers_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.SeeAllUsers)) {
                cb_filterBy.SelectedIndex = 0;
                _dvAllUsers = User.GetAllUsers();
                dgv_users.DataSource = _dvAllUsers;
                lbl_numOfRows.Text = dgv_users.RowCount.ToString();
                lbl_noDataAvailable.Visible = dgv_users.RowCount == 0;

                _SetupTableHeader();
            }
        }

        private void _SetupTableHeader() {
            dgv_users.Columns["UserID"].HeaderText = Str_LayoutManageUsers.userID;
            dgv_users.Columns["UserID"].Width = 140;
            
            dgv_users.Columns["PersonID"].HeaderText = Str_LayoutManageUsers.personID;
            dgv_users.Columns["PersonID"].Width = 140;

            dgv_users.Columns["FullName"].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_users.Columns["FullName"].Width = 270;

            dgv_users.Columns["Username"].HeaderText = Str_LayoutManageUsers.username;
            dgv_users.Columns["Username"].Width = 160;

            dgv_users.Columns["IsActive"].HeaderText = Str_LayoutManageUsers.isActive;
        }

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_users.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter == FilterByOptions.UserID || _selectedFilter == FilterByOptions.PersonID) {
                if (!((bool) cb_inputFilterBy.Tag)) {
                    cb_inputFilterBy.KeyPress += ComboBox_digitsOnly_KeyPress;
                    cb_inputFilterBy.Tag = true;
                }
            } else if ((bool) cb_inputFilterBy.Tag) {
                cb_inputFilterBy.KeyPress -= ComboBox_digitsOnly_KeyPress;
                cb_inputFilterBy.Tag = false;
            }

            if (_selectedFilter == FilterByOptions.IsActive) {
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_inputFilterBy.SelectedIndex = 0;
            } else
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.Simple;

            cb_inputFilterBy.Visible = _selectedFilter != FilterByOptions.None;
            cb_inputFilterBy.Text = string.Empty; //_RefreshDataFiltering();
        }

        private void ComboBox_digitsOnly_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void ComboBox_inputFilterBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void button_addNewUser_Click(object sender, EventArgs e) => _AddNewUser();

        private void _AddNewUser() {
            using (Frm_AddEditUser _frmAddNewUser = new Frm_AddEditUser()) {
                _frmAddNewUser.DataSaved += _frm_UserSaved;
                _frmAddNewUser.ActiveUserPermissionsChanged += _frmAddNewUser_ActiveUserPermissionsChanged;
                _frmAddNewUser.ShowDialog();
                _frmAddNewUser.ActiveUserPermissionsChanged -= _frmAddNewUser_ActiveUserPermissionsChanged;
                _frmAddNewUser.DataSaved -= _frm_UserSaved;
            }
        }

        private void _frmAddNewUser_ActiveUserPermissionsChanged(DVLD_Business.Permissions newValues) {
            EnforcePermissions(newValues);
            Layout_ManageUsers_Load(this, EventArgs.Empty); //To re-display data if needed
            OnActiveUserPermissionsChanged(newValues);
        }

        private void _frm_UserSaved(int userID) {
            if (GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.SeeAllUsers))
                ReloadAllData();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e) => _AddNewUser();

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_AddEditUser _frmEditUser = new Frm_AddEditUser((int) dgv_users.CurrentRow.Cells[0].Value)) {
                if (_frmEditUser.IsDisposed) //In case the user was not found in the form -- It will become disposed of then
                    return;

                _frmEditUser.DataSaved += _frm_UserSaved;
                _frmEditUser.ActiveUserPermissionsChanged += _frmAddNewUser_ActiveUserPermissionsChanged;
                _frmEditUser.ShowDialog();
                _frmEditUser.ActiveUserPermissionsChanged -= _frmAddNewUser_ActiveUserPermissionsChanged;
                _frmEditUser.DataSaved -= _frm_UserSaved;

                if (_frmEditUser.ForceExit)
                    OnForceExit();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) =>
            _ShowCurrentRowDetails();

        private void _ShowCurrentRowDetails() {
            using (Frm_ShowUserInformation _frmShowUserInfo = new Frm_ShowUserInformation((int) dgv_users.CurrentRow.Cells[0].Value)) {
                if (_frmShowUserInfo.IsDisposed)
                    return;

                _frmShowUserInfo.UserSaved += _frm_UserSaved;
                _frmShowUserInfo.ShowDialog();
                _frmShowUserInfo.UserSaved -= _frm_UserSaved;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(Str_LayoutManageUsers.userDeleteConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                int _userID = (int) dgv_users.CurrentRow.Cells[0].Value;
                
                if (_userID == GlobalFields.ActiveUserID) {
                    if (MessageBox.Show(Str_LayoutManageUsers.deletingLoggedInUserConfirm, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                        if (User.Delete(_userID)) {
                            GlobalFields.LoginScreenMessageBoxInfo = (Str_LayoutManageUsers.userDeletedSuccessfully, Resources.msg_success);
                            OnForceExit();
                        }
                        else
                            MessageBox.Show(Str_LayoutManageUsers.userDeletingFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else if (User.Delete(_userID)) {
                    ReloadAllData();
                    MessageBox.Show(Str_LayoutManageUsers.userDeletedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Str_LayoutManageUsers.userDeletingFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadAllData() {
            _dvAllUsers = User.GetAllUsers();

            RefreshDataFiltering();
        }

        public void RefreshDataFiltering() {
            if (cb_inputFilterBy.Text == string.Empty || cb_filterBy.SelectedIndex == (int) FilterByOptions.None || (cb_filterBy.SelectedIndex == (int) FilterByOptions.IsActive && cb_inputFilterBy.SelectedIndex == 0))
                _dvAllUsers.RowFilter = string.Empty;
            else {
                FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

                if (_selectedFilter == FilterByOptions.UserID || _selectedFilter == FilterByOptions.PersonID)
                    _dvAllUsers.RowFilter = string.Format("{0} = {1}", _selectedFilter.ToString(), cb_inputFilterBy.Text);
                else if (_selectedFilter == FilterByOptions.IsActive)
                    _dvAllUsers.RowFilter = string.Format("IsActive = {0}", 2 - cb_inputFilterBy.SelectedIndex);
                else
                    _dvAllUsers.RowFilter = string.Format("{0} LIKE '%{1}%'", _selectedFilter.ToString(), cb_inputFilterBy.Text);
            }

            dgv_users.DataSource = _dvAllUsers;
            lbl_numOfRows.Text = dgv_users.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_users.RowCount == 0;
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) => Person.PhoneCall(dgv_users.CurrentRow.Cells["PhoneNumber"].Value.ToString());

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) => Person.SendEmail(dgv_users.CurrentRow.Cells["Email"].Value.ToString());

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e) => ReloadAllData();

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void dataGridView_displayUsersData_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { 
            if (GlobalFields.ActiveUserPermissions.People.HasFlag(DVLD_Business.Permissions.PeopleManagement.SeePersonalInfoCards))
                _ShowCurrentRowDetails();
        }

        private void changePasswordToolStripMenuItem4_Click(object sender, EventArgs e) {
            using (Frm_ChangeUserPassword _frmChangePassword = new Frm_ChangeUserPassword((int) dgv_users.CurrentRow.Cells[0].Value)) {
                if (_frmChangePassword.IsDisposed)
                    return;

                _frmChangePassword.UserSaved += _frm_UserSaved;
                _frmChangePassword.ShowDialog();
                _frmChangePassword.UserSaved -= _frm_UserSaved;
            }
        }

        private void dgv_users_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_users.Columns[e.ColumnIndex].Name == "IsActive") {
                if ((int) e.Value == 1) {
                    e.Value = Str_LayoutManageUsers.active;
                    e.CellStyle.ForeColor = Color.ForestGreen;
                } else {
                    e.Value = Str_LayoutManageUsers.notActive;
                    e.CellStyle.ForeColor = Color.Red;
                }
                
                e.FormattingApplied = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            showDetailsToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards) && dgv_users.SelectedCells.Count > 0;
            editToolStripMenuItem.Enabled = (GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards) || GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.ChangeUserPermissions) || GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.EditUsername) || GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.Activate_DeactiveUsers)) && dgv_users.SelectedCells.Count > 0;
            deleteToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.DeleteUser) && dgv_users.SelectedCells.Count > 0;
            changePasswordToolStripMenuItem4.Enabled = (int) dgv_users.CurrentRow.Cells["UserID"].Value == GlobalFields.ActiveUserID || GlobalFields.ActiveUserPermissions.Users.HasFlag(UsersManagement.ChangeUserPassword) && GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards) && dgv_users.SelectedCells.Count > 0;
            sendEmailToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SendEmail) && dgv_users.SelectedCells.Count > 0;
            phoneCallToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.PhoneCall) && dgv_users.SelectedCells.Count > 0;
        }

        private void comboBox_permissionsInput_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManageUsers.users, _dvAllUsers ?? User.GetAllUsers());

        private void _ProcessNoDataAvailableLabel(Label lbl) {
            lbl.AutoSize = false;
            lbl.Width = dgv_users.Width - 20;
            lbl.Location = new Point(dgv_users.Location.X + 10, lbl.Location.Y);
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_inputFilterBy.Enabled = dgv_users.Enabled = ll_refreshData.Enabled = refreshToolStripMenuItem1.Enabled = permissions.Users.HasFlag(UsersManagement.SeeAllUsers);

            if (dgv_users.DataSource != null && !permissions.Users.HasFlag(UsersManagement.SeeAllUsers)) {
                dgv_users.DataSource = null;
                lbl_noDataAvailable.Visible = true;
                lbl_numOfRows.Text = Resources.txt_unknownField;
            }

            showDetailsToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            btn_addNewUser.Enabled = addNewUserToolStripMenuItem.Enabled = permissions.Users.HasFlag(UsersManagement.AddNewUser);
            editToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards) || permissions.Users.HasFlag(UsersManagement.ChangeUserPermissions) || permissions.Users.HasFlag(UsersManagement.EditUsername) || permissions.Users.HasFlag(UsersManagement.Activate_DeactiveUsers);
            ll_exportData.Enabled = permissions.Users.HasFlag(UsersManagement.ExportUsersData);
            changePasswordToolStripMenuItem4.Enabled = permissions.Users.HasFlag(UsersManagement.ChangeUserPassword) && permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            deleteToolStripMenuItem.Enabled = permissions.Users.HasFlag(UsersManagement.DeleteUser);
            sendEmailToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SendEmail);
            phoneCallToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.PhoneCall);

            lbl_noDataAvailable.Text = permissions.Users.HasFlag(UsersManagement.SeeAllUsers) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
