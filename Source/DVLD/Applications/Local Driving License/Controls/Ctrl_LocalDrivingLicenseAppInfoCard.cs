using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Licenses;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications.Local_Driving_License.Controls {
    public partial class Ctrl_LocalDrivingLicenseAppInfoCard : UserControl, IEnforcePermissions {
        public event Action<int> PersonSaved;
        private LocalDrivingLicenseApp _LocalDrivingLicenseApp = null;

        public int LocalDrivingLicenseAppID {
            get => _LocalDrivingLicenseApp is null ? -1 : _LocalDrivingLicenseApp.LDLAppID;
            set {
                _LocalDrivingLicenseApp = value == -1 ? null : LocalDrivingLicenseApp.Find(value);

                if (_LocalDrivingLicenseApp is null)
                    _ResetCard();
                else
                    _RefreshCard();
            }
        }

        private void _RefreshCard() {
            lbl_lDLAppID.Text = _LocalDrivingLicenseApp.LDLAppID.ToString();
            lbl_numOfPassedTests.Text = _LocalDrivingLicenseApp.NumOfPassedTests.ToString() + "/3";
            lbl_numOfPassedTests.MatchParentForeColor = false;
            lbl_numOfPassedTests.ForeColor = BusinessUtils.Mapping.GetPassedTestsColor(_LocalDrivingLicenseApp.NumOfPassedTests);
            lbl_appliedForWhichLicense.Text = _LocalDrivingLicenseApp.LicenseClassInfo.GetClassName(Settings.Default.CurrentLanguage);
            ctrl_ApplicationInfoCard1.ApplicationID = _LocalDrivingLicenseApp.BaseApplicationID;
            ll_viewLicenseInfo.Enabled = _LocalDrivingLicenseApp.ApplicationStatus == ApplicationStatus.Completed && GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
        }

        private void _ResetCard() {
            lbl_lDLAppID.Text = lbl_numOfPassedTests.Text = lbl_appliedForWhichLicense.Text = Resources.txt_unknownField;
            lbl_numOfPassedTests.MatchParentForeColor = true;
            ctrl_ApplicationInfoCard1.ApplicationID = -1;
            ll_viewLicenseInfo.Enabled = false;
        }

        public Ctrl_LocalDrivingLicenseAppInfoCard() {
            InitializeComponent();

            if (GlobalFields.ActiveUserPermissions != null)
                EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void ll_viewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowLocalLicenseInformation _frmShowLocalLicenseInfo = new Frm_ShowLocalLicenseInformation(LocalDrivingLicense.FindLocalLicenseID_ByLocalDrivingLicenseAppID(_LocalDrivingLicenseApp.LDLAppID, _LocalDrivingLicenseApp.LicenseClassID))) {
                if (_frmShowLocalLicenseInfo.IsDisposed)
                    return;

                _frmShowLocalLicenseInfo.PersonSaved += ctrl_ApplicationInfoCard1_PersonSaved;
                _frmShowLocalLicenseInfo.ShowDialog();
                _frmShowLocalLicenseInfo.PersonSaved -= ctrl_ApplicationInfoCard1_PersonSaved;
            }
        }

        private void ctrl_ApplicationInfoCard1_PersonSaved(int personID) => PersonSaved?.Invoke(personID);

        public void LoadDirectlyFromObject(LocalDrivingLicenseApp localDrivingLicenseApp) {
            _LocalDrivingLicenseApp = localDrivingLicenseApp;
            _RefreshCard();
        }

        public void ReloadCard() => LocalDrivingLicenseAppID = LocalDrivingLicenseAppID; //It looks stupid, but it is not.

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ll_viewLicenseInfo.Enabled = permissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
    }
}
