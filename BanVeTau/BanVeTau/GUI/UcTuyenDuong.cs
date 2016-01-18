using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeTau.DAL;
using BanVeTau.Properties;

namespace BanVeTau.GUI
{
    public partial class UcTuyenDuong : UserControl
    {
        public UcTuyenDuong()
        {
            InitializeComponent();
        }

        private void UcTuyenDuong_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            cbGaDau.DataSource = GaTauDal.LayTatCa();
            cbGaDau.DisplayMember = "Ten";
            cbGaDau.ValueMember = "Id";
            cbGaDau.SelectedIndex = -1;


            cbGaCuoi.DataSource = GaTauDal.LayTatCa();
            cbGaCuoi.DisplayMember = "Ten";
            cbGaCuoi.ValueMember = "Id";
            cbGaCuoi.SelectedIndex = -1;

            cbgidGaTauDau.DataSource = GaTauDal.LayTatCaModel1();
            cbgidGaTauDau.ValueMember = "Id";
            cbgidGaTauDau.DisplayMember = "Ten";

            cbgidGaTauCuoi.DataSource = GaTauDal.LayTatCaModel1();
            cbgidGaTauCuoi.ValueMember = "Id";
            cbgidGaTauCuoi.DisplayMember = "Ten";

            CapNhatGv();


            var parentForm = (FChinh)ParentForm;
            if (parentForm != null && !parentForm.NhanVien)
            {
                panel1.Visible = false;
                gridColumnXoa.Visible = false;
                gridColumnLuu.Visible = false;
                gvObject.OptionsBehavior.Editable = false;
            }
    }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao((int?) cbGaDau.SelectedValue, (int?) cbGaCuoi.SelectedValue, true))
            {
                var tuyenDuong = new TuyenDuong
                {
                    GaTauDauId = (int) cbGaDau.SelectedValue,
                    GaTauCuoiId = (int) cbGaCuoi.SelectedValue,
                    KhoangCach = int.Parse(numKhoangCach.Value.ToString(CultureInfo.InvariantCulture))
                };

                if (TuyenDuongDal.ThemTuyenDuong(tuyenDuong) > 0)
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
            gvExtra.DataSource = TuyenDuongDal.LayTatCa();
            gvExtra.RefreshDataSource();
        }

        private bool KiemTraHopLeVaThongBao(int? gaDauId, int? gaCuoiId, bool isNew)
        {
            if (gaDauId == null || gaCuoiId == null)
            {
                MessageBox.Show(Resources.ChuaNhapDuCacTruongBatBuoc, Resources.MNhapLieuSai);
                return false;
            }
            if (gaDauId == gaCuoiId)
            {
                MessageBox.Show(Resources.GiaTriNhapKhongHopLe, Resources.MNhapLieuSai);
                return false;
            }
            if (isNew && TuyenDuongDal.LayTuyenDuong(gaDauId.Value, gaCuoiId.Value) != null)
            {
                MessageBox.Show(Resources.DoiTuongDaTonTai, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void btGridSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = (int)gvObject.GetFocusedRowCellValue("Id");
            var gaTauDauId = (int) gvObject.GetFocusedRowCellValue("GaTauDauId");
            var gaTauCuoiId = (int) gvObject.GetFocusedRowCellValue("GaTauCuoiId");
            var khoangCach = (int) gvObject.GetFocusedRowCellValue("KhoangCach");

            if (KiemTraHopLeVaThongBao(gaTauDauId, gaTauCuoiId,false))
            {
                var obj = new TuyenDuong
                {
                    Id = id,
                    GaTauDauId = gaTauDauId,
                    GaTauCuoiId = gaTauCuoiId,
                    KhoangCach = khoangCach
                };
                if (TuyenDuongDal.CapNhatTuyenDuong(obj) > 0)
                {
                    MessageBox.Show(Resources.LuuDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    CapNhatGv();
                }
                else
                {
                    MessageBox.Show(Resources.LuuDoiTuong + Resources.thatBai, Resources.MThatBai);
                }
            }
        }

        private void btnGridDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = (int) gvObject.GetFocusedRowCellValue("Id");

            if (TuyenDuongDal.XoaTuyenDuong(id) > 0)
            {
                MessageBox.Show(Resources.XoaDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                CapNhatGv();
            }
            else
            {
                MessageBox.Show(Resources.XoaDoiTuong + Resources.thatBai, Resources.MThatBai);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbGaDau.SelectedIndex = -1;
            cbGaCuoi.SelectedIndex = -1;
            CapNhatGv();
        }
    }
}
