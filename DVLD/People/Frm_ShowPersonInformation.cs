using DVLD.Properties;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.People {
    public partial class Frm_ShowPersonInformation : SalForm {
        public event Action<int> PersonSaved;

        public Frm_ShowPersonInformation(int personID) {
            InitializeComponent();

            ctrl_PersonCard1.PersonID = personID;

            if (ctrl_PersonCard1.PersonID == -1) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void ctrl_PersonCard1_PersonSaved(int personID) => PersonSaved?.Invoke(personID);
    }
}
