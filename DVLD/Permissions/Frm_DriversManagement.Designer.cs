namespace DVLD.Permissions {
    partial class Frm_DriversManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DriversManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_drivingTests = new System.Windows.Forms.CheckBox();
            this.chk_writtenTests = new System.Windows.Forms.CheckBox();
            this.chk_visionTests = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_interLicenses = new System.Windows.Forms.CheckBox();
            this.chk_localLicenses = new System.Windows.Forms.CheckBox();
            this.chk_exportDriversData = new System.Windows.Forms.CheckBox();
            this.chk_seeAllDrivers = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_drivingTests);
            this.groupBox1.Controls.Add(this.chk_writtenTests);
            this.groupBox1.Controls.Add(this.chk_visionTests);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_drivingTests
            // 
            resources.ApplyResources(this.chk_drivingTests, "chk_drivingTests");
            this.chk_drivingTests.Name = "chk_drivingTests";
            this.chk_drivingTests.UseVisualStyleBackColor = true;
            this.chk_drivingTests.CheckedChanged += new System.EventHandler(this.chk_drivingTests_CheckedChanged);
            // 
            // chk_writtenTests
            // 
            resources.ApplyResources(this.chk_writtenTests, "chk_writtenTests");
            this.chk_writtenTests.Name = "chk_writtenTests";
            this.chk_writtenTests.UseVisualStyleBackColor = true;
            this.chk_writtenTests.CheckedChanged += new System.EventHandler(this.chk_writtenTests_CheckedChanged);
            // 
            // chk_visionTests
            // 
            resources.ApplyResources(this.chk_visionTests, "chk_visionTests");
            this.chk_visionTests.Name = "chk_visionTests";
            this.chk_visionTests.UseVisualStyleBackColor = true;
            this.chk_visionTests.CheckedChanged += new System.EventHandler(this.chk_visionTests_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.chk_interLicenses);
            this.groupBox2.Controls.Add(this.chk_localLicenses);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chk_interLicenses
            // 
            resources.ApplyResources(this.chk_interLicenses, "chk_interLicenses");
            this.chk_interLicenses.Name = "chk_interLicenses";
            this.chk_interLicenses.UseVisualStyleBackColor = true;
            this.chk_interLicenses.CheckedChanged += new System.EventHandler(this.chk_interLicenses_CheckedChanged);
            // 
            // chk_localLicenses
            // 
            resources.ApplyResources(this.chk_localLicenses, "chk_localLicenses");
            this.chk_localLicenses.Name = "chk_localLicenses";
            this.chk_localLicenses.UseVisualStyleBackColor = true;
            this.chk_localLicenses.CheckedChanged += new System.EventHandler(this.chk_localLicenses_CheckedChanged);
            // 
            // chk_exportDriversData
            // 
            resources.ApplyResources(this.chk_exportDriversData, "chk_exportDriversData");
            this.chk_exportDriversData.Name = "chk_exportDriversData";
            this.chk_exportDriversData.UseVisualStyleBackColor = true;
            this.chk_exportDriversData.CheckedChanged += new System.EventHandler(this.chk_exportDriversData_CheckedChanged);
            // 
            // chk_seeAllDrivers
            // 
            resources.ApplyResources(this.chk_seeAllDrivers, "chk_seeAllDrivers");
            this.chk_seeAllDrivers.Name = "chk_seeAllDrivers";
            this.chk_seeAllDrivers.UseVisualStyleBackColor = true;
            this.chk_seeAllDrivers.CheckedChanged += new System.EventHandler(this.chk_seeAllDrivers_CheckedChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.chk_exportDriversData);
            this.groupBox4.Controls.Add(this.chk_seeAllDrivers);
            this.groupBox4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox4.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // Frm_DriversManagement
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
            this.Name = "Frm_DriversManagement";
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
        private System.Windows.Forms.CheckBox chk_visionTests;
        private System.Windows.Forms.CheckBox chk_writtenTests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_interLicenses;
        private System.Windows.Forms.CheckBox chk_localLicenses;
        private System.Windows.Forms.CheckBox chk_exportDriversData;
        private System.Windows.Forms.CheckBox chk_seeAllDrivers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_drivingTests;
    }
}