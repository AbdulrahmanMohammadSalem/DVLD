using DVLD.Common;
using DVLD.Interfaces;
using DVLD.People;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Drawing;

namespace DVLD.Applications.Controls {
    public partial class Ctrl_ApplicationInfoCard : System.Windows.Forms.UserControl, IEnforcePermissions {
        public event Action<int> PersonSaved;
        private Application _Application = null;
        
        public int ApplicationID {
            get => _Application is null ? -1 : _Application.BaseApplicationID;
            set {
                _Application = value == -1 ? null : Application.Find(value);

                if (_Application is null)
                    _ResetCard();
                else
                    _RefreshCard();
            }
        }

        private void _ResetCard() {
            lbl_applicationID.Text = lbl_status.Text = lbl_fees.Text = lbl_createdBy.Text = lbl_applicationType.Text = lbl_applicationDate.Text = lbl_updateStatusDate.Text = Resources.txt_unknownField;
            lbl_status.MatchParentForeColor = true;
            lbl_status.Font = lbl_applicationID.Font;
            lbl_applicantName.Text = Resources.txt_longUnknownField;
            ll_viewPersonInfo.Enabled = false;
        }

        private void _RefreshCard() {
            lbl_applicationID.Text = _Application.BaseApplicationID.ToString();
            lbl_applicantName.Text = _Application.ApplicantInfo.FullName;
            lbl_status.Text = BusinessUtils.Mapping.GetApplicationStatusString(_Application.ApplicationStatus);
            lbl_status.MatchParentForeColor = false;
            lbl_status.ForeColor = BusinessUtils.Mapping.GetApplicationStatusColor(_Application.ApplicationStatus);
            lbl_status.Font = new Font(lbl_status.Font, FontStyle.Bold | FontStyle.Italic);
            lbl_fees.Text = _Application.FeesPaid.ToString("C2");
            lbl_createdBy.Text = _Application.CreatedByUserInfo.Username;
            lbl_applicationType.Text = _Application.ApplicationTypeInfo.GetTitle(Settings.Default.CurrentLanguage);
            lbl_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_Application.ApplicationDate);

            if (_Application.UpdateStatusDate is null) {
                lbl_updateStatusDate.MatchParentForeColor = false;
                lbl_updateStatusDate.ForeColor = Color.Red;
                lbl_updateStatusDate.Text = Resources.txt_unknownField;
            } else
                lbl_updateStatusDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_Application.UpdateStatusDate.Value);

            ll_viewPersonInfo.Enabled = GlobalFields.ActiveUserPermissions != null && GlobalFields.ActiveUserPermissions.People.HasFlag(DVLD_Business.Permissions.PeopleManagement.SeePersonalInfoCards);
        }

        public Ctrl_ApplicationInfoCard() {
            InitializeComponent();
            
            if (GlobalFields.ActiveUserPermissions != null)
                EnforcePermissions(GlobalFields.ActiveUserPermissions);
        }

        private void ll_viewPersonInfo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
            using (Frm_ShowPersonInformation _frmShowPersonInfo = new Frm_ShowPersonInformation(_Application.ApplicantPersonID)) {
                if (_frmShowPersonInfo.IsDisposed)
                    return;

                _frmShowPersonInfo.PersonSaved += _frmShowPersonInfo_PersonSaved;
                _frmShowPersonInfo.ShowDialog();
                _frmShowPersonInfo.PersonSaved -= _frmShowPersonInfo_PersonSaved;
            }
        }

        private void _frmShowPersonInfo_PersonSaved(int personID) {
            lbl_applicantName.Text = _Application.ApplicantInfo.FullName;
            PersonSaved?.Invoke(personID);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ll_viewPersonInfo.Enabled = permissions.People.HasFlag(DVLD_Business.Permissions.PeopleManagement.SeePersonalInfoCards);
    }
}
