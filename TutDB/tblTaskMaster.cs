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
    
    public partial class tblTaskMaster
    {
        private long p1;
        private string p2;

        public tblTaskMaster()
        {
            this.tblSessionActivities = new HashSet<tblSessionActivity>();
        }

        public tblTaskMaster(long p1, string p2)
        {
            // TODO: Complete member initialization
            this.TaskId = p1;
            this.TaskName = p2;
        }
    
        public long TaskId { get; set; }
        public string TaskCode { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public Nullable<long> isActive { get; set; }
        public Nullable<long> TaskAgainstId { get; set; }
        public Nullable<int> EstimatedTime { get; set; }
        public Nullable<int> ActualTime { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<tblSessionActivity> tblSessionActivities { get; set; }
        public virtual tblSubjectMaster tblSubjectMaster { get; set; }
    }
}
