using System.Collections.Generic;
using System.Linq;

namespace BanVeTau.DAL
{
    public class PhongBanDal
    {
        public static List<PhongBan> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                var result = context.PhongBans.ToList();
                return result;

            }
        }

        public static int ThemPhongBan(PhongBan phongBan)
        {
            using (var context = new VeTauEntities(false))
            {
                context.PhongBans.Add(phongBan);
                return context.SaveChanges();

            }
        }

        public static int XoaPhongBan(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                var phongBan = context.PhongBans.SingleOrDefault(pb => pb.Id == id);

                if (phongBan != null)
                {
                    context.PhongBans.Remove(phongBan);
                }

                return context.SaveChanges();
            }
          
        }

        public static PhongBan LayPhongBan(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.PhongBans.SingleOrDefault(pb => pb.Id == id);
            }
            
        }

        public static int CapNhatPhongBan(PhongBan phongBan)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.PhongBans.SingleOrDefault(pb => pb.Id == phongBan.Id);
                if (doiTuong != null)
                {
                    doiTuong.TenPhongBan = phongBan.TenPhongBan;
                    doiTuong.RuleBaoCao = phongBan.RuleBaoCao;
                    doiTuong.RuleChuyenTau = phongBan.RuleChuyenTau;
                    doiTuong.RuleLichTrinh = phongBan.RuleLichTrinh;
                    doiTuong.RuleNhanSu = phongBan.RuleNhanSu;
                    doiTuong.RuletBanVe = phongBan.RuletBanVe;
                    doiTuong.RuleQuanTri = phongBan.RuleQuanTri;
                }
                return context.SaveChanges();
            }
        }
    }
}