using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BanVeTau.DAL
{
    public class NhanVienDal
    {
        public static NhanVien LayNhanVien(string id, string matKhau)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.NhanViens.SingleOrDefault(nv => nv.Id == id && nv.MatKhau == matKhau);
            }
        }

        public static NhanVien LayNhanVien(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.NhanViens.SingleOrDefault(nv => nv.Id == id);
            }
        }

        public static bool KiemTraTonTaiId(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.NhanViens.SingleOrDefault(nv => nv.Id == id.ToUpper()) != null;
            }
        }

        public static bool TaoNhanVien(NhanVien nhanVienMoi)
        {
            using (var context = new VeTauEntities(false))
            {
                context.NhanViens.Add(nhanVienMoi);
                return context.SaveChanges()>0;
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
                while ((result+i).Length < chieuDai)
                {
                    result = result.Insert(tienTo.Length, "0");
                }
            } while (KiemTraTonTaiId(result+i));

            return result+i;
        }

        public static List<NhanVien> LayTatCa(string phongBanId)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                    context.NhanViens.Where(nv => phongBanId==string.Empty || nv.PhongBanID == phongBanId).ToList();
            }
        }

        public static List<NhanVien> LayDanhSachNhanVien(string phongBanId)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.NhanViens.Where(nv => nv.PhongBanID == phongBanId).ToList();
            }
        }

        public static List<NhanVien> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                return context.NhanViens.ToList();
            }
        }

        public static int CapNhat(NhanVien doiTuong)
        {
            using (var context = new VeTauEntities(false))
            {
                var nhanVien = context.NhanViens.SingleOrDefault(i => i.Id == doiTuong.Id);

                if (nhanVien != null)
                {
                    nhanVien.TenNhanVien = doiTuong.TenNhanVien;
                    nhanVien.NgaySinh = doiTuong.NgaySinh;
                    nhanVien.NgayVaoLam = doiTuong.NgayVaoLam;
                    nhanVien.PhongBanID = doiTuong.PhongBanID;
                    nhanVien.MatKhau = doiTuong.MatKhau;
                    nhanVien.GioiTinh = doiTuong.GioiTinh;
                }
                return context.SaveChanges();
            }
        }
        public static int Xoa(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.NhanViens.SingleOrDefault(nv => nv.Id == id);

                if (doiTuong != null)
                {
                    context.NhanViens.Remove(doiTuong);
                }

                return context.SaveChanges();
            }
        }
    }
}