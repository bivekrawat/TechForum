//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TF.DBO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Owner
    {
        public int ID { get; set; }
        public int ThreadID { get; set; }
        public string Owner1 { get; set; }
        public string UserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ThreadMaster ThreadMaster { get; set; }
    }
}
