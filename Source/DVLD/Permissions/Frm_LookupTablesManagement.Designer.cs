namespace DVLD.Permissions {
    partial class Frm_LookupTablesManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LookupTablesManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_appTypesExportData = new System.Windows.Forms.CheckBox();
            this.chk_appTypesUpdateData = new System.Windows.Forms.CheckBox();
            this.chk_appTypesViewAllData = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_testTypesExportData = new System.Windows.Forms.CheckBox();
            this.chk_testTypesUpdateData = new System.Windows.Forms.CheckBox();
            this.chk_testTypesViewAllData = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_licenseClassesExportData = new System.Windows.Forms.CheckBox();
            this.chk_licenseClassesUpdateData = new System.Windows.Forms.CheckBox();
            this.chk_licenseClassesViewAllData = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_appTypesExportData);
            this.groupBox1.Controls.Add(this.chk_appTypesUpdateData);
            this.groupBox1.Controls.Add(this.chk_appTypesViewAllData);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_appTypesExportData
            // 
            resources.ApplyResources(this.chk_appTypesExportData, "chk_appTypesExportData");
            this.chk_appTypesExportData.Name = "chk_appTypesExportData";
            this.chk_appTypesExportData.UseVisualStyleBackColor = true;
            this.chk_appTypesExportData.CheckedChanged += new System.EventHandler(this.chk_appTypesExportData_CheckedChanged);
            // 
            // chk_appTypesUpdateData
            // 
            resources.ApplyResources(this.chk_appTypesUpdateData, "chk_appTypesUpdateData");
            this.chk_appTypesUpdateData.Name = "chk_appTypesUpdateData";
            this.chk_appTypesUpdateData.UseVisualStyleBackColor = true;
            this.chk_appTypesUpdateData.CheckedChanged += new System.EventHandler(this.chk_appTypesUpdateData_CheckedChanged);
            // 
            // chk_appTypesViewAllData
            // 
            resources.ApplyResources(this.chk_appTypesViewAllData, "chk_appTypesViewAllData");
            this.chk_appTypesViewAllData.Name = "chk_appTypesViewAllData";
            this.chk_appTypesViewAllData.UseVisualStyleBackColor = true;
            this.chk_appTypesViewAllData.CheckedChanged += new System.EventHandler(this.chk_appTypesViewAllData_CheckedChanged);
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
            this.groupBox2.Controls.Add(this.chk_testTypesExportData);
            this.groupBox2.Controls.Add(this.chk_testTypesUpdateData);
            this.groupBox2.Controls.Add(this.chk_testTypesViewAllData);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chk_testTypesExportData
            // 
            resources.ApplyResources(this.chk_testTypesExportData, "chk_testTypesExportData");
            this.chk_testTypesExportData.Name = "chk_testTypesExportData";
            this.chk_testTypesExportData.UseVisualStyleBackColor = true;
            this.chk_testTypesExportData.CheckedChanged += new System.EventHandler(this.chk_testTypesExportData_CheckedChanged);
            // 
            // chk_testTypesUpdateData
            // 
            resources.ApplyResources(this.chk_testTypesUpdateData, "chk_testTypesUpdateData");
            this.chk_testTypesUpdateData.Name = "chk_testTypesUpdateData";
            this.chk_testTypesUpdateData.UseVisualStyleBackColor = true;
            this.chk_testTypesUpdateData.CheckedChanged += new System.EventHandler(this.chk_testTypesUpdateData_CheckedChanged);
            // 
            // chk_testTypesViewAllData
            // 
            resources.ApplyResources(this.chk_testTypesViewAllData, "chk_testTypesViewAllData");
            this.chk_testTypesViewAllData.Name = "chk_testTypesViewAllData";
            this.chk_testTypesViewAllData.UseVisualStyleBackColor = true;
            this.chk_testTypesViewAllData.CheckedChanged += new System.EventHandler(this.chk_testTypesViewAllData_CheckedChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.chk_licenseClassesExportData);
            this.groupBox3.Controls.Add(this.chk_licenseClassesUpdateData);
            this.groupBox3.Controls.Add(this.chk_licenseClassesViewAllData);
            this.groupBox3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox3.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // chk_licenseClassesExportData
            // 
            resources.ApplyResources(this.chk_licenseClassesExportData, "chk_licenseClassesExportData");
            this.chk_licenseClassesExportData.Name = "chk_licenseClassesExportData";
            this.chk_licenseClassesExportData.UseVisualStyleBackColor = true;
            this.chk_licenseClassesExportData.CheckedChanged += new System.EventHandler(this.chk_licenseClassesExportData_CheckedChanged);
            // 
            // chk_licenseClassesUpdateData
            // 
            resources.ApplyResources(this.chk_licenseClassesUpdateData, "chk_licenseClassesUpdateData");
            this.chk_licenseClassesUpdateData.Name = "chk_licenseClassesUpdateData";
            this.chk_licenseClassesUpdateData.UseVisualStyleBackColor = true;
            this.chk_licenseClassesUpdateData.CheckedChanged += new System.EventHandler(this.chk_licenseClassesUpdateData_CheckedChanged);
            // 
            // chk_licenseClassesViewAllData
            // 
            resources.ApplyResources(this.chk_licenseClassesViewAllData, "chk_licenseClassesViewAllData");
            this.chk_licenseClassesViewAllData.Name = "chk_licenseClassesViewAllData";
            this.chk_licenseClassesViewAllData.UseVisualStyleBackColor = true;
            this.chk_licenseClassesViewAllData.CheckedChanged += new System.EventHandler(this.chk_licenseClassesViewAllData_CheckedChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox4.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // Frm_LookupTablesManagement
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
            this.Name = "Frm_LookupTablesManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_appTypesViewAllData;
        private System.Windows.Forms.CheckBox chk_appTypesExportData;
        private System.Windows.Forms.CheckBox chk_appTypesUpdateData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_testTypesExportData;
        private System.Windows.Forms.CheckBox chk_testTypesUpdateData;
        private System.Windows.Forms.CheckBox chk_testTypesViewAllData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_licenseClassesExportData;
        private System.Windows.Forms.CheckBox chk_licenseClassesUpdateData;
        private System.Windows.Forms.CheckBox chk_licenseClassesViewAllData;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}