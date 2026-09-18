using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Licenses {
    public partial class Frm_ShowDriverLicenseHistory : SalForm, IEnforcePermissions {
        public event Action DataSaved, ForceExit;

        public Frm_ShowDriverLicenseHistory(int personID) {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            ctrl_PersonInfoCardWithFilter1.PersonID = personID;

            if (ctrl_PersonInfoCardWithFilter1.PersonID == -1) { //Unlikely to happen for this use case
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ctrl_DriverLicenseHistoryCard1.DriverID = Driver.FindIdByPersonId(personID);
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke();

        private void ctrl_DriverLicenseHistoryCard1_PersonSaved() {
            ctrl_PersonInfoCardWithFilter1.PersonID = ctrl_PersonInfoCardWithFilter1.PersonID;
            DataSaved?.Invoke();
        }

        private void ctrl_DriverLicenseHistoryCard1_ForceExit() => ForceExit?.Invoke();

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            ctrl_PersonInfoCardWithFilter1.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            ctrl_DriverLicenseHistoryCard1.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Local) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverLicenseHistory_Inter);
        }
    }
}
