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
    
    public partial class tblStudentAllocation
    {
        public tblStudentAllocation()
        {
            this.tblFeesDetails = new HashSet<tblFeesDetail>();
            this.tblFeeStructures = new HashSet<tblFeeStructure>();
            this.tblStudentAttendances = new HashSet<tblStudentAttendance>();
        }
    
        public long AllocationId { get; set; }
        public Nullable<long> StudentId { get; set; }
        public Nullable<long> CourseId { get; set; }
        public Nullable<long> BatchId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> isActive { get; set; }
        public Nullable<int> isOver { get; set; }
        public string LastQualification { get; set; }
        public string LastQualificationScore { get; set; }
        public Nullable<System.DateTime> AdmitDate { get; set; }
        public Nullable<decimal> Fees { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> ActualFees { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual tblBatchMaster tblBatchMaster { get; set; }
        public virtual tblCourseMaster tblCourseMaster { get; set; }
        public virtual ICollection<tblFeesDetail> tblFeesDetails { get; set; }
        public virtual ICollection<tblFeeStructure> tblFeeStructures { get; set; }
        public virtual tblStudentDetail tblStudentDetail { get; set; }
        public virtual ICollection<tblStudentAttendance> tblStudentAttendances { get; set; }
    }
}