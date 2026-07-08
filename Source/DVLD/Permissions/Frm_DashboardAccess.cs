using Salem.Controls;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_DashboardAccess : SalForm {
        public DashboardAccess SelectedPermissions { get; private set; } = DashboardAccess.NoAccess;

        public Frm_DashboardAccess(DashboardAccess startupValues) {
            InitializeComponent();

            chk_totalAppsOverTime.Checked = startupValues.HasFlag(DashboardAccess.TotalApplicationsOverTime);
            chk_localLicenseAppsStatus.Checked = startupValues.HasFlag(DashboardAccess.LocalLicenseApplicationsStatus);
            chk_testAppointsLoad.Checked = startupValues.HasFlag(DashboardAccess.TestAppointmentsLoad);
            chk_testResultsRates.Checked = startupValues.HasFlag(DashboardAccess.TestResultsRates_AverageAttemptsToPass);
            chk_revenueByServiceType.Checked = startupValues.HasFlag(DashboardAccess.RevenueByServiceType);
            chk_revenueByTestType.Checked = startupValues.HasFlag(DashboardAccess.RevenueByTestType);
            chk_revenueByLicenseClass.Checked = startupValues.HasFlag(DashboardAccess.RevenueByLicenseClass);
            chk_licenseDetentionFineFees.Checked = startupValues.HasFlag(DashboardAccess.LicenseDetentionFineFees);
            chk_systemWideRevenue.Checked = startupValues.HasFlag(DashboardAccess.SystemWideRevenue);
        }

        private void chk_totalAppsOverTime_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_totalAppsOverTime.Checked)
                SelectedPermissions |= DashboardAccess.TotalApplicationsOverTime;
            else
                SelectedPermissions &= ~DashboardAccess.TotalApplicationsOverTime;
        }

        private void chk_localLicenseAppsStatus_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_localLicenseAppsStatus.Checked)
                SelectedPermissions |= DashboardAccess.LocalLicenseApplicationsStatus;
            else
                SelectedPermissions &= ~DashboardAccess.LocalLicenseApplicationsStatus;
        }

        private void chk_testAppointsLoad_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_testAppointsLoad.Checked)
                SelectedPermissions |= DashboardAccess.TestAppointmentsLoad;
            else
                SelectedPermissions &= ~DashboardAccess.TestAppointmentsLoad;
        }

        private void chk_testResultsRates_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_testResultsRates.Checked)
                SelectedPermissions |= DashboardAccess.TestResultsRates_AverageAttemptsToPass;
            else
                SelectedPermissions &= ~DashboardAccess.TestResultsRates_AverageAttemptsToPass;
        }

        private void chk_revenueByServiceType_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_revenueByServiceType.Checked)
                SelectedPermissions |= DashboardAccess.RevenueByServiceType;
            else
                SelectedPermissions &= ~DashboardAccess.RevenueByServiceType;
        }

        private void chk_revenueByTestType_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_revenueByTestType.Checked)
                SelectedPermissions |= DashboardAccess.RevenueByTestType;
            else
                SelectedPermissions &= ~DashboardAccess.RevenueByTestType;
        }

        private void chk_revenueByLicenseClass_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_revenueByLicenseClass.Checked)
                SelectedPermissions |= DashboardAccess.RevenueByLicenseClass;
            else
                SelectedPermissions &= ~DashboardAccess.RevenueByLicenseClass;
        }

        private void chk_licenseDetentionFineFees_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_licenseDetentionFineFees.Checked)
                SelectedPermissions |= DashboardAccess.LicenseDetentionFineFees;
            else
                SelectedPermissions &= ~DashboardAccess.LicenseDetentionFineFees;
        }

        private void chk_systemWideRevenue_CheckedChanged(object sender, System.EventArgs e) {
            if (chk_systemWideRevenue.Checked)
                SelectedPermissions |= DashboardAccess.SystemWideRevenue;
            else
                SelectedPermissions &= ~DashboardAccess.SystemWideRevenue;
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
