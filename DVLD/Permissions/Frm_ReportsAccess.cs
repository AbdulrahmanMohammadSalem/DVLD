using Salem.Controls;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_ReportsAccess : SalForm {
        public ReportsAccess SelectedPermissions { get; private set; } = ReportsAccess.NoAccess;

        public Frm_ReportsAccess(ReportsAccess startupValues) {
            InitializeComponent();

            chk_PersonHistoryReport.Checked = startupValues.HasFlag(ReportsAccess.PersonHistoryReport);
            chk_localLicenseAppDetailsReport.Checked = startupValues.HasFlag(ReportsAccess.LocalLicenseApplicationDetailsReport);
            chk_driverProfileReport.Checked = startupValues.HasFlag(ReportsAccess.DriverProfileReport);
            chk_testAttemptsReport.Checked = startupValues.HasFlag(ReportsAccess.TestAttemptsReport);
            chk_licenseDetentionReport.Checked = startupValues.HasFlag(ReportsAccess.LicenseDetentionReport);
            chk_userActivityReport.Checked = startupValues.HasFlag(ReportsAccess.UserActivityReport);
        }

        private void chk_PersonHistoryReport_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_PersonHistoryReport.Checked)
                SelectedPermissions |= ReportsAccess.PersonHistoryReport;
            else
                SelectedPermissions &= ~ReportsAccess.PersonHistoryReport;
        }

        private void chk_localLicenseAppDetailsReport_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_localLicenseAppDetailsReport.Checked)
                SelectedPermissions |= ReportsAccess.LocalLicenseApplicationDetailsReport;
            else
                SelectedPermissions &= ~ReportsAccess.LocalLicenseApplicationDetailsReport;
        }

        private void chk_driverProfileReport_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_driverProfileReport.Checked)
                SelectedPermissions |= ReportsAccess.DriverProfileReport;
            else
                SelectedPermissions &= ~ReportsAccess.DriverProfileReport;
        }

        private void chk_testAttemptsReport_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_testAttemptsReport.Checked)
                SelectedPermissions |= ReportsAccess.TestAttemptsReport;
            else
                SelectedPermissions &= ~ReportsAccess.TestAttemptsReport;
        }

        private void chk_licenseDetentionReport_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_licenseDetentionReport.Checked)
                SelectedPermissions |= ReportsAccess.LicenseDetentionReport;
            else
                SelectedPermissions &= ~ReportsAccess.LicenseDetentionReport;
        }

        private void chk_userActivityReport_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_userActivityReport.Checked)
                SelectedPermissions |= ReportsAccess.UserActivityReport;
            else
                SelectedPermissions &= ~ReportsAccess.UserActivityReport;
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
