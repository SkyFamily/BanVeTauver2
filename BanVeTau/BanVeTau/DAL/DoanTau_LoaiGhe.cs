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
    
    public partial class DoanTau_LoaiGhe
    {
        public string DoanTauId { get; set; }
        public int LoaiGheId { get; set; }
        public int SoLuong { get; set; }
    
        public virtual DoanTau DoanTau { get; set; }
        public virtual LoaiGhe LoaiGhe { get; set; }
    }
}
