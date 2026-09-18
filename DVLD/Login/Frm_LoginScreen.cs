using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using Salem.Utils;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DVLD.Login {
    public partial class Frm_LoginScreen : SalForm {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public bool LoginSuccessful { get; private set; } = false; //By default

        public Frm_LoginScreen() {
            InitializeComponent(); 
            btn_exit.Location = new System.Drawing.Point(btn_exit.Parent.Width - btn_exit.Width, 0);
        }

        private void button_exit_Click(object sender, EventArgs e) => Close(); //The value of LoginSuccessfull will be "false"

        private void button_login_Click(object sender, EventArgs e) {
            txt_username.Text = txt_username.Text.Trim();

            var _user = txt_username.Text == string.Empty || txt_password.Text == string.Empty ? null : User.Find(txt_username.Text, Crypto.Hash(txt_password.Text));

            if (_user is null) {
                EventLogger.LogWarning($"A failed attempt to log into the system occured with these credentials:\n\tUsername: {txt_username.Text}\n\tPassword: {txt_password.Text}");
                MessageBox.Show(Str_FrmLogin.invalidUsernamePassword, Resources.msg_accessDenied, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_user.IsActive) {
                EventLogger.LogWarning($"An inactive user attempted to log into the system with these credentials:\n\tUsername: {txt_username.Text}\n\tPassword: {txt_password.Text}");
                MessageBox.Show(Str_FrmLogin.accountDeactivated, Resources.msg_accessDenied, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox_rememberMe.Checked)
                BusinessUtils.RegistryUtils.SaveLoginCredentials(txt_username.Text, txt_password.Text);
            else 
                BusinessUtils.RegistryUtils.ClearLoginCredentials();

            Settings.Default.Save();
            GlobalFields.ActiveUserID = _user.UserID;
            GlobalFields.ActiveUserPermissions = _user.PermissionsInfo;
            LoginSuccessful = true;
            EventLogger.LogInformation($"A user successfully logged into the system with these credentials:\n\tUsername: {txt_username.Text}\n\tPassword: {txt_password.Text}");
            Close();
        }

        private void Frm_LoginScreen_Load(object sender, EventArgs e) {
            var _loginCredentials = BusinessUtils.RegistryUtils.RetrieveLoginCredentials();

            if (_loginCredentials != null) {
                txt_username.Text = _loginCredentials.Value.Username;
                txt_password.Text = _loginCredentials.Value.Password;
                checkBox_rememberMe.Checked = true;
            }
        }

        private void Frm_LoginScreen_Shown(object sender, EventArgs e) {
            if (GlobalFields.LoginScreenMessageBoxInfo.text != null) {
                MessageBox.Show(GlobalFields.LoginScreenMessageBoxInfo.text, GlobalFields.LoginScreenMessageBoxInfo.caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalFields.LoginScreenMessageBoxInfo = (null, null);
            }

            txt_username.Focus();
            txt_username.SelectionStart = txt_username.TextLength;
        }

        private void _PerformDrag_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
