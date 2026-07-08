using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_LookupTablesManagement : SalForm {
        public LookupTablesManagement SelectedPermissions { get; private set; } = LookupTablesManagement.NoAccess;

        public Frm_LookupTablesManagement(LookupTablesManagement startupValues) {
            InitializeComponent();

            chk_appTypesViewAllData.Checked = startupValues.HasFlag(LookupTablesManagement.ApplicationTypes_ViewAllData);
            chk_appTypesUpdateData.Checked = startupValues.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData);
            chk_appTypesExportData.Checked = startupValues.HasFlag(LookupTablesManagement.ApplicationTypes_ExportData);

            chk_testTypesViewAllData.Checked = startupValues.HasFlag(LookupTablesManagement.TestTypes_ViewAllData);
            chk_testTypesUpdateData.Checked = startupValues.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData);
            chk_testTypesExportData.Checked = startupValues.HasFlag(LookupTablesManagement.TestTypes_ExportData);

            chk_licenseClassesViewAllData.Checked = startupValues.HasFlag(LookupTablesManagement.LicenseClasses_ViewAllData);
            chk_licenseClassesUpdateData.Checked = startupValues.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData);
            chk_licenseClassesExportData.Checked = startupValues.HasFlag(LookupTablesManagement.LicenseClasses_ExportData);
        }

        private void chk_appTypesViewAllData_CheckedChanged(object sender, EventArgs e) {
            if (chk_appTypesViewAllData.Checked)
                SelectedPermissions |= LookupTablesManagement.ApplicationTypes_ViewAllData;
            else
                SelectedPermissions &= ~LookupTablesManagement.ApplicationTypes_ViewAllData;
        }

        private void chk_appTypesUpdateData_CheckedChanged(object sender, EventArgs e) {
            if (chk_appTypesUpdateData.Checked)
                SelectedPermissions |= LookupTablesManagement.ApplicationTypes_ViewUpdateData;
            else
                SelectedPermissions &= ~LookupTablesManagement.ApplicationTypes_ViewUpdateData;
        }

        private void chk_appTypesExportData_CheckedChanged(object sender, EventArgs e) {
            if (chk_appTypesExportData.Checked)
                SelectedPermissions |= LookupTablesManagement.ApplicationTypes_ExportData;
            else
                SelectedPermissions &= ~LookupTablesManagement.ApplicationTypes_ExportData;
        }

        private void chk_testTypesViewAllData_CheckedChanged(object sender, EventArgs e) {
            if (chk_testTypesViewAllData.Checked)
                SelectedPermissions |= LookupTablesManagement.TestTypes_ViewAllData;
            else
                SelectedPermissions &= ~LookupTablesManagement.TestTypes_ViewAllData;
        }

        private void chk_testTypesUpdateData_CheckedChanged(object sender, EventArgs e) {
            if (chk_testTypesUpdateData.Checked)
                SelectedPermissions |= LookupTablesManagement.TestTypes_ViewUpdateData;
            else
                SelectedPermissions &= ~LookupTablesManagement.TestTypes_ViewUpdateData;
        }

        private void chk_testTypesExportData_CheckedChanged(object sender, EventArgs e) {
            if (chk_testTypesExportData.Checked)
                SelectedPermissions |= LookupTablesManagement.TestTypes_ExportData;
            else
                SelectedPermissions &= ~LookupTablesManagement.TestTypes_ExportData;
        }

        private void chk_licenseClassesViewAllData_CheckedChanged(object sender, EventArgs e) {
            if (chk_licenseClassesViewAllData.Checked)
                SelectedPermissions |= LookupTablesManagement.LicenseClasses_ViewAllData;
            else
                SelectedPermissions &= ~LookupTablesManagement.LicenseClasses_ViewAllData;
        }

        private void chk_licenseClassesUpdateData_CheckedChanged(object sender, EventArgs e) {
            if (chk_licenseClassesUpdateData.Checked)
                SelectedPermissions |= LookupTablesManagement.LicenseClasses_ViewUpdateData;
            else
                SelectedPermissions &= ~LookupTablesManagement.LicenseClasses_ViewUpdateData;
        }

        private void chk_licenseClassesExportData_CheckedChanged(object sender, EventArgs e) {
            if (chk_licenseClassesExportData.Checked)
                SelectedPermissions |= LookupTablesManagement.LicenseClasses_ExportData;
            else
                SelectedPermissions &= ~LookupTablesManagement.LicenseClasses_ExportData;
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
