using DVLD.Properties;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses {
    public partial class Frm_ShowLocalLicenseInformation : SalForm {
        public event Action<int> PersonSaved;

        public Frm_ShowLocalLicenseInformation(int localDrivingLicenseID) {
            LocalDrivingLicense _localLicense = LocalDrivingLicense.Find(localDrivingLicenseID);

            if (_localLicense is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();

            ctrl_LocalLicenseInfoCard1.LoadDirectlyFromObject(_localLicense);
        }

        private void ctrl_LocalLicenseInfoCard1_PersonSaved(int personID) => PersonSaved?.Invoke(personID);
    }
}
