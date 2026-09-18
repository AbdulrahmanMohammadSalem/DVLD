using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Licenses.License_Classes {
    public partial class Frm_ManageLicenseClasses : SalForm, IEnforcePermissions {
        public Frm_ManageLicenseClasses() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_licenseClasses);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_licenseClasses);

        private void textBox_digitsOnly_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void textBox_fees_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

        private void Frm_ManageLicenseClasses_Load(object sender, System.EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewAllData) || GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData))
                _ReloadAllData();
        }

        private void _ReloadAllData() {
            dgv_licenseClasses.DataSource = LicenseClass.GetAllLicenseClasses(Settings.Default.CurrentLanguage);
            label_numOfRecords.Text = dgv_licenseClasses.RowCount.ToString();

            if (dgv_licenseClasses.RowCount == 0) {
                label_numOfRecords.Text = "0";
                label_id.Text = textBox_className.Text = textBox_description.Text = textBox_minimumAllowedAge.Text = textBox_defaultValidityLength.Text = textBox_fees.Text = Resources.txt_unknownField;
                pnl_updateSelectedItem.Enabled = false;
                label_noDataAvailable.Visible = true;
            } else {
                label_numOfRecords.Text = dgv_licenseClasses.RowCount.ToString();
                _RefreshTheUpdatePanel();
                pnl_updateSelectedItem.Enabled = GlobalFields.ActiveUserPermissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData);
                label_noDataAvailable.Visible = false;
            }

            SupportedLanguages _lang = Settings.Default.CurrentLanguage;

            dgv_licenseClasses.Columns[0].Width = _lang == SupportedLanguages.English ? 50 : 90;
            dgv_licenseClasses.Columns[0].HeaderText = Resources.txt_id;

            dgv_licenseClasses.Columns[1].Width = _lang == SupportedLanguages.English ? 190 : 200;
            dgv_licenseClasses.Columns[1].HeaderText = Str_FrmManageLicenseClasses.className;

            dgv_licenseClasses.Columns[2].Width = _lang == SupportedLanguages.English ? 295 : 260;
            dgv_licenseClasses.Columns[2].HeaderText = Str_FrmManageTestTypes.description;

            dgv_licenseClasses.Columns[3].Width = _lang == SupportedLanguages.English ? 110 : 110;
            dgv_licenseClasses.Columns[3].HeaderText = Str_FrmManageLicenseClasses.minimumAllowedAge;

            dgv_licenseClasses.Columns[4].Width = _lang == SupportedLanguages.English ? 95 : 90;
            dgv_licenseClasses.Columns[4].HeaderText = Str_FrmManageLicenseClasses.defaultValidityLength;

            dgv_licenseClasses.Columns[5].HeaderText = Str_FrmManageLicenseClasses.classFees;
        }

        private void _RefreshTheUpdatePanel() {
            if (dgv_licenseClasses.CurrentRow is null)
                return;

            label_id.Text = dgv_licenseClasses.CurrentRow.Cells[0].Value.ToString();
            textBox_className.Text = dgv_licenseClasses.CurrentRow.Cells[1].Value.ToString();
            textBox_description.Text = dgv_licenseClasses.CurrentRow.Cells[2].Value.ToString();
            textBox_minimumAllowedAge.Text = dgv_licenseClasses.CurrentRow.Cells[3].Value.ToString();
            textBox_defaultValidityLength.Text = dgv_licenseClasses.CurrentRow.Cells[4].Value.ToString();
            textBox_fees.Text = dgv_licenseClasses.CurrentRow.Cells[5].Value.ToString();
        }

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllData();

        private void dgv_licenseClasses_CellEnter(object sender, DataGridViewCellEventArgs e) => _RefreshTheUpdatePanel();

        private void textBox_fees_Validating(object sender, CancelEventArgs e) {
            if (textBox_fees.Text == string.Empty)
                errorProvider1.SetError(textBox_fees, Resources.txt_requiredField);
            else if (!BusinessValidator.IsNumber(textBox_fees.Text)) {
                errorProvider1.SetError(textBox_fees, Resources.txt_enterValidDecimalValue);
                e.Cancel = true;
            }
        }

        private void textBox_toClearError_TextChanged(object sender, System.EventArgs e) => errorProvider1.SetError((TextBox) sender, string.Empty);

        private void textBox_defaultValidityLength_Validating(object sender, CancelEventArgs e) {
            bool b = false;
            _ValidateAsRequired(textBox_defaultValidityLength, ref b);
        }

        private void button_save_Click(object sender, System.EventArgs e) {
            if (ValidateChildren()) {
                LicenseClass _licenseClass = LicenseClass.Find((LicenseClasses) byte.Parse(label_id.Text));

                _licenseClass.MinimumAllowedAge = byte.Parse(textBox_minimumAllowedAge.Text);
                _licenseClass.DefaultValidityLength = byte.Parse(textBox_defaultValidityLength.Text);
                _licenseClass.ClassFees = decimal.Parse(textBox_fees.Text);

                if (_licenseClass.Save()) {
                    _ReloadAllData();
                    MessageBox.Show(Resources.msg_dataSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Resources.msg_dataSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override bool ValidateChildren() {
            bool _result = true;

            _ValidateAsRequired(textBox_minimumAllowedAge, ref _result);
            _ValidateAsRequired(textBox_defaultValidityLength, ref _result);
            _ValidateAsRequired(textBox_fees, ref _result);

            if (textBox_minimumAllowedAge.TextLength > 0 && !BusinessValidator.IsValidAge(textBox_minimumAllowedAge.Text)) {
                _result = false;
                errorProvider1.SetError(textBox_minimumAllowedAge, Str_FrmManageLicenseClasses.invalidAgeInput);
            }

            if (!BusinessValidator.IsNumber(textBox_fees.Text)) {
                _result = false;
                errorProvider1.SetError(textBox_fees, Resources.txt_enterValidDecimalValue);
            }

            return _result;
        }

        private void _ValidateAsRequired(TextBox textBox, ref bool result) {
            textBox.Text = textBox.Text.Trim();

            if (textBox.Text == string.Empty) {
                result = false;
                errorProvider1.SetError(textBox, Resources.txt_requiredField);
            }
        }

        private void textBox_minimumAllowedAge_Validating(object sender, CancelEventArgs e) {
            bool b = true;
            _ValidateAsRequired(textBox_minimumAllowedAge, ref b);

            if (b && !BusinessValidator.IsValidAge(textBox_minimumAllowedAge.Text)) {
                errorProvider1.SetError(textBox_minimumAllowedAge, Str_FrmManageLicenseClasses.invalidAgeInput);
                e.Cancel = true;
            }
        }

        private void Frm_ManageLicenseClasses_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_FrmManageLicenseClasses.licenseClasses, dgv_licenseClasses.DataSource as DataView ?? LicenseClass.GetAllLicenseClasses(Settings.Default.CurrentLanguage));

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            dgv_licenseClasses.Enabled = ll_refreshData.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData);
            pnl_updateSelectedItem.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData);
            ll_exportData.Enabled = permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ExportData);

            label_noDataAvailable.Text = permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewAllData) || permissions.LookupTables.HasFlag(LookupTablesManagement.LicenseClasses_ViewUpdateData) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
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
