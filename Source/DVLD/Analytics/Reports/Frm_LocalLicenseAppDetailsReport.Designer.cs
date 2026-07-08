namespace DVLD.Analytics.Reports {
    partial class Frm_LocalLicenseAppDetailsReport {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LocalLicenseAppDetailsReport));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_includeFeesSammary = new System.Windows.Forms.CheckBox();
            this.chk_includeTestInfo = new System.Windows.Forms.CheckBox();
            this.chk_includeApplicantInfo = new System.Windows.Forms.CheckBox();
            this.chk_includeAppInfo = new System.Windows.Forms.CheckBox();
            this.ll_selectApp = new System.Windows.Forms.LinkLabel();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.ctrl_LocalDrivingLicenseAppInfoCard1 = new DVLD.Applications.Local_Driving_License.Controls.Ctrl_LocalDrivingLicenseAppInfoCard();
            this.ctrl_DocumentExportSettings1 = new DVLD.Analytics.Reports.Controls.Ctrl_DocumentExportSettings();
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
            this.groupBox1.Controls.Add(this.chk_includeFeesSammary);
            this.groupBox1.Controls.Add(this.chk_includeTestInfo);
            this.groupBox1.Controls.Add(this.chk_includeApplicantInfo);
            this.groupBox1.Controls.Add(this.chk_includeAppInfo);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_includeFeesSammary
            // 
            resources.ApplyResources(this.chk_includeFeesSammary, "chk_includeFeesSammary");
            this.chk_includeFeesSammary.Checked = true;
            this.chk_includeFeesSammary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeFeesSammary.Name = "chk_includeFeesSammary";
            this.chk_includeFeesSammary.UseVisualStyleBackColor = true;
            this.chk_includeFeesSammary.CheckedChanged += new System.EventHandler(this.chk_includeFeesSammary_CheckedChanged);
            // 
            // chk_includeTestInfo
            // 
            resources.ApplyResources(this.chk_includeTestInfo, "chk_includeTestInfo");
            this.chk_includeTestInfo.Checked = true;
            this.chk_includeTestInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeTestInfo.Name = "chk_includeTestInfo";
            this.chk_includeTestInfo.UseVisualStyleBackColor = true;
            this.chk_includeTestInfo.CheckedChanged += new System.EventHandler(this.chk_includeTestInfo_CheckedChanged);
            // 
            // chk_includeApplicantInfo
            // 
            resources.ApplyResources(this.chk_includeApplicantInfo, "chk_includeApplicantInfo");
            this.chk_includeApplicantInfo.Checked = true;
            this.chk_includeApplicantInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeApplicantInfo.Name = "chk_includeApplicantInfo";
            this.chk_includeApplicantInfo.UseVisualStyleBackColor = true;
            this.chk_includeApplicantInfo.CheckedChanged += new System.EventHandler(this.chk_includeApplicantInfo_CheckedChanged);
            // 
            // chk_includeAppInfo
            // 
            resources.ApplyResources(this.chk_includeAppInfo, "chk_includeAppInfo");
            this.chk_includeAppInfo.Checked = true;
            this.chk_includeAppInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_includeAppInfo.Name = "chk_includeAppInfo";
            this.chk_includeAppInfo.UseVisualStyleBackColor = true;
            this.chk_includeAppInfo.CheckedChanged += new System.EventHandler(this.chk_includeAppInfo_CheckedChanged);
            // 
            // ll_selectApp
            // 
            resources.ApplyResources(this.ll_selectApp, "ll_selectApp");
            this.ll_selectApp.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_selectApp.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_selectApp.Name = "ll_selectApp";
            this.ll_selectApp.TabStop = true;
            this.ll_selectApp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_selectApp_LinkClicked);
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
            // ctrl_LocalDrivingLicenseAppInfoCard1
            // 
            resources.ApplyResources(this.ctrl_LocalDrivingLicenseAppInfoCard1, "ctrl_LocalDrivingLicenseAppInfoCard1");
            this.ctrl_LocalDrivingLicenseAppInfoCard1.LocalDrivingLicenseAppID = -1;
            this.ctrl_LocalDrivingLicenseAppInfoCard1.Name = "ctrl_LocalDrivingLicenseAppInfoCard1";
            this.ctrl_LocalDrivingLicenseAppInfoCard1.PersonSaved += new System.Action<int>(this.ctrl_LocalDrivingLicenseAppInfoCard1_PersonSaved);
            // 
            // ctrl_DocumentExportSettings1
            // 
            resources.ApplyResources(this.ctrl_DocumentExportSettings1, "ctrl_DocumentExportSettings1");
            this.ctrl_DocumentExportSettings1.Name = "ctrl_DocumentExportSettings1";
            // 
            // Frm_LocalLicenseAppDetailsReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.btn_close;
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.ll_selectApp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrl_LocalDrivingLicenseAppInfoCard1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.ctrl_DocumentExportSettings1);
            this.Controls.Add(this.btn_close);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_LocalLicenseAppDetailsReport";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Applications.Local_Driving_License.Controls.Ctrl_LocalDrivingLicenseAppInfoCard ctrl_LocalDrivingLicenseAppInfoCard1;
        private Controls.Ctrl_DocumentExportSettings ctrl_DocumentExportSettings1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_includeFeesSammary;
        private System.Windows.Forms.CheckBox chk_includeTestInfo;
        private System.Windows.Forms.CheckBox chk_includeApplicantInfo;
        private System.Windows.Forms.CheckBox chk_includeAppInfo;
        private System.Windows.Forms.LinkLabel ll_selectApp;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_export;
    }
}