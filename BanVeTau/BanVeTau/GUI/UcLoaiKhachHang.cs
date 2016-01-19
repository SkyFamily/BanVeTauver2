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

namespace BanVeTau.GUI
{
    public partial class UcLoaiKhachHang : UserControl
    {
        public UcLoaiKhachHang()
        {
            InitializeComponent();
        }
       
        private void UcLoaiKhachHang_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            CapNhatGridView();
        }

        private void CapNhatGridView()
        {
            gvExtra.DataSource = LoaiKhachHangDal.LayTatCa();
            gvExtra.RefreshDataSource();
        }

        private void btn_Delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = gridView.GetFocusedRowCellValue("Id").ToString();

            if (!string.IsNullOrEmpty(id) && DialogResult.Yes == MessageBox.Show("Bạn muốn xoá đối tượng này", Resources.MCanhBao, MessageBoxButtons.YesNo))
            {
                if (LoaiKhachHangDal.Xoa(Convert.ToInt32(id)) > 0)
                {
                    MessageBox.Show(Resources.XoaDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGridView();
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
                var loaiKhachHang = new LoaiKhachHang
                {
                    Ten = tbTenLoaiKhachHang.Text,
                    HeSo = Convert.ToDouble(numericUpDown1.Value)
                };

                if (LoaiKhachHangDal.Them(loaiKhachHang) > 0)
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGridView();
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai, Resources.MThatBai);
                }

            }
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (tbTenLoaiKhachHang.Text.Equals(string.Empty))
            {
                MessageBox.Show(Resources.KhongDeTrong, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbTenLoaiKhachHang.Text = string.Empty;
            numericUpDown1.Value = 1;
            CapNhatGridView();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dem = 0;
            var listDoiTuong = gvExtra.DataSource as List<LoaiKhachHang>;

            if (listDoiTuong != null)
            {
                foreach (var doiTuong in listDoiTuong)
                {
                    dem += LoaiKhachHangDal.CapNhat(doiTuong);
                }
            }
            MessageBox.Show(Resources.CapNhat + dem + Resources.doiTuong, Resources.MThanhCong);
        }
    }
}
