namespace TutDB
{
    partial class NewAllocation
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
            this.button_AddAllocation = new System.Windows.Forms.Button();
            this.dateTimePicker_endDateAllocate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startDateAllocate = new System.Windows.Forms.DateTimePicker();
            this.label_startDateAdd = new System.Windows.Forms.Label();
            this.label_endDateAdd = new System.Windows.Forms.Label();
            this.label_courseAdd = new System.Windows.Forms.Label();
            this.label_batchAdd = new System.Windows.Forms.Label();
            this.comboBox_batchAllocate = new System.Windows.Forms.ComboBox();
            this.comboBox_courseAllocate = new System.Windows.Forms.ComboBox();
            this.txtActualFees = new System.Windows.Forms.TextBox();
            this.lblActualFees = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.lblFees = new System.Windows.Forms.Label();
            this.cmbLastQualificationScore = new System.Windows.Forms.ComboBox();
            this.combobox_lastQualificationAllocate = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddAllocation
            // 
            this.button_AddAllocation.Location = new System.Drawing.Point(124, 313);
            this.button_AddAllocation.Name = "button_AddAllocation";
            this.button_AddAllocation.Size = new System.Drawing.Size(75, 23);
            this.button_AddAllocation.TabIndex = 87;
            this.button_AddAllocation.Text = "Allocate";
            this.button_AddAllocation.UseVisualStyleBackColor = true;
            this.button_AddAllocation.Click += new System.EventHandler(this.button_AddAllocation_Click);
            // 
            // dateTimePicker_endDateAllocate
            // 
            this.dateTimePicker_endDateAllocate.Location = new System.Drawing.Point(125, 160);
            this.dateTimePicker_endDateAllocate.Name = "dateTimePicker_endDateAllocate";
            this.dateTimePicker_endDateAllocate.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker_endDateAllocate.TabIndex = 86;
            // 
            // dateTimePicker_startDateAllocate
            // 
            this.dateTimePicker_startDateAllocate.Location = new System.Drawing.Point(124, 134);
            this.dateTimePicker_startDateAllocate.Name = "dateTimePicker_startDateAllocate";
            this.dateTimePicker_startDateAllocate.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker_startDateAllocate.TabIndex = 85;
            this.dateTimePicker_startDateAllocate.Value = new System.DateTime(2014, 9, 20, 2, 26, 43, 0);
            // 
            // label_startDateAdd
            // 
            this.label_startDateAdd.AutoSize = true;
            this.label_startDateAdd.Location = new System.Drawing.Point(25, 137);
            this.label_startDateAdd.Name = "label_startDateAdd";
            this.label_startDateAdd.Size = new System.Drawing.Size(55, 13);
            this.label_startDateAdd.TabIndex = 84;
            this.label_startDateAdd.Text = "Start Date";
            // 
            // label_endDateAdd
            // 
            this.label_endDateAdd.AutoSize = true;
            this.label_endDateAdd.Location = new System.Drawing.Point(25, 163);
            this.label_endDateAdd.Name = "label_endDateAdd";
            this.label_endDateAdd.Size = new System.Drawing.Size(52, 13);
            this.label_endDateAdd.TabIndex = 83;
            this.label_endDateAdd.Text = "End Date";
            // 
            // label_courseAdd
            // 
            this.label_courseAdd.AutoSize = true;
            this.label_courseAdd.Location = new System.Drawing.Point(25, 19);
            this.label_courseAdd.Name = "label_courseAdd";
            this.label_courseAdd.Size = new System.Drawing.Size(40, 13);
            this.label_courseAdd.TabIndex = 82;
            this.label_courseAdd.Text = "Course";
            // 
            // label_batchAdd
            // 
            this.label_batchAdd.AutoSize = true;
            this.label_batchAdd.Location = new System.Drawing.Point(25, 46);
            this.label_batchAdd.Name = "label_batchAdd";
            this.label_batchAdd.Size = new System.Drawing.Size(35, 13);
            this.label_batchAdd.TabIndex = 81;
            this.label_batchAdd.Text = "Batch";
            // 
            // comboBox_batchAllocate
            // 
            this.comboBox_batchAllocate.FormattingEnabled = true;
            this.comboBox_batchAllocate.Location = new System.Drawing.Point(125, 46);
            this.comboBox_batchAllocate.Name = "comboBox_batchAllocate";
            this.comboBox_batchAllocate.Size = new System.Drawing.Size(130, 21);
            this.comboBox_batchAllocate.TabIndex = 80;
            // 
            // comboBox_courseAllocate
            // 
            this.comboBox_courseAllocate.FormattingEnabled = true;
            this.comboBox_courseAllocate.Location = new System.Drawing.Point(125, 19);
            this.comboBox_courseAllocate.Name = "comboBox_courseAllocate";
            this.comboBox_courseAllocate.Size = new System.Drawing.Size(130, 21);
            this.comboBox_courseAllocate.TabIndex = 79;
            this.comboBox_courseAllocate.SelectedIndexChanged += new System.EventHandler(this.comboBox_courseAllocate_SelectedIndexChanged);
            // 
            // txtActualFees
            // 
            this.txtActualFees.Location = new System.Drawing.Point(126, 243);
            this.txtActualFees.MaxLength = 10;
            this.txtActualFees.Name = "txtActualFees";
            this.txtActualFees.Size = new System.Drawing.Size(130, 20);
            this.txtActualFees.TabIndex = 95;
            // 
            // lblActualFees
            // 
            this.lblActualFees.AutoSize = true;
            this.lblActualFees.Location = new System.Drawing.Point(25, 246);
            this.lblActualFees.Name = "lblActualFees";
            this.lblActualFees.Size = new System.Drawing.Size(63, 13);
            this.lblActualFees.TabIndex = 94;
            this.lblActualFees.Text = "Actual Fees";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(126, 274);
            this.txtDeposit.MaxLength = 10;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(129, 20);
            this.txtDeposit.TabIndex = 93;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(125, 212);
            this.txtDiscount.MaxLength = 10;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(130, 20);
            this.txtDiscount.TabIndex = 92;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(25, 274);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(43, 13);
            this.lblDeposit.TabIndex = 91;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(25, 216);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 90;
            this.lblDiscount.Text = "Discount";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(125, 186);
            this.txtFees.MaxLength = 10;
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(130, 20);
            this.txtFees.TabIndex = 89;
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(25, 190);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(30, 13);
            this.lblFees.TabIndex = 88;
            this.lblFees.Text = "Fees";
            // 
            // cmbLastQualificationScore
            // 
            this.cmbLastQualificationScore.FormattingEnabled = true;
            this.cmbLastQualificationScore.Items.AddRange(new object[] {
            "0% - 10%",
            "11% - 20%",
            "21% - 30%",
            "31% - 40%",
            "41% - 50%",
            "51% - 60%",
            "61% - 70%",
            "71% - 80%",
            "81% - 90%",
            "91% - 10%"});
            this.cmbLastQualificationScore.Location = new System.Drawing.Point(126, 107);
            this.cmbLastQualificationScore.Name = "cmbLastQualificationScore";
            this.cmbLastQualificationScore.Size = new System.Drawing.Size(129, 21);
            this.cmbLastQualificationScore.TabIndex = 99;
            // 
            // combobox_lastQualificationAllocate
            // 
            this.combobox_lastQualificationAllocate.FormattingEnabled = true;
            this.combobox_lastQualificationAllocate.Items.AddRange(new object[] {
            "Xth S.S.C.",
            "Xth H.S.C"});
            this.combobox_lastQualificationAllocate.Location = new System.Drawing.Point(126, 78);
            this.combobox_lastQualificationAllocate.Name = "combobox_lastQualificationAllocate";
            this.combobox_lastQualificationAllocate.Size = new System.Drawing.Size(129, 21);
            this.combobox_lastQualificationAllocate.TabIndex = 98;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(25, 107);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 97;
            this.lblScore.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Last Qualification";
            // 
            // NewAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLastQualificationScore);
            this.Controls.Add(this.combobox_lastQualificationAllocate);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtActualFees);
            this.Controls.Add(this.lblActualFees);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.button_AddAllocation);
            this.Controls.Add(this.dateTimePicker_endDateAllocate);
            this.Controls.Add(this.dateTimePicker_startDateAllocate);
            this.Controls.Add(this.label_startDateAdd);
            this.Controls.Add(this.label_endDateAdd);
            this.Controls.Add(this.label_courseAdd);
            this.Controls.Add(this.label_batchAdd);
            this.Controls.Add(this.comboBox_batchAllocate);
            this.Controls.Add(this.comboBox_courseAllocate);
            this.Name = "NewAllocation";
            this.Text = "NewAllocation";
            this.Load += new System.EventHandler(this.NewAllocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddAllocation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endDateAllocate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startDateAllocate;
        private System.Windows.Forms.Label label_startDateAdd;
        private System.Windows.Forms.Label label_endDateAdd;
        private System.Windows.Forms.Label label_courseAdd;
        private System.Windows.Forms.Label label_batchAdd;
        private System.Windows.Forms.ComboBox comboBox_batchAllocate;
        private System.Windows.Forms.ComboBox comboBox_courseAllocate;
        private System.Windows.Forms.TextBox txtActualFees;
        private System.Windows.Forms.Label lblActualFees;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.ComboBox cmbLastQualificationScore;
        private System.Windows.Forms.ComboBox combobox_lastQualificationAllocate;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
    }
}