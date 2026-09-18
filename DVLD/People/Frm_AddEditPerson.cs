using DVLD.Common;
using DVLD.Properties;
using DVLD_Business;
using Salem.Controls;
using System;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;
using DVLD.String_Resources.Forms;
using Salem.Controls.Renderers;

namespace DVLD.People {
    public partial class Frm_AddEditPerson : SalForm {
        public event Action<int> PersonSaved;

        private Modes _ActiveMode = Modes.AddNew; //By default
        private Person _Person = null; //By default

        public Frm_AddEditPerson() {
            InitializeComponent();
            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
        }

        public Frm_AddEditPerson(int personID) : this() {
            _Person = Person.Find(personID);

            if (_Person is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); //This will dispose the object -- We must check if it got disposed of when calling this constructor
                return;
            }

            _ActiveMode = Modes.Update;
        }

        private void _PopulateChildren() {
            label_personID.Text = _Person.PersonID.ToString();
            textBox_firstName.Text = _Person.FirstName;
            textBox_secondName.Text = _Person.SecondName;
            textBox_thirdName.Text = _Person.ThirdName;
            textBox_lastName.Text = _Person.LastName;
            textBox_nationalNum.Text = _Person.NationalNum;
            dateTimePicker_dateOfBirth.Value = _Person.DateOfBirth;
            radioButton_female.Checked = _Person.Gender == 'F';
            textBox_phone.Text = _Person.PhoneNumber;
            textBox_email.Text = _Person.Email;
            comboBox_nationality.Text = Settings.Default.CurrentLanguage == SupportedLanguages.Arabic ? _Person.NationalityCountryInfo.CountryNameAR : _Person.NationalityCountryInfo.CountryName;
            textBox_address.Text = _Person.Address;

            if (_Person.ImagePath is null)
                return;

            pictureBox_image.ImageLocation = _Person.ImagePath;
            linkLabel_clearImage.Enabled = true;

            if (!File.Exists(_Person.ImagePath))
                MessageBox.Show(Resources.msg_personImageLoadFailed, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Frm_AddEditPerson_Load(object sender, EventArgs e) {
            _InitializeDateOfBirthPicker();
            _InitializeNationalityComboBox();

            if (_ActiveMode == Modes.Update) {
                _PopulateChildren();

                Text = Str_FrmAddEditPerson.updatePerson;
                label_title.Text = Str_FrmAddEditPerson.updatePersonInfo;
            }
        }

        private void _InitializeNationalityComboBox() {
            comboBox_nationality.Items.AddRange(Country.GetAllCountryNames(Settings.Default.CurrentLanguage));
            comboBox_nationality.Text = Str_FrmAddEditPerson.egypt; //Default selection
        }

        private void textBox_nationalNum_Validating(object sender, CancelEventArgs e) {
            if (_ActiveMode == Modes.Update && textBox_nationalNum.Text == _Person.NationalNum)
                return;

            if (textBox_nationalNum.TextLength == 0) {
                errorProvider1.SetError(textBox_nationalNum, Resources.txt_requiredField);
                return;
            }

            BusinessValidator.NationalNumValidationResults _validationResult = BusinessValidator.ValidateNationalNum(textBox_nationalNum.Text);

            if (_validationResult == BusinessValidator.NationalNumValidationResults.InvalidLength) {
                errorProvider1.SetError(textBox_nationalNum, Str_FrmAddEditPerson.nationalNumConsistsOf14Digits);
                e.Cancel = true;
                //textBox_nationalNum.Focus();
            } else if (_validationResult == BusinessValidator.NationalNumValidationResults.AlreadyExists) {
                errorProvider1.SetError(textBox_nationalNum, Str_FrmAddEditPerson.nationalNumAlreadyInUse);
                e.Cancel = true;
                //textBox_nationalNum.Focus();
            }
        }

        private void textBox_digitsOnly_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void textBox_email_Validating(object sender, CancelEventArgs e) {
            textBox_email.Text = textBox_email.Text.Trim();

            if (textBox_email.TextLength == 0)
                return;

            if (!BusinessValidator.ValidateEmail(textBox_email.Text)) {
                errorProvider1.SetError(textBox_email, Str_FrmAddEditPerson.invalidEmail);
                e.Cancel = true;
                //textBox_email.Focus();
            }
        }

        private void linkLabel_setImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                _HandleImageDropped(openFileDialog1.FileName);
        }

        private void _HandleImageDropped(string imagePath) {
            pictureBox_image.ImageLocation = imagePath;
            linkLabel_clearImage.Enabled = true;
        }

        private void linkLabel_clearImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            pictureBox_image.ImageLocation = null;
            pictureBox_image.Image = radioButton_male.Checked ? Resources.Male_512 : Resources.Female_512;
            linkLabel_clearImage.Enabled = false;
        }

        private void _InitializeDateOfBirthPicker() {
            DateTime _now = DateTime.Now;
            dateTimePicker_dateOfBirth.MinValue = _now.AddYears(-100);
            dateTimePicker_dateOfBirth.MaxValue = _now.AddYears(-18);
        }

        private void comboBox_nationality_Validating(object sender, CancelEventArgs e) =>
            _ValidateNationalityInput();

        private bool _ValidateNationalityInput() {
            comboBox_nationality.Text = comboBox_nationality.Text.Trim();

            if (comboBox_nationality.Text == string.Empty) {
                errorProvider1.SetError(comboBox_nationality, Resources.txt_requiredField);
                return false;
            }
            else if (comboBox_nationality.FindStringExact(comboBox_nationality.Text) == -1) {
                errorProvider1.SetError(comboBox_nationality, Resources.txt_chooseValidOption);
                comboBox_nationality.Focus();
                return false;
            }

            return true;
        }

        private void textBox_normalRequiredField_Validating(object sender, CancelEventArgs e) {
            TextBox _textBox = (TextBox) sender;
            _textBox.Text = _textBox.Text.Trim();

            if (_textBox.Text == string.Empty)
                errorProvider1.SetError(_textBox, Resources.txt_requiredField);
        }

        private void textBox_trim_clearError_TextChanged(object sender, EventArgs e) {
            TextBox _textBox = (TextBox) sender;

            if (_textBox.Text.Trim() == string.Empty)
                _textBox.Text = string.Empty;

            errorProvider1.SetError(_textBox, string.Empty);
        }

        private void radioButton_gender_CheckedChanged(object sender, EventArgs e) {
            if (pictureBox_image.ImageLocation is null && ((RadioButton) sender).Checked)
                pictureBox_image.Image = radioButton_male.Checked ? Resources.Male_512 : Resources.Female_512;
        }

        private void button_save_Click(object sender, EventArgs e) {
            if (!ValidateChildren())
                return;

            if (_Person is null)
                _Person = new Person();

            if (!_HandleImagePath()) {
                MessageBox.Show(Str_FrmAddEditPerson.personImageHandleFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonObjectFromFields();

            if (_Person.Save()) {
                PersonSaved?.Invoke(_Person.PersonID);

                if (_ActiveMode == Modes.AddNew) {
                    _ActiveMode = Modes.Update;
                    label_personID.Text = _Person.PersonID.ToString();
                    Text = Str_FrmAddEditPerson.updatePerson;
                    label_title.Text = Str_FrmAddEditPerson.updatePersonInfo;
                    MessageBox.Show(Str_FrmAddEditPerson.personSavedSuccessfullyWithID + _Person.PersonID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Str_FrmAddEditPerson.personSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show(Resources.msg_dataSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _HandleImagePath() {
            if (_ActiveMode == Modes.Update) {
                if (_Person.ImagePath == pictureBox_image.ImageLocation)
                    return true; //Do nothing

                //Deleting the original image:
                if (_Person.ImagePath != null) {
                    if (!BusinessUtils.FileUtils.DeleteFile(_Person.ImagePath))
                        return false;
                }
            }

            //Storing the new image:
            _Person.ImagePath = pictureBox_image.ImageLocation is null ? null : BusinessUtils.FileUtils.StorePersonImageAsGuid(pictureBox_image.ImageLocation);

            return true;
        }

        public override bool ValidateChildren() {
            bool _result = true;

            textBox_nationalNum_Validating(textBox_nationalNum, null);

            if (textBox_nationalNum.Focused)
                _result = false;

            _ValidateAsRequiredField(textBox_address, ref _result);
            _ValidateNationalityAsRequiredField(ref _result);
            _ValidateAsRequiredField(textBox_phone, ref _result);
            _ValidateAsRequiredField(textBox_nationalNum, ref _result);
            _ValidateAsRequiredField(textBox_lastName, ref _result);
            _ValidateAsRequiredField(textBox_secondName, ref _result);
            _ValidateAsRequiredField(textBox_firstName, ref _result);

            if (!_result)
                return false;

            return _ValidateNationalityInput();
        }

        private void _ValidateNationalityAsRequiredField(ref bool result) {
            comboBox_nationality.Text = comboBox_nationality.Text.Trim();

            if (comboBox_nationality.Text == string.Empty) {
                errorProvider1.SetError(comboBox_nationality, Resources.txt_requiredField);
                result = false;
            }
        }

        private void _ValidateAsRequiredField(TextBox textBox, ref bool result) {
            textBox.Text = textBox.Text.Trim();

            if (textBox.Text == string.Empty) {
                errorProvider1.SetError(textBox, Resources.txt_requiredField);
                result = false;
            }
        }

        private void _FillPersonObjectFromFields() {
            textBox_thirdName.Text = textBox_thirdName.Text.Trim();
            textBox_email.Text = textBox_email.Text.Trim();

            _Person.FirstName = textBox_firstName.Text.Trim();
            _Person.SecondName = textBox_secondName.Text.Trim();
            _Person.ThirdName = textBox_thirdName.Text == string.Empty ? null : textBox_thirdName.Text;
            _Person.LastName = textBox_lastName.Text.Trim();
            _Person.NationalNum = textBox_nationalNum.Text.Trim();
            _Person.DateOfBirth = dateTimePicker_dateOfBirth.Value;
            _Person.Gender = radioButton_male.Checked ? 'M' : 'F';
            _Person.PhoneNumber = textBox_phone.Text.Trim();
            _Person.Email = textBox_email.Text == string.Empty ? null : textBox_email.Text;
            _Person.NationalityCountryID = Settings.Default.CurrentLanguage == SupportedLanguages.Arabic ? Country.FindByArabicName(comboBox_nationality.Text).CountryID : Country.FindByDefaultName(comboBox_nationality.Text).CountryID;
            _Person.Address = textBox_address.Text.Trim();
        }

        private void stretchImageToolStripMenuItem_CheckedChanged(object sender, EventArgs e) =>
            pictureBox_image.SizeMode = stretchImageToolStripMenuItem.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Zoom;

        private void Frm_AddEditPerson_DragEnter(object sender, DragEventArgs e) {
            string[] _filePaths = (string[]) e.Data.GetData(DataFormats.FileDrop);

            e.Effect = _filePaths.Length > 0 && BusinessValidator.IsImageFormat(_filePaths[0]) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void Frm_AddEditPerson_DragDrop(object sender, DragEventArgs e) =>
            _HandleImageDropped(((string[]) e.Data.GetData(DataFormats.FileDrop))[0]);
    }
}
