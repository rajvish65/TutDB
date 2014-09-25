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
    public partial class BatchMaster : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();

        static bool hasUpdated = false;
        static Int32 BatchId;

        public BatchMaster()
        {
            InitializeComponent();
        }

        private void BatchMaster_Load(object sender, EventArgs e)
        {
           
            CommonUtilities.populateBatch(cmbBatchMaster);
           
            txtBatchName.Enabled = false;
            txtBatchCode.Enabled = false;
            txtBatchIsActive.Enabled = false;
            linkLabel_batchAcitvate.Enabled = false;
            linkLabel_batchAdd.Enabled = false;
            linkLabel_batchCancel.Enabled = false;
            linkLabel_batchUpdate.Enabled = false;
            linkLabel_batchEdit.Enabled = false;
            lblBatchName.Enabled = false;
            lblBatchCode.Enabled = false;
            lblBatchIsActive.Enabled = false;
        }

        

        public void Clear()
        {
            txtBatchCode.Text = "";
            txtBatchName.Text = "";
            txtBatchIsActive.Text = "";
            
        }

        private void linkLabel_batchMasterClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblBatchMaster batchMaster = new tblBatchMaster();
            this.Close();
        }

        

        private void linkLabel_batchAcitvate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblBatchMaster batchMaster = new tblBatchMaster();
            batchMaster = db.tblBatchMasters.Where(x => x.BatchId== BatchId).Single();

            if (linkLabel_batchAcitvate.Text == "Activate")
            {
                batchMaster.isActive = 1;
                batchMaster.UpdatedDate = DateTime.Today;
                db.SaveChanges();
                txtBatchIsActive.Text = "Yes";
                linkLabel_batchAcitvate.Text = "InActivate";
                MessageBox.Show(txtBatchName.Text + " Acitvated");
            }
            else
                if (linkLabel_batchAcitvate.Text == "InActivate")
                {
                    batchMaster.isActive = 0;
                    batchMaster.UpdatedDate = DateTime.Today;
                    db.SaveChanges();
                    txtBatchIsActive.Text = "No";
                    linkLabel_batchAcitvate.Text = "Activate";
                    MessageBox.Show(txtBatchName.Text + " InAcitvated");
                }
        }

        private void linkLabel_batchEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtBatchName.ReadOnly = false;
            txtBatchCode.ReadOnly = false;
            linkLabel_batchUpdate.Enabled = true;
            linkLabel_batchEdit.Enabled = false;
        }

        private void linkLabel_batchNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_batchEdit.Enabled = false;
            linkLabel_batchUpdate.Enabled = false;
            linkLabel_batchNew.Enabled = false;
            linkLabel_batchCancel.Enabled = true;
            linkLabel_batchAdd.Enabled = true;
            linkLabel_batchAcitvate.Enabled = false;
            lblBatchName.Enabled = true;
            lblBatchCode.Enabled = true;
            lblBatchIsActive.Enabled = true;
            txtBatchName.Enabled = true;
            txtBatchCode.Enabled = true;
            txtBatchName.ReadOnly = false;
            txtBatchCode.ReadOnly = false;
            Clear();
        }

        private void linkLabel_batchAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            manageBatch();
        }

        private void linkLabel_batchUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hasUpdated = true;
            // ManageCourse();
            if (validateBatch())
                return; //Validation fails.

            //Validation successful.

            if (db.tblBatchMasters.Where(x => x.BatchId != BatchId && x.BatchName.Equals(txtBatchName.Text)).Count() > 0)
            {
                MessageBox.Show("Batch Already Exists");
            }
            else
                if (db.tblBatchMasters.Where(x => x.BatchId != BatchId && x.BatchCode.Equals(txtBatchCode.Text)).Count() > 0)
                {
                    MessageBox.Show("Batch Code Already Exists");
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
                                tblBatchMaster batch;
                                batch = db.tblBatchMasters.Where(x => x.BatchId == BatchId).Single();
                                batch.BatchCode = txtBatchCode.Text;
                                batch.BatchName = txtBatchName.Text;
                                batch.UpdatedDate = DateTime.Today;

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
                        lblBatchName.Enabled = false;
                        lblBatchCode.Enabled = false;
                        lblBatchIsActive.Enabled = false;
                        txtBatchIsActive.Enabled = false;
                        txtBatchCode.Enabled = false;
                        txtBatchName.Enabled = false;
                        linkLabel_batchAdd.Enabled = false;
                        linkLabel_batchCancel.Enabled = false;
                        linkLabel_batchNew.Enabled = true;
                        linkLabel_batchUpdate.Enabled = false;
                        linkLabel_batchAcitvate.Enabled = false;

                        MessageBox.Show("Batch updated successfully.", "Success");
                     

                        CommonUtilities.populateBatch(cmbBatchMaster);
                     
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }
        }

        public void manageBatch()
        {
            if (validateBatch())
                return; //Validation fails.

            //Validation successful.

            if (db.tblCourseMasters.Where(x => x.CourseName.Equals(txtBatchName.Text)).Count() > 0)
            {
                MessageBox.Show("Batch Already Exist");
            }
            else
                if (db.tblCourseMasters.Where(x => x.CourseCode.Equals(txtBatchCode.Text)).Count() > 0)
                {
                    MessageBox.Show("Batch Code Already Exist");
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
                                tblBatchMaster batch = new tblBatchMaster();

                                batch.BatchCode = txtBatchCode.Text;
                                batch.BatchName = txtBatchName.Text;
                                batch.isActive = 1;
                                batch.CreatedDate = DateTime.Today;

                                db.tblBatchMasters.Add(batch);
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
                        lblBatchName.Enabled = false;
                        lblBatchCode.Enabled = false;
                        lblBatchIsActive.Enabled = false;
                        txtBatchIsActive.Enabled = false;
                        txtBatchCode.Enabled = false;
                        txtBatchName.Enabled = false;
                        linkLabel_batchAdd.Enabled = false;
                        linkLabel_batchCancel.Enabled = false;
                        linkLabel_batchNew.Enabled = true;
                        MessageBox.Show("Batch added successfully.", "Success");
                        cmbBatchMaster.SelectedIndexChanged -= new System.EventHandler(this.cmbBatchMaster_SelectedIndexChanged);
                        CommonUtilities.populateBatch(cmbBatchMaster);
                        cmbBatchMaster.SelectedIndexChanged += new System.EventHandler(this.cmbBatchMaster_SelectedIndexChanged);
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error");
                    }
                }
        }


        private bool validateBatch()
        {
            bool errorOccurred = false;
            String errorMessage = "";

            if (txtBatchCode.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Batch Code \n";
            }

            if (txtBatchName.Text.Trim().Equals(""))
            {
                errorOccurred = true;
                errorMessage += "-> Please enter Batch Name \n";
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }

       
        private void linkLabel_batchCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
            linkLabel_batchEdit.Enabled = false;
            linkLabel_batchAcitvate.Enabled = false;
            linkLabel_batchAdd.Enabled = false;
            linkLabel_batchUpdate.Enabled = false;
        }

        private void cmbBatchMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblBatchMaster batchMaster = new tblBatchMaster();
            //courseMaster=db.tblCourseMasters.Where(x=>x.CourseName = cmbCourseMaster.SelectedValue).Single();
            string selBatchName = (cmbBatchMaster.SelectedItem as tblBatchMaster).BatchName;

            if (!selBatchName.Equals("Select"))
            {
                batchMaster = db.tblBatchMasters.Where(x => x.BatchName.Equals(selBatchName)).FirstOrDefault();
                BatchId = Convert.ToInt32(batchMaster.BatchId);
                txtBatchCode.Text = batchMaster.BatchCode;
                txtBatchName.Text = batchMaster.BatchName;
                //tblBatchCourse bt = new tblBatchCourse();
                //bt = db.tblBatchCourses.Where(x => x.BatchId == BatchId).FirstOrDefault();
                //String a=bt.CourseId.ToString();
                //cmbBatchMaster.Text =db.tblCourseMasters.Where(x=>x.CourseId== db.tblBatchCourses.Where(y => y.BatchId == BatchId).Single().CourseId).First().CourseName;
                if (batchMaster.isActive == 1)
                {
                    txtBatchIsActive.Text = "Yes";
                    linkLabel_batchAcitvate.Text = "InActivate";
                }
                else
                {
                    txtBatchIsActive.Text = "No";
                    linkLabel_batchAcitvate.Text = "Activate";
                }

                lblBatchName.Enabled = true;
                lblBatchCode.Enabled = true;
                lblBatchIsActive.Enabled = true;
                txtBatchName.Enabled = true;
                txtBatchCode.Enabled = true;
                txtBatchIsActive.Enabled = true;
                txtBatchCode.ReadOnly = true;
                txtBatchName.ReadOnly = true;
                txtBatchIsActive.ReadOnly = true;
                linkLabel_batchAcitvate.Enabled = true;
                linkLabel_batchEdit.Enabled = true;
                linkLabel_batchAdd.Enabled = false;
                linkLabel_batchCancel.Enabled = true;
                linkLabel_batchUpdate.Enabled = false;
                linkLabel_batchNew.Enabled = true;
            }
        }

       
    }
}
