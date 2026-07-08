namespace DVLD.Permissions {
    partial class Frm_InterLicenseAppsManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InterLicenseAppsManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_exportInterLicenseAppsData = new System.Windows.Forms.CheckBox();
            this.chk_createNewInterLicenseApp = new System.Windows.Forms.CheckBox();
            this.chk_seeAllInterLicenseApps = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_exportInterLicenseAppsData);
            this.groupBox1.Controls.Add(this.chk_createNewInterLicenseApp);
            this.groupBox1.Controls.Add(this.chk_seeAllInterLicenseApps);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_exportInterLicenseAppsData
            // 
            resources.ApplyResources(this.chk_exportInterLicenseAppsData, "chk_exportInterLicenseAppsData");
            this.chk_exportInterLicenseAppsData.Name = "chk_exportInterLicenseAppsData";
            this.chk_exportInterLicenseAppsData.UseVisualStyleBackColor = true;
            this.chk_exportInterLicenseAppsData.CheckedChanged += new System.EventHandler(this.chk_exportInterLicenseAppsData_CheckedChanged);
            // 
            // chk_createNewInterLicenseApp
            // 
            resources.ApplyResources(this.chk_createNewInterLicenseApp, "chk_createNewInterLicenseApp");
            this.chk_createNewInterLicenseApp.Name = "chk_createNewInterLicenseApp";
            this.chk_createNewInterLicenseApp.UseVisualStyleBackColor = true;
            this.chk_createNewInterLicenseApp.CheckedChanged += new System.EventHandler(this.chk_createNewInterLicenseApp_CheckedChanged);
            // 
            // chk_seeAllInterLicenseApps
            // 
            resources.ApplyResources(this.chk_seeAllInterLicenseApps, "chk_seeAllInterLicenseApps");
            this.chk_seeAllInterLicenseApps.Name = "chk_seeAllInterLicenseApps";
            this.chk_seeAllInterLicenseApps.UseVisualStyleBackColor = true;
            this.chk_seeAllInterLicenseApps.CheckedChanged += new System.EventHandler(this.chk_seeAllInterLicenseApps_CheckedChanged);
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
            // Frm_InterLicenseAppsManagement
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
            this.Name = "Frm_InterLicenseAppsManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_seeAllInterLicenseApps;
        private System.Windows.Forms.CheckBox chk_createNewInterLicenseApp;
        private System.Windows.Forms.CheckBox chk_exportInterLicenseAppsData;
    }
}