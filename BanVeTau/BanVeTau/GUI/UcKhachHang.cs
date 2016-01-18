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
using BanVeTau.Properties;
using BanVeTau.Utils;

namespace BanVeTau.GUI
{
    public partial class UcKhachHang : UserControl
    {
        public UcKhachHang()
        {
            InitializeComponent();
        }

        private void UcKhachHang_Load(object sender, EventArgs e)
        {
            Dock=DockStyle.Fill;

            var dataLoaiKhachHang = LoaiKhachHangDal.LayTatCa();

            cbLoaiKhachHang.DataSource = dataLoaiKhachHang;
            cbLoaiKhachHang.DisplayMember = "Ten";
            cbLoaiKhachHang.ValueMember = "Id";
            cbLoaiKhachHang.SelectedIndex = -1;

            var loaiKhachHang1 = dataLoaiKhachHang.ToList();
            loaiKhachHang1.Insert(0, new LoaiKhachHang { Id = 0, Ten = "Tất cả" });
            cbLoaiKhachHang1.DataSource = loaiKhachHang1;
            cbLoaiKhachHang1.DisplayMember = "Ten";
            cbLoaiKhachHang1.ValueMember = "Id";

            reGridLoaiKhachHang.DataSource = LoaiKhachHangDal.LayTatCa();
            reGridLoaiKhachHang.ValueMember = "Id";
            reGridLoaiKhachHang.DisplayMember = "Ten";

            tbId.Text = KhachHangDal.LayIdTuDong("KH", 4);

            CapNhatGridView();
        }

        private void CapNhatGridView()
        {
            if(cbLoaiKhachHang1.SelectedIndex<0)
                return;

            int tempLoaiKh = Convert.ToInt16(cbLoaiKhachHang1.SelectedValue);
            gvExtra.DataSource = KhachHangDal.LayTatCa(tempLoaiKh);
            gvExtra.RefreshDataSource();
        }

        private void btn_Delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = gridView.GetFocusedRowCellValue("Id").ToString();

            if (!string.IsNullOrEmpty(id))
            {
                if (KhachHangDal.Xoa(id) > 0)
                {
                    CapNhatGridView();
                    MessageBox.Show(Resources.XoaDoiTuong + Resources.thanhCong, Resources.MThanhCong);                    
                }
                else
                {
                    MessageBox.Show(Resources.XoaDoiTuong + Resources.thatBai, Resources.MThatBai);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var khachHangMoi = new KhachHang
                {
                    Id = tbId.Text.ToUpper(),
                    TenKhachHang = tbTenKhachHang.Text,
                    CMND = tbCMND.Text,
                    SoDienThoai = tbDienThoai.Text,
                    LoaiKhachHangId = cbLoaiKhachHang.SelectedValue is int ? (int) cbLoaiKhachHang.SelectedValue : 0,
                    MatKhau = MyUtil.MaHoaMatKhau(tbMatKhau.Text),
                    RuleDangNhap = twRuleDangNhap.IsOn
                };
                if (KhachHangDal.TaoKhachHang(khachHangMoi))
                {
                    btnLamMoi_Click(null, null);
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong , Resources.MThanhCong);                    
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai , Resources.MThatBai);
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
                MessageBox.Show(Resources.TenDangNhap + Resources.nhieuHon + ChieuDaiId + Resources.kyTu, Resources.MNhapLieuSai);
                return false;
            }
            if (tbTenKhachHang.Text.Equals(string.Empty) || tbCMND.Text.Equals(string.Empty) || tbMatKhau.Text.Equals(string.Empty) || cbLoaiKhachHang.SelectedIndex<0)
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMatKhau.Text = string.Empty;
            tbId.Text = string.Empty;
            tbCMND.Text = string.Empty;
            tbDienThoai.Text = string.Empty;
            tbMatKhau1.Text = string.Empty;
            tbTenKhachHang.Text = string.Empty;
            twRuleDangNhap.IsOn = true;
            cbLoaiKhachHang.SelectedIndex = -1;
            cbLoaiKhachHang.SelectedIndex = 0;

            tbId.Text = KhachHangDal.LayIdTuDong("KH", 4);

            CapNhatGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dem = 0;
            var listDoiTuong = gvExtra.DataSource as List<KhachHang>;

            if (listDoiTuong != null)
            {
                foreach (var doiTuong in listDoiTuong)
                {
                    dem += KhachHangDal.CapNhat(doiTuong);
                }
            }
            MessageBox.Show(Resources.CapNhat + dem + Resources.doiTuong, Resources.MThanhCong);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CapNhatGridView();
        }
    }
}
