namespace TutDB
{
    partial class FeeStructure
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_QuickInstallment = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_InstallmentNotification = new System.Windows.Forms.Label();
            this.dataGridView_feeStructure = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel_feeStructEdit = new System.Windows.Forms.LinkLabel();
            this.linkLabel_feeStructNew = new System.Windows.Forms.LinkLabel();
            this.linkLabel_feeStructCancel = new System.Windows.Forms.LinkLabel();
            this.linkLabel_feeStructUpdate = new System.Windows.Forms.LinkLabel();
            this.linkLabel_feeStructAdd = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker_installmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtInstallmentAmount = new System.Windows.Forms.TextBox();
            this.txtInstallmentNo = new System.Windows.Forms.TextBox();
            this.lblFeeAmountRemaining = new System.Windows.Forms.Label();
            this.lblFeesAmount = new System.Windows.Forms.Label();
            this.label_InstallmentAmount = new System.Windows.Forms.Label();
            this.label_LastDate = new System.Windows.Forms.Label();
            this.label_totalFees = new System.Windows.Forms.Label();
            this.label_remaningFees = new System.Windows.Forms.Label();
            this.label_InstallmentNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feeStructure)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_QuickInstallment);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.label_InstallmentNotification);
            this.groupBox1.Controls.Add(this.dataGridView_feeStructure);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee Structure";
            // 
            // button_QuickInstallment
            // 
            this.button_QuickInstallment.Location = new System.Drawing.Point(282, 200);
            this.button_QuickInstallment.Name = "button_QuickInstallment";
            this.button_QuickInstallment.Size = new System.Drawing.Size(116, 23);
            this.button_QuickInstallment.TabIndex = 5;
            this.button_QuickInstallment.Text = "Quick Installments";
            this.button_QuickInstallment.UseVisualStyleBackColor = true;
            this.button_QuickInstallment.Click += new System.EventHandler(this.button_QuickInstallment_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(414, 201);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_InstallmentNotification
            // 
            this.label_InstallmentNotification.AutoSize = true;
            this.label_InstallmentNotification.Location = new System.Drawing.Point(6, 210);
            this.label_InstallmentNotification.Name = "label_InstallmentNotification";
            this.label_InstallmentNotification.Size = new System.Drawing.Size(0, 13);
            this.label_InstallmentNotification.TabIndex = 3;
            // 
            // dataGridView_feeStructure
            // 
            this.dataGridView_feeStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_feeStructure.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_feeStructure.Name = "dataGridView_feeStructure";
            this.dataGridView_feeStructure.RowHeadersVisible = false;
            this.dataGridView_feeStructure.Size = new System.Drawing.Size(510, 176);
            this.dataGridView_feeStructure.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel_feeStructEdit);
            this.groupBox2.Controls.Add(this.linkLabel_feeStructNew);
            this.groupBox2.Controls.Add(this.linkLabel_feeStructCancel);
            this.groupBox2.Controls.Add(this.linkLabel_feeStructUpdate);
            this.groupBox2.Controls.Add(this.linkLabel_feeStructAdd);
            this.groupBox2.Controls.Add(this.dateTimePicker_installmentDate);
            this.groupBox2.Controls.Add(this.txtInstallmentAmount);
            this.groupBox2.Controls.Add(this.txtInstallmentNo);
            this.groupBox2.Controls.Add(this.lblFeeAmountRemaining);
            this.groupBox2.Controls.Add(this.lblFeesAmount);
            this.groupBox2.Controls.Add(this.label_InstallmentAmount);
            this.groupBox2.Controls.Add(this.label_LastDate);
            this.groupBox2.Controls.Add(this.label_totalFees);
            this.groupBox2.Controls.Add(this.label_remaningFees);
            this.groupBox2.Controls.Add(this.label_InstallmentNo);
            this.groupBox2.Location = new System.Drawing.Point(13, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fee";
            // 
            // linkLabel_feeStructEdit
            // 
            this.linkLabel_feeStructEdit.AutoSize = true;
            this.linkLabel_feeStructEdit.Location = new System.Drawing.Point(311, 16);
            this.linkLabel_feeStructEdit.Name = "linkLabel_feeStructEdit";
            this.linkLabel_feeStructEdit.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_feeStructEdit.TabIndex = 16;
            this.linkLabel_feeStructEdit.TabStop = true;
            this.linkLabel_feeStructEdit.Text = "Edit";
            // 
            // linkLabel_feeStructNew
            // 
            this.linkLabel_feeStructNew.AutoSize = true;
            this.linkLabel_feeStructNew.Location = new System.Drawing.Point(279, 16);
            this.linkLabel_feeStructNew.Name = "linkLabel_feeStructNew";
            this.linkLabel_feeStructNew.Size = new System.Drawing.Size(29, 13);
            this.linkLabel_feeStructNew.TabIndex = 15;
            this.linkLabel_feeStructNew.TabStop = true;
            this.linkLabel_feeStructNew.Text = "New";
            this.linkLabel_feeStructNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_feeStructNew_LinkClicked);
            // 
            // linkLabel_feeStructCancel
            // 
            this.linkLabel_feeStructCancel.AutoSize = true;
            this.linkLabel_feeStructCancel.Location = new System.Drawing.Point(423, 16);
            this.linkLabel_feeStructCancel.Name = "linkLabel_feeStructCancel";
            this.linkLabel_feeStructCancel.Size = new System.Drawing.Size(40, 13);
            this.linkLabel_feeStructCancel.TabIndex = 14;
            this.linkLabel_feeStructCancel.TabStop = true;
            this.linkLabel_feeStructCancel.Text = "Cancel";
            this.linkLabel_feeStructCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_feeStructCancel_LinkClicked);
            // 
            // linkLabel_feeStructUpdate
            // 
            this.linkLabel_feeStructUpdate.AutoSize = true;
            this.linkLabel_feeStructUpdate.Location = new System.Drawing.Point(375, 16);
            this.linkLabel_feeStructUpdate.Name = "linkLabel_feeStructUpdate";
            this.linkLabel_feeStructUpdate.Size = new System.Drawing.Size(42, 13);
            this.linkLabel_feeStructUpdate.TabIndex = 13;
            this.linkLabel_feeStructUpdate.TabStop = true;
            this.linkLabel_feeStructUpdate.Text = "Update";
            // 
            // linkLabel_feeStructAdd
            // 
            this.linkLabel_feeStructAdd.AutoSize = true;
            this.linkLabel_feeStructAdd.Location = new System.Drawing.Point(343, 16);
            this.linkLabel_feeStructAdd.Name = "linkLabel_feeStructAdd";
            this.linkLabel_feeStructAdd.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_feeStructAdd.TabIndex = 12;
            this.linkLabel_feeStructAdd.TabStop = true;
            this.linkLabel_feeStructAdd.Text = "Add";
            this.linkLabel_feeStructAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_feeStructAdd_LinkClicked);
            // 
            // dateTimePicker_installmentDate
            // 
            this.dateTimePicker_installmentDate.Location = new System.Drawing.Point(278, 131);
            this.dateTimePicker_installmentDate.Name = "dateTimePicker_installmentDate";
            this.dateTimePicker_installmentDate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_installmentDate.TabIndex = 10;
            // 
            // txtInstallmentAmount
            // 
            this.txtInstallmentAmount.Location = new System.Drawing.Point(147, 131);
            this.txtInstallmentAmount.Name = "txtInstallmentAmount";
            this.txtInstallmentAmount.Size = new System.Drawing.Size(125, 20);
            this.txtInstallmentAmount.TabIndex = 9;
            // 
            // txtInstallmentNo
            // 
            this.txtInstallmentNo.Location = new System.Drawing.Point(49, 131);
            this.txtInstallmentNo.Name = "txtInstallmentNo";
            this.txtInstallmentNo.Size = new System.Drawing.Size(92, 20);
            this.txtInstallmentNo.TabIndex = 7;
            // 
            // lblFeeAmountRemaining
            // 
            this.lblFeeAmountRemaining.AutoSize = true;
            this.lblFeeAmountRemaining.Location = new System.Drawing.Point(174, 46);
            this.lblFeeAmountRemaining.Name = "lblFeeAmountRemaining";
            this.lblFeeAmountRemaining.Size = new System.Drawing.Size(0, 13);
            this.lblFeeAmountRemaining.TabIndex = 6;
            // 
            // lblFeesAmount
            // 
            this.lblFeesAmount.AutoSize = true;
            this.lblFeesAmount.Location = new System.Drawing.Point(69, 46);
            this.lblFeesAmount.Name = "lblFeesAmount";
            this.lblFeesAmount.Size = new System.Drawing.Size(0, 13);
            this.lblFeesAmount.TabIndex = 5;
            // 
            // label_InstallmentAmount
            // 
            this.label_InstallmentAmount.AutoSize = true;
            this.label_InstallmentAmount.Location = new System.Drawing.Point(187, 101);
            this.label_InstallmentAmount.Name = "label_InstallmentAmount";
            this.label_InstallmentAmount.Size = new System.Drawing.Size(43, 13);
            this.label_InstallmentAmount.TabIndex = 4;
            this.label_InstallmentAmount.Text = "Amount";
            // 
            // label_LastDate
            // 
            this.label_LastDate.AutoSize = true;
            this.label_LastDate.Location = new System.Drawing.Point(311, 101);
            this.label_LastDate.Name = "label_LastDate";
            this.label_LastDate.Size = new System.Drawing.Size(53, 13);
            this.label_LastDate.TabIndex = 3;
            this.label_LastDate.Text = "Last Date";
            // 
            // label_totalFees
            // 
            this.label_totalFees.AutoSize = true;
            this.label_totalFees.Location = new System.Drawing.Point(6, 46);
            this.label_totalFees.Name = "label_totalFees";
            this.label_totalFees.Size = new System.Drawing.Size(57, 13);
            this.label_totalFees.TabIndex = 2;
            this.label_totalFees.Text = "Total Fees";
            // 
            // label_remaningFees
            // 
            this.label_remaningFees.AutoSize = true;
            this.label_remaningFees.Location = new System.Drawing.Point(117, 46);
            this.label_remaningFees.Name = "label_remaningFees";
            this.label_remaningFees.Size = new System.Drawing.Size(57, 13);
            this.label_remaningFees.TabIndex = 1;
            this.label_remaningFees.Text = "Remaining";
            // 
            // label_InstallmentNo
            // 
            this.label_InstallmentNo.AutoSize = true;
            this.label_InstallmentNo.Location = new System.Drawing.Point(57, 101);
            this.label_InstallmentNo.Name = "label_InstallmentNo";
            this.label_InstallmentNo.Size = new System.Drawing.Size(74, 13);
            this.label_InstallmentNo.TabIndex = 0;
            this.label_InstallmentNo.Text = "Installment No";
            // 
            // FeeStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FeeStructure";
            this.Text = "FeeStructure";
            this.Load += new System.EventHandler(this.FeeStructure_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_feeStructure)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_feeStructure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_InstallmentAmount;
        private System.Windows.Forms.Label label_LastDate;
        private System.Windows.Forms.Label label_totalFees;
        private System.Windows.Forms.Label label_remaningFees;
        private System.Windows.Forms.Label label_InstallmentNo;
        private System.Windows.Forms.Label lblFeeAmountRemaining;
        private System.Windows.Forms.Label lblFeesAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_installmentDate;
        private System.Windows.Forms.TextBox txtInstallmentAmount;
        private System.Windows.Forms.TextBox txtInstallmentNo;
        private System.Windows.Forms.LinkLabel linkLabel_feeStructEdit;
        private System.Windows.Forms.LinkLabel linkLabel_feeStructNew;
        private System.Windows.Forms.LinkLabel linkLabel_feeStructCancel;
        private System.Windows.Forms.LinkLabel linkLabel_feeStructUpdate;
        private System.Windows.Forms.LinkLabel linkLabel_feeStructAdd;
        private System.Windows.Forms.Label label_InstallmentNotification;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_QuickInstallment;
    }
}