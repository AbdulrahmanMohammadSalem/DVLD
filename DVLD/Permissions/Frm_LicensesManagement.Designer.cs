namespace DVLD.Permissions {
    partial class Frm_LicensesManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LicensesManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_exportLocalLicensesData = new System.Windows.Forms.CheckBox();
            this.chk_showFullLocalLicenseInfo = new System.Windows.Forms.CheckBox();
            this.chk_renewLicense = new System.Windows.Forms.CheckBox();
            this.chk_issueLicenseReplacement = new System.Windows.Forms.CheckBox();
            this.chk_issueLocalLicenseFirstTime = new System.Windows.Forms.CheckBox();
            this.chk_viewAllLocalLicenses = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_exportInterLicensesData = new System.Windows.Forms.CheckBox();
            this.chk_showFullInterLicenseInfo = new System.Windows.Forms.CheckBox();
            this.chk_viewAllInterLicenses = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_exportLocalLicensesData);
            this.groupBox1.Controls.Add(this.chk_showFullLocalLicenseInfo);
            this.groupBox1.Controls.Add(this.chk_renewLicense);
            this.groupBox1.Controls.Add(this.chk_issueLicenseReplacement);
            this.groupBox1.Controls.Add(this.chk_issueLocalLicenseFirstTime);
            this.groupBox1.Controls.Add(this.chk_viewAllLocalLicenses);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_exportLocalLicensesData
            // 
            resources.ApplyResources(this.chk_exportLocalLicensesData, "chk_exportLocalLicensesData");
            this.chk_exportLocalLicensesData.Name = "chk_exportLocalLicensesData";
            this.chk_exportLocalLicensesData.UseVisualStyleBackColor = true;
            this.chk_exportLocalLicensesData.CheckedChanged += new System.EventHandler(this.chk_exportLocalLicenseData_CheckedChanged);
            // 
            // chk_showFullLocalLicenseInfo
            // 
            resources.ApplyResources(this.chk_showFullLocalLicenseInfo, "chk_showFullLocalLicenseInfo");
            this.chk_showFullLocalLicenseInfo.Name = "chk_showFullLocalLicenseInfo";
            this.chk_showFullLocalLicenseInfo.UseVisualStyleBackColor = true;
            this.chk_showFullLocalLicenseInfo.CheckedChanged += new System.EventHandler(this.chk_showFullLocalLicenseInfo_CheckedChanged);
            // 
            // chk_renewLicense
            // 
            resources.ApplyResources(this.chk_renewLicense, "chk_renewLicense");
            this.chk_renewLicense.Name = "chk_renewLicense";
            this.chk_renewLicense.UseVisualStyleBackColor = true;
            this.chk_renewLicense.CheckedChanged += new System.EventHandler(this.chk_renewLicense_CheckedChanged);
            // 
            // chk_issueLicenseReplacement
            // 
            resources.ApplyResources(this.chk_issueLicenseReplacement, "chk_issueLicenseReplacement");
            this.chk_issueLicenseReplacement.Name = "chk_issueLicenseReplacement";
            this.chk_issueLicenseReplacement.UseVisualStyleBackColor = true;
            this.chk_issueLicenseReplacement.CheckedChanged += new System.EventHandler(this.chk_issueLicenseReplacement_CheckedChanged);
            // 
            // chk_issueLocalLicenseFirstTime
            // 
            resources.ApplyResources(this.chk_issueLocalLicenseFirstTime, "chk_issueLocalLicenseFirstTime");
            this.chk_issueLocalLicenseFirstTime.Name = "chk_issueLocalLicenseFirstTime";
            this.chk_issueLocalLicenseFirstTime.UseVisualStyleBackColor = true;
            this.chk_issueLocalLicenseFirstTime.CheckedChanged += new System.EventHandler(this.chk_issueLocalLicenseFirstTime_CheckedChanged);
            // 
            // chk_viewAllLocalLicenses
            // 
            resources.ApplyResources(this.chk_viewAllLocalLicenses, "chk_viewAllLocalLicenses");
            this.chk_viewAllLocalLicenses.Name = "chk_viewAllLocalLicenses";
            this.chk_viewAllLocalLicenses.UseVisualStyleBackColor = true;
            this.chk_viewAllLocalLicenses.CheckedChanged += new System.EventHandler(this.chk_viewAllLocalLicenses_CheckedChanged);
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.chk_exportInterLicensesData);
            this.groupBox2.Controls.Add(this.chk_showFullInterLicenseInfo);
            this.groupBox2.Controls.Add(this.chk_viewAllInterLicenses);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chk_exportInterLicensesData
            // 
            resources.ApplyResources(this.chk_exportInterLicensesData, "chk_exportInterLicensesData");
            this.chk_exportInterLicensesData.Name = "chk_exportInterLicensesData";
            this.chk_exportInterLicensesData.UseVisualStyleBackColor = true;
            this.chk_exportInterLicensesData.CheckedChanged += new System.EventHandler(this.chk_exportInterLicensesData_CheckedChanged);
            // 
            // chk_showFullInterLicenseInfo
            // 
            resources.ApplyResources(this.chk_showFullInterLicenseInfo, "chk_showFullInterLicenseInfo");
            this.chk_showFullInterLicenseInfo.Name = "chk_showFullInterLicenseInfo";
            this.chk_showFullInterLicenseInfo.UseVisualStyleBackColor = true;
            this.chk_showFullInterLicenseInfo.CheckedChanged += new System.EventHandler(this.chk_showFullInterLicenseInfo_CheckedChanged);
            // 
            // chk_viewAllInterLicenses
            // 
            resources.ApplyResources(this.chk_viewAllInterLicenses, "chk_viewAllInterLicenses");
            this.chk_viewAllInterLicenses.Name = "chk_viewAllInterLicenses";
            this.chk_viewAllInterLicenses.UseVisualStyleBackColor = true;
            this.chk_viewAllInterLicenses.CheckedChanged += new System.EventHandler(this.chk_viewAllInterLicenses_CheckedChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox4.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // Frm_LicensesManagement
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_ok);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LicensesManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_viewAllLocalLicenses;
        private System.Windows.Forms.CheckBox chk_exportLocalLicensesData;
        private System.Windows.Forms.CheckBox chk_showFullLocalLicenseInfo;
        private System.Windows.Forms.CheckBox chk_renewLicense;
        private System.Windows.Forms.CheckBox chk_issueLicenseReplacement;
        private System.Windows.Forms.CheckBox chk_issueLocalLicenseFirstTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_exportInterLicensesData;
        private System.Windows.Forms.CheckBox chk_showFullInterLicenseInfo;
        private System.Windows.Forms.CheckBox chk_viewAllInterLicenses;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}