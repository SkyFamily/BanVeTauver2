using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    public class KhachHangDal
    {
        public static KhachHang LayKhachHang(string id, string matKhau)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.KhachHangs.SingleOrDefault(kh => kh.Id == id && kh.MatKhau==matKhau);
            }
        }
        public static KhachHang LayKhachHang(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.KhachHangs.SingleOrDefault(kh => kh.Id == id);
            }
        }
        public static List<KhachHang> LayTatCa(bool? ruleDangNhap)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.KhachHangs.Where(kh => ruleDangNhap==null|| kh.RuleDangNhap == ruleDangNhap).ToList();
            }
        }

        public static bool KiemTraTonTaiId(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.KhachHangs.SingleOrDefault(kh => kh.Id == id.ToLower()) != null;
            }
        }

        public static bool TaoKhachHang(KhachHang khachHangMoi)
        {
            using (var context = new VeTauEntities(false))
            {
                context.KhachHangs.Add(khachHangMoi);
                return context.SaveChanges() > 0;
            }
        }

        public static List<KhachHang> LayTatCa(int loaiKhachHangId)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                    context.KhachHangs.Where(kh => loaiKhachHangId == 0 || kh.LoaiKhachHangId == loaiKhachHangId)
                        .ToList();
            }
        }

        public static int CapNhat(KhachHang khachHang)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.KhachHangs.SingleOrDefault(i => i.Id == khachHang.Id);

                if (doiTuong != null)
                {
                    doiTuong.Id = khachHang.Id;
                    doiTuong.TenKhachHang = khachHang.TenKhachHang;
                    doiTuong.CMND = khachHang.CMND;
                    doiTuong.SoDienThoai = khachHang.SoDienThoai;
                    doiTuong.LoaiKhachHangId = khachHang.LoaiKhachHangId;
                    doiTuong.MatKhau = khachHang.MatKhau;
                    doiTuong.RuleDangNhap = khachHang.RuleDangNhap;
                }
                return context.SaveChanges();
            }
        }

        public static string LayIdTuDong(string tienTo, int chieuDai)
        {
            var i = 0;
            string result;
            do
            {
                i++;
                result = tienTo;
                while ((result + i).Length < chieuDai)
                {
                    result = result.Insert(tienTo.Length, "0");
                }
            } while (KiemTraTonTaiId(result + i));

            return result + i;
        }

        public static int Xoa(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.KhachHangs.SingleOrDefault(pb => pb.Id == id);

                if (doiTuong != null)
                {
                    context.KhachHangs.Remove(doiTuong);
                }

                return context.SaveChanges();
            }
        }

        public static List<KhachHang> Lay(List<string> listIdKhachHang)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.KhachHangs.Where(i => listIdKhachHang.Contains(i.Id)).ToList();
            }
        }
    }
}
