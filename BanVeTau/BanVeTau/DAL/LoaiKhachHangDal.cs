using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class LoaiKhachHangDal
    {
        public static LoaiKhachHang Lay(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.LoaiKhachHangs.SingleOrDefault(kh=>kh.Id==id);
            }
        }

        public static List<LoaiKhachHang> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                return context.LoaiKhachHangs.ToList();
            }
        }

        public static int Them(LoaiKhachHang loaiKhachHang)
        {
            using (var context = new VeTauEntities(false))
            {
                context.LoaiKhachHangs.Add(loaiKhachHang);
                return context.SaveChanges();

            }
        }

        public static int CapNhat(LoaiKhachHang loaiKhachHang)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.LoaiKhachHangs.SingleOrDefault(i => i.Id == loaiKhachHang.Id);

                if (doiTuong != null)
                {
                    doiTuong.Ten = loaiKhachHang.Ten;
                    doiTuong.HeSo = loaiKhachHang.HeSo;
                }
                return context.SaveChanges();
            }
        }

        public static int Xoa(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.LoaiKhachHangs.SingleOrDefault(pb => pb.Id == id);

                if (doiTuong != null)
                {
                    context.LoaiKhachHangs.Remove(doiTuong);
                }

                return context.SaveChanges();
            }
        }
    }
}
