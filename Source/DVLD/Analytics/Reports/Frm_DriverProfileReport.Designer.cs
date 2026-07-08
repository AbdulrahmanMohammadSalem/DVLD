namespace DVLD.Analytics.Reports {
    partial class Frm_DriverProfileReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DriverProfileReport));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_desiredLicenseType = new Salem.Controls.SalDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_includeInactiveLicenses = new System.Windows.Forms.CheckBox();
            this.chk_includeActiveLicenses = new System.Windows.Forms.CheckBox();
            this.chk_includeDriverInfo = new System.Windows.Forms.CheckBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.ctrl_DocumentExportSettings1 = new DVLD.Analytics.Reports.Controls.Ctrl_DocumentExportSettings();
            this.ctrl_PersonInfoCardWithFilter1 = new DVLD.People.Controls.Ctrl_PersonInfoCardWithFilter();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label_title.Name = "label_title";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cb_desiredLicenseType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chk_includeInactiveLicenses);
            this.groupBox1.Controls.Add(this.chk_includeActiveLicenses);
            this.groupBox1.Controls.Add(this.chk_includeDriverInfo);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cb_desiredLicenseType
            // 
            resources.ApplyResources(this.cb_desiredLicenseType, "cb_desiredLicenseType");
            this.cb_desiredLicenseType.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_desiredLicenseType.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_desiredLicenseType.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_desiredLicenseType.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_desiredLicenseType.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_desiredLicenseType.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_desiredLicenseType.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_desiredLicenseType.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_desiredLicenseType.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_desiredLicenseType.Items.AddRange(new object[] {
            resources.GetString("cb_desiredLicenseType.Items"),
            resources.GetString("cb_desiredLicenseType.Items1"),
            resources.GetString("cb_desiredLicenseType.Items2")});
            this.cb_desiredLicenseType.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_desiredLicenseType.Name = "cb_desiredLicenseType";
            this.cb_desiredLicenseType.SelectedIndex = 2;
            this.cb_desiredLicenseType.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chk_includeInactiveLicenses
            // 
            resources.ApplyResources(this.chk_includeInactiveLicenses, "chk_includeInactiveLicenses");
            this.chk_includeInactiveLicenses.Checked = true;
            this.chk_includeInactiveLicenses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeInactiveLicenses.Name = "chk_includeInactiveLicenses";
            this.chk_includeInactiveLicenses.UseVisualStyleBackColor = true;
            this.chk_includeInactiveLicenses.CheckedChanged += new System.EventHandler(this.chk_includeInactiveLicenses_CheckedChanged);
            // 
            // chk_includeActiveLicenses
            // 
            resources.ApplyResources(this.chk_includeActiveLicenses, "chk_includeActiveLicenses");
            this.chk_includeActiveLicenses.Checked = true;
            this.chk_includeActiveLicenses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeActiveLicenses.Name = "chk_includeActiveLicenses";
            this.chk_includeActiveLicenses.UseVisualStyleBackColor = true;
            this.chk_includeActiveLicenses.CheckedChanged += new System.EventHandler(this.chk_includeActiveLicenses_CheckedChanged);
            // 
            // chk_includeDriverInfo
            // 
            resources.ApplyResources(this.chk_includeDriverInfo, "chk_includeDriverInfo");
            this.chk_includeDriverInfo.Checked = true;
            this.chk_includeDriverInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeDriverInfo.Name = "chk_includeDriverInfo";
            this.chk_includeDriverInfo.UseVisualStyleBackColor = true;
            this.chk_includeDriverInfo.CheckedChanged += new System.EventHandler(this.chk_includeDriverInfo_CheckedChanged);
            // 
            // btn_print
            // 
            resources.ApplyResources(this.btn_print, "btn_print");
            this.btn_print.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_print.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_print.Image = global::DVLD.Properties.Resources.Print_32;
            this.btn_print.Name = "btn_print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_export
            // 
            resources.ApplyResources(this.btn_export, "btn_export");
            this.btn_export.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_export.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_export.FlatAppearance.BorderSize = 2;
            this.btn_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_export.Image = global::DVLD.Properties.Resources.Export_PDF_32;
            this.btn_export.Name = "btn_export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // ctrl_DocumentExportSettings1
            // 
            resources.ApplyResources(this.ctrl_DocumentExportSettings1, "ctrl_DocumentExportSettings1");
            this.ctrl_DocumentExportSettings1.Name = "ctrl_DocumentExportSettings1";
            // 
            // ctrl_PersonInfoCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_PersonInfoCardWithFilter1, "ctrl_PersonInfoCardWithFilter1");
            this.ctrl_PersonInfoCardWithFilter1.EnableAddingNewPerson = true;
            this.ctrl_PersonInfoCardWithFilter1.EnableEditingPersonInfo = true;
            this.ctrl_PersonInfoCardWithFilter1.EnableFiltering = true;
            this.ctrl_PersonInfoCardWithFilter1.Name = "ctrl_PersonInfoCardWithFilter1";
            this.ctrl_PersonInfoCardWithFilter1.PersonFound += new System.Action<int>(this.ctrl_PersonInfoCardWithFilter1_PersonFound);
            this.ctrl_PersonInfoCardWithFilter1.PersonNotFound += new System.Action(this.ctrl_PersonInfoCardWithFilter1_PersonNotFound);
            this.ctrl_PersonInfoCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_PersonInfoCardWithFilter1_PersonSaved);
            // 
            // Frm_DriverProfileReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrl_DocumentExportSettings1);
            this.Controls.Add(this.ctrl_PersonInfoCardWithFilter1);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DriverProfileReport";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Controls.Ctrl_DocumentExportSettings ctrl_DocumentExportSettings1;
        private People.Controls.Ctrl_PersonInfoCardWithFilter ctrl_PersonInfoCardWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_includeInactiveLicenses;
        private System.Windows.Forms.CheckBox chk_includeActiveLicenses;
        private System.Windows.Forms.CheckBox chk_includeDriverInfo;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalDropDownList cb_desiredLicenseType;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_export;
    }
}