using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeTau.Models;

namespace BanVeTau.DAL
{
    public class BaoCaoDal
    {
        public static List<RPGiaoDich> LayGiaoDichNhanVien()
        {
            using (var context = new VeTauEntities(true))
            {
                var result = new List<RPGiaoDich>();
                var nhanViens = context.NhanViens.Where(nv=>nv.PhongBan.RuletBanVe);
                foreach (var nhanVien in nhanViens)
                {
                    var giaoDich = new RPGiaoDich();
                    giaoDich.TenNhanVien = nhanVien.TenNhanVien;
                    giaoDich.SoGiaoDichBiHuy = nhanVien.GiaoDiches.Count(gd => gd.ChiTietGiaoDiches.All(ct => ct.Huy == true));
                    giaoDich.SoGiaoDichThanhCong = nhanVien.GiaoDiches.Count(gd => gd.ChiTietGiaoDiches.All(ct => ct.Huy == false));
                    result.Add(giaoDich);
                }
                return result;

            }
        }
    }
}
