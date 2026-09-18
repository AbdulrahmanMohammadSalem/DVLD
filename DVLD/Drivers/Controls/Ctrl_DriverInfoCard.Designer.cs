namespace DVLD.Drivers.Controls {
    partial class Ctrl_DriverInfoCard {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ctrl_DriverInfoCard));
            this.ctrl_PersonCard1 = new DVLD.People.Ctrl_PersonInfoCard();
            this.lbl_dateCreated = new Salem.Controls.SalSelectableLabel();
            this.lbl_createdBy = new Salem.Controls.SalSelectableLabel();
            this.lbl_driverID = new Salem.Controls.SalSelectableLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrl_PersonCard1
            // 
            resources.ApplyResources(this.ctrl_PersonCard1, "ctrl_PersonCard1");
            this.ctrl_PersonCard1.EnableEditingPersonInfo = true;
            this.ctrl_PersonCard1.Name = "ctrl_PersonCard1";
            this.ctrl_PersonCard1.PersonSaved += new System.Action<int>(this.ctrl_PersonCard1_PersonSaved);
            // 
            // lbl_dateCreated
            // 
            resources.ApplyResources(this.lbl_dateCreated, "lbl_dateCreated");
            this.lbl_dateCreated.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_dateCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_dateCreated.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_dateCreated.Name = "lbl_dateCreated";
            this.lbl_dateCreated.ReadOnly = true;
            this.lbl_dateCreated.TabStop = false;
            // 
            // lbl_createdBy
            // 
            resources.ApplyResources(this.lbl_createdBy, "lbl_createdBy");
            this.lbl_createdBy.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_createdBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_createdBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_createdBy.Name = "lbl_createdBy";
            this.lbl_createdBy.ReadOnly = true;
            this.lbl_createdBy.TabStop = false;
            // 
            // lbl_driverID
            // 
            resources.ApplyResources(this.lbl_driverID, "lbl_driverID");
            this.lbl_driverID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_driverID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_driverID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_driverID.Name = "lbl_driverID";
            this.lbl_driverID.ReadOnly = true;
            this.lbl_driverID.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Image = global::DVLD.Properties.Resources.Calendar_32;
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
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lbl_driverID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_dateCreated);
            this.groupBox1.Controls.Add(this.lbl_createdBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DVLD.Properties.Settings.Default, "BaseForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.groupBox1.ForeColor = global::DVLD.Properties.Settings.Default.BaseForeColor;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // Ctrl_DriverInfoCard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrl_PersonCard1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ctrl_DriverInfoCard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Ctrl_PersonInfoCard ctrl_PersonCard1;
        private Salem.Controls.SalSelectableLabel lbl_dateCreated;
        private Salem.Controls.SalSelectableLabel lbl_createdBy;
        private Salem.Controls.SalSelectableLabel lbl_driverID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
