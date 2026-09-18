namespace DVLD.Applications.International_Driving_License {
    partial class Layout_ManageInternationalDrivingLicenseApps {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_ManageInternationalDrivingLicenseApps));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_filterBy = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addNewInterDrivingLicenseApp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.cb_inputFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_interDrivingLicenseApps = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDriverDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDriverLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.cb_filterBy = new Salem.Controls.SalDropDownList();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interDrivingLicenseApps)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::DVLD.Properties.Resources.International_64;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lbl_filterBy
            // 
            resources.ApplyResources(this.lbl_filterBy, "lbl_filterBy");
            this.lbl_filterBy.Name = "lbl_filterBy";
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
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Local_Driving_License_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_addNewLocalDrivingLicenseApp
            // 
            resources.ApplyResources(this.btn_addNewInterDrivingLicenseApp, "btn_addNewLocalDrivingLicenseApp");
            this.btn_addNewInterDrivingLicenseApp.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_addNewInterDrivingLicenseApp.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_addNewInterDrivingLicenseApp.Image = global::DVLD.Properties.Resources.New_Application_40;
            this.btn_addNewInterDrivingLicenseApp.Name = "btn_addNewLocalDrivingLicenseApp";
            this.toolTip1.SetToolTip(this.btn_addNewInterDrivingLicenseApp, resources.GetString("btn_addNewLocalDrivingLicenseApp.ToolTip"));
            this.btn_addNewInterDrivingLicenseApp.UseCompatibleTextRendering = true;
            this.btn_addNewInterDrivingLicenseApp.UseVisualStyleBackColor = false;
            this.btn_addNewInterDrivingLicenseApp.Click += new System.EventHandler(this.btn_addNewLocalDrivingLicenseApp_Click);
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
            // cb_inputFilterBy
            // 
            this.cb_inputFilterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_inputFilterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_inputFilterBy.FormattingEnabled = true;
            this.cb_inputFilterBy.Items.AddRange(new object[] {
            resources.GetString("cb_inputFilterBy.Items"),
            resources.GetString("cb_inputFilterBy.Items1"),
            resources.GetString("cb_inputFilterBy.Items2")});
            resources.ApplyResources(this.cb_inputFilterBy, "cb_inputFilterBy");
            this.cb_inputFilterBy.Name = "cb_inputFilterBy";
            this.cb_inputFilterBy.TextChanged += new System.EventHandler(this.comboBox_inputFilterBy_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dgv_interDrivingLicenseApps
            // 
            this.dgv_interDrivingLicenseApps.AllowUserToAddRows = false;
            this.dgv_interDrivingLicenseApps.AllowUserToDeleteRows = false;
            this.dgv_interDrivingLicenseApps.AllowUserToOrderColumns = true;
            this.dgv_interDrivingLicenseApps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_interDrivingLicenseApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_interDrivingLicenseApps, "dgv_interDrivingLicenseApps");
            this.dgv_interDrivingLicenseApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_interDrivingLicenseApps.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_interDrivingLicenseApps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_interDrivingLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_interDrivingLicenseApps.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_interDrivingLicenseApps.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "[???]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_interDrivingLicenseApps.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_interDrivingLicenseApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_interDrivingLicenseApps.EnableHeadersVisualStyles = false;
            this.dgv_interDrivingLicenseApps.MultiSelect = false;
            this.dgv_interDrivingLicenseApps.Name = "dgv_interDrivingLicenseApps";
            this.dgv_interDrivingLicenseApps.ReadOnly = true;
            this.dgv_interDrivingLicenseApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_interDrivingLicenseApps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_interDrivingLicenseApps.RowTemplate.Height = 26;
            this.dgv_interDrivingLicenseApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_interDrivingLicenseApps.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_interDrivingLicenseApps_CellDoubleClick);
            this.dgv_interDrivingLicenseApps.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_interDrivingLicenseApps_CellFormatting);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.contextMenuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDriverDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showDriverLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showDriverDetailsToolStripMenuItem
            // 
            this.showDriverDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            resources.ApplyResources(this.showDriverDetailsToolStripMenuItem, "showDriverDetailsToolStripMenuItem");
            this.showDriverDetailsToolStripMenuItem.Name = "showDriverDetailsToolStripMenuItem";
            this.showDriverDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDriverDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            resources.ApplyResources(this.showLicenseDetailsToolStripMenuItem, "showLicenseDetailsToolStripMenuItem");
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showDriverLicenseHistoryToolStripMenuItem
            // 
            this.showDriverLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            resources.ApplyResources(this.showDriverLicenseHistoryToolStripMenuItem, "showDriverLicenseHistoryToolStripMenuItem");
            this.showDriverLicenseHistoryToolStripMenuItem.Name = "showDriverLicenseHistoryToolStripMenuItem";
            this.showDriverLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showDriverLicenseHistoryToolStripMenuItem_Click);
            // 
            // ll_refreshData
            // 
            resources.ApplyResources(this.ll_refreshData, "ll_refreshData");
            this.ll_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_refreshData.Name = "ll_refreshData";
            this.ll_refreshData.TabStop = true;
            this.ll_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refreshData_LinkClicked);
            // 
            // lbl_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "lbl_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "lbl_noDataAvailable";
            // 
            // cb_filterBy
            // 
            this.cb_filterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_filterBy.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            resources.ApplyResources(this.cb_filterBy, "cb_filterBy");
            this.cb_filterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.Items.AddRange(new object[] {
            resources.GetString("cb_filterBy.Items"),
            resources.GetString("cb_filterBy.Items1"),
            resources.GetString("cb_filterBy.Items2"),
            resources.GetString("cb_filterBy.Items3"),
            resources.GetString("cb_filterBy.Items4"),
            resources.GetString("cb_filterBy.Items5"),
            resources.GetString("cb_filterBy.Items6"),
            resources.GetString("cb_filterBy.Items7")});
            this.cb_filterBy.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_filterBy.Name = "cb_filterBy";
            this.cb_filterBy.SelectedIndex = -1;
            this.cb_filterBy.TabStop = false;
            this.cb_filterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterBy_SelectedIndexChanged);
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
            // 
            // Layout_ManageInternationalDrivingLicenseApps
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.ll_refreshData);
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_filterBy);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addNewInterDrivingLicenseApp);
            this.Controls.Add(this.cb_inputFilterBy);
            this.Controls.Add(this.cb_filterBy);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.dgv_interDrivingLicenseApps);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_ManageInternationalDrivingLicenseApps";
            this.Load += new System.EventHandler(this.Layout_ManageInternationalDrivingLicenseApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_interDrivingLicenseApps)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_filterBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addNewInterDrivingLicenseApp;
        private System.Windows.Forms.ComboBox cb_inputFilterBy;
        private Salem.Controls.SalDropDownList cb_filterBy;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_interDrivingLicenseApps;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.LinkLabel ll_refreshData;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.ToolStripMenuItem showDriverDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDriverLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.LinkLabel ll_exportData;
    }
}
