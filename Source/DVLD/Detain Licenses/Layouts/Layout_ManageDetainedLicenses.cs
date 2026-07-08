using DVLD.Common;
using DVLD.Drivers;
using DVLD.Interfaces;
using DVLD.Licenses;
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

namespace DVLD.Detain_Licenses.Layouts {
    public partial class Layout_ManageDetainedLicenses : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private DataTable _dtAllDetentions;

        public Layout_ManageDetainedLicenses() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);
            lbl_noDataAvailable.BackColor = BackColor;

            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;

            Settings.Default.ApplyDataGridViewStyleSettings(dgv_detainedLicenses);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            txt_filterInput.Tag = FilterInputTypes.Normal;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_detainedLicenses);
            lbl_noDataAvailable.BackColor = BackColor;
        }

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        private enum FilterByOptions : byte {
            None, DetainID, LocalLicenseID, DetainDate, IsReleased, FineFees, 
            ReleaseDate, NationalNum, FullName, ReleaseApplicationID
        }

        private enum FilterInputTypes : byte {
            Normal, Numeric, DigitsOnly
        }

        public void RefreshDataFiltering() {
            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter == FilterByOptions.None || (_selectedFilter == FilterByOptions.IsReleased ? cb_isReleased.SelectedIndex == 0 : string.IsNullOrEmpty(txt_filterInput.Text)))
                _dtAllDetentions.DefaultView.RowFilter = string.Empty;
            else {
                if (_selectedFilter == FilterByOptions.IsReleased)
                    _dtAllDetentions.DefaultView.RowFilter = $"IsReleased = {2 - cb_isReleased.SelectedIndex}";
                else if (_selectedFilter.In(FilterByOptions.DetainID, FilterByOptions.LocalLicenseID, FilterByOptions.ReleaseApplicationID, FilterByOptions.FineFees))
                    _dtAllDetentions.DefaultView.RowFilter = txt_filterInput.Text == string.Empty ? string.Empty : $"{_selectedFilter} = {txt_filterInput.Text}";
                else if (_selectedFilter == FilterByOptions.DetainDate || _selectedFilter == FilterByOptions.ReleaseDate) {
                    if (DateTime.TryParseExact(txt_filterInput.Text, BusinessUtils.DateTimeUtils.DateSearchFormat, null, System.Globalization.DateTimeStyles.None, out var _result))
                        _dtAllDetentions.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                    else
                        _dtAllDetentions.DefaultView.RowFilter = string.Empty;
                } else
                    _dtAllDetentions.DefaultView.RowFilter = $"{_selectedFilter} LIKE '%{txt_filterInput.Text}%'";
            }

            _RefreshCountLabels();
        }

        public void ReloadAllData() {
            dgv_detainedLicenses.DataSource = _dtAllDetentions = LicenseDetention.GetAllLicenseDetains();
            RefreshDataFiltering();
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void Layout_ManageDetainedLicenses_Load(object sender, EventArgs e) {
            ReloadAllData();
            _SetupTableHeader();
        }

        private void _SetupTableHeader() {
            dgv_detainedLicenses.Columns[0].HeaderText = Str_LayoutManageDetainedLicenses.detainID;
            dgv_detainedLicenses.Columns[0].Width = 70;

            dgv_detainedLicenses.Columns[1].HeaderText = Str_LayoutManageDetainedLicenses.localLicenseID;
            dgv_detainedLicenses.Columns[1].Width = 70;

            dgv_detainedLicenses.Columns[2].HeaderText = Str_LayoutManageDetainedLicenses.detainDate;
            dgv_detainedLicenses.Columns[2].Width = 100;

            dgv_detainedLicenses.Columns[3].HeaderText = Str_LayoutManageDetainedLicenses.isReleased;
            dgv_detainedLicenses.Columns[3].Width = 70;

            dgv_detainedLicenses.Columns[4].HeaderText = Str_LayoutManageDetainedLicenses.fineFees;
            dgv_detainedLicenses.Columns[4].Width = 70;
            
            dgv_detainedLicenses.Columns[5].HeaderText = Str_LayoutManageDetainedLicenses.releaseDate;
            dgv_detainedLicenses.Columns[5].Width = 100;

            dgv_detainedLicenses.Columns[6].HeaderText = Str_LayoutManagePeople.nationalNum;
            dgv_detainedLicenses.Columns[6].Width = 100;

            dgv_detainedLicenses.Columns[7].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_detainedLicenses.Columns[7].Width = 210;

            dgv_detainedLicenses.Columns[8].HeaderText = Str_LayoutManageDetainedLicenses.releaseAppID;
        }

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_detainedLicenses.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter == FilterByOptions.None) {
                _dtAllDetentions.DefaultView.RowFilter = string.Empty;
                cb_isReleased.Visible = txt_filterInput.Visible = false;
                _RefreshCountLabels();
                return;
            }

            if (_selectedFilter.In(FilterByOptions.DetainID, FilterByOptions.LocalLicenseID, FilterByOptions.NationalNum, FilterByOptions.ReleaseApplicationID))
                _SetInputFilterByMode(FilterInputTypes.DigitsOnly);
            else if (_selectedFilter == FilterByOptions.FineFees)
                _SetInputFilterByMode(FilterInputTypes.Numeric);
            else
                _SetInputFilterByMode(FilterInputTypes.Normal);

            if (_selectedFilter == FilterByOptions.IsReleased) {
                txt_filterInput.Visible = !(cb_isReleased.Visible = true);
                cb_isReleased.SelectedIndex = 0;
            } else {
                txt_filterInput.Visible = !(cb_isReleased.Visible = false);
                txt_filterInput.Text = string.Empty;
            }
        }

        private void _SetInputFilterByMode(FilterInputTypes inputMode) {
            FilterInputTypes _currentMode = (FilterInputTypes) txt_filterInput.Tag;

            switch (inputMode) {
                case FilterInputTypes.Normal:
                    if (_currentMode == FilterInputTypes.Numeric)
                        txt_filterInput.KeyPress -= txt_filterInput_KeyPress_Numeric;
                    else if (_currentMode == FilterInputTypes.DigitsOnly)
                        txt_filterInput.KeyPress -= txt_filterInput_KeyPress_DigitsOnly;

                    txt_filterInput.RightToLeft = Settings.Default.CurrentLanguage == SupportedLanguages.English ? RightToLeft.No : RightToLeft.Yes;
                    break;
                case FilterInputTypes.Numeric:
                    if (_currentMode == FilterInputTypes.DigitsOnly) {
                        txt_filterInput.KeyPress -= txt_filterInput_KeyPress_DigitsOnly;
                        txt_filterInput.KeyPress += txt_filterInput_KeyPress_Numeric;
                    } else if (_currentMode == FilterInputTypes.Normal)
                        txt_filterInput.KeyPress += txt_filterInput_KeyPress_Numeric;

                    txt_filterInput.RightToLeft = RightToLeft.No;
                    break;
                case FilterInputTypes.DigitsOnly:
                    if (_currentMode == FilterInputTypes.Numeric) {
                        txt_filterInput.KeyPress -= txt_filterInput_KeyPress_Numeric;
                        txt_filterInput.KeyPress += txt_filterInput_KeyPress_DigitsOnly;
                    } else if (_currentMode == FilterInputTypes.Normal)
                        txt_filterInput.KeyPress += txt_filterInput_KeyPress_DigitsOnly;

                    txt_filterInput.RightToLeft = RightToLeft.No;
                    break;
            }

            txt_filterInput.Tag = inputMode;
        }

        private void txt_filterInput_KeyPress_Numeric(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

        private void txt_filterInput_KeyPress_DigitsOnly(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void cb_isReleased_SelectedIndexChanged(object sender, EventArgs e) {
            _dtAllDetentions.DefaultView.RowFilter = cb_isReleased.SelectedIndex == 0 ? string.Empty : $"IsReleased = {2 - cb_isReleased.SelectedIndex}";
            _RefreshCountLabels();
        }

        private void txt_filterInput_TextChanged(object sender, EventArgs e) {
            var _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            if (_selectedFilter.In(FilterByOptions.DetainID, FilterByOptions.LocalLicenseID, FilterByOptions.ReleaseApplicationID, FilterByOptions.FineFees))
                _dtAllDetentions.DefaultView.RowFilter = txt_filterInput.Text == string.Empty ? string.Empty : $"{_selectedFilter} = {txt_filterInput.Text}";
            else if (_selectedFilter == FilterByOptions.DetainDate || _selectedFilter == FilterByOptions.ReleaseDate) {
                if (DateTime.TryParseExact(txt_filterInput.Text, BusinessUtils.DateTimeUtils.DateSearchFormat, null, System.Globalization.DateTimeStyles.None, out var _result))
                    _dtAllDetentions.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                else
                    _dtAllDetentions.DefaultView.RowFilter = string.Empty;
            } else
                _dtAllDetentions.DefaultView.RowFilter = $"{_selectedFilter} LIKE '%{txt_filterInput.Text}%'";

            _RefreshCountLabels();
        }

        private void _RefreshCountLabels() {
            lbl_noDataAvailable.Visible = dgv_detainedLicenses.RowCount == 0;
            label_numOfRecords.Text = dgv_detainedLicenses.RowCount.ToString();
        }

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void btn_detainLicense_Click(object sender, EventArgs e) {
            using (Frm_DetainLicense _frmDetainLicense = new Frm_DetainLicense()) {
                _frmDetainLicense.DataSaved += ReloadAllData;
                _frmDetainLicense.ForceExit += OnForceExit;
                _frmDetainLicense.ShowDialog();
                _frmDetainLicense.ForceExit -= OnForceExit;
                _frmDetainLicense.DataSaved -= ReloadAllData;
            }
        }

        private void btn_releaseDetainedLicense_Click(object sender, EventArgs e) {
            using (Frm_ReleaseDetainedLicense _frmReleaseDetainedLicense = new Frm_ReleaseDetainedLicense()) {
                _frmReleaseDetainedLicense.DataSaved += ReloadAllData;
                _frmReleaseDetainedLicense.ForceExit += OnForceExit;
                _frmReleaseDetainedLicense.ShowDialog();
                _frmReleaseDetainedLicense.ForceExit -= OnForceExit;
                _frmReleaseDetainedLicense.DataSaved -= ReloadAllData;
            }
        }

        private void showDriverDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowDriverInformation _frmShowDriverInfo = new Frm_ShowDriverInformation(LocalDrivingLicense.FindDriverId((int) dgv_detainedLicenses.CurrentRow.Cells[1].Value))) {
                if (_frmShowDriverInfo.IsDisposed)
                    return;
                
                _frmShowDriverInfo.DriverSaved += _frm_DataSaved;
                _frmShowDriverInfo.ShowDialog();
                _frmShowDriverInfo.DriverSaved -= _frm_DataSaved;
            }
        }

        private void _frm_DataSaved(int _) => ReloadAllData();

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            showDriverDetailsToolStripMenuItem.Enabled = dgv_detainedLicenses.RowCount > 0 && GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            showLicenseDetailsToolStripMenuItem.Enabled = dgv_detainedLicenses.RowCount > 0 && GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            showDriverLicenseHistoryToolStripMenuItem.Enabled = dgv_detainedLicenses.RowCount > 0 && (GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter));
            releaseDetailedLicenseToolStripMenuItem.Enabled = dgv_detainedLicenses.RowCount > 0 && GlobalFields.ActiveUserPermissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ReleaseDetainedLicense) && GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            releaseDetailedLicenseToolStripMenuItem.Enabled &= !(bool) dgv_detainedLicenses.CurrentRow.Cells[3].Value;
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowLocalLicenseInformation _frmShowLocalLicenseInfo = new Frm_ShowLocalLicenseInformation((int) dgv_detainedLicenses.CurrentRow.Cells[1].Value)) {
                if (_frmShowLocalLicenseInfo.IsDisposed)
                    return;

                _frmShowLocalLicenseInfo.PersonSaved += _frm_DataSaved;
                _frmShowLocalLicenseInfo.ShowDialog();
                _frmShowLocalLicenseInfo.PersonSaved -= _frm_DataSaved;
            }
        }

        private void showDriverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ShowDriverLicenseHistory _frmShowDriverLicenseHistory = new Frm_ShowDriverLicenseHistory(LocalDrivingLicense.FindPersonId((int) dgv_detainedLicenses.CurrentRow.Cells[1].Value))) {
                if (_frmShowDriverLicenseHistory.IsDisposed)
                    return;

                _frmShowDriverLicenseHistory.ForceExit += OnForceExit;
                _frmShowDriverLicenseHistory.DataSaved += ReloadAllData;
                _frmShowDriverLicenseHistory.ShowDialog();
                _frmShowDriverLicenseHistory.DataSaved -= ReloadAllData;
                _frmShowDriverLicenseHistory.ForceExit -= OnForceExit;
            }
        }

        private void releaseDetailedLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ReleaseDetainedLicense _frmReleaseDetainedLicense = new Frm_ReleaseDetainedLicense((int) dgv_detainedLicenses.CurrentRow.Cells[1].Value)) {
                if (_frmReleaseDetainedLicense.IsDisposed)
                    return;

                _frmReleaseDetainedLicense.ForceExit += OnForceExit;
                _frmReleaseDetainedLicense.DataSaved += ReloadAllData;
                _frmReleaseDetainedLicense.ShowDialog();
                _frmReleaseDetainedLicense.DataSaved -= ReloadAllData;
                _frmReleaseDetainedLicense.ForceExit -= OnForceExit;
            }
        }

        private void dgv_detainedLicenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (e.Value == DBNull.Value) {
                e.CellStyle.ForeColor = Color.Red;
                e.Value = Resources.txt_unknownField;
                e.FormattingApplied = true;
            } else if (dgv_detainedLicenses.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            }
        }
        
        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManageDetainedLicenses.detainedLicenses, (_dtAllDetentions ?? LicenseDetention.GetAllLicenseDetains()).DefaultView);

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_isReleased.Enabled = txt_filterInput.Enabled = dgv_detainedLicenses.Enabled = ll_refreshData.Enabled = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ViewAllDetainedLicenses);
            btn_detain.Enabled = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.DetainLicense);
            btn_release.Enabled = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ReleaseDetainedLicense);
            ll_exportData.Enabled = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ExportDetainedLicensesData);
            showDriverDetailsToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            showLicenseDetailsToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            showDriverLicenseHistoryToolStripMenuItem.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);

            lbl_noDataAvailable.Text = permissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ViewAllDetainedLicenses) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
