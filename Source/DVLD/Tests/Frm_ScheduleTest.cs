using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Tests {
    public partial class Frm_ScheduleTest : SalForm {
        public event Action DataSaved, ForceExit;

        private Frm_ScheduleTest() => InitializeComponent();

        //This is the Add new Appointment Constructor:
        public Frm_ScheduleTest(int localDrivingLicenseID, TestTypes testType) : this() {
            ctrl_ScheduleTest1.LocalDrivingLicenseAppID = localDrivingLicenseID;

            if (ctrl_ScheduleTest1.LocalDrivingLicenseAppID == -1) {
                MessageBox.Show(Str_FrmScheduleTest.LDLAppRecNoLongerExists, Resources.msg_unexpectedError);
                Close();
                return;
            }

            ctrl_ScheduleTest1.ActiveTestType = testType;
        }

        private void Frm_ScheduleTest_Load(object sender, EventArgs e) => button_save.Enabled = ctrl_ScheduleTest1.SaveEnabled;

        //This is the Update Appointment Constructor:
        public Frm_ScheduleTest(int appointmentID) : this() {
            ctrl_ScheduleTest1.TestAppointmentID = appointmentID;

            if (ctrl_ScheduleTest1.TestAppointmentID == -1) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        private void ctrl_ScheduleTest1_SaveEnabledChanged() => button_save.Enabled = ctrl_ScheduleTest1.SaveEnabled;

        private void ctrl_ScheduleTest1_DataSaved() {
            Text = Str_FrmScheduleTest.updateTestAppointment;
            DataSaved?.Invoke();
        }

        private void ctrl_ScheduleTest1_ForceExit() => ForceExit?.Invoke();

        private void button_save_Click(object sender, EventArgs e) => ctrl_ScheduleTest1.SaveAppointment();
    }
}
