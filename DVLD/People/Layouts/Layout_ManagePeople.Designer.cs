using System;

namespace DVLD.People {
    partial class Layout_ManagePeople {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout_ManagePeople));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_filterBy = new System.Windows.Forms.Label();
            this.cb_filterBy = new Salem.Controls.SalDropDownList();
            this.cb_inputFilterBy = new System.Windows.Forms.ComboBox();
            this.dgv_people = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_addNewPerson = new System.Windows.Forms.Button();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_people)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
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
            // label2
            // 
            resources.ApplyResources(this.lbl_filterBy, "label2");
            this.lbl_filterBy.Name = "label2";
            this.toolTip1.SetToolTip(this.lbl_filterBy, resources.GetString("label2.ToolTip"));
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
            resources.GetString("comboBox_filterBy.Items9"),
            resources.GetString("comboBox_filterBy.Items10"),
            resources.GetString("comboBox_filterBy.Items11")});
            this.cb_filterBy.MouseOverBackColor = global::DVLD.Properties.Settings.Default.SurfaceHoverColor;
            this.cb_filterBy.Name = "comboBox_filterBy";
            this.cb_filterBy.SelectedIndex = 0;
            this.cb_filterBy.TabStop = false;
            this.toolTip1.SetToolTip(this.cb_filterBy, resources.GetString("comboBox_filterBy.ToolTip"));
            this.cb_filterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_filterBy_SelectedIndexChanged);
            // 
            // comboBox_inputFilterBy
            // 
            resources.ApplyResources(this.cb_inputFilterBy, "comboBox_inputFilterBy");
            this.cb_inputFilterBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_inputFilterBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_inputFilterBy.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_inputFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_inputFilterBy.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.cb_inputFilterBy.FormattingEnabled = true;
            this.cb_inputFilterBy.Name = "comboBox_inputFilterBy";
            this.cb_inputFilterBy.Sorted = true;
            this.toolTip1.SetToolTip(this.cb_inputFilterBy, resources.GetString("comboBox_inputFilterBy.ToolTip"));
            this.cb_inputFilterBy.TextChanged += new System.EventHandler(this.ComboBox_inputFilterBy_TextChanged);
            // 
            // dgv_people
            // 
            resources.ApplyResources(this.dgv_people, "dgv_people");
            this.dgv_people.AllowUserToAddRows = false;
            this.dgv_people.AllowUserToDeleteRows = false;
            this.dgv_people.AllowUserToOrderColumns = true;
            this.dgv_people.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_people.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_people.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_people.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_people.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_people.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_people.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_people.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dgv_people.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_people.EnableHeadersVisualStyles = false;
            this.dgv_people.MultiSelect = false;
            this.dgv_people.Name = "dgv_people";
            this.dgv_people.ReadOnly = true;
            this.dgv_people.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_people.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_people.RowTemplate.Height = 26;
            this.dgv_people.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.dgv_people, resources.GetString("dgv_people.ToolTip"));
            this.dgv_people.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayPeopleData_CellDoubleClick);
            this.dgv_people.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_people_CellFormatting);
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
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem,
            this.toolStripMenuItem3,
            this.refreshToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolTip1.SetToolTip(this.contextMenuStrip1, resources.GetString("contextMenuStrip1.ToolTip"));
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            resources.ApplyResources(this.showDetailsToolStripMenuItem, "showDetailsToolStripMenuItem");
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // addNewPersonToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewPersonToolStripMenuItem, "addNewPersonToolStripMenuItem");
            this.addNewPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.AddPerson_32;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // sendEmailToolStripMenuItem
            // 
            resources.ApplyResources(this.sendEmailToolStripMenuItem, "sendEmailToolStripMenuItem");
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            resources.ApplyResources(this.phoneCallToolStripMenuItem, "phoneCallToolStripMenuItem");
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // refreshToolStripMenuItem1
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem1, "refreshToolStripMenuItem1");
            this.refreshToolStripMenuItem1.Image = global::DVLD.Properties.Resources.Refresh_32;
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
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
            // button_addNewPerson
            // 
            resources.ApplyResources(this.btn_addNewPerson, "button_addNewPerson");
            this.btn_addNewPerson.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_addNewPerson.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_addNewPerson.Image = global::DVLD.Properties.Resources.Add_Person_40;
            this.btn_addNewPerson.Name = "button_addNewPerson";
            this.toolTip1.SetToolTip(this.btn_addNewPerson, resources.GetString("button_addNewPerson.ToolTip"));
            this.btn_addNewPerson.UseCompatibleTextRendering = true;
            this.btn_addNewPerson.UseVisualStyleBackColor = false;
            this.btn_addNewPerson.Click += new System.EventHandler(this.button_addNewPerson_Click);
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
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::DVLD.Properties.Resources.People_400;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // label_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "label_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "label_noDataAvailable";
            this.toolTip1.SetToolTip(this.lbl_noDataAvailable, resources.GetString("label_noDataAvailable.ToolTip"));
            // 
            // Layout_ManagePeople
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.ll_refreshData);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_people);
            this.Controls.Add(this.cb_inputFilterBy);
            this.Controls.Add(this.cb_filterBy);
            this.Controls.Add(this.lbl_filterBy);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addNewPerson);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.Name = "Layout_ManagePeople";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Layout_ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_people)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_filterBy;
        private Salem.Controls.SalDropDownList cb_filterBy;
        private System.Windows.Forms.ComboBox cb_inputFilterBy;
        private System.Windows.Forms.DataGridView dgv_people;
        private System.Windows.Forms.Button btn_addNewPerson;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.LinkLabel ll_refreshData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.LinkLabel ll_exportData;
    }
}
