using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.Models
{
    public class LichTrinhModel
    {
        public int Id { get; set; }
        public string TenLichTrinh { get; set; }
        public int TrangThai { get; set; }
        public int LichTrinhTuyenDuongHienTaiId { get; set; }
        public string TenGaDau { get; set; }
    }
}
