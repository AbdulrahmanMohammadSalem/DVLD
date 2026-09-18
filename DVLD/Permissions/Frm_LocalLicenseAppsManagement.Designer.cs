namespace DVLD.Permissions {
    partial class Frm_LocalLicenseAppsManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LocalLicenseAppsManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_cancelApp = new System.Windows.Forms.CheckBox();
            this.chk_deleteApp = new System.Windows.Forms.CheckBox();
            this.chk_editAppInfo = new System.Windows.Forms.CheckBox();
            this.chk_exportLocalLicenseAppsData = new System.Windows.Forms.CheckBox();
            this.chk_viewFullAppDetails = new System.Windows.Forms.CheckBox();
            this.chk_createNewLocalLicenseApp = new System.Windows.Forms.CheckBox();
            this.chk_seeAllLocalLicenseApps = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_cancelApp);
            this.groupBox1.Controls.Add(this.chk_deleteApp);
            this.groupBox1.Controls.Add(this.chk_editAppInfo);
            this.groupBox1.Controls.Add(this.chk_exportLocalLicenseAppsData);
            this.groupBox1.Controls.Add(this.chk_viewFullAppDetails);
            this.groupBox1.Controls.Add(this.chk_createNewLocalLicenseApp);
            this.groupBox1.Controls.Add(this.chk_seeAllLocalLicenseApps);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_cancelApp
            // 
            resources.ApplyResources(this.chk_cancelApp, "chk_cancelApp");
            this.chk_cancelApp.Name = "chk_cancelApp";
            this.chk_cancelApp.UseVisualStyleBackColor = true;
            this.chk_cancelApp.CheckedChanged += new System.EventHandler(this.chk_cancelApp_CheckedChanged);
            // 
            // chk_deleteApp
            // 
            resources.ApplyResources(this.chk_deleteApp, "chk_deleteApp");
            this.chk_deleteApp.Name = "chk_deleteApp";
            this.chk_deleteApp.UseVisualStyleBackColor = true;
            this.chk_deleteApp.CheckedChanged += new System.EventHandler(this.chk_deleteApp_CheckedChanged);
            // 
            // chk_editAppInfo
            // 
            resources.ApplyResources(this.chk_editAppInfo, "chk_editAppInfo");
            this.chk_editAppInfo.Name = "chk_editAppInfo";
            this.chk_editAppInfo.UseVisualStyleBackColor = true;
            this.chk_editAppInfo.CheckedChanged += new System.EventHandler(this.chk_editAppInfo_CheckedChanged);
            // 
            // chk_exportLocalLicenseAppsData
            // 
            resources.ApplyResources(this.chk_exportLocalLicenseAppsData, "chk_exportLocalLicenseAppsData");
            this.chk_exportLocalLicenseAppsData.Name = "chk_exportLocalLicenseAppsData";
            this.chk_exportLocalLicenseAppsData.UseVisualStyleBackColor = true;
            this.chk_exportLocalLicenseAppsData.CheckedChanged += new System.EventHandler(this.chk_exportLocalLicenseAppsData_CheckedChanged);
            // 
            // chk_viewFullAppDetails
            // 
            resources.ApplyResources(this.chk_viewFullAppDetails, "chk_viewFullAppDetails");
            this.chk_viewFullAppDetails.Name = "chk_viewFullAppDetails";
            this.chk_viewFullAppDetails.UseVisualStyleBackColor = true;
            this.chk_viewFullAppDetails.CheckedChanged += new System.EventHandler(this.chk_viewFullAppDetails_CheckedChanged);
            // 
            // chk_createNewLocalLicenseApp
            // 
            resources.ApplyResources(this.chk_createNewLocalLicenseApp, "chk_createNewLocalLicenseApp");
            this.chk_createNewLocalLicenseApp.Name = "chk_createNewLocalLicenseApp";
            this.chk_createNewLocalLicenseApp.UseVisualStyleBackColor = true;
            this.chk_createNewLocalLicenseApp.CheckedChanged += new System.EventHandler(this.chk_createNewLocalLicenseApp_CheckedChanged);
            // 
            // chk_seeAllLocalLicenseApps
            // 
            resources.ApplyResources(this.chk_seeAllLocalLicenseApps, "chk_seeAllLocalLicenseApps");
            this.chk_seeAllLocalLicenseApps.Name = "chk_seeAllLocalLicenseApps";
            this.chk_seeAllLocalLicenseApps.UseVisualStyleBackColor = true;
            this.chk_seeAllLocalLicenseApps.CheckedChanged += new System.EventHandler(this.chk_seeAllLocalLicenseApps_CheckedChanged);
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
            // Frm_LocalLicenseAppsManagement
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
            this.Name = "Frm_LocalLicenseAppsManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_seeAllLocalLicenseApps;
        private System.Windows.Forms.CheckBox chk_cancelApp;
        private System.Windows.Forms.CheckBox chk_deleteApp;
        private System.Windows.Forms.CheckBox chk_editAppInfo;
        private System.Windows.Forms.CheckBox chk_exportLocalLicenseAppsData;
        private System.Windows.Forms.CheckBox chk_viewFullAppDetails;
        private System.Windows.Forms.CheckBox chk_createNewLocalLicenseApp;
    }
}