namespace DVLD.Detain_Licenses.Layouts {
    partial class Layout_ManageDetainedLicenses {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_ManageDetainedLicenses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.btn_detain = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_release = new System.Windows.Forms.Button();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDriverDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDriverLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetailedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_detainedLicenses = new System.Windows.Forms.DataGridView();
            this.lbl_filterBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_filterInput = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cb_isReleased = new Salem.Controls.SalDropDownList();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.cb_filterBy = new Salem.Controls.SalDropDownList();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "label_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "label_noDataAvailable";
            this.toolTip1.SetToolTip(this.lbl_noDataAvailable, resources.GetString("label_noDataAvailable.ToolTip"));
            // 
            // linkLabel_refreshData
            // 
            resources.ApplyResources(this.ll_refreshData, "linkLabel_refreshData");
            this.ll_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_refreshData.Name = "linkLabel_refreshData";
            this.ll_refreshData.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_refreshData, resources.GetString("linkLabel_refreshData.ToolTip"));
            this.ll_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refreshData_LinkClicked);
            // 
            // btn_detain
            // 
            resources.ApplyResources(this.btn_detain, "btn_detain");
            this.btn_detain.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_detain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_detain.Image = global::DVLD.Properties.Resources.Detain_32;
            this.btn_detain.Name = "btn_detain";
            this.toolTip1.SetToolTip(this.btn_detain, resources.GetString("btn_detain.ToolTip"));
            this.btn_detain.UseCompatibleTextRendering = true;
            this.btn_detain.UseVisualStyleBackColor = false;
            this.btn_detain.Click += new System.EventHandler(this.btn_detainLicense_Click);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Name = "btn_close";
            this.toolTip1.SetToolTip(this.btn_close, resources.GetString("btn_close.ToolTip"));
            this.btn_close.UseCompatibleTextRendering = true;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_release
            // 
            resources.ApplyResources(this.btn_release, "btn_release");
            this.btn_release.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_release.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_release.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.btn_release.Name = "btn_release";
            this.toolTip1.SetToolTip(this.btn_release, resources.GetString("btn_release.ToolTip"));
            this.btn_release.UseCompatibleTextRendering = true;
            this.btn_release.UseVisualStyleBackColor = false;
            this.btn_release.Click += new System.EventHandler(this.btn_releaseDetainedLicense_Click);
            // 
            // ll_exportData
            // 
            resources.ApplyResources(this.ll_exportData, "ll_exportData");
            this.ll_exportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_exportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_exportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_exportData.Name = "ll_exportData";
            this.ll_exportData.TabStop = true;
            this.toolTip1.SetToolTip(this.ll_exportData, resources.GetString("ll_exportData.ToolTip"));
            this.ll_exportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_exportData_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDriverDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showDriverLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseDetailedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolTip1.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showDriverDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.showDriverDetailsToolStripMenuItem, "showDriverDetailsToolStripMenuItem");
            this.showDriverDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDriverDetailsToolStripMenuItem.Name = "showDriverDetailsToolStripMenuItem";
            this.showDriverDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDriverDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.showLicenseDetailsToolStripMenuItem, "showLicenseDetailsToolStripMenuItem");
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showDriverLicenseHistoryToolStripMenuItem
            // 
            resources.ApplyResources(this.showDriverLicenseHistoryToolStripMenuItem, "showDriverLicenseHistoryToolStripMenuItem");
            this.showDriverLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showDriverLicenseHistoryToolStripMenuItem.Name = "showDriverLicenseHistoryToolStripMenuItem";
            this.showDriverLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showDriverLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // releaseDetailedLicenseToolStripMenuItem
            // 
            resources.ApplyResources(this.releaseDetailedLicenseToolStripMenuItem, "releaseDetailedLicenseToolStripMenuItem");
            this.releaseDetailedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.releaseDetailedLicenseToolStripMenuItem.Name = "releaseDetailedLicenseToolStripMenuItem";
            this.releaseDetailedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetailedLicenseToolStripMenuItem_Click);
            // 
            // dgv_detainedLicenses
            // 
            resources.ApplyResources(this.dgv_detainedLicenses, "dgv_detainedLicenses");
            this.dgv_detainedLicenses.AllowUserToAddRows = false;
            this.dgv_detainedLicenses.AllowUserToDeleteRows = false;
            this.dgv_detainedLicenses.AllowUserToOrderColumns = true;
            this.dgv_detainedLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_detainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detainedLicenses.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_detainedLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_detainedLicenses.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_detainedLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_detainedLicenses.EnableHeadersVisualStyles = false;
            this.dgv_detainedLicenses.MultiSelect = false;
            this.dgv_detainedLicenses.Name = "dgv_detainedLicenses";
            this.dgv_detainedLicenses.ReadOnly = true;
            this.dgv_detainedLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_detainedLicenses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_detainedLicenses.RowTemplate.Height = 26;
            this.dgv_detainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgv_detainedLicenses, resources.GetString("dgv_detainedLicenses.ToolTip"));
            this.dgv_detainedLicenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_detainedLicenses_CellFormatting);
            // 
            // label2
            // 
            resources.ApplyResources(this.lbl_filterBy, "label2");
            this.lbl_filterBy.Name = "label2";
            this.toolTip1.SetToolTip(this.lbl_filterBy, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Detain_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // txt_filterInput
            // 
            resources.ApplyResources(this.txt_filterInput, "txt_filterInput");
            this.txt_filterInput.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_filterInput.BeforeTouchSize = new System.Drawing.Size(170, 26);
            this.txt_filterInput.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_filterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_filterInput.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.txt_filterInput.Name = "txt_filterInput";
            this.toolTip1.SetToolTip(this.txt_filterInput, resources.GetString("txt_filterInput.ToolTip"));
            this.txt_filterInput.TextChanged += new System.EventHandler(this.txt_filterInput_TextChanged);
            // 
            // cb_isReleased
            // 
            resources.ApplyResources(this.cb_isReleased, "cb_isReleased");
            this.cb_isReleased.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_isReleased.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_isReleased.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_isReleased.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_isReleased.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_isReleased.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_isReleased.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_isReleased.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_isReleased.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_isReleased.Items.AddRange(new object[] {
            resources.GetString("cb_isReleased.Items"),
            resources.GetString("cb_isReleased.Items1"),
            resources.GetString("cb_isReleased.Items2")});
            this.cb_isReleased.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_isReleased.Name = "cb_isReleased";
            this.cb_isReleased.SelectedIndex = -1;
            this.cb_isReleased.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_isReleased, resources.GetString("cb_isReleased.ToolTip"));
            this.cb_isReleased.SelectedIndexChanged += new System.EventHandler(this.cb_isReleased_SelectedIndexChanged);
            // 
            // label_numOfRecords
            // 
            resources.ApplyResources(this.label_numOfRecords, "label_numOfRecords");
            this.label_numOfRecords.BackColor = System.Drawing.SystemColors.Control;
            this.label_numOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_numOfRecords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_numOfRecords.Name = "label_numOfRecords";
            this.label_numOfRecords.ReadOnly = true;
            this.label_numOfRecords.TabStop = false;
            this.toolTip1.SetToolTip(this.label_numOfRecords, resources.GetString("label_numOfRecords.ToolTip"));
            // 
            // comboBox_filterBy
            // 
            resources.ApplyResources(this.cb_filterBy, "comboBox_filterBy");
            this.cb_filterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_filterBy.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.Items.AddRange(new object[] {
            resources.GetString("comboBox_filterBy.Items"),
            resources.GetString("comboBox_filterBy.Items1"),
            resources.GetString("comboBox_filterBy.Items2"),
            resources.GetString("comboBox_filterBy.Items3"),
            resources.GetString("comboBox_filterBy.Items4"),
            resources.GetString("comboBox_filterBy.Items5"),
            resources.GetString("comboBox_filterBy.Items6"),
            resources.GetString("comboBox_filterBy.Items7"),
            resources.GetString("comboBox_filterBy.Items8"),
            resources.GetString("comboBox_filterBy.Items9")});
            this.cb_filterBy.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_filterBy.Name = "comboBox_filterBy";
            this.cb_filterBy.SelectedIndex = 0;
            this.cb_filterBy.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_filterBy, resources.GetString("comboBox_filterBy.ToolTip"));
            this.cb_filterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterBy_SelectedIndexChanged);
            // 
            // Layout_ManageDetainedLicenses
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.btn_release);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.btn_detain);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_detainedLicenses);
            this.Controls.Add(this.cb_filterBy);
            this.Controls.Add(this.lbl_filterBy);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_isReleased);
            this.Controls.Add(this.txt_filterInput);
            this.Controls.Add(this.ll_refreshData);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_ManageDetainedLicenses";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Layout_ManageDetainedLicenses_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_filterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.LinkLabel ll_refreshData;
        private System.Windows.Forms.Button btn_detain;
        private System.Windows.Forms.ToolTip toolTip1;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgv_detainedLicenses;
        private Salem.Controls.SalDropDownList cb_filterBy;
        private System.Windows.Forms.Label lbl_filterBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_release;
        private Salem.Controls.SalDropDownList cb_isReleased;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_filterInput;
        private System.Windows.Forms.ToolStripMenuItem showDriverDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDriverLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetailedLicenseToolStripMenuItem;
        private System.Windows.Forms.LinkLabel ll_exportData;
    }
}
