namespace DVLD.Licenses.Controls {
    partial class Ctrl_InternationalLicenseInfoCard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_InternationalLicenseInfoCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_personImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_issueDate = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_interLicenseID = new Salem.Controls.SalSelectableLabel();
            this.ttl_gender = new System.Windows.Forms.Label();
            this.lbl_gender = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nationalNum = new Salem.Controls.SalSelectableLabel();
            this.lbl_fullName = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_localLicenseID = new Salem.Controls.SalSelectableLabel();
            this.ttl_localLicenseID = new System.Windows.Forms.Label();
            this.ll_showPersonInfo = new System.Windows.Forms.LinkLabel();
            this.lbl_applicationID = new Salem.Controls.SalSelectableLabel();
            this.lbl_isActive = new Salem.Controls.SalSelectableLabel();
            this.lbl_dateOfBirth = new Salem.Controls.SalSelectableLabel();
            this.lbl_driverID = new Salem.Controls.SalSelectableLabel();
            this.lbl_expirationDate = new Salem.Controls.SalSelectableLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pb_personImage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_issueDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_interLicenseID);
            this.groupBox1.Controls.Add(this.ttl_gender);
            this.groupBox1.Controls.Add(this.lbl_gender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_nationalNum);
            this.groupBox1.Controls.Add(this.lbl_fullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_localLicenseID);
            this.groupBox1.Controls.Add(this.ttl_localLicenseID);
            this.groupBox1.Controls.Add(this.ll_showPersonInfo);
            this.groupBox1.Controls.Add(this.lbl_applicationID);
            this.groupBox1.Controls.Add(this.lbl_isActive);
            this.groupBox1.Controls.Add(this.lbl_dateOfBirth);
            this.groupBox1.Controls.Add(this.lbl_driverID);
            this.groupBox1.Controls.Add(this.lbl_expirationDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // pb_personImage
            // 
            resources.ApplyResources(this.pb_personImage, "pb_personImage");
            this.pb_personImage.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.pb_personImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_personImage.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pb_personImage.ForeColor = System.Drawing.Color.Red;
            this.pb_personImage.Image = global::DVLD.Properties.Resources.Male_512;
            this.pb_personImage.Name = "pb_personImage";
            this.pb_personImage.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_personImage, resources.GetString("pb_personImage.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.International_64_2_31x31;
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.Number_32;
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // lbl_issueDate
            // 
            resources.ApplyResources(this.lbl_issueDate, "lbl_issueDate");
            this.lbl_issueDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_issueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_issueDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_issueDate.Name = "lbl_issueDate";
            this.lbl_issueDate.ReadOnly = true;
            this.lbl_issueDate.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_issueDate, resources.GetString("lbl_issueDate.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.International_64_2_31x31;
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // lbl_interLicenseID
            // 
            resources.ApplyResources(this.lbl_interLicenseID, "lbl_interLicenseID");
            this.lbl_interLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_interLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_interLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_interLicenseID.Name = "lbl_interLicenseID";
            this.lbl_interLicenseID.ReadOnly = true;
            this.lbl_interLicenseID.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_interLicenseID, resources.GetString("lbl_interLicenseID.ToolTip"));
            // 
            // ttl_gender
            // 
            resources.ApplyResources(this.ttl_gender, "ttl_gender");
            this.ttl_gender.Image = global::DVLD.Properties.Resources.Man_32;
            this.ttl_gender.Name = "ttl_gender";
            this.toolTip1.SetToolTip(this.ttl_gender, resources.GetString("ttl_gender.ToolTip"));
            // 
            // lbl_gender
            // 
            resources.ApplyResources(this.lbl_gender, "lbl_gender");
            this.lbl_gender.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.ReadOnly = true;
            this.lbl_gender.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_gender, resources.GetString("lbl_gender.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.Number_32;
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // lbl_nationalNum
            // 
            resources.ApplyResources(this.lbl_nationalNum, "lbl_nationalNum");
            this.lbl_nationalNum.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_nationalNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_nationalNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_nationalNum.Name = "lbl_nationalNum";
            this.lbl_nationalNum.ReadOnly = true;
            this.lbl_nationalNum.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_nationalNum, resources.GetString("lbl_nationalNum.ToolTip"));
            // 
            // lbl_fullName
            // 
            resources.ApplyResources(this.lbl_fullName, "lbl_fullName");
            this.lbl_fullName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_fullName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "StrongForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_fullName.ForeColor = global::DVLD.Properties.Settings.Default.StrongForeColor;
            this.lbl_fullName.MatchParentForeColor = false;
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.ReadOnly = true;
            this.lbl_fullName.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_fullName, resources.GetString("lbl_fullName.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Question_32;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // lbl_localLicenseID
            // 
            resources.ApplyResources(this.lbl_localLicenseID, "lbl_localLicenseID");
            this.lbl_localLicenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_localLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_localLicenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_localLicenseID.Name = "lbl_localLicenseID";
            this.lbl_localLicenseID.ReadOnly = true;
            this.lbl_localLicenseID.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_localLicenseID, resources.GetString("lbl_localLicenseID.ToolTip"));
            // 
            // ttl_localLicenseID
            // 
            resources.ApplyResources(this.ttl_localLicenseID, "ttl_localLicenseID");
            this.ttl_localLicenseID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ttl_localLicenseID.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ttl_localLicenseID.ForeColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ttl_localLicenseID.Image = global::DVLD.Properties.Resources.Number_32;
            this.ttl_localLicenseID.Name = "ttl_localLicenseID";
            this.ttl_localLicenseID.TabStop = true;
            this.toolTip1.SetToolTip(this.ttl_localLicenseID, resources.GetString("ttl_localLicenseID.ToolTip"));
            this.ttl_localLicenseID.UseCompatibleTextRendering = true;
            this.ttl_localLicenseID.Click += new System.EventHandler(this.ttl_localLicenseID_Click);
            this.ttl_localLicenseID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ttl_localLicenseID_MouseDown);
            this.ttl_localLicenseID.MouseEnter += new System.EventHandler(this.ttl_localLicenseID_MouseEnter);
            this.ttl_localLicenseID.MouseLeave += new System.EventHandler(this.ttl_localLicenseID_MouseLeave);
            this.ttl_localLicenseID.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ttl_localLicenseID_MouseUp);
            // 
            // ll_showPersonInfo
            // 
            resources.ApplyResources(this.ll_showPersonInfo, "ll_showPersonInfo");
            this.ll_showPersonInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_showPersonInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showPersonInfo.Name = "ll_showPersonInfo";
            this.ll_showPersonInfo.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_showPersonInfo, resources.GetString("ll_showPersonInfo.ToolTip"));
            this.ll_showPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showPersonInfo_LinkClicked);
            // 
            // lbl_applicationID
            // 
            resources.ApplyResources(this.lbl_applicationID, "lbl_applicationID");
            this.lbl_applicationID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_applicationID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationID.Name = "lbl_applicationID";
            this.lbl_applicationID.ReadOnly = true;
            this.lbl_applicationID.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_applicationID, resources.GetString("lbl_applicationID.ToolTip"));
            // 
            // lbl_isActive
            // 
            resources.ApplyResources(this.lbl_isActive, "lbl_isActive");
            this.lbl_isActive.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_isActive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_isActive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_isActive.Name = "lbl_isActive";
            this.lbl_isActive.ReadOnly = true;
            this.lbl_isActive.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_isActive, resources.GetString("lbl_isActive.ToolTip"));
            // 
            // lbl_dateOfBirth
            // 
            resources.ApplyResources(this.lbl_dateOfBirth, "lbl_dateOfBirth");
            this.lbl_dateOfBirth.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_dateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_dateOfBirth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            this.lbl_dateOfBirth.ReadOnly = true;
            this.lbl_dateOfBirth.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_dateOfBirth, resources.GetString("lbl_dateOfBirth.ToolTip"));
            // 
            // lbl_driverID
            // 
            resources.ApplyResources(this.lbl_driverID, "lbl_driverID");
            this.lbl_driverID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_driverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_driverID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_driverID.Name = "lbl_driverID";
            this.lbl_driverID.ReadOnly = true;
            this.lbl_driverID.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_driverID, resources.GetString("lbl_driverID.ToolTip"));
            // 
            // lbl_expirationDate
            // 
            resources.ApplyResources(this.lbl_expirationDate, "lbl_expirationDate");
            this.lbl_expirationDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_expirationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_expirationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_expirationDate.Name = "lbl_expirationDate";
            this.lbl_expirationDate.ReadOnly = true;
            this.lbl_expirationDate.TabStop = false;
            this.toolTip1.SetToolTip(this.lbl_expirationDate, resources.GetString("lbl_expirationDate.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Person_32;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Ctrl_InternationalLicenseInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_InternationalLicenseInfoCard";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_localLicenseID;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel lbl_expirationDate;
        private System.Windows.Forms.Label label7;
        private Salem.Controls.SalSelectableLabel lbl_applicationID;
        private System.Windows.Forms.Label label9;
        private Salem.Controls.SalSelectableLabel lbl_driverID;
        private System.Windows.Forms.Label label10;
        private Salem.Controls.SalSelectableLabel lbl_dateOfBirth;
        private System.Windows.Forms.Label ttl_localLicenseID;
        private Salem.Controls.SalSelectableLabel lbl_isActive;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_issueDate;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalSelectableLabel lbl_interLicenseID;
        private System.Windows.Forms.Label ttl_gender;
        private Salem.Controls.SalSelectableLabel lbl_gender;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_nationalNum;
        private Salem.Controls.SalSelectableLabel lbl_fullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ll_showPersonInfo;
        private System.Windows.Forms.PictureBox pb_personImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
