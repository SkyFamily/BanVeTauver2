using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeTau.DAL;
using BanVeTau.Models;
using BanVeTau.Properties;
using BanVeTau.Utils;

namespace BanVeTau.GUI
{
    public partial class UcTraVe : UserControl
    {
        public UcTraVe()
        {
            InitializeComponent();
            gridControl.DataSource = new List<GheModel>();
        }

        private void btnHuyGhe_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLeVaThongBao())
                return;

            var dataSource = tileView.DataSource as List<GheModel>;

            if (dataSource != null)
            {
                var dsGhe = dataSource.Where(g => g.CoTheDat).ToList();

                foreach (var ghe in dsGhe)
                {
                    var fChinh = ParentForm as FChinh;

                    if (fChinh != null)
                    {
                        //var nhanVienId = fChinh.UserId;

                        var giaoDich = GiaoDichDal.LayGiaoDich(ghe.GiaoDichId);
                        var lichTrinhTuyenDuongs = LichTrinhTuyenDuongDal.LayLichTrinhGiaoDich(ghe.GiaoDichId);

                        var fCapNhatThongTin = new FCapNhatThongTinVe(lichTrinhTuyenDuongs, ghe, giaoDich.NhanVienId);

                        fCapNhatThongTin.ShowDialog();

                        CapNhatLichTrinh();
                    }

                }
            }
        }

        private bool KiemTraHopLeVaThongBao()
        {
            var dsGhe = tileView.DataSource as List<GheModel>;

            if (dsGhe == null || !dsGhe.Any(g => g.CoTheDat))
            {
                MessageBox.Show("Chưa chọn ghế để huỷ", Resources.BanChuaChonGheDeDatVe);
                return false;
            }
            foreach (var ghe in dsGhe.Where(g=>g.CoTheDat))
            {
                var lichTrinh = LichTrinhDal.Lay(ghe.LichTrinhId);

                if (lichTrinh.GioDen < DateTime.Now)
                {
                    MessageBox.Show(ghe.TenLichTrinh+ "của chuyến tàu này đã kết thúc vào thời gian hiện tại", Resources.MCanhBao);
                    return false;
                }

                var lichTrinhTuyenDuongs = LichTrinhTuyenDuongDal.LayLichTrinhGiaoDich(ghe.GiaoDichId);

                if (lichTrinhTuyenDuongs.Any(lt => lt.DaChayQua))
                {
                    MessageBox.Show("Lịch trình "+ ghe .TenLichTrinh + " đã qua không thể huỷ", Resources.MCanhBao);
                    return false;
                }
            }
            return true;
        }

        private void UcTraVe_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            gridLockUpSearch.Properties.DataSource = KhachHangDal.LayTatCa(true).ToList();
            CapNhatListAnh();

            var parentForm = (FChinh)ParentForm;
            if (parentForm != null && !parentForm.NhanVien)
            {
                labelKhachHang.Visible = false;
                gridLockUpSearch.Visible = false;
                btnHuyGhe.Location = new Point(12,12);
                gridLockUpSearch.EditValue = parentForm.UserId;
            }

        }

        private void CapNhatListAnh()
        {
            var listLoaiGhe = LoaiGheDal.LayTatCa();
            listLoaiGhe.ForEach(lg => imageListLoaiGhe.Images.Add(lg.Id.ToString(), MyUtil.ByteArrayToImage(lg.Anh)));
        }

        private void gridLockUpSearch_EditValueChanged(object sender, EventArgs e)
        {
            CapNhatLichTrinh();
        }

        private void CapNhatLichTrinh()
        {
            var ghes = new List<GheModel>();
            var dsGiaoDich = GiaoDichDal.LayGiaoDichKhachHang(gridLockUpSearch.EditValue.ToString());
            foreach (var giaoDich in dsGiaoDich)
            {
                if(giaoDich.ChiTietGiaoDiches.Count<1)
                    continue;

                var ctgd = giaoDich.ChiTietGiaoDiches.First();

                var ngay = LichTrinhDal.LayTheoId(giaoDich.LichTrinhId);

                var lg = LoaiGheDal.LayLoaiGhe(giaoDich.ChiTietGiaoDiches.First().LoaiGheId);

                var ghe = new GheModel
                {
                    Anh = imageListLoaiGhe.Images[imageListLoaiGhe.Images.IndexOfKey(lg.Id.ToString())],
                    LoaiGheId = lg.Id,
                    GhiChu = string.Empty,
                    Ten = lg.Ten,
                    DaDuocDat = ctgd.Huy != null && !ctgd.Huy.Value, //chấp nhận cho huỷ ko sát nghĩa lắm enable
                    HeSo = lg.HeSo,
                    SoShe = ctgd.SoGhe,
                    HuyGhe = ctgd.Huy != null && ctgd.Huy.Value, //mặc định
                    CoTheDat = false, //check khi right click select
                    MaGhe = "LT" + giaoDich.LichTrinhId + "-" + lg.Id + (ctgd.SoGhe + 1),
                    TenKhachHang = gridLockUpSearch.SelectedText,
                    GiaoDichId = giaoDich.Id,
                    LichTrinhId = giaoDich.LichTrinhId,
                    KhachHangId = giaoDich.KhachHangId,
                    NgayKhoiHanh = ngay.GioChay.ToShortDateString(),
                    GioKhoiHanh = ngay.GioChay.ToShortTimeString(),
                    SoTien = giaoDich.SoTien
                };
                var lichTrinhTuyenDuongs = LichTrinhTuyenDuongDal.LayLichTrinhGiaoDich(giaoDich.Id);
                
                ghe.TenLichTrinh = LayTuyenDuong(lichTrinhTuyenDuongs);

                var length = ghe.TenLichTrinh.Length;

                if (length > 12)
                {
                    ghe.TenLichTrinh = ghe.TenLichTrinh.Substring(0, 12) + "..." +
                                              ghe.TenLichTrinh.Substring(ghe.TenLichTrinh.Length - 12, 12);
                }

                
                ghes.Add(ghe);
            }
         
            gridControl.DataSource = ghes;
        }

        private string LayTuyenDuong(List<LichTrinhTuyenDuongModelcs>  listLichTrinh)
        {
            var lbTuyenDuongText = new StringBuilder(" || ");

            for (int i = 0; i < listLichTrinh.Count; i++)
            {
                var tuyenDuong = listLichTrinh[i];
                if (i == 0)
                {
                    if (!tuyenDuong.GaTauCuoiId.Equals(tuyenDuong.GaTauDauId))
                    {
                        lbTuyenDuongText.Append(tuyenDuong.GaTauDau.Ten).Append(" >> ").Append(tuyenDuong.GaTauCuoi.Ten);
                        continue;
                    }

                    return string.Empty;
                }

                if (listLichTrinh[i - 1].GaTauCuoiId.Equals(tuyenDuong.GaTauDauId) && !tuyenDuong.GaTauCuoiId.Equals(tuyenDuong.GaTauDauId))
                {
                    lbTuyenDuongText.Append(" >> ").Append(tuyenDuong.GaTauCuoi.Ten);
                }
                else
                {
                    return string.Empty;
                }
            }

            lbTuyenDuongText.Append(" || ");

            return lbTuyenDuongText.ToString();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
