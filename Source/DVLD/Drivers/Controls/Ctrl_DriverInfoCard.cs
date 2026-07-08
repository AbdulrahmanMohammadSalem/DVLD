using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Drivers.Controls {
    public partial class Ctrl_DriverInfoCard : UserControl {
        public event Action<int> DriverSaved;

        private Driver _Driver = null;

        public int DriverID {
            get => _Driver is null ? -1 : _Driver.DriverID;
            set {
                _Driver = value == -1 ? null : Driver.Find(value);
                _RefreshCard();
            }
        }

        public bool EnableEditingPersonInfo {
            get => ctrl_PersonCard1.EnableEditingPersonInfo;
            set => ctrl_PersonCard1.EnableEditingPersonInfo = value;
        }

        private void _RefreshCard() {
            if (_Driver is null) {
                ctrl_PersonCard1.PersonID = -1;
                lbl_driverID.Text = lbl_createdBy.Text = lbl_dateCreated.Text = Resources.txt_unknownField;
                return;
            }

            User _createdBy = _Driver.CreatedByUserInfo;

            ctrl_PersonCard1.LoadPersonDirectly(_Driver.PersonInfo);
            lbl_driverID.Text = _Driver.DriverID.ToString();
            lbl_createdBy.Text = _createdBy is null ? Resources.txt_unknownField : _createdBy.Username;
            lbl_dateCreated.Text = BusinessUtils.DateTimeUtils.FormatDateTime(_Driver.DateCreated);
        }

        public Ctrl_DriverInfoCard() => InitializeComponent();

        private void ctrl_PersonCard1_PersonSaved(int personID) => DriverSaved?.Invoke(_Driver.DriverID);

        public void LoadDriverDirectly(Driver driver) {
            _Driver = driver;
            _RefreshCard();
        }
    }
}
