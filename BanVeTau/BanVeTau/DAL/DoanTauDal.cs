using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class DoanTauDal
    {
        public static List<DoanTau> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                var result = context.DoanTaus.ToList();
                return result;

            }
        }

        public static int ThemDoanTau(DoanTau doanTau)
        {
            using (var context = new VeTauEntities(false))
            {
                context.DoanTaus.Add(doanTau);
                return context.SaveChanges();

            }
        }

        public static int Xoa(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                var ojb = context.DoanTaus.SingleOrDefault(i => i.Id == id);

                if (ojb != null)
                {
                    context.DoanTaus.Remove(ojb);
                }

                return context.SaveChanges();
            }

        }

        public static DoanTau LayDoanTau(string id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.DoanTaus.SingleOrDefault(i => i.Id == id);
            }

        }
     
        public static int CapNhatDoanTau(DoanTau doanTau)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.DoanTaus.SingleOrDefault(i => i.Id == doanTau.Id);
                if (doiTuong != null)
                {
                    doiTuong.GhiChu = doanTau.GhiChu;
                    doiTuong.Name = doanTau.Name;
                    doiTuong.TocDo = doanTau.TocDo;
                }
                return context.SaveChanges();
            }
        }
    }
}
