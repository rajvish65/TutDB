namespace TutDB
{
    partial class SearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.combo_batch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_course = new System.Windows.Forms.ComboBox();
            this.button_refreshStudentDetails = new System.Windows.Forms.Button();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_studentLastName = new System.Windows.Forms.TextBox();
            this.button_Search_StudentDetails = new System.Windows.Forms.Button();
            this.textBox_studentFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_refreshEmployee = new System.Windows.Forms.Button();
            this.textBox_employeeLastName = new System.Windows.Forms.TextBox();
            this.button_Search_EmployeeDetails = new System.Windows.Forms.Button();
            this.textBox_employeeFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_searchEmployeeResult = new System.Windows.Forms.DataGridView();
            this.dataGridView_studentSearchResults = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchEmployeeResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 475);
            this.tabControl1.TabIndex = 80;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_studentSearchResults);
            this.tabPage1.Controls.Add(this.combo_batch);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.combo_course);
            this.tabPage1.Controls.Add(this.button_refreshStudentDetails);
            this.tabPage1.Controls.Add(this.textBox_balance);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_studentLastName);
            this.tabPage1.Controls.Add(this.button_Search_StudentDetails);
            this.tabPage1.Controls.Add(this.textBox_studentFirstName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // combo_batch
            // 
            this.combo_batch.FormattingEnabled = true;
            this.combo_batch.Location = new System.Drawing.Point(299, 35);
            this.combo_batch.Name = "combo_batch";
            this.combo_batch.Size = new System.Drawing.Size(100, 21);
            this.combo_batch.TabIndex = 93;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Batch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Course";
            // 
            // combo_course
            // 
            this.combo_course.FormattingEnabled = true;
            this.combo_course.Location = new System.Drawing.Point(86, 35);
            this.combo_course.Name = "combo_course";
            this.combo_course.Size = new System.Drawing.Size(121, 21);
            this.combo_course.TabIndex = 89;
            // 
            // button_refreshStudentDetails
            // 
            this.button_refreshStudentDetails.Location = new System.Drawing.Point(676, 60);
            this.button_refreshStudentDetails.Name = "button_refreshStudentDetails";
            this.button_refreshStudentDetails.Size = new System.Drawing.Size(75, 22);
            this.button_refreshStudentDetails.TabIndex = 88;
            this.button_refreshStudentDetails.Text = "Refresh";
            this.button_refreshStudentDetails.UseVisualStyleBackColor = true;
            // 
            // textBox_balance
            // 
            this.textBox_balance.Location = new System.Drawing.Point(86, 67);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.Size = new System.Drawing.Size(70, 20);
            this.textBox_balance.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Balance >=";
            // 
            // textBox_studentLastName
            // 
            this.textBox_studentLastName.Location = new System.Drawing.Point(190, 6);
            this.textBox_studentLastName.Name = "textBox_studentLastName";
            this.textBox_studentLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_studentLastName.TabIndex = 85;
            // 
            // button_Search_StudentDetails
            // 
            this.button_Search_StudentDetails.Location = new System.Drawing.Point(577, 59);
            this.button_Search_StudentDetails.Name = "button_Search_StudentDetails";
            this.button_Search_StudentDetails.Size = new System.Drawing.Size(75, 23);
            this.button_Search_StudentDetails.TabIndex = 84;
            this.button_Search_StudentDetails.Text = "Search";
            this.button_Search_StudentDetails.UseVisualStyleBackColor = true;
            this.button_Search_StudentDetails.Click += new System.EventHandler(this.button_Search_StudentDetails_Click);
            // 
            // textBox_studentFirstName
            // 
            this.textBox_studentFirstName.Location = new System.Drawing.Point(86, 6);
            this.textBox_studentFirstName.Name = "textBox_studentFirstName";
            this.textBox_studentFirstName.Size = new System.Drawing.Size(98, 20);
            this.textBox_studentFirstName.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_searchEmployeeResult);
            this.tabPage2.Controls.Add(this.button_refreshEmployee);
            this.tabPage2.Controls.Add(this.textBox_employeeLastName);
            this.tabPage2.Controls.Add(this.button_Search_EmployeeDetails);
            this.tabPage2.Controls.Add(this.textBox_employeeFirstName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_refreshEmployee
            // 
            this.button_refreshEmployee.Location = new System.Drawing.Point(503, 59);
            this.button_refreshEmployee.Name = "button_refreshEmployee";
            this.button_refreshEmployee.Size = new System.Drawing.Size(75, 22);
            this.button_refreshEmployee.TabIndex = 97;
            this.button_refreshEmployee.Text = "Refresh";
            this.button_refreshEmployee.UseVisualStyleBackColor = true;
            // 
            // textBox_employeeLastName
            // 
            this.textBox_employeeLastName.Location = new System.Drawing.Point(187, 34);
            this.textBox_employeeLastName.Name = "textBox_employeeLastName";
            this.textBox_employeeLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_employeeLastName.TabIndex = 94;
            // 
            // button_Search_EmployeeDetails
            // 
            this.button_Search_EmployeeDetails.Location = new System.Drawing.Point(404, 58);
            this.button_Search_EmployeeDetails.Name = "button_Search_EmployeeDetails";
            this.button_Search_EmployeeDetails.Size = new System.Drawing.Size(75, 23);
            this.button_Search_EmployeeDetails.TabIndex = 93;
            this.button_Search_EmployeeDetails.Text = "Search";
            this.button_Search_EmployeeDetails.UseVisualStyleBackColor = true;
            this.button_Search_EmployeeDetails.Click += new System.EventHandler(this.button_Search_EmployeeDetails_Click);
            // 
            // textBox_employeeFirstName
            // 
            this.textBox_employeeFirstName.Location = new System.Drawing.Point(83, 34);
            this.textBox_employeeFirstName.Name = "textBox_employeeFirstName";
            this.textBox_employeeFirstName.Size = new System.Drawing.Size(98, 20);
            this.textBox_employeeFirstName.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Name:";
            // 
            // dataGridView_searchEmployeeResult
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_searchEmployeeResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_searchEmployeeResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_searchEmployeeResult.Location = new System.Drawing.Point(0, 110);
            this.dataGridView_searchEmployeeResult.Name = "dataGridView_searchEmployeeResult";
            this.dataGridView_searchEmployeeResult.RowHeadersVisible = false;
            this.dataGridView_searchEmployeeResult.Size = new System.Drawing.Size(791, 339);
            this.dataGridView_searchEmployeeResult.TabIndex = 98;
            // 
            // dataGridView_studentSearchResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_studentSearchResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_studentSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentSearchResults.Location = new System.Drawing.Point(0, 108);
            this.dataGridView_studentSearchResults.Name = "dataGridView_studentSearchResults";
            this.dataGridView_studentSearchResults.RowHeadersVisible = false;
            this.dataGridView_studentSearchResults.Size = new System.Drawing.Size(791, 345);
            this.dataGridView_studentSearchResults.TabIndex = 94;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchEmployeeResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_refreshStudentDetails;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_studentLastName;
        private System.Windows.Forms.Button button_Search_StudentDetails;
        private System.Windows.Forms.TextBox textBox_studentFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_refreshEmployee;
        private System.Windows.Forms.TextBox textBox_employeeLastName;
        private System.Windows.Forms.Button button_Search_EmployeeDetails;
        private System.Windows.Forms.TextBox textBox_employeeFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_batch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_course;
        private System.Windows.Forms.DataGridView dataGridView_studentSearchResults;
        private System.Windows.Forms.DataGridView dataGridView_searchEmployeeResult;
    }
}