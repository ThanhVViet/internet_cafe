//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Net4.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class worktime
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public Nullable<System.DateTime> daywork { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<int> salary { get; set; }
        public byte[] image_nv { get; set; }
    }
}
