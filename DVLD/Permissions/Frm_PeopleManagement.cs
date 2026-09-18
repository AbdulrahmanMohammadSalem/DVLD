using Salem.Controls;
using System;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.Permissions {
    public partial class Frm_PeopleManagement : SalForm {
        public PeopleManagement SelectedPermissions { get; private set; } = PeopleManagement.NoAccess;

        public Frm_PeopleManagement(PeopleManagement startupValues) {
            InitializeComponent();

            chk_seeAllPeople.Checked = startupValues.HasFlag(PeopleManagement.SeeAllPeople);
            chk_seePersonalInfoCards.Checked = startupValues.HasFlag(PeopleManagement.SeePersonalInfoCards);
            chk_addNewPerson.Checked = startupValues.HasFlag(PeopleManagement.AddNewPerson);
            chk_editPersonalInfo.Checked = startupValues.HasFlag(PeopleManagement.EditPersonalInfo);
            chk_deletePerson.Checked = startupValues.HasFlag(PeopleManagement.DeletePerson);
            chk_sendEmail.Checked = startupValues.HasFlag(PeopleManagement.SendEmail);
            chk_phoneCall.Checked = startupValues.HasFlag(PeopleManagement.PhoneCall);
            chk_exportPeopleData.Checked = startupValues.HasFlag(PeopleManagement.ExportPeopleData);
        }

        private void chk_seeAllPeople_CheckedChanged(object sender, EventArgs e) {
            if (chk_seeAllPeople.Checked)
                SelectedPermissions |= PeopleManagement.SeeAllPeople;
            else
                SelectedPermissions &= ~PeopleManagement.SeeAllPeople;
        }

        private void chk_seePersonalInfoCards_CheckedChanged(object sender, EventArgs e) {
            if (chk_seePersonalInfoCards.Checked)
                SelectedPermissions |= PeopleManagement.SeePersonalInfoCards;
            else
                SelectedPermissions &= ~PeopleManagement.SeePersonalInfoCards;
        }

        private void chk_addNewPerson_CheckedChanged(object sender, EventArgs e) {
            if (chk_addNewPerson.Checked)
                SelectedPermissions |= PeopleManagement.AddNewPerson;
            else
                SelectedPermissions &= ~PeopleManagement.AddNewPerson;
        }

        private void chk_editPersonalInfo_CheckedChanged(object sender, EventArgs e) {
            if (chk_editPersonalInfo.Checked)
                SelectedPermissions |= PeopleManagement.EditPersonalInfo;
            else
                SelectedPermissions &= ~PeopleManagement.EditPersonalInfo;
        }

        private void chk_deletePerson_CheckedChanged(object sender, EventArgs e) {
            if (chk_deletePerson.Checked)
                SelectedPermissions |= PeopleManagement.DeletePerson;
            else
                SelectedPermissions &= ~PeopleManagement.DeletePerson;
        }

        private void chk_sendEmail_CheckedChanged(object sender, EventArgs e) {
            if (chk_sendEmail.Checked)
                SelectedPermissions |= PeopleManagement.SendEmail;
            else
                SelectedPermissions &= ~PeopleManagement.SendEmail;
        }

        private void chk_phoneCall_CheckedChanged(object sender, EventArgs e) {
            if (chk_phoneCall.Checked)
                SelectedPermissions |= PeopleManagement.PhoneCall;
            else
                SelectedPermissions &= ~PeopleManagement.PhoneCall;
        }

        private void chk_exportPeopleData_CheckedChanged(object sender, EventArgs e) {
            if (chk_exportPeopleData.Checked)
                SelectedPermissions |= PeopleManagement.ExportPeopleData;
            else
                SelectedPermissions &= ~PeopleManagement.ExportPeopleData;
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
