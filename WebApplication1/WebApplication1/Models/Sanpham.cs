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
    
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            this.Chitietdonhangs = new HashSet<Chitietdonhang>();
            this.Chitietgiohangs = new HashSet<Chitietgiohang>();
        }
    
        public string Mã_SP { get; set; }
        public string Mã_loại_SP { get; set; }
        public string Tên_món_ăn { get; set; }
        public int Số_lượng { get; set; }
        public int Giá_tiền { get; set; }
        public string Mô_tả { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietgiohang> Chitietgiohangs { get; set; }
        public virtual Loaisanpham Loaisanpham { get; set; }
    }
}
