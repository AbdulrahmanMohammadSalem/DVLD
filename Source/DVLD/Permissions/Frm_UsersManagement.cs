using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_UsersManagement : SalForm {
        public UsersManagement SelectedPermissions { get; private set; } = UsersManagement.NoAccess;

        public Frm_UsersManagement(UsersManagement startupValues) {
            InitializeComponent();

            chk_seeAllUsers.Checked = startupValues.HasFlag(UsersManagement.SeeAllUsers);
            chk_addNewUser.Checked = startupValues.HasFlag(UsersManagement.AddNewUser);
            chk_editUsername.Checked = startupValues.HasFlag(UsersManagement.EditUsername);
            chk_activateDeactivateUsers.Checked = startupValues.HasFlag(UsersManagement.Activate_DeactiveUsers);
            chk_changeUserPassword.Checked = startupValues.HasFlag(UsersManagement.ChangeUserPassword);
            chk_seeUserPermissions.Checked = startupValues.HasFlag(UsersManagement.SeeUserPermissions);
            chk_changeUserPermissions.Checked = startupValues.HasFlag(UsersManagement.ChangeUserPermissions);
            chk_deleteUser.Checked = startupValues.HasFlag(UsersManagement.DeleteUser);
            chk_exportUsersData.Checked = startupValues.HasFlag(UsersManagement.ExportUsersData);
        }

        private void chk_viewAllUsers_CheckedChanged(object sender, EventArgs e) {
            if (chk_seeAllUsers.Checked)
                SelectedPermissions |= UsersManagement.SeeAllUsers;
            else
                SelectedPermissions &= ~UsersManagement.SeeAllUsers;
        }

        private void chk_addNewUser_CheckedChanged(object sender, EventArgs e) {
            if (chk_addNewUser.Checked)
                SelectedPermissions |= UsersManagement.AddNewUser;
            else
                SelectedPermissions &= ~UsersManagement.AddNewUser;
        }

        private void chk_editUsername_CheckedChanged(object sender, EventArgs e) {
            if (chk_editUsername.Checked)
                SelectedPermissions |= UsersManagement.EditUsername;
            else
                SelectedPermissions &= ~UsersManagement.EditUsername;
        }

        private void chk_activateDeactivateUsers_CheckedChanged(object sender, EventArgs e) {
            if (chk_activateDeactivateUsers.Checked)
                SelectedPermissions |= UsersManagement.Activate_DeactiveUsers;
            else
                SelectedPermissions &= ~UsersManagement.Activate_DeactiveUsers;
        }

        private void chk_changeUserPassword_CheckedChanged(object sender, EventArgs e) {
            if (chk_changeUserPassword.Checked)
                SelectedPermissions |= UsersManagement.ChangeUserPassword;
            else
                SelectedPermissions &= ~UsersManagement.ChangeUserPassword;
        }

        private void chk_seeUserPermissions_CheckedChanged(object sender, EventArgs e) {
            if (chk_seeUserPermissions.Checked)
                SelectedPermissions |= UsersManagement.SeeUserPermissions;
            else
                SelectedPermissions &= ~UsersManagement.SeeUserPermissions;
        }

        private void chk_changeUserPermissions_CheckedChanged(object sender, EventArgs e) {
            if (chk_changeUserPermissions.Checked)
                SelectedPermissions |= UsersManagement.ChangeUserPermissions;
            else
                SelectedPermissions &= ~UsersManagement.ChangeUserPermissions;
        }

        private void chk_deleteUser_CheckedChanged(object sender, EventArgs e) {
            if (chk_deleteUser.Checked)
                SelectedPermissions |= UsersManagement.DeleteUser;
            else
                SelectedPermissions &= ~UsersManagement.DeleteUser;
        }

        private void chk_exportUsersData_CheckedChanged(object sender, EventArgs e) {
            if (chk_exportUsersData.Checked)
                SelectedPermissions |= UsersManagement.ExportUsersData;
            else
                SelectedPermissions &= ~UsersManagement.ExportUsersData;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
