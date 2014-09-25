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
    public partial class CreateSession : Form
    {
        TutDBEntities db = CommonUtilities.getConnection();
        static Int32 SessionId;
        static bool hasComeFromEdit = false;

        public CreateSession()
        {
            InitializeComponent();
        }

        private void CreateSession_Load(object sender, EventArgs e)
        {
            CommonUtilities.populateSessionOwner(comboBox_sessionOwner);
            CommonUtilities.populateHours(comboBox_durationHours);
            CommonUtilities.populateMinutes(comboBox_durationMinutes);
            CommonUtilities.populateOccurances(comboBox_sessionOccurances);
        }

        private void fetchFormValues(tblSessionMaster sessionMaster)
        {
            if (hasComeFromEdit == true)
            {
                sessionMaster = db.tblSessionMasters.Where(x => x.SessionId == SessionId && x.isActive == 1).Single();
            }

            String selectedSessionOwner = (comboBox_sessionOwner.SelectedItem as tblEmployeeDetail).FirstName.ToString();
            int sessionOwnerId = Convert.ToInt32(db.tblEmployeeDetails.Where(x => x.FirstName.Equals(selectedSessionOwner)).First().EmployeeId);
            sessionMaster.SessionOwnerId = sessionOwnerId;

            sessionMaster.SessionDescription = richTextBox_sessionDescription.Text.ToString();

            String selectedSessionOccurances = (comboBox_sessionOccurances.SelectedItem as tblBasicMaster).Value.ToString();
            int sessionOccurancesId = Convert.ToInt32(db.tblBasicMasters.Where(x => x.Value.Equals(selectedSessionOccurances)).First().Id);
            sessionMaster.SessionOwnerId = sessionOccurancesId;

            String selectedHours = comboBox_durationHours.SelectedItem.ToString();
            String selectedMinutes = comboBox_durationMinutes.SelectedItem.ToString();
            int sessionDuration = (Int32.Parse(selectedHours) * 60) + Int32.Parse(selectedMinutes);
            sessionMaster.SessionTime = sessionDuration;

            sessionMaster.isActive = 1;
            sessionMaster.CreatedDate = DateTime.Now;
           
        }

        private void button_createSession_Click(object sender, EventArgs e)
        {
            //if (validate())
            //    return; //Validation fails.

            //Validation successful.

            //Create a new CustomerDetail object, fetch form-field-values and insert into the DB.
            tblSessionMaster sessionMaster = new tblSessionMaster();
            if (hasComeFromEdit == false)
            {
                int lastInsertedSessionCode = db.tblSessionMasters.Count();
                lastInsertedSessionCode = lastInsertedSessionCode + 1;
                sessionMaster.SessionCode = "SN" + lastInsertedSessionCode.ToString();
            }
            //customerDetail.CustomerId = lastInsertedCustomerId + 1; //New Customer's id.

            fetchFormValues(sessionMaster);

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
                        if (hasComeFromEdit == false)
                        {
                            db.tblSessionMasters.Add(sessionMaster);
                        }
                        //db.tblSessionMasters.Add(sessionMaster);
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

            if (!exceptionOccured && hasComeFromEdit == false)
            {
                MessageBox.Show("Session created successfully.", "Success");
            }
            else
                if (!exceptionOccured && hasComeFromEdit == true)
                {
                    MessageBox.Show("User updated successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Error");
                }
        }
    }
}
