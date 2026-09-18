using Salem.Controls;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_LicensesManagement : SalForm {
        public LicensesManagement SelectedPermissions { get; private set; } = LicensesManagement.NoAccess;

        public Frm_LicensesManagement(LicensesManagement startupValues) {
            InitializeComponent();

            chk_viewAllLocalLicenses.Checked = startupValues.HasFlag(LicensesManagement.ViewAllLocalLicenses);
            chk_issueLocalLicenseFirstTime.Checked = startupValues.HasFlag(LicensesManagement.IssueLocalLicenseFirstTime);
            chk_issueLicenseReplacement.Checked = startupValues.HasFlag(LicensesManagement.IssueLicenseReplacement);
            chk_renewLicense.Checked = startupValues.HasFlag(LicensesManagement.RenewLicense);
            chk_showFullLocalLicenseInfo.Checked = startupValues.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            chk_exportLocalLicensesData.Checked = startupValues.HasFlag(LicensesManagement.ExportLocalLicensesData);

            chk_viewAllInterLicenses.Checked = startupValues.HasFlag(LicensesManagement.ViewAllInterLicenses);
            chk_showFullInterLicenseInfo.Checked = startupValues.HasFlag(LicensesManagement.ShowFullInterLicenseInfo);
            chk_exportInterLicensesData.Checked = startupValues.HasFlag(LicensesManagement.ExportInterLicensesData);
        }

        private void chk_viewAllLocalLicenses_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_viewAllLocalLicenses.Checked)
                SelectedPermissions |= LicensesManagement.ViewAllLocalLicenses;
            else
                SelectedPermissions &= ~LicensesManagement.ViewAllLocalLicenses;
        }

        private void chk_issueLocalLicenseFirstTime_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_issueLocalLicenseFirstTime.Checked)
                SelectedPermissions |= LicensesManagement.IssueLocalLicenseFirstTime;
            else
                SelectedPermissions &= ~LicensesManagement.IssueLocalLicenseFirstTime;
        }

        private void chk_issueLicenseReplacement_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_issueLicenseReplacement.Checked)
                SelectedPermissions |= LicensesManagement.IssueLicenseReplacement;
            else
                SelectedPermissions &= ~LicensesManagement.IssueLicenseReplacement;
        }

        private void chk_renewLicense_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_renewLicense.Checked)
                SelectedPermissions |= LicensesManagement.RenewLicense;
            else
                SelectedPermissions &= ~LicensesManagement.RenewLicense;
        }

        private void chk_showFullLocalLicenseInfo_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_showFullLocalLicenseInfo.Checked)
                SelectedPermissions |= LicensesManagement.ShowFullLocalLicenseInfo;
            else
                SelectedPermissions &= ~LicensesManagement.ShowFullLocalLicenseInfo;
        }

        private void chk_exportLocalLicenseData_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_exportLocalLicensesData.Checked)
                SelectedPermissions |= LicensesManagement.ExportLocalLicensesData;
            else
                SelectedPermissions &= ~LicensesManagement.ExportLocalLicensesData;
        }

        private void chk_viewAllInterLicenses_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_viewAllInterLicenses.Checked)
                SelectedPermissions |= LicensesManagement.ViewAllInterLicenses;
            else
                SelectedPermissions &= ~LicensesManagement.ViewAllInterLicenses;
        }

        private void chk_showFullInterLicenseInfo_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_showFullInterLicenseInfo.Checked)
                SelectedPermissions |= LicensesManagement.ShowFullInterLicenseInfo;
            else
                SelectedPermissions &= ~LicensesManagement.ShowFullInterLicenseInfo;
        }

        private void chk_exportInterLicensesData_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_exportInterLicensesData.Checked)
                SelectedPermissions |= LicensesManagement.ExportInterLicensesData;
            else
                SelectedPermissions &= ~LicensesManagement.ExportInterLicensesData;
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
