using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeTau.DAL;
using BanVeTau.Properties;
using BanVeTau.Utils;
using System.Windows.Forms;

namespace BanVeTau.GUI
{
    public partial class FTaoKhachHang : Form
    {
        readonly int ChieuDaiId = 4;
        readonly int tempId = 1;
        public FTaoKhachHang()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var khachHangMoi = new KhachHang
                {
                    Id = tbId.Text.ToUpper(),
                    TenKhachHang = tbTenKhachHang.Text,
                    CMND = tbCMND.Text,
                    LoaiKhachHangId = 1,
                    SoDienThoai = tbDienThoai.Text,
                    MatKhau = MyUtil.MaHoaMatKhau(tbMatKhau.Text),
                };
                if (KhachHangDal.TaoKhachHang(khachHangMoi))
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong + Resources.MThanhCong);
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai + Resources.MThatBai);
                }
            }
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (tbId.Text.Length > ChieuDaiId)
            {
                MessageBox.Show(Resources.TenDangNhap + Resources.nhieuHon + ChieuDaiId + Resources.kyTu, Resources.MNhapLieuSai);
                return false;
            }
            if (tbId.Text.Equals(string.Empty) || tbTenKhachHang.Text.Equals(string.Empty) || tbDienThoai.Text.Equals(string.Empty)
                || tbCMND.Text.Equals(string.Empty))
            {
                MessageBox.Show(Resources.ChuaNhapDuCacTruongBatBuoc, Resources.MNhapLieuSai);
                return false;
            }
            if (KhachHangDal.KiemTraTonTaiId(tbId.Text))
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

        private void FTaoKhachHang_Load(object sender, EventArgs e)
        {
            tbId.Text = KhachHangDal.LayIdTuDong("KH",ChieuDaiId);
        }

        //private int LoadId()
        //{

        //}
    }
}
