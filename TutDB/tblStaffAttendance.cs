//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TutDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblStaffAttendance
    {
        public long StaffAttendanceId { get; set; }
        public Nullable<long> EmployeeId { get; set; }
        public Nullable<long> SessionActivityId { get; set; }
        public Nullable<System.DateTime> EnteredDate { get; set; }
        public Nullable<System.DateTime> AttendanceDate { get; set; }
        public Nullable<int> isPresent { get; set; }
        public string LeaveReason { get; set; }
        public Nullable<int> Reviewed { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual tblEmployeeDetail tblEmployeeDetail { get; set; }
        public virtual tblSessionActivity tblSessionActivity { get; set; }
    }
}
