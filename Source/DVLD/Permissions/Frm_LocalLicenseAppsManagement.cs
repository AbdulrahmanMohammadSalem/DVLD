using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_LocalLicenseAppsManagement : SalForm {
        public LocalLicenseAppsManagement SelectedPermissions { get; private set; } = LocalLicenseAppsManagement.NoAccess;

        public Frm_LocalLicenseAppsManagement(LocalLicenseAppsManagement startupValues) {
            InitializeComponent();

            chk_seeAllLocalLicenseApps.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps);
            chk_createNewLocalLicenseApp.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.CreateNewLocalLicenseApp);
            chk_viewFullAppDetails.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails);
            chk_exportLocalLicenseAppsData.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.ExportLocalLicenseAppsData);
            chk_editAppInfo.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.EditAppInfo);
            chk_deleteApp.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.DeleteApp);
            chk_cancelApp.Checked = startupValues.HasFlag(LocalLicenseAppsManagement.CancelApp);
        }

        private void chk_seeAllLocalLicenseApps_CheckedChanged(object sender, EventArgs e) {
            if (chk_seeAllLocalLicenseApps.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.SeeAllLocalLicenseApps;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.SeeAllLocalLicenseApps;
        }

        private void chk_createNewLocalLicenseApp_CheckedChanged(object sender, EventArgs e) {
            if (chk_createNewLocalLicenseApp.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.CreateNewLocalLicenseApp;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.CreateNewLocalLicenseApp;
        }

        private void chk_viewFullAppDetails_CheckedChanged(object sender, EventArgs e) {
            if (chk_viewFullAppDetails.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.ViewFullAppDetails;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.ViewFullAppDetails;
        }

        private void chk_exportLocalLicenseAppsData_CheckedChanged(object sender, EventArgs e) {
            if (chk_exportLocalLicenseAppsData.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.ExportLocalLicenseAppsData;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.ExportLocalLicenseAppsData;
        }

        private void chk_editAppInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_editAppInfo.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.EditAppInfo;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.EditAppInfo;
        }

        private void chk_deleteApp_CheckedChanged(object sender, EventArgs e) {
            if (chk_deleteApp.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.DeleteApp;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.DeleteApp;
        }

        private void chk_cancelApp_CheckedChanged(object sender, EventArgs e) {
            if (chk_cancelApp.Checked)
                SelectedPermissions |= LocalLicenseAppsManagement.CancelApp;
            else
                SelectedPermissions &= ~LocalLicenseAppsManagement.CancelApp;
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
