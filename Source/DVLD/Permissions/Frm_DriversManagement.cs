using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_DriversManagement : SalForm {
        public DriversManagement SelectedPermissions { get; private set; } = DriversManagement.NoAccess;

        public Frm_DriversManagement(DriversManagement startupValues) {
            InitializeComponent();

            chk_seeAllDrivers.Checked = startupValues.HasFlag(DriversManagement.SeeAllDrivers);
            chk_exportDriversData.Checked = startupValues.HasFlag(DriversManagement.ExportDriversData);

            chk_visionTests.Checked = startupValues.HasFlag(DriversManagement.ShowDriverTestsHistory_Vision);
            chk_writtenTests.Checked = startupValues.HasFlag(DriversManagement.ShowDriverTestsHistory_Written);
            chk_drivingTests.Checked = startupValues.HasFlag(DriversManagement.ShowDriverTestsHistory_Driving);

            chk_localLicenses.Checked = startupValues.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local);
            chk_interLicenses.Checked = startupValues.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
        }

        private void chk_seeAllDrivers_CheckedChanged(object sender, EventArgs e) {
            if (chk_seeAllDrivers.Checked)
                SelectedPermissions |= DriversManagement.SeeAllDrivers;
            else
                SelectedPermissions &= ~DriversManagement.SeeAllDrivers;
        }

        private void chk_exportDriversData_CheckedChanged(object sender, EventArgs e) {
            if (chk_exportDriversData.Checked)
                SelectedPermissions |= DriversManagement.ExportDriversData;
            else
                SelectedPermissions &= ~DriversManagement.ExportDriversData;
        }

        private void chk_visionTests_CheckedChanged(object sender, EventArgs e) {
            if (chk_visionTests.Checked)
                SelectedPermissions |= DriversManagement.ShowDriverTestsHistory_Vision;
            else
                SelectedPermissions &= ~DriversManagement.ShowDriverTestsHistory_Vision;
        }

        private void chk_writtenTests_CheckedChanged(object sender, EventArgs e) {
            if (chk_writtenTests.Checked)
                SelectedPermissions |= DriversManagement.ShowDriverTestsHistory_Written;
            else
                SelectedPermissions &= ~DriversManagement.ShowDriverTestsHistory_Written;
        }

        private void chk_drivingTests_CheckedChanged(object sender, EventArgs e) {
            if (chk_drivingTests.Checked)
                SelectedPermissions |= DriversManagement.ShowDriverTestsHistory_Driving;
            else
                SelectedPermissions &= ~DriversManagement.ShowDriverTestsHistory_Driving;
        }

        private void chk_localLicenses_CheckedChanged(object sender, EventArgs e) {
            if (chk_localLicenses.Checked)
                SelectedPermissions |= DriversManagement.ShowDriverLicenseHistory_Local;
            else
                SelectedPermissions &= ~DriversManagement.ShowDriverLicenseHistory_Local;
        }

        private void chk_interLicenses_CheckedChanged(object sender, EventArgs e) {
            if (chk_interLicenses.Checked)
                SelectedPermissions |= DriversManagement.ShowDriverLicenseHistory_Inter;
            else
                SelectedPermissions &= ~DriversManagement.ShowDriverLicenseHistory_Inter;
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
