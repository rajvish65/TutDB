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
    public partial class CourseMaster : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static bool hasUpdated = false;
        static Int32 CourseId;

        public CourseMaster()
        {
            InitializeComponent();
        }

        private void CourseMaster_Load(object sender, EventArgs e)
        {
            cmbCourseMaster.SelectedIndexChanged -= new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
            CommonUtilities.populateCourse(cmbCourseMaster);
            cmbCourseMaster.SelectedIndexChanged += new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
            checkBox_selectAll.Enabled = false;
            checkedListBox1.Enabled = false;
            txtCourseName.Enabled = false;
            txtCourseCode.Enabled = false;
            txtCourseIsActive.Enabled = false;
            linkLabel_CourseActivate.Enabled = false;
            linkLabel_courseAdd.Enabled = false;
            linkLabel_courseCancel.Enabled = false;
            linkLabel_courseUpdate.Enabled = false;
            linkLabel_courseEdit.Enabled = false;
            lblCourseName.Enabled = false;
            lblCourseCode.Enabled = false;
            lblCourseIsActive.Enabled = false;
            lblBatch.Enabled = false;

        }

        private void cmbCourseMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblCourseMaster courseMaster = new tblCourseMaster();
            //courseMaster=db.tblCourseMasters.Where(x=>x.CourseName = cmbCourseMaster.SelectedValue).Single();
            string selCourseName = (cmbCourseMaster.SelectedItem as tblCourseMaster).CourseName;
            courseMaster = db.tblCourseMasters.Where(x => x.CourseName.Equals(selCourseName)).FirstOrDefault();
            CourseId = Convert.ToInt32(courseMaster.CourseId);
            txtCourseCode.Text = courseMaster.CourseCode;
            txtCourseName.Text = courseMaster.CourseName;
            if (courseMaster.isActive == 1)
            {
                txtCourseIsActive.Text = "Yes";
                linkLabel_CourseActivate.Text = "InActivate";
            }
            else
            {
                txtCourseIsActive.Text = "No";
                linkLabel_CourseActivate.Text = "Activate";
            }

            CommonUtilities.populateChkListBatch(checkedListBox1);
            unCheckAllCheckList();
            List<tblBatchCourse> list_batchCourse = new List<tblBatchCourse>();
            list_batchCourse.AddRange(db.tblBatchCourses.Where(x => x.CourseId == CourseId && x.isActive == 1).ToList());

            //int count=0;
            if (list_batchCourse.Count() > 0)
            {
                foreach (var item in list_batchCourse)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        String a = (checkedListBox1.Items[i] as tblBatchMaster).BatchName;
                        if (item.BatchId == (checkedListBox1.Items[i] as tblBatchMaster).BatchId)//&& checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(i))==CheckState.Unchecked)
                        {
                            checkedListBox1.SetItemChecked(i, true);
                        }


                    }
                }
            }

            checkedListBox1.SelectionMode = SelectionMode.None;
            checkedListBox1.Enabled = true;
            checkBox_selectAll.Enabled = false;
            lblBatch.Enabled = true;
            lblCourseName.Enabled = true;
            lblCourseCode.Enabled = true;
            lblCourseIsActive.Enabled = true;
            txtCourseName.Enabled = true;
            txtCourseCode.Enabled = true;
            txtCourseIsActive.Enabled = true;
            txtCourseCode.ReadOnly = true;
            txtCourseName.ReadOnly = true;
            txtCourseIsActive.ReadOnly = true;
            linkLabel_CourseActivate.Enabled = true;
            linkLabel_courseEdit.Enabled = true;
            linkLabel_courseAdd.Enabled = false;
            linkLabel_courseCancel.Enabled = true;
            linkLabel_courseUpdate.Enabled = false;
            linkLabel_courseNew.Enabled = true;
        }

        private void checkAllCheckList()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void unCheckAllCheckList()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void linkLabel_courseMasterClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CourseMaster courseMaster = new CourseMaster();
            this.Close();

        }

        private void linkLabel_courseAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageCourse();

        }

        public void Clear()
        {
            txtCourseCode.Text = "";
            txtCourseName.Text = "";
            txtCourseIsActive.Text = "";
            checkBox_selectAll.Checked = false;
            unCheckAllCheckList();
        }

        public void ManageCourse()
        {
            if (validateCourse())
                return; //Validation fails.

            //Validation successful.

            if (db.tblCourseMasters.Where(x => x.CourseName.Equals(txtCourseName.Text)).Count() > 0)
            {
                MessageBox.Show("Course Already Exist");
            }
            else
                if (db.tblCourseMasters.Where(x => x.CourseCode.Equals(txtCourseCode.Text)).Count() > 0)
                {
                    MessageBox.Show("Course Code Already Exist");
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
                                tblCourseMaster course = new tblCourseMaster();

                                course.CourseCode = txtCourseCode.Text;
                                course.CourseName = txtCourseName.Text;
                                course.isActive = 1;
                                course.CreatedDate = DateTime.Today;

                                db.tblCourseMasters.Add(course);
                                db.SaveChanges();

                                tblBatchCourse batchcourse = new tblBatchCourse();
                                addCheckedItems(batchcourse);

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
                        checkedListBox1.Enabled = false;
                        checkBox_selectAll.Enabled = false;
                        lblBatch.Enabled = false;
                        lblCourseName.Enabled = false;
                        lblCourseCode.Enabled = false;
                        lblCourseIsActive.Enabled = false;
                        txtCourseIsActive.Enabled = false;
                        txtCourseCode.Enabled = false;
                        txtCourseName.Enabled = false;
                        linkLabel_courseAdd.Enabled = false;
                        linkLabel_courseCancel.Enabled = false;
                        linkLabel_courseNew.Enabled = true;
                        MessageBox.Show("Course added successfully.", "Success");
                        cmbCourseMaster.SelectedIndexChanged -= new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
                        CommonUtilities.populateCourse(cmbCourseMaster);
                        cmbCourseMaster.SelectedIndexChanged += new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }




        }

        private void linkLabel_courseUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hasUpdated = true;
            // ManageCourse();
            if (validateCourse())
                return; //Validation fails.

            //Validation successful.

            if (db.tblCourseMasters.Where(x => x.CourseId != CourseId && x.CourseName.Equals(txtCourseName.Text)).Count() > 0)
            {
                MessageBox.Show("Course Already Exist");
            }
            else
                if (db.tblCourseMasters.Where(x => x.CourseId != CourseId && x.CourseCode.Equals(txtCourseCode.Text)).Count() > 0)
                {
                    MessageBox.Show("Course Code Already Exist");
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
                                tblCourseMaster course;
                                course = db.tblCourseMasters.Where(x => x.CourseId == CourseId).Single();
                                course.CourseCode = txtCourseCode.Text;
                                course.CourseName = txtCourseName.Text;
                                course.UpdatedDate = DateTime.Today;

                                //db.tblCourseMasters.Add(course);
                                db.SaveChanges();

                                tblBatchCourse batchcourse = new tblBatchCourse();
                                updateCheckedItems(batchcourse);


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
                        checkedListBox1.Enabled = false;
                        checkBox_selectAll.Enabled = false;
                        lblBatch.Enabled = false;
                        lblCourseName.Enabled = false;
                        lblCourseCode.Enabled = false;
                        lblCourseIsActive.Enabled = false;
                        txtCourseIsActive.Enabled = false;
                        txtCourseCode.Enabled = false;
                        txtCourseName.Enabled = false;
                        linkLabel_courseAdd.Enabled = false;
                        linkLabel_courseCancel.Enabled = false;
                        linkLabel_courseNew.Enabled = true;
                        linkLabel_courseUpdate.Enabled = false;
                        linkLabel_CourseActivate.Enabled = false;

                        MessageBox.Show("Course updated successfully.", "Success");
                        cmbCourseMaster.SelectedIndexChanged -= new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
                        CommonUtilities.populateCourse(cmbCourseMaster);
                        cmbCourseMaster.SelectedIndexChanged += new System.EventHandler(this.cmbCourseMaster_SelectedIndexChanged);
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }

        }



        private void linkLabel_CourseActivate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblCourseMaster courseMaster = new tblCourseMaster();
            courseMaster = db.tblCourseMasters.Where(x => x.CourseId == CourseId).Single();

            if (linkLabel_CourseActivate.Text == "Activate")
            {
                courseMaster.isActive = 1;
                courseMaster.UpdatedDate = DateTime.Today;
                db.SaveChanges();
                txtCourseIsActive.Text = "Yes";
                linkLabel_CourseActivate.Text = "InActivate";
                MessageBox.Show(txtCourseName.Text + " Acitvated");
            }
            else
                if (linkLabel_CourseActivate.Text == "InActivate")
                {
                    courseMaster.isActive = 0;
                    courseMaster.UpdatedDate = DateTime.Today;
                    db.SaveChanges();
                    txtCourseIsActive.Text = "No";
                    linkLabel_CourseActivate.Text = "Activate";
                    MessageBox.Show(txtCourseName.Text + " InAcitvated");
                }
        }




        private bool validateCourse()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (txtCourseCode.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Course Code \n";
            }

            if (txtCourseName.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Course Name \n";
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }



        private void addCheckedItems(tblBatchCourse batchCourse)
        {

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                try
                {
                    tblBatchMaster castedItem = itemChecked as tblBatchMaster;
                    //string comapnyName = castedItem.BatchName;
                    batchCourse.CourseId = db.tblCourseMasters.Where(x => x.CourseName.Equals(txtCourseName.Text)).Single().CourseId;
                    batchCourse.BatchId = Convert.ToInt32(castedItem.BatchId);
                    batchCourse.isActive = 1;
                    batchCourse.CreatedDate = DateTime.Today;
                    db.tblBatchCourses.Add(batchCourse);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    //success = false;
                }
            }
        }

        private void updateCheckedItems(tblBatchCourse batchCourse)
        {
            List<tblBatchCourse> list_batchCourseOld = new List<tblBatchCourse>();
            list_batchCourseOld.AddRange(db.tblBatchCourses.Where(x => x.CourseId == CourseId).ToList());


            List<int> a = new List<int>();
            List<int> b = new List<int>();
            foreach (var id in list_batchCourseOld)
            {
                b.Add(Convert.ToInt32(id.BatchId));
            }

            try
            {
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {


                    tblBatchMaster castedItem = itemChecked as tblBatchMaster;
                    //string comapnyName = castedItem.BatchName;

                    int selCourseID = Convert.ToInt32(db.tblCourseMasters.Where(x => x.CourseName.Equals(txtCourseName.Text)).Single().CourseId);
                    int selBatchId = Convert.ToInt32(castedItem.BatchId);
                    a.Add(selBatchId);
                    if (db.tblBatchCourses.Where(x => x.CourseId == selCourseID && x.BatchId == selBatchId).ToList().Count() > 0)
                    {
                        batchCourse.CourseId = selCourseID;
                        batchCourse.BatchId = selBatchId;
                        batchCourse.isActive = 1;
                        batchCourse.UpdatedDate = DateTime.Today;
                        db.SaveChanges();
                    }
                    else
                        if (db.tblBatchCourses.Where(x => x.CourseId == selCourseID && x.BatchId == selBatchId).ToList().Count() < 1)
                        {
                            batchCourse.CourseId = selCourseID;
                            batchCourse.BatchId = selBatchId;
                            batchCourse.isActive = 1;
                            batchCourse.CreatedDate = DateTime.Today;
                            db.tblBatchCourses.Add(batchCourse);
                            db.SaveChanges();
                        }
                }
            }
            catch (Exception ex)
            {
                //success = false;
            }

            a.Count();
            b.Count();

            List<int> diff = b.Except(a).ToList();
            foreach (var extra in diff)
            {
                tblBatchCourse inActivate = new tblBatchCourse();
                inActivate = db.tblBatchCourses.Where(x => x.CourseId == CourseId && x.BatchId == extra).Single();
                inActivate.isActive = 0;
                db.SaveChanges();
            }







        }

        private void checkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_selectAll.Checked == true)
            {
                checkAllCheckList();

            }
            else
                if (checkBox_selectAll.Checked == false)
                {
                    unCheckAllCheckList();

                }
        }

        private void linkLabel_courseNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CommonUtilities.populateChkListBatch(checkedListBox1);
            checkBox_selectAll.Enabled = true;
            checkedListBox1.Enabled = true;
            lblBatch.Enabled = true;
            linkLabel_courseEdit.Enabled = false;
            linkLabel_courseUpdate.Enabled = false;
            linkLabel_courseNew.Enabled = false;
            linkLabel_courseCancel.Enabled = true;
            linkLabel_courseAdd.Enabled = true;
            linkLabel_CourseActivate.Enabled = false;
            lblCourseName.Enabled = true;
            lblCourseCode.Enabled = true;
            lblCourseIsActive.Enabled = true;
            txtCourseName.Enabled = true;
            txtCourseCode.Enabled = true;
            txtCourseName.ReadOnly = false;
            txtCourseCode.ReadOnly = false;
            Clear();
        }

        private void linkLabel_courseEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkedListBox1.SelectionMode = SelectionMode.One;
            checkedListBox1.Enabled = true;
            checkBox_selectAll.Enabled = true;
            txtCourseName.ReadOnly = false;
            txtCourseCode.ReadOnly = false;
            linkLabel_courseUpdate.Enabled = true;
            linkLabel_courseEdit.Enabled = false;
        }

        private void linkLabel_courseCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            linkLabel_CourseActivate.Enabled = false;
            linkLabel_courseAdd.Enabled = false;
            linkLabel_courseEdit.Enabled = false;
            linkLabel_courseNew.Enabled = true;
            linkLabel_courseUpdate.Enabled = false;
        }







    }
}
