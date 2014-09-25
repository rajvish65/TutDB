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

namespace TutDB
{
    public partial class EmployeeRegistration : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        
        static Int32 EmployeeId;
        String selectedDesignation = null;
        static bool hasComeFromSearchDetail = false;
        String picLoc;

        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        internal static void setEmployeeId(int selectedEmployeeId)
        {
            EmployeeId = selectedEmployeeId;
        }

        internal static void setHasComeFromSearch(bool hasCome)
        {
            hasComeFromSearchDetail = hasCome;
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

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            if (hasComeFromSearchDetail == false)
            {
                CommonUtilities.populateCity(cmbCity);
                CommonUtilities.populateGenders(cmbGender);
                CommonUtilities.populateDesignation(cmbDesignation);
                CommonUtilities.populateChkListSubject(checkedListBox_subjects);

                linkLabel_editEmployee.Visible = false;
                linkLabel_deleteEmployee.Visible = false;
                lblNoImage.Visible = false;
            }
            else
                if (hasComeFromSearchDetail == true)
                {
                    tblEmployeeDetail empDetails = null;

                    CommonUtilities.populateCity(cmbCity);
                    CommonUtilities.populateGenders(cmbGender);
                    CommonUtilities.populateChkListSubject(checkedListBox_subjects);

                    try
                    {
                        empDetails = db.tblEmployeeDetails.Where(x => x.EmployeeId == EmployeeId && x.isActive == 1).Single();
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
                    txtFirstName.Text = empDetails.FirstName;
                    txtMiddleName.Text = empDetails.MiddleName;
                    txtLastName.Text = empDetails.LastName;
                    txtFatherName.Text = empDetails.FatherName;
                    txtMotherName.Text = empDetails.MotherName;
                    txtAddress1.Text = empDetails.Address1;
                    txtAddress2.Text = empDetails.Address2;
                    txtMobile.Text = empDetails.Contacts;
                    txtResiContacts.Text = empDetails.ResiContacts;
                    dtpDob.Value = empDetails.DOB.Value;
                    txtEmail.Text = empDetails.Email;
                    dtpJoiningDate.Value = empDetails.JoiningDate.Value;
                    cmbGender.Text = empDetails.tblGenderMaster.Description;
                    cmbCity.Text = empDetails.tblCityMaster.CityName;
                    cmbQualification.Text = empDetails.Qualificaton;

                    byte[] img = (byte[])empDetails.Dpic;
                    if (img == null)
                    {
                        picBox.Image = null;
                        lblNoImage.Visible = true;
                    }
                    else
                    {
                        lblNoImage.Visible = false;
                        MemoryStream ms = new MemoryStream(img);
                        picBox.Image = Image.FromStream(ms);
                    }

                    txtFirstName.Enabled = false;
                    txtMiddleName.Enabled = false;
                    txtLastName.Enabled = false;
                    txtFatherName.Enabled = false;
                    txtMotherName.Enabled = false;
                    txtAddress1.Enabled = false;
                    txtAddress2.Enabled = false;
                    txtMobile.Enabled = false;
                    txtResiContacts.Enabled = false;
                    dtpDob.Enabled = false;
                    txtEmail.Enabled = false;
                    dtpJoiningDate.Enabled = false;
                    cmbGender.Enabled = false;
                    cmbCity.Enabled = false;                
                    cmbQualification.Enabled = false;
                }
        }


        /// <summary>
        /// Fetches values from the form-fields and populates the customerDetail object.
        /// </summary>
        /// <param name="empDetails">The CustomerDetail object into which the form-field-values are filled.</param>
        private void fetchFormValues(tblEmployeeDetail empDetails)
        {
            if (hasComeFromSearchDetail == true)
            {
                empDetails = db.tblEmployeeDetails.Where(x => x.EmployeeId == EmployeeId && x.isActive == 1).Single();
            }
            empDetails.FirstName = txtFirstName.Text;
            empDetails.MiddleName = txtMiddleName.Text;
            empDetails.LastName = txtLastName.Text;
            empDetails.FatherName = txtFatherName.Text;
            empDetails.MotherName = txtMotherName.Text;
            empDetails.Address1 = txtAddress1.Text;
            empDetails.Address2 = txtAddress2.Text;
            empDetails.Contacts = txtMobile.Text;
            empDetails.ResiContacts = txtResiContacts.Text;
            empDetails.DOB = dtpDob.Value;
            empDetails.Email = txtEmail.Text;
            empDetails.isActive = 1;
            empDetails.JoiningDate = dtpJoiningDate.Value;
            empDetails.CreatedDate = DateTime.Today;

            //String selectedCity1 = cmbCity.SelectedItem.ToString();
            //int areaId = Convert.ToInt32(db.tblCityMasters.Where(x => x.CityName.Equals(selectedCity1)).First().CityId);
            //studentDetails.CityId = areaId;

            String selectedCity = (cmbCity.SelectedItem as tblCityMaster).CityName.ToString();
            int cityId = Convert.ToInt32(db.tblCityMasters.Where(x => x.CityName.Equals(selectedCity)).First().CityId);
            //int cityId = Convert.ToInt32(selectedCity);
            empDetails.CityId = cityId;

           
            //var selectBatch = cmbBatch.SelectedItem.ToString();

            

            String selectedGender = (cmbGender.SelectedItem as tblGenderMaster).Description.ToString();
            int genderId = Convert.ToInt32(db.tblGenderMasters.Where(x => x.Description.Equals(selectedGender)).First().GenderId);
            //int genderId = Convert.ToInt32(selectedGender);
            empDetails.Sex = genderId;

            String selectedQualification = cmbQualification.SelectedItem.ToString();
            empDetails.Qualificaton = selectedQualification;

            selectedDesignation = (cmbDesignation.SelectedItem as tblBasicMaster).Value.ToString();
            empDetails.Designation = selectedDesignation;

            byte[] img = null;
            if (picLoc != null)
            {
                FileStream fs = new FileStream(picLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                empDetails.Dpic = img;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validate())
            return; //Validation fails.

            //Validation successful.

            //Create a new CustomerDetail object, fetch form-field-values and insert into the DB.
            tblEmployeeDetail empDetails = new tblEmployeeDetail();
            if (hasComeFromSearchDetail == false)
            {
                int lastInsertedEmployeeCode = db.tblEmployeeDetails.Count();
                lastInsertedEmployeeCode = lastInsertedEmployeeCode + 1;

                if ((cmbDesignation.SelectedItem as tblBasicMaster).Value.ToString().Equals("Teacher"))
                    empDetails.EmployeeCode = "T" + lastInsertedEmployeeCode.ToString();
                else
                    empDetails.EmployeeCode = "E" + lastInsertedEmployeeCode.ToString();
            }
            //customerDetail.CustomerId = lastInsertedCustomerId + 1; //New Customer's id.

            fetchFormValues(empDetails);

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
                        if (hasComeFromSearchDetail == false)
                        {
                            db.tblEmployeeDetails.Add(empDetails);
                        }

                        //Pending Balance should be inserted in the CustomerDues table.
                        //CustomerDue dues = new CustomerDue();
                        //dues.CustomerId = customerDetail.CustomerId;
                        //int dueAmount = 0;
                        //Int32.TryParse(textBox_currentBalance.Text.Trim(), out dueAmount);
                        //dues.DueAmount = dueAmount;

                        //db.CustomerDues.AddObject(dues);

                        db.SaveChanges();
                        EmployeeId = Int32.Parse(empDetails.EmployeeId.ToString());

                        tblSubjectEmployeeMapping subjectEmployee = new tblSubjectEmployeeMapping();
                        addCheckedItems(subjectEmployee);  

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

            if (!exceptionOccured && hasComeFromSearchDetail == false)
            {
                MessageBox.Show("User added successfully.", "Success");
            }
            else
                if (!exceptionOccured && hasComeFromSearchDetail == true)
                {
                    MessageBox.Show("User updated successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Error");
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

            if (cmbDesignation.Text.Trim().Equals("") || cmbDesignation.Text.Trim().Equals("Select"))
            {
                errorOccurred = true;
                errorMessage += "-> Please select Designation \n";
            }
            if (cmbQualification.Text.Trim().Equals("") || cmbQualification.Text.Trim().Equals("Select"))
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

            if (txtEmail.Text.Trim().Length != 0)
            {
                if (!(txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".") && (txtEmail.Text.IndexOf(".") - txtEmail.Text.IndexOf("@") > 1)))
                {
                    errorOccurred = true;
                    errorMessage += "-> Please Enter a Valid Email Id \n";
                }
            }
            if (dtpDob.Value > DateTime.Now || dtpDob.Value < DateTime.Parse("1900-01-01"))
            {
                errorOccurred = true;
                errorMessage += "-> Please Enter a Valid Date of Birth \n";
            }
            if (dtpJoiningDate.Value < dtpDob.Value)
            {
                errorOccurred = true;
                errorMessage += "-> Please Enter a Valid Joining Date \n";
            }

            if (cmbDesignation.Text.Trim().ToString().Equals("Teacher"))
            {
                if (checkedListBox_subjects.CheckedItems.Count < 1)
                {
                    errorOccurred = true;
                    errorMessage += "-> Please Select Atleast 1 Subject from the List \n";
                }
            }

            if (errorOccurred)
            {
                MessageBox.Show(errorMessage, "Error");
            }

            return errorOccurred;
        }

        private void addCheckedItems(tblSubjectEmployeeMapping subjectEmployee)
        {

            foreach (object itemChecked in checkedListBox_subjects.CheckedItems)
            {

                try
                {
                    tblSubjectMaster castedItem = itemChecked as tblSubjectMaster;
                    //string comapnyName = castedItem.BatchName;
                    subjectEmployee.EmployeeId = EmployeeId;
                    subjectEmployee.SubjectId = Convert.ToInt32(castedItem.SubjectId); ;
                    subjectEmployee.isActvie = 1;
                    subjectEmployee.CreatedDate = DateTime.Today;
                    db.tblSubjectEmployeeMappings.Add(subjectEmployee);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    //success = false;
                }
            }
        } 
        private void linkLabel_editEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtFatherName.Enabled = true;        
            txtMotherName.Enabled = true;
            txtAddress1.Enabled = true;
            txtAddress2.Enabled = true;
            txtMobile.Enabled = true;
            txtResiContacts.Enabled = true;
            dtpDob.Enabled = true;
            txtEmail.Enabled = true;
            dtpJoiningDate.Enabled = true;
            cmbGender.Enabled = true;
            cmbCity.Enabled = true;
            cmbDesignation.Enabled = true;
            cmbQualification.Enabled = true;
            btnSubmit.Visible = true;
            btnBrowse.Visible = true;
        }

        private void linkLabel_deleteEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to delete the student?",
           "Important Query",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {
                tblEmployeeDetail empDetail = db.tblEmployeeDetails.Where(x => x.EmployeeId == EmployeeId && x.isActive == 1).Single();
                empDetail.isActive = 0;
                db.SaveChanges();

            }
        }

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedDesignation = (cmbDesignation.SelectedItem as tblBasicMaster).Value.ToString();
            if (selectedDesignation.Equals("Teacher"))
            {
                checkedListBox_subjects.Visible = true;
                lblSubjects.Visible = true;
            }
        }
    }
}
