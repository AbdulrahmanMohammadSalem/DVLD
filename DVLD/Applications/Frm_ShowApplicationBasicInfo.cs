using DVLD.Properties;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Applications {
    public partial class Frm_ShowApplicationBasicInfo : SalForm {
        public event Action DataSaved;

        public Frm_ShowApplicationBasicInfo(int baseApplicationID) {
            InitializeComponent();

            ctrl_ApplicationInfoCard1.ApplicationID = baseApplicationID;

            if (ctrl_ApplicationInfoCard1.ApplicationID == -1) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ctrl_ApplicationInfoCard1_PersonSaved(int personID) => DataSaved?.Invoke();
    }
}
