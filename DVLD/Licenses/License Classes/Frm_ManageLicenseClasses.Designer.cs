namespace DVLD.Licenses.License_Classes {
    partial class Frm_ManageLicenseClasses {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageLicenseClasses));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox_className = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_description = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_fees = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_defaultValidityLength = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBox_minimumAllowedAge = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.button_save = new System.Windows.Forms.Button();
            this.label_id = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_numOfRecords = new Salem.Controls.SalSelectableLabel();
            this.button_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_updateSelectedItem = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ll_refreshData = new System.Windows.Forms.LinkLabel();
            this.dgv_licenseClasses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_noDataAvailable = new System.Windows.Forms.Label();
            this.ll_exportData = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_className)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_fees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_defaultValidityLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_minimumAllowedAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_updateSelectedItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licenseClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // textBox_className
            // 
            resources.ApplyResources(this.textBox_className, "textBox_className");
            this.textBox_className.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_className.BeforeTouchSize = new System.Drawing.Size(261, 55);
            this.textBox_className.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_className.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_className.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_className.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "SyncTextBoxStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_className, resources.GetString("textBox_className.Error"));
            this.textBox_className.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.errorProvider1.SetIconAlignment(this.textBox_className, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_className.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_className, ((int)(resources.GetObject("textBox_className.IconPadding"))));
            this.textBox_className.Name = "textBox_className";
            this.textBox_className.ReadOnly = true;
            this.textBox_className.Style = global::DVLD.Properties.Settings.Default.SyncTextBoxStyle;
            this.textBox_className.ThemeName = "Office2016White";
            // 
            // textBox_description
            // 
            resources.ApplyResources(this.textBox_description, "textBox_description");
            this.textBox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_description.BeforeTouchSize = new System.Drawing.Size(261, 55);
            this.textBox_description.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_description.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_description.DataBindings.Add(new System.Windows.Forms.Binding("Style", global::DVLD.Properties.Settings.Default, "SyncTextBoxStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_description, resources.GetString("textBox_description.Error"));
            this.textBox_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.errorProvider1.SetIconAlignment(this.textBox_description, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_description.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_description, ((int)(resources.GetObject("textBox_description.IconPadding"))));
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.Style = global::DVLD.Properties.Settings.Default.SyncTextBoxStyle;
            this.textBox_description.ThemeName = "Office2016White";
            // 
            // textBox_fees
            // 
            resources.ApplyResources(this.textBox_fees, "textBox_fees");
            this.textBox_fees.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_fees.BeforeTouchSize = new System.Drawing.Size(261, 55);
            this.textBox_fees.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_fees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_fees.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_fees.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_fees.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_fees, resources.GetString("textBox_fees.Error"));
            this.textBox_fees.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_fees, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_fees.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_fees, ((int)(resources.GetObject("textBox_fees.IconPadding"))));
            this.textBox_fees.Name = "textBox_fees";
            this.textBox_fees.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_fees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fees_KeyPress);
            this.textBox_fees.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_fees_Validating);
            // 
            // textBox_defaultValidityLength
            // 
            resources.ApplyResources(this.textBox_defaultValidityLength, "textBox_defaultValidityLength");
            this.textBox_defaultValidityLength.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_defaultValidityLength.BeforeTouchSize = new System.Drawing.Size(261, 55);
            this.textBox_defaultValidityLength.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_defaultValidityLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_defaultValidityLength.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_defaultValidityLength.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_defaultValidityLength.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_defaultValidityLength, resources.GetString("textBox_defaultValidityLength.Error"));
            this.textBox_defaultValidityLength.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_defaultValidityLength, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_defaultValidityLength.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_defaultValidityLength, ((int)(resources.GetObject("textBox_defaultValidityLength.IconPadding"))));
            this.textBox_defaultValidityLength.Name = "textBox_defaultValidityLength";
            this.textBox_defaultValidityLength.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_defaultValidityLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_digitsOnly_KeyPress);
            this.textBox_defaultValidityLength.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_defaultValidityLength_Validating);
            // 
            // textBox_minimumAllowedAge
            // 
            resources.ApplyResources(this.textBox_minimumAllowedAge, "textBox_minimumAllowedAge");
            this.textBox_minimumAllowedAge.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_minimumAllowedAge.BeforeTouchSize = new System.Drawing.Size(261, 55);
            this.textBox_minimumAllowedAge.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_minimumAllowedAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_minimumAllowedAge.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_minimumAllowedAge.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_minimumAllowedAge.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_minimumAllowedAge, resources.GetString("textBox_minimumAllowedAge.Error"));
            this.textBox_minimumAllowedAge.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_minimumAllowedAge, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_minimumAllowedAge.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_minimumAllowedAge, ((int)(resources.GetObject("textBox_minimumAllowedAge.IconPadding"))));
            this.textBox_minimumAllowedAge.Name = "textBox_minimumAllowedAge";
            this.textBox_minimumAllowedAge.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_minimumAllowedAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_digitsOnly_KeyPress);
            this.textBox_minimumAllowedAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_minimumAllowedAge_Validating);
            // 
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.button_save, resources.GetString("button_save.Error"));
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorProvider1.SetIconAlignment(this.button_save, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button_save.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button_save, ((int)(resources.GetObject("button_save.IconPadding"))));
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
            this.errorProvider1.SetError(this.label_id, resources.GetString("label_id.Error"));
            this.label_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorProvider1.SetIconAlignment(this.label_id, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_id.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label_id, ((int)(resources.GetObject("label_id.IconPadding"))));
            this.label_id.Name = "label_id";
            this.label_id.ReadOnly = true;
            this.label_id.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Image = global::DVLD.Properties.Resources.money_32;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Image = global::DVLD.Properties.Resources.ApplicationTitle;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Image = global::DVLD.Properties.Resources.Number_32;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.label2.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label_numOfRecords
            // 
            resources.ApplyResources(this.label_numOfRecords, "label_numOfRecords");
            this.label_numOfRecords.BackColor = System.Drawing.SystemColors.Control;
            this.label_numOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProvider1.SetError(this.label_numOfRecords, resources.GetString("label_numOfRecords.Error"));
            this.label_numOfRecords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorProvider1.SetIconAlignment(this.label_numOfRecords, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_numOfRecords.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label_numOfRecords, ((int)(resources.GetObject("label_numOfRecords.IconPadding"))));
            this.label_numOfRecords.Name = "label_numOfRecords";
            this.label_numOfRecords.ReadOnly = true;
            this.label_numOfRecords.TabStop = false;
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_close.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorProvider1.SetError(this.button_close, resources.GetString("button_close.Error"));
            this.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.errorProvider1.SetIconAlignment(this.button_close, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("button_close.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.button_close, ((int)(resources.GetObject("button_close.IconPadding"))));
            this.button_close.Image = global::DVLD.Properties.Resources.Close_32;
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.errorProvider1.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Manage_License_Classes_512;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // pnl_updateSelectedItem
            // 
            resources.ApplyResources(this.pnl_updateSelectedItem, "pnl_updateSelectedItem");
            this.pnl_updateSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_minimumAllowedAge);
            this.pnl_updateSelectedItem.Controls.Add(this.label8);
            this.pnl_updateSelectedItem.Controls.Add(this.label9);
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_defaultValidityLength);
            this.pnl_updateSelectedItem.Controls.Add(this.label7);
            this.pnl_updateSelectedItem.Controls.Add(this.button_save);
            this.pnl_updateSelectedItem.Controls.Add(this.label5);
            this.pnl_updateSelectedItem.Controls.Add(this.label4);
            this.pnl_updateSelectedItem.Controls.Add(this.label3);
            this.pnl_updateSelectedItem.Controls.Add(this.label2);
            this.pnl_updateSelectedItem.Controls.Add(this.label_id);
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_className);
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_description);
            this.pnl_updateSelectedItem.Controls.Add(this.textBox_fees);
            this.errorProvider1.SetError(this.pnl_updateSelectedItem, resources.GetString("pnl_updateSelectedItem.Error"));
            this.errorProvider1.SetIconAlignment(this.pnl_updateSelectedItem, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnl_updateSelectedItem.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pnl_updateSelectedItem, ((int)(resources.GetObject("pnl_updateSelectedItem.IconPadding"))));
            this.pnl_updateSelectedItem.Name = "pnl_updateSelectedItem";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Image = global::DVLD.Properties.Resources.Validity_Length_32;
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Image = global::DVLD.Properties.Resources.ApplicationTitle;
            this.label7.Name = "label7";
            // 
            // ll_refreshData
            // 
            resources.ApplyResources(this.ll_refreshData, "ll_refreshData");
            this.ll_refreshData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_refreshData, resources.GetString("ll_refreshData.Error"));
            this.errorProvider1.SetIconAlignment(this.ll_refreshData, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_refreshData.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_refreshData, ((int)(resources.GetObject("ll_refreshData.IconPadding"))));
            this.ll_refreshData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_refreshData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_refreshData.Name = "ll_refreshData";
            this.ll_refreshData.TabStop = true;
            this.ll_refreshData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_refreshData_LinkClicked);
            // 
            // dgv_licenseClasses
            // 
            resources.ApplyResources(this.dgv_licenseClasses, "dgv_licenseClasses");
            this.dgv_licenseClasses.AllowUserToAddRows = false;
            this.dgv_licenseClasses.AllowUserToDeleteRows = false;
            this.dgv_licenseClasses.AllowUserToOrderColumns = true;
            this.dgv_licenseClasses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.dgv_licenseClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_licenseClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_licenseClasses.BackgroundColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.dgv_licenseClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_licenseClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_licenseClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_licenseClasses.DataBindings.Add(new System.Windows.Forms.Binding("BackgroundColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "[???]";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_licenseClasses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_licenseClasses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_licenseClasses.EnableHeadersVisualStyles = false;
            this.errorProvider1.SetError(this.dgv_licenseClasses, resources.GetString("dgv_licenseClasses.Error"));
            this.errorProvider1.SetIconAlignment(this.dgv_licenseClasses, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dgv_licenseClasses.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.dgv_licenseClasses, ((int)(resources.GetObject("dgv_licenseClasses.IconPadding"))));
            this.dgv_licenseClasses.MultiSelect = false;
            this.dgv_licenseClasses.Name = "dgv_licenseClasses";
            this.dgv_licenseClasses.ReadOnly = true;
            this.dgv_licenseClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_licenseClasses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Readex Pro", 7.8F);
            this.dgv_licenseClasses.RowTemplate.Height = 26;
            this.dgv_licenseClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_licenseClasses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_licenseClasses_CellEnter);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.label1.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // label_noDataAvailable
            // 
            resources.ApplyResources(this.label_noDataAvailable, "label_noDataAvailable");
            this.label_noDataAvailable.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "InactiveForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.label_noDataAvailable, resources.GetString("label_noDataAvailable.Error"));
            this.label_noDataAvailable.ForeColor = global::DVLD.Properties.Settings.Default.InactiveForeColor;
            this.errorProvider1.SetIconAlignment(this.label_noDataAvailable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_noDataAvailable.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label_noDataAvailable, ((int)(resources.GetObject("label_noDataAvailable.IconPadding"))));
            this.label_noDataAvailable.Name = "label_noDataAvailable";
            // 
            // ll_exportData
            // 
            resources.ApplyResources(this.ll_exportData, "ll_exportData");
            this.ll_exportData.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_exportData, resources.GetString("ll_exportData.Error"));
            this.errorProvider1.SetIconAlignment(this.ll_exportData, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_exportData.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_exportData, ((int)(resources.GetObject("ll_exportData.IconPadding"))));
            this.ll_exportData.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_exportData.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_exportData.Name = "ll_exportData";
            this.ll_exportData.TabStop = true;
            this.ll_exportData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_exportData_LinkClicked);
            // 
            // Frm_ManageLicenseClasses
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.ll_exportData);
            this.Controls.Add(this.label_noDataAvailable);
            this.Controls.Add(this.label_numOfRecords);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl_updateSelectedItem);
            this.Controls.Add(this.ll_refreshData);
            this.Controls.Add(this.dgv_licenseClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_close);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.MinimizeBox = false;
            this.Name = "Frm_ManageLicenseClasses";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ManageLicenseClasses_FormClosed);
            this.Load += new System.EventHandler(this.Frm_ManageLicenseClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_className)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_fees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_defaultValidityLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_minimumAllowedAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_updateSelectedItem.ResumeLayout(false);
            this.pnl_updateSelectedItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_licenseClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Salem.Controls.SalSelectableLabel label_numOfRecords;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnl_updateSelectedItem;
        private System.Windows.Forms.Button button_save;
        private Salem.Controls.SalSelectableLabel label_id;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_className;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ll_refreshData;
        private System.Windows.Forms.DataGridView dgv_licenseClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_defaultValidityLength;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_fees;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_description;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_minimumAllowedAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_noDataAvailable;
        private System.Windows.Forms.LinkLabel ll_exportData;
    }
}