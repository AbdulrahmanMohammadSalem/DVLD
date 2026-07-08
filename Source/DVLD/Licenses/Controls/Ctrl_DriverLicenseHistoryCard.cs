using DVLD.Applications.Renew_Driving_License;
using DVLD.Applications.Replacement_for_Lost_Damaged;
using DVLD.Common;
using DVLD.Detain_Licenses;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD.String_Resources.User_Controls;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Licenses.Controls {
    public partial class Ctrl_DriverLicenseHistoryCard : UserControl, IEnforcePermissions {
        public event Action DataSaved, ForceExit;
        private int _driverID = -1;

        [DefaultValue(-1)]
        public int DriverID {
            get => _driverID;
            set {
                if (value == -1 || !Driver.DoesExist(value)) {
                    _driverID = -1;

                    dgv_localHistory.DataSource = dgv_interHistory.DataSource = null;
                    lbl_localNumOfRecords.Text = lbl_interNumOfRecords.Text = Resources.txt_unknownField;
                    lbl_localNoDataAvailable.Visible = lbl_interNoDataAvailable.Visible = true;
                    ll_localRefreshData.Enabled = ll_interRefreshData.Enabled = ll_localExportData.Enabled = ll_interExportData.Enabled = false;
                } else {
                    _driverID = value;

                    if (GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local))
                        _ReloadLocalData();
                    
                    if (GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter))
                        _ReloadInterData();
                }
            }
        }

        private void _SetupInterHistoryTableHeader() {
            dgv_interHistory.Columns[0].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.interLicenseID;
            dgv_interHistory.Columns[1].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.applicationID;
            dgv_interHistory.Columns[2].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.localLicenseID;
            dgv_interHistory.Columns[3].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.issueDate;
            dgv_interHistory.Columns[4].HeaderText = Str_LayoutManageInternationalDrivingLicenseApps.expirationDate;
            dgv_interHistory.Columns[5].HeaderText = Str_LayoutManageUsers.isActive;
        }

        private void _SetupLocalHistoryTableHeader() {
            dgv_localHistory.Columns[0].HeaderText = Str_CtrlDriverLicenseHistoryCard.licenseID;
            dgv_localHistory.Columns[1].HeaderText = Str_CtrlDriverLicenseHistoryCard.applicationID;
            dgv_localHistory.Columns[2].HeaderText = Str_LayoutManageLocalDrivingLicenseApps.licenseClass;
            dgv_localHistory.Columns[3].HeaderText = Str_CtrlDriverLicenseHistoryCard.issueDate;
            dgv_localHistory.Columns[4].HeaderText = Str_CtrlDriverLicenseHistoryCard.expirationDate;
            dgv_localHistory.Columns[5].HeaderText = Str_LayoutManageUsers.isActive;
            dgv_localHistory.Columns[6].Visible = false;
        }

        public Ctrl_DriverLicenseHistoryCard() {
            InitializeComponent();

            if (GlobalFields.ActiveUserPermissions != null)
                EnforcePermissions(GlobalFields.ActiveUserPermissions);

            _ProcessNoDataAvailableLabel(lbl_localNoDataAvailable);
            _ProcessNoDataAvailableLabel(lbl_interNoDataAvailable);

            if (Settings.Default.CurrentLanguage == SupportedLanguages.English) {
                ll_localExportData.Location = ll_interExportData.Location = new System.Drawing.Point(ll_localRefreshData.Location.X - ll_localRefreshData.Width - 6, ll_localRefreshData.Location.Y);
                ll_localExportData.Anchor = ll_interExportData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            } else {
                ll_localExportData.Location = ll_interExportData.Location = new System.Drawing.Point(ll_localRefreshData.Location.X + ll_localRefreshData.Width + 6, ll_localRefreshData.Location.Y);
                ll_localExportData.Anchor = ll_interExportData.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }

            detainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showInterLicenseToolStripMenuItem1.RightToLeftAutoMirrorImage = showLocalLicenseToolStripMenuItem.RightToLeftAutoMirrorImage = renewLicenseToolStripMenuItem.RightToLeftAutoMirrorImage = issueReplacementForLicenseToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            detainLicenseToolStripMenuItem.Tag = (byte) 0; //Detain

            cms_local.Renderer = cms_inter.Renderer = GlobalFields.ToolStripRenderer;

            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_localHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interHistory);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            if (tabControl1.RightToLeft == RightToLeft.Yes) {
                tabControl1.TabLocation = Manina.Windows.Forms.TabLocation.TopRight;
                tabControl1.ReverseTabsOrder();
                tabControl1.SelectedTab = tb_inter;
                tabControl1.SelectedTab = tb_local;
            }
        }

        private void _ProcessNoDataAvailableLabel(Label lbl) {
            lbl.AutoSize = false;
            lbl.Width = dgv_localHistory.Width - 20;
            lbl.Location = new System.Drawing.Point(dgv_localHistory.Location.X + 10, lbl.Location.Y);
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) {
            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_localHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interHistory);
        }

        private void ll_localRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadLocalData();

        private void _ReloadLocalData() {
            dgv_localHistory.DataSource = LocalDrivingLicense.GetPreferredLocalLicensesView(_driverID, Settings.Default.CurrentLanguage);
            _SetupLocalHistoryTableHeader();
            lbl_localNumOfRecords.Text = dgv_localHistory.RowCount.ToString();
            lbl_localNoDataAvailable.Visible = dgv_localHistory.RowCount == 0;
            ll_localRefreshData.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local);
            ll_localExportData.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ExportLocalLicensesData);
        }

        private void ll_interRefreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => _ReloadInterData();

        private void _ReloadInterData() {
            dgv_interHistory.DataSource = InternationalDrivingLicense.GetPreferredInternationalLicensesView(_driverID);
            _SetupInterHistoryTableHeader();
            lbl_interNumOfRecords.Text = dgv_interHistory.RowCount.ToString();
            lbl_interNoDataAvailable.Visible = dgv_interHistory.RowCount == 0;
            ll_interRefreshData.Enabled = GlobalFields.ActiveUserPermissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
            ll_interExportData.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ExportInterLicensesData);
        }

        private void dgv_interHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo))
                _DisplayCurrentlySelectedInterLicenseInfo();
        }

        private void dgv_localHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo))
                _DisplayCurrentlySelectedLocalLicenseInfo();
        }

        private void _DisplayCurrentlySelectedInterLicenseInfo() {
            using (Frm_ShowInternationalLicenseInformation _frmShowInterLicenseInfo = new Frm_ShowInternationalLicenseInformation((int) dgv_interHistory.CurrentRow.Cells[0].Value)) {
                if (_frmShowInterLicenseInfo.IsDisposed)
                    return;

                _frmShowInterLicenseInfo.DataSaved += _frmShowInterLicenseInfo_DataSaved;
                _frmShowInterLicenseInfo.ShowDialog();
                _frmShowInterLicenseInfo.DataSaved -= _frmShowInterLicenseInfo_DataSaved;
            }
        }

        private void _frmShowInterLicenseInfo_DataSaved() => DataSaved?.Invoke();

        private void _DisplayCurrentlySelectedLocalLicenseInfo() {
            using (Frm_ShowLocalLicenseInformation _frmShowLocalLicenseInfo = new Frm_ShowLocalLicenseInformation((int) dgv_localHistory.CurrentRow.Cells[0].Value)) {
                if (_frmShowLocalLicenseInfo.IsDisposed)
                    return;

                _frmShowLocalLicenseInfo.PersonSaved += _frmShowLocalLicenseInfo_PersonSaved;
                _frmShowLocalLicenseInfo.ShowDialog();
                _frmShowLocalLicenseInfo.PersonSaved -= _frmShowLocalLicenseInfo_PersonSaved;
            }
        }

        private void _frmShowLocalLicenseInfo_PersonSaved(int personID) => DataSaved?.Invoke();

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (((DataGridView) sender).Columns[e.ColumnIndex].ValueType == typeof(DateTime)) {
                e.Value = BusinessUtils.DateTimeUtils.FormatDateTime((DateTime) e.Value);
                e.FormattingApplied = true;
            }
        }

        private void cms_local_Opening(object sender, CancelEventArgs e) {
            if (dgv_localHistory.RowCount == 0) {
                renewLicenseToolStripMenuItem.Enabled = issueReplacementForLicenseToolStripMenuItem.Enabled = detainLicenseToolStripMenuItem.Enabled = false;
                return;
            }

            bool _isLicenseActive = (bool) dgv_localHistory.CurrentRow.Cells[5].Value;

            if (_isLicenseActive) {
                renewLicenseToolStripMenuItem.Enabled = false;
                issueReplacementForLicenseToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.IssueLicenseReplacement) && GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            } else {
                renewLicenseToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.RenewLicense) && GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo) &&!LocalDrivingLicense.DoesDriverOwnActiveLocalLicenseOfClass(_driverID, (LicenseClasses) dgv_localHistory.CurrentRow.Cells[6].Value);
                issueReplacementForLicenseToolStripMenuItem.Enabled = false;
            }

            if (LicenseDetention.CheckIfDetained((int) dgv_localHistory.CurrentRow.Cells[0].Value)) {
                detainLicenseToolStripMenuItem.Tag = (byte) 1; //Release
                detainLicenseToolStripMenuItem.Text = Str_CtrlDriverLicenseHistoryCard.releaseLicense;
                detainLicenseToolStripMenuItem.Image = Resources.Release_Detained_License_32;
                detainLicenseToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.LicenseDetention.HasFlag(LicenseDetentionManagement.ReleaseDetainedLicense);
            } else {
                detainLicenseToolStripMenuItem.Tag = (byte) 0; //Detain
                detainLicenseToolStripMenuItem.Text = Str_CtrlDriverLicenseHistoryCard.detainLicense;
                detainLicenseToolStripMenuItem.Image = Resources.Detain_32;
                detainLicenseToolStripMenuItem.Enabled = _isLicenseActive && GlobalFields.ActiveUserPermissions.LicenseDetention.HasFlag(LicenseDetentionManagement.DetainLicense);
            }
        }

        private void cms_inter_Opening(object sender, CancelEventArgs e) => showInterLicenseToolStripMenuItem1.Enabled = dgv_interHistory.RowCount > 0;

        private void showInterLicenseToolStripMenuItem1_Click(object sender, EventArgs e) => _DisplayCurrentlySelectedInterLicenseInfo();

        private void showLocalLicenseToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayCurrentlySelectedLocalLicenseInfo();

        private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_RenewLocalDrivingLicense _frmRenewLocalLicense = new Frm_RenewLocalDrivingLicense((int) dgv_localHistory.CurrentRow.Cells[0].Value)) {
                if (_frmRenewLocalLicense.IsDisposed)
                    return;

                _frmRenewLocalLicense.DataSaved += _RefreshEverythingLocal;
                _frmRenewLocalLicense.ForceExit += _frm_ForceExit;
                _frmRenewLocalLicense.ShowDialog();
                _frmRenewLocalLicense.ForceExit -= () => ForceExit?.Invoke();
                _frmRenewLocalLicense.DataSaved -= _frm_ForceExit;
            }
        }

        private void _RefreshEverythingLocal() {
            _ReloadLocalData();
            DataSaved?.Invoke();
        }

        private void Ctrl_DriverLicenseHistoryCard_Load(object sender, EventArgs e) {
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_localHistory);
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_interHistory);
        }

        private void issueReplacementForLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_ReplacementForLostDamagedApplication _frmIssueReplacement = new Frm_ReplacementForLostDamagedApplication((int) dgv_localHistory.CurrentRow.Cells[0].Value)) {
                if (_frmIssueReplacement.IsDisposed)
                    return;
            
                _frmIssueReplacement.DataSaved += _RefreshEverythingLocal;
                _frmIssueReplacement.ForceExit += _frm_ForceExit;
                _frmIssueReplacement.ShowDialog();
                _frmIssueReplacement.ForceExit -= _frm_ForceExit;
                _frmIssueReplacement.DataSaved -= _RefreshEverythingLocal;
            }
        }

        private void _frm_ForceExit() => ForceExit?.Invoke();

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e) {
            if ((byte) detainLicenseToolStripMenuItem.Tag == 0) //Detain
                _DisplayDetainSelectedLicense();
            else //Release
                _DisplayReleaseSelectedLicense();
        }

        private void _DisplayReleaseSelectedLicense() {
            using (Frm_ReleaseDetainedLicense _frmReleaseDetainedLicense = new Frm_ReleaseDetainedLicense((int) dgv_localHistory.CurrentRow.Cells[0].Value)) {
                if (_frmReleaseDetainedLicense.IsDisposed)
                    return;

                _frmReleaseDetainedLicense.DataSaved += _RefreshEverythingLocal;
                _frmReleaseDetainedLicense.ForceExit += _frm_ForceExit;
                _frmReleaseDetainedLicense.ShowDialog();
                _frmReleaseDetainedLicense.ForceExit -= _frm_ForceExit;
                _frmReleaseDetainedLicense.DataSaved -= _RefreshEverythingLocal;
            }
        }

        private void ll_localExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_CtrlDriverLicenseHistoryCard.localLicensesHistory, dgv_localHistory.DataSource as DataView ?? LocalDrivingLicense.GetPreferredLocalLicensesView(_driverID, Settings.Default.CurrentLanguage));

        private void ll_interExportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_CtrlDriverLicenseHistoryCard.interLicensesHistory, dgv_interHistory.DataSource as DataView ?? InternationalDrivingLicense.GetPreferredInternationalLicensesView(_driverID));

        private void _DisplayDetainSelectedLicense() {
            using (Frm_DetainLicense _frmDetainLicense = new Frm_DetainLicense((int) dgv_localHistory.CurrentRow.Cells[0].Value)) {
                if (_frmDetainLicense.IsDisposed)
                    return;

                _frmDetainLicense.DataSaved += _RefreshEverythingLocal;
                _frmDetainLicense.ForceExit += _frm_ForceExit;
                _frmDetainLicense.ShowDialog();
                _frmDetainLicense.ForceExit -= _frm_ForceExit;
                _frmDetainLicense.DataSaved -= _RefreshEverythingLocal;
            }
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            dgv_localHistory.Enabled = ll_localRefreshData.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local);
            ll_localRefreshData.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ExportLocalLicensesData);

            dgv_interHistory.Enabled = ll_interRefreshData.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
            ll_interRefreshData.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ExportInterLicensesData);

            showLocalLicenseToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            renewLicenseToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.RenewLicense) && permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
            issueReplacementForLicenseToolStripMenuItem.Enabled = permissions.Licenses.HasFlag(LicensesManagement.IssueLicenseReplacement) && permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);

            showInterLicenseToolStripMenuItem1.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullInterLicenseInfo);

            lbl_localNoDataAvailable.Text = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
            lbl_interNoDataAvailable.Text = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
