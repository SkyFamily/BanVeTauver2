using System.Windows.Forms;
using BanVeTau.DAL;
using DevExpress.XtraBars;

namespace BanVeTau.GUI
{
    public partial class FChinh : Form
    {
        public string UserId { get; }
        public bool NhanVien { get; }
        public FChinh(string userId, bool nhanVien)
        {
            InitializeComponent();
            UserId = userId;
            NhanVien = nhanVien;
            PhanQuyen();            
        }

        private void PhanQuyen()
        {
            ribbonControl.Pages.Remove(ribbonPage3);
            ribbonControl.Pages.Remove(ribbonPage4);
            ribbonPage1.Groups.Remove(ribbonPageGroupKhachHang);
            ribbonPage2.Groups.Remove(ribbonPageGroupBanVe);
            ribbonPage2.Groups.Remove(ribbonPageGroupLichTrinh2);
            ribbonPage1.Groups.Remove(ribbonPageGroupKhachHang);
            ribbonPage1.Groups.Remove(ribbonPageGroupKhachHang);
            ribbonPage1.Groups.Remove(ribbonPageGroupNhanVien);
            ribbonPage1.Groups.Remove(ribbonPageGroupHeThong);
            ribbonPage1.Groups.Remove(ribbonPageGroupChoNgoi);
            ribbonPage1.Groups.Remove(ribbonPageGroupLichTrinh1);
            if (NhanVien)
            {
                var nv = NhanVienDal.LayNhanVien(UserId);
                var phongBan = PhongBanDal.LayPhongBan(nv.PhongBanID);
                if (phongBan.RuleBaoCao)
                {
                    ribbonControl.Pages.Add(ribbonPage3);
                }
                if (phongBan.RuletBanVe)
                {
                    ribbonPage2.Groups.Add(ribbonPageGroupBanVe);
                    ribbonPage1.Groups.Add(ribbonPageGroupKhachHang);
                }
                if (phongBan.RuleNhanSu)
                {
                    ribbonPage1.Groups.Add(ribbonPageGroupKhachHang);
                    ribbonPage1.Groups.Add(ribbonPageGroupNhanVien);
                }
                if (phongBan.RuleChuyenTau)
                {
                    ribbonPage1.Groups.Add(ribbonPageGroupLichTrinh1);
                    ribbonPage2.Groups.Add(ribbonPageGroupLichTrinh2);
                }
                if (phongBan.RuleQuanTri)
                {
                    ribbonPage1.Groups.Add(ribbonPageGroupHeThong);
                    ribbonPage1.Groups.Add(ribbonPageGroupChoNgoi);
                }
                if (phongBan.Id.Equals("ADMIN") || phongBan.Id.Equals("BH") || phongBan.Id.Equals("KT"))
                    barStatusUser.Caption = phongBan.TenPhongBan + ": " + nv.TenNhanVien;
                

            }
            else
            {
                ribbonControl.Pages.Remove(ribbonPage1);
                ribbonControl.Pages.Remove(ribbonPage2);
                ribbonControl.Pages.Remove(ribbonPage3);
                ribbonControl.Pages.Add(ribbonPage4);

                var kh = KhachHangDal.LayKhachHang(UserId);
                var loaiKh = LoaiKhachHangDal.Lay(kh.LoaiKhachHangId);
                barStatusUser.Caption = loaiKh.Ten + ": "+ kh.TenKhachHang;
            }
        }

        private void statusBar()
        {
            if(NhanVien)
                ribbonStatusBar1.ItemLinks[0].Caption = "Nhân viên";
            else
                ribbonStatusBar1.ItemLinks[0].Caption = "Khách hàng";
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var phongBan = new UcPhongBan();
            panelMain.Controls.Add(phongBan);
        }

        private void btnNhaGa_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucGaTau = new UCGaTau();
            panelMain.Controls.Add(ucGaTau);
        }

        private void btnTuyenDuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucTuyenDuong = new UcTuyenDuong();
            panelMain.Controls.Add(ucTuyenDuong);
        }

        private void btnLoaiGhe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucLoaiGhe = new UCLoaiGhe();
            panelMain.Controls.Add(ucLoaiGhe);
        }

        private void btnDoanTau_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucDoanTau = new UCDoanTau();
            panelMain.Controls.Add(ucDoanTau);
        }

        private void btnLichTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucLichTrinh = new UCLichTrinh();
            panelMain.Controls.Add(ucLichTrinh);
        }

        private void btnTaoLichTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucChiTietLichTrinh = new UCChiTietLichTrinh();
            panelMain.Controls.Add(ucChiTietLichTrinh);
        }

        private void btnGhe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucGhe = new UCGhe();
            panelMain.Controls.Add(ucGhe);
        }

        private void btnBanVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucBanVe = new UcBanVe();
            panelMain.Controls.Add(ucBanVe);
        }

        private void btnLoaiKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucLoaiKhachHang = new UcLoaiKhachHang();
            panelMain.Controls.Add(ucLoaiKhachHang);
        }

        private void btnNhanSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucKhachHang = new UcKhachHang();
            panelMain.Controls.Add(ucKhachHang);
        }

        private void btnTraVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucTraVe = new UcTraVe();
            panelMain.Controls.Add(ucTraVe);
        }

        private void btnCapNhatLichTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucCapNhatLichTrinh = new UcCapNhatLichTrinh();
            panelMain.Controls.Add(ucCapNhatLichTrinh);
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucNhanVien = new UcNhanVien(UserId);
            panelMain.Controls.Add(ucNhanVien);
        }

        private void btnXemNhanVienBanVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucrNhanVienBanHang = new UcRNhanVien();
            panelMain.Controls.Add(ucrNhanVienBanHang);
        }

        private void btnInGiaVe_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucBaoCaoGiaVe = new UcBaoCaoGiaVe();
            panelMain.Controls.Add(ucBaoCaoGiaVe);
        }

        private void btnInGiaoDich_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucBaoCaoGiaoDich = new UcBaoCaoGiaoDichTC();
            panelMain.Controls.Add(ucBaoCaoGiaoDich);
        }

        private void btnGiaoDich1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucBaoCaoGiaoDich = new UcBaoCaoGiaoDichTB();
            panelMain.Controls.Add(ucBaoCaoGiaoDich);
        }

        private void btnInDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var ucBaoCaoDoanhThu = new UcBaoCaoDoanhThu();
            panelMain.Controls.Add(ucBaoCaoDoanhThu);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
            FLogin login = new FLogin();
            login.ShowDialog();
        }
    }
}
