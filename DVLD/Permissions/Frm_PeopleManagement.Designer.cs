namespace DVLD.Permissions {
    partial class Frm_PeopleManagement {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PeopleManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_exportPeopleData = new System.Windows.Forms.CheckBox();
            this.chk_phoneCall = new System.Windows.Forms.CheckBox();
            this.chk_sendEmail = new System.Windows.Forms.CheckBox();
            this.chk_deletePerson = new System.Windows.Forms.CheckBox();
            this.chk_editPersonalInfo = new System.Windows.Forms.CheckBox();
            this.chk_addNewPerson = new System.Windows.Forms.CheckBox();
            this.chk_seePersonalInfoCards = new System.Windows.Forms.CheckBox();
            this.chk_seeAllPeople = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_exportPeopleData);
            this.groupBox1.Controls.Add(this.chk_phoneCall);
            this.groupBox1.Controls.Add(this.chk_sendEmail);
            this.groupBox1.Controls.Add(this.chk_deletePerson);
            this.groupBox1.Controls.Add(this.chk_editPersonalInfo);
            this.groupBox1.Controls.Add(this.chk_addNewPerson);
            this.groupBox1.Controls.Add(this.chk_seePersonalInfoCards);
            this.groupBox1.Controls.Add(this.chk_seeAllPeople);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_exportPeopleData
            // 
            resources.ApplyResources(this.chk_exportPeopleData, "chk_exportPeopleData");
            this.chk_exportPeopleData.Name = "chk_exportPeopleData";
            this.chk_exportPeopleData.UseVisualStyleBackColor = true;
            this.chk_exportPeopleData.CheckedChanged += new System.EventHandler(this.chk_exportPeopleData_CheckedChanged);
            // 
            // chk_phoneCall
            // 
            resources.ApplyResources(this.chk_phoneCall, "chk_phoneCall");
            this.chk_phoneCall.Name = "chk_phoneCall";
            this.chk_phoneCall.UseVisualStyleBackColor = true;
            this.chk_phoneCall.CheckedChanged += new System.EventHandler(this.chk_phoneCall_CheckedChanged);
            // 
            // chk_sendEmail
            // 
            resources.ApplyResources(this.chk_sendEmail, "chk_sendEmail");
            this.chk_sendEmail.Name = "chk_sendEmail";
            this.chk_sendEmail.UseVisualStyleBackColor = true;
            this.chk_sendEmail.CheckedChanged += new System.EventHandler(this.chk_sendEmail_CheckedChanged);
            // 
            // chk_deletePerson
            // 
            resources.ApplyResources(this.chk_deletePerson, "chk_deletePerson");
            this.chk_deletePerson.Name = "chk_deletePerson";
            this.chk_deletePerson.UseVisualStyleBackColor = true;
            this.chk_deletePerson.CheckedChanged += new System.EventHandler(this.chk_deletePerson_CheckedChanged);
            // 
            // chk_editPersonalInfo
            // 
            resources.ApplyResources(this.chk_editPersonalInfo, "chk_editPersonalInfo");
            this.chk_editPersonalInfo.Name = "chk_editPersonalInfo";
            this.chk_editPersonalInfo.UseVisualStyleBackColor = true;
            this.chk_editPersonalInfo.CheckedChanged += new System.EventHandler(this.chk_editPersonalInfo_CheckedChanged);
            // 
            // chk_addNewPerson
            // 
            resources.ApplyResources(this.chk_addNewPerson, "chk_addNewPerson");
            this.chk_addNewPerson.Name = "chk_addNewPerson";
            this.chk_addNewPerson.UseVisualStyleBackColor = true;
            this.chk_addNewPerson.CheckedChanged += new System.EventHandler(this.chk_addNewPerson_CheckedChanged);
            // 
            // chk_seePersonalInfoCards
            // 
            resources.ApplyResources(this.chk_seePersonalInfoCards, "chk_seePersonalInfoCards");
            this.chk_seePersonalInfoCards.Name = "chk_seePersonalInfoCards";
            this.chk_seePersonalInfoCards.UseVisualStyleBackColor = true;
            this.chk_seePersonalInfoCards.CheckedChanged += new System.EventHandler(this.chk_seePersonalInfoCards_CheckedChanged);
            // 
            // chk_seeAllPeople
            // 
            resources.ApplyResources(this.chk_seeAllPeople, "chk_seeAllPeople");
            this.chk_seeAllPeople.Name = "chk_seeAllPeople";
            this.chk_seeAllPeople.UseVisualStyleBackColor = true;
            this.chk_seeAllPeople.CheckedChanged += new System.EventHandler(this.chk_seeAllPeople_CheckedChanged);
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_ok.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // Frm_PeopleManagement
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_PeopleManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_seeAllPeople;
        private System.Windows.Forms.CheckBox chk_exportPeopleData;
        private System.Windows.Forms.CheckBox chk_phoneCall;
        private System.Windows.Forms.CheckBox chk_sendEmail;
        private System.Windows.Forms.CheckBox chk_deletePerson;
        private System.Windows.Forms.CheckBox chk_editPersonalInfo;
        private System.Windows.Forms.CheckBox chk_addNewPerson;
        private System.Windows.Forms.CheckBox chk_seePersonalInfoCards;
    }
}