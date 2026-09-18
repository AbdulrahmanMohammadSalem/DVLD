using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_ApplicationSettingsAccess : SalForm {
        public ApplicationSettingsAccess SelectedPermissions { get; private set; } = ApplicationSettingsAccess.NoAccess;

        public Frm_ApplicationSettingsAccess(ApplicationSettingsAccess startupValues) {
            InitializeComponent();

            chk_changeLanguage.Checked = startupValues.HasFlag(ApplicationSettingsAccess.ChangeLanguage);
            chk_changeColorMode.Checked = startupValues.HasFlag(ApplicationSettingsAccess.ChangeColorMode);
            chk_changeTheme.Checked = startupValues.HasFlag(ApplicationSettingsAccess.ChangeTheme);
            chk_createNewTheme.Checked = startupValues.HasFlag(ApplicationSettingsAccess.CreateNewTheme);
            chk_editThemeValues.Checked = startupValues.HasFlag(ApplicationSettingsAccess.EditThemeValues);
            chk_renameTheme.Checked = startupValues.HasFlag(ApplicationSettingsAccess.RenameTheme);
            chk_deleteTheme.Checked = startupValues.HasFlag(ApplicationSettingsAccess.DeleteTheme);
        }

        private void chk_changeLanguage_CheckedChanged(object sender, EventArgs e) {
            if (chk_changeLanguage.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.ChangeLanguage;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.ChangeLanguage;
        }

        private void chk_changeColorMode_CheckedChanged(object sender, EventArgs e) {
            if (chk_changeColorMode.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.ChangeColorMode;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.ChangeColorMode;
        }

        private void chk_changeTheme_CheckedChanged(object sender, EventArgs e) {
            if (chk_changeTheme.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.ChangeTheme;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.ChangeTheme;
        }

        private void chk_createNewTheme_CheckedChanged(object sender, EventArgs e) {
            if (chk_createNewTheme.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.CreateNewTheme;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.CreateNewTheme;
        }

        private void chk_editThemeValues_CheckedChanged(object sender, EventArgs e) {
            if (chk_editThemeValues.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.EditThemeValues;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.EditThemeValues;
        }

        private void chk_renameTheme_CheckedChanged(object sender, EventArgs e) {
            if (chk_renameTheme.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.RenameTheme;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.RenameTheme;
        }

        private void chk_deleteTheme_CheckedChanged(object sender, EventArgs e) {
            if (chk_deleteTheme.Checked)
                SelectedPermissions |= ApplicationSettingsAccess.DeleteTheme;
            else
                SelectedPermissions &= ~ApplicationSettingsAccess.DeleteTheme;
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
