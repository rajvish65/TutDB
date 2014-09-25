using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace TutDB
{
    public partial class RoomMaster : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static bool hasUpdated = false;
        static Int32 RoomId;

        public RoomMaster()
        {
            InitializeComponent();
        }

        private void RoomMaster_Load(object sender, EventArgs e)
        {
            combo_roomMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
            CommonUtilities.populateRoom(combo_roomMaster);
            combo_roomMaster.SelectedIndexChanged += new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
            textbox_roomName.Enabled = false;
            textbox_roomDescription.Enabled = false;
            textbox_roomIsActive.Enabled = false;
            linkLabel_roomAcitvate.Enabled = false;
            linkLabel_roomAdd.Enabled = false;
            linkLabel_roomCancel.Enabled = false;
            linkLabel_roomUpdate.Enabled = false;
            linkLabel_roomEdit.Enabled = false;
            Label_room.Enabled = false;
            Label_roomDescription.Enabled = false;
            Label_roomIsActive.Enabled = false;
        }

        public void Clear()
        {
            textbox_roomDescription.Text = "";
            textbox_roomName.Text = "";
            textbox_roomIsActive.Text = "";
        }

        private void linkLabel_roomMasterClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblRoomMaster batchMaster = new tblRoomMaster();
            this.Close();
        }

        private void linkLabel_roomAcitvate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblRoomMaster roomMaster = new tblRoomMaster();
            roomMaster = db.tblRoomMasters.Where(x => x.RoomId == RoomId).Single();

            if (linkLabel_roomAcitvate.Text == "Activate")
            {
                roomMaster.isActive = 1;
                roomMaster.UpdatedDate = DateTime.Today;
                db.SaveChanges();
                textbox_roomIsActive.Text = "Yes";
                linkLabel_roomAcitvate.Text = "InActivate";
                MessageBox.Show(textbox_roomName.Text + " Acitvated");
            }
            else
                if (linkLabel_roomAcitvate.Text == "InActivate")
                {
                    roomMaster.isActive = 0;
                    roomMaster.UpdatedDate = DateTime.Today;
                    db.SaveChanges();
                    textbox_roomIsActive.Text = "No";
                    linkLabel_roomAcitvate.Text = "Activate";
                    MessageBox.Show(textbox_roomName.Text + " InAcitvated");
                }
        }

        private void linkLabel_roomEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox_roomName.ReadOnly = false;
            textbox_roomDescription.ReadOnly = false;
            linkLabel_roomUpdate.Enabled = true;
            linkLabel_roomEdit.Enabled = false;
        }

        private void linkLabel_roomNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_roomEdit.Enabled = false;
            linkLabel_roomUpdate.Enabled = false;
            linkLabel_roomNew.Enabled = false;
            linkLabel_roomCancel.Enabled = true;
            linkLabel_roomAdd.Enabled = true;
            linkLabel_roomAcitvate.Enabled = false;
            Label_room.Enabled = true;
            Label_roomDescription.Enabled = true;
            Label_roomIsActive.Enabled = true;
            textbox_roomName.Enabled = true;
            textbox_roomDescription.Enabled = true;
            textbox_roomName.ReadOnly = false;
            textbox_roomDescription.ReadOnly = false;
            Clear();
        }

        private void linkLabel_roomAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            manageRoom();
        }

        public void manageRoom()
        {
            if (validateRoom())
                return; //Validation fails.

            //Validation successful.

            if (db.tblRoomMasters.Where(x => x.RoomName.Equals(textbox_roomName.Text)).Count() > 0)
            {
                MessageBox.Show("Task Already Exist");
            }
            else
                {
                    bool exceptionOccured = false;
                    try
                    {
                        bool success = false;


                        using (TransactionScope transaction = new TransactionScope())
                        {
                            try
                            {
                                tblRoomMaster room = new tblRoomMaster();

                                room.RoomDescription = textbox_roomDescription.Text;
                                room.RoomName = textbox_roomName.Text;
                                room.isActive = 1;
                                room.CreatedDate = DateTime.Today;

                                db.tblRoomMasters.Add(room);
                                db.SaveChanges();
                                transaction.Complete();
                                success = true;
                            }
                            catch (Exception ex)
                            {
                                success = false;
                            }
                        }
                        if (success)
                        {
                            //db.AcceptAllChanges(); //Transaction was successful, commit all changes.
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        exceptionOccured = true;
                    }

                    if (!exceptionOccured)
                    {
                        Clear();
                        Label_room.Enabled = false;
                        Label_roomDescription.Enabled = false;
                        Label_roomIsActive.Enabled = false;
                        textbox_roomIsActive.Enabled = false;
                        textbox_roomDescription.Enabled = false;
                        textbox_roomName.Enabled = false;
                        linkLabel_roomAdd.Enabled = false;
                        linkLabel_roomCancel.Enabled = false;
                        linkLabel_roomNew.Enabled = true;
                        MessageBox.Show("Room added successfully.", "Success");
                        combo_roomMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
                        CommonUtilities.populateRoom(combo_roomMaster);
                        combo_roomMaster.SelectedIndexChanged += new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }
        }

        private bool validateRoom()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (textbox_roomDescription.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Room Description \n";
            }

            if (textbox_roomName.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Room Name \n";
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }

        private void combo_roomMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblRoomMaster roomMaster = new tblRoomMaster();
            //courseMaster=db.tblCourseMasters.Where(x=>x.CourseName = cmbCourseMaster.SelectedValue).Single();
            string selRoomName = (combo_roomMaster.SelectedItem as tblRoomMaster).RoomName;
            roomMaster = db.tblRoomMasters.Where(x => x.RoomName.Equals(selRoomName)).FirstOrDefault();
            RoomId = Convert.ToInt32(roomMaster.RoomId);
            textbox_roomDescription.Text = roomMaster.RoomDescription;
            textbox_roomName.Text = roomMaster.RoomName;
            //tblBatchCourse bt = new tblBatchCourse();
            //bt = db.tblBatchCourses.Where(x => x.BatchId == BatchId).FirstOrDefault();
            //String a=bt.CourseId.ToString();
            //cmbBatchMaster.Text =db.tblCourseMasters.Where(x=>x.CourseId== db.tblBatchCourses.Where(y => y.BatchId == BatchId).Single().CourseId).First().CourseName;
            if (roomMaster.isActive == 1)
            {
                textbox_roomIsActive.Text = "Yes";
                linkLabel_roomAcitvate.Text = "InActivate";
            }
            else
            {
                textbox_roomIsActive.Text = "No";
                linkLabel_roomAcitvate.Text = "Activate";
            }

            Label_room.Enabled = true;
            Label_roomDescription.Enabled = true;
            Label_roomIsActive.Enabled = true;
            textbox_roomName.Enabled = true;
            textbox_roomDescription.Enabled = true;
            textbox_roomIsActive.Enabled = true;
            textbox_roomDescription.ReadOnly = true;
            textbox_roomName.ReadOnly = true;
            textbox_roomIsActive.ReadOnly = true;
            linkLabel_roomAcitvate.Enabled = true;
            linkLabel_roomEdit.Enabled = true;
            linkLabel_roomAdd.Enabled = false;
            linkLabel_roomCancel.Enabled = true;
            linkLabel_roomUpdate.Enabled = false;
            linkLabel_roomNew.Enabled = true;
        }

        private void linkLabel_roomUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hasUpdated = true;
            // ManageCourse();
            if (validateRoom())
                return; //Validation fails.

            //Validation successful.

            if (db.tblRoomMasters.Where(x => x.RoomId != RoomId && x.RoomName.Equals(textbox_roomName.Text)).Count() > 0)
            {
                MessageBox.Show("Room Already Exist");
            }
                else
                {
                    bool exceptionOccured = false;
                    try
                    {
                        bool success = false;


                        using (TransactionScope transaction = new TransactionScope())
                        {
                            try
                            {
                                tblRoomMaster room;
                                room = db.tblRoomMasters.Where(x => x.RoomId == RoomId).Single();
                                room.RoomDescription = textbox_roomDescription.Text;
                                room.RoomName = textbox_roomName.Text;
                                room.UpdatedDate = DateTime.Today;

                                //db.tblCourseMasters.Add(course);
                                db.SaveChanges();
                                transaction.Complete();
                                success = true;
                            }
                            catch (Exception ex)
                            {
                                success = false;
                            }
                        }
                        if (success)
                        {
                            //db.AcceptAllChanges(); //Transaction was successful, commit all changes.
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        exceptionOccured = true;
                    }

                    if (!exceptionOccured)
                    {
                        Clear();
                        Label_room.Enabled = false;
                        Label_roomDescription.Enabled = false;
                        Label_roomIsActive.Enabled = false;
                        textbox_roomIsActive.Enabled = false;
                        textbox_roomDescription.Enabled = false;
                        textbox_roomName.Enabled = false;
                        linkLabel_roomAdd.Enabled = false;
                        linkLabel_roomCancel.Enabled = false;
                        linkLabel_roomNew.Enabled = true;
                        linkLabel_roomUpdate.Enabled = false;
                        linkLabel_roomAcitvate.Enabled = false;

                        MessageBox.Show("Room updated successfully.", "Success");
                        combo_roomMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
                        CommonUtilities.populateRoom(combo_roomMaster);
                        combo_roomMaster.SelectedIndexChanged += new System.EventHandler(this.combo_roomMaster_SelectedIndexChanged);
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }
        }

        private void linkLabel_roomCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            linkLabel_roomEdit.Enabled = false;
            linkLabel_roomAcitvate.Enabled = false;
            linkLabel_roomAdd.Enabled = false;
            linkLabel_roomUpdate.Enabled = false;
        }

    }
}
