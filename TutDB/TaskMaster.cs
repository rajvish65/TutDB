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
    public partial class TaskMaster : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static bool hasUpdated = false;
        static Int32 TaskId;

        public TaskMaster()
        {
            InitializeComponent();
        }

        private void TaskMaster_Load(object sender, EventArgs e)
        {
            combo_taskMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
            CommonUtilities.populateTask(combo_taskMaster);
            combo_taskMaster.SelectedIndexChanged += new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
            textbox_taskName.Enabled = false;
            textbox_taskCode.Enabled = false;
            textbox_taskIsActive.Enabled = false;
            textBox_taskDecription.Enabled = false;
            linkLabel_taskAcitvate.Enabled = false;
            linkLabel_taskAdd.Enabled = false;
            linkLabel_taskCancel.Enabled = false;
            linkLabel_taskUpdate.Enabled = false;
            linkLabel_taskEdit.Enabled = false;
            Label_task.Enabled = false;
            Label_taskCode.Enabled = false;
            Label_taskIsActive.Enabled = false;
            label_taskDescription.Enabled = false;
        }

        public void formload()
        {
            combo_taskMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
            CommonUtilities.populateTask(combo_taskMaster);
            combo_taskMaster.SelectedIndexChanged += new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
        }

        public void Clear()
        {
            textbox_taskCode.Text = "";
            textbox_taskName.Text = "";
            textbox_taskIsActive.Text = "";
            textBox_taskDecription.Text = "";
        }

        private void linkLabel_taskMasterClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblTaskMaster taskMaster = new tblTaskMaster();
            this.Close();
        }

        private void linkLabel_taskAcitvate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblTaskMaster taskMaster = new tblTaskMaster();
            taskMaster = db.tblTaskMasters.Where(x => x.TaskId == TaskId).Single();

            if (linkLabel_taskAcitvate.Text == "Activate")
            {
                taskMaster.isActive = 1;
                taskMaster.UpdatedDate = DateTime.Today;
                db.SaveChanges();
                textbox_taskIsActive.Text = "Yes";
                linkLabel_taskAcitvate.Text = "InActivate";
                MessageBox.Show(textbox_taskName.Text + " Acitvated");
            }
            else
                if (linkLabel_taskAcitvate.Text == "InActivate")
                {
                    taskMaster.isActive = 0;
                    taskMaster.UpdatedDate = DateTime.Today;
                    db.SaveChanges();
                    textbox_taskIsActive.Text = "No";
                    linkLabel_taskAcitvate.Text = "Activate";
                    MessageBox.Show(textbox_taskName.Text + " InAcitvated");
                }
        }

        private void linkLabel_taskEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox_taskName.ReadOnly = false;
            textbox_taskCode.ReadOnly = false;
            textBox_taskDecription.ReadOnly = false;
            linkLabel_taskUpdate.Enabled = true;
            linkLabel_taskEdit.Enabled = false;
        }

        private void linkLabel_taskNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_taskEdit.Enabled = false;
            linkLabel_taskUpdate.Enabled = false;
            linkLabel_taskNew.Enabled = false;
            linkLabel_taskCancel.Enabled = true;
            linkLabel_taskAdd.Enabled = true;
            linkLabel_taskAcitvate.Enabled = false;
            Label_task.Enabled = true;
            Label_taskCode.Enabled = true;
            Label_taskIsActive.Enabled = true;
            label_taskDescription.Enabled = true;
            textbox_taskName.Enabled = true;
            textbox_taskCode.Enabled = true;
            textbox_taskName.ReadOnly = false;
            textbox_taskCode.ReadOnly = false;
            textBox_taskDecription.ReadOnly = false;
            Clear();
        }

        private void linkLabel_taskAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            manageTask();
        }

        public void manageTask()
        {
            if (validateTask())
                return; //Validation fails.

            //Validation successful.

            if (db.tblTaskMasters.Where(x => x.TaskName.Equals(textbox_taskName.Text)).Count() > 0)
            {
                MessageBox.Show("Task Already Exist");
            }
            else
                if (db.tblTaskMasters.Where(x => x.TaskCode.Equals(textbox_taskCode.Text)).Count() > 0)
                {
                    MessageBox.Show("Task Code Already Exist");
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
                                tblTaskMaster task = new tblTaskMaster();

                                task.TaskCode = textbox_taskCode.Text;
                                task.TaskName = textbox_taskName.Text;
                                task.TaskDescription = textBox_taskDecription.Text;
                                task.isActive = 1;
                                task.CreatedDate = DateTime.Today;

                                db.tblTaskMasters.Add(task);
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
                        Label_task.Enabled = false;
                        Label_taskCode.Enabled = false;
                        Label_taskIsActive.Enabled = false;
                        label_taskDescription.Enabled = false;
                        textbox_taskIsActive.Enabled = false;
                        textbox_taskCode.Enabled = false;
                        textbox_taskName.Enabled = false;
                        textBox_taskDecription.Enabled = false;
                        linkLabel_taskAdd.Enabled = false;
                        linkLabel_taskCancel.Enabled = false;
                        linkLabel_taskNew.Enabled = true;
                        MessageBox.Show("Task added successfully.", "Success");
                        combo_taskMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
                        CommonUtilities.populateTask(combo_taskMaster);
                        combo_taskMaster.SelectedIndexChanged += new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }
        }

        private bool validateTask()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (textbox_taskCode.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Task Code \n";
            }

            if (textbox_taskName.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Task Name \n";
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }


        private void combo_taskMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblTaskMaster taskMaster = new tblTaskMaster();
      
            string selTaskName = (combo_taskMaster.SelectedItem as tblTaskMaster).TaskName;
            taskMaster = db.tblTaskMasters.Where(x => x.TaskName.Equals(selTaskName)).FirstOrDefault();
            TaskId = Convert.ToInt32(taskMaster.TaskId);
            textbox_taskCode.Text = taskMaster.TaskCode;
            textbox_taskName.Text = taskMaster.TaskName;
            textBox_taskDecription.Text = taskMaster.TaskDescription;
            //tblBatchCourse bt = new tblBatchCourse();
            //bt = db.tblBatchCourses.Where(x => x.BatchId == BatchId).FirstOrDefault();
            //String a=bt.CourseId.ToString();
            //cmbBatchMaster.Text =db.tblCourseMasters.Where(x=>x.CourseId== db.tblBatchCourses.Where(y => y.BatchId == BatchId).Single().CourseId).First().CourseName;
            if (taskMaster.isActive == 1)
            {
                textbox_taskIsActive.Text = "Yes";
                linkLabel_taskAcitvate.Text = "InActivate";
            }
            else
            {
                textbox_taskIsActive.Text = "No";
                linkLabel_taskAcitvate.Text = "Activate";
            }

            Label_task.Enabled = true;
            Label_taskCode.Enabled = true;
            Label_taskIsActive.Enabled = true;
            label_taskDescription.Enabled = true;
            textbox_taskName.Enabled = true;
            textbox_taskCode.Enabled = true;
            textbox_taskIsActive.Enabled = true;
            textBox_taskDecription.Enabled = true;
            textbox_taskCode.ReadOnly = true;
            textbox_taskName.ReadOnly = true;
            textbox_taskIsActive.ReadOnly = true;
            textBox_taskDecription.ReadOnly = true;
            linkLabel_taskAcitvate.Enabled = true;
            linkLabel_taskEdit.Enabled = true;
            linkLabel_taskAdd.Enabled = false;
            linkLabel_taskCancel.Enabled = true;
            linkLabel_taskUpdate.Enabled = false;
            linkLabel_taskNew.Enabled = true;
        }

        private void linkLabel_taskUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hasUpdated = true;
            // ManageCourse();
            if (validateTask())
                return; //Validation fails.

            //Validation successful.

            if (db.tblTaskMasters.Where(x => x.TaskId != TaskId && x.TaskName.Equals(textbox_taskName.Text)).Count() > 0)
            {
                MessageBox.Show("Task Already Exist");
            }
            else
                if (db.tblTaskMasters.Where(x => x.TaskId != TaskId && x.TaskCode.Equals(textbox_taskCode.Text)).Count() > 0)
                {
                    MessageBox.Show("Task Code Already Exist");
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
                                tblTaskMaster task;
                                task = db.tblTaskMasters.Where(x => x.TaskId == TaskId).Single();
                                task.TaskCode = textbox_taskCode.Text;
                                task.TaskName = textbox_taskName.Text;
                                task.TaskDescription = textBox_taskDecription.Text;
                                task.UpdatedDate = DateTime.Today;

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
                        Label_task.Enabled = false;
                        Label_taskCode.Enabled = false;
                        Label_taskIsActive.Enabled = false;
                        label_taskDescription.Enabled = false;
                        textbox_taskIsActive.Enabled = false;
                        textbox_taskCode.Enabled = false;
                        textbox_taskName.Enabled = false;
                        textBox_taskDecription.Enabled = false;
                        linkLabel_taskAdd.Enabled = false;
                        linkLabel_taskCancel.Enabled = false;
                        linkLabel_taskNew.Enabled = true;
                        linkLabel_taskUpdate.Enabled = false;
                        linkLabel_taskAcitvate.Enabled = false;

                        MessageBox.Show("Task updated successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }
            formload();
        }

        private void linkLabel_taskCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            linkLabel_taskEdit.Enabled = false;
            linkLabel_taskAcitvate.Enabled = false;
            linkLabel_taskAdd.Enabled = false;
            linkLabel_taskUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combo_taskMaster.SelectedIndexChanged -= new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
            CommonUtilities.populateTask(combo_taskMaster);
            combo_taskMaster.SelectedIndexChanged += new System.EventHandler(this.combo_taskMaster_SelectedIndexChanged);
        }
    }
}
