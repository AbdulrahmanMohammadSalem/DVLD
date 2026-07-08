namespace DVLD.Licenses.Layouts {
    partial class Layout_ShowAllLicenses {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_ShowAllLicenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new Manina.Windows.Forms.TabControl();
            this.tabPage1 = new Manina.Windows.Forms.Tab();
            this.ll_localExportData = new System.Windows.Forms.LinkLabel();
            this.ll_newLocalApplication = new System.Windows.Forms.LinkLabel();
            this.lbl_localNoDataAvailable = new System.Windows.Forms.Label();
            this.lbl_localNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.ll_localRefreshData = new System.Windows.Forms.LinkLabel();
            this.dgv_localLicenses = new System.Windows.Forms.DataGridView();
            this.IsDetainedImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_allLocalLicenses = new System.Windows.Forms.Label();
            this.tabPage2 = new Manina.Windows.Forms.Tab();
            this.ll_interExportData = new System.Windows.Forms.LinkLabel();
            this.ll_newInterApplication = new System.Windows.Forms.LinkLabel();
            this.lbl_interNoDataAvailable = new System.Windows.Forms.Label();
            this.lbl_interNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ll_interRefreshData = new System.Windows.Forms.LinkLabel();
            this.dgv_interLicenses = new System.Windows.Forms.DataGridView();
            this.lbl_allInterLicenses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localLicenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseCompatibleTextRendering = true;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.LicenseView_400;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Tabs.Add(this.tabPage1);
            this.tabControl1.Tabs.Add(this.tabPage2);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tabPage1.Controls.Add(this.ll_localExportData);
            this.tabPage1.Controls.Add(this.ll_newLocalApplication);
            this.tabPage1.Controls.Add(this.lbl_localNoDataAvailable);
            this.tabPage1.Controls.Add(this.lbl_localNumOfRecords);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ll_localRefreshData);
            this.tabPage1.Controls.Add(this.dgv_localLicenses);
            this.tabPage1.Controls.Add(this.lbl_allLocalLicenses);
            this.tabPage1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage1.Name = "tabPage1";
            // 
            // ll_localExportData
            // 
            resources.ApplyResources(this.ll_localExportData, "ll_localExportData");
            this.ll_localExportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_localExportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_localExportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_localExportData.Name = "ll_localExportData";
            this.ll_localExportData.TabStop = true;
            this.ll_localExportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_localExportData_LinkClicked);
            // 
            // ll_newLocalApplication
            // 
            resources.ApplyResources(this.ll_newLocalApplication, "ll_newLocalApplication");
            this.ll_newLocalApplication.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_newLocalApplication.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_newLocalApplication.Name = "ll_newLocalApplication";
            this.ll_newLocalApplication.TabStop = true;
            this.ll_newLocalApplication.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_newLocalApplication_LinkClicked);
            // 
            // lbl_localNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_localNoDataAvailable, "lbl_localNoDataAvailable");
            this.lbl_localNoDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_localNoDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_localNoDataAvailable.Name = "lbl_localNoDataAvailable";
            // 
            // lbl_localNumOfRecords
            // 
            resources.ApplyResources(this.lbl_localNumOfRecords, "lbl_localNumOfRecords");
            this.lbl_localNumOfRecords.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.lbl_localNumOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_localNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_localNumOfRecords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_localNumOfRecords.Name = "lbl_localNumOfRecords";
            this.lbl_localNumOfRecords.ReadOnly = true;
            this.lbl_localNumOfRecords.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ll_localRefreshData
            // 
            resources.ApplyResources(this.ll_localRefreshData, "ll_localRefreshData");
            this.ll_localRefreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_localRefreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_localRefreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_localRefreshData.Name = "ll_localRefreshData";
            this.ll_localRefreshData.TabStop = true;
            this.ll_localRefreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_localRefreshData_LinkClicked);
            // 
            // dgv_localLicenses
            // 
            resources.ApplyResources(this.dgv_localLicenses, "dgv_localLicenses");
            this.dgv_localLicenses.AllowUserToAddRows = false;
            this.dgv_localLicenses.AllowUserToDeleteRows = false;
            this.dgv_localLicenses.AllowUserToOrderColumns = true;
            this.dgv_localLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_localLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_localLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_localLicenses.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_localLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Rubik", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_localLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_localLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsDetainedImage});
            this.dgv_localLicenses.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Rubik", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.NullValue = "[???]";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_localLicenses.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_localLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_localLicenses.EnableHeadersVisualStyles = false;
            this.dgv_localLicenses.MultiSelect = false;
            this.dgv_localLicenses.Name = "dgv_localLicenses";
            this.dgv_localLicenses.ReadOnly = true;
            this.dgv_localLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_localLicenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_localLicenses.RowTemplate.Height = 26;
            this.dgv_localLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_localLicenses.Tag = "";
            this.dgv_localLicenses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_localLicenses_CellDoubleClick);
            this.dgv_localLicenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Licenses_CellFormatting);
            // 
            // IsDetainedImage
            // 
            resources.ApplyResources(this.IsDetainedImage, "IsDetainedImage");
            this.IsDetainedImage.Image = global::DVLD.Properties.Resources.Question_16;
            this.IsDetainedImage.Name = "IsDetainedImage";
            this.IsDetainedImage.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.lbl_allLocalLicenses, "label4");
            this.lbl_allLocalLicenses.Name = "label4";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tabPage2.Controls.Add(this.ll_interExportData);
            this.tabPage2.Controls.Add(this.ll_newInterApplication);
            this.tabPage2.Controls.Add(this.lbl_interNoDataAvailable);
            this.tabPage2.Controls.Add(this.lbl_interNumOfRecords);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ll_interRefreshData);
            this.tabPage2.Controls.Add(this.dgv_interLicenses);
            this.tabPage2.Controls.Add(this.lbl_allInterLicenses);
            this.tabPage2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tabPage2.Name = "tabPage2";
            // 
            // ll_interExportData
            // 
            resources.ApplyResources(this.ll_interExportData, "ll_interExportData");
            this.ll_interExportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_interExportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_interExportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_interExportData.Name = "ll_interExportData";
            this.ll_interExportData.TabStop = true;
            this.ll_interExportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_interExportData_LinkClicked);
            // 
            // ll_newInterApplication
            // 
            resources.ApplyResources(this.ll_newInterApplication, "ll_newInterApplication");
            this.ll_newInterApplication.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_newInterApplication.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_newInterApplication.Name = "ll_newInterApplication";
            this.ll_newInterApplication.TabStop = true;
            this.ll_newInterApplication.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_newInterApplication_LinkClicked);
            // 
            // lbl_interNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_interNoDataAvailable, "lbl_interNoDataAvailable");
            this.lbl_interNoDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_interNoDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_interNoDataAvailable.Name = "lbl_interNoDataAvailable";
            // 
            // lbl_interNumOfRecords
            // 
            resources.ApplyResources(this.lbl_interNumOfRecords, "lbl_interNumOfRecords");
            this.lbl_interNumOfRecords.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.lbl_interNumOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_interNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_interNumOfRecords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_interNumOfRecords.Name = "lbl_interNumOfRecords";
            this.lbl_interNumOfRecords.ReadOnly = true;
            this.lbl_interNumOfRecords.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ll_interRefreshData
            // 
            resources.ApplyResources(this.ll_interRefreshData, "ll_interRefreshData");
            this.ll_interRefreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_interRefreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_interRefreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_interRefreshData.Name = "ll_interRefreshData";
            this.ll_interRefreshData.TabStop = true;
            this.ll_interRefreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_interRefreshData_LinkClicked);
            // 
            // dgv_interLicenses
            // 
            resources.ApplyResources(this.dgv_interLicenses, "dgv_interLicenses");
            this.dgv_interLicenses.AllowUserToAddRows = false;
            this.dgv_interLicenses.AllowUserToDeleteRows = false;
            this.dgv_interLicenses.AllowUserToOrderColumns = true;
            this.dgv_interLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_interLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_interLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_interLicenses.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_interLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Rubik", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_interLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_interLicenses.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Rubik", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.NullValue = "[???]";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_interLicenses.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_interLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_interLicenses.EnableHeadersVisualStyles = false;
            this.dgv_interLicenses.MultiSelect = false;
            this.dgv_interLicenses.Name = "dgv_interLicenses";
            this.dgv_interLicenses.ReadOnly = true;
            this.dgv_interLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_interLicenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_interLicenses.RowTemplate.Height = 26;
            this.dgv_interLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_interLicenses.Tag = "";
            this.dgv_interLicenses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_interLicenses_CellDoubleClick);
            this.dgv_interLicenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Licenses_CellFormatting);
            // 
            // label5
            // 
            resources.ApplyResources(this.lbl_allInterLicenses, "label5");
            this.lbl_allInterLicenses.Name = "label5";
            // 
            // Layout_ShowAllLicenses
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_ShowAllLicenses";
            this.Load += new System.EventHandler(this.Layout_ShowAllLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localLicenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Manina.Windows.Forms.TabControl tabControl1;
        private Manina.Windows.Forms.Tab tabPage1;
        private Manina.Windows.Forms.Tab tabPage2;
        private System.Windows.Forms.Label lbl_allLocalLicenses;
        private System.Windows.Forms.DataGridView dgv_localLicenses;
        private Salem.Controls.SalSelectableLabel lbl_localNumOfRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ll_localRefreshData;
        private System.Windows.Forms.Label lbl_localNoDataAvailable;
        private System.Windows.Forms.Label lbl_interNoDataAvailable;
        private Salem.Controls.SalSelectableLabel lbl_interNumOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ll_interRefreshData;
        private System.Windows.Forms.DataGridView dgv_interLicenses;
        private System.Windows.Forms.Label lbl_allInterLicenses;
        private System.Windows.Forms.LinkLabel ll_newLocalApplication;
        private System.Windows.Forms.LinkLabel ll_newInterApplication;
        private System.Windows.Forms.DataGridViewImageColumn IsDetainedImage;
        private System.Windows.Forms.LinkLabel ll_localExportData;
        private System.Windows.Forms.LinkLabel ll_interExportData;
    }
}
