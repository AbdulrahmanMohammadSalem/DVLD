namespace DVLD.People {
    partial class Ctrl_PersonInfoCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_PersonInfoCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel_editPersonInfo = new System.Windows.Forms.LinkLabel();
            this.label_personID = new Salem.Controls.SalSelectableLabel();
            this.label_fullName = new Salem.Controls.SalSelectableLabel();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stretchImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_dateOfBirth = new Salem.Controls.SalSelectableLabel();
            this.label_phone = new Salem.Controls.SalSelectableLabel();
            this.label_nationality = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_address = new Salem.Controls.SalSelectableLabel();
            this.label_email = new Salem.Controls.SalSelectableLabel();
            this.label_gender = new Salem.Controls.SalSelectableLabel();
            this.label_nationalNum = new Salem.Controls.SalSelectableLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.linkLabel_editPersonInfo);
            this.groupBox1.Controls.Add(this.label_personID);
            this.groupBox1.Controls.Add(this.label_fullName);
            this.groupBox1.Controls.Add(this.pictureBox_image);
            this.groupBox1.Controls.Add(this.label_dateOfBirth);
            this.groupBox1.Controls.Add(this.label_phone);
            this.groupBox1.Controls.Add(this.label_nationality);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_address);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.label_gender);
            this.groupBox1.Controls.Add(this.label_nationalNum);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // linkLabel_editPersonInfo
            // 
            resources.ApplyResources(this.linkLabel_editPersonInfo, "linkLabel_editPersonInfo");
            this.linkLabel_editPersonInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linkLabel_editPersonInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.linkLabel_editPersonInfo.Name = "linkLabel_editPersonInfo";
            this.linkLabel_editPersonInfo.TabStop = true;
            this.linkLabel_editPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_editPersonInfo_LinkClicked);
            // 
            // label_personID
            // 
            this.label_personID.BackColor = System.Drawing.SystemColors.Control;
            this.label_personID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_personID, "label_personID");
            this.label_personID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_personID.Name = "label_personID";
            this.label_personID.ReadOnly = true;
            this.label_personID.TabStop = false;
            // 
            // label_fullName
            // 
            this.label_fullName.BackColor = System.Drawing.SystemColors.Control;
            this.label_fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_fullName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "StrongForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label_fullName, "label_fullName");
            this.label_fullName.ForeColor = global::DVLD.Properties.Settings.Default.StrongForeColor;
            this.label_fullName.MatchParentForeColor = false;
            this.label_fullName.Name = "label_fullName";
            this.label_fullName.ReadOnly = true;
            this.label_fullName.TabStop = false;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_image.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox_image.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox_image.Image = global::DVLD.Properties.Resources.Male_512;
            resources.ApplyResources(this.pictureBox_image, "pictureBox_image");
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
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
            this.stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
            this.stretchImageToolStripMenuItem.CheckedChanged += new System.EventHandler(this.stretchImageToolStripMenuItem_CheckedChanged);
            // 
            // label_dateOfBirth
            // 
            this.label_dateOfBirth.BackColor = System.Drawing.SystemColors.Control;
            this.label_dateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_dateOfBirth, "label_dateOfBirth");
            this.label_dateOfBirth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_dateOfBirth.Name = "label_dateOfBirth";
            this.label_dateOfBirth.ReadOnly = true;
            this.label_dateOfBirth.TabStop = false;
            // 
            // label_phone
            // 
            this.label_phone.BackColor = System.Drawing.SystemColors.Control;
            this.label_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_phone, "label_phone");
            this.label_phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_phone.Name = "label_phone";
            this.label_phone.ReadOnly = true;
            this.label_phone.TabStop = false;
            // 
            // label_nationality
            // 
            this.label_nationality.BackColor = System.Drawing.SystemColors.Control;
            this.label_nationality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_nationality, "label_nationality");
            this.label_nationality.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_nationality.Name = "label_nationality";
            this.label_nationality.ReadOnly = true;
            this.label_nationality.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.Number_32;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Person_32;
            this.label4.Name = "label4";
            // 
            // label_address
            // 
            this.label_address.BackColor = System.Drawing.SystemColors.Control;
            this.label_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_address, "label_address");
            this.label_address.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_address.Name = "label_address";
            this.label_address.ReadOnly = true;
            this.label_address.TabStop = false;
            // 
            // label_email
            // 
            this.label_email.BackColor = System.Drawing.SystemColors.Control;
            this.label_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_email, "label_email");
            this.label_email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_email.Name = "label_email";
            this.label_email.ReadOnly = true;
            this.label_email.TabStop = false;
            // 
            // label_gender
            // 
            this.label_gender.BackColor = System.Drawing.SystemColors.Control;
            this.label_gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_gender, "label_gender");
            this.label_gender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_gender.Name = "label_gender";
            this.label_gender.ReadOnly = true;
            this.label_gender.TabStop = false;
            // 
            // label_nationalNum
            // 
            this.label_nationalNum.BackColor = System.Drawing.SystemColors.Control;
            this.label_nationalNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.label_nationalNum, "label_nationalNum");
            this.label_nationalNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_nationalNum.Name = "label_nationalNum";
            this.label_nationalNum.ReadOnly = true;
            this.label_nationalNum.TabStop = false;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Image = global::DVLD.Properties.Resources.Address_32;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Image = global::DVLD.Properties.Resources.Country_32;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Image = global::DVLD.Properties.Resources.Email_32;
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Image = global::DVLD.Properties.Resources.Phone_32;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.Man_32;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.Number_32;
            this.label6.Name = "label6";
            // 
            // Ctrl_PersonInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_PersonInfoCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Salem.Controls.SalSelectableLabel label_address;
        private Salem.Controls.SalSelectableLabel label_email;
        private Salem.Controls.SalSelectableLabel label_gender;
        private Salem.Controls.SalSelectableLabel label_nationalNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalSelectableLabel label_dateOfBirth;
        private Salem.Controls.SalSelectableLabel label_phone;
        private Salem.Controls.SalSelectableLabel label_nationality;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private Salem.Controls.SalSelectableLabel label_fullName;
        private Salem.Controls.SalSelectableLabel label_personID;
        private System.Windows.Forms.LinkLabel linkLabel_editPersonInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
    }
}
