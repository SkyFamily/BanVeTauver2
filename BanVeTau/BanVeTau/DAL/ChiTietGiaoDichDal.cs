using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class ChiTietGiaoDichDal
    {
        public static List<ChiTietGiaoDich> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                var result = context.ChiTietGiaoDiches.ToList();
                return result;

            }
        }

        public static int Them(ChiTietGiaoDich ghe)
        {
            using (var context = new VeTauEntities(false))
            {
                context.ChiTietGiaoDiches.Add(ghe);
                return context.SaveChanges();

            }
        }
    

        public static List<ChiTietGiaoDich> LayChiTietGiaoDiches(int loaiGheId, int soGhe, IEnumerable<int> listLichTrinhTuyenDuongId)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                   context.ChiTietGiaoDiches.Where(
                       gt =>
                           gt.LoaiGheId == loaiGheId && listLichTrinhTuyenDuongId.Contains(gt.LichTrinhTuyenDuongId) &&
                           gt.SoGhe == soGhe).ToList();
            }
        }

        public static ICollection<ChiTietGiaoDich> LayChiTietGiaoDiches(int giaoDichId)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                   context.ChiTietGiaoDiches.Where(ct=>ct.GiaoDichId==giaoDichId).ToList();
            }
        }

        public static List<ChiTietGiaoDich> LayChiTietGiaoDiches(int loaiGheId, int soGhe, int lichTrinhTuyenDuongId)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                    context.ChiTietGiaoDiches.Where(
                        gt =>
                            gt.LoaiGheId == loaiGheId && gt.LichTrinhTuyenDuongId == lichTrinhTuyenDuongId &&
                            gt.SoGhe == soGhe).ToList();
            }
        }
       
        public static int HuyChiTuyetGiaoDich(int giaoDichId, int loaiGheId, int soShe)
        {
            using (var context = new VeTauEntities(false))
            {
                var chiTiets = context.ChiTietGiaoDiches.Where(ct=>ct.GiaoDichId==giaoDichId && ct.LoaiGheId==loaiGheId && ct.SoGhe==soShe);
                foreach (var chiTiet in chiTiets)
                {
                    chiTiet.Huy = true;
                }
                return context.SaveChanges();
            }
        }
    }
}
