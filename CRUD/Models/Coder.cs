//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coder
    {
        public int id { get; set; }
        public string batch_name { get; set; }
        public string patient_name { get; set; }
        public Nullable<int> pagennumber { get; set; }
        public Nullable<System.DateTime> DOS { get; set; }
        public string CPT { get; set; }
        public string modifier { get; set; }
        public string ICD_10 { get; set; }
        public string comments { get; set; }
        public string coder1 { get; set; }
    }
}
