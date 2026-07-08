namespace DVLD.Users {
    partial class Frm_ChangeUserPassword {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangeUserPassword));
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_currentPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_newPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_confirmPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrl_UserCard1 = new DVLD.Users.Ctrl_UserInfoCard();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_currentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_newPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_confirmPassword)).BeginInit();
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
            // textBox_currentPassword
            // 
            resources.ApplyResources(this.textBox_currentPassword, "textBox_currentPassword");
            this.textBox_currentPassword.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_currentPassword.BeforeTouchSize = new System.Drawing.Size(243, 30);
            this.textBox_currentPassword.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_currentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_currentPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_currentPassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_currentPassword.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_currentPassword, resources.GetString("textBox_currentPassword.Error"));
            this.textBox_currentPassword.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_currentPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_currentPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_currentPassword, ((int)(resources.GetObject("textBox_currentPassword.IconPadding"))));
            this.textBox_currentPassword.Name = "textBox_currentPassword";
            this.textBox_currentPassword.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_currentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_currentNewPassword_Validating);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.errorProvider1.SetError(this.label13, resources.GetString("label13.Error"));
            this.errorProvider1.SetIconAlignment(this.label13, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label13.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label13, ((int)(resources.GetObject("label13.IconPadding"))));
            this.label13.Image = global::DVLD.Properties.Resources.Number_32;
            this.label13.Name = "label13";
            // 
            // textBox_newPassword
            // 
            resources.ApplyResources(this.textBox_newPassword, "textBox_newPassword");
            this.textBox_newPassword.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_newPassword.BeforeTouchSize = new System.Drawing.Size(243, 30);
            this.textBox_newPassword.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_newPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_newPassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_newPassword.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_newPassword, resources.GetString("textBox_newPassword.Error"));
            this.textBox_newPassword.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_newPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_newPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_newPassword, ((int)(resources.GetObject("textBox_newPassword.IconPadding"))));
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_newPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_currentNewPassword_Validating);
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
            // textBox_confirmPassword
            // 
            resources.ApplyResources(this.textBox_confirmPassword, "textBox_confirmPassword");
            this.textBox_confirmPassword.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_confirmPassword.BeforeTouchSize = new System.Drawing.Size(243, 30);
            this.textBox_confirmPassword.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_confirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider1.SetError(this.textBox_confirmPassword, resources.GetString("textBox_confirmPassword.Error"));
            this.textBox_confirmPassword.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.errorProvider1.SetIconAlignment(this.textBox_confirmPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox_confirmPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox_confirmPassword, ((int)(resources.GetObject("textBox_confirmPassword.IconPadding"))));
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.TextChanged += new System.EventHandler(this.textBox_toClearError_TextChanged);
            this.textBox_confirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_confirmPassword_Validating);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Image = global::DVLD.Properties.Resources.Number_32;
            this.label2.Name = "label2";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // ctrl_UserCard1
            // 
            resources.ApplyResources(this.ctrl_UserCard1, "ctrl_UserCard1");
            this.ctrl_UserCard1.EnableEditingPersonInfo = true;
            this.errorProvider1.SetError(this.ctrl_UserCard1, resources.GetString("ctrl_UserCard1.Error"));
            this.errorProvider1.SetIconAlignment(this.ctrl_UserCard1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ctrl_UserCard1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.ctrl_UserCard1, ((int)(resources.GetObject("ctrl_UserCard1.IconPadding"))));
            this.ctrl_UserCard1.Name = "ctrl_UserCard1";
            this.ctrl_UserCard1.UserSaved += new System.Action<int>(this.ctrl_UserCard1_UserSaved);
            // 
            // Frm_ChangeUserPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.CancelButton = this.button_close;
            this.Controls.Add(this.ctrl_UserCard1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_currentPassword);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ChangeUserPassword";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            ((System.ComponentModel.ISupportInitialize)(this.textBox_currentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_newPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_confirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_currentPassword;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_newPassword;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_confirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Ctrl_UserInfoCard ctrl_UserCard1;
    }
}