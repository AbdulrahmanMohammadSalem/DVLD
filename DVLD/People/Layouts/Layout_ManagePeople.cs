using DVLD.Common;
using DVLD.Interfaces;
using DVLD.Properties;
using DVLD.String_Resources.Layouts;
using DVLD_Business;
using Salem.Extensions;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static DVLD_Business.Permissions;

namespace DVLD.People {
    public partial class Layout_ManagePeople : ClosableLayout, IDataConsumer, IEnforcePermissions {
        private DataTable _dtAllPeople;

        public Layout_ManagePeople() {
            InitializeComponent();

            if (Settings.Default.CurrentLanguage == SupportedLanguages.English)
                cb_inputFilterBy.Height += 3;

            EnforcePermissions(GlobalFields.ActiveUserPermissions);

            _ProcessNoDataAvailableLabel(lbl_noDataAvailable);
            contextMenuStrip1.Renderer = GlobalFields.ToolStripRenderer;
            
            Settings.Default.ApplyDataGridViewStyleSettings(dgv_people);
            Settings.Default.SettingsSaving += Default_SettingsSaving;

            cb_inputFilterBy.Tag = false; //DigitsOnly = false
        }

        private void Default_SettingsSaving(object sender, CancelEventArgs e) => Settings.Default.ApplyDataGridViewStyleSettings(dgv_people);

        protected override void OnCloseRequested(bool showBackground) {
            Settings.Default.SettingsSaving -= Default_SettingsSaving;
            base.OnCloseRequested(showBackground);
        }

        /// <summary>
        /// This automatically map each item in the ComboBox to each index along with the database column name.
        /// </summary>
        private enum FilterByOptions : byte {
            None, PersonID, NationalNum, FirstName, SecondName, ThirdName,
            LastName, Gender, DateOfBirth, CountryName, PhoneNumber, Email
        }

        private void Layout_ManagePeople_Load(object sender, EventArgs e) {
            if (GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeeAllPeople)) {
                ReloadAllData();
                _SetupTableHeader();
            }
        }

        private void _SetupTableHeader() {
            dgv_people.Columns[0].HeaderText = Str_LayoutManagePeople.personID;
            dgv_people.Columns[1].HeaderText = Str_LayoutManagePeople.nationalNum;
            dgv_people.Columns[2].HeaderText = Str_LayoutManagePeople.firstName;
            dgv_people.Columns[3].HeaderText = Str_LayoutManagePeople.secondName;
            dgv_people.Columns[4].HeaderText = Str_LayoutManagePeople.thirdName;
            dgv_people.Columns[5].HeaderText = Str_LayoutManagePeople.lastName;
            dgv_people.Columns[6].HeaderText = Str_LayoutManagePeople.gender;
            dgv_people.Columns[7].HeaderText = Str_LayoutManagePeople.dateOfBirth;
            dgv_people.Columns[8].HeaderText = Str_LayoutManagePeople.nationality;
            dgv_people.Columns[9].HeaderText = Str_LayoutManagePeople.phoneNumber;
            dgv_people.Columns[10].HeaderText = Str_LayoutManagePeople.email;
        }

        private void btn_close_Click(object sender, EventArgs e) => OnCloseRequested(true);

        private void comboBox_filterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if (dgv_people.DataSource is null)
                return;

            FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;
            
            if (_selectedFilter.In(FilterByOptions.PersonID, FilterByOptions.NationalNum, FilterByOptions.PhoneNumber)) {
                if (!((bool) cb_inputFilterBy.Tag)) {
                    cb_inputFilterBy.KeyPress += ComboBox_inputFilterBy_KeyPress;
                    cb_inputFilterBy.Tag = true;
                }
            } else if ((bool) cb_inputFilterBy.Tag) {
                cb_inputFilterBy.KeyPress -= ComboBox_inputFilterBy_KeyPress;
                cb_inputFilterBy.Tag = false;
            }

            if (_selectedFilter == FilterByOptions.Gender) {
                if (cb_inputFilterBy.Items.Count == 0 || cb_inputFilterBy.Items.Count != 3) {
                    cb_inputFilterBy.Items.Clear();
                    cb_inputFilterBy.Items.AddRange(new string[3] { Str_LayoutManagePeople.all, Resources.txt_male, Resources.txt_female });
                }

                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
                cb_inputFilterBy.SelectedIndex = 0;
            } else if (_selectedFilter == FilterByOptions.CountryName) {
                if (cb_inputFilterBy.Items.Count == 0 || cb_inputFilterBy.Items.Count == 3) {
                    cb_inputFilterBy.Items.Clear();
                    cb_inputFilterBy.Items.AddRange(Country.GetAllCountryNames(Settings.Default.CurrentLanguage));
                }

                cb_inputFilterBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.DropDown;
            } else {
                cb_inputFilterBy.DropDownStyle = ComboBoxStyle.Simple;
                cb_inputFilterBy.AutoCompleteMode = AutoCompleteMode.None;
            }

            cb_inputFilterBy.Visible = _selectedFilter != FilterByOptions.None;
            cb_inputFilterBy.Text = string.Empty; //To invoke the TextChanged event and clear filtering and show all records
        }

        private void ComboBox_inputFilterBy_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        private void ComboBox_inputFilterBy_TextChanged(object sender, EventArgs e) => RefreshDataFiltering();

        private void button_addNewPerson_Click(object sender, EventArgs e) => _DisplayAddNewPersonDialog();

        private void _DisplayAddNewPersonDialog() {
            using (Frm_AddEditPerson _frmAddNewPerson = new Frm_AddEditPerson()) {
                _frmAddNewPerson.PersonSaved += _frmAddNewPerson_PersonSaved;
                _frmAddNewPerson.ShowDialog();
                _frmAddNewPerson.PersonSaved -= _frmAddNewPerson_PersonSaved;
            }
        }

        private void _frmAddNewPerson_PersonSaved(int personID) => ReloadAllData();

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e) => _DisplayAddNewPersonDialog();

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            using (Frm_AddEditPerson _frmEditPerson = new Frm_AddEditPerson((int) dgv_people.CurrentRow.Cells[0].Value)) {
                if (_frmEditPerson.IsDisposed) //In case the person was not found in the form -- It will become disposed of then
                    return;

                _frmEditPerson.PersonSaved += _frmAddNewPerson_PersonSaved;
                _frmEditPerson.ShowDialog();
                _frmEditPerson.PersonSaved -= _frmAddNewPerson_PersonSaved;
            }

            dgv_people.ClearSelection();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e) => _ShowCurrentRowDetails();

        private void _ShowCurrentRowDetails() {
            using (Frm_ShowPersonInformation _frmShowPersonInfo = new Frm_ShowPersonInformation((int) dgv_people.CurrentRow.Cells[0].Value)) {
                if (_frmShowPersonInfo.IsDisposed)
                    return;

                _frmShowPersonInfo.PersonSaved += _frmAddNewPerson_PersonSaved;
                _frmShowPersonInfo.ShowDialog();
                _frmShowPersonInfo.PersonSaved -= _frmAddNewPerson_PersonSaved;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show(Str_LayoutManagePeople.personDeleteConfirmation, Resources.msg_confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                if (Person.Delete((int) dgv_people.CurrentRow.Cells[0].Value)) {
                    ReloadAllData();
                    MessageBox.Show(Str_LayoutManagePeople.personDeleteSuccess, Resources.msg_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show(Resources.msg_errorDeleting, Resources.msg_unexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadAllData() {
            _dtAllPeople = Person.GetAllPeople(Settings.Default.CurrentLanguage);

            dgv_people.DataSource = _dtAllPeople;

            RefreshDataFiltering();
        }

        public void RefreshDataFiltering() {
            if (cb_inputFilterBy.Text == string.Empty || cb_filterBy.SelectedIndex == (int) FilterByOptions.None || (cb_filterBy.SelectedIndex == (int) FilterByOptions.Gender && cb_inputFilterBy.SelectedIndex == 0))
                _dtAllPeople.DefaultView.RowFilter = string.Empty;
            else {
                FilterByOptions _selectedFilter = (FilterByOptions) cb_filterBy.SelectedIndex;

                if (_selectedFilter == FilterByOptions.PersonID)
                    _dtAllPeople.DefaultView.RowFilter = $"{_selectedFilter} = '{cb_inputFilterBy.Text}'";
                else if (_selectedFilter == FilterByOptions.Gender)
                    _dtAllPeople.DefaultView.RowFilter = $"{_selectedFilter} = '{(char) (7 * cb_inputFilterBy.SelectedIndex + 63)}'"; //Branchless ;-)
                else if (_selectedFilter == FilterByOptions.CountryName) {
                    if (Settings.Default.CurrentLanguage == SupportedLanguages.Arabic)
                        _dtAllPeople.DefaultView.RowFilter = $"CountryNameAR LIKE '%{cb_inputFilterBy.Text}%'";
                    else
                        _dtAllPeople.DefaultView.RowFilter = $"CountryName LIKE '%{cb_inputFilterBy.Text}%'";
                } else if (_selectedFilter == FilterByOptions.DateOfBirth) {
                    if (DateTime.TryParse(cb_inputFilterBy.Text, out DateTime _result))
                        _dtAllPeople.DefaultView.RowFilter = $"{_selectedFilter} >= #{_result:yyyy-MM-dd}# AND {_selectedFilter} < #{_result.AddDays(1):yyyy-MM-dd}#";
                    else
                        _dtAllPeople.DefaultView.RowFilter = string.Empty;
                } else
                    _dtAllPeople.DefaultView.RowFilter = $"{_selectedFilter} LIKE '%{cb_inputFilterBy.Text}%'";
            }

            label_numOfRecords.Text = dgv_people.RowCount.ToString();
            lbl_noDataAvailable.Visible = dgv_people.RowCount == 0;
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e) => Person.PhoneCall(dgv_people.CurrentRow.Cells["PhoneNumber"].Value.ToString());

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e) => Person.SendEmail(dgv_people.CurrentRow.Cells["Email"].Value.ToString());

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e) => ReloadAllData();

        private void linkLabel_refreshData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => ReloadAllData();

        private void dataGridView_displayPeopleData_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards))
                _ShowCurrentRowDetails();
        }

        private void dgv_people_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.Value is null)
                return;

            if (dgv_people.Columns[e.ColumnIndex].Name == "Gender") {
                e.Value = (string) e.Value == "M" ? Resources.txt_male : Resources.txt_female;
                e.FormattingApplied = true;
            } else if ((dgv_people.Columns[e.ColumnIndex].Name == "Email" || dgv_people.Columns[e.ColumnIndex].Name == "ThirdName") && e.Value == DBNull.Value) {
                e.Value = Resources.txt_unknownField;
                e.CellStyle.ForeColor = Color.Red;
                e.FormattingApplied = true;
            } else if (dgv_people.Columns[e.ColumnIndex].Name == "DateOfBirth") {
                e.Value = BusinessUtils.DateTimeUtils.FormatDate((DateTime) e.Value);
                e.FormattingApplied = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            showDetailsToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards) && dgv_people.SelectedCells.Count > 0;
            editToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.EditPersonalInfo) && dgv_people.SelectedCells.Count > 0;
            deleteToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.DeletePerson) && dgv_people.SelectedCells.Count > 0;
            sendEmailToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.SendEmail) && dgv_people.SelectedCells.Count > 0;
            phoneCallToolStripMenuItem.Enabled = GlobalFields.ActiveUserPermissions.People.HasFlag(PeopleManagement.PhoneCall) && dgv_people.SelectedCells.Count > 0;
        }
        
        private void ll_exportData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BusinessUtils.Exporting.PerformCsvExport(Str_LayoutManagePeople.people, (_dtAllPeople ?? Person.GetAllPeople(Settings.Default.CurrentLanguage)).DefaultView);

        private void _ProcessNoDataAvailableLabel(Label lbl) {
            lbl.AutoSize = false;
            lbl.Width = dgv_people.Width - 20;
            lbl.Location = new Point(dgv_people.Location.X + 10, lbl.Location.Y);
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void EnforcePermissions(DVLD_Business.Permissions permissions) {
            lbl_filterBy.Enabled = cb_filterBy.Enabled = cb_inputFilterBy.Enabled = ll_refreshData.Enabled = refreshToolStripMenuItem1.Enabled = dgv_people.Enabled = permissions.People.HasFlag(PeopleManagement.SeeAllPeople);
            showDetailsToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SeePersonalInfoCards);
            btn_addNewPerson.Enabled = addNewPersonToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.AddNewPerson);
            editToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.EditPersonalInfo);
            deleteToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.DeletePerson);
            sendEmailToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.SendEmail);
            phoneCallToolStripMenuItem.Enabled = permissions.People.HasFlag(PeopleManagement.PhoneCall);
            ll_exportData.Enabled = permissions.People.HasFlag(PeopleManagement.ExportPeopleData);

            lbl_noDataAvailable.Text = permissions.People.HasFlag(PeopleManagement.SeeAllPeople) ? Resources.txt_noDataAvailable : Resources.txt_noPermissionsToSeeData;
        }
    }
}
