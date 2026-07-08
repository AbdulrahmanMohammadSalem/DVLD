using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Application_Settings {
    public partial class Frm_EnterThemeName : SalForm {
        public string InputValue { get; private set; }

        public Frm_EnterThemeName() {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.Arabic)
                btn_ok.Padding = Padding.Empty;
        }

        public Frm_EnterThemeName(string themeName, string formTitle) : this() {
            txt_value.Text = themeName;
            Text = formTitle;
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            txt_value.Text = txt_value.Text.Trim();

            if (txt_value.Text == string.Empty)
                errorProvider1.SetError(txt_value, Resources.txt_requiredField);
            else if (Theme.DoesExist(txt_value.Text))
                errorProvider1.SetError(txt_value, Str_FrmSettings.themeNameAlreadyTaken);
            else {
                InputValue = txt_value.Text;
                DialogResult = DialogResult.OK;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
