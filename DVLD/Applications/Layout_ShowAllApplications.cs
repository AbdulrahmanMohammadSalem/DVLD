using DVLD.Applications.Local_Driving_License;
using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications {
    public partial class Layout_ShowAllApplications : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private DataTable _dtAllApplications;

        private enum FilterByOptions : byte {
            None, ApplicationID, ApplicantPersonID, FullName, ApplicationTypeTitle,
            ApplicationDate, ApplicationStatus, UpdateStatusDate, FeesPaid, CreatedBy
        }

        private enum ComboBoxInputTypes : byte {
            Normal, Numeric, DigitsOnly
        }

        public Layout_ShowAllApplications() {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == SupportedLanguages.English)
                cb_inputFilterBy.Height += 3;

            EnforcePermissions(GlobalFields.ActiveUserPermissions);
            
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_applications);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            cb_inputFilterBy.Tag = ComboBoxInputTypes.Normal;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_applications);

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        public void ReloadAllData() {
            _dtAllApplications = DVLD_Business.Application.GetAllApplications(Settings.Default.CurrentLanguage);
            dgv_applications.DataSource = _dtAllApplications;
            RefreshDataFiltering();
        }

        public void RefreshDataFiltering() {
            if (cb_inputFilterBy.Text == string.Empty || cb_filterBy.SelectedIndex == (int) FilterByOptions.None || ((cb_filterBy.SelectedIndex == (int) FilterByOptions.ApplicationTypeTitle || cb_filterBy.SelectedIndex == (int) FilterByOptions.ApplicationStatus) && cb_inputFilterBy.SelectedIndex == 0))
                _dtAllApplications.DefaultView.RowFilter = string.Empty;
            else {
                FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

                if (_selectedFilter == FilterByOptions.ApplicationID || _selectedFilter == FilterByOptions.ApplicantPersonID)
                    _dtAllApplications.DefaultView.RowFilter = $"{_selectedFilter} = '{cb_inputFilterBy.Text}'";
                else if (_selectedFilter == FilterByOptions.FeesPaid)
                    _dtAllApplications.DefaultView.RowFilter = $"FeesPaid LIKE '{cb_inputFilterBy.Text}%'";
                else if (_selectedFilter == FilterByOptions.ApplicationTypeTitle)
                    _dtAllApplications.DefaultView.RowFilter = $"{_selectedFilter} = '{cb_inputFilterBy.Text}'";
                else if (_selectedFilter == FilterByOptions.ApplicationStatus)
                    _dtAllApplications.DefaultView.RowFilter = $"{_selectedFilter} = '{cb_inputFilterBy.SelectedIndex}'";
                else if (_selectedFilter == FilterByOptions.ApplicationDate || _selectedFilter == FilterByOptions.UpdateStatusDate) {
                    if (DateTime.TryParseExact(cb_inputFilterBy.Text, BusinessUtils.DateTimeUtils.DateSearchFormat, null, System.Globalization.DateTimeStyles.None, out var _result))
                        _dtAllApplications.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                    else
                        _dtAllApplications.DefaultView.RowFilter = string.Empty;
                } else
                    _dtAllApplications.DefaultView.RowFilter = $"{_selectedFilter} LIKE '%{cb_inputFilterBy.Text}%'";
            }

            label_numOfRecords.Text = dgv_applications.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_applications.RowCount == 0;
        }

        private void Layout_ShowAllApplications_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps) && GlobalFields.ActiveUserPermissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps)) {
                cb_filterBy.SelectedIndex = 0;
                ReloadAllData();

                _SetupTableHeader();
            }
        }

        private void _SetupTableHeader() {
            dgv_applications.Columns[9].Visible = false;

            dgv_applications.Columns[0].HeaderText = Str_LayoutShowAllApplications.applicationID;
            dgv_applications.Columns[0].Width = 62;

            dgv_applications.Columns[1].HeaderText = Str_LayoutShowAllApplications.applicantID;
            dgv_applications.Columns[1].Width = 58;

            dgv_applications.Columns[2].HeaderText = Str_LayoutManageUsers.fullName;
            dgv_applications.Columns[2].Width = 200;

            dgv_applications.Columns[3].HeaderText = Str_LayoutShowAllApplications.applicationType;
            dgv_applications.Columns[3].Width = 150;

            dgv_applications.Columns[4].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.applicationDate;
            dgv_applications.Columns[4].Width = 90;

            dgv_applications.Columns[5].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.status;
            dgv_applications.Columns[5].Width = 70;

            dgv_applications.Columns[6].HeaderText = Str_LayoutShowAllApplications.statusUpdateDate;
            dgv_applications.Columns[6].Width = 90;

            dgv_applications.Columns[7].HeaderText = Str_LayoutShowAllApplications.feesPaid;
            dgv_applications.Columns[7].Width = 75;

            dgv_applications.Columns[8].HeaderText = Str_LayoutShowAllApplications.createdBy;
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_applications.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

            cb_inputFilterBy.Visible = _selectedFilter != FilterByOptions.None;

            if (_selectedFilter == FilterByOptions.ApplicationID || _selectedFilter == FilterByOptions.ApplicantPersonID)
                _SetInputFilterByMode(ComboBoxInputTypes.DigitsOnly);
            else if (_selectedFilter == FilterByOptions.FeesPaid)
                _SetInputFilterByMode(ComboBoxInputTypes.Numeric);
            else
                _SetInputFilterByMode(ComboBoxInputTypes.Normal);

            if (_selectedFilter == FilterByOptions.ApplicationTypeTitle) {
                if (cb_inputFilterBy.Items.Count == 0 || cb_inputFilterBy.Items.Count != 7) {
                    cb_inputFilterBy.Items.Clear();
                    cb_inputFilterBy.Items.Add(Resources.txt_all);
                    cb_inputFilterBy.Items.AddRange(ApplicationType.GetTypeTitles(Settings.Default.CurrentLanguage));
                }

                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_inputFilterBy.DropDownWidth = cb_inputFilterBy.Width + 40;
                cb_inputFilterBy.SelectedIndex = 0; //To clear filtering and show all records
            } else if (_selectedFilter == FilterByOptions.ApplicationStatus) {
                if (cb_inputFilterBy.Items.Count == 0 || cb_inputFilterBy.Items.Count != 3) {
                    cb_inputFilterBy.Items.Clear();
                    cb_inputFilterBy.Items.Add(Resources.txt_all);
                    cb_inputFilterBy.Items.AddRange(new string[3] { Str_LayoutManageLocalDrivingLicenseApps._new, Str_LayoutManageLocalDrivingLicenseApps.completed, Str_LayoutManageLocalDrivingLicenseApps.cancelled });
                }

                
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_inputFilterBy.DropDownWidth = cb_inputFilterBy.Width;
                cb_inputFilterBy.SelectedIndex = 0; //To clear filtering and show all records
            } else {
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.Simple;
                cb_inputFilterBy.Text = string.Empty; //To clear filtering and show all records
            }
        }

        private void _SetInputFilterByMode(ComboBoxInputTypes inputMode) {
            ComboBoxInputTypes _currentMode = (ComboBoxInputTypes) cb_inputFilterBy.Tag;

            switch (inputMode) {
                case ComboBoxInputTypes.Normal:
                    if (_currentMode == ComboBoxInputTypes.Numeric)
                        cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress_Numeric;
                    else if (_currentMode == ComboBoxInputTypes.DigitsOnly)
                        cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress_DigitsOnly;

                    break;
                case ComboBoxInputTypes.Numeric:
                    if (_currentMode == ComboBoxInputTypes.DigitsOnly) {
                        cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress_DigitsOnly;
                        cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress_Numeric;
                    }
                    else if (_currentMode == ComboBoxInputTypes.Normal)
                        cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress_Numeric;

                    break;
                case ComboBoxInputTypes.DigitsOnly:
                    if (_currentMode == ComboBoxInputTypes.Numeric) {
                        cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress_Numeric;
                        cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress_DigitsOnly;
                    } else if (_currentMode == ComboBoxInputTypes.Normal)
                        cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress_DigitsOnly;

                    break;
            }

            cb_inputFilterBy.Tag = inputMode;
        }

        private void ComboBox_inputFilterBy_KeyPress_DigitsOnly(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void ComboBox_inputFilterBy_KeyPress_Numeric(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';

        private void comboBox_inputFilterBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void dgv_applications_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (e.Value == DBNull.Value) {
                e.CellStyle.ForeColor = Color.Red;
                e.Value = Resources.txt_unknownField;
                e.FormattingApplied = true;
                return;
            }

            if (dgv_applications.Columns[e.ColumnIndex].Name == "ApplicationStatus") {
                ApplicationStatus _status = (ApplicationStatus) e.Value;

                e.CellStyle.ForeColor = BusinessUtils.Mapping.GetApplicationStatusColor(_status);
                e.Value = BusinessUtils.Mapping.GetApplicationStatusString(_status);
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold | FontStyle.Italic);
                e.FormattingApplied = true;
            } else if (dgv_applications.Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            }
        }

        private void dgv_applications_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if ((ApplicationTypes) dgv_applications.CurrentRow.Cells[9].Value == ApplicationTypes.NewLocalLicense) {
                if (GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ViewFullAppDetails))
                    _DisplayLocalLicenseApplicationInfo();
            }
            else
                _DisplayGenericApplicationDetails();
        }

        private void _DisplayGenericApplicationDetails() {
            using (Frm_ShowApplicationBasicInfo _frmShowApplicationInfo = new Frm_ShowApplicationBasicInfo((int) dgv_applications.CurrentRow.Cells[0].Value)) {
                if (_frmShowApplicationInfo.IsDisposed)
                    return;

                _frmShowApplicationInfo.DataSaved += ReloadAllData;
                _frmShowApplicationInfo.ShowDialog();
                _frmShowApplicationInfo.DataSaved -= ReloadAllData;
            }
        }

        private void _DisplayLocalLicenseApplicationInfo() {
            using (Frm_ShowLocalDrivingLicenseAppInformation _frmLocalAppInfo = new Frm_ShowLocalDrivingLicenseAppInformation(LocalDrivingLicenseApp.FindLocalDrivingLicenseApplicationID((int) dgv_applications.CurrentRow.Cells[0].Value))) {
                if (_frmLocalAppInfo.IsDisposed)
                    return;

                _frmLocalAppInfo.PersonSaved += _frmLocalAppInfo_PersonSaved;
                _frmLocalAppInfo.ShowDialog();
                _frmLocalAppInfo.PersonSaved -= _frmLocalAppInfo_PersonSaved;
            }
        }

        private void _frmLocalAppInfo_PersonSaved(int personID) => ReloadAllData();

        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutShowAllApplications.allApps, (_dtAllApplications ?? DVLD_Business.Application.GetAllApplications(Settings.Default.CurrentLanguage)).DefaultView);

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_inputFilterBy.Enabled = dgv_applications.Enabled = linkLabel_refreshData.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.SeeAllLocalLicenseApps) && permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.SeeAllInterLicenseApps);
            ll_exportData.Enabled = permissions.LocalLicenseApps.HasFlag(LocalLicenseAppsManagement.ExportLocalLicenseAppsData) && permissions.InterLicenseApps.HasFlag(InterLicenseAppsManagement.ExportInterLicenseAppsData);
            lbl_noDataAvailable.Text = lbl_filterBy.Enabled ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
