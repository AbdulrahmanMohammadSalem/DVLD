using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.People.Controls {
    public partial class Ctrl_PersonInfoCardWithFilter : UserControl {
        private bool _enableAddingNewPerson = true;
        
        public event Action<int> PersonFound;
        public event Action PersonNotFound;
        public event Action<int> PersonSaved;

        public Person SelectedPerson { get => ctrl_PersonCard1.SelectedPerson; }

        public bool EnableFiltering {
            get => groupBox_filter.Enabled;
            set => groupBox_filter.Enabled = value;
        }

        public bool EnableAddingNewPerson {
            get => _enableAddingNewPerson;
            set {
                _enableAddingNewPerson = value;
                button_addNewPerson.Visible = value;
            }
        }

        public bool EnableEditingPersonInfo {
            get => ctrl_PersonCard1.EnableEditingPersonInfo;
            set => ctrl_PersonCard1.EnableEditingPersonInfo = value;
        }

        [DefaultValue(-1)]
        public int PersonID {
            get => ctrl_PersonCard1.PersonID;
            set {
                if (value == -1) {
                    ctrl_PersonCard1.PersonID = -1;
                    txt_filterInput.Text = string.Empty;
                    return; //We don't invoke the PersonNotFound event
                }

                ctrl_PersonCard1.PersonID = value;

                if (ctrl_PersonCard1.PersonID != -1) { //Found
                    if (comboBox_filterOptions.SelectedIndex == 0) //National No.
                        txt_filterInput.Text = ctrl_PersonCard1.NationalNum;
                    else //PersonID
                        txt_filterInput.Text = value.ToString();

                    PersonFound?.Invoke(value);
                } else {
                    txt_filterInput.Text = string.Empty;
                    OnPersonNotFound();
                }
            }
        }

        [DefaultValue("")]
        public string NationalNum {
            get => ctrl_PersonCard1.NationalNum;
            set {
                ctrl_PersonCard1.NationalNum = value;

                if (ctrl_PersonCard1.PersonID != -1) { //Found
                    if (comboBox_filterOptions.SelectedIndex == 0) //National No.
                        txt_filterInput.Text = value;
                    else //PersonID
                        txt_filterInput.Text = ctrl_PersonCard1.PersonID.ToString();

                    PersonFound?.Invoke(ctrl_PersonCard1.PersonID);
                } else {
                    txt_filterInput.Text = string.Empty;
                    OnPersonNotFound();
                }
            }
        }

        public override bool Focused => txt_filterInput.Focused;

        public Ctrl_PersonInfoCardWithFilter() {
            InitializeComponent();
            comboBox_filterOptions.SelectedIndex = 0;
        }

        private void Ctrl_PersonCardWithFilter_Load(object sender, EventArgs e) {
            comboBox_filterOptions.SelectedIndex = 0;
            txt_filterInput.Focus();
        }

        private void textBox_filterInput_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '\r';

        private void button_search_Click(object sender, EventArgs e) => PerformSearch();

        public void PerformSearch() {
            if (comboBox_filterOptions.SelectedIndex == 0) //National No.
                ctrl_PersonCard1.NationalNum = txt_filterInput.Text;
            else //Person ID
                ctrl_PersonCard1.PersonID = int.Parse(txt_filterInput.Text);

            if (ctrl_PersonCard1.PersonID == -1 && txt_filterInput.Text != string.Empty) //Not found
                OnPersonNotFound();
            else //Found
                PersonFound?.Invoke(ctrl_PersonCard1.PersonID);
        }

        private void button_addNewPerson_Click(object sender, EventArgs e) {
            using (Frm_AddEditPerson _frmAddPerson = new Frm_AddEditPerson()) {
                _frmAddPerson.PersonSaved += _frmAddPerson_PersonSaved;
                _frmAddPerson.ShowDialog();
                _frmAddPerson.PersonSaved -= _frmAddPerson_PersonSaved;
            }
        }

        private void _frmAddPerson_PersonSaved(int personID) {
            ctrl_PersonCard1.PersonID = personID;

            if (comboBox_filterOptions.SelectedIndex == 0) //National No.
                txt_filterInput.Text = ctrl_PersonCard1.NationalNum;
            else //Person ID
                txt_filterInput.Text = personID.ToString();

            PersonFound?.Invoke(personID);
            PersonSaved?.Invoke(personID);
        }

        protected virtual void OnPersonNotFound() {
            PersonNotFound?.Invoke();
            MessageBox.Show(Str_FrmAddEditUser.personNotExist, Resources.msg_warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void SetFocused() => txt_filterInput.Focus();
    }
}
