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
using BanVeTau.Properties;
using BanVeTau.Utils;

namespace BanVeTau.GUI
{
    public partial class FTaoNhanVien : Form
    {
        private const int ChieuDaiId = 4;
        public FTaoNhanVien()
        {
            InitializeComponent();
        }

        private void FTaoNhanVien_Load(object sender, EventArgs e)
        {
            dtNgaySinh.MaxDate = DateTime.Now.AddYears(-18);

            cbPhongBan.DataSource = PhongBanDal.LayTatCa();
            cbPhongBan.DisplayMember = "TenPhongBan";
            cbPhongBan.ValueMember = "Id";
            cbPhongBan.SelectedIndex = -1;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var nhanVienMoi = new NhanVien
                {
                    CMND = tbCMND.Text,
                    DiaChi = tbDiaChi.Text,
                    DienThoai = tbDienThoai.Text,
                    Email = tbEmail.Text,
                    GioiTinh = tsGioiTinh.IsOn,
                    Id = tbId.Text.ToUpper(),
                    MatKhau = MyUtil.MaHoaMatKhau(tbMatKhau.Text),
                    NgaySinh = dtNgaySinh.Value.ToUniversalTime(),
                    NgayVaoLam = DateTime.Now,
                    PhongBanID = cbPhongBan.SelectedValue.ToString(),
                    TenNhanVien = tbTenNhanVien.Text

                };
                if (NhanVienDal.TaoNhanVien(nhanVienMoi))
                {
                    MessageBox.Show(Resources.TaoDoiTuong +Resources.thanhCong, Resources.MThanhCong);
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
            if (string.IsNullOrWhiteSpace(tbId.Text))
            {
                MessageBox.Show(Resources.TenDangNhap + " không thể chứa" + Resources.kyTu + " khoảng trắng ", Resources.MNhapLieuSai);
                return false;
            }
            if (tbId.Text.Length < ChieuDaiId)
            {
                MessageBox.Show(Resources.TenDangNhap +Resources.nhieuHon +ChieuDaiId + Resources.kyTu, Resources.MNhapLieuSai);
                return false;
            }
            if (tbId.Text.Equals(string.Empty)|| tbTenNhanVien.Text.Equals(string.Empty) || tbCMND.Text.Equals(string.Empty) ||
                tbMatKhau.Text.Equals(string.Empty) || tbMatKhau1.Text.Equals(string.Empty) || cbPhongBan.SelectedIndex<0)
            {
                MessageBox.Show(Resources.ChuaNhapDuCacTruongBatBuoc, Resources.MNhapLieuSai);
                return false;
            }
            if (NhanVienDal.KiemTraTonTaiId(tbId.Text.ToUpper()))
            {
                MessageBox.Show(Resources.MaDoiTuong + Resources.daTonTai, Resources.MNhapLieuSai);
                return false;
            }
                if (!tbMatKhau1.Text.Equals(tbMatKhau.Text))
            {
                MessageBox.Show(Resources.MatKhauNhapLai + Resources.khongChinhXac, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void cbPhongBan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbId.Text = NhanVienDal.LayIdTuDong(cbPhongBan.SelectedValue.ToString(), ChieuDaiId);
        }
    }
}
