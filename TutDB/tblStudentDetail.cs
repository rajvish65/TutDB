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
    
    public partial class tblStudentDetail
    {
        public tblStudentDetail()
        {
            this.tblStudentAllocations = new HashSet<tblStudentAllocation>();
        }
    
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<long> Sex { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<long> CityId { get; set; }
        public byte[] Dpic { get; set; }
        public Nullable<long> isActive { get; set; }
        public Nullable<System.DateTime> AdmitDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string FatherContacts { get; set; }
        public string MotherContacts { get; set; }
        public string ResiContacts { get; set; }
        public string Contacts { get; set; }
        public string Email { get; set; }
        public string StudentCode { get; set; }
        public string LastQualificatiion { get; set; }
        public string LastQualificationScore { get; set; }
    
        public virtual tblCityMaster tblCityMaster { get; set; }
        public virtual tblGenderMaster tblGenderMaster { get; set; }
        public virtual ICollection<tblStudentAllocation> tblStudentAllocations { get; set; }
    }
}