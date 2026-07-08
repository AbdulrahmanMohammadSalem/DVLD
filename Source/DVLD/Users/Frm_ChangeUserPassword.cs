using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Users {
    public partial class Frm_ChangeUserPassword : SalForm {
        public event Action<int> UserSaved;

        private readonly User _User = null;

        private Frm_ChangeUserPassword() => InitializeComponent();

        public Frm_ChangeUserPassword(int userID) : this() {
            _User = User.Find(userID);

            if (_User is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ctrl_UserCard1.LoadUserDirectly(_User);
        }

        public Frm_ChangeUserPassword(User user) : this() {
            _User = user;
            ctrl_UserCard1.LoadUserDirectly(_User);
        }

        private void textBox_currentNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            TextBox _txtBx = (TextBox) sender;

            if (_txtBx.Text == string.Empty)
                errorProvider1.SetError(_txtBx, Resources.txt_requiredField);
        }

        private void textBox_confirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (textBox_newPassword.Text != string.Empty && textBox_confirmPassword.Text != string.Empty && textBox_confirmPassword.Text != textBox_newPassword.Text) {
                errorProvider1.SetError(textBox_confirmPassword, Str_FrmChangeUserPassword.invalidConfirmPasswordInput);
                e.Cancel = true;
                //textBox_confirmPassword.Focus();
            }
        }

        private void textBox_toClearError_TextChanged(object sender, EventArgs e) =>
            errorProvider1.SetError((TextBox) sender, string.Empty);

        private void button_save_Click(object sender, EventArgs e) {
            if (!_ValidateFieldsAsRequired()) {
                MessageBox.Show(Resources.msg_incompleteCredentials, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_confirmPassword.Text != textBox_newPassword.Text) {
                errorProvider1.SetError(textBox_confirmPassword, Str_FrmChangeUserPassword.invalidConfirmPasswordInput);
                return;
            }

            if (textBox_currentPassword.Text != _User.Password) {
                MessageBox.Show(Str_FrmChangeUserPassword.incorrectCurrentPasswordInput, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.UpdatePassword(textBox_newPassword.Text)) {
                MessageBox.Show(Resources.msg_userSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_currentPassword.Text = textBox_newPassword.Text = textBox_confirmPassword.Text = string.Empty;
            }
            else
                MessageBox.Show(Resources.msg_userSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _ValidateFieldsAsRequired() {
            bool _result = true;

            if (textBox_confirmPassword.Text == string.Empty) {
                errorProvider1.SetError(textBox_confirmPassword, Resources.txt_requiredField);
                _result = false;
            }

            if (textBox_newPassword.Text == string.Empty) {
                errorProvider1.SetError(textBox_newPassword, Resources.txt_requiredField);
                _result = false;
            }

            if (textBox_currentPassword.Text == string.Empty) {
                errorProvider1.SetError(textBox_currentPassword, Resources.txt_requiredField);
                _result = false;
            }

            return _result;
        }

        private void ctrl_UserCard1_UserSaved(int userID) => UserSaved?.Invoke(userID);
    }
}
