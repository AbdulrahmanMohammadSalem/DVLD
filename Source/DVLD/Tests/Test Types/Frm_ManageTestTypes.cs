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

namespace DVLD.Applications.Test_Types {
    public partial class Frm_ManageTestTypes : SalForm, IEnforcePermissions {
        public Frm_ManageTestTypes() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
            
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_testTypes);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_testTypes);

        private void Frm_ManageTestTypes_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewAllData) || GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData))
                _ReloadAllData(); 
        }

        private void _ReloadAllData() {
            dgv_testTypes.DataSource = TestType.GetAllTestTypes(Settings.Default.CurrentLanguage);
            label_numOfRecords.Text = dgv_testTypes.RowCount.ToString();

            if (dgv_testTypes.RowCount == 0) {
                label_numOfRecords.Text = "0";
                label_id.Text = textBox_title.Text = textBox_description.Text = textBox_fees.Text = Resources.txt_unknownField;
                pnl_updateSelectedItem.Enabled = false;
                label_noDataAvailable.Visible = true;
            } else {
                label_numOfRecords.Text = dgv_testTypes.RowCount.ToString();
                _RefreshTheUpdatePanel();
                pnl_updateSelectedItem.Enabled = GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData);
                label_noDataAvailable.Visible = false;
            }

            dgv_testTypes.Columns[0].Width = 85;
            dgv_testTypes.Columns[0].HeaderText = Resources.txt_id;

            dgv_testTypes.Columns[1].Width = 160;
            dgv_testTypes.Columns[1].HeaderText = Resources.txt_title;

            dgv_testTypes.Columns[2].Width = 210;
            dgv_testTypes.Columns[2].HeaderText = Str_FrmManageTestTypes.description;

            dgv_testTypes.Columns[3].HeaderText = Resources.txt_fees;
        }

        private void _RefreshTheUpdatePanel() {
            if (dgv_testTypes.CurrentRow is null)
                return;
            
            label_id.Text = dgv_testTypes.CurrentRow.Cells[0].Value.ToString();
            textBox_title.Text = dgv_testTypes.CurrentRow.Cells[1].Value.ToString();
            textBox_description.Text = dgv_testTypes.CurrentRow.Cells[2].Value.ToString();
            textBox_fees.Text = dgv_testTypes.CurrentRow.Cells[3].Value.ToString();
        }

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllData();

        private void dgv_testTypes_CellEnter(object sender, DataGridViewCellEventArgs e) => _RefreshTheUpdatePanel();

        private void textBox_fees_Validating(object sender, CancelEventArgs e) {
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
                TestType _testType = TestType.Find((TestTypes) byte.Parse(label_id.Text));

                _testType.Fees = decimal.Parse(textBox_fees.Text);

                if (_testType.Save()) {
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

        private void Frm_ManageTestTypes_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;
        
        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_FrmManageTestTypes.testTypes, dgv_testTypes.DataSource as DataView ?? TestType.GetAllTestTypes(Settings.Default.CurrentLanguage));

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            dgv_testTypes.Enabled = ll_refreshData.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData);
            pnl_updateSelectedItem.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData);
            ll_exportData.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ExportData);

            label_noDataAvailable.Text = permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.TestTypes_ViewUpdateData) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
