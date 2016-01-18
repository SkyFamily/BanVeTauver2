using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class TuyenDuongDal
    {
        public static List<TuyenDuong> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                var result = context.TuyenDuongs.ToList();
                return result;

            }
        }

        public static int ThemTuyenDuong(TuyenDuong tuyenDuong)
        {
            using (var context = new VeTauEntities(false))
            {
                context.TuyenDuongs.Add(tuyenDuong);
                return context.SaveChanges();

            }
        }

        public static int XoaTuyenDuong(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                var ojb = context.TuyenDuongs.SingleOrDefault(pb => pb.Id == id);

                if (ojb != null)
                {
                    context.TuyenDuongs.Remove(ojb);
                }
                try
                {
                    return context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return 0;

        }

        public static TuyenDuong LayTuyenDuong(int gaDauId, int gaCuoiId)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.TuyenDuongs.SingleOrDefault(i => i.GaTauDauId==gaDauId && i.GaTauCuoiId==gaCuoiId);
            }

        }

        public static TuyenDuong LayTuyenDuong(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.TuyenDuongs.SingleOrDefault(i => i.Id == id);
            }

        }
        public static TuyenDuong LayTuyenDuong()
        {
            using (var context = new VeTauEntities(false))
            {
                return context.TuyenDuongs.FirstOrDefault();
            }

        }

        public static int CapNhatTuyenDuong(TuyenDuong tuyenDuong)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.TuyenDuongs.SingleOrDefault(i => i.Id == tuyenDuong.Id);
                if (doiTuong != null)
                {
                    doiTuong.GaTauCuoiId = tuyenDuong.GaTauCuoiId;
                    doiTuong.GaTauDauId = tuyenDuong.GaTauDauId;
                    doiTuong.KhoangCach = tuyenDuong.KhoangCach;
                }
                return context.SaveChanges();
            }
        }
    }
}
