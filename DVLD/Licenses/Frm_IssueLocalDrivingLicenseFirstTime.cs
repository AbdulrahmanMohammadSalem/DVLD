using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses {
    public partial class Frm_IssueLocalDrivingLicenseFirstTime : SalForm {
        public event Action DataSaved, ForceExit;
        private LocalDrivingLicenseApp _LocalDrivingLicenseApp = null;

        public Frm_IssueLocalDrivingLicenseFirstTime(int localDrivingLicenseAppID) {
            _LocalDrivingLicenseApp = LocalDrivingLicenseApp.Find(localDrivingLicenseAppID);

            if (_LocalDrivingLicenseApp is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (_LocalDrivingLicenseApp.NumOfPassedTests != 3) {
                MessageBox.Show(Str_FrmIssueLocalDrivingLicenseFirstTime.personMustPassAllTests, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            if (LocalDrivingLicense.DoesLicenseExistForPerson(_LocalDrivingLicenseApp.ApplicantPersonID, _LocalDrivingLicenseApp.LicenseClassID)) {
                MessageBox.Show(Str_FrmIssueLocalDrivingLicenseFirstTime.personAlreadyHaveLicense, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();
        }

        private void btn_issue_Click(object sender, EventArgs e) {
            txtBx_notes.Text = txtBx_notes.Text.Trim();

            //Checking the Active User:
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                _LocalDrivingLicenseApp.MakeNew();
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                ForceExit?.Invoke();
                return;
            }

            int _newLocalLicenseID = _LocalDrivingLicenseApp.IssueLicenseFirstTime(string.IsNullOrEmpty(txtBx_notes.Text) ? null : txtBx_notes.Text, _activeUser.UserID);

            if (_newLocalLicenseID == -1)
                MessageBox.Show(Str_FrmIssueLocalDrivingLicenseFirstTime.localLicenseSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                lbl_lDLID.Text = _newLocalLicenseID.ToString();
                txtBx_notes.Enabled = btn_issue.Enabled = false;
                ctrl_LocalDrivingLicenseAppInfoCard1.ReloadCard();

                DataSaved?.Invoke();
                MessageBox.Show(Str_FrmIssueLocalDrivingLicenseFirstTime.licenseSavedSuccessfullyWithID + _newLocalLicenseID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved(int _) => DataSaved?.Invoke();

        private void Frm_IssueDrivingLicenseFirstTime_Activated(object sender, EventArgs e) => txtBx_notes.Focus();

        private void Frm_IssueDrivingLicenseFirstTime_Load(object sender, System.EventArgs e) {
            User _activeUser = GlobalFields.ActiveUserInfo;

            if (_activeUser is null || !_activeUser.IsActive) {
                MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                ForceExit?.Invoke();
                return;
            }
            
            ctrl_LocalDrivingLicenseAppInfoCard1.LoadDirectlyFromObject(_LocalDrivingLicenseApp);
            lbl_createdBy.Text = _activeUser.Username;
            lbl_licenseReleaseDate.Text = BusinessUtils.DateTimeUtils.FormatDate(DateTime.Now);
            lbl_licenseClassFees.Text = LicenseClass.GetFees(_LocalDrivingLicenseApp.LicenseClassID).ToString("C2");
        }
    }
}
