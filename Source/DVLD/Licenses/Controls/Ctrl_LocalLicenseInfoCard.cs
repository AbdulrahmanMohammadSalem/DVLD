using DVLD.Common;
using DVLD.People;
using DVLD.Properties;
using DVLD.String_Resources.User_Controls;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls {
    public partial class Ctrl_LocalLicenseInfoCard : UserControl {
        public event Action<int> PersonSaved;
        private LocalDrivingLicense _LocalDrivingLicense = null;

        [DefaultValue(-1)]
        public int LocalDrivingLicenseID {
            get => _LocalDrivingLicense is null ? -1 : _LocalDrivingLicense.LocalDrivingLicenseID;
            set {
                _LocalDrivingLicense = value == -1 ? null : LocalDrivingLicense.Find(value);

                if (_LocalDrivingLicense is null)
                    _ResetCard();
                else
                    _RefreshCard();
            }
        }

        public LocalDrivingLicense SelectedLocalDrivingLicense => _LocalDrivingLicense;

        public LocalDrivingLicense SelectedLicenseInfo { get => _LocalDrivingLicense; }

        private void _RefreshCard() {
            Person _licenseOwner = _LocalDrivingLicense.DriverInfo.PersonInfo;

            lbl_licenseClass.Text = _LocalDrivingLicense.LicenseClassInfo.GetClassName(Settings.Default.CurrentLanguage);
            lbl_fullName.Text = _licenseOwner.FullName;
            lbl_licenseID.Text = _LocalDrivingLicense.LocalDrivingLicenseID.ToString();
            lbl_nationalNum.Text = _licenseOwner.NationalNum;

            if (_licenseOwner.Gender == 'M') {
                lbl_gender.Text = Resources.txt_male;
                lbl_genderLabel.Image = Resources.Man_32;
            } else {
                lbl_gender.Text = Resources.txt_female;
                lbl_genderLabel.Image = Resources.Woman_32;
            }

            lbl_issueDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_LocalDrivingLicense.IssueDate);
            lbl_issueReason.Text = BusinessUtils.Mapping.GetIssueReasonString(_LocalDrivingLicense.IssueReason);
            lbl_notes.Text = string.IsNullOrEmpty(_LocalDrivingLicense.Notes) ? Str_CtrlLocalLicenseInfoCard.noNotes : _LocalDrivingLicense.Notes;
            
            if (_LocalDrivingLicense.CheckIfActive()) {
                lbl_isActive.MatchParentForeColor = true;
                lbl_isActive.Text = Resources.txt_yes;
            } else {
                lbl_isActive.MatchParentForeColor = false;
                lbl_isActive.ForeColor = Color.Red;
                lbl_isActive.Text = Resources.txt_no;
            }
            
            lbl_dateOfBirth.Text = BusinessUtils.DateTimeUtils.FormatDate(_licenseOwner.DateOfBirth);
            lbl_driverID.Text = _LocalDrivingLicense.DriverID.ToString();
            lbl_expirationDate.MatchParentForeColor = false;

            if (DateTime.Now > _LocalDrivingLicense.ExpirationDate) {
                lbl_expirationDate.MatchParentForeColor = false;
                lbl_expirationDate.ForeColor = Color.Red;
            } else
                lbl_expirationDate.MatchParentForeColor = true;

            lbl_expirationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_LocalDrivingLicense.ExpirationDate);
            SetIsDetainedLabel(_LocalDrivingLicense.IsDetained);

            if (_licenseOwner.ImagePath is null)
                pb_personImage.Image = _licenseOwner.Gender == 'M' ? Resources.Male_512 : Resources.Female_512;
            else {
                pb_personImage.ImageLocation = _licenseOwner.ImagePath;

                if (!BusinessUtils.FileUtils.CheckFileExists(_licenseOwner.ImagePath))
                    MessageBox.Show(Resources.msg_personImageLoadFailed, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lbl_showPersonInfo.Enabled = GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.People.HasFlag(DVLD_Business.Permissions.PeopleManagement.SeePersonalInfoCards);
        }

        private void _ResetCard() {
            lbl_expirationDate.MatchParentForeColor = lbl_isDetained.MatchParentForeColor = true;
            lbl_licenseClass.Text = lbl_licenseID.Text = lbl_nationalNum.Text = lbl_gender.Text = lbl_issueDate.Text = lbl_issueReason.Text = lbl_isActive.Text = lbl_dateOfBirth.Text = lbl_driverID.Text = lbl_expirationDate.Text = lbl_isDetained.Text = Resources.txt_unknownField;
            lbl_fullName.Text = Resources.txt_longUnknownField;
            lbl_notes.Text = Str_CtrlLocalLicenseInfoCard.noNotes;
            lbl_genderLabel.Image = Resources.Man_32;
            pb_personImage.Image = Resources.Male_512;
            lbl_showPersonInfo.Enabled = false;
        }

        public Ctrl_LocalLicenseInfoCard() {
            InitializeComponent();
            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
        }

        private void stretchImageToolStripMenuItem_CheckedChanged(object sender, EventArgs e) =>
            pb_personImage.SizeMode = stretchImageToolStripMenuItem.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Zoom;

        private void lbl_showPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowPersonInformation _frmShowPersonInfo = new Frm_ShowPersonInformation(_LocalDrivingLicense.DriverInfo.PersonID)) {
                if (_frmShowPersonInfo.IsDisposed)
                    return;

                _frmShowPersonInfo.PersonSaved += _frmShowPersonInfo_PersonSaved;
                _frmShowPersonInfo.ShowDialog();
                _frmShowPersonInfo.PersonSaved -= _frmShowPersonInfo_PersonSaved;
            }
        }

        private void _frmShowPersonInfo_PersonSaved(int personID) {
            ReloadCard();
            PersonSaved?.Invoke(personID);
        }

        private void ReloadCard() => LocalDrivingLicenseID = LocalDrivingLicenseID;

        public void LoadDirectlyFromObject(LocalDrivingLicense localLicense) {
            _LocalDrivingLicense = localLicense;

            if (_LocalDrivingLicense is null)
                _ResetCard();
            else
                _RefreshCard();
        }

        public void SetIsDetainedLabel(bool value) {
            if (value) {
                lbl_isDetained.MatchParentForeColor = false;
                lbl_isDetained.ForeColor = Color.Red;
                lbl_isDetained.Text = Resources.txt_yes;
            } else {
                lbl_isDetained.MatchParentForeColor = true;
                lbl_isDetained.Text = Resources.txt_no;
            }
        }
    }
}
