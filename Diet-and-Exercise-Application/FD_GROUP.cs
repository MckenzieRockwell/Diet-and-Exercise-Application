//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diet_and_Exercise_Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class FD_GROUP
    {
        public FD_GROUP()
        {
            this.FOOD_DES = new HashSet<FOOD_DES>();
        }
    
        public string FdGrp_CD { get; set; }
        public string FdGrp_Desc { get; set; }
    
        public virtual ICollection<FOOD_DES> FOOD_DES { get; set; }
    }
}
