namespace DVLD.Applications.International_Driving_License {
    partial class Frm_IssueNewInternationalLicense {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IssueNewInternationalLicense));
            this.label_title = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.ll_showLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.ll_showInterLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ctrl_LocalLicenseInfoCardWithFilter1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.lbl_expirationDate = new Salem.Controls.SalSelectableLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_issueDate = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_applicationDate = new Salem.Controls.SalSelectableLabel();
            this.lbl_fees = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_localLicenseID = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_interLicenseAppID = new Salem.Controls.SalSelectableLabel();
            this.lbl_interLicenseID = new Salem.Controls.SalSelectableLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
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
            // button_issue
            // 
            resources.ApplyResources(this.btn_issue, "button_issue");
            this.btn_issue.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_issue.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_issue.FlatAppearance.BorderSize = 2;
            this.btn_issue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_issue.Image = global::DVLD.Properties.Resources.International_32;
            this.btn_issue.Name = "button_issue";
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.button_issue_Click);
            // 
            // ll_showLicenseHistory
            // 
            resources.ApplyResources(this.ll_showLicensesHistory, "ll_showLicenseHistory");
            this.ll_showLicensesHistory.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showLicensesHistory.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showLicensesHistory.Name = "ll_showLicenseHistory";
            this.ll_showLicensesHistory.TabStop = true;
            this.ll_showLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showLicenseHistory_LinkClicked);
            // 
            // ll_showInterLicenseInfo
            // 
            resources.ApplyResources(this.ll_showInterLicenseInfo, "ll_showInterLicenseInfo");
            this.ll_showInterLicenseInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showInterLicenseInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showInterLicenseInfo.Name = "ll_showInterLicenseInfo";
            this.ll_showInterLicenseInfo.TabStop = true;
            this.ll_showInterLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showInterLicenseInfo_LinkClicked);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_createdBy);
            this.groupBox1.Controls.Add(this.lbl_expirationDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_issueDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_applicationDate);
            this.groupBox1.Controls.Add(this.lbl_fees);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_localLicenseID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_interLicenseAppID);
            this.groupBox1.Controls.Add(this.lbl_interLicenseID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // lbl_expirationDate
            // 
            this.lbl_expirationDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_expirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_expirationDate, "lbl_expirationDate");
            this.lbl_expirationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_expirationDate.Name = "lbl_expirationDate";
            this.lbl_expirationDate.ReadOnly = true;
            this.lbl_expirationDate.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label7.Name = "label7";
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label5.Name = "label5";
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
            // lbl_fees
            // 
            this.lbl_fees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_fees, "lbl_fees");
            this.lbl_fees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.ReadOnly = true;
            this.lbl_fees.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.money_32;
            this.label3.Name = "label3";
            // 
            // lbl_localLicenseID
            // 
            this.lbl_localLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_localLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_localLicenseID, "lbl_localLicenseID");
            this.lbl_localLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_localLicenseID.Name = "lbl_localLicenseID";
            this.lbl_localLicenseID.ReadOnly = true;
            this.lbl_localLicenseID.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Number_32;
            this.label2.Name = "label2";
            // 
            // lbl_interLicenseAppID
            // 
            this.lbl_interLicenseAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_interLicenseAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_interLicenseAppID, "lbl_interLicenseAppID");
            this.lbl_interLicenseAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_interLicenseAppID.Name = "lbl_interLicenseAppID";
            this.lbl_interLicenseAppID.ReadOnly = true;
            this.lbl_interLicenseAppID.TabStop = false;
            // 
            // lbl_interLicenseID
            // 
            this.lbl_interLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_interLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_interLicenseID, "lbl_interLicenseID");
            this.lbl_interLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_interLicenseID.Name = "lbl_interLicenseID";
            this.lbl_interLicenseID.ReadOnly = true;
            this.lbl_interLicenseID.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label4.Name = "label4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label8.Name = "label8";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.Name = "label1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.International_64_2_31x31;
            this.label6.Name = "label6";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_IssueNewInternationalLicense
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ll_showInterLicenseInfo);
            this.Controls.Add(this.ll_showLicensesHistory);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_issue);
            this.Controls.Add(this.ctrl_LocalLicenseInfoCardWithFilter1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_IssueNewInternationalLicense";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_IssueNewInternationalLicense_Activated);
            this.Load += new System.EventHandler(this.Frm_IssueNewInternationalLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter ctrl_LocalLicenseInfoCardWithFilter1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.LinkLabel ll_showLicensesHistory;
        private System.Windows.Forms.LinkLabel ll_showInterLicenseInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private Salem.Controls.SalSelectableLabel lbl_expirationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel lbl_issueDate;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalSelectableLabel lbl_applicationDate;
        private Salem.Controls.SalSelectableLabel lbl_fees;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_localLicenseID;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_interLicenseAppID;
        private Salem.Controls.SalSelectableLabel lbl_interLicenseID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}