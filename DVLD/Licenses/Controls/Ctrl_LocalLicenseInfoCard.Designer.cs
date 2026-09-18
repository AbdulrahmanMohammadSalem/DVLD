namespace DVLD.Licenses.Controls {
    partial class Ctrl_LocalLicenseInfoCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_LocalLicenseInfoCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_showPersonInfo = new System.Windows.Forms.LinkLabel();
            this.pb_personImage = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stretchImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_expirationDate = new Salem.Controls.SalSelectableLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_driverID = new Salem.Controls.SalSelectableLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_dateOfBirth = new Salem.Controls.SalSelectableLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_isActive = new Salem.Controls.SalSelectableLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_notes = new Salem.Controls.SalSelectableLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_issueDate = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_gender = new Salem.Controls.SalSelectableLabel();
            this.lbl_genderLabel = new System.Windows.Forms.Label();
            this.lbl_nationalNum = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fullName = new Salem.Controls.SalSelectableLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_licenseClass = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_issueReason = new Salem.Controls.SalSelectableLabel();
            this.lbl_isDetained = new Salem.Controls.SalSelectableLabel();
            this.lbl_licenseID = new Salem.Controls.SalSelectableLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lbl_showPersonInfo);
            this.groupBox1.Controls.Add(this.pb_personImage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl_expirationDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_driverID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_dateOfBirth);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl_isActive);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbl_notes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_issueDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_gender);
            this.groupBox1.Controls.Add(this.lbl_genderLabel);
            this.groupBox1.Controls.Add(this.lbl_nationalNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_fullName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_licenseClass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_issueReason);
            this.groupBox1.Controls.Add(this.lbl_isDetained);
            this.groupBox1.Controls.Add(this.lbl_licenseID);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbl_showPersonInfo
            // 
            resources.ApplyResources(this.lbl_showPersonInfo, "lbl_showPersonInfo");
            this.lbl_showPersonInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_showPersonInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.lbl_showPersonInfo.Name = "lbl_showPersonInfo";
            this.lbl_showPersonInfo.TabStop = true;
            this.lbl_showPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_showPersonInfo_LinkClicked);
            // 
            // pb_personImage
            // 
            this.pb_personImage.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.pb_personImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_personImage.ContextMenuStrip = this.contextMenuStrip1;
            this.pb_personImage.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pb_personImage.Image = global::DVLD.Properties.Resources.Male_512;
            resources.ApplyResources(this.pb_personImage, "pb_personImage");
            this.pb_personImage.Name = "pb_personImage";
            this.pb_personImage.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stretchImageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // stretchImageToolStripMenuItem
            // 
            this.stretchImageToolStripMenuItem.CheckOnClick = true;
            resources.ApplyResources(this.stretchImageToolStripMenuItem, "stretchImageToolStripMenuItem");
            this.stretchImageToolStripMenuItem.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            this.stretchImageToolStripMenuItem.CheckedChanged += new System.EventHandler(this.stretchImageToolStripMenuItem_CheckedChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
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
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // lbl_driverID
            // 
            this.lbl_driverID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_driverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_driverID, "lbl_driverID");
            this.lbl_driverID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_driverID.Name = "lbl_driverID";
            this.lbl_driverID.ReadOnly = true;
            this.lbl_driverID.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Image = global::DVLD.Properties.Resources.Number_32;
            this.label11.Name = "label11";
            // 
            // lbl_dateOfBirth
            // 
            this.lbl_dateOfBirth.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_dateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_dateOfBirth, "lbl_dateOfBirth");
            this.lbl_dateOfBirth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_dateOfBirth.Name = "lbl_dateOfBirth";
            this.lbl_dateOfBirth.ReadOnly = true;
            this.lbl_dateOfBirth.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // lbl_isActive
            // 
            this.lbl_isActive.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_isActive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_isActive, "lbl_isActive");
            this.lbl_isActive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_isActive.Name = "lbl_isActive";
            this.lbl_isActive.ReadOnly = true;
            this.lbl_isActive.TabStop = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // lbl_notes
            // 
            this.lbl_notes.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_notes, "lbl_notes");
            this.lbl_notes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.ReadOnly = true;
            this.lbl_notes.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.Notes_32;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.Notes_32;
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
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label6.Name = "label6";
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_gender, "lbl_gender");
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.ReadOnly = true;
            this.lbl_gender.TabStop = false;
            // 
            // lbl_genderLabel
            // 
            resources.ApplyResources(this.lbl_genderLabel, "lbl_genderLabel");
            this.lbl_genderLabel.Image = global::DVLD.Properties.Resources.Man_32;
            this.lbl_genderLabel.Name = "lbl_genderLabel";
            // 
            // lbl_nationalNum
            // 
            this.lbl_nationalNum.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_nationalNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_nationalNum, "lbl_nationalNum");
            this.lbl_nationalNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_nationalNum.Name = "lbl_nationalNum";
            this.lbl_nationalNum.ReadOnly = true;
            this.lbl_nationalNum.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.Number_32;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Number_32;
            this.label2.Name = "label2";
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_fullName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "StrongForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.lbl_fullName, "lbl_fullName");
            this.lbl_fullName.ForeColor = global::DVLD.Properties.Settings.Default.StrongForeColor;
            this.lbl_fullName.MatchParentForeColor = false;
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.ReadOnly = true;
            this.lbl_fullName.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Person_32;
            this.label1.Name = "label1";
            // 
            // lbl_licenseClass
            // 
            this.lbl_licenseClass.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_licenseClass, "lbl_licenseClass");
            this.lbl_licenseClass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseClass.Name = "lbl_licenseClass";
            this.lbl_licenseClass.ReadOnly = true;
            this.lbl_licenseClass.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.label5.Name = "label5";
            // 
            // lbl_issueReason
            // 
            this.lbl_issueReason.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_issueReason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_issueReason, "lbl_issueReason");
            this.lbl_issueReason.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_issueReason.Name = "lbl_issueReason";
            this.lbl_issueReason.ReadOnly = true;
            this.lbl_issueReason.TabStop = false;
            // 
            // lbl_isDetained
            // 
            this.lbl_isDetained.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_isDetained.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_isDetained, "lbl_isDetained");
            this.lbl_isDetained.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_isDetained.Name = "lbl_isDetained";
            this.lbl_isDetained.ReadOnly = true;
            this.lbl_isDetained.TabStop = false;
            // 
            // lbl_licenseID
            // 
            this.lbl_licenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_licenseID, "lbl_licenseID");
            this.lbl_licenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseID.Name = "lbl_licenseID";
            this.lbl_licenseID.ReadOnly = true;
            this.lbl_licenseID.TabStop = false;
            // 
            // Ctrl_LocalLicenseInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_LocalLicenseInfoCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_personImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Salem.Controls.SalSelectableLabel lbl_issueDate;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel lbl_gender;
        private System.Windows.Forms.Label lbl_genderLabel;
        private Salem.Controls.SalSelectableLabel lbl_nationalNum;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_licenseID;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_fullName;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel lbl_licenseClass;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalSelectableLabel lbl_isDetained;
        private System.Windows.Forms.Label label9;
        private Salem.Controls.SalSelectableLabel lbl_expirationDate;
        private System.Windows.Forms.Label label10;
        private Salem.Controls.SalSelectableLabel lbl_driverID;
        private System.Windows.Forms.Label label11;
        private Salem.Controls.SalSelectableLabel lbl_dateOfBirth;
        private System.Windows.Forms.Label label12;
        private Salem.Controls.SalSelectableLabel lbl_isActive;
        private System.Windows.Forms.Label label13;
        private Salem.Controls.SalSelectableLabel lbl_notes;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_issueReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lbl_showPersonInfo;
        private System.Windows.Forms.PictureBox pb_personImage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
    }
}
