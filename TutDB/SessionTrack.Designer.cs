namespace TutDB
{
    partial class SessionTrack
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
            this.panel_sessionList = new System.Windows.Forms.Panel();
            this.button_createSession = new System.Windows.Forms.Button();
            this.treeView_locationView = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_sessionTrackDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sessionList
            // 
            this.panel_sessionList.AutoScroll = true;
            this.panel_sessionList.Location = new System.Drawing.Point(13, 77);
            this.panel_sessionList.Name = "panel_sessionList";
            this.panel_sessionList.Size = new System.Drawing.Size(111, 256);
            this.panel_sessionList.TabIndex = 0;
            // 
            // button_createSession
            // 
            this.button_createSession.Location = new System.Drawing.Point(12, 48);
            this.button_createSession.Name = "button_createSession";
            this.button_createSession.Size = new System.Drawing.Size(112, 23);
            this.button_createSession.TabIndex = 1;
            this.button_createSession.Text = "Create Session";
            this.button_createSession.UseVisualStyleBackColor = true;
            this.button_createSession.Click += new System.EventHandler(this.button_createSession_Click);
            // 
            // treeView_locationView
            // 
            this.treeView_locationView.Location = new System.Drawing.Point(130, 127);
            this.treeView_locationView.Name = "treeView_locationView";
            this.treeView_locationView.Size = new System.Drawing.Size(115, 206);
            this.treeView_locationView.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(431, 285);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker_sessionTrackDate
            // 
            this.dateTimePicker_sessionTrackDate.Location = new System.Drawing.Point(555, 22);
            this.dateTimePicker_sessionTrackDate.Name = "dateTimePicker_sessionTrackDate";
            this.dateTimePicker_sessionTrackDate.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker_sessionTrackDate.TabIndex = 3;
            this.dateTimePicker_sessionTrackDate.ValueChanged += new System.EventHandler(this.dateTimePicker_sessionTrackDate_ValueChanged);
            // 
            // SessionTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 358);
            this.Controls.Add(this.dateTimePicker_sessionTrackDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView_locationView);
            this.Controls.Add(this.button_createSession);
            this.Controls.Add(this.panel_sessionList);
            this.Name = "SessionTrack";
            this.Text = "SessionTrack";
            this.Load += new System.EventHandler(this.SessionTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sessionList;
        private System.Windows.Forms.Button button_createSession;
        private System.Windows.Forms.TreeView treeView_locationView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sessionTrackDate;
    }
}