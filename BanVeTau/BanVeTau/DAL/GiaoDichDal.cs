using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class GiaoDichDal
    {
        public static KhachHang LayKhachHang(int giaoDichId)
        {
            GiaoDich giaoDich;
            using (var context = new VeTauEntities(false))
            {
                giaoDich = context.GiaoDiches.SingleOrDefault(kh => kh.Id == giaoDichId);
            }
            if (giaoDich != null)
                return KhachHangDal.LayKhachHang(giaoDich.KhachHangId);

            return null;

        }

        public static GiaoDich LayGiaoDich(int giaoDichId)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.GiaoDiches.SingleOrDefault(kh => kh.Id == giaoDichId);
            }
        }

        public static int Them(GiaoDich giaoDich)
        {
            using (var context = new VeTauEntities(false))
            {
                context.GiaoDiches.Add(giaoDich);
                return context.SaveChanges();

            }
        }

        public static List<GiaoDich> LayGiaoDichTrenTuyenDuong(bool? huy, int loaiGheId, int soGhe, List<int> listTuyenDuong)
        {
            using (var context = new VeTauEntities(false))
            {
                var result =
                    context.ChiTietGiaoDiches.Where(
                        ct => (huy == null || ct.Huy == huy) &&
                              ct.LoaiGheId == loaiGheId && ct.SoGhe == soGhe &&
                              listTuyenDuong.Contains(ct.LichTrinhTuyenDuongId))
                        .Select(ct => ct.GiaoDich)
                        .Distinct()
                        .ToList();
                return result;

            }
        }

        public static List<GiaoDich> LayGiaoDichKhachHang(string khachHangId)
        {
            List<GiaoDich> giaoDichs;

            using (var context = new VeTauEntities(false))
            {
                giaoDichs = context.GiaoDiches.Where(gd =>gd.KhachHangId==khachHangId).Distinct().ToList();

            }

            foreach (var giaoDich in giaoDichs)
            {
                giaoDich.ChiTietGiaoDiches = ChiTietGiaoDichDal.LayChiTietGiaoDiches(giaoDich.Id);
            }

            return giaoDichs;
        }
    }
}
