using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutDB
{
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }

        private void linkLabel_course_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseMaster courseMaster = new CourseMaster();
            courseMaster.Show();
        }

        private void linkLabel_batch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BatchMaster batchMaster = new BatchMaster();
            batchMaster.Show();
        }

        private void linkLabel_room_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show();
        }

        private void linkLabel_task_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaskMaster taskMaster = new TaskMaster();
            taskMaster.Show();
        }

        private void linkLabel_location_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LocationMaster locationMaster = new LocationMaster();
            locationMaster.Show();
        }

        private void linkLabel_paymentMethod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewMaster newMaster = new AddNewMaster();
            newMaster.clickedLinkName = (sender as LinkLabel).Name;
            newMaster.Show();
        }

        private void linkLabel_designation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewMaster newMaster = new AddNewMaster();
            newMaster.clickedLinkName = (sender as LinkLabel).Name;
            newMaster.Show();
        }

      
        private void linkLabel_status_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewMaster newMaster = new AddNewMaster();
            newMaster.clickedLinkName = (sender as LinkLabel).Name;
            newMaster.Show();
        }

        private void linkLabel_leaveReason_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewMaster newMaster = new AddNewMaster();
            newMaster.clickedLinkName = (sender as LinkLabel).Name;
            newMaster.Show();
        }

        private void Masters_Load(object sender, EventArgs e)
        {

        }
    }
}
