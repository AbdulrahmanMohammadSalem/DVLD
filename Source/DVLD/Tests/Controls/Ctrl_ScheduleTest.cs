using DVLD.Common;
using DVLD.Properties;
using DVLD.String_Resources.Forms;
using DVLD.String_Resources.User_Controls;
using DVLD_Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Tests.Controls {
    public partial class Ctrl_ScheduleTest : UserControl {
        public event Action SaveEnabledChanged, DataSaved, ForceExit;

        private LocalDrivingLicenseApp _LocalDrivingLicenseApp = null;
        private TestType _ActiveTestType = null;
        private TestAppointment _TestAppointment = null;
        private Modes _ActiveMode = Modes.AddNew;

        public int TestAppointmentID {
            get => _TestAppointment is null ? -1 : _TestAppointment.TestAppointmentID;
            set {
                _TestAppointment = value == -1 ? null : TestAppointment.Find(value);

                if (_TestAppointment is null) {
                    _ActiveMode = Modes.AddNew;

                    _LocalDrivingLicenseApp = null;
                    _ActiveTestType = null;

                    _ResetApplicationInfoFields();
                    _ResetTestTypeFields();
                    _ResetTotalTrialsFields();
                    _ResetTestAppointmentFields();
                } else {
                    _ActiveMode = Modes.Update;

                    _LocalDrivingLicenseApp = _TestAppointment.LocalDrivingLicenseAppInfo;
                    _ActiveTestType = _TestAppointment.TestTypeInfo;

                    _RefreshTestAppointmentFields();
                }
            }
        }

        public int LocalDrivingLicenseAppID {
            get => _LocalDrivingLicenseApp is null ? -1 : _LocalDrivingLicenseApp.LDLAppID;
            set {
                if (_TestAppointment != null)
                    return;

                _LocalDrivingLicenseApp = value == -1 ? null : LocalDrivingLicenseApp.Find(value);

                if (_LocalDrivingLicenseApp is null) {
                    _ResetApplicationInfoFields();
                    _ResetTotalTrialsFields();
                    lbl_cannotUpdate.Visible = false;
                }
                else
                    _RefreshApplicationInfoFields();
            }
        }

        public TestTypes ActiveTestType {
            get => _ActiveTestType is null ? TestTypes.Unknown : _ActiveTestType.ID;
            set {
                if (_TestAppointment != null)
                    return;

                _ActiveTestType = value == TestTypes.Unknown ? null : TestType.Find(value);

                if (_ActiveTestType is null) {
                    _ResetTestTypeFields();
                    _ResetTotalTrialsFields();
                    lbl_cannotUpdate.Visible = false;
                }
                else
                    _RefreshTestTypeFields();
            }
        }

        public bool SaveEnabled { get; private set; } = true;

        private void _RefreshTestAppointmentFields() {
            //Application Info:
            lbl_lDLAppID.Text = _LocalDrivingLicenseApp.LDLAppID.ToString();
            lbl_licenseClass.Text = _LocalDrivingLicenseApp.LicenseClassInfo.GetClassName(Settings.Default.CurrentLanguage);
            lbl_applicantName.Text = _LocalDrivingLicenseApp.ApplicantInfo.FullName;

            //TestType Info:
            gb_mainContainer.Text = _ActiveTestType.GetTitle(Settings.Default.CurrentLanguage);
            lbl_title.Image = _GetSceduleTestTypeImage();
            lbl_testFees.Text = _ActiveTestType.Fees.ToString("C2");

            //The rest of the Info:
            lbl_totalTrials.Text = TestAppointment.GetTotalTrials(_LocalDrivingLicenseApp.LDLAppID, _ActiveTestType.ID).ToString();
            dtp_testDate.MinValue = BusinessUtils.DateTimeUtils.GetMinDate(DateTime.Now, _TestAppointment.AppointmentDate);
            dtp_testDate.Value = dtp_testTime.Value = _TestAppointment.AppointmentDate;
            
            if (_TestAppointment.RetakeFailedTestAppID != null) {
                decimal _retakeTestAppFees = _TestAppointment.RetakeFailedTestAppInfo.FeesPaid;

                gb_retakeTestInfo.Enabled = true;
                lbl_retakeAppID.Text = _TestAppointment.RetakeFailedTestAppID.ToString();
                lbl_retakeTestAppFees.Text = _retakeTestAppFees.ToString("C2");
                lbl_totalFees.Text = (_TestAppointment.FeesPaid + _retakeTestAppFees).ToString("C2");
            } else {
                gb_retakeTestInfo.Enabled = false;
                lbl_retakeAppID.Text = lbl_retakeTestAppFees.Text = lbl_totalFees.Text = Resources.txt_unknownField;
            }

            if (_TestAppointment.IsLocked)
                _DisableSaving(Str_CtrlScheduleTest.applicantAlreadyTookTest);
            else
                _EnableSaving();
        }

        

        private void _ResetTestAppointmentFields() {
            dtp_testDate.MinValue = DateTime.Now;
            dtp_testDate.Value = dtp_testTime.Value = DateTime.Now;
            lbl_cannotUpdate.Visible = false;
        }

        private void _RefreshTestTypeFields() {
            gb_mainContainer.Text = _ActiveTestType.GetTitle(Settings.Default.CurrentLanguage);
            lbl_title.Image = _GetSceduleTestTypeImage();
            lbl_testFees.Text = _ActiveTestType.Fees.ToString("C2");

            if (_LocalDrivingLicenseApp is null)
                _ResetTotalTrialsFields();
            else {
                if (_LocalDrivingLicenseApp.NumOfPassedTests + 1 < (byte) _ActiveTestType.ID)
                    _DisableSaving(Str_CtrlScheduleTest.invalidSchedulingOrder);
                else {
                    _RefreshTotalTrialsFields();

                    if (_LocalDrivingLicenseApp.NumOfPassedTests >= (byte) _ActiveTestType.ID)
                        _DisableSaving(Str_CtrlScheduleTest.applicantAlreadyTookTest);
                    else
                        _EnableSaving();
                }
            }
        }

        private void _ResetTestTypeFields() {
            gb_mainContainer.Text = Str_CtrlScheduleTest.test;
            lbl_title.Image = Resources.Question_70;
            lbl_totalTrials.Text = lbl_testFees.Text = lbl_retakeAppID.Text = lbl_retakeTestAppFees.Text = lbl_totalFees.Text = Resources.txt_unknownField;
            gb_retakeTestInfo.Enabled = false;
        }

        private void _RefreshApplicationInfoFields() {
            lbl_lDLAppID.Text = _LocalDrivingLicenseApp.LDLAppID.ToString();
            lbl_licenseClass.Text = _LocalDrivingLicenseApp.LicenseClassInfo.GetClassName(Settings.Default.CurrentLanguage);
            lbl_applicantName.Text = _LocalDrivingLicenseApp.ApplicantInfo.FullName;

            if (_ActiveTestType is null)
                _ResetTotalTrialsFields();
            else {
                if (_LocalDrivingLicenseApp.NumOfPassedTests + 1 < (byte) _ActiveTestType.ID)
                    _DisableSaving(Str_CtrlScheduleTest.invalidSchedulingOrder);
                else {
                    _RefreshTotalTrialsFields();

                    if (_LocalDrivingLicenseApp.NumOfPassedTests >= (byte) _ActiveTestType.ID)
                        _DisableSaving(Str_CtrlScheduleTest.applicantAlreadyTookTest);
                    else
                        _EnableSaving();
                }
            }
        }

        private void _ResetApplicationInfoFields() {
            lbl_lDLAppID.Text = lbl_licenseClass.Text = Resources.txt_unknownField;
            lbl_applicantName.Text = Resources.txt_longUnknownField;
            lbl_cannotUpdate.Visible = false;
        }

        private void _RefreshTotalTrialsFields() {
            int _totalTrials = TestAppointment.GetTotalTrials(_LocalDrivingLicenseApp.LDLAppID, _ActiveTestType.ID);

            lbl_totalTrials.Text = _totalTrials.ToString();

            if (_totalTrials > 0) {
                decimal _retakeTestAppFees = ApplicationType.GetFees(ApplicationTypes.RetakeFailedTest);

                gb_retakeTestInfo.Enabled = true;
                lbl_retakeAppID.Text = Resources.txt_unknownField;
                lbl_retakeTestAppFees.Text = _retakeTestAppFees.ToString("C2");
                lbl_totalFees.Text = (_retakeTestAppFees + _ActiveTestType.Fees).ToString("C2");
            } else {
                gb_retakeTestInfo.Enabled = false;
                lbl_retakeAppID.Text = lbl_retakeTestAppFees.Text = lbl_totalFees.Text = Resources.txt_unknownField;
            }
        }

        private void _ResetTotalTrialsFields() {
            gb_retakeTestInfo.Enabled = false;
            lbl_totalTrials.Text = lbl_retakeAppID.Text = lbl_retakeTestAppFees.Text = lbl_totalFees.Text = Resources.txt_unknownField;
        }

        private Image _GetSceduleTestTypeImage() {
            switch (_ActiveTestType.ID) {
                case TestTypes.VisionTest: return Resources.Schedule_Vision_Test_70;
                case TestTypes.WrittenTest: return Resources.Schedule_Written_Test_70;
                case TestTypes.DrivingTest: return Resources.Schedule_Driving_Test_70;
                default: return Resources.Question_70;
            }
        }

        public Ctrl_ScheduleTest() => InitializeComponent();

        public bool SaveAppointment() {
            if (_LocalDrivingLicenseApp is null || _ActiveTestType is null)
                return false;

            if (Test.CheckForPassedTest(_LocalDrivingLicenseApp.LDLAppID, _ActiveTestType.ID)) {
                MessageBox.Show(Str_FrmTestAppointments.applicantAlreadyPassedTest, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TestAppointmentID = -1;
                _DisableSaving(Str_CtrlScheduleTest.invalidState);
                return false;
            }

            DateTime _inputDateTime = BusinessUtils.DateTimeUtils.GetFullDateTime(dtp_testDate.Value, dtp_testTime.Value);

            if (DateTime.Compare(DateTime.Now, _inputDateTime) > 0) {
                MessageBox.Show(Str_CtrlScheduleTest.chooseFutureDate, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int? _retakeFailedTestAppID = null;

            if (_ActiveMode == Modes.AddNew) {
                User _createdByUserInfo = GlobalFields.ActiveUserInfo;

                if (_createdByUserInfo is null || !_createdByUserInfo.IsActive) {
                    MessageBox.Show(_createdByUserInfo is null ? Resources.msg_currentUserNoLongerExists : Resources.msg_currentUserIsInactive, Resources.msg_error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ForceExit?.Invoke();
                    return false;
                }

                if (gb_retakeTestInfo.Enabled) {
                    if (_CreateNewRetakeTestApplication(_inputDateTime, ref _retakeFailedTestAppID))
                        lbl_retakeAppID.Text = _retakeFailedTestAppID.ToString();
                    else {
                        MessageBox.Show(Str_CtrlScheduleTest.retakeAppSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                _TestAppointment = new TestAppointment() {
                    CreatedByUserID = _createdByUserInfo.UserID,
                    FeesPaid = decimal.Parse(lbl_testFees.Text),
                    IsLocked = false,
                    LocalDrivingLicenseAppID = _LocalDrivingLicenseApp.LDLAppID,
                    TestTypeID = _ActiveTestType.ID,
                    RetakeFailedTestAppID = _retakeFailedTestAppID
                };
            }

            _TestAppointment.AppointmentDate = _inputDateTime;

            if (_TestAppointment.Save()) {
                DataSaved?.Invoke();

                if (_ActiveMode == Modes.AddNew) {
                    _ActiveMode = Modes.Update;
                    MessageBox.Show(Str_CtrlScheduleTest.appointmentSavedSuccessfullyWithID + _TestAppointment.TestAppointmentID, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Str_CtrlScheduleTest.appointmentSavedSuccessfully, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }

            //We must delete the retake test application if any:

            if (_retakeFailedTestAppID != null) //Retake test
                DVLD_Business.Application.Delete(_retakeFailedTestAppID.Value); //If this failed... I don't know... (we may keep track of all failed deletions and occasionally try to delete them in the background without the user knowing but this would be complicated and I don't want to do it)

            MessageBox.Show(Str_CtrlScheduleTest.appointmentSaveFailed, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            return false;
        }

        private bool _CreateNewRetakeTestApplication(DateTime applicationDate, ref int? retakeFailedTestAppID) {
            DVLD_Business.Application _retakeFailedTestApp = new DVLD_Business.Application() {
                ApplicantPersonID = _LocalDrivingLicenseApp.ApplicantPersonID,
                ApplicationDate = applicationDate,
                UpdateStatusDate = applicationDate,
                ApplicationStatus = ApplicationStatus.Completed,
                ApplicationTypeID = ApplicationTypes.RetakeFailedTest,
                CreatedByUserID = GlobalFields.ActiveUserID,
                FeesPaid = decimal.Parse(lbl_retakeTestAppFees.Text)
            };

            if (_retakeFailedTestApp.Save()) {
                retakeFailedTestAppID = _retakeFailedTestApp.BaseApplicationID;
                return true;
            }

            return false;
        }

        private void _DisableSaving(string message) {
            lbl_cannotUpdate.Text = message;
            lbl_cannotUpdate.Visible = !string.IsNullOrEmpty(message);
            dtp_testDate.Enabled = dtp_testTime.Enabled = SaveEnabled = false;
            SaveEnabledChanged?.Invoke();
        }

        private void _EnableSaving() {
            lbl_cannotUpdate.Visible = false;
            dtp_testDate.Enabled = dtp_testTime.Enabled = SaveEnabled = true;
            SaveEnabledChanged?.Invoke();
        }
    }
}
