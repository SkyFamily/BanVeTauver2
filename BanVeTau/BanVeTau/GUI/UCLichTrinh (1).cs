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
    public partial class UCLichTrinh : UserControl
    {
        public UCLichTrinh()
        {
            InitializeComponent();
        }

        private void UCLichTrinh_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            cbDoanTau.DataSource = DoanTauDal.LayTatCa();
            cbDoanTau.DisplayMember = "Name";
            cbDoanTau.ValueMember = "Id";
            cbDoanTau.SelectedIndex = -1;

            dtNgayKhoiHanh.MinDate = DateTime.Now;
            dtNgayDenNoi.MinDate = DateTime.Now;

            cbLichTrinhMau.DisplayMember = "TenLichTrinh";
            cbLichTrinhMau.ValueMember = "Id";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao(0,cbDoanTau.SelectedValue as string,tbTenLichTrinh.Text,dtNgayKhoiHanh.Value, dtNgayDenNoi.Value,true,null ))
            {
                var lichTrinh = new LichTrinh
                {
                    TenLichTrinh = tbTenLichTrinh.Text,
                    DoanTauId = cbDoanTau.SelectedValue as string,
                    GioChay = dtNgayKhoiHanh.Value,
                    GioDen = dtNgayDenNoi.Value,
                    LichTrinhMau = false,
                    TrangThai = 1
                    
                };


                if (LichTrinhDal.Them(lichTrinh) > 0)
                {
                    if (chkThemChiTiet.Checked)
                    {
                        var listTuyenDuong = LichTrinhTuyenDuongDal.LayLichTrinh((int) cbLichTrinhMau.SelectedValue);
                        LichTrinhTuyenDuongDal.CapNhatLichTrinhTuyenDuong(lichTrinh.Id, listTuyenDuong);
                    }

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
            if (cbDoanTau.SelectedIndex < 0)
                return;
            gvExtra.DataSource = LichTrinhDal.LayTatCa(cbDoanTau.SelectedValue as string,false);
            gvExtra.RefreshDataSource();
        }

        private bool KiemTraHopLeVaThongBao(int id,string doanTauId,string tenLichTrinh, DateTime gioChay, DateTime gioDen,bool isNew,int? trangThai)
        {
            if (string.IsNullOrEmpty(doanTauId))
            {
                MessageBox.Show(Resources.ChuaNhapDuCacTruongBatBuoc, Resources.MNhapLieuSai);
                return false;
            }
            if (tenLichTrinh.Trim().Equals(string.Empty))
            {
                MessageBox.Show(Resources.KhongDeTrong, Resources.MNhapLieuSai);
                return false;
            }

            var lichTrinhXungDot = LichTrinhDal.LayLichTrinhTrongNgay(id,doanTauId, gioChay);

            if (lichTrinhXungDot != null)
            {
                MessageBox.Show(Resources.LichTrinhThoiGianGioDiXungDot + lichTrinhXungDot.TenLichTrinh, Resources.MNhapLieuSai);
                return false;
            }

            lichTrinhXungDot = LichTrinhDal.LayLichTrinhTrongNgay(id,doanTauId, gioDen);

            if (lichTrinhXungDot != null)
            {
                MessageBox.Show(Resources.LichTrinhThoiGianGioDenXungDot + lichTrinhXungDot.TenLichTrinh, Resources.MNhapLieuSai);
                return false;
            }
            if (!isNew)
            {
                if (trangThai < 1)
                {
                    MessageBox.Show(tenLichTrinh + Resources.khongTheSua, Resources.MNhapLieuSai);
                    return false;
                }
                if (gioChay >= gioDen)
                {
                    MessageBox.Show(tenLichTrinh + Resources.khongChinhXac , Resources.MNhapLieuSai);
                    return false;
                }
                if (gioChay <= DateTime.Now)

                {
                    MessageBox.Show(tenLichTrinh + Resources.khongChinhXac , Resources.MNhapLieuSai);
                    return false;
                }
            }
            return true;
        }

        private void cbDoanTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGv();

            cbLichTrinhMau.DataSource = LichTrinhDal.LayLichTrinhTheoDoanTau(cbDoanTau.SelectedValue as string, true);
            cbLichTrinhMau.SelectedIndex = -1;
            cbLichTrinhMau.ResetText();

        }

        private void btGridSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = (int)gridView.GetFocusedRowCellValue("Id");
            var doanTauId = (string)gridView.GetFocusedRowCellValue("DoanTauId");
            var gioChay = (DateTime)gridView.GetFocusedRowCellValue("GioChay");
            var gioDen = (DateTime)gridView.GetFocusedRowCellValue("GioDen");
            var tenLichTrinh = (string)gridView.GetFocusedRowCellValue("TenLichTrinh");
            var trangThai = (int)gridView.GetFocusedRowCellValue("TrangThai");

            if (KiemTraHopLeVaThongBao(id,doanTauId, tenLichTrinh, gioChay, gioDen, false,trangThai))
            {
                var obj = new LichTrinh
                {
                    Id = id,
                    DoanTauId = doanTauId,
                    GioDen = gioDen,
                    GioChay = gioChay,
                    TenLichTrinh = tenLichTrinh,
                    TrangThai = trangThai,
                    LichTrinhMau = false
                };
                if (LichTrinhDal.CapNhat(obj) > 0)
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
            var id = (int)gridView.GetFocusedRowCellValue("Id");
           
            if (LichTrinhDal.Xoa(id) > 0)
            {
                MessageBox.Show(Resources.XoaDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                CapNhatGv();
            }
            else
            {
                MessageBox.Show(Resources.XoaDoiTuong + Resources.thatBai, Resources.MThatBai);
            }
            
        }

        private void dtGridGioChay_DateTimeChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbDoanTau.SelectedIndex = -1;
            tbTenLichTrinh.Text = string.Empty;
            dtNgayKhoiHanh.Value = dtNgayKhoiHanh.MinDate;

            chkThemChiTiet.Enabled = false;
            btnXoaLichTrinhMau.Enabled = false;
        }

        private void dtNgayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            dtNgayDenNoi.MinDate = dtNgayKhoiHanh.Value;
        }

        private void cbLichTrinhMau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chkThemChiTiet.Enabled = true;
            btnXoaLichTrinhMau.Enabled = true;
        }

        private void btnXoaLichTrinhMau_Click(object sender, EventArgs e)
        {
            if(cbLichTrinhMau.SelectedIndex<0)
                return;
            if(LichTrinhDal.Xoa((int) cbLichTrinhMau.SelectedValue)>0)
                MessageBox.Show(Resources.MThanhCong,Resources.XoaDoiTuong + Resources.thanhCong);
            else
            {
                MessageBox.Show(Resources.MThanhCong, Resources.XoaDoiTuong + Resources.thanhCong);
            }


        }
    }
}
