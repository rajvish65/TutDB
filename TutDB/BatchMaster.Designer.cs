namespace TutDB
{
    partial class BatchMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_batchMaster = new System.Windows.Forms.GroupBox();
            this.lblBatchMaster = new System.Windows.Forms.Label();
            this.linkLabel_batchMasterClose = new System.Windows.Forms.LinkLabel();
            this.cmbBatchMaster = new System.Windows.Forms.ComboBox();
            this.groupBox_batchDetails = new System.Windows.Forms.GroupBox();
            this.linkLabel_batchEdit = new System.Windows.Forms.LinkLabel();
            this.linkLabel_batchNew = new System.Windows.Forms.LinkLabel();
            this.lblBatchName = new System.Windows.Forms.Label();
            this.lblBatchIsActive = new System.Windows.Forms.Label();
            this.lblBatchCode = new System.Windows.Forms.Label();
            this.linkLabel_batchCancel = new System.Windows.Forms.LinkLabel();
            this.linkLabel_batchUpdate = new System.Windows.Forms.LinkLabel();
            this.linkLabel_batchAdd = new System.Windows.Forms.LinkLabel();
            this.linkLabel_batchAcitvate = new System.Windows.Forms.LinkLabel();
            this.txtBatchIsActive = new System.Windows.Forms.TextBox();
            this.txtBatchName = new System.Windows.Forms.TextBox();
            this.txtBatchCode = new System.Windows.Forms.TextBox();
            this.groupBox_batchMaster.SuspendLayout();
            this.groupBox_batchDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_batchMaster
            // 
            this.groupBox_batchMaster.Controls.Add(this.lblBatchMaster);
            this.groupBox_batchMaster.Controls.Add(this.linkLabel_batchMasterClose);
            this.groupBox_batchMaster.Controls.Add(this.cmbBatchMaster);
            this.groupBox_batchMaster.Location = new System.Drawing.Point(13, 13);
            this.groupBox_batchMaster.Name = "groupBox_batchMaster";
            this.groupBox_batchMaster.Size = new System.Drawing.Size(471, 117);
            this.groupBox_batchMaster.TabIndex = 0;
            this.groupBox_batchMaster.TabStop = false;
            this.groupBox_batchMaster.Text = "Batch";
            // 
            // lblBatchMaster
            // 
            this.lblBatchMaster.AutoSize = true;
            this.lblBatchMaster.Location = new System.Drawing.Point(88, 50);
            this.lblBatchMaster.Name = "lblBatchMaster";
            this.lblBatchMaster.Size = new System.Drawing.Size(35, 13);
            this.lblBatchMaster.TabIndex = 5;
            this.lblBatchMaster.Text = "Batch";
            // 
            // linkLabel_batchMasterClose
            // 
            this.linkLabel_batchMasterClose.AutoSize = true;
            this.linkLabel_batchMasterClose.Location = new System.Drawing.Point(432, 16);
            this.linkLabel_batchMasterClose.Name = "linkLabel_batchMasterClose";
            this.linkLabel_batchMasterClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_batchMasterClose.TabIndex = 4;
            this.linkLabel_batchMasterClose.TabStop = true;
            this.linkLabel_batchMasterClose.Text = "Close";
            this.linkLabel_batchMasterClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchMasterClose_LinkClicked);
            // 
            // cmbBatchMaster
            // 
            this.cmbBatchMaster.FormattingEnabled = true;
            this.cmbBatchMaster.Location = new System.Drawing.Point(166, 47);
            this.cmbBatchMaster.Name = "cmbBatchMaster";
            this.cmbBatchMaster.Size = new System.Drawing.Size(121, 21);
            this.cmbBatchMaster.TabIndex = 0;
            this.cmbBatchMaster.SelectedIndexChanged += new System.EventHandler(this.cmbBatchMaster_SelectedIndexChanged);
            // 
            // groupBox_batchDetails
            // 
            this.groupBox_batchDetails.Controls.Add(this.linkLabel_batchEdit);
            this.groupBox_batchDetails.Controls.Add(this.linkLabel_batchNew);
            this.groupBox_batchDetails.Controls.Add(this.lblBatchName);
            this.groupBox_batchDetails.Controls.Add(this.lblBatchIsActive);
            this.groupBox_batchDetails.Controls.Add(this.lblBatchCode);
            this.groupBox_batchDetails.Controls.Add(this.linkLabel_batchCancel);
            this.groupBox_batchDetails.Controls.Add(this.linkLabel_batchUpdate);
            this.groupBox_batchDetails.Controls.Add(this.linkLabel_batchAdd);
            this.groupBox_batchDetails.Controls.Add(this.linkLabel_batchAcitvate);
            this.groupBox_batchDetails.Controls.Add(this.txtBatchIsActive);
            this.groupBox_batchDetails.Controls.Add(this.txtBatchName);
            this.groupBox_batchDetails.Controls.Add(this.txtBatchCode);
            this.groupBox_batchDetails.Location = new System.Drawing.Point(13, 148);
            this.groupBox_batchDetails.Name = "groupBox_batchDetails";
            this.groupBox_batchDetails.Size = new System.Drawing.Size(471, 182);
            this.groupBox_batchDetails.TabIndex = 1;
            this.groupBox_batchDetails.TabStop = false;
            this.groupBox_batchDetails.Text = "Details";
            // 
            // linkLabel_batchEdit
            // 
            this.linkLabel_batchEdit.AutoSize = true;
            this.linkLabel_batchEdit.Location = new System.Drawing.Point(309, 16);
            this.linkLabel_batchEdit.Name = "linkLabel_batchEdit";
            this.linkLabel_batchEdit.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_batchEdit.TabIndex = 13;
            this.linkLabel_batchEdit.TabStop = true;
            this.linkLabel_batchEdit.Text = "Edit";
            this.linkLabel_batchEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchEdit_LinkClicked);
            // 
            // linkLabel_batchNew
            // 
            this.linkLabel_batchNew.AutoSize = true;
            this.linkLabel_batchNew.Location = new System.Drawing.Point(277, 16);
            this.linkLabel_batchNew.Name = "linkLabel_batchNew";
            this.linkLabel_batchNew.Size = new System.Drawing.Size(29, 13);
            this.linkLabel_batchNew.TabIndex = 12;
            this.linkLabel_batchNew.TabStop = true;
            this.linkLabel_batchNew.Text = "New";
            this.linkLabel_batchNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchNew_LinkClicked);
            // 
            // lblBatchName
            // 
            this.lblBatchName.AutoSize = true;
            this.lblBatchName.Location = new System.Drawing.Point(88, 104);
            this.lblBatchName.Name = "lblBatchName";
            this.lblBatchName.Size = new System.Drawing.Size(35, 13);
            this.lblBatchName.TabIndex = 10;
            this.lblBatchName.Text = "Batch";
            // 
            // lblBatchIsActive
            // 
            this.lblBatchIsActive.AutoSize = true;
            this.lblBatchIsActive.Location = new System.Drawing.Point(88, 130);
            this.lblBatchIsActive.Name = "lblBatchIsActive";
            this.lblBatchIsActive.Size = new System.Drawing.Size(37, 13);
            this.lblBatchIsActive.TabIndex = 9;
            this.lblBatchIsActive.Text = "Active";
            // 
            // lblBatchCode
            // 
            this.lblBatchCode.AutoSize = true;
            this.lblBatchCode.Location = new System.Drawing.Point(88, 78);
            this.lblBatchCode.Name = "lblBatchCode";
            this.lblBatchCode.Size = new System.Drawing.Size(32, 13);
            this.lblBatchCode.TabIndex = 7;
            this.lblBatchCode.Text = "Code";
            // 
            // linkLabel_batchCancel
            // 
            this.linkLabel_batchCancel.AutoSize = true;
            this.linkLabel_batchCancel.Location = new System.Drawing.Point(421, 16);
            this.linkLabel_batchCancel.Name = "linkLabel_batchCancel";
            this.linkLabel_batchCancel.Size = new System.Drawing.Size(40, 13);
            this.linkLabel_batchCancel.TabIndex = 6;
            this.linkLabel_batchCancel.TabStop = true;
            this.linkLabel_batchCancel.Text = "Cancel";
            this.linkLabel_batchCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchCancel_LinkClicked);
            // 
            // linkLabel_batchUpdate
            // 
            this.linkLabel_batchUpdate.AutoSize = true;
            this.linkLabel_batchUpdate.Location = new System.Drawing.Point(373, 16);
            this.linkLabel_batchUpdate.Name = "linkLabel_batchUpdate";
            this.linkLabel_batchUpdate.Size = new System.Drawing.Size(42, 13);
            this.linkLabel_batchUpdate.TabIndex = 5;
            this.linkLabel_batchUpdate.TabStop = true;
            this.linkLabel_batchUpdate.Text = "Update";
            this.linkLabel_batchUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchUpdate_LinkClicked);
            // 
            // linkLabel_batchAdd
            // 
            this.linkLabel_batchAdd.AutoSize = true;
            this.linkLabel_batchAdd.Location = new System.Drawing.Point(341, 16);
            this.linkLabel_batchAdd.Name = "linkLabel_batchAdd";
            this.linkLabel_batchAdd.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_batchAdd.TabIndex = 4;
            this.linkLabel_batchAdd.TabStop = true;
            this.linkLabel_batchAdd.Text = "Add";
            this.linkLabel_batchAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchAdd_LinkClicked);
            // 
            // linkLabel_batchAcitvate
            // 
            this.linkLabel_batchAcitvate.AutoSize = true;
            this.linkLabel_batchAcitvate.Location = new System.Drawing.Point(241, 130);
            this.linkLabel_batchAcitvate.Name = "linkLabel_batchAcitvate";
            this.linkLabel_batchAcitvate.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_batchAcitvate.TabIndex = 3;
            this.linkLabel_batchAcitvate.TabStop = true;
            this.linkLabel_batchAcitvate.Text = "Activate";
            this.linkLabel_batchAcitvate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_batchAcitvate_LinkClicked);
            // 
            // txtBatchIsActive
            // 
            this.txtBatchIsActive.Location = new System.Drawing.Point(166, 127);
            this.txtBatchIsActive.Name = "txtBatchIsActive";
            this.txtBatchIsActive.Size = new System.Drawing.Size(61, 20);
            this.txtBatchIsActive.TabIndex = 2;
            // 
            // txtBatchName
            // 
            this.txtBatchName.Location = new System.Drawing.Point(166, 101);
            this.txtBatchName.Name = "txtBatchName";
            this.txtBatchName.Size = new System.Drawing.Size(140, 20);
            this.txtBatchName.TabIndex = 1;
            // 
            // txtBatchCode
            // 
            this.txtBatchCode.Location = new System.Drawing.Point(166, 75);
            this.txtBatchCode.Name = "txtBatchCode";
            this.txtBatchCode.Size = new System.Drawing.Size(100, 20);
            this.txtBatchCode.TabIndex = 0;
            // 
            // BatchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 342);
            this.Controls.Add(this.groupBox_batchDetails);
            this.Controls.Add(this.groupBox_batchMaster);
            this.Name = "BatchMaster";
            this.Text = "BatchMaster";
            this.Load += new System.EventHandler(this.BatchMaster_Load);
            this.groupBox_batchMaster.ResumeLayout(false);
            this.groupBox_batchMaster.PerformLayout();
            this.groupBox_batchDetails.ResumeLayout(false);
            this.groupBox_batchDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_batchMaster;
        private System.Windows.Forms.Label lblBatchMaster;
        private System.Windows.Forms.LinkLabel linkLabel_batchMasterClose;
        private System.Windows.Forms.ComboBox cmbBatchMaster;
        private System.Windows.Forms.GroupBox groupBox_batchDetails;
        private System.Windows.Forms.Label lblBatchIsActive;
        private System.Windows.Forms.Label lblBatchCode;
        private System.Windows.Forms.LinkLabel linkLabel_batchCancel;
        private System.Windows.Forms.LinkLabel linkLabel_batchUpdate;
        private System.Windows.Forms.LinkLabel linkLabel_batchAdd;
        private System.Windows.Forms.LinkLabel linkLabel_batchAcitvate;
        private System.Windows.Forms.TextBox txtBatchIsActive;
        private System.Windows.Forms.TextBox txtBatchName;
        private System.Windows.Forms.TextBox txtBatchCode;
        private System.Windows.Forms.Label lblBatchName;
        private System.Windows.Forms.LinkLabel linkLabel_batchEdit;
        private System.Windows.Forms.LinkLabel linkLabel_batchNew;
    }
}