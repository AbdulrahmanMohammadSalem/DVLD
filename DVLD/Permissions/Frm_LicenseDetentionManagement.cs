using Salem.Controls;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_LicenseDetentionManagement : SalForm {
        public LicenseDetentionManagement SelectedPermissions { get; private set; } = LicenseDetentionManagement.NoAccess;

        public Frm_LicenseDetentionManagement(LicenseDetentionManagement startupValues) {
            InitializeComponent();

            chk_viewAllDetainedLicenses.Checked = startupValues.HasFlag(LicenseDetentionManagement.ViewAllDetainedLicenses);
            chk_detainLicense.Checked = startupValues.HasFlag(LicenseDetentionManagement.DetainLicense);
            chk_releaseDetainedLicense.Checked = startupValues.HasFlag(LicenseDetentionManagement.ReleaseDetainedLicense);
            chk_exportLicenseDetentionsData.Checked = startupValues.HasFlag(LicenseDetentionManagement.ExportDetainedLicensesData);
        }

        private void chk_viewAllDetainedLicenses_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_viewAllDetainedLicenses.Checked)
                SelectedPermissions |= LicenseDetentionManagement.ViewAllDetainedLicenses;
            else
                SelectedPermissions &= ~LicenseDetentionManagement.ViewAllDetainedLicenses;
        }

        private void chk_detainLicense_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_detainLicense.Checked)
                SelectedPermissions |= LicenseDetentionManagement.DetainLicense;
            else
                SelectedPermissions &= ~LicenseDetentionManagement.DetainLicense;
        }

        private void chk_releaseDetainedLicense_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_releaseDetainedLicense.Checked)
                SelectedPermissions |= LicenseDetentionManagement.ReleaseDetainedLicense;
            else
                SelectedPermissions &= ~LicenseDetentionManagement.ReleaseDetainedLicense;
        }

        private void chk_exportLicenseDetentionsData_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_exportLicenseDetentionsData.Checked)
                SelectedPermissions |= LicenseDetentionManagement.ExportDetainedLicensesData;
            else
                SelectedPermissions &= ~LicenseDetentionManagement.ExportDetainedLicensesData;
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
