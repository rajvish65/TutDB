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
    
    public partial class tblSubjectMaster
    {
        private long p1;
        private string p2;

        public tblSubjectMaster()
        {
            this.tblCourseSubjectMappings = new HashSet<tblCourseSubjectMapping>();
            this.tblSubjectEmployeeMappings = new HashSet<tblSubjectEmployeeMapping>();
            this.tblTaskMasters = new HashSet<tblTaskMaster>();
        }

        public tblSubjectMaster(long p1, string p2)
        {
            // TODO: Complete member initialization
            this.SubjectId = p1;
            this.SubjectName = p2;
        }
    
        public long SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
        public Nullable<long> isActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<tblCourseSubjectMapping> tblCourseSubjectMappings { get; set; }
        public virtual ICollection<tblSubjectEmployeeMapping> tblSubjectEmployeeMappings { get; set; }
        public virtual ICollection<tblTaskMaster> tblTaskMasters { get; set; }
    }
}
