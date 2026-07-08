namespace DVLD.Tests.Controls {
    partial class Ctrl_PersonTestsHistoryCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_PersonTestsHistoryCard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new Manina.Windows.Forms.TabControl();
            this.tp_visionTests = new Manina.Windows.Forms.Tab();
            this.ll_visionExportData = new System.Windows.Forms.LinkLabel();
            this.lbl_visionNoDataAvailable = new System.Windows.Forms.Label();
            this.lbl_visionNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.ll_visionRefreshData = new System.Windows.Forms.LinkLabel();
            this.lbl_visionTestAppoints = new System.Windows.Forms.Label();
            this.dgv_visionHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTest_seeTestResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_writtenTests = new Manina.Windows.Forms.Tab();
            this.ll_writtenExportData = new System.Windows.Forms.LinkLabel();
            this.lbl_writtenNoDataAvailable = new System.Windows.Forms.Label();
            this.lbl_writtenNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ll_writtenRefreshData = new System.Windows.Forms.LinkLabel();
            this.lbl_writtenTestAppoints = new System.Windows.Forms.Label();
            this.dgv_writtenHistory = new System.Windows.Forms.DataGridView();
            this.tp_drivingTests = new Manina.Windows.Forms.Tab();
            this.ll_drivingExportData = new System.Windows.Forms.LinkLabel();
            this.lbl_drivingNoDataAvailable = new System.Windows.Forms.Label();
            this.lbl_drivingNumOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ll_drivingRefreshData = new System.Windows.Forms.LinkLabel();
            this.lbl_drivingTestAppoints = new System.Windows.Forms.Label();
            this.dgv_drivingHistory = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_visionTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visionHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tp_writtenTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_writtenHistory)).BeginInit();
            this.tp_drivingTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_visionTests);
            this.tabControl1.Controls.Add(this.tp_writtenTests);
            this.tabControl1.Controls.Add(this.tp_drivingTests);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Tabs.Add(this.tp_visionTests);
            this.tabControl1.Tabs.Add(this.tp_writtenTests);
            this.tabControl1.Tabs.Add(this.tp_drivingTests);
            // 
            // tp_visionTests
            // 
            this.tp_visionTests.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tp_visionTests.Controls.Add(this.ll_visionExportData);
            this.tp_visionTests.Controls.Add(this.lbl_visionNoDataAvailable);
            this.tp_visionTests.Controls.Add(this.lbl_visionNumOfRecords);
            this.tp_visionTests.Controls.Add(this.label6);
            this.tp_visionTests.Controls.Add(this.ll_visionRefreshData);
            this.tp_visionTests.Controls.Add(this.lbl_visionTestAppoints);
            this.tp_visionTests.Controls.Add(this.dgv_visionHistory);
            this.tp_visionTests.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tp_visionTests, "tp_visionTests");
            this.tp_visionTests.Name = "tp_visionTests";
            // 
            // ll_visionExportData
            // 
            resources.ApplyResources(this.ll_visionExportData, "ll_visionExportData");
            this.ll_visionExportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_visionExportData.ForeColor = System.Drawing.Color.Blue;
            this.ll_visionExportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_visionExportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_visionExportData.Name = "ll_visionExportData";
            this.ll_visionExportData.TabStop = true;
            this.ll_visionExportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_visionExportData_LinkClicked);
            // 
            // lbl_visionNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_visionNoDataAvailable, "lbl_visionNoDataAvailable");
            this.lbl_visionNoDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_visionNoDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_visionNoDataAvailable.Name = "lbl_visionNoDataAvailable";
            // 
            // lbl_visionNumOfRecords
            // 
            resources.ApplyResources(this.lbl_visionNumOfRecords, "lbl_visionNumOfRecords");
            this.lbl_visionNumOfRecords.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.lbl_visionNumOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_visionNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_visionNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_visionNumOfRecords.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_visionNumOfRecords.Name = "lbl_visionNumOfRecords";
            this.lbl_visionNumOfRecords.ReadOnly = true;
            this.lbl_visionNumOfRecords.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ll_visionRefreshData
            // 
            resources.ApplyResources(this.ll_visionRefreshData, "ll_visionRefreshData");
            this.ll_visionRefreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_visionRefreshData.ForeColor = System.Drawing.Color.Blue;
            this.ll_visionRefreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_visionRefreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_visionRefreshData.Name = "ll_visionRefreshData";
            this.ll_visionRefreshData.TabStop = true;
            this.ll_visionRefreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_visionRefreshData_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.lbl_visionTestAppoints, "label4");
            this.lbl_visionTestAppoints.Name = "label4";
            // 
            // dgv_visionHistory
            // 
            this.dgv_visionHistory.AllowUserToAddRows = false;
            this.dgv_visionHistory.AllowUserToDeleteRows = false;
            this.dgv_visionHistory.AllowUserToOrderColumns = true;
            this.dgv_visionHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_visionHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_visionHistory, "dgv_visionHistory");
            this.dgv_visionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_visionHistory.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_visionHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_visionHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_visionHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_visionHistory.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "[???]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_visionHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_visionHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_visionHistory.EnableHeadersVisualStyles = false;
            this.dgv_visionHistory.MultiSelect = false;
            this.dgv_visionHistory.Name = "dgv_visionHistory";
            this.dgv_visionHistory.ReadOnly = true;
            this.dgv_visionHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_visionHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_visionHistory.RowTemplate.Height = 26;
            this.dgv_visionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_visionHistory.Tag = "";
            this.dgv_visionHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_visionHistory_CellDoubleClick);
            this.dgv_visionHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTest_seeTestResultToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTest_seeTestResultToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            resources.ApplyResources(this.takeTest_seeTestResultToolStripMenuItem, "takeTestToolStripMenuItem");
            this.takeTest_seeTestResultToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTest_seeTestResultToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // tp_writtenTests
            // 
            this.tp_writtenTests.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tp_writtenTests.Controls.Add(this.ll_writtenExportData);
            this.tp_writtenTests.Controls.Add(this.lbl_writtenNoDataAvailable);
            this.tp_writtenTests.Controls.Add(this.lbl_writtenNumOfRecords);
            this.tp_writtenTests.Controls.Add(this.label2);
            this.tp_writtenTests.Controls.Add(this.ll_writtenRefreshData);
            this.tp_writtenTests.Controls.Add(this.lbl_writtenTestAppoints);
            this.tp_writtenTests.Controls.Add(this.dgv_writtenHistory);
            this.tp_writtenTests.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tp_writtenTests, "tp_writtenTests");
            this.tp_writtenTests.Name = "tp_writtenTests";
            // 
            // ll_writtenExportData
            // 
            resources.ApplyResources(this.ll_writtenExportData, "ll_writtenExportData");
            this.ll_writtenExportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_writtenExportData.ForeColor = System.Drawing.Color.Blue;
            this.ll_writtenExportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_writtenExportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_writtenExportData.Name = "ll_writtenExportData";
            this.ll_writtenExportData.TabStop = true;
            this.ll_writtenExportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_writtenExportData_LinkClicked);
            // 
            // lbl_writtenNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_writtenNoDataAvailable, "lbl_writtenNoDataAvailable");
            this.lbl_writtenNoDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_writtenNoDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_writtenNoDataAvailable.Name = "lbl_writtenNoDataAvailable";
            // 
            // lbl_writtenNumOfRecords
            // 
            resources.ApplyResources(this.lbl_writtenNumOfRecords, "lbl_writtenNumOfRecords");
            this.lbl_writtenNumOfRecords.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.lbl_writtenNumOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_writtenNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_writtenNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_writtenNumOfRecords.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_writtenNumOfRecords.Name = "lbl_writtenNumOfRecords";
            this.lbl_writtenNumOfRecords.ReadOnly = true;
            this.lbl_writtenNumOfRecords.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ll_writtenRefreshData
            // 
            resources.ApplyResources(this.ll_writtenRefreshData, "ll_writtenRefreshData");
            this.ll_writtenRefreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_writtenRefreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_writtenRefreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_writtenRefreshData.Name = "ll_writtenRefreshData";
            this.ll_writtenRefreshData.TabStop = true;
            this.ll_writtenRefreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_writtenRefreshData_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.lbl_writtenTestAppoints, "label3");
            this.lbl_writtenTestAppoints.Name = "label3";
            // 
            // dgv_writtenHistory
            // 
            this.dgv_writtenHistory.AllowUserToAddRows = false;
            this.dgv_writtenHistory.AllowUserToDeleteRows = false;
            this.dgv_writtenHistory.AllowUserToOrderColumns = true;
            this.dgv_writtenHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_writtenHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.dgv_writtenHistory, "dgv_writtenHistory");
            this.dgv_writtenHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_writtenHistory.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_writtenHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_writtenHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_writtenHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_writtenHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_writtenHistory.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.NullValue = "[???]";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_writtenHistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_writtenHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_writtenHistory.EnableHeadersVisualStyles = false;
            this.dgv_writtenHistory.MultiSelect = false;
            this.dgv_writtenHistory.Name = "dgv_writtenHistory";
            this.dgv_writtenHistory.ReadOnly = true;
            this.dgv_writtenHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_writtenHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_writtenHistory.RowTemplate.Height = 26;
            this.dgv_writtenHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_writtenHistory.Tag = "";
            this.dgv_writtenHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_writtenHistory_CellDoubleClick);
            this.dgv_writtenHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // tp_drivingTests
            // 
            this.tp_drivingTests.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.tp_drivingTests.Controls.Add(this.ll_drivingExportData);
            this.tp_drivingTests.Controls.Add(this.lbl_drivingNoDataAvailable);
            this.tp_drivingTests.Controls.Add(this.lbl_drivingNumOfRecords);
            this.tp_drivingTests.Controls.Add(this.label5);
            this.tp_drivingTests.Controls.Add(this.ll_drivingRefreshData);
            this.tp_drivingTests.Controls.Add(this.lbl_drivingTestAppoints);
            this.tp_drivingTests.Controls.Add(this.dgv_drivingHistory);
            this.tp_drivingTests.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.tp_drivingTests, "tp_drivingTests");
            this.tp_drivingTests.Name = "tp_drivingTests";
            // 
            // ll_drivingExportData
            // 
            resources.ApplyResources(this.ll_drivingExportData, "ll_drivingExportData");
            this.ll_drivingExportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_drivingExportData.ForeColor = System.Drawing.Color.Blue;
            this.ll_drivingExportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_drivingExportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_drivingExportData.Name = "ll_drivingExportData";
            this.ll_drivingExportData.TabStop = true;
            this.ll_drivingExportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_drivingExportData_LinkClicked);
            // 
            // lbl_drivingNoDataAvailable
            // 
            resources.ApplyResources(this.lbl_drivingNoDataAvailable, "lbl_drivingNoDataAvailable");
            this.lbl_drivingNoDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_drivingNoDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_drivingNoDataAvailable.Name = "lbl_drivingNoDataAvailable";
            // 
            // lbl_drivingNumOfRecords
            // 
            resources.ApplyResources(this.lbl_drivingNumOfRecords, "lbl_drivingNumOfRecords");
            this.lbl_drivingNumOfRecords.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.lbl_drivingNumOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_drivingNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_drivingNumOfRecords.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_drivingNumOfRecords.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.lbl_drivingNumOfRecords.Name = "lbl_drivingNumOfRecords";
            this.lbl_drivingNumOfRecords.ReadOnly = true;
            this.lbl_drivingNumOfRecords.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ll_drivingRefreshData
            // 
            resources.ApplyResources(this.ll_drivingRefreshData, "ll_drivingRefreshData");
            this.ll_drivingRefreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_drivingRefreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_drivingRefreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_drivingRefreshData.Name = "ll_drivingRefreshData";
            this.ll_drivingRefreshData.TabStop = true;
            this.ll_drivingRefreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_drivingRefreshData_LinkClicked);
            // 
            // label7
            // 
            resources.ApplyResources(this.lbl_drivingTestAppoints, "label7");
            this.lbl_drivingTestAppoints.Name = "label7";
            // 
            // dgv_drivingHistory
            // 
            this.dgv_drivingHistory.AllowUserToAddRows = false;
            this.dgv_drivingHistory.AllowUserToDeleteRows = false;
            this.dgv_drivingHistory.AllowUserToOrderColumns = true;
            this.dgv_drivingHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_drivingHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.dgv_drivingHistory, "dgv_drivingHistory");
            this.dgv_drivingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_drivingHistory.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_drivingHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_drivingHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_drivingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_drivingHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_drivingHistory.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.NullValue = "[???]";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_drivingHistory.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_drivingHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_drivingHistory.EnableHeadersVisualStyles = false;
            this.dgv_drivingHistory.MultiSelect = false;
            this.dgv_drivingHistory.Name = "dgv_drivingHistory";
            this.dgv_drivingHistory.ReadOnly = true;
            this.dgv_drivingHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_drivingHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_drivingHistory.RowTemplate.Height = 26;
            this.dgv_drivingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_drivingHistory.Tag = "";
            this.dgv_drivingHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_drivingHistory_CellDoubleClick);
            this.dgv_drivingHistory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // Ctrl_PersonTestsHistoryCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_PersonTestsHistoryCard";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_visionTests.ResumeLayout(false);
            this.tp_visionTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visionHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tp_writtenTests.ResumeLayout(false);
            this.tp_writtenTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_writtenHistory)).EndInit();
            this.tp_drivingTests.ResumeLayout(false);
            this.tp_drivingTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_drivingHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Manina.Windows.Forms.TabControl tabControl1;
        private Manina.Windows.Forms.Tab tp_visionTests;
        private System.Windows.Forms.Label lbl_visionNoDataAvailable;
        private Salem.Controls.SalSelectableLabel lbl_visionNumOfRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ll_visionRefreshData;
        private System.Windows.Forms.Label lbl_visionTestAppoints;
        private System.Windows.Forms.DataGridView dgv_visionHistory;
        private Manina.Windows.Forms.Tab tp_writtenTests;
        private System.Windows.Forms.Label lbl_writtenNoDataAvailable;
        private Salem.Controls.SalSelectableLabel lbl_writtenNumOfRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ll_writtenRefreshData;
        private System.Windows.Forms.Label lbl_writtenTestAppoints;
        private System.Windows.Forms.DataGridView dgv_writtenHistory;
        private Manina.Windows.Forms.Tab tp_drivingTests;
        private System.Windows.Forms.Label lbl_drivingNoDataAvailable;
        private Salem.Controls.SalSelectableLabel lbl_drivingNumOfRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel ll_drivingRefreshData;
        private System.Windows.Forms.Label lbl_drivingTestAppoints;
        private System.Windows.Forms.DataGridView dgv_drivingHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTest_seeTestResultToolStripMenuItem;
        private System.Windows.Forms.LinkLabel ll_visionExportData;
        private System.Windows.Forms.LinkLabel ll_writtenExportData;
        private System.Windows.Forms.LinkLabel ll_drivingExportData;
    }
}
