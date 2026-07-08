namespace DVLD.Detain_Licenses {
    partial class Frm_ReleaseDetainedLicense {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReleaseDetainedLicense));
            this.label_title = new System.Windows.Forms.Label();
            this.ctrl_LocalLicenseInfoCardWithFilter1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_releasedBy = new Salem.Controls.SalSelectableLabel();
            this.lbl_totalFees = new Salem.Controls.SalSelectableLabel();
            this.lbl_applicationFees = new Salem.Controls.SalSelectableLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_releaseDate = new Salem.Controls.SalSelectableLabel();
            this.lbl_fineFees = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_releaseAppID = new Salem.Controls.SalSelectableLabel();
            this.lbl_detainReason = new Salem.Controls.SalSelectableLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_licenseID = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_detainDate = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_detainID = new Salem.Controls.SalSelectableLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_release = new System.Windows.Forms.Button();
            this.ll_showLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.lbl_releasedBy);
            this.groupBox2.Controls.Add(this.lbl_totalFees);
            this.groupBox2.Controls.Add(this.lbl_applicationFees);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_releaseDate);
            this.groupBox2.Controls.Add(this.lbl_fineFees);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_releaseAppID);
            this.groupBox2.Controls.Add(this.lbl_detainReason);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_licenseID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_createdBy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_detainDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbl_detainID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lbl_releasedBy
            // 
            resources.ApplyResources(this.lbl_releasedBy, "lbl_releasedBy");
            this.lbl_releasedBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_releasedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_releasedBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_releasedBy.Name = "lbl_releasedBy";
            this.lbl_releasedBy.ReadOnly = true;
            this.lbl_releasedBy.TabStop = false;
            // 
            // lbl_totalFees
            // 
            resources.ApplyResources(this.lbl_totalFees, "lbl_totalFees");
            this.lbl_totalFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_totalFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_totalFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_totalFees.Name = "lbl_totalFees";
            this.lbl_totalFees.ReadOnly = true;
            this.lbl_totalFees.TabStop = false;
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
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.money_32;
            this.label7.Name = "label7";
            // 
            // lbl_releaseDate
            // 
            resources.ApplyResources(this.lbl_releaseDate, "lbl_releaseDate");
            this.lbl_releaseDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_releaseDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_releaseDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_releaseDate.Name = "lbl_releaseDate";
            this.lbl_releaseDate.ReadOnly = true;
            this.lbl_releaseDate.TabStop = false;
            // 
            // lbl_fineFees
            // 
            resources.ApplyResources(this.lbl_fineFees, "lbl_fineFees");
            this.lbl_fineFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fineFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_fineFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_fineFees.Name = "lbl_fineFees";
            this.lbl_fineFees.ReadOnly = true;
            this.lbl_fineFees.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label5.Name = "label5";
            // 
            // lbl_releaseAppID
            // 
            resources.ApplyResources(this.lbl_releaseAppID, "lbl_releaseAppID");
            this.lbl_releaseAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_releaseAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_releaseAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_releaseAppID.Name = "lbl_releaseAppID";
            this.lbl_releaseAppID.ReadOnly = true;
            this.lbl_releaseAppID.TabStop = false;
            // 
            // lbl_detainReason
            // 
            resources.ApplyResources(this.lbl_detainReason, "lbl_detainReason");
            this.lbl_detainReason.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_detainReason.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_detainReason.Name = "lbl_detainReason";
            this.lbl_detainReason.ReadOnly = true;
            this.lbl_detainReason.TabStop = false;
            this.lbl_detainReason.TextChanged += new System.EventHandler(this.lbl_detainReason_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Number_32;
            this.label4.Name = "label4";
            // 
            // lbl_licenseID
            // 
            resources.ApplyResources(this.lbl_licenseID, "lbl_licenseID");
            this.lbl_licenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_licenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseID.Name = "lbl_licenseID";
            this.lbl_licenseID.ReadOnly = true;
            this.lbl_licenseID.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.Notes_32;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.Name = "label1";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_detainDate
            // 
            resources.ApplyResources(this.lbl_detainDate, "lbl_detainDate");
            this.lbl_detainDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_detainDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_detainDate.Name = "lbl_detainDate";
            this.lbl_detainDate.ReadOnly = true;
            this.lbl_detainDate.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.money_32;
            this.label6.Name = "label6";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.money_32;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.label10.Name = "label10";
            // 
            // lbl_detainID
            // 
            resources.ApplyResources(this.lbl_detainID, "lbl_detainID");
            this.lbl_detainID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_detainID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_detainID.Name = "lbl_detainID";
            this.lbl_detainID.ReadOnly = true;
            this.lbl_detainID.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label11.Name = "label11";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label8.Name = "label8";
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
            // btn_release
            // 
            resources.ApplyResources(this.btn_release, "btn_release");
            this.btn_release.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_release.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_release.FlatAppearance.BorderSize = 2;
            this.btn_release.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_release.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.btn_release.Name = "btn_release";
            this.btn_release.UseVisualStyleBackColor = false;
            this.btn_release.Click += new System.EventHandler(this.btn_release_Click);
            // 
            // ll_showLicenseHistory
            // 
            resources.ApplyResources(this.ll_showLicenseHistory, "ll_showLicenseHistory");
            this.ll_showLicenseHistory.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showLicenseHistory.ForeColor = System.Drawing.Color.Blue;
            this.ll_showLicenseHistory.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showLicenseHistory.Name = "ll_showLicenseHistory";
            this.ll_showLicenseHistory.TabStop = true;
            this.ll_showLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showLicenseHistory_LinkClicked);
            // 
            // Frm_ReleaseDetainedLicense
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_release);
            this.Controls.Add(this.ll_showLicenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.ctrl_LocalLicenseInfoCardWithFilter1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReleaseDetainedLicense";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_ReleaseDetainedLicense_Activated);
            this.Load += new System.EventHandler(this.Frm_ReleaseDetainedLicense_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter ctrl_LocalLicenseInfoCardWithFilter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Salem.Controls.SalSelectableLabel lbl_detainReason;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_licenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_detainID;
        private Salem.Controls.SalSelectableLabel lbl_detainDate;
        private Salem.Controls.SalSelectableLabel lbl_releaseAppID;
        private Salem.Controls.SalSelectableLabel lbl_releaseDate;
        private Salem.Controls.SalSelectableLabel lbl_fineFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel lbl_totalFees;
        private Salem.Controls.SalSelectableLabel lbl_applicationFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Salem.Controls.SalSelectableLabel lbl_releasedBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_release;
        private System.Windows.Forms.LinkLabel ll_showLicenseHistory;
    }
}