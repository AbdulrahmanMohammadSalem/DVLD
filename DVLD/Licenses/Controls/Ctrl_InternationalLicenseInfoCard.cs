using DVLD.Common;
using DVLD.People;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Licenses.Controls {
    public partial class Ctrl_InternationalLicenseInfoCard : UserControl {
        public event Action DataSaved;
        private InternationalDrivingLicense _InternationalLicense = null;

        [DefaultValue(-1)]
        public int InternationalDrivingLicenseID {
            get => _InternationalLicense is null ? -1 : _InternationalLicense.InternationalLicenseID;
            set {
                _InternationalLicense = value == -1 ? null : InternationalDrivingLicense.Find(value);

                if (_InternationalLicense is null)
                    _ResetCard();
                else
                    _RefreshCard();
            }
        }

        private void _RefreshCard() {
            Person _personInfo = _InternationalLicense.DriverInfo.PersonInfo;

            lbl_fullName.Text = _personInfo.FullName;
            lbl_interLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lbl_localLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lbl_nationalNum.Text = _personInfo.NationalNum;

            if (_personInfo.Gender == 'M') {
                ttl_gender.Image = Resources.Man_32;
                lbl_gender.Text = Resources.txt_male;
            } else {
                ttl_gender.Image = Resources.Woman_32;
                lbl_gender.Text = Resources.txt_female;
            }

            lbl_issueDate.Text = BusinessUtils.DateTimeUtils.FormatDateTime(_InternationalLicense.IssueDate);
            lbl_applicationID.Text = _InternationalLicense.ApplicationID.ToString();

            if (_InternationalLicense.CheckIfActive()) {
                lbl_isActive.MatchParentForeColor = true;
                lbl_isActive.Text = Resources.txt_yes;
            } else {
                lbl_isActive.MatchParentForeColor = false;
                lbl_isActive.ForeColor = Color.Red;
                lbl_isActive.Text = Resources.txt_no;
            }

            lbl_dateOfBirth.Text = BusinessUtils.DateTimeUtils.FormatDate(_personInfo.DateOfBirth);
            lbl_driverID.Text = _InternationalLicense.DriverID.ToString();

            if (DateTime.Now > _InternationalLicense.ExpirationDate) {
                lbl_expirationDate.MatchParentForeColor = false;
                lbl_expirationDate.ForeColor = Color.Red;
            } else
                lbl_expirationDate.MatchParentForeColor = true;

            lbl_expirationDate.Text = BusinessUtils.DateTimeUtils.FormatDateTime(_InternationalLicense.ExpirationDate);

            if (_personInfo.ImagePath is null)
                pb_personImage.Image = _personInfo.Gender == 'M' ? Resources.Male_512 : Resources.Female_512;
            else {
                pb_personImage.ImageLocation = _personInfo.ImagePath;

                if (!BusinessUtils.FileUtils.CheckFileExists(_personInfo.ImagePath))
                    MessageBox.Show(Resources.msg_personImageLoadFailed, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ll_showPersonInfo.Enabled = GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            ttl_localLicenseID.Enabled = GlobalFields.ActiveUserPermissions is null || GlobalFields.ActiveUserPermissions.Licenses.HasFlag(LicensesManagement.ShowFullLocalLicenseInfo);
        }

        private void _ResetCard() {
            ttl_gender.Image = Resources.Man_32;
            lbl_isActive.MatchParentForeColor = lbl_expirationDate.MatchParentForeColor = true;
            lbl_fullName.Text = lbl_interLicenseID.Text = lbl_localLicenseID.Text = lbl_nationalNum.Text = lbl_gender.Text = lbl_issueDate.Text = lbl_applicationID.Text = lbl_isActive.Text = lbl_dateOfBirth.Text = lbl_driverID.Text = lbl_expirationDate.Text = Resources.txt_unknownField;
            pb_personImage.Image = Resources.Male_512;
            ll_showPersonInfo.Enabled = ttl_localLicenseID.Enabled = false;
        }

        public Ctrl_InternationalLicenseInfoCard() => InitializeComponent();

        private void ttl_localLicenseID_MouseEnter(object sender, EventArgs e) => ttl_localLicenseID.Font = new Font(ttl_localLicenseID.Font, FontStyle.Underline | FontStyle.Bold);

        private void ttl_localLicenseID_MouseLeave(object sender, EventArgs e) => ttl_localLicenseID.Font = new Font(ttl_localLicenseID.Font, FontStyle.Bold);

        private void ttl_localLicenseID_MouseDown(object sender, MouseEventArgs e) => ttl_localLicenseID.ForeColor = Color.Red;

        private void ttl_localLicenseID_MouseUp(object sender, MouseEventArgs e) => ttl_localLicenseID.ForeColor = Color.Blue;

        private void ttl_localLicenseID_Click(object sender, EventArgs e) {
            using (Frm_ShowLocalLicenseInformation _frmLocalLicenseInfo = new Frm_ShowLocalLicenseInformation(_InternationalLicense.IssuedUsingLocalLicenseID)) {
                if (_frmLocalLicenseInfo.IsDisposed)
                    return;

                _frmLocalLicenseInfo.PersonSaved += _frm_PersonSaved;
                _frmLocalLicenseInfo.ShowDialog();
                _frmLocalLicenseInfo.PersonSaved -= _frm_PersonSaved;
            }
        }

        private void _frm_PersonSaved(int personID) {
            InternationalDrivingLicenseID = InternationalDrivingLicenseID;
            DataSaved?.Invoke();
        }

        private void ll_showPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowPersonInformation _frmShowPersonInfo = new Frm_ShowPersonInformation(_InternationalLicense.DriverInfo.PersonID)) {
                if (_frmShowPersonInfo.IsDisposed)
                    return;

                _frmShowPersonInfo.PersonSaved += _frm_PersonSaved;
                _frmShowPersonInfo.ShowDialog();
                _frmShowPersonInfo.PersonSaved -= _frm_PersonSaved;
            }
        }

        internal void LoadDirectlyFromObject(InternationalDrivingLicense internationalLicense) {
            _InternationalLicense = internationalLicense;

            if (_InternationalLicense is null)
                _ResetCard();
            else
                _RefreshCard();
        }
    }
}
