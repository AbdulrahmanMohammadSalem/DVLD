namespace DVLD.Detain_Licenses {
    partial class Frm_DetainLicense {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetainLicense));
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_fineFees = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_licenseID = new Salem.Controls.SalSelectableLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_detainID = new Salem.Controls.SalSelectableLabel();
            this.lbl_detainDate = new Salem.Controls.SalSelectableLabel();
            this.txt_detainReason = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ll_showLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_detain = new System.Windows.Forms.Button();
            this.ctrl_LocalLicenseInfoCardWithFilter1 = new DVLD.Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fineFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_detainReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            resources.ApplyResources(this.label_title, "label_title");
            this.label_title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "AccentForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.label_title, resources.GetString("label_title.Error"));
            this.label_title.ForeColor = global::DVLD.Properties.Settings.Default.AccentForeColor;
            this.errorProvider1.SetIconAlignment(this.label_title, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label_title.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label_title, ((int)(resources.GetObject("label_title.IconPadding"))));
            this.label_title.Name = "label_title";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txt_fineFees);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbl_licenseID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbl_createdBy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_detainID);
            this.groupBox2.Controls.Add(this.lbl_detainDate);
            this.groupBox2.Controls.Add(this.txt_detainReason);
            this.groupBox2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.groupBox2.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txt_fineFees
            // 
            resources.ApplyResources(this.txt_fineFees, "txt_fineFees");
            this.txt_fineFees.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_fineFees.BeforeTouchSize = new System.Drawing.Size(388, 76);
            this.txt_fineFees.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.txt_fineFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fineFees.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fineFees.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_fineFees.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_fineFees, resources.GetString("txt_fineFees.Error"));
            this.txt_fineFees.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_fineFees, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_fineFees.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_fineFees, ((int)(resources.GetObject("txt_fineFees.IconPadding"))));
            this.txt_fineFees.Name = "txt_fineFees";
            this.txt_fineFees.TextChanged += new System.EventHandler(this.txt_detainNotes_TextChanged);
            this.txt_fineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fineFees_KeyPress);
            this.txt_fineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txt_fineFees_Validating);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Image = global::DVLD.Properties.Resources.money_32;
            this.label4.Name = "label4";
            // 
            // lbl_licenseID
            // 
            resources.ApplyResources(this.lbl_licenseID, "lbl_licenseID");
            this.lbl_licenseID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_licenseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProvider1.SetError(this.lbl_licenseID, resources.GetString("lbl_licenseID.Error"));
            this.lbl_licenseID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.lbl_licenseID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_licenseID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_licenseID, ((int)(resources.GetObject("lbl_licenseID.IconPadding"))));
            this.lbl_licenseID.Name = "lbl_licenseID";
            this.lbl_licenseID.ReadOnly = true;
            this.lbl_licenseID.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Image = global::DVLD.Properties.Resources.Notes_32;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.Name = "label1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label8.Name = "label8";
            // 
            // lbl_createdBy
            // 
            resources.ApplyResources(this.lbl_createdBy, "lbl_createdBy");
            this.lbl_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProvider1.SetError(this.lbl_createdBy, resources.GetString("lbl_createdBy.Error"));
            this.lbl_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.lbl_createdBy, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_createdBy.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_createdBy, ((int)(resources.GetObject("lbl_createdBy.IconPadding"))));
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.ReadOnly = true;
            this.lbl_createdBy.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // lbl_detainID
            // 
            resources.ApplyResources(this.lbl_detainID, "lbl_detainID");
            this.lbl_detainID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProvider1.SetError(this.lbl_detainID, resources.GetString("lbl_detainID.Error"));
            this.lbl_detainID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.lbl_detainID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_detainID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_detainID, ((int)(resources.GetObject("lbl_detainID.IconPadding"))));
            this.lbl_detainID.Name = "lbl_detainID";
            this.lbl_detainID.ReadOnly = true;
            this.lbl_detainID.TabStop = false;
            // 
            // lbl_detainDate
            // 
            resources.ApplyResources(this.lbl_detainDate, "lbl_detainDate");
            this.lbl_detainDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_detainDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorProvider1.SetError(this.lbl_detainDate, resources.GetString("lbl_detainDate.Error"));
            this.lbl_detainDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider1.SetIconAlignment(this.lbl_detainDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbl_detainDate.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lbl_detainDate, ((int)(resources.GetObject("lbl_detainDate.IconPadding"))));
            this.lbl_detainDate.Name = "lbl_detainDate";
            this.lbl_detainDate.ReadOnly = true;
            this.lbl_detainDate.TabStop = false;
            // 
            // txt_detainReason
            // 
            resources.ApplyResources(this.txt_detainReason, "txt_detainReason");
            this.txt_detainReason.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.txt_detainReason.BeforeTouchSize = new System.Drawing.Size(388, 76);
            this.txt_detainReason.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txt_detainReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_detainReason.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_detainReason.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.txt_detainReason, resources.GetString("txt_detainReason.Error"));
            this.txt_detainReason.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.txt_detainReason, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txt_detainReason.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txt_detainReason, ((int)(resources.GetObject("txt_detainReason.IconPadding"))));
            this.txt_detainReason.Name = "txt_detainReason";
            this.txt_detainReason.TextChanged += new System.EventHandler(this.txt_detainNotes_TextChanged);
            this.txt_detainReason.Validating += new System.ComponentModel.CancelEventHandler(this.txt_detainNotes_Validating);
            // 
            // ll_showLicenseHistory
            // 
            resources.ApplyResources(this.ll_showLicenseHistory, "ll_showLicenseHistory");
            this.ll_showLicenseHistory.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.ll_showLicenseHistory, resources.GetString("ll_showLicenseHistory.Error"));
            this.ll_showLicenseHistory.ForeColor = System.Drawing.Color.Blue;
            this.errorProvider1.SetIconAlignment(this.ll_showLicenseHistory, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ll_showLicenseHistory.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ll_showLicenseHistory, ((int)(resources.GetObject("ll_showLicenseHistory.IconPadding"))));
            this.ll_showLicenseHistory.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_showLicenseHistory.Name = "ll_showLicenseHistory";
            this.ll_showLicenseHistory.TabStop = true;
            this.ll_showLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_showLicenseHistory_LinkClicked);
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
            // btn_detain
            // 
            resources.ApplyResources(this.btn_detain, "btn_detain");
            this.btn_detain.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_detain.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.btn_detain, resources.GetString("btn_detain.Error"));
            this.btn_detain.FlatAppearance.BorderSize = 2;
            this.btn_detain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorProvider1.SetIconAlignment(this.btn_detain, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btn_detain.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btn_detain, ((int)(resources.GetObject("btn_detain.IconPadding"))));
            this.btn_detain.Image = global::DVLD.Properties.Resources.Detain_32;
            this.btn_detain.Name = "btn_detain";
            this.btn_detain.UseVisualStyleBackColor = false;
            this.btn_detain.Click += new System.EventHandler(this.btn_detain_Click);
            // 
            // ctrl_LocalLicenseInfoCardWithFilter1
            // 
            resources.ApplyResources(this.ctrl_LocalLicenseInfoCardWithFilter1, "ctrl_LocalLicenseInfoCardWithFilter1");
            this.ctrl_LocalLicenseInfoCardWithFilter1.EnableFiltering = true;
            this.errorProvider1.SetError(this.ctrl_LocalLicenseInfoCardWithFilter1, resources.GetString("ctrl_LocalLicenseInfoCardWithFilter1.Error"));
            this.errorProvider1.SetIconAlignment(this.ctrl_LocalLicenseInfoCardWithFilter1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrl_LocalLicenseInfoCardWithFilter1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ctrl_LocalLicenseInfoCardWithFilter1, ((int)(resources.GetObject("ctrl_LocalLicenseInfoCardWithFilter1.IconPadding"))));
            this.ctrl_LocalLicenseInfoCardWithFilter1.Name = "ctrl_LocalLicenseInfoCardWithFilter1";
            this.ctrl_LocalLicenseInfoCardWithFilter1.LicenseFound += new System.Action<bool>(this.ctrl_LocalLicenseInfoCardWithFilter1_LicenseFound);
            this.ctrl_LocalLicenseInfoCardWithFilter1.LicenseNotFound += new System.Action(this.ctrl_LocalLicenseInfoCardWithFilter1_LicenseNotFound);
            this.ctrl_LocalLicenseInfoCardWithFilter1.PersonSaved += new System.Action<int>(this.ctrl_LocalLicenseInfoCardWithFilter1_PersonSaved);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // Frm_DetainLicense
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.btn_detain);
            this.Controls.Add(this.ll_showLicenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.ctrl_LocalLicenseInfoCardWithFilter1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DetainLicense";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.Activated += new System.EventHandler(this.Frm_DetainLicense_Activated);
            this.Load += new System.EventHandler(this.Frm_DetainLicense_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fineFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_detainReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.Ctrl_LocalLicenseInfoCardWithFilter ctrl_LocalLicenseInfoCardWithFilter1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_licenseID;
        private Salem.Controls.SalSelectableLabel lbl_detainDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel lbl_detainID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_detainReason;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_fineFees;
        private System.Windows.Forms.LinkLabel ll_showLicenseHistory;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_detain;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}