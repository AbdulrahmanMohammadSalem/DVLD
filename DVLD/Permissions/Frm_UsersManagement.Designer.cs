namespace DVLD.Permissions {
    partial class Frm_UsersManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_UsersManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_seeUserPermissions = new System.Windows.Forms.CheckBox();
            this.chk_exportUsersData = new System.Windows.Forms.CheckBox();
            this.chk_deleteUser = new System.Windows.Forms.CheckBox();
            this.chk_changeUserPermissions = new System.Windows.Forms.CheckBox();
            this.chk_changeUserPassword = new System.Windows.Forms.CheckBox();
            this.chk_activateDeactivateUsers = new System.Windows.Forms.CheckBox();
            this.chk_editUsername = new System.Windows.Forms.CheckBox();
            this.chk_addNewUser = new System.Windows.Forms.CheckBox();
            this.chk_seeAllUsers = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chk_seeUserPermissions);
            this.groupBox1.Controls.Add(this.chk_exportUsersData);
            this.groupBox1.Controls.Add(this.chk_deleteUser);
            this.groupBox1.Controls.Add(this.chk_changeUserPermissions);
            this.groupBox1.Controls.Add(this.chk_changeUserPassword);
            this.groupBox1.Controls.Add(this.chk_activateDeactivateUsers);
            this.groupBox1.Controls.Add(this.chk_editUsername);
            this.groupBox1.Controls.Add(this.chk_addNewUser);
            this.groupBox1.Controls.Add(this.chk_seeAllUsers);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chk_seeUserPermissions
            // 
            resources.ApplyResources(this.chk_seeUserPermissions, "chk_seeUserPermissions");
            this.chk_seeUserPermissions.Name = "chk_seeUserPermissions";
            this.chk_seeUserPermissions.UseVisualStyleBackColor = true;
            this.chk_seeUserPermissions.CheckedChanged += new System.EventHandler(this.chk_seeUserPermissions_CheckedChanged);
            // 
            // chk_exportUsersData
            // 
            resources.ApplyResources(this.chk_exportUsersData, "chk_exportUsersData");
            this.chk_exportUsersData.Name = "chk_exportUsersData";
            this.chk_exportUsersData.UseVisualStyleBackColor = true;
            this.chk_exportUsersData.CheckedChanged += new System.EventHandler(this.chk_exportUsersData_CheckedChanged);
            // 
            // chk_deleteUser
            // 
            resources.ApplyResources(this.chk_deleteUser, "chk_deleteUser");
            this.chk_deleteUser.Name = "chk_deleteUser";
            this.chk_deleteUser.UseVisualStyleBackColor = true;
            this.chk_deleteUser.CheckedChanged += new System.EventHandler(this.chk_deleteUser_CheckedChanged);
            // 
            // chk_changeUserPermissions
            // 
            resources.ApplyResources(this.chk_changeUserPermissions, "chk_changeUserPermissions");
            this.chk_changeUserPermissions.Name = "chk_changeUserPermissions";
            this.chk_changeUserPermissions.UseVisualStyleBackColor = true;
            this.chk_changeUserPermissions.CheckedChanged += new System.EventHandler(this.chk_changeUserPermissions_CheckedChanged);
            // 
            // chk_changeUserPassword
            // 
            resources.ApplyResources(this.chk_changeUserPassword, "chk_changeUserPassword");
            this.chk_changeUserPassword.Name = "chk_changeUserPassword";
            this.chk_changeUserPassword.UseVisualStyleBackColor = true;
            this.chk_changeUserPassword.CheckedChanged += new System.EventHandler(this.chk_changeUserPassword_CheckedChanged);
            // 
            // chk_activateDeactivateUsers
            // 
            resources.ApplyResources(this.chk_activateDeactivateUsers, "chk_activateDeactivateUsers");
            this.chk_activateDeactivateUsers.Name = "chk_activateDeactivateUsers";
            this.chk_activateDeactivateUsers.UseVisualStyleBackColor = true;
            this.chk_activateDeactivateUsers.CheckedChanged += new System.EventHandler(this.chk_activateDeactivateUsers_CheckedChanged);
            // 
            // chk_editUsername
            // 
            resources.ApplyResources(this.chk_editUsername, "chk_editUsername");
            this.chk_editUsername.Name = "chk_editUsername";
            this.chk_editUsername.UseVisualStyleBackColor = true;
            this.chk_editUsername.CheckedChanged += new System.EventHandler(this.chk_editUsername_CheckedChanged);
            // 
            // chk_addNewUser
            // 
            resources.ApplyResources(this.chk_addNewUser, "chk_addNewUser");
            this.chk_addNewUser.Name = "chk_addNewUser";
            this.chk_addNewUser.UseVisualStyleBackColor = true;
            this.chk_addNewUser.CheckedChanged += new System.EventHandler(this.chk_addNewUser_CheckedChanged);
            // 
            // chk_seeAllUsers
            // 
            resources.ApplyResources(this.chk_seeAllUsers, "chk_seeAllUsers");
            this.chk_seeAllUsers.Name = "chk_seeAllUsers";
            this.chk_seeAllUsers.UseVisualStyleBackColor = true;
            this.chk_seeAllUsers.CheckedChanged += new System.EventHandler(this.chk_viewAllUsers_CheckedChanged);
            // 
            // btn_ok
            // 
            resources.ApplyResources(this.btn_ok, "btn_ok");
            this.btn_ok.BackColor = global::DVLD.Properties.Settings.Default.SurfaceBackColor;
            this.btn_ok.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "SurfaceBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // Frm_UsersManagement
            // 
            this.AcceptButton = this.btn_ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DVLD.Properties.Settings.Default.BaseBackColor;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TitleBarColorMode", global::DVLD.Properties.Settings.Default, "TitleBarColorMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DVLD.Properties.Settings.Default, "BaseBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_UsersManagement";
            this.TitleBarColorMode = global::DVLD.Properties.Settings.Default.TitleBarColorMode;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox chk_seeAllUsers;
        private System.Windows.Forms.CheckBox chk_exportUsersData;
        private System.Windows.Forms.CheckBox chk_deleteUser;
        private System.Windows.Forms.CheckBox chk_changeUserPermissions;
        private System.Windows.Forms.CheckBox chk_changeUserPassword;
        private System.Windows.Forms.CheckBox chk_activateDeactivateUsers;
        private System.Windows.Forms.CheckBox chk_editUsername;
        private System.Windows.Forms.CheckBox chk_addNewUser;
        private System.Windows.Forms.CheckBox chk_seeUserPermissions;
    }
}