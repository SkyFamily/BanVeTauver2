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
    public partial class UCGaTau : UserControl
    {
        public UCGaTau()
        {
            InitializeComponent();
        }

        private void UCGaTau_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            CapNhatGv();

            var parentForm = (FChinh)ParentForm;
            if (parentForm != null && !parentForm.NhanVien)
            {
                panel1.Visible = false;
                gridColumnXoa.Visible = false;
                gvNhaGa.OptionsBehavior.Editable = false;
            }
        }

        private void btn_Delete_Phongban_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = Convert.ToInt32(gvNhaGa.GetFocusedRowCellValue("Id"));

            if (id!=0 && DialogResult.Yes == MessageBox.Show("Bạn muốn xoá đối tượng này", Resources.MCanhBao, MessageBoxButtons.YesNo))
            {
                if (GaTauDal.XoaGaTau(id) > 0)
                {
                    MessageBox.Show(Resources.XoaDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGv();
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
                var gaTau = new GaTau
                {
                    Ten = tbTenNhaGa.Text,
                    DiaChi = tbDiaChi.Text
                };

                if (GaTauDal.ThemGaTau(gaTau) > 0)
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGv();
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai, Resources.MThatBai);
                }

            }
        }

        private void CapNhatGv()
        {
            gvextraNhaGa.DataSource = GaTauDal.LayTatCa();
            gvextraNhaGa.RefreshDataSource();
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (tbTenNhaGa.Text.Equals(string.Empty))
            {
                MessageBox.Show(Resources.KhongDeTrong, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbTenNhaGa.Text = string.Empty;
            tbDiaChi.Text = string.Empty;
            CapNhatGv();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dem = 0;
            var gaTaus = gvextraNhaGa.DataSource as List<GaTau>;

            if (gaTaus != null)
            {
                foreach (var gaTau in gaTaus)
                {
                    dem += GaTauDal.CapNhatGaTau(gaTau);
                }
            }
            MessageBox.Show(Resources.CapNhat + dem + Resources.doiTuong, Resources.MThanhCong);
        }
    }
}
