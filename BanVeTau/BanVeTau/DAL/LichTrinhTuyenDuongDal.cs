using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BanVeTau.Models;

namespace BanVeTau.DAL
{
    class LichTrinhTuyenDuongDal
    {
        public static LichTrinh_TuyenDuong LayLichTrinhTuyenDuong(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.LichTrinh_TuyenDuong.SingleOrDefault(i => i.Id == id);

            }
        }
        public static List<LichTrinh_TuyenDuong> LayTatCa(int? lichTrinhId)
        {
            using (var context = new VeTauEntities(false))
            {
                var result =
                    context.LichTrinh_TuyenDuong.Where(i => lichTrinhId == null || i.LichTrinhId == lichTrinhId)
                        .OrderBy(i => i.ThuTu)
                        .ToList();
                return result;

            }
        }

        public static List<LichTrinh_TuyenDuong> LayLichTrinhTuyenDuongTheoGhaoDich(int giaoDichId)
        {
            var listLichTrinhTuyenDuongIds =
                ChiTietGiaoDichDal.LayChiTietGiaoDiches(giaoDichId)
                    .Select(i => i.LichTrinhTuyenDuongId)
                    .Distinct()
                    .ToList();
            using (var context = new VeTauEntities(false))
            {
                return context.LichTrinh_TuyenDuong.Where(i => listLichTrinhTuyenDuongIds.Contains(i.Id)).ToList();
            }
        }

        public static LichTrinh LayLichTrinCuaGiaoDich(int giaoDichId)
        {
            var lichTrinhTuyenDuong = LayLichTrinhTuyenDuong(giaoDichId);

            if (lichTrinhTuyenDuong != null)
            {
                return LichTrinhDal.Lay(lichTrinhTuyenDuong.LichTrinhId);
            }

            return null;
        }

        public static List<LichTrinhTuyenDuongModelcs> LayLichTrinh(int lichTrinhId)
        {
            var results = LayTatCa(lichTrinhId).OrderBy(i => i.ThuTu).Select(i => new LichTrinhTuyenDuongModelcs
            {
                Id = i.Id,
                DaChayQua = i.DaChayQua,
                LichTrinhId = i.LichTrinhId,
                TuyenDuongId = i.TuyenDuongId,
                ThuTu = i.ThuTu,
                ThoiGianDung = new TimeSpan(0, (int)i.ThoiGianDung, 0),
                GiaVe = i.GiaVe,
            }).ToList();

            foreach (var r in results)
            {
                r.TuyenDuong = TuyenDuongDal.LayTuyenDuong(r.TuyenDuongId);
                r.GaTauDauId = r.TuyenDuong.GaTauDauId;
                r.GaTauCuoiId = r.TuyenDuong.GaTauCuoiId;
                r.GaTauDau = GaTauDal.LayPGaTau(r.GaTauDauId);
                r.GaTauCuoi = GaTauDal.LayPGaTau(r.GaTauCuoiId);
            }
            return results;
        }

        public static List<LichTrinhTuyenDuongModelcs> LayLichTrinhGiaoDich(int giaoDichId)
        {

            var results = LayLichTrinhTuyenDuongTheoGhaoDich(giaoDichId).OrderBy(i => i.ThuTu).Select(i => new LichTrinhTuyenDuongModelcs
            {
                Id = i.Id,
                DaChayQua = i.DaChayQua,
                LichTrinhId = i.LichTrinhId,
                TuyenDuongId = i.TuyenDuongId,
                ThuTu = i.ThuTu,
                ThoiGianDung = new TimeSpan(0, (int)i.ThoiGianDung, 0),
                GiaVe = i.GiaVe,
            }).ToList();

            foreach (var r in results)
            {
                r.TuyenDuong = TuyenDuongDal.LayTuyenDuong(r.TuyenDuongId);
                r.GaTauDauId = r.TuyenDuong.GaTauDauId;
                r.GaTauCuoiId = r.TuyenDuong.GaTauCuoiId;
                r.GaTauDau = GaTauDal.LayPGaTau(r.GaTauDauId);
                r.GaTauCuoi = GaTauDal.LayPGaTau(r.GaTauCuoiId);
            }
            return results;
        }

        public static bool CapNhatLichTrinhTuyenDuong(int lichTrinhId,List<LichTrinhTuyenDuongModelcs> listTuyenDuong)
        {
            using (var context = new VeTauEntities(false))
            using (var trans = new TransactionScope())
            {
                //Xoa cac lich trinh 
                var exceptList =
                    context.LichTrinh_TuyenDuong.Where(i => i.LichTrinhId == lichTrinhId)
                        .Select(i => i.TuyenDuongId)
                        .Except(listTuyenDuong.Select(j => j.TuyenDuongId)).ToList();
          
                context.LichTrinh_TuyenDuong.RemoveRange(
                    context.LichTrinh_TuyenDuong.Where(i => i.LichTrinhId==lichTrinhId && exceptList.Contains(i.TuyenDuongId)));

                for (int i = 0; i < listTuyenDuong.Count; i++)
                {
                    var lttd = listTuyenDuong[i];

                    var obj =
                        context.LichTrinh_TuyenDuong.SingleOrDefault(
                            j => j.Id == lttd.Id && j.LichTrinhId == lichTrinhId);

                    //Them lichTrinh
                    if (obj == null)
                    {
                        var newOjb = new LichTrinh_TuyenDuong
                        {
                            DaChayQua = lttd.DaChayQua,
                            GiaVe = lttd.GiaVe,
                            ThoiGianDung = lttd.ThoiGianDung.TotalMinutes,
                            ThuTu = i,
                            TuyenDuongId = lttd.TuyenDuongId,
                            LichTrinhId = lichTrinhId,
                        };
                        context.LichTrinh_TuyenDuong.Add(newOjb);
                    }
                    //sua lich trinh
                    else
                    {
                        obj.DaChayQua = lttd.DaChayQua;
                        obj.GiaVe = lttd.GiaVe;
                        obj.ThoiGianDung = lttd.ThoiGianDung.TotalMinutes;
                        obj.ThuTu = i;
                    }
                }
                try
                {
                    context.SaveChanges();
                    trans.Complete();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool CapNhatLichTrinhTuyenDuongMau(string doanTauId, string tenLichTrinh, List<LichTrinhTuyenDuongModelcs> listTuyenDuong)
        {
            LichTrinh lichTrinh = new LichTrinh()
            {
                DoanTauId = doanTauId,
                GioChay = DateTime.Now,
                GioDen = DateTime.Now,
                LichTrinhMau = true,
                TenLichTrinh = tenLichTrinh,
                TrangThai = 1,
            };
            
            var id = LichTrinhDal.Them(lichTrinh);

            listTuyenDuong.ForEach(i => i.Id = 0);

            return CapNhatLichTrinhTuyenDuong(id, listTuyenDuong);
        }


        public static List<LichTrinhTuyenDuongModelcs> LayTuyenDuongTheoLichTrinhGaDauGaCuoi(int lichTrinhId, int gaDauId, int gaCuoiId)
        {
            var results = LayLichTrinh(lichTrinhId);
            
            for (int i =0; i<results.Count;)
            {
                var curentTd = results[i];

                if (curentTd.GaTauDauId == gaDauId)
                {
                    break;
                }

                results.Remove(curentTd);
            }

            var j = results.Count - 1;
            while (j > -1)
            {
                var curentTd = results[j];

                if (curentTd.GaTauCuoiId == gaCuoiId)
                {
                    break;
                }

                results.Remove(curentTd);
                j--;
            }

            return results;
        }

        public static void CapNhatDaChayQua(int id, bool daChayQua)
        {
            using (var context = new VeTauEntities(false))
            {
                var ojb = context.LichTrinh_TuyenDuong.SingleOrDefault(i => i.Id == id);

                if (ojb != null)
                    ojb.DaChayQua = daChayQua;

                context.SaveChanges();

            }
        }
    }
}
