using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeTau.DAL;
using BanVeTau.Models;
using BanVeTau.Properties;

namespace BanVeTau.GUI
{
    public partial class FCapNhatThongTinVe : Form
    {
        public List<LichTrinhTuyenDuongModelcs> ListLichTrinh { get; }
        public GheModel Ghe { get; }
        public bool TaoMoi { get; set; }
        public string NhanVienId { get; set; }

        public FCapNhatThongTinVe(List<LichTrinhTuyenDuongModelcs> listLichTrinh, GheModel ghe, string nhanVienId) 
        {
            InitializeComponent();
            Ghe = ghe;
            ListLichTrinh = listLichTrinh;
            TaoMoi = ghe.GiaoDichId == 0;
            NhanVienId = nhanVienId;
        }

        

        private void FCapNhatThongTinVe_Load(object sender, EventArgs e)
        {
            LamMoiControl();

            cbKhachHang.DataSource = KhachHangDal.LayTatCa(true); 
            cbKhachHang.ValueMember = "Id";
            cbKhachHang.DisplayMember = "TenKhachHang";

            cbKhachHang.SelectedValue = Ghe.KhachHangId;

            cbKhachHang.Enabled = TaoMoi;

            btnCapNhat.Visible = TaoMoi;
            btnHuyVe.Visible = !TaoMoi;
        }

        private void LamMoiControl()
        {
            var lichTrinh = LichTrinhDal.Lay(ListLichTrinh.Count > 0 ? ListLichTrinh[0].LichTrinhId : 0);
            var doanTau = DoanTauDal.LayDoanTau(lichTrinh.DoanTauId);

            lbDoanTau.Text = doanTau.Name;
            lbLichTrinh.Text = lichTrinh.TenLichTrinh;

            var chiTietTuyenDuong = LayTuyenDuong();

            lbChiTietLichTrinh.Text = chiTietTuyenDuong;

            var length = chiTietTuyenDuong.Length;

            if (length > 12)
            {
                lbChiTietLichTrinh.Text = chiTietTuyenDuong.Substring(0, 15) + "..." +
                                          chiTietTuyenDuong.Substring(chiTietTuyenDuong.Length - 15, 15);
            }

            lbLoaiGhe.Text = Ghe.Ten;
            lbSoGhe.Text = Ghe.MaGhe;
            chkBiHoan.Checked = ListLichTrinh.Any(lt => lt.TuyenDuongId == 0);
            lbNhanVien.Text = NhanVienDal.LayNhanVien(NhanVienId).TenNhanVien;
            chkBiHuy.Checked = Ghe.HuyGhe;
            lbGiaVe.Text = Ghe.SoTien.ToString("C0");
            //Thêm ngày khởi hành cho vé.
            var ltr = LichTrinhDal.LayNgayKhoiHanhTheoTen(lbLichTrinh.Text);
            lbNgayKhoiHanh.Text = ltr.GioChay.ToShortDateString();
            lbGioChay.Text = ltr.GioChay.ToShortTimeString();
            var giaoDich = GiaoDichDal.LayGiaoDich(Ghe.GiaoDichId);
            if (giaoDich!=null)
                tbGhiChu.Text = giaoDich.GhiChu;

        }
        private string LayTuyenDuong()
        {
            var lbTuyenDuongText = new StringBuilder(" || ");

            for (int i = 0; i < ListLichTrinh.Count; i++)
            {
                var tuyenDuong = ListLichTrinh[i];
                if (i == 0)
                {
                    if (!tuyenDuong.GaTauCuoiId.Equals(tuyenDuong.GaTauDauId))
                    {
                        lbTuyenDuongText.Append(tuyenDuong.GaTauDau.Ten).Append(" >> ").Append(tuyenDuong.GaTauCuoi.Ten);
                        continue;
                    }

                    return string.Empty;
                }

                if (ListLichTrinh[i - 1].GaTauCuoiId.Equals(tuyenDuong.GaTauDauId) && !tuyenDuong.GaTauCuoiId.Equals(tuyenDuong.GaTauDauId))
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

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhachHang.SelectedIndex<0 && TaoMoi)
                return;

            var khachHang = cbKhachHang.SelectedItem as KhachHang;
            double heSo;
            //trường hợp xem thông tin vé khách hàng bị xoá 
            if (khachHang == null)
            {
                heSo = GiaoDichDal.LayGiaoDich(Ghe.GiaoDichId).HeSo;
            }
            else
            {
                heSo = LoaiKhachHangDal.Lay(khachHang.LoaiKhachHangId).HeSo;
            }

            lbHeSo.Text = heSo.ToString("F2");
            lbHeSo.Tag = heSo;
            if (TaoMoi)
            {
                lbSoTien.Text = (Ghe.SoTien*heSo).ToString("C0");
                lbSoTien.Tag = (Ghe.SoTien*heSo);
            }
            else
            {
                label17.Text = "Số tiền trả lại";
                lbSoTien.Text = (Ghe.SoTien * 0.8).ToString("C0");
                lbSoTien.Tag = (Ghe.SoTien * 0.8).ToString("C0");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var chiTietGiaoDich = new List<ChiTietGiaoDich>();

                foreach (var lichTrinh in ListLichTrinh)
                {
                    var chiTiet = new ChiTietGiaoDich
                    {
                        Huy = false,
                        LichTrinhTuyenDuongId = lichTrinh.Id,
                        LoaiGheId = Ghe.LoaiGheId,
                        SoGhe = Ghe.SoShe
                    };

                    chiTietGiaoDich.Add(chiTiet);
                }

                var giaoDich = new GiaoDich
                {
                    KhachHangId = cbKhachHang.SelectedValue.ToString(),
                    LichTrinhId = ListLichTrinh[0].LichTrinhId,
                    GhiChu = tbGhiChu.Text,
                    HeSo = (double) lbHeSo.Tag,
                    NhanVienId = NhanVienId,
                    SoTien = (double) lbSoTien.Tag,
                    ChiTietGiaoDiches = chiTietGiaoDich,
                    NgayLap = DateTime.Now
                };

                if (GiaoDichDal.Them(giaoDich) > 0)
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai, Resources.MThatBai);
                }

            }
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (cbKhachHang.SelectedIndex<0)
            {
                MessageBox.Show(Resources.KhongDeTrong, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            if (ChiTietGiaoDichDal.HuyChiTuyetGiaoDich(Ghe.GiaoDichId, Ghe.LoaiGheId, Ghe.SoShe) > 0)
            {
                MessageBox.Show("Huỷ vé "+ Ghe.MaGhe + Resources.thanhCong, Resources.MThanhCong);
                Close();
            }
            else
            {
                MessageBox.Show("Huỷ vé " + Resources.thatBai, Resources.MThatBai);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
