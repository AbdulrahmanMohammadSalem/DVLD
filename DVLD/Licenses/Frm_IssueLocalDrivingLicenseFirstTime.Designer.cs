namespace DVLD.Licenses {
    partial class Frm_IssueLocalDrivingLicenseFirstTime {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IssueLocalDrivingLicenseFirstTime));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_lDLID = new Salem.Controls.SalSelectableLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_licenseReleaseDate = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_licenseClassFees = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_notes = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_issue = new System.Windows.Forms.Button();
            this.ctrl_LocalDrivingLicenseAppInfoCard1 = new DVLD.Applications.Local_Driving_License.Controls.Ctrl_LocalDrivingLicenseAppInfoCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBx_notes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Issue_Driving_License_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbl_lDLID
            // 
            this.lbl_lDLID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_lDLID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_lDLID, "lbl_lDLID");
            this.lbl_lDLID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_lDLID.Name = "lbl_lDLID";
            this.lbl_lDLID.ReadOnly = true;
            this.lbl_lDLID.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Number_32;
            this.label4.Name = "label4";
            // 
            // lbl_licenseReleaseDate
            // 
            this.lbl_licenseReleaseDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_licenseReleaseDate, "lbl_licenseReleaseDate");
            this.lbl_licenseReleaseDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseReleaseDate.Name = "lbl_licenseReleaseDate";
            this.lbl_licenseReleaseDate.ReadOnly = true;
            this.lbl_licenseReleaseDate.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label2.Name = "label2";
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label3.Name = "label3";
            // 
            // lbl_licenseClassFees
            // 
            this.lbl_licenseClassFees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseClassFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_licenseClassFees, "lbl_licenseClassFees");
            this.lbl_licenseClassFees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_licenseClassFees.Name = "lbl_licenseClassFees";
            this.lbl_licenseClassFees.ReadOnly = true;
            this.lbl_licenseClassFees.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.money_32;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.Notes_32;
            this.label6.Name = "label6";
            // 
            // txtBx_notes
            // 
            resources.ApplyResources(this.txtBx_notes, "txtBx_notes");
            this.txtBx_notes.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txtBx_notes.BeforeTouchSize = new System.Drawing.Size(389, 30);
            this.txtBx_notes.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txtBx_notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx_notes.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBx_notes.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBx_notes.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBx_notes.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.txtBx_notes.Name = "txtBx_notes";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_issue
            // 
            this.btn_issue.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_issue.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_issue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            resources.ApplyResources(this.btn_issue, "btn_issue");
            this.btn_issue.Image = global::DVLD.Properties.Resources.Local_32;
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.UseVisualStyleBackColor = false;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // ctrl_LocalDrivingLicenseAppInfoCard1
            // 
            resources.ApplyResources(this.ctrl_LocalDrivingLicenseAppInfoCard1, "ctrl_LocalDrivingLicenseAppInfoCard1");
            this.ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID = -1;
            this.ctrl_LocalDrivingLicenseAppInfoCard1.Name = "ctrl_LocalDrivingLicenseAppInfoCard1";
            this.ctrl_LocalDrivingLicenseAppInfoCard1.PersonSaved += new System.Action<int>(this.ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved);
            // 
            // Frm_IssueLocalDrivingLicenseFirstTime
            // 
            this.AcceptButton = this.btn_issue;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.btn_close;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_issue);
            this.Controls.Add(this.txtBx_notes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_licenseClassFees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_createdBy);
            this.Controls.Add(this.lbl_licenseReleaseDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_lDLID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrl_LocalDrivingLicenseAppInfoCard1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_IssueLocalDrivingLicenseFirstTime";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_IssueDrivingLicenseFirstTime_Activated);
            this.Load += new System.EventHandler(this.Frm_IssueDrivingLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBx_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Applications.Local_Driving_License.Controls.Ctrl_LocalDrivingLicenseAppInfoCard ctrl_LocalDrivingLicenseAppInfoCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Salem.Controls.SalSelectableLabel lbl_lDLID;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_licenseReleaseDate;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_licenseClassFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBx_notes;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_issue;
    }
}