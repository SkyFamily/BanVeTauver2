using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class LoaiGheDal
    {
        public static List<LoaiGhe> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                var result = context.LoaiGhes.ToList();
                return result;

            }
        }

        public static int ThemLoaiGhe(LoaiGhe loaiGhe)
        {
            using (var context = new VeTauEntities(false))
            {
                context.LoaiGhes.Add(loaiGhe);
                return context.SaveChanges();

            }
        }

        public static int XoaLoaiGhe(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                var loaiGhe = context.LoaiGhes.SingleOrDefault(gt => gt.Id == id);

                if (loaiGhe != null)
                {
                    context.LoaiGhes.Remove(loaiGhe);
                }

                return context.SaveChanges();
            }

        }

        public static LoaiGhe LayLoaiGhe(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.LoaiGhes.SingleOrDefault(gt => gt.Id == id);
            }

        }

        public static int CapNhatLoaiGhe(LoaiGhe loaiGhe)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.LoaiGhes.SingleOrDefault(i => i.Id == loaiGhe.Id);

                if (doiTuong != null)
                {
                    doiTuong.Ten = loaiGhe.Ten;
                    doiTuong.Anh = loaiGhe.Anh;
                    doiTuong.HeSo = loaiGhe.HeSo;
                }
                return context.SaveChanges();
            }
        }
    }
}
