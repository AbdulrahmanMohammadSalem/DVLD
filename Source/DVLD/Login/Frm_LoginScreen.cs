using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.IO;
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
            textBox_username.Text = textBox_username.Text.Trim();

            User _user = textBox_username.Text == string.Empty || textBox_password.Text == string.Empty ? null : User.Find(textBox_username.Text, textBox_password.Text);

            if (_user is null) {
                MessageBox.Show(Str_FrmLogin.invalidUsernamePassword, Resources.msg_accessDenied, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_user.IsActive) {
                MessageBox.Show(Str_FrmLogin.accountDeactivated, Resources.msg_accessDenied, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox_rememberMe.Checked) {
                Settings.Default.RememberedUsername = textBox_username.Text;
                Settings.Default.RememberedPassword = textBox_password.Text;
            } else 
                Settings.Default.RememberedUsername = Settings.Default.RememberedPassword = null;

            Settings.Default.Save();
            GlobalFields.ActiveUserID = _user.UserID;
            GlobalFields.ActiveUserPermissions = _user.PermissionsInfo;
            LoginSuccessful = true;
            Close();
        }

        private void Frm_LoginScreen_Load(object sender, EventArgs e) {
            if (Settings.Default.RememberedUsername != null) {
                textBox_username.Text = Settings.Default.RememberedUsername;
                textBox_password.Text = Settings.Default.RememberedPassword;
                checkBox_rememberMe.Checked = true;
            }
        }

        private void Frm_LoginScreen_Shown(object sender, EventArgs e) {
            if (GlobalFields.LoginScreenMessageBoxInfo.text != null) {
                MessageBox.Show(GlobalFields.LoginScreenMessageBoxInfo.text, GlobalFields.LoginScreenMessageBoxInfo.caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalFields.LoginScreenMessageBoxInfo = (null, null);
            }

            textBox_username.Focus();
            textBox_username.SelectionStart = textBox_username.TextLength;
        }

        private void _PerformDrag_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
