using DVLD.Common;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.People {
    public partial class Ctrl_PersonInfoCard : UserControl {
        private bool _enableEditingPersonInfo = true;

        public event Action<int> PersonSaved;

        private Person _Person = null;

        [DefaultValue(-1)]
        public int PersonID {
            get => _Person is null ? -1 : _Person.PersonID;
            set {
                _Person = value == -1 ? null : Person.Find(value);
                _RefreshCard();
            }
        }

        [DefaultValue("")]
        public string NationalNum {
            get => _Person is null ? string.Empty : _Person.NationalNum;
            set {
                _Person = value == string.Empty ? null : Person.Find(value);
                _RefreshCard();
            }
        }

        public bool EnableEditingPersonInfo {
            get => _enableEditingPersonInfo;
            set {
                _enableEditingPersonInfo = value;
                linkLabel_editPersonInfo.Visible = value;
            }
        }

        public Person SelectedPerson => _Person;

        private void _RefreshCard() {
            if (_Person is null) {
                label_personID.Text = label_nationalNum.Text = label_gender.Text = label_email.Text = label_address.Text = label_dateOfBirth.Text = label_phone.Text = label_nationality.Text = "[???]";
                label_fullName.Text = Resources.txt_longUnknownField;
                pictureBox_image.Image = Resources.Male_512;
                linkLabel_editPersonInfo.Enabled = false;

                return;
            }

            linkLabel_editPersonInfo.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(DVLD_Business.Permissions.PeopleManagement.EditPersonalInfo);

            label_personID.Text = _Person.PersonID.ToString();
            label_fullName.Text = _Person.FullName;
            label_nationalNum.Text = _Person.NationalNum;
            label_gender.Text = _Person.Gender == 'M' ? Resources.txt_male : Resources.txt_female;
            label8.Image = _Person.Gender == 'M' ? Resources.Man_32 : Resources.Woman_32;
            label_email.Text = _Person.Email ?? Resources.txt_unknownField;
            label_address.Text = _Person.Address;
            label_dateOfBirth.Text = BusinessUtils.DateTimeUtils.FormatDate(_Person.DateOfBirth);
            label_phone.Text = _Person.PhoneNumber;
            label_nationality.Text = Settings.Default.CurrentLanguage == SupportedLanguages.Arabic ? _Person.NationalityCountryInfo.CountryNameAR : _Person.NationalityCountryInfo.CountryName;

            if (_Person.ImagePath is null) {
                pictureBox_image.Image = _Person.Gender == 'M' ? Resources.Male_512 : Resources.Female_512;
                return;
            }

            pictureBox_image.ImageLocation = _Person.ImagePath;

            if (!BusinessUtils.FileUtils.CheckFileExists(_Person.ImagePath))
                MessageBox.Show(Resources.msg_personImageLoadFailed, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public Ctrl_PersonInfoCard() {
            InitializeComponent();
            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
        }

        private void linkLabel_editPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (Frm_AddEditPerson _frmAddNewPerson = new Frm_AddEditPerson(PersonID)) {
                if (_frmAddNewPerson.IsDisposed) //In case the person was not found in the form -- It will become disposed of then
                    return;

                _frmAddNewPerson.PersonSaved += _frmAddNewPerson_PersonSaved;
                _frmAddNewPerson.ShowDialog();
                _frmAddNewPerson.PersonSaved -= _frmAddNewPerson_PersonSaved;
            }
        }

        private void _frmAddNewPerson_PersonSaved(int personID) {
            PersonID = _Person.PersonID; //To refresh the control
            PersonSaved?.Invoke(_Person.PersonID);
        }

        private void stretchImageToolStripMenuItem_CheckedChanged(object sender, EventArgs e) =>
            pictureBox_image.SizeMode = stretchImageToolStripMenuItem.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Zoom;

        public void LoadPersonDirectly(Person person) {
            _Person = person;
            _RefreshCard();
        }
    }
}
