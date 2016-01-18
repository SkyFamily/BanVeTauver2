using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeTau.DAL;

namespace BanVeTau.Models
{
    public class LichTrinhTuyenDuongModelcs
    {
        public int Id { get; set; }
        public int LichTrinhId { get; set; }
        public int TuyenDuongId { get; set; }
        public int ThuTu { get; set; }
        public TimeSpan ThoiGianDung { get; set; }
        public double GiaVe { get; set; }
        public bool DaChayQua { get; set; }
        public int GaTauDauId { get; set; }
        public int GaTauCuoiId { get; set; }
        public GaTau GaTauDau { get; set; }
        public GaTau GaTauCuoi { get; set; }
        public int KhoangCach { get; set; }
        public TuyenDuong TuyenDuong { get; set; }


    }
}
