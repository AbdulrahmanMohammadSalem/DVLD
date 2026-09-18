using DVLD.Properties;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Drivers {
    public partial class Frm_ShowDriverInformation : SalForm {
        public event Action<int> DriverSaved;

        public Frm_ShowDriverInformation(int driverID) {
            Driver _driver = Driver.Find(driverID);

            if (_driver is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();

            ctrl_DriverInfoCard1.LoadDriverDirectly(_driver);
        }

        private void ctrl_DriverInfoCard1_DriverSaved(int driverID) => DriverSaved?.Invoke(driverID);
    }
}
