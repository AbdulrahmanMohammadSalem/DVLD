using DVLD.Properties;
using DVLD.String_Resources.Forms;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Application_Settings {
    public partial class Frm_SelectHue : SalForm {
        public short SelectedValue { get; private set; }

        public Frm_SelectHue(int value) {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == DVLD_Business.SupportedLanguages.Arabic)
                btn_ok.Padding = Padding.Empty;

            txt_value.Text = value.ToString();
        }

        private void textBox_nationalNum_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '\r';

            if (e.KeyChar == '\r')
                btn_ok.PerformClick();
        }

        private void btn_ok_Click(object sender, EventArgs e) {
            SelectedValue = short.Parse(txt_value.Text);

            if (SelectedValue > 360)
                errorProvider1.SetError(txt_value, Str_FrmSettings.valueNotExceed360);
            else {
                errorProvider1.SetError(txt_value, string.Empty);
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
