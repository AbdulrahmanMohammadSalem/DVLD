using DVLD.Applications.International_Driving_License;
using DVLD.Applications.Local_Driving_License;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Licenses.Layouts {
    public partial class Layout_ShowAllLicenses : ClosableLayout, IDataConsumer, IEnforcePermissions {
        public Layout_ShowAllLicenses() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            ll_interExportData.Anchor = ll_localExportData.Anchor = Settings.Default.CurrentLanguage == SupportedLanguages.English ? AnchorStyles.Bottom | AnchorStyles.Right : AnchorStyles.Bottom | AnchorStyles.Left;

            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_localLicenses);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interLicenses);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            if (tabControl1.RightToLeft == RightToLeft.Yes) {
                tabControl1.TabLocation = Manina.Windows.Forms.TabLocation.TopRight;
                tabControl1.ReverseTabsOrder();
                tabControl1.SelectedTab = tabPage2;
                tabControl1.SelectedTab = tabPage1;
            }

            dgv_localLicenses.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_localLicenses.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9F);
            dgv_localLicenses.Tag = (byte) 0;

            dgv_interLicenses.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_interLicenses.ColumnHeadersDefaultCellStyle.Font.FontFamily, 9F);
            dgv_interLicenses.Tag = (byte) 1;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_localLicenses);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interLicenses);
        }

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void Layout_ShowAllLicenses_Load(object sender, EventArgs e) {
            _ReloadAllLocalData();
            _ReloadAllInterData();

            _SetupLocalTableHeader();
            _SetupInterTableHeader();
        }

        private void _SetupInterTableHeader() {
            dgv_interLicenses.Columns[0].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.interLicenseID;
            dgv_interLicenses.Columns[0].Width = 65;

            dgv_interLicenses.Columns[1].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_interLicenses.Columns[1].Width = 180;

            dgv_interLicenses.Columns[2].HeaderText = Str_LayoutManagePeople.nationalNum;
            dgv_interLicenses.Columns[2].Width = 95;

            dgv_interLicenses.Columns[3].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.issueDate;
            dgv_interLicenses.Columns[3].Width = 95;

            dgv_interLicenses.Columns[4].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.expirationDate;
            dgv_interLicenses.Columns[4].Width = 95;

            dgv_interLicenses.Columns[5].HeaderText = Str_LayoutShowAllLicenses.baseAppID;
            dgv_interLicenses.Columns[5].Width = 95;

            dgv_interLicenses.Columns[6].HeaderText = Str_LayoutShowAllLicenses.assocLocalLicenseID;
            dgv_interLicenses.Columns[6].Width = 95;

            dgv_interLicenses.Columns[7].HeaderText = Str_LayoutManageUsers.isActive;
        }

        private void _SetupLocalTableHeader() {
            dgv_localLicenses.Columns[1].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.localLicenseID;
            dgv_localLicenses.Columns[1].Width = 65;

            dgv_localLicenses.Columns[2].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.licenseClass;
            dgv_localLicenses.Columns[2].Width = 120;

            dgv_localLicenses.Columns[3].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_localLicenses.Columns[3].Width = 180;

            dgv_localLicenses.Columns[4].HeaderText = Str_LayoutManagePeople.nationalNum;
            dgv_localLicenses.Columns[4].Width = 80;

            dgv_localLicenses.Columns[5].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.issueDate;
            dgv_localLicenses.Columns[5].Width = 85;

            dgv_localLicenses.Columns[6].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.expirationDate;
            dgv_localLicenses.Columns[6].Width = 85;

            dgv_localLicenses.Columns[7].HeaderText = Str_LayoutShowAllLicenses.baseAppID;
            dgv_localLicenses.Columns[7].Width = 70;

            dgv_localLicenses.Columns[8].HeaderText = Str_LayoutManageUsers.isActive;

            dgv_localLicenses.Columns[9].Visible = false;
        }

        private void _ReloadAllInterData() {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ViewAllInterLicenses)) {
                dgv_interLicenses.DataSource = InternationalDrivingLicense.GetAllInternationalLicenses();
                lbl_interNoDataAvailable.Visible = dgv_interLicenses.RowCount == 0;
                lbl_interNumOfRecords.Text = dgv_interLicenses.RowCount.ToString();
            }
        }

        private void _ReloadAllLocalData() {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ViewAllLocalLicenses)) {
                dgv_localLicenses.DataSource = LocalDrivingLicense.GetAllLocalLicenses(Settings.Default.CurrentLanguage);
                dgv_localLicenses.Columns["IsDetainedImage"].DisplayIndex = 8;
                lbl_localNoDataAvailable.Visible = dgv_localLicenses.RowCount == 0;
                lbl_localNumOfRecords.Text = dgv_localLicenses.RowCount.ToString();
            }
        }

        private void ll_localRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllLocalData();

        private void ll_interRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadAllInterData();

        private void ll_newLocalApplication_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_AddEditLocalDrivingLicenseApplication _frmNewLocalApplication = new Frm_AddEditLocalDrivingLicenseApplication()) {
                _frmNewLocalApplication.ForceExit += OnForceExit;
                _frmNewLocalApplication.DataSaved += _ReloadAllLocalData;
                _frmNewLocalApplication.ShowDialog();
                _frmNewLocalApplication.DataSaved -= _ReloadAllLocalData;
                _frmNewLocalApplication.ForceExit -= OnForceExit;
            }
        }

        private void ll_newInterApplication_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_IssueNewInternationalLicense _frmNewInterApplication = new Frm_IssueNewInternationalLicense()) {
                _frmNewInterApplication.ForceExit += OnForceExit;
                _frmNewInterApplication.DataSaved += _ReloadAllInterData;
                _frmNewInterApplication.ShowDialog();
                _frmNewInterApplication.DataSaved -= _ReloadAllInterData;
                _frmNewInterApplication.ForceExit -= OnForceExit;
            }
        }

        private void dgv_Licenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            DataGridView _sender = (DataGridView) sender;

            if (_sender.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                DateTime _val = (DateTime) e.Value;

                if (_sender.Columns[e.ColumnIndex].Name == "ExpirationDate" && DateTime.Now > _val)
                    e.CellStyle.ForeColor = Color.Red;

                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (_sender.Columns[e.ColumnIndex].Name == "IsActive") {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if ((byte) e.Value == 1) {
                    e.CellStyle.Font = new Font("Segoe Fluent Icons", 10F);
                    e.CellStyle.ForeColor = Color.Green;
                    e.Value = "\uf78c";
                } else {
                    e.CellStyle.Font = new Font("Segoe Fluent Icons", 8F);
                    e.CellStyle.ForeColor = Color.Red;
                    e.Value = "\uf78a";
                }
              
                e.FormattingApplied = true;
            } else if ((byte) _sender.Tag == 0 && _sender.Columns[e.ColumnIndex].Name == "IsDetainedImage") {
                e.Value = (bool) _sender[9, e.RowIndex].Value ? Resources.Detained_16 : Resources.Released_16;
                e.FormattingApplied = true;
            }
        }

        private void dgv_localLicenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo)) {
                using (Frm_ShowLocalLicenseInformation _frmShowLocalLicenseInfo = new Frm_ShowLocalLicenseInformation((int) dgv_localLicenses.CurrentRow.Cells[1].Value)) {
                    if (_frmShowLocalLicenseInfo.IsDisposed)
                        return;

                    _frmShowLocalLicenseInfo.PersonSaved += _frmShowLocalLicenseInfo_PersonSaved;
                    _frmShowLocalLicenseInfo.ShowDialog();
                    _frmShowLocalLicenseInfo.PersonSaved -= _frmShowLocalLicenseInfo_PersonSaved;
                }
            }
        }

        private void _frmShowLocalLicenseInfo_PersonSaved(int personID) => _ReloadAllLocalData();

        private void dgv_interLicenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo)) {
                using (Frm_ShowInternationalLicenseInformation _frmShowInterLicenseInfo = new Frm_ShowInternationalLicenseInformation((int) dgv_interLicenses.CurrentRow.Cells[0].Value)) {
                    if (_frmShowInterLicenseInfo.IsDisposed)
                        return;

                    _frmShowInterLicenseInfo.DataSaved += _ReloadAllInterData;
                    _frmShowInterLicenseInfo.ShowDialog();
                    _frmShowInterLicenseInfo.DataSaved -= _ReloadAllInterData;
                }
            }
        }

        public void ReloadAllData() {
            _ReloadAllLocalData();
            _ReloadAllInterData();
        }

        public void RefreshDataFiltering() { /* Do Nothing */ }

        private void ll_localExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutShowAllLicenses.localLicenses, dgv_localLicenses.DataSource as DataView ?? LocalDrivingLicense.GetAllLocalLicenses(Settings.Default.CurrentLanguage));

        private void ll_interExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutShowAllLicenses.interLicenses, dgv_interLicenses.DataSource as DataView ?? InternationalDrivingLicense.GetAllInternationalLicenses());

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_allLocalLicenses.Enabled = dgv_localLicenses.Enabled = ll_localRefreshData.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ViewAllLocalLicenses);
            ll_newLocalApplication.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.CreateNewLocalLicenseApp);
            ll_localExportData.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ExportLocalLicensesData);
            
            lbl_allInterLicenses.Enabled = dgv_interLicenses.Enabled = ll_interRefreshData.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ViewAllInterLicenses);
            ll_newInterApplication.Enabled = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense);
            ll_interExportData.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ExportInterLicensesData);
        }
    }
}
