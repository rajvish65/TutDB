namespace TutDB
{
    partial class RoomMaster
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
            this.groupBox_taskMaster = new System.Windows.Forms.GroupBox();
            this.Label_roomMaster = new System.Windows.Forms.Label();
            this.linkLabel_roomMasterClose = new System.Windows.Forms.LinkLabel();
            this.combo_roomMaster = new System.Windows.Forms.ComboBox();
            this.groupBox_roomDetails = new System.Windows.Forms.GroupBox();
            this.linkLabel_roomEdit = new System.Windows.Forms.LinkLabel();
            this.linkLabel_roomNew = new System.Windows.Forms.LinkLabel();
            this.Label_room = new System.Windows.Forms.Label();
            this.Label_roomIsActive = new System.Windows.Forms.Label();
            this.Label_roomDescription = new System.Windows.Forms.Label();
            this.linkLabel_roomCancel = new System.Windows.Forms.LinkLabel();
            this.linkLabel_roomUpdate = new System.Windows.Forms.LinkLabel();
            this.linkLabel_roomAdd = new System.Windows.Forms.LinkLabel();
            this.linkLabel_roomAcitvate = new System.Windows.Forms.LinkLabel();
            this.textbox_roomIsActive = new System.Windows.Forms.TextBox();
            this.textbox_roomName = new System.Windows.Forms.TextBox();
            this.textbox_roomDescription = new System.Windows.Forms.TextBox();
            this.groupBox_taskMaster.SuspendLayout();
            this.groupBox_roomDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_taskMaster
            // 
            this.groupBox_taskMaster.Controls.Add(this.Label_roomMaster);
            this.groupBox_taskMaster.Controls.Add(this.linkLabel_roomMasterClose);
            this.groupBox_taskMaster.Controls.Add(this.combo_roomMaster);
            this.groupBox_taskMaster.Location = new System.Drawing.Point(11, 10);
            this.groupBox_taskMaster.Name = "groupBox_taskMaster";
            this.groupBox_taskMaster.Size = new System.Drawing.Size(471, 117);
            this.groupBox_taskMaster.TabIndex = 4;
            this.groupBox_taskMaster.TabStop = false;
            this.groupBox_taskMaster.Text = "Room";
            // 
            // Label_roomMaster
            // 
            this.Label_roomMaster.AutoSize = true;
            this.Label_roomMaster.Location = new System.Drawing.Point(88, 50);
            this.Label_roomMaster.Name = "Label_roomMaster";
            this.Label_roomMaster.Size = new System.Drawing.Size(35, 13);
            this.Label_roomMaster.TabIndex = 5;
            this.Label_roomMaster.Text = "Room";
            // 
            // linkLabel_roomMasterClose
            // 
            this.linkLabel_roomMasterClose.AutoSize = true;
            this.linkLabel_roomMasterClose.Location = new System.Drawing.Point(432, 16);
            this.linkLabel_roomMasterClose.Name = "linkLabel_roomMasterClose";
            this.linkLabel_roomMasterClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabel_roomMasterClose.TabIndex = 4;
            this.linkLabel_roomMasterClose.TabStop = true;
            this.linkLabel_roomMasterClose.Text = "Close";
            this.linkLabel_roomMasterClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomMasterClose_LinkClicked);
            // 
            // combo_roomMaster
            // 
            this.combo_roomMaster.FormattingEnabled = true;
            this.combo_roomMaster.Location = new System.Drawing.Point(166, 47);
            this.combo_roomMaster.Name = "combo_roomMaster";
            this.combo_roomMaster.Size = new System.Drawing.Size(121, 21);
            this.combo_roomMaster.TabIndex = 0;
            this.combo_roomMaster.SelectedIndexChanged += new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
            // 
            // groupBox_roomDetails
            // 
            this.groupBox_roomDetails.Controls.Add(this.linkLabel_roomEdit);
            this.groupBox_roomDetails.Controls.Add(this.linkLabel_roomNew);
            this.groupBox_roomDetails.Controls.Add(this.Label_room);
            this.groupBox_roomDetails.Controls.Add(this.Label_roomIsActive);
            this.groupBox_roomDetails.Controls.Add(this.Label_roomDescription);
            this.groupBox_roomDetails.Controls.Add(this.linkLabel_roomCancel);
            this.groupBox_roomDetails.Controls.Add(this.linkLabel_roomUpdate);
            this.groupBox_roomDetails.Controls.Add(this.linkLabel_roomAdd);
            this.groupBox_roomDetails.Controls.Add(this.linkLabel_roomAcitvate);
            this.groupBox_roomDetails.Controls.Add(this.textbox_roomIsActive);
            this.groupBox_roomDetails.Controls.Add(this.textbox_roomName);
            this.groupBox_roomDetails.Controls.Add(this.textbox_roomDescription);
            this.groupBox_roomDetails.Location = new System.Drawing.Point(11, 145);
            this.groupBox_roomDetails.Name = "groupBox_roomDetails";
            this.groupBox_roomDetails.Size = new System.Drawing.Size(471, 182);
            this.groupBox_roomDetails.TabIndex = 5;
            this.groupBox_roomDetails.TabStop = false;
            this.groupBox_roomDetails.Text = "Details";
            // 
            // linkLabel_roomEdit
            // 
            this.linkLabel_roomEdit.AutoSize = true;
            this.linkLabel_roomEdit.Location = new System.Drawing.Point(309, 16);
            this.linkLabel_roomEdit.Name = "linkLabel_roomEdit";
            this.linkLabel_roomEdit.Size = new System.Drawing.Size(25, 13);
            this.linkLabel_roomEdit.TabIndex = 13;
            this.linkLabel_roomEdit.TabStop = true;
            this.linkLabel_roomEdit.Text = "Edit";
            this.linkLabel_roomEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomEdit_LinkClicked);
            // 
            // linkLabel_roomNew
            // 
            this.linkLabel_roomNew.AutoSize = true;
            this.linkLabel_roomNew.Location = new System.Drawing.Point(277, 16);
            this.linkLabel_roomNew.Name = "linkLabel_roomNew";
            this.linkLabel_roomNew.Size = new System.Drawing.Size(29, 13);
            this.linkLabel_roomNew.TabIndex = 12;
            this.linkLabel_roomNew.TabStop = true;
            this.linkLabel_roomNew.Text = "New";
            this.linkLabel_roomNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomNew_LinkClicked);
            // 
            // Label_room
            // 
            this.Label_room.AutoSize = true;
            this.Label_room.Location = new System.Drawing.Point(88, 71);
            this.Label_room.Name = "Label_room";
            this.Label_room.Size = new System.Drawing.Size(35, 13);
            this.Label_room.TabIndex = 10;
            this.Label_room.Text = "Room";
            // 
            // Label_roomIsActive
            // 
            this.Label_roomIsActive.AutoSize = true;
            this.Label_roomIsActive.Location = new System.Drawing.Point(88, 130);
            this.Label_roomIsActive.Name = "Label_roomIsActive";
            this.Label_roomIsActive.Size = new System.Drawing.Size(37, 13);
            this.Label_roomIsActive.TabIndex = 9;
            this.Label_roomIsActive.Text = "Active";
            // 
            // Label_roomDescription
            // 
            this.Label_roomDescription.AutoSize = true;
            this.Label_roomDescription.Location = new System.Drawing.Point(88, 101);
            this.Label_roomDescription.Name = "Label_roomDescription";
            this.Label_roomDescription.Size = new System.Drawing.Size(60, 13);
            this.Label_roomDescription.TabIndex = 7;
            this.Label_roomDescription.Text = "Description";
            // 
            // linkLabel_roomCancel
            // 
            this.linkLabel_roomCancel.AutoSize = true;
            this.linkLabel_roomCancel.Location = new System.Drawing.Point(421, 16);
            this.linkLabel_roomCancel.Name = "linkLabel_roomCancel";
            this.linkLabel_roomCancel.Size = new System.Drawing.Size(40, 13);
            this.linkLabel_roomCancel.TabIndex = 6;
            this.linkLabel_roomCancel.TabStop = true;
            this.linkLabel_roomCancel.Text = "Cancel";
            this.linkLabel_roomCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomCancel_LinkClicked);
            // 
            // linkLabel_roomUpdate
            // 
            this.linkLabel_roomUpdate.AutoSize = true;
            this.linkLabel_roomUpdate.Location = new System.Drawing.Point(373, 16);
            this.linkLabel_roomUpdate.Name = "linkLabel_roomUpdate";
            this.linkLabel_roomUpdate.Size = new System.Drawing.Size(42, 13);
            this.linkLabel_roomUpdate.TabIndex = 5;
            this.linkLabel_roomUpdate.TabStop = true;
            this.linkLabel_roomUpdate.Text = "Update";
            this.linkLabel_roomUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomUpdate_LinkClicked);
            // 
            // linkLabel_roomAdd
            // 
            this.linkLabel_roomAdd.AutoSize = true;
            this.linkLabel_roomAdd.Location = new System.Drawing.Point(341, 16);
            this.linkLabel_roomAdd.Name = "linkLabel_roomAdd";
            this.linkLabel_roomAdd.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_roomAdd.TabIndex = 4;
            this.linkLabel_roomAdd.TabStop = true;
            this.linkLabel_roomAdd.Text = "Add";
            this.linkLabel_roomAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomAdd_LinkClicked);
            // 
            // linkLabel_roomAcitvate
            // 
            this.linkLabel_roomAcitvate.AutoSize = true;
            this.linkLabel_roomAcitvate.Location = new System.Drawing.Point(241, 130);
            this.linkLabel_roomAcitvate.Name = "linkLabel_roomAcitvate";
            this.linkLabel_roomAcitvate.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_roomAcitvate.TabIndex = 3;
            this.linkLabel_roomAcitvate.TabStop = true;
            this.linkLabel_roomAcitvate.Text = "Activate";
            this.linkLabel_roomAcitvate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_roomAcitvate_LinkClicked);
            // 
            // textbox_roomIsActive
            // 
            this.textbox_roomIsActive.Location = new System.Drawing.Point(166, 127);
            this.textbox_roomIsActive.Name = "textbox_roomIsActive";
            this.textbox_roomIsActive.Size = new System.Drawing.Size(61, 20);
            this.textbox_roomIsActive.TabIndex = 2;
            // 
            // textbox_roomName
            // 
            this.textbox_roomName.Location = new System.Drawing.Point(166, 68);
            this.textbox_roomName.Name = "textbox_roomName";
            this.textbox_roomName.Size = new System.Drawing.Size(140, 20);
            this.textbox_roomName.TabIndex = 1;
            // 
            // textbox_roomDescription
            // 
            this.textbox_roomDescription.Location = new System.Drawing.Point(166, 98);
            this.textbox_roomDescription.Name = "textbox_roomDescription";
            this.textbox_roomDescription.Size = new System.Drawing.Size(140, 20);
            this.textbox_roomDescription.TabIndex = 0;
            // 
            // RoomMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 337);
            this.Controls.Add(this.groupBox_taskMaster);
            this.Controls.Add(this.groupBox_roomDetails);
            this.Name = "RoomMaster";
            this.Text = "RoomMaster";
            this.Load += new System.EventHandler(this.RoomMaster_Load);
            this.groupBox_taskMaster.ResumeLayout(false);
            this.groupBox_taskMaster.PerformLayout();
            this.groupBox_roomDetails.ResumeLayout(false);
            this.groupBox_roomDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_taskMaster;
        private System.Windows.Forms.Label Label_roomMaster;
        private System.Windows.Forms.LinkLabel linkLabel_roomMasterClose;
        private System.Windows.Forms.ComboBox combo_roomMaster;
        private System.Windows.Forms.GroupBox groupBox_roomDetails;
        private System.Windows.Forms.LinkLabel linkLabel_roomEdit;
        private System.Windows.Forms.LinkLabel linkLabel_roomNew;
        private System.Windows.Forms.Label Label_room;
        private System.Windows.Forms.Label Label_roomIsActive;
        private System.Windows.Forms.Label Label_roomDescription;
        private System.Windows.Forms.LinkLabel linkLabel_roomCancel;
        private System.Windows.Forms.LinkLabel linkLabel_roomUpdate;
        private System.Windows.Forms.LinkLabel linkLabel_roomAdd;
        private System.Windows.Forms.LinkLabel linkLabel_roomAcitvate;
        private System.Windows.Forms.TextBox textbox_roomIsActive;
        private System.Windows.Forms.TextBox textbox_roomName;
        private System.Windows.Forms.TextBox textbox_roomDescription;

    }
}