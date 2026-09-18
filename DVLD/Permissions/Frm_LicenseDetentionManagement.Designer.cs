namespace DVLD.Permissions {
    partial class Frm_LicenseDetentionManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LicenseDetentionManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_exportLicenseDetentionsData = new System.Windows.Forms.CheckBox();
            this.chk_releaseDetainedLicense = new System.Windows.Forms.CheckBox();
            this.chk_detainLicense = new System.Windows.Forms.CheckBox();
            this.chk_viewAllDetainedLicenses = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_exportLicenseDetentionsData);
            this.groupBox1.Controls.Add(this.chk_releaseDetainedLicense);
            this.groupBox1.Controls.Add(this.chk_detainLicense);
            this.groupBox1.Controls.Add(this.chk_viewAllDetainedLicenses);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_exportLicenseDetentionsData
            // 
            resources.ApplyResources(this.chk_exportLicenseDetentionsData, "chk_exportLicenseDetentionsData");
            this.chk_exportLicenseDetentionsData.Name = "chk_exportLicenseDetentionsData";
            this.chk_exportLicenseDetentionsData.UseVisualStyleBackColor = true;
            this.chk_exportLicenseDetentionsData.CheckedChanged += new System.EventHandler(this.chk_exportLicenseDetentionsData_CheckedChanged);
            // 
            // chk_releaseDetainedLicense
            // 
            resources.ApplyResources(this.chk_releaseDetainedLicense, "chk_releaseDetainedLicense");
            this.chk_releaseDetainedLicense.Name = "chk_releaseDetainedLicense";
            this.chk_releaseDetainedLicense.UseVisualStyleBackColor = true;
            this.chk_releaseDetainedLicense.CheckedChanged += new System.EventHandler(this.chk_releaseDetainedLicense_CheckedChanged);
            // 
            // chk_detainLicense
            // 
            resources.ApplyResources(this.chk_detainLicense, "chk_detainLicense");
            this.chk_detainLicense.Name = "chk_detainLicense";
            this.chk_detainLicense.UseVisualStyleBackColor = true;
            this.chk_detainLicense.CheckedChanged += new System.EventHandler(this.chk_detainLicense_CheckedChanged);
            // 
            // chk_viewAllDetainedLicenses
            // 
            resources.ApplyResources(this.chk_viewAllDetainedLicenses, "chk_viewAllDetainedLicenses");
            this.chk_viewAllDetainedLicenses.Name = "chk_viewAllDetainedLicenses";
            this.chk_viewAllDetainedLicenses.UseVisualStyleBackColor = true;
            this.chk_viewAllDetainedLicenses.CheckedChanged += new System.EventHandler(this.chk_viewAllDetainedLicenses_CheckedChanged);
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
            // Frm_LicenseDetentionManagement
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
            this.Name = "Frm_LicenseDetentionManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_viewAllDetainedLicenses;
        private System.Windows.Forms.CheckBox chk_exportLicenseDetentionsData;
        private System.Windows.Forms.CheckBox chk_releaseDetainedLicense;
        private System.Windows.Forms.CheckBox chk_detainLicense;
    }
}