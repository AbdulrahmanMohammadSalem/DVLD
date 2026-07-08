using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses.Controls {
    public partial class Ctrl_LocalLicenseInfoCardWithFilter : UserControl {
        public event Action<bool> LicenseFound;
        public event Action LicenseNotFound;
        public event Action<int> PersonSaved;

        public int LocalDrivingLicenseID => ctrl_LocalLicenseInfoCard1.LocalDrivingLicenseID;
        public LocalDrivingLicense SelectedLocalDrivingLicense => ctrl_LocalLicenseInfoCard1.SelectedLocalDrivingLicense;
        public bool EnableFiltering { get => groupBox_filter.Enabled; set => groupBox_filter.Enabled = value; }
        public override bool Focused => txt_filterInput.Focused;

        public Ctrl_LocalLicenseInfoCardWithFilter() => InitializeComponent();

        private void ctrl_LocalLicenseInfoCard1_PersonSaved(int personID) => PersonSaved?.Invoke(personID);

        private void textBox_filterInput_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == '\r';

        private void button_search_Click(object sender, EventArgs e) {
            if (txt_filterInput.TextLength != 0) {
                ctrl_LocalLicenseInfoCard1.LocalDrivingLicenseID = int.Parse(txt_filterInput.Text);
                
                if (ctrl_LocalLicenseInfoCard1.LocalDrivingLicenseID == -1)
                    LicenseNotFound?.Invoke();
                else
                    LicenseFound?.Invoke(ctrl_LocalLicenseInfoCard1.SelectedLocalDrivingLicense.CheckIfActive());
            }
        }

        public void RefreshSelectedRecord() => ctrl_LocalLicenseInfoCard1.LocalDrivingLicenseID = ctrl_LocalLicenseInfoCard1.LocalDrivingLicenseID;

        public void SetFocused() => txt_filterInput.Focus();

        public void LoadDirectlyFromObject(LocalDrivingLicense localDrivingLicense) {
            txt_filterInput.Text = localDrivingLicense.LocalDrivingLicenseID.ToString();
            ctrl_LocalLicenseInfoCard1.LoadDirectlyFromObject(localDrivingLicense);
        }

        /// <summary>
        /// This method raises both the LicenseFound and the LicenseNotFoundEvents
        /// </summary>
        public void SearchForLicense(int localDrivingLicenseID) {
            txt_filterInput.Text = localDrivingLicenseID.ToString();
            button_search_Click(btn_search, EventArgs.Empty);
        }

        public void SetIsDetainedLabel(bool value) => ctrl_LocalLicenseInfoCard1.SetIsDetainedLabel(value);

        public void PerformSearch() => button_search_Click(btn_search, EventArgs.Empty);
    }
}
