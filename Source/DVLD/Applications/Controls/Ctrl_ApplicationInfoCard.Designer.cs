namespace DVLD.Applications.Controls {
    partial class Ctrl_ApplicationInfoCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_ApplicationInfoCard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ll_viewPersonInfo = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_applicantName = new Salem.Controls.SalSelectableLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_fees = new Salem.Controls.SalSelectableLabel();
            this.lbl_status = new Salem.Controls.SalSelectableLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_applicationID = new Salem.Controls.SalSelectableLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_applicationType = new Salem.Controls.SalSelectableLabel();
            this.lbl_applicationDate = new Salem.Controls.SalSelectableLabel();
            this.lbl_updateStatusDate = new Salem.Controls.SalSelectableLabel();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.ll_viewPersonInfo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_applicantName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_fees);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_applicationID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_applicationType);
            this.groupBox1.Controls.Add(this.lbl_applicationDate);
            this.groupBox1.Controls.Add(this.lbl_updateStatusDate);
            this.groupBox1.Controls.Add(this.lbl_createdBy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ll_viewPersonInfo
            // 
            resources.ApplyResources(this.ll_viewPersonInfo, "ll_viewPersonInfo");
            this.ll_viewPersonInfo.DataBindings.Add(new System.Windows.Forms.Binding("LinkColor", global::DVLD.Properties.Settings.Default, "BaseLinkColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ll_viewPersonInfo.LinkColor = global::DVLD.Properties.Settings.Default.BaseLinkColor;
            this.ll_viewPersonInfo.Name = "ll_viewPersonInfo";
            this.ll_viewPersonInfo.TabStop = true;
            this.ll_viewPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_viewPersonInfo_LinkClicked);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Image = global::DVLD.Properties.Resources.User_32__2;
            this.label8.Name = "label8";
            // 
            // lbl_applicantName
            // 
            this.lbl_applicantName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicantName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_applicantName.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "StrongForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.lbl_applicantName, "lbl_applicantName");
            this.lbl_applicantName.ForeColor = global::DVLD.Properties.Settings.Default.StrongForeColor;
            this.lbl_applicantName.MatchParentForeColor = false;
            this.lbl_applicantName.Name = "lbl_applicantName";
            this.lbl_applicantName.ReadOnly = true;
            this.lbl_applicantName.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Image = global::DVLD.Properties.Resources.Person_32;
            this.label4.Name = "label4";
            // 
            // lbl_fees
            // 
            this.lbl_fees.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_fees, "lbl_fees");
            this.lbl_fees.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_fees.Name = "lbl_fees";
            this.lbl_fees.ReadOnly = true;
            this.lbl_fees.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.ReadOnly = true;
            this.lbl_status.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Image = global::DVLD.Properties.Resources.Number_32;
            this.label1.Name = "label1";
            // 
            // lbl_applicationID
            // 
            this.lbl_applicationID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_applicationID, "lbl_applicationID");
            this.lbl_applicationID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationID.Name = "lbl_applicationID";
            this.lbl_applicationID.ReadOnly = true;
            this.lbl_applicationID.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::DVLD.Properties.Resources.Number_32;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Image = global::DVLD.Properties.Resources.ApplicationType;
            this.label3.Name = "label3";
            // 
            // lbl_applicationType
            // 
            this.lbl_applicationType.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_applicationType, "lbl_applicationType");
            this.lbl_applicationType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationType.Name = "lbl_applicationType";
            this.lbl_applicationType.ReadOnly = true;
            this.lbl_applicationType.TabStop = false;
            // 
            // lbl_applicationDate
            // 
            this.lbl_applicationDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_applicationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_applicationDate, "lbl_applicationDate");
            this.lbl_applicationDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_applicationDate.Name = "lbl_applicationDate";
            this.lbl_applicationDate.ReadOnly = true;
            this.lbl_applicationDate.TabStop = false;
            // 
            // lbl_updateStatusDate
            // 
            this.lbl_updateStatusDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_updateStatusDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_updateStatusDate.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.lbl_updateStatusDate, "lbl_updateStatusDate");
            this.lbl_updateStatusDate.Name = "lbl_updateStatusDate";
            this.lbl_updateStatusDate.ReadOnly = true;
            this.lbl_updateStatusDate.TabStop = false;
            // 
            // lbl_createdBy
            // 
            this.lbl_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbl_createdBy, "lbl_createdBy");
            this.lbl_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.ReadOnly = true;
            this.lbl_createdBy.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label7.Name = "label7";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.money_32;
            this.label2.Name = "label2";
            // 
            // Ctrl_ApplicationInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_ApplicationInfoCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Salem.Controls.SalSelectableLabel lbl_applicationID;
        private System.Windows.Forms.Label label5;
        private Salem.Controls.SalSelectableLabel lbl_applicantName;
        private System.Windows.Forms.Label label4;
        private Salem.Controls.SalSelectableLabel lbl_applicationType;
        private System.Windows.Forms.Label label3;
        private Salem.Controls.SalSelectableLabel lbl_fees;
        private System.Windows.Forms.Label label2;
        private Salem.Controls.SalSelectableLabel lbl_status;
        private System.Windows.Forms.Label label1;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private System.Windows.Forms.Label label8;
        private Salem.Controls.SalSelectableLabel lbl_updateStatusDate;
        private System.Windows.Forms.Label label7;
        private Salem.Controls.SalSelectableLabel lbl_applicationDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ll_viewPersonInfo;
    }
}
