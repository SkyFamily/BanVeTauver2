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
    public partial class UcPhongBan : UserControl
    {
        const int ChieuDaiId = 3;
        public UcPhongBan()
        {
            InitializeComponent();
        }

        private void UCPhongBan_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            CapNhatGvPhongBan();
        }

        private void CapNhatGvPhongBan()
        {
            gvextraPhongBan.DataSource = PhongBanDal.LayTatCa();
            gvextraPhongBan.RefreshDataSource();
        }

        private void btn_Delete_Phongban_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = gvPhongBan.GetFocusedRowCellValue("Id").ToString();

            if(id.Equals("ADMIN"))
            {
                MessageBox.Show("Không được xóa phòng quản trị", Resources.MThatBai);
                return;
            }

            if (!string.IsNullOrEmpty(id) && DialogResult.Yes == MessageBox.Show("Bạn muốn xoá đối tượng này", Resources.MCanhBao, MessageBoxButtons.YesNo))
            {
                if (PhongBanDal.XoaPhongBan(id) > 0)
                {
                    MessageBox.Show(Resources.XoaDoiTuong +Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGvPhongBan();
                }
                else
                {
                    MessageBox.Show(Resources.XoaDoiTuong+Resources.thatBai, Resources.MThatBai);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var phongBan = new PhongBan
                {
                    Id = tbMaPhongBan.Text.ToUpper(),
                    TenPhongBan = tbTenPhongBan.Text
                };
               
                if (PhongBanDal.ThemPhongBan(phongBan)>0)
                {
                    MessageBox.Show(Resources.TaoDoiTuong +Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGvPhongBan();
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong +Resources.thatBai, Resources.MThatBai);
                }

            }
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if ( tbMaPhongBan.Text.Length >= ChieuDaiId)
            {
                MessageBox.Show(Resources.MaPhongBan + "tối đa" + ChieuDaiId + Resources.kyTu, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaPhongBan.Text = string.Empty;
            tbTenPhongBan.Text = string.Empty;
            CapNhatGvPhongBan();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dem = 0;
            var phongBans = gvPhongBan.DataSource as List<PhongBan>;

            if (phongBans != null)
                foreach (var phongBan in phongBans)
                {
                    dem+=PhongBanDal.CapNhatPhongBan(phongBan);
                }
            MessageBox.Show(Resources.CapNhat+dem+Resources.doiTuong, Resources.MThanhCong);
        }
    }
}
