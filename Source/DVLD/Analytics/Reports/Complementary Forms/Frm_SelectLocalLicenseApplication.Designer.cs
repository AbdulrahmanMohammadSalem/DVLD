namespace DVLD.Analytics.Reports.Complementary_Forms {
    partial class Frm_SelectLocalLicenseApplication {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectLocalLicenseApplication));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.dgv_apps = new System.Windows.Forms.DataGridView();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.lbl_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.ctrl_PersonInfoCardWithFilter1 = new DVLD.People.Controls.Ctrl_PersonInfoCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apps)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "lbl_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "lbl_noDataAvailable";
            // 
            // dgv_apps
            // 
            this.dgv_apps.AllowUserToAddRows = false;
            this.dgv_apps.AllowUserToDeleteRows = false;
            this.dgv_apps.AllowUserToOrderColumns = true;
            this.dgv_apps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_apps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_apps, "dgv_apps");
            this.dgv_apps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_apps.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_apps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_apps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_apps.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_apps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_apps.EnableHeadersVisualStyles = false;
            this.dgv_apps.MultiSelect = false;
            this.dgv_apps.Name = "dgv_apps";
            this.dgv_apps.ReadOnly = true;
            this.dgv_apps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_apps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_apps.RowTemplate.Height = 26;
            this.dgv_apps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_apps.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_apps_CellDoubleClick);
            this.dgv_apps.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_apps_CellFormatting);
            // 
            // ll_exportData
            // 
            resources.ApplyResources(this.ll_exportData, "ll_exportData");
            this.ll_exportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_exportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_exportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_exportData.Name = "ll_exportData";
            this.ll_exportData.TabStop = true;
            this.ll_exportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_exportData_LinkClicked);
            // 
            // ll_refreshData
            // 
            resources.ApplyResources(this.ll_refreshData, "ll_refreshData");
            this.ll_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_refreshData.Name = "ll_refreshData";
            this.ll_refreshData.TabStop = true;
            this.ll_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_refreshData_LinkClicked);
            // 
            // lbl_numOfRecords
            // 
            resources.ApplyResources(this.lbl_numOfRecords, "lbl_numOfRecords");
            this.lbl_numOfRecords.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_numOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_numOfRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_numOfRecords.Name = "lbl_numOfRecords";
            this.lbl_numOfRecords.ReadOnly = true;
            this.lbl_numOfRecords.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_cancel.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.Image = global::DVLD.Properties.Resources.Close_32;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_ok.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ok.Image = global::DVLD.Properties.Resources.OK_32;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
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
            // Frm_SelectLocalLicenseApplication
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.btn_cancel;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.ll_refreshData);
            this.Controls.Add(this.lbl_numOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.dgv_apps);
            this.Controls.Add(this.ctrl_PersonInfoCardWithFilter1);
            this.Controls.Add(this.ll_exportData);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SelectLocalLicenseApplication";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_SelectLocalLicenseApplication_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.Ctrl_PersonInfoCardWithFilter ctrl_PersonInfoCardWithFilter1;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.DataGridView dgv_apps;
        private System.Windows.Forms.LinkLabel ll_exportData;
        private System.Windows.Forms.LinkLabel ll_refreshData;
        private Salem.Controls.SalSelectableLabel lbl_numOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}