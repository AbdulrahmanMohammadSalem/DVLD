namespace DVLD.Permissions {
    partial class Frm_DashboardAccess {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DashboardAccess));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_systemWideRevenue = new System.Windows.Forms.CheckBox();
            this.chk_licenseDetentionFineFees = new System.Windows.Forms.CheckBox();
            this.chk_revenueByLicenseClass = new System.Windows.Forms.CheckBox();
            this.chk_revenueByTestType = new System.Windows.Forms.CheckBox();
            this.chk_revenueByServiceType = new System.Windows.Forms.CheckBox();
            this.chk_testResultsRates = new System.Windows.Forms.CheckBox();
            this.chk_testAppointsLoad = new System.Windows.Forms.CheckBox();
            this.chk_localLicenseAppsStatus = new System.Windows.Forms.CheckBox();
            this.chk_totalAppsOverTime = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_systemWideRevenue);
            this.groupBox1.Controls.Add(this.chk_licenseDetentionFineFees);
            this.groupBox1.Controls.Add(this.chk_revenueByLicenseClass);
            this.groupBox1.Controls.Add(this.chk_revenueByTestType);
            this.groupBox1.Controls.Add(this.chk_revenueByServiceType);
            this.groupBox1.Controls.Add(this.chk_testResultsRates);
            this.groupBox1.Controls.Add(this.chk_testAppointsLoad);
            this.groupBox1.Controls.Add(this.chk_localLicenseAppsStatus);
            this.groupBox1.Controls.Add(this.chk_totalAppsOverTime);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_systemWideRevenue
            // 
            resources.ApplyResources(this.chk_systemWideRevenue, "chk_systemWideRevenue");
            this.chk_systemWideRevenue.Name = "chk_systemWideRevenue";
            this.chk_systemWideRevenue.UseVisualStyleBackColor = true;
            this.chk_systemWideRevenue.CheckedChanged += new System.EventHandler(this.chk_systemWideRevenue_CheckedChanged);
            // 
            // chk_licenseDetentionFineFees
            // 
            resources.ApplyResources(this.chk_licenseDetentionFineFees, "chk_licenseDetentionFineFees");
            this.chk_licenseDetentionFineFees.Name = "chk_licenseDetentionFineFees";
            this.chk_licenseDetentionFineFees.UseVisualStyleBackColor = true;
            this.chk_licenseDetentionFineFees.CheckedChanged += new System.EventHandler(this.chk_licenseDetentionFineFees_CheckedChanged);
            // 
            // chk_revenueByLicenseClass
            // 
            resources.ApplyResources(this.chk_revenueByLicenseClass, "chk_revenueByLicenseClass");
            this.chk_revenueByLicenseClass.Name = "chk_revenueByLicenseClass";
            this.chk_revenueByLicenseClass.UseVisualStyleBackColor = true;
            this.chk_revenueByLicenseClass.CheckedChanged += new System.EventHandler(this.chk_revenueByLicenseClass_CheckedChanged);
            // 
            // chk_revenueByTestType
            // 
            resources.ApplyResources(this.chk_revenueByTestType, "chk_revenueByTestType");
            this.chk_revenueByTestType.Name = "chk_revenueByTestType";
            this.chk_revenueByTestType.UseVisualStyleBackColor = true;
            this.chk_revenueByTestType.CheckedChanged += new System.EventHandler(this.chk_revenueByTestType_CheckedChanged);
            // 
            // chk_revenueByServiceType
            // 
            resources.ApplyResources(this.chk_revenueByServiceType, "chk_revenueByServiceType");
            this.chk_revenueByServiceType.Name = "chk_revenueByServiceType";
            this.chk_revenueByServiceType.UseVisualStyleBackColor = true;
            this.chk_revenueByServiceType.CheckedChanged += new System.EventHandler(this.chk_revenueByServiceType_CheckedChanged);
            // 
            // chk_testResultsRates
            // 
            resources.ApplyResources(this.chk_testResultsRates, "chk_testResultsRates");
            this.chk_testResultsRates.Name = "chk_testResultsRates";
            this.chk_testResultsRates.UseVisualStyleBackColor = true;
            this.chk_testResultsRates.CheckedChanged += new System.EventHandler(this.chk_testResultsRates_CheckedChanged);
            // 
            // chk_testAppointsLoad
            // 
            resources.ApplyResources(this.chk_testAppointsLoad, "chk_testAppointsLoad");
            this.chk_testAppointsLoad.Name = "chk_testAppointsLoad";
            this.chk_testAppointsLoad.UseVisualStyleBackColor = true;
            this.chk_testAppointsLoad.CheckedChanged += new System.EventHandler(this.chk_testAppointsLoad_CheckedChanged);
            // 
            // chk_localLicenseAppsStatus
            // 
            resources.ApplyResources(this.chk_localLicenseAppsStatus, "chk_localLicenseAppsStatus");
            this.chk_localLicenseAppsStatus.Name = "chk_localLicenseAppsStatus";
            this.chk_localLicenseAppsStatus.UseVisualStyleBackColor = true;
            this.chk_localLicenseAppsStatus.CheckedChanged += new System.EventHandler(this.chk_localLicenseAppsStatus_CheckedChanged);
            // 
            // chk_totalAppsOverTime
            // 
            resources.ApplyResources(this.chk_totalAppsOverTime, "chk_totalAppsOverTime");
            this.chk_totalAppsOverTime.Name = "chk_totalAppsOverTime";
            this.chk_totalAppsOverTime.UseVisualStyleBackColor = true;
            this.chk_totalAppsOverTime.CheckedChanged += new System.EventHandler(this.chk_totalAppsOverTime_CheckedChanged);
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
            // Frm_DashboardAccess
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
            this.Name = "Frm_DashboardAccess";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_totalAppsOverTime;
        private System.Windows.Forms.CheckBox chk_testResultsRates;
        private System.Windows.Forms.CheckBox chk_testAppointsLoad;
        private System.Windows.Forms.CheckBox chk_localLicenseAppsStatus;
        private System.Windows.Forms.CheckBox chk_systemWideRevenue;
        private System.Windows.Forms.CheckBox chk_licenseDetentionFineFees;
        private System.Windows.Forms.CheckBox chk_revenueByLicenseClass;
        private System.Windows.Forms.CheckBox chk_revenueByTestType;
        private System.Windows.Forms.CheckBox chk_revenueByServiceType;
    }
}