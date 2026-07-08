namespace DVLD.Applications {
    partial class Frm_ManageApplicationTypes {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageApplicationTypes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_updateSelectedItem = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.label_id = new Salem.Controls.SalSelectableLabel();
            this.textBox_title = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fees = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.dgv_applicationTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_noDataAvailable = new System.Windows.Forms.Label();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            this.pnl_updateSelectedItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_fees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_applicationTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_updateSelectedItem
            // 
            resources.ApplyResources(this.pnl_updateSelectedItem, "pnl_updateSelectedItem");
            this.pnl_updateSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_updateSelectedItem.Controls.Add(this.button_save);
            this.pnl_updateSelectedItem.Controls.Add(this.label_id);
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_title);
            this.pnl_updateSelectedItem.Controls.Add(this.label5);
            this.pnl_updateSelectedItem.Controls.Add(this.label4);
            this.pnl_updateSelectedItem.Controls.Add(this.label3);
            this.pnl_updateSelectedItem.Controls.Add(this.label2);
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_fees);
            this.pnl_updateSelectedItem.Name = "pnl_updateSelectedItem";
            // 
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_save.Image = global::DVLD.Properties.Resources.Save_32;
            this.button_save.Name = "button_save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_id
            // 
            resources.ApplyResources(this.label_id, "label_id");
            this.label_id.BackColor = System.Drawing.SystemColors.Control;
            this.label_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_id.Name = "label_id";
            this.label_id.ReadOnly = true;
            this.label_id.TabStop = false;
            // 
            // textBox_title
            // 
            resources.ApplyResources(this.textBox_title, "textBox_title");
            this.textBox_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_title.BeforeTouchSize = new System.Drawing.Size(255, 26);
            this.textBox_title.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_title.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_title.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "SyncTextBoxStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_title.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_title, ((int)(resources.GetObject("textBox_title.IconPadding"))));
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.ReadOnly = true;
            this.textBox_title.Style = global::DVLD.Properties.Settings.Default.SyncTextBoxStyle;
            this.textBox_title.ThemeName = "Office2016White";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.money_32;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.ApplicationTitle;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.Number_32;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.label2.Name = "label2";
            // 
            // textBox_fees
            // 
            resources.ApplyResources(this.textBox_fees, "textBox_fees");
            this.textBox_fees.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_fees.BeforeTouchSize = new System.Drawing.Size(255, 26);
            this.textBox_fees.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_fees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fees.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_fees.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_fees.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_fees.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconPadding(this.textBox_fees, ((int)(resources.GetObject("textBox_fees.IconPadding"))));
            this.textBox_fees.Name = "textBox_fees";
            this.textBox_fees.TextChanged += new System.EventHandler(this.textBox_fees_TextChanged);
            this.textBox_fees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fees_KeyPress);
            this.textBox_fees.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_fees_Validating);
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
            // dgv_applicationTypes
            // 
            this.dgv_applicationTypes.AllowUserToAddRows = false;
            this.dgv_applicationTypes.AllowUserToDeleteRows = false;
            this.dgv_applicationTypes.AllowUserToOrderColumns = true;
            this.dgv_applicationTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_applicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgv_applicationTypes, "dgv_applicationTypes");
            this.dgv_applicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_applicationTypes.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_applicationTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_applicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_applicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_applicationTypes.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "[???]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_applicationTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_applicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_applicationTypes.EnableHeadersVisualStyles = false;
            this.dgv_applicationTypes.MultiSelect = false;
            this.dgv_applicationTypes.Name = "dgv_applicationTypes";
            this.dgv_applicationTypes.ReadOnly = true;
            this.dgv_applicationTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_applicationTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_applicationTypes.RowTemplate.Height = 26;
            this.dgv_applicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_applicationTypes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_applicationTypes_CellEnter);
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
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Application_Types_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // label_numOfRecords
            // 
            resources.ApplyResources(this.label_numOfRecords, "label_numOfRecords");
            this.label_numOfRecords.BackColor = System.Drawing.SystemColors.Control;
            this.label_numOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_numOfRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_numOfRecords.Name = "label_numOfRecords";
            this.label_numOfRecords.ReadOnly = true;
            this.label_numOfRecords.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label_noDataAvailable
            // 
            resources.ApplyResources(this.lbl_noDataAvailable, "label_noDataAvailable");
            this.lbl_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lbl_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.lbl_noDataAvailable.Name = "label_noDataAvailable";
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
            // Frm_ManageApplicationTypes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.lbl_noDataAvailable);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.pnl_updateSelectedItem);
            this.Controls.Add(this.ll_refreshData);
            this.Controls.Add(this.dgv_applicationTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ll_exportData);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.MinimizeBox = false;
            this.Name = "Frm_ManageApplicationTypes";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ManageApplicationTypes_FormClosed);
            this.Load += new System.EventHandler(this.Frm_ManageApplicationTypes_Load);
            this.pnl_updateSelectedItem.ResumeLayout(false);
            this.pnl_updateSelectedItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_fees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_applicationTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_updateSelectedItem;
        private Salem.Controls.SalSelectableLabel label_id;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_fees;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ll_refreshData;
        private System.Windows.Forms.DataGridView dgv_applicationTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_close;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_noDataAvailable;
        private System.Windows.Forms.LinkLabel ll_exportData;
    }
}