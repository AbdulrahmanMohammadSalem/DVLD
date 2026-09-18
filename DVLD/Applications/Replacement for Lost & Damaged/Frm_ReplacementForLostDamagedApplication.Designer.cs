namespace DVLD.Applications.Replacement_for_Lost_Damaged {
    partial class Frm_ReplacementForLostDamagedApplication {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReplacementForLostDamagedApplication));
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_replacementFor = new System.Windows.Forms.GroupBox();
            this.rb_damagedLicense = new System.Windows.Forms.RadioButton();
            this.rb_lostLicense = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_newLicenseID = new Salem.Controls.SalSelectableLabel();
            this.lbl_applicationFees = new Salem.Controls.SalSelectableLabel();
            this.lbl_applicationDate = new Salem.Controls.SalSelectableLabel();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_licenseReplacementAppID = new Salem.Controls.SalSelectableLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_oldLicenseID = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_issueReplacement = new System.Windows.Forms.Button();
            this.ll_showNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ll_showDriverLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ctrl_LocalLicenseInfoCardWithFilter1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter();
            this.gb_replacementFor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            resources.ApplyResources(this.lbl_title, "lbl_title");
            this.lbl_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.lbl_title.Name = "lbl_title";
            // 
            // gb_replacementFor
            // 
            resources.ApplyResources(this.gb_replacementFor, "gb_replacementFor");
            this.gb_replacementFor.Controls.Add(this.rb_damagedLicense);
            this.gb_replacementFor.Controls.Add(this.rb_lostLicense);
            this.gb_replacementFor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gb_replacementFor.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.gb_replacementFor.Name = "gb_replacementFor";
            this.gb_replacementFor.TabStop = false;
            // 
            // rb_damagedLicense
            // 
            resources.ApplyResources(this.rb_damagedLicense, "rb_damagedLicense");
            this.rb_damagedLicense.Name = "rb_damagedLicense";
            this.rb_damagedLicense.UseVisualStyleBackColor = true;
            this.rb_damagedLicense.CheckedChanged += new System.EventHandler(this.rb_replacementFor_CheckedChanged);
            // 
            // rb_lostLicense
            // 
            resources.ApplyResources(this.rb_lostLicense, "rb_lostLicense");
            this.rb_lostLicense.Checked = true;
            this.rb_lostLicense.Name = "rb_lostLicense";
            this.rb_lostLicense.TabStop = true;
            this.rb_lostLicense.UseVisualStyleBackColor = true;
            this.rb_lostLicense.CheckedChanged += new System.EventHandler(this.rb_replacementFor_CheckedChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.lbl_newLicenseID);
            this.groupBox2.Controls.Add(this.lbl_applicationFees);
            this.groupBox2.Controls.Add(this.lbl_applicationDate);
            this.groupBox2.Controls.Add(this.lbl_createdBy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_licenseReplacementAppID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbl_oldLicenseID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lbl_newLicenseID
            // 
            resources.ApplyResources(this.lbl_newLicenseID, "lbl_newLicenseID");
            this.lbl_newLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_newLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_newLicenseID.Name = "lbl_newLicenseID";
            this.lbl_newLicenseID.ReadOnly = true;
            this.lbl_newLicenseID.TabStop = false;
            // 
            // lbl_applicationFees
            // 
            resources.ApplyResources(this.lbl_applicationFees, "lbl_applicationFees");
            this.lbl_applicationFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_applicationFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationFees.Name = "lbl_applicationFees";
            this.lbl_applicationFees.ReadOnly = true;
            this.lbl_applicationFees.TabStop = false;
            // 
            // lbl_applicationDate
            // 
            resources.ApplyResources(this.lbl_applicationDate, "lbl_applicationDate");
            this.lbl_applicationDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_applicationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationDate.Name = "lbl_applicationDate";
            this.lbl_applicationDate.ReadOnly = true;
            this.lbl_applicationDate.TabStop = false;
            // 
            // lbl_createdBy
            // 
            resources.ApplyResources(this.lbl_createdBy, "lbl_createdBy");
            this.lbl_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.ReadOnly = true;
            this.lbl_createdBy.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.money_32;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.Name = "label1";
            // 
            // lbl_licenseReplacementAppID
            // 
            resources.ApplyResources(this.lbl_licenseReplacementAppID, "lbl_licenseReplacementAppID");
            this.lbl_licenseReplacementAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseReplacementAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_licenseReplacementAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseReplacementAppID.Name = "lbl_licenseReplacementAppID";
            this.lbl_licenseReplacementAppID.ReadOnly = true;
            this.lbl_licenseReplacementAppID.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label8.Name = "label8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.label10.Name = "label10";
            // 
            // lbl_oldLicenseID
            // 
            resources.ApplyResources(this.lbl_oldLicenseID, "lbl_oldLicenseID");
            this.lbl_oldLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_oldLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_oldLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_oldLicenseID.Name = "lbl_oldLicenseID";
            this.lbl_oldLicenseID.ReadOnly = true;
            this.lbl_oldLicenseID.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.label9.Name = "label9";
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // btn_issueReplacement
            // 
            resources.ApplyResources(this.btn_issueReplacement, "btn_issueReplacement");
            this.btn_issueReplacement.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_issueReplacement.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_issueReplacement.FlatAppearance.BorderSize = 2;
            this.btn_issueReplacement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_issueReplacement.Image = global::DVLD.Properties.Resources.Renew_Local_License_32;
            this.btn_issueReplacement.Name = "btn_issueReplacement";
            this.btn_issueReplacement.UseVisualStyleBackColor = false;
            this.btn_issueReplacement.Click += new System.EventHandler(this.btn_issueReplacement_Click);
            // 
            // ll_showNewLicenseInfo
            // 
            resources.ApplyResources(this.ll_showNewLicenseInfo, "ll_showNewLicenseInfo");
            this.ll_showNewLicenseInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showNewLicenseInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showNewLicenseInfo.Name = "ll_showNewLicenseInfo";
            this.ll_showNewLicenseInfo.TabStop = true;
            this.ll_showNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showNewLicenseInfo_LinkClicked);
            // 
            // ll_showDriverLicenseHistory
            // 
            resources.ApplyResources(this.ll_showDriverLicenseHistory, "ll_showDriverLicenseHistory");
            this.ll_showDriverLicenseHistory.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showDriverLicenseHistory.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showDriverLicenseHistory.Name = "ll_showDriverLicenseHistory";
            this.ll_showDriverLicenseHistory.TabStop = true;
            this.ll_showDriverLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showDriverLicenseHistory_LinkClicked);
            // 
            // ctrl_LocalLicenseInfoCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_LocalLicenseInfoCardWithFilter1, "ctrl_LocalLicenseInfoCardWithFilter1");
            this.ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = true;
            this.ctrl_LocalLicenseInfoCardWithFilter1.Name = "ctrl_LocalLicenseInfoCardWithFilter1";
            this.ctrl_LocalLicenseInfoCardWithFilter1.LicenseFound += new System.Action<bool>(this.ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound);
            this.ctrl_LocalLicenseInfoCardWithFilter1.LicenseNotFound += new System.Action(this.ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound);
            this.ctrl_LocalLicenseInfoCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved);
            // 
            // Frm_ReplacementForLostDamagedApplication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_issueReplacement);
            this.Controls.Add(this.ll_showNewLicenseInfo);
            this.Controls.Add(this.ll_showDriverLicenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_replacementFor);
            this.Controls.Add(this.ctrl_LocalLicenseInfoCardWithFilter1);
            this.Controls.Add(this.lbl_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReplacementForLostDamagedApplication";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_ReplacementForLostDamagedApplication_Activated);
            this.gb_replacementFor.ResumeLayout(false);
            this.gb_replacementFor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter ctrl_LocalLicenseInfoCardWithFilter1;
        private System.Windows.Forms.GroupBox gb_replacementFor;
        private System.Windows.Forms.RadioButton rb_damagedLicense;
        private System.Windows.Forms.RadioButton rb_lostLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Salem.Controls.SalSelectableLabel lbl_newLicenseID;
        private Salem.Controls.SalSelectableLabel lbl_applicationFees;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_applicationDate;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_licenseReplacementAppID;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel lbl_oldLicenseID;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_issueReplacement;
        private System.Windows.Forms.LinkLabel ll_showNewLicenseInfo;
        private System.Windows.Forms.LinkLabel ll_showDriverLicenseHistory;
    }
}