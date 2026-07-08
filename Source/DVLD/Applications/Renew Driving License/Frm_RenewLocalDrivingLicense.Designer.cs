namespace DVLD.Applications.Renew_Driving_License {
    partial class Frm_RenewLocalDrivingLicense {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RenewLocalDrivingLicense));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_notes = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_newLicenseID = new Salem.Controls.SalSelectableLabel();
            this.lbl_licenseFees = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_applicationFees = new Salem.Controls.SalSelectableLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_issueDate = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_applicationDate = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_renewAppID = new Salem.Controls.SalSelectableLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_oldLicenseID = new Salem.Controls.SalSelectableLabel();
            this.lbl_newExpirationDate = new Salem.Controls.SalSelectableLabel();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.lbl_totalFees = new Salem.Controls.SalSelectableLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.ll_showRenewedLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ll_showLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_renew = new System.Windows.Forms.Button();
            this.ctrl_LocalLicenseInfoCardWithFilter1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_notes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_newLicenseID);
            this.groupBox1.Controls.Add(this.lbl_licenseFees);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_applicationFees);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_issueDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_applicationDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_renewAppID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_oldLicenseID);
            this.groupBox1.Controls.Add(this.lbl_newExpirationDate);
            this.groupBox1.Controls.Add(this.lbl_createdBy);
            this.groupBox1.Controls.Add(this.lbl_totalFees);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txt_notes
            // 
            this.txt_notes.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_notes.BeforeTouchSize = new System.Drawing.Size(462, 76);
            this.txt_notes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txt_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_notes.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_notes.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.txt_notes, "txt_notes");
            this.txt_notes.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.txt_notes.Name = "txt_notes";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Image = global::DVLD.Properties.Resources.Notes_32;
            this.label11.Name = "label11";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.Number_32;
            this.label9.Name = "label9";
            // 
            // lbl_newLicenseID
            // 
            this.lbl_newLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_newLicenseID, "lbl_newLicenseID");
            this.lbl_newLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_newLicenseID.Name = "lbl_newLicenseID";
            this.lbl_newLicenseID.ReadOnly = true;
            this.lbl_newLicenseID.TabStop = false;
            // 
            // lbl_licenseFees
            // 
            this.lbl_licenseFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_licenseFees, "lbl_licenseFees");
            this.lbl_licenseFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseFees.Name = "lbl_licenseFees";
            this.lbl_licenseFees.ReadOnly = true;
            this.lbl_licenseFees.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbl_applicationFees
            // 
            this.lbl_applicationFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_applicationFees, "lbl_applicationFees");
            this.lbl_applicationFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationFees.Name = "lbl_applicationFees";
            this.lbl_applicationFees.ReadOnly = true;
            this.lbl_applicationFees.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbl_issueDate
            // 
            this.lbl_issueDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_issueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_issueDate, "lbl_issueDate");
            this.lbl_issueDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_issueDate.Name = "lbl_issueDate";
            this.lbl_issueDate.ReadOnly = true;
            this.lbl_issueDate.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbl_applicationDate
            // 
            this.lbl_applicationDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_applicationDate, "lbl_applicationDate");
            this.lbl_applicationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationDate.Name = "lbl_applicationDate";
            this.lbl_applicationDate.ReadOnly = true;
            this.lbl_applicationDate.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_renewAppID
            // 
            this.lbl_renewAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_renewAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_renewAppID, "lbl_renewAppID");
            this.lbl_renewAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_renewAppID.Name = "lbl_renewAppID";
            this.lbl_renewAppID.ReadOnly = true;
            this.lbl_renewAppID.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.Name = "label1";
            // 
            // lbl_oldLicenseID
            // 
            this.lbl_oldLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_oldLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_oldLicenseID, "lbl_oldLicenseID");
            this.lbl_oldLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_oldLicenseID.Name = "lbl_oldLicenseID";
            this.lbl_oldLicenseID.ReadOnly = true;
            this.lbl_oldLicenseID.TabStop = false;
            // 
            // lbl_newExpirationDate
            // 
            this.lbl_newExpirationDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_newExpirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_newExpirationDate, "lbl_newExpirationDate");
            this.lbl_newExpirationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_newExpirationDate.Name = "lbl_newExpirationDate";
            this.lbl_newExpirationDate.ReadOnly = true;
            this.lbl_newExpirationDate.TabStop = false;
            // 
            // lbl_createdBy
            // 
            this.lbl_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_createdBy, "lbl_createdBy");
            this.lbl_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.ReadOnly = true;
            this.lbl_createdBy.TabStop = false;
            // 
            // lbl_totalFees
            // 
            this.lbl_totalFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_totalFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_totalFees, "lbl_totalFees");
            this.lbl_totalFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_totalFees.Name = "lbl_totalFees";
            this.lbl_totalFees.ReadOnly = true;
            this.lbl_totalFees.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.Number_32;
            this.label10.Name = "label10";
            // 
            // ll_showRenewedLicenseInfo
            // 
            resources.ApplyResources(this.ll_showRenewedLicenseInfo, "ll_showRenewedLicenseInfo");
            this.ll_showRenewedLicenseInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showRenewedLicenseInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showRenewedLicenseInfo.Name = "ll_showRenewedLicenseInfo";
            this.ll_showRenewedLicenseInfo.TabStop = true;
            this.ll_showRenewedLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showRenewedLicenseInfo_LinkClicked);
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
            // btn_renew
            // 
            resources.ApplyResources(this.btn_renew, "btn_renew");
            this.btn_renew.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_renew.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_renew.FlatAppearance.BorderSize = 2;
            this.btn_renew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_renew.Image = global::DVLD.Properties.Resources.Renew_Local_License_32;
            this.btn_renew.Name = "btn_renew";
            this.btn_renew.UseVisualStyleBackColor = false;
            this.btn_renew.Click += new System.EventHandler(this.btn_renew_Click);
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
            // Frm_RenewLocalDrivingLicense
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_renew);
            this.Controls.Add(this.ll_showRenewedLicenseInfo);
            this.Controls.Add(this.ll_showLicenseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrl_LocalLicenseInfoCardWithFilter1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RenewLocalDrivingLicense";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_RenewLocalDrivingLicense_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter ctrl_LocalLicenseInfoCardWithFilter1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private Salem.Controls.SalSelectableLabel lbl_renewAppID;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel lbl_licenseFees;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalSelectableLabel lbl_applicationFees;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_issueDate;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_applicationDate;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_totalFees;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private System.Windows.Forms.Label label7;
        private Salem.Controls.SalSelectableLabel lbl_newExpirationDate;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_oldLicenseID;
        private System.Windows.Forms.Label label9;
        private Salem.Controls.SalSelectableLabel lbl_newLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel ll_showRenewedLicenseInfo;
        private System.Windows.Forms.LinkLabel ll_showLicenseHistory;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_renew;
        private System.Windows.Forms.Label label11;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_notes;
    }
}