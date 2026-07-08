using DVLD.Applications.International_Driving_License;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD.Tests;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Drivers.Layouts {
    public partial class Layout_ManageDrivers : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private int _activeLocalLicenseClass3IdOfSelectedDriver = -1; //By default
        private DataTable _dtAllDrivers;

        private enum FilterByOptions : byte {
            None, DriverID, PersonID, NationalNum, FullName, DateCreated, ActiveLicensesCount
        }

        public Layout_ManageDrivers() {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == SupportedLanguages.English)
                cb_inputFilterBy.Height += 3;

            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_drivers);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            cb_inputFilterBy.Tag = false; //DigitsOnly = false
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_drivers);
        }

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        private void Layout_ManageDrivers_Load(object sender, EventArgs e) {
            cb_filterBy.SelectedIndex = 0;
            ReloadAllData();

            _SetupTableHeader();
        }

        private void _SetupTableHeader() {
            dgv_drivers.Columns[0].HeaderText = Str_LayoutManageDrivers.driverID;
            dgv_drivers.Columns[1].HeaderText = Str_LayoutManagePeople.personID;
            dgv_drivers.Columns[2].HeaderText = Str_LayoutManagePeople.nationalNum;
            dgv_drivers.Columns[3].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_drivers.Columns[4].HeaderText = Str_LayoutManageDrivers.dateCreated;
            dgv_drivers.Columns[5].HeaderText = Str_LayoutManageDrivers.activeLicensesCount;
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_drivers.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter == FilterByOptions.DriverID || _selectedFilter == FilterByOptions.PersonID || _selectedFilter == FilterByOptions.NationalNum || _selectedFilter == FilterByOptions.ActiveLicensesCount) {
                if (!((bool) cb_inputFilterBy.Tag)) {
                    cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress;
                    cb_inputFilterBy.Tag = true;
                }
            } else if ((bool) cb_inputFilterBy.Tag) {
                cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress;
                cb_inputFilterBy.Tag = false;
            }

            cb_inputFilterBy.Visible = _selectedFilter != FilterByOptions.None;
            cb_inputFilterBy.Text = string.Empty; //To clear filtering and show all records
        }

        private void ComboBox_inputFilterBy_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void comboBox_inputFilterBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        public void ReloadAllData() {
            _dtAllDrivers = Driver.GetAllDrivers();

            dgv_drivers.DataSource = _dtAllDrivers;

            RefreshDataFiltering();
        }

        public void RefreshDataFiltering() {
            if (cb_inputFilterBy.Text == string.Empty || cb_filterBy.SelectedIndex == (int) FilterByOptions.None)
                _dtAllDrivers.DefaultView.RowFilter = string.Empty;
            else {
                FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

                if (_selectedFilter == FilterByOptions.DriverID || _selectedFilter == FilterByOptions.PersonID || _selectedFilter == FilterByOptions.ActiveLicensesCount)
                    _dtAllDrivers.DefaultView.RowFilter = $"{_selectedFilter} = '{cb_inputFilterBy.Text}'";
                else if (_selectedFilter == FilterByOptions.DateCreated) {
                    if (DateTime.TryParseExact(cb_inputFilterBy.Text, BusinessUtils.DateTimeUtils.DateSearchFormat, null, System.Globalization.DateTimeStyles.None, out var _result))
                        _dtAllDrivers.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                    else
                        _dtAllDrivers.DefaultView.RowFilter = string.Empty;
                }
                else
                    _dtAllDrivers.DefaultView.RowFilter = $"{_selectedFilter} LIKE '%{cb_inputFilterBy.Text}%'";
            }

            label_numOfRecords.Text = dgv_drivers.RowCount.ToString();
            label_noDataAvailable.Visible = dgv_drivers.RowCount == 0;
        }

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void dgv_drivers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_drivers.Columns[e.ColumnIndex].Name == "ActiveLicensesCount") {
                if ((int) e.Value == 0)
                    e.CellStyle.ForeColor = Color.Red;
            } else if (dgv_drivers.Columns[e.ColumnIndex].Name == "DateCreated") {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) => _ShowSelectedDriverDetails();

        private void _ShowSelectedDriverDetails() {
            using (Frm_ShowDriverInformation _frmShowDriverInfo = new Frm_ShowDriverInformation((int) dgv_drivers.CurrentRow.Cells[0].Value)) {
                if (_frmShowDriverInfo.IsDisposed)
                    return;

                _frmShowDriverInfo.DriverSaved += _frmShowDriverInfo_DriverSaved;
                _frmShowDriverInfo.ShowDialog();
                _frmShowDriverInfo.DriverSaved -= _frmShowDriverInfo_DriverSaved;
            }
        }

        private void _frmShowDriverInfo_DriverSaved(int personID) => ReloadAllData();

        private void viewLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory((int) dgv_drivers.CurrentRow.Cells[1].Value)) {
                if (_frmShowDriverLicenseHistory.IsDisposed)
                    return;

                _frmShowDriverLicenseHistory.ForceExit += OnForceExit;
                _frmShowDriverLicenseHistory.DataSaved += _frmShowDriverLicenseHistory_DataSaved;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.DataSaved -= _frmShowDriverLicenseHistory_DataSaved;
                _frmShowDriverLicenseHistory.ForceExit -= OnForceExit;
            }
        }

        private void _frmShowDriverLicenseHistory_DataSaved() => ReloadAllData();

        private void viewTestsHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowPersonTestsHistory _frmShowPersonTestHistory = new Frm_ShowPersonTestsHistory((int) dgv_drivers.CurrentRow.Cells[1].Value)) {
                if (_frmShowPersonTestHistory.IsDisposed)
                    return;

                _frmShowPersonTestHistory.DataSaved += ReloadAllData;
                _frmShowPersonTestHistory.ForceExit += OnForceExit;
                _frmShowPersonTestHistory.ShowDialog();
                _frmShowPersonTestHistory.ForceExit -= OnForceExit;
                _frmShowPersonTestHistory.DataSaved -= ReloadAllData;
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) => ReloadAllData();

        private void issueInternationalLicenseeToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_IssueNewInternationalLicense _frmNewInterLicense = new Frm_IssueNewInternationalLicense(_activeLocalLicenseClass3IdOfSelectedDriver)) {
                if (_frmNewInterLicense.IsDisposed)
                    return;

                _frmNewInterLicense.DataSaved += ReloadAllData;
                _frmNewInterLicense.ForceExit += OnForceExit;
                _frmNewInterLicense.ShowDialog();
                _frmNewInterLicense.ForceExit -= OnForceExit;
                _frmNewInterLicense.DataSaved -= ReloadAllData;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (dgv_drivers.RowCount == 0) {
                _activeLocalLicenseClass3IdOfSelectedDriver = -1;
                showDetailsToolStripMenuItem.Enabled = viewLicenseHistoryToolStripMenuItem.Enabled = viewTestsHistoryToolStripMenuItem.Enabled = issueInternationalLicenseeToolStripMenuItem.Enabled = false;
            } else {
                _activeLocalLicenseClass3IdOfSelectedDriver = LocalDrivingLicense.FindActiveIdByDriverId((int) dgv_drivers.CurrentRow.Cells[0].Value, LicenseClasses.Class3_OrdinaryDrivingLicense);
                issueInternationalLicenseeToolStripMenuItem.Enabled = _activeLocalLicenseClass3IdOfSelectedDriver != -1 && GlobalFields.ActiveUserPermissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense) && GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo) && !InternationalDrivingLicense.DoesActiveInternationalLicenseExist_ByLocalLicense(_activeLocalLicenseClass3IdOfSelectedDriver);
            }
        }

        private void dgv_drivers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards))
                _ShowSelectedDriverDetails();
        }

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManageDrivers.drivers, (_dtAllDrivers ?? Driver.GetAllDrivers()).DefaultView);

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_inputFilterBy.Enabled = dgv_drivers.Enabled = ll_refreshData.Enabled = refreshToolStripMenuItem.Enabled = permissions.Drivers.HasFlag(DriversManagement.SeeAllDrivers);
            ll_exportData.Enabled = permissions.Drivers.HasFlag(DriversManagement.ExportDriversData);
            showDetailsToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            viewLicenseHistoryToolStripMenuItem.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
            viewTestsHistoryToolStripMenuItem.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Vision) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Written) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Driving);
            issueInternationalLicenseeToolStripMenuItem.Enabled = permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.CreateNewInterLicenseApp_IssueInterLicense) && permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
        }
    }
}

