using DVLD.Common;
using DVLD.Drivers;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications.International_Driving_License {
    public partial class Layout_ManageInternationalDrivingLicenseApps : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private DataTable _dtAllInterDrivingLicenseApps;

        public Layout_ManageInternationalDrivingLicenseApps() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
            
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interDrivingLicenseApps);
            Settings.Default.SettingsSaving += Default_SettingsSaving;
            
            cb_inputFilterBy.Tag = false; //DigitsOnly = false
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interDrivingLicenseApps);
        }

        private enum FilterByOptions : byte {
            None, InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
        }

        private void Layout_ManageInternationalDrivingLicenseApps_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps)) {
                cb_filterBy.SelectedIndex = 0;
                ReloadAllData();

                _SetupTableHeader();
            }
        }

        private void _SetupTableHeader() {
            dgv_interDrivingLicenseApps.Columns[0].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.interLicenseID;
            dgv_interDrivingLicenseApps.Columns[1].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.applicationID;
            dgv_interDrivingLicenseApps.Columns[2].HeaderText = Str_LayoutManageDrivers.driverID;
            dgv_interDrivingLicenseApps.Columns[3].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.localLicenseID;
            dgv_interDrivingLicenseApps.Columns[4].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.issueDate;
            dgv_interDrivingLicenseApps.Columns[5].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.expirationDate;
            dgv_interDrivingLicenseApps.Columns[6].HeaderText = Str_LayoutManageUsers.isActive;
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_interDrivingLicenseApps.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter == FilterByOptions.InternationalLicenseID || _selectedFilter == FilterByOptions.ApplicationID || _selectedFilter == FilterByOptions.DriverID || _selectedFilter == FilterByOptions.IssuedUsingLocalLicenseID) {
                if (!((bool) cb_inputFilterBy.Tag)) {
                    cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress;
                    cb_inputFilterBy.Tag = true;
                }
            } else if ((bool) cb_inputFilterBy.Tag) {
                cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress;
                cb_inputFilterBy.Tag = false;
            }

            if (_selectedFilter == FilterByOptions.IsActive) {
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_inputFilterBy.SelectedIndex = 0;
            } else {
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.Simple;
                cb_inputFilterBy.Text = string.Empty;
            }

            cb_inputFilterBy.Visible = _selectedFilter != FilterByOptions.None;
        }

        private void ComboBox_inputFilterBy_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void comboBox_inputFilterBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void btn_addNewLocalDrivingLicenseApp_Click(object sender, EventArgs e) {
            using (Frm_IssueNewInternationalLicense _frmNewInterLicense = new Frm_IssueNewInternationalLicense()) {
                _frmNewInterLicense.DataSaved += ReloadAllData;
                _frmNewInterLicense.ForceExit += _frmNewInterLicense_ForceExit;
                _frmNewInterLicense.ShowDialog();
                _frmNewInterLicense.ForceExit -= _frmNewInterLicense_ForceExit;
                _frmNewInterLicense.DataSaved -= ReloadAllData;
            }
        }

        private void _frmNewInterLicense_ForceExit() => OnForceExit();

        private void dgv_interDrivingLicenseApps_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo))
                _DisplayCurrentLicenseDetails();
        }

        public void ReloadAllData() {
            _dtAllInterDrivingLicenseApps = InternationalDrivingLicense.GetPreferredInternationalAppsView();

            dgv_interDrivingLicenseApps.DataSource = _dtAllInterDrivingLicenseApps;

            RefreshDataFiltering();
        }

        public void RefreshDataFiltering() {
            if (cb_inputFilterBy.Text == string.Empty || cb_filterBy.SelectedIndex == (int) FilterByOptions.None || (cb_filterBy.SelectedIndex == (int) FilterByOptions.IsActive && cb_inputFilterBy.SelectedIndex == 0))
                _dtAllInterDrivingLicenseApps.DefaultView.RowFilter = string.Empty;
            else {
                FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

                if (_selectedFilter == FilterByOptions.IsActive)
                    _dtAllInterDrivingLicenseApps.DefaultView.RowFilter = $"{_selectedFilter} = {2 - cb_inputFilterBy.SelectedIndex}"; //Branchless
                else if (_selectedFilter == FilterByOptions.IssueDate || _selectedFilter == FilterByOptions.ExpirationDate) {
                    if (DateTime.TryParseExact(cb_inputFilterBy.Text, BusinessUtils.DateTimeUtils.DateSearchFormat, null, System.Globalization.DateTimeStyles.None, out var _result))
                        _dtAllInterDrivingLicenseApps.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                    else
                        _dtAllInterDrivingLicenseApps.DefaultView.RowFilter = string.Empty;
                } else
                    _dtAllInterDrivingLicenseApps.DefaultView.RowFilter = $"{_selectedFilter} = {cb_inputFilterBy.Text}";
            }

            label_numOfRecords.Text = dgv_interDrivingLicenseApps.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_interDrivingLicenseApps.RowCount == 0;
        }

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void dgv_interDrivingLicenseApps_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_interDrivingLicenseApps.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            } else if (dgv_interDrivingLicenseApps.Columns[e.ColumnIndex].Name == "IsActive") {
                if ((byte) e.Value == 1) {
                    e.Value = Resources.txt_yes;
                    e.CellStyle.ForeColor = Color.Green;
                } else {
                    e.Value = Resources.txt_no;
                    e.CellStyle.ForeColor = Color.Red;
                }

                e.FormattingApplied = true;
            }
        }

        private void showDriverDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowDriverInformation _frmShowDriverInfo = new Frm_ShowDriverInformation((int) dgv_interDrivingLicenseApps.CurrentRow.Cells[2].Value)) {
                if (_frmShowDriverInfo.IsDisposed)
                    return;

                _frmShowDriverInfo.DriverSaved += _frmShowDriverInfo_DriverSaved;
                _frmShowDriverInfo.ShowDialog();
                _frmShowDriverInfo.DriverSaved -= _frmShowDriverInfo_DriverSaved;
            }
        }

        private void _frmShowDriverInfo_DriverSaved(int driverID) => ReloadAllData();

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)  => _DisplayCurrentLicenseDetails();

        private void showDriverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(Driver.FindPersonID((int) dgv_interDrivingLicenseApps.CurrentRow.Cells[2].Value))) {
                if (_frmShowDriverLicenseHistory.IsDisposed)
                    return;

                _frmShowDriverLicenseHistory.ForceExit += OnForceExit;
                _frmShowDriverLicenseHistory.DataSaved += ReloadAllData;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.DataSaved -= ReloadAllData;
                _frmShowDriverLicenseHistory.ForceExit -= OnForceExit;
            }
        }

        private void _DisplayCurrentLicenseDetails() {
            using (Frm_ShowInternationalLicenseInformation _frmShowInterLicenseInfo = new Frm_ShowInternationalLicenseInformation((int) dgv_interDrivingLicenseApps.CurrentRow.Cells[0].Value)) {
                if (_frmShowInterLicenseInfo.IsDisposed)
                    return;

                _frmShowInterLicenseInfo.DataSaved += ReloadAllData;
                _frmShowInterLicenseInfo.ShowDialog();
                _frmShowInterLicenseInfo.DataSaved -= ReloadAllData;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            showDriverDetailsToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards) && dgv_interDrivingLicenseApps.RowCount > 0;
            showLicenseDetailsToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo) && dgv_interDrivingLicenseApps.RowCount > 0;
            showDriverLicenseHistoryToolStripMenuItem.Enabled = (GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter)) && dgv_interDrivingLicenseApps.RowCount > 0;
        }

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManageInternationalDrivingLicenseApps.interDrivingLicenseApps, (_dtAllInterDrivingLicenseApps ?? InternationalDrivingLicense.GetPreferredInternationalAppsView()).DefaultView);

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_inputFilterBy.Enabled = dgv_interDrivingLicenseApps.Enabled = ll_refreshData.Enabled = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps);
            btn_addNewInterDrivingLicenseApp.Enabled = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense);
            ll_exportData.Enabled = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.ExportInterLicenseAppsData);
            showDriverDetailsToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            showLicenseDetailsToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo);
            showDriverLicenseHistoryToolStripMenuItem.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);

            lbl_noDataAvailable.Text = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
