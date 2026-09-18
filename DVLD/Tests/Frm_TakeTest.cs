using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD_Business;
using Salem.Controls;
using System;
using System.Windows.Forms;

namespace DVLD.Tests {
    public partial class Frm_TakeTest : SalForm {
        public event Action DataSaved, ForceExit;
        private readonly TestAppointment _TestAppointment = null;

        public Frm_TakeTest(int testAppointmentID) {
            _TestAppointment = TestAppointment.Find(testAppointmentID);

            if (_TestAppointment is null) {
                MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            InitializeComponent();
            ctrl_ScehduledTest1.SetTestAppointmentObjectDirectly(_TestAppointment);
        }

        private void Frm_TakeTest_Load(object sender, EventArgs e) {
            if (_TestAppointment.IsLocked) {
                rb_pass.Enabled = rb_fail.Enabled = txtBx_notes.Enabled = button_save.Enabled = false;

                Test _underlayingTest = Test.FindByAppointment(_TestAppointment.TestAppointmentID);

                if (_underlayingTest is null) { //This piece is also present in Ctrl_ScheduledTest
                    MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                rb_fail.Checked = !_underlayingTest.TestResults;
                txtBx_notes.Text = _underlayingTest.Notes;
            }
        }

        private void ctrl_ScehduledTest1_CloseRequested() => Close();

        private void button_save_Click(object sender, EventArgs e) {
            User _createdByUserInfo = GlobalFields.ActiveUserInfo;

            if (_createdByUserInfo is null || !_createdByUserInfo.IsActive) {
                MessageBox.Show(_createdByUserInfo is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                ForceExit?.Invoke();
                return;
            }

            txtBx_notes.Text = txtBx_notes.Text.Trim();

            Test _newTestRecord = new Test() {
                CreatedByUserID = GlobalFields.ActiveUserID,
                Notes = txtBx_notes.Text == string.Empty ? null : txtBx_notes.Text,
                TestAppointmentID = _TestAppointment.TestAppointmentID,
                TestResults = rb_pass.Checked
            };

            if (MessageBox.Show(Str_FrmTakeTest.confirmResult, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes && _newTestRecord.Save()) {
                ctrl_ScehduledTest1.ShowSaveTestResult(_newTestRecord.TestID);
                DataSaved?.Invoke();
                rb_pass.Enabled = rb_fail.Enabled = txtBx_notes.Enabled = button_save.Enabled = false;
                MessageBox.Show(Str_FrmTakeTest.testResultSavedSuccessfullyWithID + _newTestRecord.TestID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
