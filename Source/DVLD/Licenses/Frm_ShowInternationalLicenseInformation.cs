using DVLD.Properties;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses {
    public partial class Frm_ShowInternationalLicenseInformation : SalForm {
        public event Action DataSaved;

        public Frm_ShowInternationalLicenseInformation(int internationalDrivingLicenseID) {
            InternationalDrivingLicense _internationalLicense = InternationalDrivingLicense.Find(internationalDrivingLicenseID);

            if (_internationalLicense is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();

            ctrl_InternationalLicenseInfoCard1.LoadDirectlyFromObject(_internationalLicense);
        }

        private void ctrl_InternationalLicenseInfoCard1_DataSaved() => DataSaved?.Invoke();
    }
}
