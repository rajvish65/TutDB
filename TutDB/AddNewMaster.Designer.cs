namespace TutDB
{
    partial class AddNewMaster
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
            this.button_addNew = new System.Windows.Forms.Button();
            this.textBox_addNewMaster = new System.Windows.Forms.TextBox();
            this.label_whichMaster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_addNew
            // 
            this.button_addNew.Location = new System.Drawing.Point(94, 83);
            this.button_addNew.Name = "button_addNew";
            this.button_addNew.Size = new System.Drawing.Size(75, 23);
            this.button_addNew.TabIndex = 4;
            this.button_addNew.Text = "Submit";
            this.button_addNew.UseVisualStyleBackColor = true;
            this.button_addNew.Click += new System.EventHandler(this.button_addNew_Click);
            // 
            // textBox_addNewMaster
            // 
            this.textBox_addNewMaster.Location = new System.Drawing.Point(144, 44);
            this.textBox_addNewMaster.Name = "textBox_addNewMaster";
            this.textBox_addNewMaster.Size = new System.Drawing.Size(107, 20);
            this.textBox_addNewMaster.TabIndex = 3;
            // 
            // label_whichMaster
            // 
            this.label_whichMaster.AutoSize = true;
            this.label_whichMaster.Location = new System.Drawing.Point(12, 47);
            this.label_whichMaster.Name = "label_whichMaster";
            this.label_whichMaster.Size = new System.Drawing.Size(0, 13);
            this.label_whichMaster.TabIndex = 5;
            // 
            // AddNewMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 138);
            this.Controls.Add(this.label_whichMaster);
            this.Controls.Add(this.button_addNew);
            this.Controls.Add(this.textBox_addNewMaster);
            this.Name = "AddNewMaster";
            this.Text = "Add New Entry";
            this.Load += new System.EventHandler(this.AddNewMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addNew;
        private System.Windows.Forms.TextBox textBox_addNewMaster;
        private System.Windows.Forms.Label label_whichMaster;
    }
}