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
    public partial class UcNhanVien : UserControl
    {
        public UcNhanVien()
        {
            InitializeComponent();
        }

        private void UcNhanVien_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            var dataPhongBan = PhongBanDal.LayTatCa();

            cbPhongBan.DataSource = dataPhongBan;
            cbPhongBan.DisplayMember = "TenPhongBan";
            cbPhongBan.ValueMember = "Id";

            var dataPhongBan1 = PhongBanDal.LayTatCa();
            dataPhongBan1.Insert(0, new PhongBan {Id = string.Empty, TenPhongBan = "Tất cả"});
            cbPhongBan1.DataSource = dataPhongBan1;
            cbPhongBan1.DisplayMember = "TenPhongBan";
            cbPhongBan1.ValueMember = "Id";

            reGridPhongBan.DataSource = PhongBanDal.LayTatCa();
            reGridPhongBan.ValueMember = "Id";
            reGridPhongBan.DisplayMember = "TenPhongBan";

            tbId.Text = NhanVienDal.LayIdTuDong("NV", 4);
            dtNgaySinh.MaxDate = DateTime.Now.AddYears(-18);

            cbPhongBan.SelectedIndex = -1;
            cbPhongBan1.SelectedIndex = 0;

            reNgaySinh.MaxValue = DateTime.Now.AddYears(-18);

            CapNhatGridView();
        }

        private void CapNhatGridView()
        {
            if (cbPhongBan1.SelectedIndex < 0)
                return;

            gvExtra.DataSource = NhanVienDal.LayTatCa(cbPhongBan1.SelectedValue as string);
            gvExtra.RefreshDataSource();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var nhanVienMoi = new NhanVien
            {
                Id = tbId.Text.ToUpper(),
                TenNhanVien = tbTen.Text,
                NgaySinh = dtNgaySinh.Value,
                NgayVaoLam = dtNgayVaoLam.Value,
                PhongBanID = cbPhongBan.SelectedValue as string,
                MatKhau = MyUtil.MaHoaMatKhau(tbMatKhau.Text.ToLower()),
                GioiTinh = twGioTinh.IsOn
            };
            if (KiemTraTaoNhanVien() && KiemTraHopLeVaThongBao(nhanVienMoi))
            {

                if (NhanVienDal.TaoNhanVien(nhanVienMoi))
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong + Resources.MThanhCong);
                    btnLamMoi_Click(null, null);
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai + Resources.MThatBai);
                }

            }
        }

        private bool KiemTraTaoNhanVien()
        {
            if (!tbMatKhau1.Text.Equals(tbMatKhau.Text))
            {
                MessageBox.Show(Resources.MatKhauNhapLai + Resources.khongChinhXac, Resources.MNhapLieuSai);
                return false;
            }
            if (NhanVienDal.KiemTraTonTaiId(tbId.Text))
            {
                MessageBox.Show(Resources.MaDoiTuong + Resources.daTonTai, Resources.MNhapLieuSai);
                return false;
            }

            return true;
        }

        private bool KiemTraHopLeVaThongBao(NhanVien nhanVien)
        {
            if (string.IsNullOrWhiteSpace(nhanVien.Id))
            {
                MessageBox.Show(nhanVien.TenNhanVien +" "+ Resources.TenDangNhap + " không thể chứa" + Resources.kyTu + " khoảng trắng ", Resources.MNhapLieuSai);
                return false;
            }
            if (nhanVien.Id.Length < ChieuDaiId)
            {
                MessageBox.Show(nhanVien.TenNhanVien + " " + Resources.TenDangNhap + Resources.nhieuHon + ChieuDaiId + Resources.kyTu, Resources.MNhapLieuSai);
                return false;
            }
            if (nhanVien.Id.Equals(string.Empty) || nhanVien.MatKhau.Equals(string.Empty) || nhanVien.NgaySinh == null ||
                nhanVien.NgayVaoLam == null || nhanVien.PhongBanID==null|| nhanVien.PhongBanID.Equals(string.Empty))
            {
                MessageBox.Show(nhanVien.TenNhanVien + " " + Resources.ChuaNhapDuCacTruongBatBuoc,
                    Resources.MNhapLieuSai);
                return false;
            }
            if (nhanVien.NgaySinh > DateTime.Now.AddYears(-18)|| nhanVien.NgaySinh.AddYears(18) > nhanVien.NgayVaoLam)
            {
                MessageBox.Show(nhanVien.TenNhanVien + " " + "chưa đủ 18 tuổi, Kiểm tra ngày sinh và ngày vào làm", Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMatKhau.Text = string.Empty;
            tbId.Text = string.Empty;
            tbTen.Text = string.Empty;
            dtNgaySinh.MaxDate = DateTime.Now.AddYears(-21);
            dtNgayVaoLam.Value = DateTime.Now;
            tbMatKhau1.Text = string.Empty;
            tbMatKhau.Text = string.Empty;
            twGioTinh.IsOn = true;
            tbId.Text = NhanVienDal.LayIdTuDong("NV", 4);
            cbPhongBan.SelectedIndex = -1;
            CapNhatGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dem = 0;
            var listDoiTuong = gvExtra.DataSource as List<NhanVien>;

            if (listDoiTuong != null)
            {
                foreach (var doiTuong in listDoiTuong)
                {
                    if (KiemTraHopLeVaThongBao(doiTuong))
                    {
                        dem += NhanVienDal.CapNhat(doiTuong);
                    }
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
