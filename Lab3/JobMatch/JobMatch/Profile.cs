//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobMatch
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile()
        {
            this.EmployerRates = new HashSet<EmployerRates>();
            this.Skill = new HashSet<Skill>();
        }
    
        public int JobSeeker_Id { get; set; }
        public string Education { get; set; }
        public string ShortDescription { get; set; }
        public string ContactData { get; set; }
        public string WorkExperience { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployerRates> EmployerRates { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skill> Skill { get; set; }
    }
}
