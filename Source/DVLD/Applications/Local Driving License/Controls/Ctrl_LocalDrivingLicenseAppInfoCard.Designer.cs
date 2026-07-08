namespace DVLD.Applications.Local_Driving_License.Controls {
    partial class Ctrl_LocalDrivingLicenseAppInfoCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_LocalDrivingLicenseAppInfoCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ll_viewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lbl_numOfPassedTests = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_lDLAppID = new Salem.Controls.SalSelectableLabel();
            this.lbl_appliedForWhichLicense = new Salem.Controls.SalSelectableLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrl_ApplicationInfoCard1 = new DVLD.Applications.Controls.Ctrl_ApplicationInfoCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.ll_viewLicenseInfo);
            this.groupBox1.Controls.Add(this.lbl_numOfPassedTests);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_lDLAppID);
            this.groupBox1.Controls.Add(this.lbl_appliedForWhichLicense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ll_viewLicenseInfo
            // 
            resources.ApplyResources(this.ll_viewLicenseInfo, "ll_viewLicenseInfo");
            this.ll_viewLicenseInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_viewLicenseInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_viewLicenseInfo.Name = "ll_viewLicenseInfo";
            this.ll_viewLicenseInfo.TabStop = true;
            this.ll_viewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_viewLicenseInfo_LinkClicked);
            // 
            // lbl_numOfPassedTests
            // 
            this.lbl_numOfPassedTests.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_numOfPassedTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_numOfPassedTests, "lbl_numOfPassedTests");
            this.lbl_numOfPassedTests.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_numOfPassedTests.Name = "lbl_numOfPassedTests";
            this.lbl_numOfPassedTests.ReadOnly = true;
            this.lbl_numOfPassedTests.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.PassedTests_32;
            this.label2.Name = "label2";
            // 
            // lbl_lDLAppID
            // 
            this.lbl_lDLAppID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_lDLAppID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_lDLAppID, "lbl_lDLAppID");
            this.lbl_lDLAppID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_lDLAppID.Name = "lbl_lDLAppID";
            this.lbl_lDLAppID.ReadOnly = true;
            this.lbl_lDLAppID.TabStop = false;
            // 
            // lbl_appliedForWhichLicense
            // 
            this.lbl_appliedForWhichLicense.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_appliedForWhichLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_appliedForWhichLicense.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.lbl_appliedForWhichLicense, "lbl_appliedForWhichLicense");
            this.lbl_appliedForWhichLicense.Name = "lbl_appliedForWhichLicense";
            this.lbl_appliedForWhichLicense.ReadOnly = true;
            this.lbl_appliedForWhichLicense.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.Number_32;
            this.label3.Name = "label3";
            // 
            // ctrl_ApplicationInfoCard1
            // 
            this.ctrl_ApplicationInfoCard1.ApplicationID = -1;
            resources.ApplyResources(this.ctrl_ApplicationInfoCard1, "ctrl_ApplicationInfoCard1");
            this.ctrl_ApplicationInfoCard1.Name = "ctrl_ApplicationInfoCard1";
            this.ctrl_ApplicationInfoCard1.PersonSaved += new System.Action<int>(this.ctrl_ApplicationInfoCard1_PersonSaved);
            // 
            // Ctrl_LocalDrivingLicenseAppInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrl_ApplicationInfoCard1);
            this.Name = "Ctrl_LocalDrivingLicenseAppInfoCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Controls.Ctrl_ApplicationInfoCard ctrl_ApplicationInfoCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Salem.Controls.SalSelectableLabel lbl_lDLAppID;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_numOfPassedTests;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_appliedForWhichLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ll_viewLicenseInfo;
    }
}
