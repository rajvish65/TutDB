namespace TutDB
{
    partial class QuickInstallments
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
            this.label_NoOfInstallment = new System.Windows.Forms.Label();
            this.textBox_NoOfInstallment = new System.Windows.Forms.TextBox();
            this.label_InstallmentDate = new System.Windows.Forms.Label();
            this.label_Occurances = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.checkBox_CustomizedAmount = new System.Windows.Forms.CheckBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Occurance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Occurances = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_InstallmentDate = new System.Windows.Forms.DateTimePicker();
            this.button_QuickInstallmentSubmit = new System.Windows.Forms.Button();
            this.button_QuickInstallmentCancel = new System.Windows.Forms.Button();
            this.label_FeeAmount = new System.Windows.Forms.Label();
            this.textBox_FeeAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_remainingAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_NoOfInstallment
            // 
            this.label_NoOfInstallment.AutoSize = true;
            this.label_NoOfInstallment.Location = new System.Drawing.Point(50, 79);
            this.label_NoOfInstallment.Name = "label_NoOfInstallment";
            this.label_NoOfInstallment.Size = new System.Drawing.Size(88, 13);
            this.label_NoOfInstallment.TabIndex = 0;
            this.label_NoOfInstallment.Text = "No Of Installment";
            // 
            // textBox_NoOfInstallment
            // 
            this.textBox_NoOfInstallment.Location = new System.Drawing.Point(156, 76);
            this.textBox_NoOfInstallment.Name = "textBox_NoOfInstallment";
            this.textBox_NoOfInstallment.Size = new System.Drawing.Size(75, 20);
            this.textBox_NoOfInstallment.TabIndex = 1;
            // 
            // label_InstallmentDate
            // 
            this.label_InstallmentDate.AutoSize = true;
            this.label_InstallmentDate.Location = new System.Drawing.Point(50, 164);
            this.label_InstallmentDate.Name = "label_InstallmentDate";
            this.label_InstallmentDate.Size = new System.Drawing.Size(83, 13);
            this.label_InstallmentDate.TabIndex = 2;
            this.label_InstallmentDate.Text = "Installment Date";
            // 
            // label_Occurances
            // 
            this.label_Occurances.AutoSize = true;
            this.label_Occurances.Location = new System.Drawing.Point(50, 133);
            this.label_Occurances.Name = "label_Occurances";
            this.label_Occurances.Size = new System.Drawing.Size(65, 13);
            this.label_Occurances.TabIndex = 3;
            this.label_Occurances.Text = "Occurances";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(50, 107);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(43, 13);
            this.label_Amount.TabIndex = 4;
            this.label_Amount.Text = "Amount";
            // 
            // checkBox_CustomizedAmount
            // 
            this.checkBox_CustomizedAmount.AutoSize = true;
            this.checkBox_CustomizedAmount.Location = new System.Drawing.Point(156, 106);
            this.checkBox_CustomizedAmount.Name = "checkBox_CustomizedAmount";
            this.checkBox_CustomizedAmount.Size = new System.Drawing.Size(80, 17);
            this.checkBox_CustomizedAmount.TabIndex = 5;
            this.checkBox_CustomizedAmount.Text = "Customized";
            this.checkBox_CustomizedAmount.UseVisualStyleBackColor = true;
            this.checkBox_CustomizedAmount.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(246, 104);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(62, 20);
            this.textBox_Amount.TabIndex = 6;
            // 
            // textBox_Occurance
            // 
            this.textBox_Occurance.Location = new System.Drawing.Point(246, 130);
            this.textBox_Occurance.Name = "textBox_Occurance";
            this.textBox_Occurance.Size = new System.Drawing.Size(62, 20);
            this.textBox_Occurance.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "+";
            // 
            // comboBox_Occurances
            // 
            this.comboBox_Occurances.FormattingEnabled = true;
            this.comboBox_Occurances.Location = new System.Drawing.Point(156, 130);
            this.comboBox_Occurances.Name = "comboBox_Occurances";
            this.comboBox_Occurances.Size = new System.Drawing.Size(62, 21);
            this.comboBox_Occurances.TabIndex = 10;
            this.comboBox_Occurances.SelectedIndexChanged += new System.EventHandler(this.comboBox_Occurances_SelectedIndexChanged);
            // 
            // dateTimePicker_InstallmentDate
            // 
            this.dateTimePicker_InstallmentDate.Location = new System.Drawing.Point(156, 158);
            this.dateTimePicker_InstallmentDate.Name = "dateTimePicker_InstallmentDate";
            this.dateTimePicker_InstallmentDate.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_InstallmentDate.TabIndex = 11;
            // 
            // button_QuickInstallmentSubmit
            // 
            this.button_QuickInstallmentSubmit.Location = new System.Drawing.Point(156, 195);
            this.button_QuickInstallmentSubmit.Name = "button_QuickInstallmentSubmit";
            this.button_QuickInstallmentSubmit.Size = new System.Drawing.Size(75, 23);
            this.button_QuickInstallmentSubmit.TabIndex = 12;
            this.button_QuickInstallmentSubmit.Text = "Submit";
            this.button_QuickInstallmentSubmit.UseVisualStyleBackColor = true;
            this.button_QuickInstallmentSubmit.Click += new System.EventHandler(this.button_QuickInstallmentSubmit_Click);
            // 
            // button_QuickInstallmentCancel
            // 
            this.button_QuickInstallmentCancel.Location = new System.Drawing.Point(246, 195);
            this.button_QuickInstallmentCancel.Name = "button_QuickInstallmentCancel";
            this.button_QuickInstallmentCancel.Size = new System.Drawing.Size(75, 23);
            this.button_QuickInstallmentCancel.TabIndex = 13;
            this.button_QuickInstallmentCancel.Text = "Cancel";
            this.button_QuickInstallmentCancel.UseVisualStyleBackColor = true;
            this.button_QuickInstallmentCancel.Click += new System.EventHandler(this.button_QuickInstallmentCancel_Click);
            // 
            // label_FeeAmount
            // 
            this.label_FeeAmount.AutoSize = true;
            this.label_FeeAmount.Location = new System.Drawing.Point(50, 50);
            this.label_FeeAmount.Name = "label_FeeAmount";
            this.label_FeeAmount.Size = new System.Drawing.Size(30, 13);
            this.label_FeeAmount.TabIndex = 14;
            this.label_FeeAmount.Text = "Fees";
            // 
            // textBox_FeeAmount
            // 
            this.textBox_FeeAmount.Location = new System.Drawing.Point(156, 47);
            this.textBox_FeeAmount.Name = "textBox_FeeAmount";
            this.textBox_FeeAmount.Size = new System.Drawing.Size(75, 20);
            this.textBox_FeeAmount.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quick Installment Wizard";
            // 
            // textBox_remainingAmount
            // 
            this.textBox_remainingAmount.Location = new System.Drawing.Point(237, 47);
            this.textBox_remainingAmount.Name = "textBox_remainingAmount";
            this.textBox_remainingAmount.ReadOnly = true;
            this.textBox_remainingAmount.Size = new System.Drawing.Size(71, 20);
            this.textBox_remainingAmount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "(Remaining)";
            // 
            // QuickInstallments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_remainingAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_FeeAmount);
            this.Controls.Add(this.label_FeeAmount);
            this.Controls.Add(this.button_QuickInstallmentCancel);
            this.Controls.Add(this.button_QuickInstallmentSubmit);
            this.Controls.Add(this.dateTimePicker_InstallmentDate);
            this.Controls.Add(this.comboBox_Occurances);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Occurance);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.checkBox_CustomizedAmount);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_Occurances);
            this.Controls.Add(this.label_InstallmentDate);
            this.Controls.Add(this.textBox_NoOfInstallment);
            this.Controls.Add(this.label_NoOfInstallment);
            this.Name = "QuickInstallments";
            this.Text = "QuickInstallments";
            this.Load += new System.EventHandler(this.QuickInstallments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NoOfInstallment;
        private System.Windows.Forms.TextBox textBox_NoOfInstallment;
        private System.Windows.Forms.Label label_InstallmentDate;
        private System.Windows.Forms.Label label_Occurances;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.CheckBox checkBox_CustomizedAmount;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_Occurance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Occurances;
        private System.Windows.Forms.DateTimePicker dateTimePicker_InstallmentDate;
        private System.Windows.Forms.Button button_QuickInstallmentSubmit;
        private System.Windows.Forms.Button button_QuickInstallmentCancel;
        private System.Windows.Forms.Label label_FeeAmount;
        private System.Windows.Forms.TextBox textBox_FeeAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_remainingAmount;
        private System.Windows.Forms.Label label3;
    }
}