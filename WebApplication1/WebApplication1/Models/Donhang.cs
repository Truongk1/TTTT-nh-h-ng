//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donhang()
        {
            this.Chitietdonhangs = new HashSet<Chitietdonhang>();
            this.Chitiethanhtoans = new HashSet<Chitiethanhtoan>();
        }
    
        public string Mã_ĐH { get; set; }
        public string Email { get; set; }
        public int Mã_TT { get; set; }
        public string Địa_chỉ_người_nhận { get; set; }
        public string SĐT { get; set; }
        public int Tổng_tiền { get; set; }
        public System.DateTime Ngày_giao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitiethanhtoan> Chitiethanhtoans { get; set; }
        public virtual Khachhang Khachhang { get; set; }
        public virtual Trangthaidonhang Trangthaidonhang { get; set; }
    }
}
