using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Manina.Windows.Forms;
using Salem.Controls;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Applications.Local_Driving_License {
    public partial class Frm_AddEditLocalDrivingLicenseApplication : SalForm, IEnforcePermissions {
        public event Action DataSaved, ForceExit;

        private Modes _ActiveMode = Modes.AddNew; //By default
        private LocalDrivingLicenseApp _LocalDrivingLicenseApp = null; //By default

        public Frm_AddEditLocalDrivingLicenseApplication() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            tabPage1.Tag = 0;
            tabPage2.Tag = 1;
            
            Settings.Default.ApplyTabControlStyleSettings(tabControl1);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            if (tabControl1.RightToLeft == RightToLeft.Yes) {
                tabControl1.Pages.Clear();
                tabControl1.Pages.Add(tabPage2);
                tabControl1.Pages.Add(tabPage1);
                tabControl1.TabLocation = TabLocation.TopRight;
                tabControl1.SelectedIndex = 1;
            }
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyTabControlStyleSettings(tabControl1);

        public Frm_AddEditLocalDrivingLicenseApplication(int LDLAppID) : this() {
            _LocalDrivingLicenseApp = LocalDrivingLicenseApp.Find(LDLAppID);

            if (_LocalDrivingLicenseApp is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            _ActiveMode = Modes.Update;
        }

        private void Frm_AddEditLocalDrivingLicenseApplication_Load(object sender, EventArgs e) {
            button_next.Image = Settings.Default.CurrentLanguage == SupportedLanguages.Arabic ? Resources.Prev_32 : Resources.Next_32;
            comboBox_licenseClass.Items.AddRange(LicenseClass.GetAllLicenseClassNames(Settings.Default.CurrentLanguage));

            if (_ActiveMode == Modes.Update) {
                string _createdByUsername = _LocalDrivingLicenseApp.CreatedByUserInfo?.Username;

                ctrl_PersonCardWithFilter1.PersonID = _LocalDrivingLicenseApp.ApplicantInfo.PersonID;
                ctrl_PersonCardWithFilter1.EnableFiltering = false;
                panel_applicationInfoFields.Enabled = true;
                label_LDLAppID.Text = _LocalDrivingLicenseApp.LDLAppID.ToString();
                label_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_LocalDrivingLicenseApp.ApplicationDate);
                comboBox_licenseClass.SelectedIndex = (byte) _LocalDrivingLicenseApp.LicenseClassID - 1;
                label_applicationFees.Text = _LocalDrivingLicenseApp.ApplicationTypeInfo.Fees.ToString("C2");
                label_createdBy.Text = _createdByUsername ?? Resources.txt_unknownField;
                Text = label_title.Text = Str_FrmAddEditLocalDrivingLicenseApp.updateLDLApp;
            } else
                comboBox_licenseClass.SelectedIndex = 2; //Class 3 - Ordinary Driving License Application
        }

        private void button_next_Click(object sender, EventArgs e) {
            if (ctrl_PersonCardWithFilter1.PersonID == -1) {
                MessageBox.Show(Str_FrmAddEditUser.youMustFirstChoosePerson, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_ActiveMode == Modes.AddNew) {
                User _activeUser = GlobalFields.ActiveUserInfo;
                
                if (_activeUser is null || !_activeUser.IsActive) { //Force Exit
                    MessageBox.Show(_activeUser is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    ForceExit?.Invoke();
                    return;
                }

                label_applicationDate.Text = BusinessUtils.DateTimeUtils.FormatDate(DateTime.Now);
                label_applicationFees.Text = ApplicationType.GetFees(ApplicationTypes.NewLocalLicense).ToString("C2");
                label_createdBy.Text = _activeUser.Username;
                panel_applicationInfoFields.Enabled = true;
            }

            tabControl1.SelectedIndex = 1 - tabControl1.SelectedIndex;
        }

        private void ctrl_PersonCardWithFilter1_PersonFound(int obj) {
            if (_ActiveMode == Modes.AddNew)
                _ResetApplicationInfoPanel();
        }

        private void ctrl_PersonCardWithFilter1_PersonNotFound() {
            if (_ActiveMode == Modes.AddNew)
                _ResetApplicationInfoPanel();
        }

        private void ctrl_PersonCardWithFilter1_PersonSaved(int _) => DataSaved?.Invoke();

        private void _ResetApplicationInfoPanel() {
            errorProvider1.Clear();
            label_LDLAppID.Text = label_applicationDate.Text = label_applicationFees.Text = label_createdBy.Text = Resources.txt_unknownField;
            comboBox_licenseClass.SelectedIndex = 2; //Class 3 - Ordinary Driving License Application
            panel_applicationInfoFields.Enabled = false;
        }

        private void button_save_Click(object sender, EventArgs e) {
            if (!panel_applicationInfoFields.Enabled) { //No need to check the PersonID inside ctrlPersonCardWithFilter
                MessageBox.Show(Resources.msg_incompleteCredentials, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LicenseClasses _chosenLicenseClassID = (LicenseClasses) (comboBox_licenseClass.SelectedIndex + 1);

            if (ValidateChildren(_chosenLicenseClassID)) {
                if (_LocalDrivingLicenseApp is null) { //AddNew Mode
                    ApplicationType _applicationType = ApplicationType.Find(ApplicationTypes.NewLocalLicense);

                    _LocalDrivingLicenseApp = new LocalDrivingLicenseApp() {
                        ApplicantPersonID = ctrl_PersonCardWithFilter1.PersonID,
                        ApplicationDate = DateTime.Now,
                        ApplicationStatus = ApplicationStatus.New,
                        ApplicationTypeID = _applicationType.ID,
                        CreatedByUserID = GlobalFields.ActiveUserID,
                        FeesPaid = _applicationType.Fees
                    };
                }

                _LocalDrivingLicenseApp.LicenseClassID = _chosenLicenseClassID;
                
                if (_LocalDrivingLicenseApp.Save()) {
                    DataSaved?.Invoke();
                    ctrl_PersonCardWithFilter1.EnableFiltering = false;

                    if (_ActiveMode == Modes.AddNew) {
                        _ActiveMode = Modes.Update;
                        label_LDLAppID.Text = _LocalDrivingLicenseApp.LDLAppID.ToString();
                        Text = label_title.Text = Str_FrmAddEditLocalDrivingLicenseApp.updateLDLApp;
                        button_save.Enabled = GlobalFields.ActiveUserPermissions.LocalLicenseApps.HasFlag(DVLD_Business.Permissions.LocalLicenseAppsManagement.EditAppInfo);

                        MessageBox.Show(Str_FrmAddEditLocalDrivingLicenseApp.applicationSavedSuccessfullyWithID + _LocalDrivingLicenseApp.LDLAppID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                        MessageBox.Show(Str_FrmAddEditLocalDrivingLicenseApp.applicationSavedSucessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Resources.msg_somethingWentWrongWhileSaving, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_AddEditLocalDrivingLicenseApplication_Shown(object sender, EventArgs e) => button_next.Location = Settings.Default.CurrentLanguage == SupportedLanguages.English ? new Point(805, 408) : new Point(23, 408);

        private void Frm_AddEditLocalDrivingLicenseApplication_Activated(object sender, EventArgs e) => ctrl_PersonCardWithFilter1.SetFocused();

        private void tabControl1_PageChanged(object sender, PageChangedEventArgs e) {
            if (e.CurrentPage is null)
                return;

            button_next.FlatAppearance.BorderSize = 2 - (int) e.CurrentPage.Tag; //Branchless
            button_save.FlatAppearance.BorderSize = (int) e.CurrentPage.Tag + 1; //Branchless
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter && ctrl_PersonCardWithFilter1.Focused) {
                ctrl_PersonCardWithFilter1.PerformSearch();

                if (ctrl_PersonCardWithFilter1.SelectedPerson != null)
                    ActiveControl = button_next;

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Frm_AddEditLocalDrivingLicenseApplication_FormClosed(object sender, FormClosedEventArgs e) => Settings.Default.SettingsSaving -= Default_SettingsSaving;

        public bool ValidateChildren(LicenseClasses chosenLicenseClassID) {
            if (comboBox_licenseClass.SelectedIndex == -1) {
                MessageBox.Show(Resources.msg_incompleteCredentials, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ctrl_PersonCardWithFilter1.SelectedPerson is null) {
                MessageBox.Show(Str_FrmAddEditLocalDrivingLicenseApp.chosenPersonNoLongerExists, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetApplicationInfoPanel();
                ctrl_PersonCardWithFilter1.PersonID = -1;
                tabControl1.SelectedIndex = 1 - tabControl1.SelectedIndex;
                return false;
            }

            if (ctrl_PersonCardWithFilter1.SelectedPerson.Age < LicenseClass.Find(chosenLicenseClassID).MinimumAllowedAge) {
                MessageBox.Show(Str_FrmAddEditLocalDrivingLicenseApp.invalidChosenPersonAge, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (LocalDrivingLicense.DoesActiveLicenseExistForPerson(ctrl_PersonCardWithFilter1.PersonID, chosenLicenseClassID)) {
                MessageBox.Show(Str_FrmAddEditLocalDrivingLicenseApp.personAlreadyHaveActiveLicense, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int _existingOpenApplicationID = LocalDrivingLicenseApp.FindIdForActive(ctrl_PersonCardWithFilter1.PersonID, chosenLicenseClassID);

            if (_existingOpenApplicationID != -1 && (_ActiveMode == Modes.AddNew || _existingOpenApplicationID != _LocalDrivingLicenseApp.LDLAppID)) {
                MessageBox.Show(Str_FrmAddEditLocalDrivingLicenseApp.anOpenApplicationExistsForPerson, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) => ctrl_PersonCardWithFilter1.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
    }
}
