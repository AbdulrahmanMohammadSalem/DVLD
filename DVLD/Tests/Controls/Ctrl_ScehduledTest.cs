using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD.String_Resources.User_Controls;
using DVLD_Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Tests.Controls {
    public partial class Ctrl_ScehduledTest : UserControl {
        public event Action CloseRequested;
        private TestAppointment _TestAppointment = null;

        public int TestAppointmentID {
            get => _TestAppointment is null ? -1 : _TestAppointment.TestAppointmentID;
            set {
                _TestAppointment = value == -1 ? null : TestAppointment.Find(value);

                if (_TestAppointment is null)
                    _ResetCard();
                else
                    _RefreshCard();
            }
        }

        private void _RefreshCard() {
            LocalDrivingLicenseApp _localDrivingLicenseApp = _TestAppointment.LocalDrivingLicenseAppInfo;

            gb_mainContainer.Text = _TestAppointment.TestTypeInfo.GetTitle(Settings.Default.CurrentLanguage);
            lbl_title.Image = _GetTestTypeImage();
            lbl_lDLAppID.Text = _localDrivingLicenseApp.LDLAppID.ToString();
            lbl_licenseClass.Text = _localDrivingLicenseApp.LicenseClassInfo.GetClassName(Settings.Default.CurrentLanguage);
            lbl_applicantName.Text = _localDrivingLicenseApp.ApplicantInfo.FullName;
            lbl_totalTrials.Text = TestAppointment.GetTotalTrials(_localDrivingLicenseApp.LDLAppID, _TestAppointment.TestTypeID).ToString();
            lbl_testDate.Text = BusinessUtils.DateTimeUtils.FormatDate(_TestAppointment.AppointmentDate);
            lbl_testTime.Text = BusinessUtils.DateTimeUtils.FormatTime(_TestAppointment.AppointmentDate);
            lbl_totalPaidFees.Text = (_TestAppointment.FeesPaid + (_TestAppointment.RetakeFailedTestAppID is null ? 0 : _TestAppointment.RetakeFailedTestAppInfo.FeesPaid)).ToString("C2");

            if (_TestAppointment.IsLocked) {
                lbl_title.Text += Str_FrmTakeTest.locked;
                Test _underlayingTest = Test.FindByAppointment(_TestAppointment.TestAppointmentID);

                if (_underlayingTest is null) {
                    MessageBox.Show(Resources.msg_recordNoLongerInDatabase, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseRequested?.Invoke();
                    return;
                }

                lbl_testID.Text = _underlayingTest.TestID.ToString();
            }
        }

        private void _ResetCard() {
            gb_mainContainer.Text = Str_CtrlScheduleTest.test;
            lbl_title.Image = Resources.Question_70;
            lbl_lDLAppID.Text = lbl_licenseClass.Text = lbl_totalTrials.Text = lbl_testDate.Text = lbl_testTime.Text = lbl_totalPaidFees.Text = Resources.txt_unknownField;
            lbl_applicantName.Text = Resources.txt_longUnknownField;
            lbl_testID.Text = Resources.txt_notRecordedYet;
        }

        private Image _GetTestTypeImage() {
            switch (_TestAppointment.TestTypeID) {
                case TestTypes.VisionTest: return Resources.Vision_Test_70;
                case TestTypes.WrittenTest: return Resources.Written_Test_70;
                case TestTypes.DrivingTest: return Resources.Driving_Test_70;
                default: return Resources.Question_70;
            }
        }

        public void ShowSaveTestResult(int savedTestID) {
            lbl_title.Text += Str_FrmTakeTest.locked;
            lbl_totalTrials.Text = (byte.Parse(lbl_totalTrials.Text) + 1).ToString();
            lbl_testID.Text = savedTestID.ToString();
        }

        public void SetTestAppointmentObjectDirectly(TestAppointment testAppointment) {
            _TestAppointment = testAppointment;

            _RefreshCard();
        }

        public Ctrl_ScehduledTest() {
            InitializeComponent();
        }
    }
}
