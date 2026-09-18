using DVLD.Properties;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Users {
    public partial class Frm_ShowUserInformation : SalForm {
        public event Action<int> UserSaved;

        public Frm_ShowUserInformation(int userID) {
            User _user = User.Find(userID);

            if (_user is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();

            ctrl_UserCard1.LoadUserDirectly(_user);
        }

        public Frm_ShowUserInformation(User user) {
            InitializeComponent();

            ctrl_UserCard1.LoadUserDirectly(user);
        }

        private void ctrl_UserCard1_UserSaved(int userID) => UserSaved?.Invoke(userID);
    }
}
