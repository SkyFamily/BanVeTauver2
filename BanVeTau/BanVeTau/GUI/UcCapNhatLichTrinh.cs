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
using BanVeTau.Models;
using BanVeTau.Properties;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BanVeTau.GUI
{
    public partial class UcCapNhatLichTrinh : UserControl
    {
        public UcCapNhatLichTrinh()
        {
            InitializeComponent();
        }
        private void UcCapNhatLichTrinh_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;


            cbDoanTau.DataSource = DoanTauDal.LayTatCa();
            cbDoanTau.DisplayMember = "Name";
            cbDoanTau.ValueMember = "Id";
            cbDoanTau.SelectedIndex = -1;
        }
        private void reBtnSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var lichTrinhId = (int)gridView.GetFocusedRowCellValue("Id");
            var gaCuoiId = (int)gridView.GetFocusedRowCellValue("LichTrinhTuyenDuongHienTaiId");
            var doanTauId = cbDoanTau.SelectedValue.ToString();
            if (KiemTraHopLeVaThongBao(doanTauId,lichTrinhId))
            {
                var lichTrinhTuyenDuongs = LichTrinhTuyenDuongDal.LayLichTrinh(lichTrinhId);

                for (var i = 0; i < lichTrinhTuyenDuongs.Count; i++)
                {
                    var tuyenDuong = lichTrinhTuyenDuongs[i];

                    if (i == lichTrinhTuyenDuongs.Count - 1)
                        LichTrinhDal.CapNhatTrangThai(lichTrinhId, -1);

                    LichTrinhTuyenDuongDal.CapNhatDaChayQua(tuyenDuong.Id, true);

                    if (tuyenDuong.GaTauCuoiId == gaCuoiId)
                        break;
                   
                }

                MessageBox.Show(Resources.LuuDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                CapNhatGridView();
                
            }
        }

        private bool KiemTraHopLeVaThongBao(string doanTauId, int lichTrinhId)
        {
            var lichTrinh = LichTrinhDal.Lay(lichTrinhId);

            if (lichTrinh.GioDen < DateTime.Now)
            {
                if (DialogResult.Yes == MessageBox.Show("Lịch trình này đã quá hạn, Xác nhận lịch trình này đã chạy qua", Resources.MNhapLieuSai, MessageBoxButtons.YesNoCancel))
                {
                    LichTrinhDal.CapNhatTrangThai(lichTrinhId,-1);
                    return true;
                }
            }

            var lichTrinhs = LichTrinhDal.LayLichTrinhTheoDoanTau(doanTauId, false);

            if (lichTrinhs.Any(lt => lt.TrangThai == 0 && lt.Id!= lichTrinhId))
            {
                MessageBox.Show("Đoàn tàu này đang chạy, Kết thúc lịch trình hiện tại để tiếp tục", Resources.MCanhBao);
                CapNhatGridView();
                return false;
            }

            return true;

        }

        private void cbDoanTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGridView();
        }

        private void CapNhatGridView()
        {
            if(cbDoanTau.SelectedIndex<0)
                return;
            gvExtra.DataSource = LichTrinhDal.LayTatModel(cbDoanTau.SelectedValue as string, chkLichTrinhChuaChay.Checked);

        }
    
        private void gridView_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName == "LichTrinhTuyenDuongHienTaiId")
            {
                GridView gv = sender as GridView;
                RepositoryItemRadioGroup gridRadioGroup = new RepositoryItemRadioGroup();

                var tuyenDuongs =
                    LichTrinhTuyenDuongDal.LayLichTrinh(Convert.ToInt32(gv.GetRowCellValue(e.RowHandle,
                        gv.Columns["Id"])));

                foreach (var tuyenDuong in tuyenDuongs)
                {
                    var item = new RadioGroupItem
                    {
                        Value = tuyenDuong.GaTauCuoiId,
                        Description = tuyenDuong.GaTauCuoi.Ten,
                        Enabled = !tuyenDuong.DaChayQua,
                    };
                    gridRadioGroup.Items.Add(item);
                }
                e.RepositoryItem = gridRadioGroup;

            }
        }

        private void chkLichTrinhChuaChay_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatGridView();
        }
    }
}
