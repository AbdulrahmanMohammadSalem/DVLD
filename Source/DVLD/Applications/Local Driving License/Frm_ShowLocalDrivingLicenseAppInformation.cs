using DVLD.Properties;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Local_Driving_License {
    public partial class Frm_ShowLocalDrivingLicenseAppInformation : SalForm {
        public event Action<int> PersonSaved;

        public Frm_ShowLocalDrivingLicenseAppInformation(int localDrivingLicenseAppID) {
            InitializeComponent();

            ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID = localDrivingLicenseAppID;

            if (ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID == -1) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        private void ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved(int personID) => PersonSaved?.Invoke(personID);
    }
}
