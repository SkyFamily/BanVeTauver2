using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeTau.Models;

namespace BanVeTau.DAL
{
    class GaTauDal
    {
        public static List<GaTau> LayTatCa()
        {
            using (var context = new VeTauEntities(false))
            {
                var result = context.GaTaus.ToList();
                return result;

            }
        }

        public static int ThemGaTau(GaTau gaTau)
        {
            using (var context = new VeTauEntities(false))
            {
                context.GaTaus.Add(gaTau);
                return context.SaveChanges();

            }
        }

        public static int XoaGaTau(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                var gaTau = context.GaTaus.SingleOrDefault(gt => gt.Id == id);

                if (gaTau != null)
                {
                    context.GaTaus.Remove(gaTau);
                }

                return context.SaveChanges();
            }

        }

        public static GaTau LayPGaTau(int id)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.GaTaus.SingleOrDefault(gt => gt.Id == id);
            }

        }

        public static int CapNhatGaTau(GaTau gaTau)
        {
            using (var context = new VeTauEntities(false))
            {
                var doiTuong = context.GaTaus.SingleOrDefault(i => i.Id == gaTau.Id);

                if (doiTuong != null)
                {
                    doiTuong.Ten = gaTau.Ten;
                    doiTuong.DiaChi = gaTau.DiaChi;
                }
                return context.SaveChanges();
            }
        }

        public static List<GaTauModel1> LayTatCaModel1()
        {
            return LayTatCa().Select(i=>new GaTauModel1
            {
                Id = i.Id,
                Ten = i.Ten,
                DiaChi = i.DiaChi
            }).ToList();
        }
    }
}
