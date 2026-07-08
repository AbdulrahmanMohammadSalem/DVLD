using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Analytics.Dashboard {
    public partial class Layout_Dashboard : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private Form _parentForm;

        public Layout_Dashboard() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            foreach (UserControl ctrlChrt in flowLayoutPanel1.Controls)
                ctrlChrt.BackColor = Settings.Default.SurfaceBackColor;
        }

        public void RefreshDataFiltering() {
            foreach (ICtrlChart ctrlChrt in flowLayoutPanel1.Controls)
                ctrlChrt.RefreshDataFiltering();
        }

        public void ReloadAllData() {
            foreach (ICtrlChart ctrlChrt in flowLayoutPanel1.Controls)
                ctrlChrt.RefreshChart();
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void Layout_Dashboard_Resize(object sender, EventArgs e) {
            if (_parentForm != null && _parentForm.WindowState == FormWindowState.Maximized) {
                flowLayoutPanel1.AutoScroll = false;
                flowLayoutPanel1.AutoScroll = true;
            }
        }

        private void Layout_Dashboard_Load(object sender, EventArgs e) => _parentForm = FindForm();

        private void ctrlChart_ForceExit() => OnForceExit();

        private void ctrlChart_DataSaved() => ReloadAllData();

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            ctrlChart_TotalApplicationsWithTime1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.TotalApplicationsOverTime);
            ctrlChart_NewLocalLicenseAppStatus1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.LocalLicenseApplicationsStatus);
            ctrlChart_TestAppointmentsLoad1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.TestAppointmentsLoad);
            ctrlChart_TestTypesPassRates1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.TestResultsRates_AverageAttemptsToPass);
            ctrlChart_RevenueByServiceType1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.RevenueByServiceType);
            ctrlChart_RevenueByTestType1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.RevenueByTestType);
            ctrlChart_RevenueByLicenseClass1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.RevenueByLicenseClass);
            ctrlChart_LicenseDetentionFineFees1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.LicenseDetentionFineFees);
            ctrl_SystemWideRevenue1.Enabled = permissions.Dashboard.HasFlag(DashboardAccess.SystemWideRevenue);
        }
    }
}
