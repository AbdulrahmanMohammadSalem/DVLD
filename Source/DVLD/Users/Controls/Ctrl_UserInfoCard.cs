using DVLD.Common;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Users {
    public partial class Ctrl_UserInfoCard : UserControl {
        public event Action<int> UserSaved;

        private User _User = null;

        [DefaultValue(-1)]
        public int UserID {
            get => _User is null ? -1 : _User.UserID;
            set {
                _User = value == -1 ? null : User.Find(value);
                _RefreshCard();
            }
        }

        public bool EnableEditingPersonInfo {
            get => ctrl_PersonCard1.EnableEditingPersonInfo;
            set => ctrl_PersonCard1.EnableEditingPersonInfo = value;
        }

        private void _RefreshCard() {
            ll_seePermissions.Enabled = _User != null && (GlobalFields.ActiveUserPermissions is null || _User.UserID == GlobalFields.ActiveUserID || GlobalFields.ActiveUserPermissions.Users.HasFlag(DVLD_Business.Permissions.UsersManagement.SeeUserPermissions));

            if (_User is null) {
                ctrl_PersonCard1.PersonID = -1;
                label_userID.Text = label_username.Text = label_isActive.Text = Resources.txt_unknownField;
                return;
            }

            ctrl_PersonCard1.LoadPersonDirectly(_User.PersonInfo);
            label_userID.Text = _User.UserID.ToString();
            label_username.Text = _User.Username;
            label_isActive.Text = _User.IsActive ? Resources.txt_yes : Resources.txt_no;
        }

        public Ctrl_UserInfoCard() => InitializeComponent();

        private void ctrl_PersonCard1_PersonSaved(int personID) => UserSaved?.Invoke(_User.UserID);

        public void LoadUserDirectly(User user) {
            _User = user;
            _RefreshCard();
        }

        private void ll_seePermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var _frmUserPermissions = new Frm_UserPermissions(_User))
                _frmUserPermissions.ShowDialog();
        }
    }
}
