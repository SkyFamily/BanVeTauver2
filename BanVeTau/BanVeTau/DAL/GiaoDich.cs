//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanVeTau.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiaoDich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoDich()
        {
            this.ChiTietGiaoDiches = new HashSet<ChiTietGiaoDich>();
        }
    
        public int Id { get; set; }
        public string KhachHangId { get; set; }
        public int LichTrinhId { get; set; }
        public bool ThanhToan { get; set; }
        public double HeSo { get; set; }
        public string NhanVienId { get; set; }
        public double SoTien { get; set; }
        public string GhiChu { get; set; }
        public System.DateTime NgayLap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietGiaoDich> ChiTietGiaoDiches { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
