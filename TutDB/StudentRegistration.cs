
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
using System.Data.Objects;
using System.IO;
using System.Globalization;

namespace TutDB
{
    public partial class StudentRegistration : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static Int32 StudentId;
        static Int32 selectedAllocationId;
        static bool hasComeFromSearchDetail = false;
        int discount;

        String picLoc;

        public StudentRegistration()
        {
            InitializeComponent();
        }

        internal static void setStudentId(int selectedStudentId)
        {
            StudentId = selectedStudentId;
        }

        internal static void setHasComeFromSearch(bool hasCome)
        {
            hasComeFromSearchDetail = hasCome;
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            if (hasComeFromSearchDetail == false)
            {
                CommonUtilities.populateCity(cmbCity);
                CommonUtilities.populateGenders(cmbGender);

                this.cmbCourse.SelectedIndexChanged -= new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
                CommonUtilities.populateCourse(cmbCourse);
                this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);

                //CommonUtilities.populateBatch(cmbBatch);

                linkLabel_editStudent.Visible = false;
                linkLabel_deleteStudent.Visible = false;
                lblNoImage.Visible = false;
            }
            else
                if (hasComeFromSearchDetail == true)
                {
                    tblStudentDetail studentDetail = null;
                    tblStudentAllocation studentAllocation = null;

                    CommonUtilities.populateCity(cmbCity);
                    CommonUtilities.populateGenders(cmbGender);

                    try
                    {
                        studentDetail = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive==1).Single();
                        studentAllocation =db.tblStudentAllocations.Where(x =>x.StudentId==StudentId && x.isActive==1).Single();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("User not found. He/She may have been deleted.", "Error");
                        this.Close();
                        return;
                    }

                    btnBrowse.Visible = false;
                    btnSubmit.Visible = false;
                    //Set values of all textboxes
                    txtFirstName.Text = studentDetail.FirstName;
                    txtMiddleName.Text=studentDetail.MiddleName;
                    txtLastName.Text=studentDetail.LastName;
                    txtFatherName.Text=studentDetail.FatherName;
                    txtFatherContacts.Text = studentDetail.FatherContacts;
                    txtMotherName.Text=studentDetail.MotherName;
                    txtMotherContacts.Text=studentDetail.MotherContacts;
                    txtAddress1.Text =studentDetail.Address1;
                    txtAddress2.Text=studentDetail.Address2;
                    txtMobile.Text=studentDetail.Contacts;
                    txtResiContacts.Text=studentDetail.ResiContacts;
                    dtpDob.Value=studentDetail.DOB.Value;
                    txtEmail.Text=studentDetail.Email;
                    dtpAdmitDate.Value= studentDetail.AdmitDate.Value;
                    txtFees.Text = studentAllocation.Fees.ToString();
                    txtDiscount.Text = studentAllocation.Discount.ToString();
                    txtDeposit.Text = studentAllocation.Deposit.ToString();
                    txtActualFees.Text = studentAllocation.ActualFees.ToString();
                    cmbGender.Text = studentDetail.tblGenderMaster.Description;
                    cmbCity.Text = studentDetail.tblCityMaster.CityName;
                    cmbCourse.Text = studentAllocation.tblCourseMaster.CourseName;
                    cmbBatch.Text = studentAllocation.tblBatchMaster.BatchName;
                    cmbLastQualification.Text = studentAllocation.LastQualification;
                    cmbLastQualificationScore.Text = studentAllocation.LastQualificationScore;
                   

                    byte[] img = (byte[])studentDetail.Dpic;
                    if (img == null)
                    {
                        picBox.Image = null;
                        lblNoImage.Visible=true;
                    }   
                    else
                    {
                        lblNoImage.Visible = false;
                        MemoryStream ms = new MemoryStream(img);
                        picBox.Image = Image.FromStream(ms);
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }



                    this.comboBox_isStudentActive.SelectedIndexChanged -= new System.EventHandler(this.comboBox_isStudentActive_SelectedIndexChanged); 
                    List<String> activeListStudent = new List<String>();
                    activeListStudent.Add("Select");
                    activeListStudent.Add("Yes");
                    activeListStudent.Add("No");
                    comboBox_isStudentActive.DataSource = activeListStudent;
                    this.comboBox_isStudentActive.SelectedIndexChanged += new System.EventHandler(this.comboBox_isStudentActive_SelectedIndexChanged);

                    var allocation = db.tblStudentAllocations.Where(x => x.StudentId == StudentId)
                                 .Select(x => new
                                 {
                                     x.AllocationId, 
                                     x.StudentId,
                                     x.tblCourseMaster.CourseName,
                                     x.tblBatchMaster.BatchName,
                                     x.StartDate,
                                     x.EndDate,
                                     Active = x.isActive.Value == 1 ? "Yes":"No"
                                              //x.isActive.Value ==0? :

                                 }).OrderBy(x => x.StartDate);
                    allocation.ToList();
                    dataGridView_studentAllocation.DataSource = allocation.ToList();

                    //Hide the extra column.
                    dataGridView_studentAllocation.Columns["AllocationId"].Visible = false;
                    dataGridView_studentAllocation.Columns["StudentId"].Visible = false;

                    //Registering an event handler when a particular row is clicked.
                    dataGridView_studentAllocation.CellClick -= displayDetailedAllocation;
                    dataGridView_studentAllocation.CellClick += displayDetailedAllocation;

                    txtFirstName.Enabled = false;
                    txtMiddleName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtFatherName.Enabled = false;
                    txtFatherContacts.Enabled = false;
                    txtMotherName.Enabled = false;
                    txtMotherContacts.Enabled = false;
                    txtAddress1.Enabled = false;
                    txtAddress2.Enabled = false;
                    txtMobile.Enabled = false;
                    txtResiContacts.Enabled = false;
                    dtpDob.Enabled = false;
                    txtEmail.Enabled = false;
                    dtpAdmitDate.Enabled = false;
                    txtFees.Enabled = false;
                    txtDiscount.Enabled = false;
                    txtDeposit.Enabled = false;
                    txtActualFees.Enabled = false;
                    cmbGender.Enabled = false;
                    cmbCity.Enabled = false;
                    cmbCourse.Enabled = false;
                    cmbBatch.Enabled = false;
                    cmbLastQualification.Enabled = false;
                    cmbLastQualificationScore.Enabled = false;
                }

        }

        /// <summary>
        /// Fetch/Generate the monthly bill of the selected user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayDetailedAllocation(object sender, DataGridViewCellEventArgs e)
        {
            linkLabel_viewAllocation.Visible = true;

            //Getting the value of clicked row
            DataGridView button = sender as DataGridView;
            DataGridViewCellCollection selectedUser = button.CurrentRow.Cells as DataGridViewCellCollection;

            //Returns the selected customer ID
            selectedAllocationId = Int32.Parse(selectedUser["AllocationId"].Value.ToString());
            StudentId = Int32.Parse(selectedUser["StudentId"].Value.ToString());
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonUtilities.loadBatchCombo(cmbBatch, cmbCourse.SelectedIndex);
            CommonUtilities.loadCourseFees(txtFees, cmbCourse.SelectedIndex);
            
        }

         
          private void tb_KeyDown(object sender, KeyEventArgs e)
          {
              //String deposit=txtDiscount.Text.ToString();
              //deposit = deposit + ".00";
              //txtDiscount.Text = deposit;

              if (e.KeyCode == Keys.Enter)
              {
                  
                   int fees = 0;
                   String fee=txtFees.Text.ToString();
                  
                   fees = Convert.ToInt32( fee.Substring(0, fee.Length - 3));
                   int discount=Convert.ToInt32(txtDiscount.Text.ToString());
                   int actualfees=fees-discount;
                  
                   txtActualFees.Text=actualfees.ToString()+".00";
                   txtActualFees.ReadOnly=true;
              }
          }



          /// <summary>
          /// Validates the form-fields before insertion into the DB.
          /// </summary>
          /// <returns></returns>
          private bool validate()
          {
              bool errorOccurred = false;
              String errorMessage = "";

              if (txtFirstName.Text.Trim().Equals(""))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please enter First Name \n";
              }
               if (txtLastName.Text.Trim().Equals(""))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please enter Last Name \n";
              }
              if (txtAddress1.Text.Trim().Equals(""))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please enter Address Line 1 \n";
              }

              if (cmbCourse.Text.Trim().Equals("") || cmbCourse.Text.Trim().Equals("Select"))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please select Course \n";
              }
              if (cmbBatch.Text.Trim().Equals("") || cmbBatch.Text.Trim().Equals("Select"))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please select Batch \n";
              }
              if (cmbLastQualification.Text.Trim().Equals("") || cmbLastQualification.Text.Trim().Equals("Select"))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please select Qualification \n";
              }
              if (cmbGender.Text.Trim().Equals("") || cmbGender.Text.Trim().Equals("Select"))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please select Gender \n";
              }
              if (cmbCity.Text.Trim().Equals("") || cmbCity.Text.Trim().Equals("Select"))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please select City \n";
              }



              long result;
              if (txtResiContacts.Text.Trim().Length != 0)
              {
                  if (!long.TryParse(txtResiContacts.Text, out result))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Please Enter a Valid Phone Number \n";
                  }
              }
              long mobile;
              if (txtMobile.Text.Trim().Length != 0)
              {
                  if (!long.TryParse(txtMobile.Text, out mobile))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Please Enter a Valid Mobile Number \n";
                  }
              }
              long fatherContacts;
              if (txtFatherContacts.Text.Trim().Length != 0)
              {
                  if (!long.TryParse(txtFatherContacts.Text, out fatherContacts))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Please Enter a Valid Contact Number(Father) \n";
                  }
              }
              long motherContacts;
              if (txtMotherContacts.Text.Trim().Length != 0)
              {
                  if (!long.TryParse(txtMotherContacts.Text, out motherContacts))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Please Enter a Valid Contact Number(Mother) \n";
                  }
              }
              if (txtEmail.Text.Trim().Length != 0)
              {
                  if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".") && (txtEmail.Text.IndexOf(".") - txtEmail.Text.IndexOf("@") > 1)))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Please Enter a Valid Email Id \n";
                  }
              }
              if (dtpDob.Value > DateTime.Now || dtpDob.Value < DateTime.Parse("1990-01-01"))
              {
                  errorOccurred = true;
                  errorMessage += "-> Please Enter a Valid Date of Birth \n";
              }
              if (dtpAdmitDate.Value <dtpDob.Value)
              {
                  errorOccurred = true;
                  errorMessage += "-> Please Enter a Valid Joining Date \n";
              }
              int fee;
              if (txtFees.Text.Trim().Length != 0)
              {
                  String Currentfee =Convert.ToString((int)(Decimal.Parse(txtFees.Text, NumberStyles.Float, CultureInfo.InvariantCulture)));
                  if (!Int32.TryParse(Currentfee, out fee))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Fee Cannot be Empty,Please select course \n";
                  }
              }
              int deposit;
              if (txtDeposit.Text.Trim().Length != 0)
              {
                  if (!Int32.TryParse(txtDeposit.Text, out deposit))
                  {
                      errorOccurred = true;
                      errorMessage += "-> Please Enter a Valid Deposit \n";
                  }
              }

              //int balance;
              //if (textBox_currentBalance.Text.Trim().Length != 0)
              //{
              //    if (!Int32.TryParse(textBox_currentBalance.Text, out balance))
              //    {
              //        errorOccurred = true;
              //        errorMessage += "-> Please Enter a Valid Balance \n";
              //    }
              //}

             

              if (errorOccurred)
              {
                  MessageBox.Show(errorMessage, "Error");
              }

              return errorOccurred;
          }


        /// <summary>
        /// Fetches values from the form-fields and populates the customerDetail object.
        /// </summary>
        /// <param name="studentDetails">The CustomerDetail object into which the form-field-values are filled.</param>
        private void fetchStudentValues(tblStudentDetail studentDetails)
        {
            if (hasComeFromSearchDetail == true)
            {
                studentDetails = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).Single();
            }
            studentDetails.FirstName = txtFirstName.Text;
            studentDetails.MiddleName=txtMiddleName.Text;
            studentDetails.LastName = txtLastName.Text;
            studentDetails.FatherName = txtFatherName.Text;
            studentDetails.FatherContacts = txtFatherContacts.Text;
            studentDetails.MotherName = txtMotherName.Text;
            studentDetails.MotherContacts = txtMotherContacts.Text;
            studentDetails.Address1 = txtAddress1.Text;
            studentDetails.Address2 = txtAddress2.Text;
            studentDetails.Contacts = txtMobile.Text;
            studentDetails.ResiContacts = txtResiContacts.Text;
            studentDetails.DOB = dtpDob.Value;
            studentDetails.Email = txtEmail.Text;
            studentDetails.isActive = 1;
            studentDetails.AdmitDate = dtpAdmitDate.Value;
            studentDetails.CreatedDate = DateTime.Today;


            String selectedCity = (cmbCity.SelectedItem as tblCityMaster).CityName.ToString();
            int cityId = Convert.ToInt32(db.tblCityMasters.Where(x => x.CityName.Equals(selectedCity)).First().CityId);
            studentDetails.CityId = cityId;


            String selectedGender = (cmbGender.SelectedItem as tblGenderMaster).Description.ToString();
            int genderId = Convert.ToInt32(db.tblGenderMasters.Where(x => x.Description.Equals(selectedGender)).First().GenderId);
            //int genderId = Convert.ToInt32(selectedGender);
            studentDetails.Sex = genderId;

            String selectedQualification = cmbLastQualification.SelectedItem.ToString();
            studentDetails.LastQualificatiion = selectedQualification;

            String selectedQualificationScore = cmbLastQualificationScore.SelectedItem.ToString();
            studentDetails.LastQualificationScore = selectedQualificationScore;

            byte[] img = null;
            if (picLoc != null)
            {
                FileStream fs = new FileStream(picLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                studentDetails.Dpic = img;
            }
        }

        private void fetchAllocationValues(tblStudentAllocation studentAllocation)
        {
            //if (hasComeFromSearchDetail == true)
            //{
            //    studentDetails = db.tblStudentAllocations.Where(x => x.AllocationId == AllocationId && x.isActive == 1).Single();
            //}

            studentAllocation.isActive = 1;
            studentAllocation.AdmitDate = dtpAdmitDate.Value;
            studentAllocation.CreatedDate = DateTime.Today;

            String selectedCourse = (cmbCourse.SelectedItem as tblCourseMaster).CourseName.ToString();
            int courseId = Convert.ToInt32(db.tblCourseMasters.Where(x => x.CourseName.Equals(selectedCourse)).First().CourseId);
            studentAllocation.CourseId = courseId;

            //var selectBatch = cmbBatch.SelectedItem.ToString();

            String selectedBatch = (cmbBatch.SelectedItem as tblBatchMaster).BatchName.ToString();
            int batchId = Convert.ToInt32(db.tblBatchMasters.Where(x => x.BatchName.Equals(selectedBatch)).First().BatchId);
            studentAllocation.BatchId = batchId;

            String selectedQualification = cmbLastQualification.SelectedItem.ToString();
            studentAllocation.LastQualification = selectedQualification;

            String selectedQualificationScore = cmbLastQualificationScore.SelectedItem.ToString();
            studentAllocation.LastQualificationScore = selectedQualificationScore;

            int payableFees = 0;
            String fees = txtFees.Text.ToString();
            payableFees = Convert.ToInt32(fees.Substring(0, fees.Length - 3));
            //Int32.TryParse(txtFees.Text.Trim(), out payableFees);
            studentAllocation.Fees = payableFees;

            int discountAmount = 0;
            Int32.TryParse(txtDiscount.Text.Trim(), out discountAmount);
            studentAllocation.Discount = discountAmount;

            int depositAmount = 0;
            Int32.TryParse(txtDeposit.Text.Trim(), out depositAmount);
            studentAllocation.Deposit = depositAmount;

            int actualAmount = 0;
            actualAmount = payableFees - discountAmount;
            txtActualFees.Text = actualAmount.ToString();
            studentAllocation.ActualFees = depositAmount;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validate())
            return; //Validation fails.

            //Validation successful.

            //Create a new CustomerDetail object, fetch form-field-values and insert into the DB.
            tblStudentDetail studentDetails = new tblStudentDetail();
            tblStudentAllocation allocationDetails = new tblStudentAllocation();
            if (hasComeFromSearchDetail == false)
            {
                int lastInsertedStudentCode = db.tblStudentDetails.Count();
                lastInsertedStudentCode = lastInsertedStudentCode + 1;
                studentDetails.StudentCode = "S" + lastInsertedStudentCode.ToString();
            }
  

            bool exceptionOccured = false;
            try
            {
                bool success = false;

                /* For every new Customer inserted into the DB, entries are made in 2 tables - CustomerDetails and CustomerDues.
                 * Hence a transaction is required. */
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        //if (hasComeFromSearchDetail == false)
                        //{
                        //    db.tblStudentDetails.Add(studentDetails);
                        //    db.tblStudentAllocations.Add(allocationDetails);
                        //}

                        fetchStudentValues(studentDetails);
                        if (hasComeFromSearchDetail == false)
                        {
                            db.tblStudentDetails.Add(studentDetails);
                        }
                        db.SaveChanges();

                        StudentId = Convert.ToInt32(db.tblStudentDetails.Max(x => x.StudentId).ToString());
                        allocationDetails.StudentId = StudentId;
                        fetchAllocationValues(allocationDetails);
                        if (hasComeFromSearchDetail == false)
                        {
                            db.tblStudentAllocations.Add(allocationDetails);
                        }
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

            if (!exceptionOccured && hasComeFromSearchDetail==false)
            {
                MessageBox.Show("Student added successfully.", "Success");
            }
            else
                if (!exceptionOccured && hasComeFromSearchDetail==true)
                {
                    MessageBox.Show("Student updated successfully.", "Success");
                }
            else
            {
                MessageBox.Show("Something went wrong.", "Error");
            }
        }

       

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Employee Picture.";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picLoc = dlg.FileName.ToString();
                    Image image = Image.FromFile(picLoc);
                    picBox.Image = image;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel_editStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtFatherName.Enabled = true;
            txtFatherContacts.Enabled = true;
            txtMotherName.Enabled = true;
            txtMotherContacts.Enabled = true;
            txtAddress1.Enabled = true;
            txtAddress2.Enabled = true;
            txtMobile.Enabled = true;
            txtResiContacts.Enabled = true;
            dtpDob.Enabled = true;
            txtEmail.Enabled = true;
            dtpAdmitDate.Enabled = true;
            txtFees.Enabled = true;
            txtDiscount.Enabled = true;
            txtDeposit.Enabled = true;
            txtActualFees.Enabled = true;
            cmbGender.Enabled = true;
            cmbCity.Enabled = true;
            cmbCourse.Enabled = true;
            cmbBatch.Enabled = true;
            cmbLastQualification.Enabled = true;
            cmbLastQualificationScore.Enabled = true;
            btnSubmit.Visible = true;
            btnBrowse.Visible = true;
        }

        private void linkLabel_deleteStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to delete the student?",
            "Important Query",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                tblStudentDetail studentDetail = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).Single();
                studentDetail.isActive = 0;
                db.SaveChanges();
                
            }
        }



        private void comboBox_isStudentActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_isStudentActive.SelectedItem.ToString() == "Yes")
            {
                var allocation = db.tblStudentAllocations.Where(x => x.StudentId == StudentId && x.isActive == 1)
                                .Select(x => new
                                {
                                    x.AllocationId,
                                    x.tblCourseMaster.CourseName,
                                    x.tblBatchMaster.BatchName,
                                    x.StartDate,
                                    x.EndDate,
                                    Active = x.isActive.Value == 1 ? "Yes" : "No"
                                }).OrderBy(x => x.StartDate);
                allocation.ToList();
                dataGridView_studentAllocation.DataSource = allocation.ToList();

                //Hide the extra column.
                dataGridView_studentAllocation.Columns["AllocationId"].Visible = false;
            }
            else if (comboBox_isStudentActive.SelectedItem.ToString() == "No")
            {
                var allocation = db.tblStudentAllocations.Where(x => x.StudentId == StudentId && x.isActive == 0)
                                                .Select(x => new
                                                {
                                                    x.AllocationId,
                                                    x.tblCourseMaster.CourseName,
                                                    x.tblBatchMaster.BatchName,
                                                    x.StartDate,
                                                    x.EndDate,
                                                    Active = x.isActive.Value == 1 ? "Yes" : "No"
                                                }).OrderBy(x => x.StartDate);
                allocation.ToList();
                dataGridView_studentAllocation.DataSource = allocation.ToList();

                //Hide the extra column.
                dataGridView_studentAllocation.Columns["AllocationId"].Visible = false;
            }
            else
            {
                var allocation = db.tblStudentAllocations.Where(x => x.StudentId == StudentId)
                                                .Select(x => new
                                                {
                                                    x.AllocationId,
                                                    x.tblCourseMaster.CourseName,
                                                    x.tblBatchMaster.BatchName,
                                                    x.StartDate,
                                                    x.EndDate,
                                                    Active = x.isActive.Value == 1 ? "Yes" : "No"
                                                }).OrderBy(x => x.StartDate);
                allocation.ToList();
                dataGridView_studentAllocation.DataSource = allocation.ToList();

                //Hide the extra column.
                dataGridView_studentAllocation.Columns["AllocationId"].Visible = false;
            }
        }

       
        

        private void linkLabel_AddNewAllocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAllocation.setStudentId(StudentId);

            //If this user has been deleted in another window, display error message.
            tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).FirstOrDefault();
            if (selectedStudent == null)
            {
                MessageBox.Show("Allocation not found. It may have been deleted.", "Error");
                return;
            }

            NewAllocation newAllocation = new NewAllocation();
            newAllocation.Show();
        }

        private void linkLabel_viewAllocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAllocation.setStudentId(StudentId);
            NewAllocation.setAllocationId(selectedAllocationId);
            NewAllocation.setHasComeFromStudentDetail(true);

            //If this user has been deleted in another window, display error message.
            tblStudentDetail selectedStudent = db.tblStudentDetails.Where(x => x.StudentId == StudentId && x.isActive == 1).FirstOrDefault();
            if (selectedStudent == null)
            {
                MessageBox.Show("Allocation not found. It may have been deleted.", "Error");
                return;
            }

            NewAllocation newAllocation = new NewAllocation();
            newAllocation.Show();
        }

       
       

   
    }
}
