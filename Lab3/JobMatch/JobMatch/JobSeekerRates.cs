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
    
    public partial class JobSeekerRates
    {
        public int JobSeeker_Id { get; set; }
        public int Job_Id { get; set; }
        public bool Rate { get; set; }
    
        public virtual Job Job { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
