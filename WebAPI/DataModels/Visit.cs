//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visit()
        {
            this.Guest = new HashSet<Guest>();
        }
    
        public int ID { get; set; }
        public System.DateTime VisitRegDateTime { get; set; }
        public bool IsOver { get; set; }
        public System.DateTime VisitEndDateTime { get; set; }
        public long ResidentPersonalCode { get; set; }
        public long GuardPersonalCode { get; set; }
        public int DormitoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Guest> Guest { get; set; }
        public virtual Resident Resident { get; set; }
        public virtual Guard Guard { get; set; }
        public virtual Dormitory Dormitory { get; set; }
    }
}
