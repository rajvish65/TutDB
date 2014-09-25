using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
//using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;


namespace TutDB
{
    class CommonUtilities
    {
        static TutDBEntities db;

        public static TutDBEntities getConnection()
        {
            if (db == null)
                db = new TutDBEntities();

            return db;
        }
        
        public static void loadBatchCombo(ComboBox comboBoxObj,int courseId)
        {
           

            var batchList = (from c in db.tblCourseMasters
                         join bc in db.tblBatchCourses on c.CourseId equals bc.CourseId
                         join b in db.tblBatchMasters on bc.BatchId equals b.BatchId
                         where c.CourseId.Equals(courseId) && c.isActive==1 && b.isActive==1 && bc.isActive==1
                         orderby b.BatchName
                         select new
                         {
                             b.BatchId,
                             b.BatchName,
                             b.BatchCode,
                             b.isActive,
                             b.CreatedDate,
                             b.UpdatedDate
                            
                         }).ToList();

            List<tblBatchMaster> item = new List<tblBatchMaster>();
            tblBatchMaster batchObj = new tblBatchMaster();
            batchObj.BatchName = "Select";
            item.Add(batchObj);  
            item.AddRange(batchList.Select(t => new tblBatchMaster(t.BatchId, t.BatchName)).ToList()) ;
            

            comboBoxObj.DataSource = item;// batchList;
            comboBoxObj.DisplayMember = "BatchName";
            comboBoxObj.ValueMember = "BatchId"; 
        }


        public static void loadCourseFees(TextBox txtBoxObj, int courseId)
        {
            //var fees=db.tblFeesMasters.Where(x => x.CourseId.Equals(courseId));//.Select(x=>x.Amount).Single();

            var q = from info in db.tblFeesMasters
                    where info.CourseId == courseId
                    select info.Amount;
            String fees=q.SingleOrDefault().ToString();
            
            txtBoxObj.Text = fees.Substring(0, fees.Length - 2);
            txtBoxObj.ReadOnly=true;
          
         }

        public static void populateCourse(ComboBox comboBoxObj)
        {
            List<tblCourseMaster> courseList = new List<tblCourseMaster>();
            tblCourseMaster courseObj = new tblCourseMaster();
            courseObj.CourseId = 0;
            courseObj.CourseName = "Select";
            courseList.Add(courseObj);
            //courseList.Add(new tblCourseMaster());
            courseList.AddRange(db.tblCourseMasters.OrderBy(x => x.CourseName).ToList());

            comboBoxObj.DataSource = courseList;
           // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "CourseName";
            comboBoxObj.ValueMember = "CourseId";
        }

        public static void populateBatch(ComboBox comboBoxObj)
        {
            List<tblBatchMaster> batchList = new List<tblBatchMaster>();
            tblBatchMaster batchObj = new tblBatchMaster();
            batchObj.BatchId = 0;
            batchObj.BatchName = "Select";
            batchList.Add(batchObj);

            List<tblBatchMaster> masters = new List<tblBatchMaster>();
            masters = db.tblBatchMasters.ToList();

            //courseList.Add(new tblCourseMaster());
            batchList.AddRange(masters);

            comboBoxObj.DataSource = batchList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "BatchName";
            comboBoxObj.ValueMember = "BatchId";
        }


        public static void populateGenders(ComboBox comboBoxObj)
        {
            List<tblGenderMaster> genderList = new List<tblGenderMaster>();
            tblGenderMaster genderObj = new tblGenderMaster();
            genderObj.GenderId = 0;
            genderObj.Description = "Select";
            genderList.Add(genderObj);
            //genderList.Add(new tblGenderMaster());
            genderList.AddRange(db.tblGenderMasters.OrderBy(x => x.Description).ToList());

            comboBoxObj.DataSource = genderList;
           // comboBoxObj.DataSource = db.tblGenderMasters.ToList();
            comboBoxObj.DisplayMember = "Description";
            comboBoxObj.ValueMember = "GenderId";
        }

        public static void populateCity(ComboBox comboBoxObj)
        {
            List<tblCityMaster> cityList = new List<tblCityMaster>();
            tblCityMaster cityObj = new tblCityMaster();
            cityObj.CityId = 0;
            cityObj.CityName = "Select";
            cityList.Add(cityObj);
            //cityList.Add(new tblCityMaster());
            cityList.AddRange(db.tblCityMasters.OrderBy(x => x.CityName).ToList());

            comboBoxObj.DataSource = cityList;// db.tblCityMasters.ToList();

            comboBoxObj.DisplayMember = "CityName";
            comboBoxObj.ValueMember = "CityId";
        }

        public static void populateLocation(ComboBox comboBoxObj)
        {
            List<tblLocationMaster> locationList = new List<tblLocationMaster>();
            tblLocationMaster locationObj = new tblLocationMaster();
            locationObj.LocationId = 0;
            locationObj.LocationName = "Select";
            locationList.Add(locationObj);
      
            locationList.AddRange(db.tblLocationMasters.OrderBy(x => x.LocationName).ToList());

            comboBoxObj.DataSource = locationList;

            comboBoxObj.DisplayMember = "LocationName";
            comboBoxObj.ValueMember = "LocationId";
        }


        //public static void populatePaymentMethod(ComboBox comboBoxObj)
        //{
        //    List<String> paymentMethod = new List<String>();
        //    paymentMethod.Add("Cash");
        //    paymentMethod.Add("Cheque");
        //    paymentMethod.Add("Others");

        //    comboBoxObj.DataSource = paymentMethod;
        //}

        public static void populateBatchListBox(ListBox listBoxObj)
        {
            List<tblBatchMaster> batchList = new List<tblBatchMaster>();
       
            batchList.AddRange(db.tblBatchMasters.OrderBy(x => x.BatchName).ToList());

            listBoxObj.DataSource = batchList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            listBoxObj.DisplayMember = "BatchName";
            listBoxObj.ValueMember = "BatchId";
        }

        public static void populateChkListBatch(CheckedListBox chkObj)
        {
            List<tblBatchMaster> batchList = new List<tblBatchMaster>();

            batchList.AddRange(db.tblBatchMasters.OrderBy(x => x.BatchName).ToList());

            chkObj.DataSource = batchList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            chkObj.DisplayMember = "BatchName";
            chkObj.ValueMember = "BatchId";
        }

        public static void populateChkListSubject(CheckedListBox chkObj)
        {
            List<tblSubjectMaster> subjectList = new List<tblSubjectMaster>();

            subjectList.AddRange(db.tblSubjectMasters.OrderBy(x => x.SubjectName).ToList());

            chkObj.DataSource = subjectList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            chkObj.DisplayMember = "SubjectName";
            chkObj.ValueMember = "SubjectId";
        }

        public static void calculateTaxes(int amount, TextBox txtServiceTaxObj, TextBox txtOtherTaxObj,TextBox txtTuitionObj)
        {
            float serviceTax = 0;
            float otherTax = 0;
            float tuitionFee = 0;
            int serviceTaxValue=Convert.ToInt32(db.tblBasicMasters.Where(x=>x.Description.Equals("ServiceTax")).Single().Value.ToString());
            int otherTaxValue = Convert.ToInt32(db.tblBasicMasters.Where(x => x.Description.Equals("OtherTax")).Single().Value.ToString());
           
            
            serviceTax = (serviceTaxValue * amount) / 100;
            otherTax = (otherTaxValue * amount) / 100;
            tuitionFee = amount - (serviceTax + otherTax);

            txtServiceTaxObj.Text = String.Format("{0:#,##0.00}", serviceTax);
            txtOtherTaxObj.Text = String.Format("{0:#,##0.00}", otherTax);
            txtTuitionObj.Text = String.Format("{0:#,##0.00}", tuitionFee);


        }

        public static void populatePaymentMethod(ComboBox comboBoxObj)
        {
            List<tblBasicMaster> paymentMethodList = new List<tblBasicMaster>();
            tblBasicMaster paymentObj = new tblBasicMaster();
            paymentObj.Value = "Select";
            paymentMethodList.Add(paymentObj);
            paymentMethodList.AddRange(db.tblBasicMasters.Where(x=>x.Description.Equals("PaymentMethod")).OrderBy(x => x.Value).ToList());

            comboBoxObj.DataSource = paymentMethodList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "Value";
        }

        public static void populateDesignation(ComboBox comboBoxObj)
        {
            List<tblBasicMaster> designationList = new List<tblBasicMaster>();
            tblBasicMaster designationObj = new tblBasicMaster();
            designationObj.Value = "Select";
            designationList.Add(designationObj);
            designationList.AddRange(db.tblBasicMasters.Where(x => x.Description.Equals("Designation")).OrderBy(x => x.Value).ToList());

            comboBoxObj.DataSource = designationList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "Value";
        }

        public static void populateOccurances(ComboBox comboBoxObj)
        {
            List<tblBasicMaster> occurancesList = new List<tblBasicMaster>();
            tblBasicMaster occurancesObj = new tblBasicMaster();
            occurancesObj.Value = "Select";
            occurancesList.Add(occurancesObj);
            occurancesList.AddRange(db.tblBasicMasters.Where(x => x.Description.Equals("Occurances")).OrderBy(x => x.Value).ToList());

            comboBoxObj.DataSource = occurancesList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "Value";
        }


        public static void populateSessionOwner(ComboBox comboBoxObj)
        {
            List<tblEmployeeDetail> employeeList = new List<tblEmployeeDetail>();
            tblEmployeeDetail employeeObj = new tblEmployeeDetail();
            employeeObj.FirstName = "Select";
            employeeList.Add(employeeObj);
            employeeList.AddRange(db.tblEmployeeDetails.Where(x => x.Designation.Equals("Teacher")).OrderBy(x => x.FirstName).ToList());

            comboBoxObj.DataSource = employeeList;
            comboBoxObj.DisplayMember = "FirstName";
            comboBoxObj.ValueMember = "EmployeeId";
        }

        public static void populateHours(ComboBox comboBoxObj)
        {
            List<String> hoursList = new List<String>();
            hoursList.Add("Select");
            for(int hours=0; hours <= 24; hours ++)
            {
                if (hours.ToString().Length == 1)
                {
                    hoursList.Add("0" + hours.ToString());
                }
                else
                hoursList.Add(hours.ToString());
            }
            comboBoxObj.DataSource = hoursList;
            comboBoxObj.DisplayMember = "Value";
        }

        public static void populateMinutes(ComboBox comboBoxObj)
        {
            List<String> minutesList = new List<String>();
            minutesList.Add("Select");
            for (int minutes = 0; minutes <= 45; minutes+=15)
            {
                if (minutes.ToString().Length == 1)
                {
                    minutesList.Add("0" + minutes.ToString());
                }
                else
                minutesList.Add(minutes.ToString());
            }
            comboBoxObj.DataSource = minutesList;
            comboBoxObj.DisplayMember = "Value";
        }

        public static void populateLeaveReason(ComboBox comboBoxObj)
        {
            List<tblBasicMaster> leaveReasonList = new List<tblBasicMaster>();
            tblBasicMaster leaveReasonObj = new tblBasicMaster();
            leaveReasonObj.Value = "Select";
            leaveReasonList.Add(leaveReasonObj);
            leaveReasonList.AddRange(db.tblBasicMasters.Where(x => x.Description.Equals("LeaveReason")).OrderBy(x => x.Value).ToList());

            comboBoxObj.DataSource = leaveReasonList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "Value";
        }

        public static void populateSubjectOnSelectCourse(ComboBox comboBoxObj, int courseId)
        {
            var subjectList = (from c in db.tblCourseMasters
                             join cs in db.tblCourseSubjectMappings on c.CourseId equals cs.CourseId
                             join s in db.tblSubjectMasters on cs.SubjectId equals s.SubjectId
                             where c.CourseId.Equals(courseId) && c.isActive == 1 && cs.isActive == 1 && s.isActive == 1
                             orderby s.SubjectName
                             select new
                             {
                                 s.SubjectId,
                                 s.SubjectName,
                                 s.isActive,
                                 s.CreatedDate,
                                 s.UpdatedDate
                             }).ToList();

            List<tblSubjectMaster> item = new List<tblSubjectMaster>();
            tblSubjectMaster subjectObj = new tblSubjectMaster();
            subjectObj.SubjectName = "Select";
            item.Add(subjectObj);
            item.AddRange(subjectList.Select(t => new tblSubjectMaster(t.SubjectId, t.SubjectName)).ToList());

            comboBoxObj.DataSource = item;// batchList;
            comboBoxObj.DisplayMember = "SubjectName";
            comboBoxObj.ValueMember = "SubjectId"; 
        }

        public static void populateEmployeeOnSelectSubject(ComboBox comboBoxObj, int subjectId)
        {
            var employeeList = (from s in db.tblSubjectMasters
                            join se in db.tblSubjectEmployeeMappings on s.SubjectId equals se.SubjectId
                            join e in db.tblEmployeeDetails on se.EmployeeId equals e.EmployeeId
                            join sm in db.tblSessionMasters on e.EmployeeId equals sm.SessionOwnerId
                            where s.SubjectId.Equals(subjectId) && s.isActive == 1 && se.isActvie == 1 && e.isActive == 1 && sm.isActive==1 && e.Designation == "Teacher"
                            orderby e.FirstName,e.LastName
                            select new
                            {
                                 e.EmployeeId,
                                 sm.SessionId,
                                 e.FirstName,
                                 e.LastName,
                                 e.isActive,
                                 e.CreatedDate,
                                 e.UpdatedDate,
                                 sm.SessionTime
                             }).ToList();

            List<tblEmployeeDetail> item = new List<tblEmployeeDetail>();
            tblEmployeeDetail employeeObj = new tblEmployeeDetail();
            employeeObj.FirstName = "Select";
            item.Add(employeeObj);
            item.AddRange(employeeList.Select(t => new tblEmployeeDetail(t.SessionId, (t.FirstName + " " + t.LastName).ToString()+"("+t.SessionTime+")")).ToList());
            //Instead of employeeID we are passing SessionId
            comboBoxObj.DataSource = item;// batchList;
            comboBoxObj.DisplayMember = "FirstName";
            comboBoxObj.ValueMember = "EmployeeId";
        }

        public static void populateRoom(ComboBox comboBoxObj)
        {
            List<tblRoomMaster> roomList = new List<tblRoomMaster>();
            tblRoomMaster roomObj = new tblRoomMaster();
            roomObj.RoomId = 0;
            roomObj.RoomName = "Select";
            roomList.Add(roomObj);
            //courseList.Add(new tblCourseMaster());
            roomList.AddRange(db.tblRoomMasters.OrderBy(x => x.RoomName).ToList());

            comboBoxObj.DataSource = roomList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "RoomName";
            comboBoxObj.ValueMember = "RoomId";
        }

        public static void populateTask(ComboBox comboBoxObj)
        {
            List<tblTaskMaster> taskList = new List<tblTaskMaster>();
            tblTaskMaster taskObj = new tblTaskMaster();
            taskObj.TaskId = 0;
            taskObj.TaskName = "Select";
            taskList.Add(taskObj);
            //courseList.Add(new tblCourseMaster());
            taskList.AddRange(db.tblTaskMasters.OrderBy(x => x.TaskName).ToList());

            comboBoxObj.DataSource = taskList;
            // comboBoxObj.DataSource = db.tblCourseMasters.ToList();
            comboBoxObj.DisplayMember = "TaskName";
            comboBoxObj.ValueMember = "TaskId";
        }

        public static void populateRoomOnSelectLocation(ComboBox comboBoxObj, int locationId)
        {
            var roomList = (from l in db.tblLocationMasters
                                join lr in db.tblLocationRoomMappings on l.LocationId equals lr.LocationId
                                join r in db.tblRoomMasters on lr.RoomId equals r.RoomId
                                where l.LocationId.Equals(locationId) && l.isActive == 1 && lr.isActive == 1 && r.isActive == 1
                                orderby r.RoomName
                                select new
                                {
                                    r.RoomId,
                                    r.RoomName,
                                    r.isActive,
                                    r.CreatedDate,
                                }).ToList();

            List<tblRoomMaster> item = new List<tblRoomMaster>();
            tblRoomMaster roomObj = new tblRoomMaster();
            roomObj.RoomName = "Select";
            item.Add(roomObj);
            item.AddRange(roomList.Select(t => new tblRoomMaster(t.RoomId, t.RoomName)).ToList());
            //Instead of employeeID we are passing SessionId
            comboBoxObj.DataSource = item;// batchList;
            comboBoxObj.DisplayMember = "RoomName";
            comboBoxObj.ValueMember = "RoomId";
        }


        public static void populateTaskOnSelectSubject(ComboBox comboBoxObj, int subjectId)
        {
            var taskList = (from s in db.tblSubjectMasters
                            join t in db.tblTaskMasters on s.SubjectId equals t.TaskAgainstId
                            where s.SubjectId.Equals(subjectId) && s.isActive == 1 && t.isActive == 1
                            orderby t.TaskName
                            select new
                            {
                                t.TaskId,
                                t.TaskName,
                                t.isActive,
                                t.CreatedDate,
                                t.UpdatedDate
                            }).ToList();

            List<tblTaskMaster> item = new List<tblTaskMaster>();
            tblTaskMaster taskObj = new tblTaskMaster();
            taskObj.TaskName = "Select";
            item.Add(taskObj);
            item.AddRange(taskList.Select(t => new tblTaskMaster(t.TaskId, t.TaskName)).ToList());

            comboBoxObj.DataSource = item;// batchList;
            comboBoxObj.DisplayMember = "TaskName";
            comboBoxObj.ValueMember = "TaskId";
        }



        
    }
}
