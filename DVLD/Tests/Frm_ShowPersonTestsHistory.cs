using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Tests {
    public partial class Frm_ShowPersonTestsHistory : SalForm, IEnforcePermissions {
        private enum Modes : byte {
            ShowPersonTestsHistory, RetakeFailedTest
        }

        public event Action DataSaved, ForceExit;

        public Frm_ShowPersonTestsHistory(int personID) {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            ctrl_PersonInfoCardWithFilter1.PersonID = personID;

            if (ctrl_PersonInfoCardWithFilter1.PersonID == -1) { //Unlikely to happen
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            ctrl_PersonTestsHistoryCard1.PersonID = personID;
        }

        public Frm_ShowPersonTestsHistory() {
            InitializeComponent();
            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            label_title.Text = Resources.txt_retakeFailedTest;
            pictureBox1.Image = Resources.Failed_Test_512;
            ctrl_PersonInfoCardWithFilter1.EnableFiltering = true;
        }

        private void ctrl_PersonInfoCardWithFilter1_PersonSaved(int personID) => DataSaved?.Invoke();

        private void ctrl_PersonTestsHistoryCard1_DataSaved() => DataSaved?.Invoke();

        private void ctrl_PersonInfoCardWithFilter1_PersonFound(int personID) => ctrl_PersonTestsHistoryCard1.PersonID = personID;

        private void ctrl_PersonInfoCardWithFilter1_PersonNotFound() => ctrl_PersonTestsHistoryCard1.PersonID = -1;

        private void ctrl_PersonTestsHistoryCard1_ForceExit() => ForceExit?.Invoke();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Enter && ctrl_PersonInfoCardWithFilter1.Focused) {
                ctrl_PersonInfoCardWithFilter1.PerformSearch();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            ctrl_PersonInfoCardWithFilter1.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            ctrl_PersonTestsHistoryCard1.Enabled = permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Vision) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Written) || permissions.Drivers.HasFlag(DriversManagement.ShowDriverTestsHistory_Driving);
        }
    }
}
