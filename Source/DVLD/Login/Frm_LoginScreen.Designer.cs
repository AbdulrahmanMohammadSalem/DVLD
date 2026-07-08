namespace DVLD.Login {
    partial class Frm_LoginScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoginScreen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_username = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.checkBox_rememberMe = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_password)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.btn_exit);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.button_login);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PerformDrag_MouseDown);
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PerformDrag_MouseDown);
            // 
            // button_exit
            // 
            resources.ApplyResources(this.btn_exit, "button_exit");
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Name = "button_exit";
            this.toolTip1.SetToolTip(this.btn_exit, resources.GetString("button_exit.ToolTip"));
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.textBox_username);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox_password);
            this.flowLayoutPanel1.Controls.Add(this.checkBox_rememberMe);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip1.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PerformDrag_MouseDown);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Image = global::DVLD.Properties.Resources.Person_32;
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PerformDrag_MouseDown);
            // 
            // textBox_username
            // 
            resources.ApplyResources(this.textBox_username, "textBox_username");
            this.textBox_username.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_username.BeforeTouchSize = new System.Drawing.Size(216, 26);
            this.textBox_username.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_username.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_username.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_username.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_username.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.textBox_username.Name = "textBox_username";
            this.toolTip1.SetToolTip(this.textBox_username, resources.GetString("textBox_username.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Number_32;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PerformDrag_MouseDown);
            // 
            // textBox_password
            // 
            resources.ApplyResources(this.textBox_password, "textBox_password");
            this.textBox_password.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.textBox_password.BeforeTouchSize = new System.Drawing.Size(216, 26);
            this.textBox_password.BorderColor = global::DVLD.Properties.Settings.Default.SurfaceBorderColor;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::DVLD.Properties.Settings.Default, "SurfaceBorderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_password.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.ThemeStyle.CornerRadius = 0;
            this.toolTip1.SetToolTip(this.textBox_password, resources.GetString("textBox_password.ToolTip"));
            // 
            // checkBox_rememberMe
            // 
            resources.ApplyResources(this.checkBox_rememberMe, "checkBox_rememberMe");
            this.checkBox_rememberMe.Name = "checkBox_rememberMe";
            this.toolTip1.SetToolTip(this.checkBox_rememberMe, resources.GetString("checkBox_rememberMe.ToolTip"));
            this.checkBox_rememberMe.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.button_login.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_login.Image = global::DVLD.Properties.Resources.sign_in_32;
            this.button_login.Name = "button_login";
            this.toolTip1.SetToolTip(this.button_login, resources.GetString("button_login.ToolTip"));
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PerformDrag_MouseDown);
            // 
            // Frm_LoginScreen
            // 
            this.AcceptButton = this.button_login;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CancelButton = this.btn_exit;
            this.Controls.Add(this.splitContainer1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoginScreen";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.Frm_LoginScreen_Load);
            this.Shown += new System.EventHandler(this.Frm_LoginScreen_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_password)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_password;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBox_username;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox_rememberMe;
    }
}