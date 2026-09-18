using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_TestsManagement : SalForm {
        public Tests_TestAppointsManagement SelectedPermissions { get; private set; } = Tests_TestAppointsManagement.NoAccess;

        public Frm_TestsManagement(Tests_TestAppointsManagement startupValues) {
            InitializeComponent();

            chk_vision_seeAllAppoints.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Vision_SeeAllAppointments);
            chk_vision_createNewAppoint.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Vision_CreateNewAppointment);
            chk_vision_updateAppointInfo.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo);
            chk_vision_takeTest.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Vision_TakeTest);
            chk_vision_seeTestResult.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Vision_SeeTestResult);
            chk_vision_exportAppointsData.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Vision_ExportAppointmentsdata);

            chk_written_seeAllAppoints.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Written_SeeAllAppointments);
            chk_written_createNewAppoint.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Written_CreateNewAppointment);
            chk_written_updateAppointInfo.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Written_UpdateAppointmentInfo);
            chk_written_takeTest.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Written_TakeTest);
            chk_written_seeTestResult.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Written_SeeTestResult);
            chk_written_exportAppointsData.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Written_ExportAppointmentsdata);

            chk_driving_seeAllAppoints.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Driving_SeeAllAppointments);
            chk_driving_createNewAppoint.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Driving_CreateNewAppointment);
            chk_driving_updateAppointInfo.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo);
            chk_driving_takeTest.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Driving_TakeTest);
            chk_driving_seeTestResult.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Driving_SeeTestResult);
            chk_driving_exportAppointsData.Checked = startupValues.HasFlag(Tests_TestAppointsManagement.Driving_ExportAppointmentsdata);
        }

        private void chk_vision_seeAllAppoints_CheckedChanged(object sender, EventArgs e) {
            if (chk_vision_seeAllAppoints.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Vision_SeeAllAppointments;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Vision_SeeAllAppointments;
        }

        private void chk_vision_createNewAppoint_CheckedChanged(object sender, EventArgs e) {
            if (chk_vision_createNewAppoint.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Vision_CreateNewAppointment;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Vision_CreateNewAppointment;
        }

        private void chk_vision_updateAppointInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_vision_updateAppointInfo.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Vision_UpdateAppointmentInfo;
        }

        private void chk_vision_takeTest_CheckedChanged(object sender, EventArgs e) {
            if (chk_vision_takeTest.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Vision_TakeTest;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Vision_TakeTest;
        }

        private void chk_vision_seeTestResult_CheckedChanged(object sender, EventArgs e) {
            if (chk_vision_seeTestResult.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Vision_SeeTestResult;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Vision_SeeTestResult;
        }

        private void chk_vision_exportAppointsData_CheckedChanged(object sender, EventArgs e) {
            if (chk_vision_exportAppointsData.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Vision_ExportAppointmentsdata;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Vision_ExportAppointmentsdata;
        }

        private void chk_written_seeAllAppoints_CheckedChanged(object sender, EventArgs e) {
            if (chk_written_seeAllAppoints.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Written_SeeAllAppointments;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Written_SeeAllAppointments;
        }

        private void chk_written_createNewAppoint_CheckedChanged(object sender, EventArgs e) {
            if (chk_written_createNewAppoint.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Written_CreateNewAppointment;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Written_CreateNewAppointment;
        }

        private void chk_written_updateAppointInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_written_updateAppointInfo.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Written_UpdateAppointmentInfo;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Written_UpdateAppointmentInfo;
        }

        private void chk_written_takeTest_CheckedChanged(object sender, EventArgs e) {
            if (chk_written_takeTest.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Written_TakeTest;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Written_TakeTest;
        }

        private void chk_written_seeTestResult_CheckedChanged(object sender, EventArgs e) {
            if (chk_written_seeTestResult.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Written_SeeTestResult;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Written_SeeTestResult;
        }

        private void chk_written_exportAppointsData_CheckedChanged(object sender, EventArgs e) {
            if (chk_written_exportAppointsData.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Written_ExportAppointmentsdata;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Written_ExportAppointmentsdata;
        }

        private void chk_driving_seeAllAppoints_CheckedChanged(object sender, EventArgs e) {
            if (chk_driving_seeAllAppoints.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Driving_SeeAllAppointments;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Driving_SeeAllAppointments;
        }

        private void chk_driving_createNewAppoint_CheckedChanged(object sender, EventArgs e) {
            if (chk_driving_createNewAppoint.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Driving_CreateNewAppointment;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Driving_CreateNewAppointment;
        }

        private void chk_driving_updateAppointInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_driving_updateAppointInfo.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Driving_UpdateAppointmentInfo;
        }

        private void chk_driving_takeTest_CheckedChanged(object sender, EventArgs e) {
            if (chk_driving_takeTest.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Driving_TakeTest;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Driving_TakeTest;
        }

        private void chk_driving_seeTestResult_CheckedChanged(object sender, EventArgs e) {
            if (chk_driving_seeTestResult.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Driving_SeeTestResult;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Driving_SeeTestResult;
        }

        private void chk_driving_exportAppointsData_CheckedChanged(object sender, EventArgs e) {
            if (chk_driving_exportAppointsData.Checked)
                SelectedPermissions |= Tests_TestAppointsManagement.Driving_ExportAppointmentsdata;
            else
                SelectedPermissions &= ~Tests_TestAppointsManagement.Driving_ExportAppointmentsdata;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if (keyData == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
