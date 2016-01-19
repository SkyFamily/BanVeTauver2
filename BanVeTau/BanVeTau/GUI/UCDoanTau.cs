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
    public partial class UCDoanTau : UserControl
    {
        readonly int ChieuDaiId = 4;
        public UCDoanTau()
        {
            InitializeComponent();
        }

        private void UCDoanTau_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            CapNhatGv();

            var parentForm = (FChinh) ParentForm;
            if (parentForm != null && !parentForm.NhanVien)
            {
                panel1.Visible = false;
                gridColumnXoa.Visible = false;
                gridView.OptionsBehavior.Editable = false;
            }
            tbMa.Text = DoanTauDal.LayIdTuDong("SE",ChieuDaiId);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var doanTau = new DoanTau
            {
                Id = tbMa.Text.ToUpper().Replace(" ", ""),
                Name = tbTen.Text,
                TocDo = trckTocDo.Value,
                GhiChu = tbGhiChu.Text
            };

            if (KiemTraHopLeVaThongBao(doanTau))
            {
                if (DoanTauDal.ThemDoanTau(doanTau) > 0)
                {
                    btnLamMoi_Click(null,null);
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thanhCong, Resources.MThanhCong);                    
                }
                else
                {
                    MessageBox.Show(Resources.TaoDoiTuong + Resources.thatBai, Resources.MThatBai);
                }

            }
        }

        private void CapNhatGv()
        {
            gvExtra.DataSource = DoanTauDal.LayTatCa();
            gvExtra.RefreshDataSource();
        }

        private bool KiemTraHopLeVaThongBao(DoanTau doanTau)
        {
            if (doanTau.Name.Trim().Equals(string.Empty))
            {
                MessageBox.Show(Resources.KhongDeTrong1, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void trckTocDo_Scroll(object sender, EventArgs e)
        {
            lbTocDo.Text = "(" + trckTocDo.Value + " km/h)";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMa.Text = DoanTauDal.LayIdTuDong("SE", ChieuDaiId);
            tbTen.Text = string.Empty;
            tbGhiChu.Text = string.Empty;
            trckTocDo.Value = 30;
            lbTocDo.Text = "(30 km/h)";
            CapNhatGv();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var dem = 0;
            var doanTaus = gvExtra.DataSource as List<DoanTau>;

            if (doanTaus != null)
            {
                foreach (var doanTau in doanTaus)
                {
                    dem += DoanTauDal.CapNhatDoanTau(doanTau);
                }
            }
            MessageBox.Show(Resources.CapNhat + dem + Resources.doiTuong, Resources.MThanhCong);
        }

        private void btn_Delete_Doantau_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = gridView.GetFocusedRowCellValue("Id").ToString();

            if (!string.IsNullOrEmpty(id))
            {
                if (DoanTauDal.Xoa(id) > 0)
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
    }
}
