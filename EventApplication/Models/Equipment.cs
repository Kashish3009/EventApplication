//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentFilename { get; set; }
        public string EquipmentFilePath { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<System.DateTime> Createdate { get; set; }
        public Nullable<int> EquipmentCost { get; set; }
    }
}
