using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeTau.Models;

namespace BanVeTau.DAL
{
    internal class LichTrinhDal
    {
        public static List<LichTrinh> LayTatCa(bool? lichTrinhMau)
        {
            using (var context = new VeTauEntities(false))
            {
                var result =
                    context.LichTrinhs.Where(i => lichTrinhMau == null || i.LichTrinhMau == lichTrinhMau).ToList();
                return result;

            }
        }

        public static List<LichTrinh> LayTatCa(string doanTauId, bool? lichTrinhMau)
        {
            using (var context = new VeTauEntities(false))
            {
                var result =
                    context.LichTrinhs.Where(
                        i => (lichTrinhMau == null || i.LichTrinhMau == lichTrinhMau) && doanTauId == i.DoanTauId)
                        .ToList();
                return result;

            }
        }
        public static List<LichTrinhModel> LayTatModel(string doanTauId,bool? chuaKetThuc)
        {
            var result = new List<LichTrinhModel>();
            List<LichTrinh> lichTrinhs;

            using (var context = new VeTauEntities(false))
            {
                lichTrinhs =
                    context.LichTrinhs.Where(
                        i =>
                            (i.LichTrinhMau == false) &&
                            (chuaKetThuc == null ||
                             (chuaKetThuc == true
                                 ? (i.TrangThai > -1 && i.GioDen > DateTime.Now)
                                 : (i.TrangThai == -1 || i.GioDen < DateTime.Now))) &&
                            doanTauId == i.DoanTauId)
                        .ToList();
            }

            foreach (var lichTrinh in lichTrinhs)
            {
                var ltmodel = new LichTrinhModel
                {
                    Id = lichTrinh.Id,
                    TenLichTrinh = lichTrinh.TenLichTrinh,
                    TrangThai = lichTrinh.TrangThai
                };

                var lichTrinhTuyenDuongs = LichTrinhTuyenDuongDal.LayTatCa(lichTrinh.Id);

                if (lichTrinhTuyenDuongs.Count != 0)
                {
                    var tuyenDuongDau = TuyenDuongDal.LayTuyenDuong(lichTrinhTuyenDuongs.First().TuyenDuongId);
                    var gaDau = GaTauDal.LayPGaTau(tuyenDuongDau.GaTauDauId);
                    ltmodel.TenGaDau = gaDau.Ten;
                }
                else
                {
                    ltmodel.TenGaDau = "Chưa tạo LT";
                }

                var tuyenDuongChuaChay = lichTrinhTuyenDuongs.FirstOrDefault(i => i.DaChayQua==false);
                var tuyenDuongDaChay = lichTrinhTuyenDuongs.FirstOrDefault(i => i.DaChayQua);

                if (tuyenDuongChuaChay == null)
                {
                    CapNhatTrangThai(lichTrinh.Id, -1);
                    ltmodel.TrangThai = -1;
                    ltmodel.LichTrinhTuyenDuongHienTaiId = 0;
                }
                else if (tuyenDuongDaChay == null)
                {
                    ltmodel.TrangThai = 1;
                    CapNhatTrangThai(lichTrinh.Id, 1);
                    ltmodel.LichTrinhTuyenDuongHienTaiId = 0;
                }
                else
                {
                    ltmodel.TrangThai = 0;
                    var tuyenDuong = TuyenDuongDal.LayTuyenDuong(tuyenDuongChuaChay.TuyenDuongId);
                    CapNhatTrangThai(lichTrinh.Id, 0);
                    ltmodel.LichTrinhTuyenDuongHienTaiId = tuyenDuong.GaTauDauId;
                }
               
               result.Add(ltmodel);
            }
            return result;
        }

        public static void CapNhatTrangThai(int id, int trangThai)
        {
            using (var context = new VeTauEntities(false))
            {
                var lichTrinh =  context.LichTrinhs.SingleOrDefault(gt => gt.Id == id);
                if (lichTrinh != null)
                    lichTrinh.TrangThai = trangThai;
                context.SaveChanges();
            }
            var tuyenDuongLichTrinhs = LichTrinhTuyenDuongDal.LayTatCa(id);

            if (trangThai != -1 && trangThai != 1)
                return;

            foreach (var tuyenDuong in tuyenDuongLichTrinhs)
            {
                LichTrinhTuyenDuongDal.CapNhatDaChayQua(tuyenDuong.Id, trangThai == -1);
            }
        }

        public static int Them(LichTrinh ojb)
        {
            using (var context = new VeTauEntities(false))
            {
                context.LichTrinhs.Add(ojb);
                context.SaveChanges();
                return ojb.Id;

            }
        }

        public static int Xoa(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                var lichTrinh = context.LichTrinhs.SingleOrDefault(gt => gt.Id == id);

                if (lichTrinh != null)
                {
                    context.LichTrinhs.Remove(lichTrinh);
                }

                return context.SaveChanges();
            }

        }

        public static LichTrinh Lay(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.LichTrinhs.SingleOrDefault(gt => gt.Id == id);
            }

        }

        public static int CapNhat(LichTrinh obj)
        {
            using (var context = new VeTauEntities(false))
            {
                var tarGetObject = context.LichTrinhs.SingleOrDefault(i => i.Id == obj.Id);

                if (tarGetObject != null)
                {
                    tarGetObject.LichTrinhMau = obj.LichTrinhMau;
                    tarGetObject.DoanTauId = obj.DoanTauId;
                    tarGetObject.GioDen = obj.GioDen;
                    tarGetObject.GioChay = obj.GioChay;
                    tarGetObject.TenLichTrinh = obj.TenLichTrinh;
                    tarGetObject.TrangThai = obj.TrangThai;
                }
                return context.SaveChanges();
            }
        }

        public static LichTrinh LayLichTrinhTrongNgay(int id, string doanTauId, DateTime gioChay)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                    context.LichTrinhs.Where(i => i.Id != id && i.DoanTauId == doanTauId && i.LichTrinhMau == false)
                        .FirstOrDefault(gt => gt.GioChay <= gioChay && gt.GioDen >= gioChay);
            }
        }

        public static List<LichTrinh> LayLichTrinhTheoDoanTau(string id, bool? lichTrinhMau)
        {
            using (var context = new VeTauEntities(false))
            {
                return
                    context.LichTrinhs.Where(
                        i => i.DoanTauId == id && (lichTrinhMau == null || i.LichTrinhMau == lichTrinhMau)).ToList();
            }
        }


        public static List<LichTrinh> LayLichTrinhTheoGaDenVaDi(int gaDiId, int gaDenId, DateTime ngayKhoiHanh)
        {
            using (var context = new VeTauEntities(false))
            {
                var listTuyenDuongGaDau = context.LichTrinh_TuyenDuong.Where(
                    lttd => !lttd.DaChayQua && lttd.TuyenDuong.GaTauDauId == gaDiId)
                    .Select(lttd => lttd.LichTrinhId)
                    .ToList();

                var listTuyenDuongGaCuoi = context.LichTrinh_TuyenDuong.Where(
                    lttd => !lttd.DaChayQua && lttd.TuyenDuong.GaTauCuoiId == gaDenId)
                    .Select(lttd => lttd.LichTrinhId)
                    .ToList();

                var listIdLichTrinh = listTuyenDuongGaDau.Intersect(listTuyenDuongGaCuoi).Distinct().ToList();

                return context.LichTrinhs.Where(
                    lt =>
                        lt.TrangThai > -1 && !lt.LichTrinhMau && lt.GioDen >= ngayKhoiHanh &&
                        listIdLichTrinh.Contains(lt.Id)).ToList();
            }
        }

    }
}
