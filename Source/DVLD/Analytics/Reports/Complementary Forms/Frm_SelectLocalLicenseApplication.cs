using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using Salem.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Analytics.Reports.Complementary_Forms {
    public partial class Frm_SelectLocalLicenseApplication : SalForm, IEnforcePermissions {
        public event Action<int> PersonSaved;
        private DataTable _dtAllApps;

        public int SelectedLocalLicenseAppID { get; private set; }

        public Frm_SelectLocalLicenseApplication() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_apps);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_apps);

        private void ctrl_PersonInfoCardWithFilter1_PersonFound(int personID) {
            if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps)) {
                bool _formatHeader = dgv_apps.DataSource is null;
                _ReloadAllData();

                ll_refreshData.Enabled =  btn_ok.Enabled = true;
                ll_exportData.Enabled = GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ExportLocalLicenseAppsData);

                if (_formatHeader)
                    _FormatTableHeader();
            }
        }

        private void _FormatTableHeader() {
            dgv_apps.Columns[0].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.localDrivingLicenseAppID;
            dgv_apps.Columns[0].Width = 120;

            dgv_apps.Columns[1].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.licenseClass;
            dgv_apps.Columns[1].Width = 280;

            dgv_apps.Columns[2].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.applicationDate;
            dgv_apps.Columns[2].Width = 180;

            dgv_apps.Columns[3].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.numOfTestPassed;
            dgv_apps.Columns[3].Width = 160;

            dgv_apps.Columns[4].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.status;
        }

        private void _ReloadAllData() {
            _dtAllApps = LocalDrivingLicenseApp.GetPreferredApplicationsView(ctrl_PersonInfoCardWithFilter1.PersonID, Settings.Default.CurrentLanguage);
            dgv_apps.DataSource = _dtAllApps;
            lbl_numOfRecords.Text = dgv_apps.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_apps.RowCount == 0;
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonNotFound() {
            ll_exportData.Enabled = ll_refreshData.Enabled = btn_ok.Enabled = false;
            lbl_numOfRecords.Text = Resources.txt_unknownField;
            lbl_noDataAvailable.Visible = true;
            dgv_apps.DataSource = null;
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => PersonSaved?.Invoke(personID);

        private void dgv_apps_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => btn_ok.PerformClick();

        private void dgv_apps_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_apps.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (dgv_apps.Columns[e.ColumnIndex].Name == "ApplicationStatus") {
                ApplicationStatus _status = (ApplicationStatus) e.Value;

                e.CellStyle.ForeColor = BusinessUtils.Mapping.GetApplicationStatusColor(_status);
                e.Value = BusinessUtils.Mapping.GetApplicationStatusString(_status);
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold | FontStyle.Italic);
                e.FormattingApplied = true;
            } else if (dgv_apps.Columns[e.ColumnIndex].Name == "PassedTestsCount") {
                e.CellStyle.ForeColor = BusinessUtils.Mapping.GetPassedTestsColor((byte) e.Value);
                e.Value = $"{e.Value}/3";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter) {
                if (ctrl_PersonInfoCardWithFilter1.Focused) {
                    ctrl_PersonInfoCardWithFilter1.PerformSearch();

                    if (ctrl_PersonInfoCardWithFilter1.PersonID != -1)
                        dgv_apps.Focus();

                    return true;
                } else if (dgv_apps.Focused) {
                    btn_ok.PerformClick();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            SelectedLocalLicenseAppID = (int) dgv_apps.CurrentRow.Cells[0].Value;
            DialogResult = DialogResult.OK;
        }

        private void Frm_SelectLocalLicenseApplication_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;

        private void ll_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllData();

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManageLocalDrivingLicenseApps.localDrivingLicenseApps, (_dtAllApps ?? LocalDrivingLicenseApp.GetPreferredApplicationsView(ctrl_PersonInfoCardWithFilter1.PersonID, Settings.Default.CurrentLanguage)).DefaultView);

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            ctrl_PersonInfoCardWithFilter1.EnableFiltering = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            dgv_apps.Enabled = ll_refreshData.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps);

            lbl_noDataAvailable.Text = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
