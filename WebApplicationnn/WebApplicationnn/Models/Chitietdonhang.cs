//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationnn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chitietdonhang
    {
        public int Mã_CTĐH { get; set; }
        public string Mã_ĐH { get; set; }
        public string Mã_SP { get; set; }
        public int Số_lượng { get; set; }
    
        public virtual Donhang Donhang { get; set; }
        public virtual Sanpham Sanpham { get; set; }
    }
}