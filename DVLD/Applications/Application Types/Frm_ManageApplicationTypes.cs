using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications {
    public partial class Frm_ManageApplicationTypes : SalForm, IEnforcePermissions {
        public Frm_ManageApplicationTypes() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
            
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_applicationTypes);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_applicationTypes);

        private void Frm_ManageApplicationTypes_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewAllData) || GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData))
                _ReloadAllData();
        }

        private void _ReloadAllData() {
            dgv_applicationTypes.DataSource = ApplicationType.GetAllApplicationTypes(Settings.Default.CurrentLanguage);
            label_numOfRecords.Text = dgv_applicationTypes.RowCount.ToString();

            if (dgv_applicationTypes.RowCount == 0) {
                label_numOfRecords.Text = "0";
                label_id.Text = textBox_title.Text = textBox_fees.Text = Resources.txt_unknownField;
                pnl_updateSelectedItem.Enabled = false;
                lbl_noDataAvailable.Visible = true;
            } else {
                label_numOfRecords.Text = dgv_applicationTypes.RowCount.ToString();
                _RefreshTheUpdatePanel();
                pnl_updateSelectedItem.Enabled = GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData);
                lbl_noDataAvailable.Visible = false;
            }

            dgv_applicationTypes.Columns[0].Width = 95;
            dgv_applicationTypes.Columns[0].HeaderText = Resources.txt_id;

            dgv_applicationTypes.Columns[1].Width = 335;
            dgv_applicationTypes.Columns[1].HeaderText = Resources.txt_title;

            dgv_applicationTypes.Columns[2].HeaderText = Resources.txt_fees;
        }

        private void _RefreshTheUpdatePanel() {
            label_id.Text = dgv_applicationTypes.CurrentRow.Cells[0].Value.ToString();
            textBox_title.Text = dgv_applicationTypes.CurrentRow.Cells[1].Value.ToString();
            textBox_fees.Text = dgv_applicationTypes.CurrentRow.Cells[2].Value.ToString();
        }

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllData();

        private void dgv_applicationTypes_CellEnter(object sender, DataGridViewCellEventArgs e) => _RefreshTheUpdatePanel();

        private void textBox_fees_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (textBox_fees.Text == string.Empty)
                errorProvider1.SetError(textBox_fees, Resources.txt_requiredField);
            else if (!BusinessValidator.IsNumber(textBox_fees.Text)) {
                errorProvider1.SetError(textBox_fees, Resources.txt_enterValidDecimalValue);
                e.Cancel = true;
            }
        }

        private void textBox_fees_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

        private void textBox_fees_TextChanged(object sender, EventArgs e) => errorProvider1.SetError(textBox_fees, string.Empty);

        private void button_save_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                ApplicationType _applicationType = ApplicationType.Find((ApplicationTypes) int.Parse(label_id.Text));

                _applicationType.Fees = decimal.Parse(textBox_fees.Text);

                if (_applicationType.Save()) {
                    _ReloadAllData();
                    MessageBox.Show(Resources.msg_dataSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Resources.msg_dataSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool ValidateChildren() {
            if (!BusinessValidator.IsNumber(textBox_fees.Text)) {
                errorProvider1.SetError(textBox_fees, Resources.txt_enterValidDecimalValue);
                return false;
            }

            return true;
        }

        private void Frm_ManageApplicationTypes_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_FrmManageApplicationTypes.applicationTypes, dgv_applicationTypes.DataSource as DataView ?? ApplicationType.GetAllApplicationTypes(Settings.Default.CurrentLanguage));

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            ll_refreshData.Enabled = dgv_applicationTypes.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData);
            pnl_updateSelectedItem.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData);
            ll_exportData.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ExportData);

            lbl_noDataAvailable.Text = permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.ApplicationTypes_ViewUpdateData) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
