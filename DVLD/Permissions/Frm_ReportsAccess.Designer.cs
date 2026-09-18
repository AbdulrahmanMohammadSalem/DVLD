namespace DVLD.Permissions {
    partial class Frm_ReportsAccess {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportsAccess));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_userActivityReport = new System.Windows.Forms.CheckBox();
            this.chk_licenseDetentionReport = new System.Windows.Forms.CheckBox();
            this.chk_testAttemptsReport = new System.Windows.Forms.CheckBox();
            this.chk_driverProfileReport = new System.Windows.Forms.CheckBox();
            this.chk_localLicenseAppDetailsReport = new System.Windows.Forms.CheckBox();
            this.chk_PersonHistoryReport = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_userActivityReport);
            this.groupBox1.Controls.Add(this.chk_licenseDetentionReport);
            this.groupBox1.Controls.Add(this.chk_testAttemptsReport);
            this.groupBox1.Controls.Add(this.chk_driverProfileReport);
            this.groupBox1.Controls.Add(this.chk_localLicenseAppDetailsReport);
            this.groupBox1.Controls.Add(this.chk_PersonHistoryReport);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_userActivityReport
            // 
            resources.ApplyResources(this.chk_userActivityReport, "chk_userActivityReport");
            this.chk_userActivityReport.Name = "chk_userActivityReport";
            this.chk_userActivityReport.UseVisualStyleBackColor = true;
            this.chk_userActivityReport.CheckedChanged += new System.EventHandler(this.chk_userActivityReport_CheckedChanged);
            // 
            // chk_licenseDetentionReport
            // 
            resources.ApplyResources(this.chk_licenseDetentionReport, "chk_licenseDetentionReport");
            this.chk_licenseDetentionReport.Name = "chk_licenseDetentionReport";
            this.chk_licenseDetentionReport.UseVisualStyleBackColor = true;
            this.chk_licenseDetentionReport.CheckedChanged += new System.EventHandler(this.chk_licenseDetentionReport_CheckedChanged);
            // 
            // chk_testAttemptsReport
            // 
            resources.ApplyResources(this.chk_testAttemptsReport, "chk_testAttemptsReport");
            this.chk_testAttemptsReport.Name = "chk_testAttemptsReport";
            this.chk_testAttemptsReport.UseVisualStyleBackColor = true;
            this.chk_testAttemptsReport.CheckedChanged += new System.EventHandler(this.chk_testAttemptsReport_CheckedChanged);
            // 
            // chk_driverProfileReport
            // 
            resources.ApplyResources(this.chk_driverProfileReport, "chk_driverProfileReport");
            this.chk_driverProfileReport.Name = "chk_driverProfileReport";
            this.chk_driverProfileReport.UseVisualStyleBackColor = true;
            this.chk_driverProfileReport.CheckedChanged += new System.EventHandler(this.chk_driverProfileReport_CheckedChanged);
            // 
            // chk_localLicenseAppDetailsReport
            // 
            resources.ApplyResources(this.chk_localLicenseAppDetailsReport, "chk_localLicenseAppDetailsReport");
            this.chk_localLicenseAppDetailsReport.Name = "chk_localLicenseAppDetailsReport";
            this.chk_localLicenseAppDetailsReport.UseVisualStyleBackColor = true;
            this.chk_localLicenseAppDetailsReport.CheckedChanged += new System.EventHandler(this.chk_localLicenseAppDetailsReport_CheckedChanged);
            // 
            // chk_PersonHistoryReport
            // 
            resources.ApplyResources(this.chk_PersonHistoryReport, "chk_PersonHistoryReport");
            this.chk_PersonHistoryReport.Name = "chk_PersonHistoryReport";
            this.chk_PersonHistoryReport.UseVisualStyleBackColor = true;
            this.chk_PersonHistoryReport.CheckedChanged += new System.EventHandler(this.chk_PersonHistoryReport_CheckedChanged);
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
            // Frm_ReportsAccess
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReportsAccess";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_PersonHistoryReport;
        private System.Windows.Forms.CheckBox chk_testAttemptsReport;
        private System.Windows.Forms.CheckBox chk_driverProfileReport;
        private System.Windows.Forms.CheckBox chk_localLicenseAppDetailsReport;
        private System.Windows.Forms.CheckBox chk_licenseDetentionReport;
        private System.Windows.Forms.CheckBox chk_userActivityReport;
    }
}