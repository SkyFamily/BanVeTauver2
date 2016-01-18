using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeTau.DAL
{
    class DoanTauGheDal
    {
        public static DoanTau_LoaiGhe LayHoacTao(string doanTauId, int loaiGheId)
        {
            var result = Lay(doanTauId, loaiGheId);

            if (result == null)
            {
                result = new DoanTau_LoaiGhe {DoanTauId = doanTauId, LoaiGheId = loaiGheId, SoLuong = 0};
                TaoDoanTauLoaiGhe(result);
            }
            return result;
        }
        public static DoanTau_LoaiGhe Lay(string doanTauId, int loaiGheId)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.DoanTau_LoaiGhe.SingleOrDefault(i => i.DoanTauId == doanTauId && i.LoaiGheId == loaiGheId);
            }
        }

        public static bool TaoDoanTauLoaiGhe(DoanTau_LoaiGhe dtlg)
        {
            using (var context = new VeTauEntities(false))
            {
                context.DoanTau_LoaiGhe.Add(dtlg);
                return context.SaveChanges() > 0;
            }
        }
        public static bool CapNhatDoanTauLoaiGhe(string doanTauId, int loaiGheId, int soLuong)
        {
            using (var context = new VeTauEntities(false))
            {
                var obj = context.DoanTau_LoaiGhe.SingleOrDefault(i => i.DoanTauId == doanTauId && i.LoaiGheId == loaiGheId);
                if (obj != null)
                    obj.SoLuong = soLuong;

                return context.SaveChanges() > 0;
            }
        }

        public static List<DoanTau_LoaiGhe> LayTatCa(int? loaiGheId)
        {
            using (var context = new VeTauEntities(false))
            {
                return context.DoanTau_LoaiGhe.Where(g=>loaiGheId==null||g.LoaiGheId==loaiGheId).ToList();
            }
        }
    }
}
