using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.Models
{
    public class GheModel
    {
        public int LoaiGheId { get; set; }
        public string Ten { get; set; }
        public Image Anh { get; set; }
        public int GiaoDichId { get; set; }
        public string GhiChu { get; set; }
        public int LichTrinhTuyenDuongId { get; set; }
        public int LichTrinhId { get; set; }
        public int SoShe { get; set; }
        public string TenKhachHang { get; set; }
        public string MaGhe { get; set; }
        public double SoTien { get; set; }
        public bool DaDuocDat { get; set; }
        public bool CoTheDat { get; set; }
        public double HeSo { get; set; }
        public bool HuyGhe { get; set; }
        public string KhachHangId { get; set; }
        public string TenLichTrinh { get; set; }
    }
}
