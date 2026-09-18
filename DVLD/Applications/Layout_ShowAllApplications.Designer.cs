namespace DVLD.Applications {
    partial class Layout_ShowAllApplications {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_ShowAllApplications));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.linkLabel_refreshData = new System.Windows.Forms.LinkLabel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_applications = new System.Windows.Forms.DataGridView();
            this.cb_inputFilterBy = new System.Windows.Forms.ComboBox();
            this.cb_filterBy = new Salem.Controls.SalDropDownList();
            this.lbl_filterBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_applications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "lbl_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "lbl_noDataAvailable";
            this.toolTip1.SetToolTip(this.lbl_noDataAvailable, resources.GetString("lbl_noDataAvailable.ToolTip"));
            // 
            // linkLabel_refreshData
            // 
            resources.ApplyResources(this.linkLabel_refreshData, "linkLabel_refreshData");
            this.linkLabel_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linkLabel_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.linkLabel_refreshData.Name = "linkLabel_refreshData";
            this.linkLabel_refreshData.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel_refreshData, resources.GetString("linkLabel_refreshData.ToolTip"));
            this.linkLabel_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refreshData_LinkClicked);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // dgv_applications
            // 
            resources.ApplyResources(this.dgv_applications, "dgv_applications");
            this.dgv_applications.AllowUserToAddRows = false;
            this.dgv_applications.AllowUserToDeleteRows = false;
            this.dgv_applications.AllowUserToOrderColumns = true;
            this.dgv_applications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_applications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_applications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_applications.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_applications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_applications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_applications.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_applications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_applications.EnableHeadersVisualStyles = false;
            this.dgv_applications.MultiSelect = false;
            this.dgv_applications.Name = "dgv_applications";
            this.dgv_applications.ReadOnly = true;
            this.dgv_applications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_applications.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_applications.RowTemplate.Height = 26;
            this.dgv_applications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgv_applications, resources.GetString("dgv_applications.ToolTip"));
            this.dgv_applications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_applications_CellDoubleClick);
            this.dgv_applications.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_applications_CellFormatting);
            // 
            // cb_inputFilterBy
            // 
            resources.ApplyResources(this.cb_inputFilterBy, "cb_inputFilterBy");
            this.cb_inputFilterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_inputFilterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_inputFilterBy.FormattingEnabled = true;
            this.cb_inputFilterBy.Name = "cb_inputFilterBy";
            this.toolTip1.SetToolTip(this.cb_inputFilterBy, resources.GetString("cb_inputFilterBy.ToolTip"));
            this.cb_inputFilterBy.TextChanged += new System.EventHandler(this.comboBox_inputFilterBy_TextChanged);
            // 
            // cb_filterBy
            // 
            resources.ApplyResources(this.cb_filterBy, "cb_filterBy");
            this.cb_filterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_filterBy.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("MouseOverBackColor", global::DVLD.Properties.Settings.Default, "SurfaceHoverColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DataBindings.Add(new System.Windows.Forms.Binding("DropDownArrowColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_filterBy.DropDownArrowColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_filterBy.Items.AddRange(new object[] {
            resources.GetString("cb_filterBy.Items"),
            resources.GetString("cb_filterBy.Items1"),
            resources.GetString("cb_filterBy.Items2"),
            resources.GetString("cb_filterBy.Items3"),
            resources.GetString("cb_filterBy.Items4"),
            resources.GetString("cb_filterBy.Items5"),
            resources.GetString("cb_filterBy.Items6"),
            resources.GetString("cb_filterBy.Items7"),
            resources.GetString("cb_filterBy.Items8"),
            resources.GetString("cb_filterBy.Items9")});
            this.cb_filterBy.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_filterBy.Name = "cb_filterBy";
            this.cb_filterBy.SelectedIndex = -1;
            this.cb_filterBy.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_filterBy, resources.GetString("cb_filterBy.ToolTip"));
            this.cb_filterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterBy_SelectedIndexChanged);
            // 
            // lbl_filterBy
            // 
            resources.ApplyResources(this.lbl_filterBy, "lbl_filterBy");
            this.lbl_filterBy.Name = "lbl_filterBy";
            this.toolTip1.SetToolTip(this.lbl_filterBy, resources.GetString("lbl_filterBy.ToolTip"));
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
            this.pictureBox1.Image = global::DVLD.Properties.Resources.All_Applications_400;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
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
            // Layout_ShowAllApplications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.linkLabel_refreshData);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_applications);
            this.Controls.Add(this.cb_inputFilterBy);
            this.Controls.Add(this.cb_filterBy);
            this.Controls.Add(this.lbl_filterBy);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_ShowAllApplications";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Layout_ShowAllApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_applications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.LinkLabel linkLabel_refreshData;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_applications;
        private System.Windows.Forms.ComboBox cb_inputFilterBy;
        private Salem.Controls.SalDropDownList cb_filterBy;
        private System.Windows.Forms.Label lbl_filterBy;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel ll_exportData;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
