//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dependent
    {
        public int ESSN { get; set; }
        public string Dependent_name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> Bdate { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
