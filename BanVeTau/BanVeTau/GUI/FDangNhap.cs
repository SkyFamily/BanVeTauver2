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
using BanVeTau.GUI;
using BanVeTau.Properties;
using BanVeTau.Utils;

namespace BanVeTau
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();

            Text = tsLoaiTaiKhoan.IsOn ? "Khách hàng đăng nhập" : "Nhân viên đăng nhập";
            label1.Text = tsLoaiTaiKhoan.IsOn ? Resources.MaKH : Resources.MaNV;
            //btnLogin_Click(null,null);
            Hide();
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbTenDangNhap.Text.Equals(string.Empty) || tbMatKhau.Text.Equals(string.Empty))
            {
                MessageBox.Show(Resources.ChuaNhapDuCacTruongBatBuoc, Resources.MNhapLieuSai, MessageBoxButtons.OK);
            }
            else if(tsLoaiTaiKhoan.IsOn)
            {
                var khachHang = KhachHangDal.LayKhachHang(tbTenDangNhap.Text.ToUpper(), MyUtil.MaHoaMatKhau(tbMatKhau.Text));
                //TODO Khanh
                if (khachHang != null && khachHang.RuleDangNhap)
                {
                    Hide();
                    FChinh fChinh = new FChinh(tbTenDangNhap.Text, false);
                    fChinh.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại \nTài khoản không chính xác hoặc chưa kích hoặt", Resources.MThatBai);
                }
            }
            else
            {
                if (NhanVienDal.LayNhanVien(tbTenDangNhap.Text.ToUpper(), MyUtil.MaHoaMatKhau(tbMatKhau.Text)) != null)
                {
                    Hide();
                    FChinh fChinh = new FChinh(tbTenDangNhap.Text,true);
                    fChinh.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(Resources.TaiKhoan + Resources.khongChinhXac, Resources.MNhapLieuSai, MessageBoxButtons.OK);
                }
            }
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            if (tsLoaiTaiKhoan.IsOn)
            {
                var fTaoKhachHAng = new FTaoKhachHang();
                Hide();
                fTaoKhachHAng.ShowDialog();
                Show();
            }
            else
            {
                var fTaoNhanVien = new FTaoNhanVien();
                Hide();
                fTaoNhanVien.ShowDialog();
                Show();
            }
        }

        private void tsLoaiTaiKhoan_Toggled(object sender, EventArgs e)
        {
            Text = tsLoaiTaiKhoan.IsOn ? "Khách hàng đăng nhập" : "Nhân viên đăng nhập";
            label1.Text = tsLoaiTaiKhoan.IsOn ? Resources.MaKH : Resources.MaNV;
        }

        private void tbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
