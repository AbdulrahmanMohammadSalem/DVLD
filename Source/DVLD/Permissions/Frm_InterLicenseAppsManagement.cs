using Salem.Controls;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_InterLicenseAppsManagement : SalForm {
        public InterLicenseAppsManagement SelectedPermissions { get; private set; } = InterLicenseAppsManagement.NoAccess;

        public Frm_InterLicenseAppsManagement(InterLicenseAppsManagement startupValues) {
            InitializeComponent();

            chk_seeAllInterLicenseApps.Checked = startupValues.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps);
            chk_createNewInterLicenseApp.Checked = startupValues.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense);
            chk_exportInterLicenseAppsData.Checked = startupValues.HasFlag(InterLicenseAppsManagement.ExportInterLicenseAppsData);
        }

        private void chk_seeAllInterLicenseApps_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_seeAllInterLicenseApps.Checked)
                SelectedPermissions |= InterLicenseAppsManagement.SeeAllInterLicenseApps;
            else
                SelectedPermissions &= ~InterLicenseAppsManagement.SeeAllInterLicenseApps;
        }

        private void chk_createNewInterLicenseApp_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_createNewInterLicenseApp.Checked)
                SelectedPermissions |= InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense;
            else
                SelectedPermissions &= ~InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense;
        }

        private void chk_exportInterLicenseAppsData_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_exportInterLicenseAppsData.Checked)
                SelectedPermissions |= InterLicenseAppsManagement.ExportInterLicenseAppsData;
            else
                SelectedPermissions &= ~InterLicenseAppsManagement.ExportInterLicenseAppsData;
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
