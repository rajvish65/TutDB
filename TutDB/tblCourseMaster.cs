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
    
    public partial class tblCourseMaster
    {
        public tblCourseMaster()
        {
            this.tblBatchCourses = new HashSet<tblBatchCourse>();
            this.tblCourseSubjectMappings = new HashSet<tblCourseSubjectMapping>();
            this.tblFeesMasters = new HashSet<tblFeesMaster>();
            this.tblSessionActivities = new HashSet<tblSessionActivity>();
            this.tblStudentAllocations = new HashSet<tblStudentAllocation>();
        }
    
        public long CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public Nullable<long> isActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<tblBatchCourse> tblBatchCourses { get; set; }
        public virtual ICollection<tblCourseSubjectMapping> tblCourseSubjectMappings { get; set; }
        public virtual ICollection<tblFeesMaster> tblFeesMasters { get; set; }
        public virtual ICollection<tblSessionActivity> tblSessionActivities { get; set; }
        public virtual ICollection<tblStudentAllocation> tblStudentAllocations { get; set; }
    }
}
