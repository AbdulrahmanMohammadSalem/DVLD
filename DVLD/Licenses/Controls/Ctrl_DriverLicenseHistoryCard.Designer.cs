namespace DVLD.Licenses.Controls {
    partial class Ctrl_DriverLicenseHistoryCard {
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
                DVLD.Properties.Settings.Default.SettingsSaving -= Default_SettingsSaving;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_DriverLicenseHistoryCard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new Manina.Windows.Forms.TabControl();
            this.tb_local = new Manina.Windows.Forms.Tab();
            this.ll_localExportData = new System.Windows.Forms.LinkLabel();
            this.lbl_localNoDataAvailable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ll_localRefreshData = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_localHistory = new System.Windows.Forms.DataGridView();
            this.cms_local = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLocalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.renewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueReplacementForLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_localNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.tb_inter = new Manina.Windows.Forms.Tab();
            this.ll_interExportData = new System.Windows.Forms.LinkLabel();
            this.lbl_interNoDataAvailable = new System.Windows.Forms.Label();
            this.lbl_interNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ll_interRefreshData = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_interHistory = new System.Windows.Forms.DataGridView();
            this.cms_inter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInterLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tb_local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localHistory)).BeginInit();
            this.cms_local.SuspendLayout();
            this.tb_inter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interHistory)).BeginInit();
            this.cms_inter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_local);
            this.tabControl1.Controls.Add(this.tb_inter);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Tabs.Add(this.tb_local);
            this.tabControl1.Tabs.Add(this.tb_inter);
            // 
            // tp_local
            // 
            this.tb_local.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tb_local.Controls.Add(this.ll_localExportData);
            this.tb_local.Controls.Add(this.lbl_localNoDataAvailable);
            this.tb_local.Controls.Add(this.label6);
            this.tb_local.Controls.Add(this.ll_localRefreshData);
            this.tb_local.Controls.Add(this.label4);
            this.tb_local.Controls.Add(this.dgv_localHistory);
            this.tb_local.Controls.Add(this.lbl_localNumOfRecords);
            this.tb_local.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tb_local, "tp_local");
            this.tb_local.Name = "tp_local";
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
            // lbl_localNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_localNoDataAvailable, "lbl_localNoDataAvailable");
            this.lbl_localNoDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_localNoDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_localNoDataAvailable.Name = "lbl_localNoDataAvailable";
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.label4.Name = "label4";
            // 
            // dgv_localHistory
            // 
            this.dgv_localHistory.AllowUserToAddRows = false;
            this.dgv_localHistory.AllowUserToDeleteRows = false;
            this.dgv_localHistory.AllowUserToOrderColumns = true;
            this.dgv_localHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_localHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_localHistory, "dgv_localHistory");
            this.dgv_localHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_localHistory.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_localHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_localHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_localHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_localHistory.ContextMenuStrip = this.cms_local;
            this.dgv_localHistory.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "[???]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_localHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_localHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_localHistory.EnableHeadersVisualStyles = false;
            this.dgv_localHistory.MultiSelect = false;
            this.dgv_localHistory.Name = "dgv_localHistory";
            this.dgv_localHistory.ReadOnly = true;
            this.dgv_localHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_localHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_localHistory.RowTemplate.Height = 26;
            this.dgv_localHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_localHistory.Tag = "";
            this.dgv_localHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_localHistory_CellDoubleClick);
            this.dgv_localHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // cms_local
            // 
            this.cms_local.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cms_local.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cms_local.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.cms_local, "cms_local");
            this.cms_local.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cms_local.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_local.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLocalLicenseToolStripMenuItem,
            this.toolStripMenuItem2,
            this.renewLicenseToolStripMenuItem,
            this.issueReplacementForLicenseToolStripMenuItem,
            this.detainLicenseToolStripMenuItem});
            this.cms_local.Name = "contextMenuStrip1";
            this.cms_local.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms_local.Opening += new System.ComponentModel.CancelEventHandler(this.cms_local_Opening);
            // 
            // showLocalLicenseToolStripMenuItem
            // 
            this.showLocalLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            resources.ApplyResources(this.showLocalLicenseToolStripMenuItem, "showLocalLicenseToolStripMenuItem");
            this.showLocalLicenseToolStripMenuItem.Name = "showLocalLicenseToolStripMenuItem";
            this.showLocalLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLocalLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // renewLicenseToolStripMenuItem
            // 
            this.renewLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            resources.ApplyResources(this.renewLicenseToolStripMenuItem, "renewLicenseToolStripMenuItem");
            this.renewLicenseToolStripMenuItem.Name = "renewLicenseToolStripMenuItem";
            this.renewLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewLicenseToolStripMenuItem_Click);
            // 
            // issueReplacementForLicenseToolStripMenuItem
            // 
            this.issueReplacementForLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32;
            resources.ApplyResources(this.issueReplacementForLicenseToolStripMenuItem, "issueReplacementForLicenseToolStripMenuItem");
            this.issueReplacementForLicenseToolStripMenuItem.Name = "issueReplacementForLicenseToolStripMenuItem";
            this.issueReplacementForLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueReplacementForLicenseToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_32;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            resources.ApplyResources(this.detainLicenseToolStripMenuItem, "detainLicenseToolStripMenuItem");
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
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
            // tp_international
            // 
            this.tb_inter.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tb_inter.Controls.Add(this.ll_interExportData);
            this.tb_inter.Controls.Add(this.lbl_interNoDataAvailable);
            this.tb_inter.Controls.Add(this.lbl_interNumOfRecords);
            this.tb_inter.Controls.Add(this.label2);
            this.tb_inter.Controls.Add(this.ll_interRefreshData);
            this.tb_inter.Controls.Add(this.label3);
            this.tb_inter.Controls.Add(this.dgv_interHistory);
            this.tb_inter.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tb_inter, "tp_international");
            this.tb_inter.Name = "tp_international";
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
            // lbl_interNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_interNoDataAvailable, "lbl_interNoDataAvailable");
            this.lbl_interNoDataAvailable.BackColor = System.Drawing.SystemColors.Control;
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.label3.Name = "label3";
            // 
            // dgv_interHistory
            // 
            this.dgv_interHistory.AllowUserToAddRows = false;
            this.dgv_interHistory.AllowUserToDeleteRows = false;
            this.dgv_interHistory.AllowUserToOrderColumns = true;
            this.dgv_interHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_interHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.dgv_interHistory, "dgv_interHistory");
            this.dgv_interHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_interHistory.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_interHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_interHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_interHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_interHistory.ContextMenuStrip = this.cms_inter;
            this.dgv_interHistory.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = "[???]";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_interHistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_interHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_interHistory.EnableHeadersVisualStyles = false;
            this.dgv_interHistory.MultiSelect = false;
            this.dgv_interHistory.Name = "dgv_interHistory";
            this.dgv_interHistory.ReadOnly = true;
            this.dgv_interHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_interHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_interHistory.RowTemplate.Height = 26;
            this.dgv_interHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_interHistory.Tag = "";
            this.dgv_interHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_interHistory_CellDoubleClick);
            this.dgv_interHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // cms_inter
            // 
            this.cms_inter.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cms_inter.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cms_inter.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.cms_inter, "cms_inter");
            this.cms_inter.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cms_inter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_inter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInterLicenseToolStripMenuItem1});
            this.cms_inter.Name = "contextMenuStrip1";
            this.cms_inter.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cms_inter.Opening += new System.ComponentModel.CancelEventHandler(this.cms_inter_Opening);
            // 
            // showInterLicenseToolStripMenuItem1
            // 
            this.showInterLicenseToolStripMenuItem1.Image = global::DVLD.Properties.Resources.License_View_32;
            resources.ApplyResources(this.showInterLicenseToolStripMenuItem1, "showInterLicenseToolStripMenuItem1");
            this.showInterLicenseToolStripMenuItem1.Name = "showInterLicenseToolStripMenuItem1";
            this.showInterLicenseToolStripMenuItem1.Click += new System.EventHandler(this.showInterLicenseToolStripMenuItem1_Click);
            // 
            // Ctrl_DriverLicenseHistoryCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_DriverLicenseHistoryCard";
            this.Load += new System.EventHandler(this.Ctrl_DriverLicenseHistoryCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tb_local.ResumeLayout(false);
            this.tb_local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_localHistory)).EndInit();
            this.cms_local.ResumeLayout(false);
            this.tb_inter.ResumeLayout(false);
            this.tb_inter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interHistory)).EndInit();
            this.cms_inter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Manina.Windows.Forms.TabControl tabControl1;
        private Manina.Windows.Forms.Tab tb_local;
        private System.Windows.Forms.Label lbl_localNoDataAvailable;
        private Salem.Controls.SalSelectableLabel lbl_localNumOfRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ll_localRefreshData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_localHistory;
        private Manina.Windows.Forms.Tab tb_inter;
        private System.Windows.Forms.Label lbl_interNoDataAvailable;
        private Salem.Controls.SalSelectableLabel lbl_interNumOfRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ll_interRefreshData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_interHistory;
        private System.Windows.Forms.ContextMenuStrip cms_local;
        private System.Windows.Forms.ToolStripMenuItem showLocalLicenseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_inter;
        private System.Windows.Forms.ToolStripMenuItem showInterLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renewLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueReplacementForLicenseToolStripMenuItem;
        private System.Windows.Forms.LinkLabel ll_localExportData;
        private System.Windows.Forms.LinkLabel ll_interExportData;
    }
}
