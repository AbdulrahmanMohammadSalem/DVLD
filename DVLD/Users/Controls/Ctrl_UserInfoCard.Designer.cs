namespace DVLD.Users {
    partial class Ctrl_UserInfoCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_UserInfoCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_isActive = new Salem.Controls.SalSelectableLabel();
            this.label_username = new Salem.Controls.SalSelectableLabel();
            this.label_userID = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ll_seePermissions = new System.Windows.Forms.LinkLabel();
            this.ctrl_PersonCard1 = new DVLD.People.Ctrl_PersonInfoCard();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label_isActive);
            this.groupBox1.Controls.Add(this.label_username);
            this.groupBox1.Controls.Add(this.label_userID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label_isActive
            // 
            resources.ApplyResources(this.label_isActive, "label_isActive");
            this.label_isActive.BackColor = System.Drawing.SystemColors.Control;
            this.label_isActive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_isActive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_isActive.Name = "label_isActive";
            this.label_isActive.ReadOnly = true;
            this.label_isActive.TabStop = false;
            // 
            // label_username
            // 
            resources.ApplyResources(this.label_username, "label_username");
            this.label_username.BackColor = System.Drawing.SystemColors.Control;
            this.label_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_username.Name = "label_username";
            this.label_username.ReadOnly = true;
            this.label_username.TabStop = false;
            // 
            // label_userID
            // 
            resources.ApplyResources(this.label_userID, "label_userID");
            this.label_userID.BackColor = System.Drawing.SystemColors.Control;
            this.label_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_userID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_userID.Name = "label_userID";
            this.label_userID.ReadOnly = true;
            this.label_userID.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Question_32;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Person_32;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Number_32;
            this.label4.Name = "label4";
            // 
            // ll_seePermissions
            // 
            resources.ApplyResources(this.ll_seePermissions, "ll_seePermissions");
            this.ll_seePermissions.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_seePermissions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ll_seePermissions.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_seePermissions.Name = "ll_seePermissions";
            this.ll_seePermissions.TabStop = true;
            this.ll_seePermissions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_seePermissions_LinkClicked);
            // 
            // ctrl_PersonCard1
            // 
            resources.ApplyResources(this.ctrl_PersonCard1, "ctrl_PersonCard1");
            this.ctrl_PersonCard1.EnableEditingPersonInfo = true;
            this.ctrl_PersonCard1.Name = "ctrl_PersonCard1";
            this.ctrl_PersonCard1.PersonSaved += new System.Action<int>(this.ctrl_PersonCard1_PersonSaved);
            // 
            // Ctrl_UserInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ll_seePermissions);
            this.Controls.Add(this.ctrl_PersonCard1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_UserInfoCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel label_userID;
        private Salem.Controls.SalSelectableLabel label_isActive;
        private Salem.Controls.SalSelectableLabel label_username;
        private People.Ctrl_PersonInfoCard ctrl_PersonCard1;
        private System.Windows.Forms.LinkLabel ll_seePermissions;
    }
}
