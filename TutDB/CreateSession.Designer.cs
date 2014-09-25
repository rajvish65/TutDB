namespace TutDB
{
    partial class CreateSession
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
            this.label_sessionOwner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_sessionDescription = new System.Windows.Forms.Label();
            this.comboBox_sessionOwner = new System.Windows.Forms.ComboBox();
            this.richTextBox_sessionDescription = new System.Windows.Forms.RichTextBox();
            this.comboBox_durationHours = new System.Windows.Forms.ComboBox();
            this.comboBox_durationMinutes = new System.Windows.Forms.ComboBox();
            this.comboBox_sessionOccurances = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_createSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_sessionOwner
            // 
            this.label_sessionOwner.AutoSize = true;
            this.label_sessionOwner.Location = new System.Drawing.Point(27, 50);
            this.label_sessionOwner.Name = "label_sessionOwner";
            this.label_sessionOwner.Size = new System.Drawing.Size(78, 13);
            this.label_sessionOwner.TabIndex = 0;
            this.label_sessionOwner.Text = "Session Owner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Occurances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration(in minutes)";
            // 
            // label_sessionDescription
            // 
            this.label_sessionDescription.AutoSize = true;
            this.label_sessionDescription.Location = new System.Drawing.Point(27, 81);
            this.label_sessionDescription.Name = "label_sessionDescription";
            this.label_sessionDescription.Size = new System.Drawing.Size(60, 13);
            this.label_sessionDescription.TabIndex = 3;
            this.label_sessionDescription.Text = "Description";
            // 
            // comboBox_sessionOwner
            // 
            this.comboBox_sessionOwner.FormattingEnabled = true;
            this.comboBox_sessionOwner.Location = new System.Drawing.Point(156, 50);
            this.comboBox_sessionOwner.Name = "comboBox_sessionOwner";
            this.comboBox_sessionOwner.Size = new System.Drawing.Size(129, 21);
            this.comboBox_sessionOwner.TabIndex = 4;
            // 
            // richTextBox_sessionDescription
            // 
            this.richTextBox_sessionDescription.Location = new System.Drawing.Point(156, 78);
            this.richTextBox_sessionDescription.Name = "richTextBox_sessionDescription";
            this.richTextBox_sessionDescription.Size = new System.Drawing.Size(213, 57);
            this.richTextBox_sessionDescription.TabIndex = 5;
            this.richTextBox_sessionDescription.Text = "";
            // 
            // comboBox_durationHours
            // 
            this.comboBox_durationHours.FormattingEnabled = true;
            this.comboBox_durationHours.Location = new System.Drawing.Point(156, 154);
            this.comboBox_durationHours.Name = "comboBox_durationHours";
            this.comboBox_durationHours.Size = new System.Drawing.Size(70, 21);
            this.comboBox_durationHours.TabIndex = 6;
            // 
            // comboBox_durationMinutes
            // 
            this.comboBox_durationMinutes.FormattingEnabled = true;
            this.comboBox_durationMinutes.Location = new System.Drawing.Point(261, 154);
            this.comboBox_durationMinutes.Name = "comboBox_durationMinutes";
            this.comboBox_durationMinutes.Size = new System.Drawing.Size(67, 21);
            this.comboBox_durationMinutes.TabIndex = 7;
            // 
            // comboBox_sessionOccurances
            // 
            this.comboBox_sessionOccurances.FormattingEnabled = true;
            this.comboBox_sessionOccurances.Location = new System.Drawing.Point(156, 186);
            this.comboBox_sessionOccurances.Name = "comboBox_sessionOccurances";
            this.comboBox_sessionOccurances.Size = new System.Drawing.Size(129, 21);
            this.comboBox_sessionOccurances.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "HH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MM";
            // 
            // button_createSession
            // 
            this.button_createSession.Location = new System.Drawing.Point(156, 213);
            this.button_createSession.Name = "button_createSession";
            this.button_createSession.Size = new System.Drawing.Size(75, 23);
            this.button_createSession.TabIndex = 11;
            this.button_createSession.Text = "Submit";
            this.button_createSession.UseVisualStyleBackColor = true;
            this.button_createSession.Click += new System.EventHandler(this.button_createSession_Click);
            // 
            // CreateSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 258);
            this.Controls.Add(this.button_createSession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_sessionOccurances);
            this.Controls.Add(this.comboBox_durationMinutes);
            this.Controls.Add(this.comboBox_durationHours);
            this.Controls.Add(this.richTextBox_sessionDescription);
            this.Controls.Add(this.comboBox_sessionOwner);
            this.Controls.Add(this.label_sessionDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_sessionOwner);
            this.Name = "CreateSession";
            this.Text = "CreateSession";
            this.Load += new System.EventHandler(this.CreateSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_sessionOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sessionDescription;
        private System.Windows.Forms.ComboBox comboBox_sessionOwner;
        private System.Windows.Forms.RichTextBox richTextBox_sessionDescription;
        private System.Windows.Forms.ComboBox comboBox_durationHours;
        private System.Windows.Forms.ComboBox comboBox_durationMinutes;
        private System.Windows.Forms.ComboBox comboBox_sessionOccurances;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_createSession;
    }
}