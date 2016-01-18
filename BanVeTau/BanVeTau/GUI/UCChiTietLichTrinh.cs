using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeTau.DAL;
using BanVeTau.Models;
using BanVeTau.Properties;
using DevExpress.XtraEditors;

namespace BanVeTau.GUI
{
    public partial class UCChiTietLichTrinh : UserControl
    {
        private List<LichTrinhTuyenDuongModelcs> listTuyenDuong;

        public UCChiTietLichTrinh()
        {
            InitializeComponent();
        }

        private void UCChiTietLichTrinh_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            listTuyenDuong = new List<LichTrinhTuyenDuongModelcs>();

            cbDoanTau.DataSource = DoanTauDal.LayTatCa();
            cbDoanTau.DisplayMember = "Name";
            cbDoanTau.ValueMember = "Id";
            cbDoanTau.SelectedIndex = -1;

            cbLichTrinh.DisplayMember = "TenLichTrinh";
            cbLichTrinh.ValueMember = "Id";

            gridGaDau.DataSource = GaTauDal.LayTatCaModel1();
            gridGaDau.DisplayMember = "Ten";
            gridGaDau.ValueMember = "Id";

            gridGaCuoi.DataSource = GaTauDal.LayTatCaModel1();
            gridGaCuoi.DisplayMember = "Ten";
            gridGaCuoi.ValueMember = "Id";

            var parentForm = (FChinh)ParentForm;
            if (parentForm != null && !parentForm.NhanVien)
            {
                btnThem.Visible = false;
                btnCapNhat.Visible = false;
                chkLichTrinhMau.Visible = false;
                gridColumnXoa.Visible = false;
                gridView.OptionsBehavior.Editable = false;
            }

        }

        private void cbDoanTau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDoanTau.SelectedIndex < 0)
                return;

            cbLichTrinh.DataSource = LichTrinhDal.LayLichTrinhTheoDoanTau((string)cbDoanTau.SelectedValue, null);
            cbLichTrinh.SelectedIndex = -1;
            cbLichTrinh.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var tuyenDuong = TuyenDuongDal.LayTuyenDuong();
                var tuyenDuongModel = new LichTrinhTuyenDuongModelcs
                {
                    LichTrinhId = (int)cbLichTrinh.SelectedValue,
                    DaChayQua = false,
                    GaTauDauId = tuyenDuong.GaTauDauId,
                    GaTauCuoiId = tuyenDuong.GaTauCuoiId,
                    GiaVe = 100000,
                    ThoiGianDung = new TimeSpan(0, 10, 0),
                    TuyenDuongId = tuyenDuong.Id,
                    KhoangCach = tuyenDuong.KhoangCach,
                };
                tuyenDuongModel.GaTauDau = GaTauDal.LayPGaTau(tuyenDuongModel.GaTauDauId);
                tuyenDuongModel.GaTauCuoi = GaTauDal.LayPGaTau(tuyenDuongModel.GaTauCuoiId);
                tuyenDuongModel.TuyenDuong = tuyenDuong;

                listTuyenDuong.Add(tuyenDuongModel);
                CapNhatGridView();
            }

        }

        private void HienThiThongTin()
        {
            if (listTuyenDuong.Count > 0)
            {
                var khoangCach = listTuyenDuong.Where(t => t.TuyenDuong.Id != 0).Sum(t => t.TuyenDuong.KhoangCach);
                lbTongTien.Text = "Giá vé:        " + listTuyenDuong.Sum(t => t.GiaVe).ToString("C");
                lbKhoangCach.Text = "Khoảng cách:   " + khoangCach;

                if (cbDoanTau != null)
                    lbThoiGianToi.Text = "Ngày kết thúc: " +
                                         DateTime.Now.AddDays(listTuyenDuong.Sum(t => t.ThoiGianDung.TotalDays) +
                                                              khoangCach / (((DoanTau)cbDoanTau.SelectedItem).TocDo * 24))
                                             .ToString("dd/MM/yyyy HH:mm");
            }         
        }

        private bool KiemTraTuyenDuongVaHienThi(bool baoLoi)
        {
            var result = true;
            var lbTuyenDuongText = new StringBuilder(" || ");

            for (int i = 0; i < listTuyenDuong.Count; i++)
            {
                var tuyenDuong = listTuyenDuong[i];
                if (i == 0)
                {
                    if (!tuyenDuong.GaTauCuoiId.Equals(tuyenDuong.GaTauDauId))
                    {
                        lbTuyenDuongText.Append(tuyenDuong.GaTauDau.Ten).Append(" >> ").Append(tuyenDuong.GaTauCuoi.Ten);
                        continue;
                    }

                    result = false;
                    if (baoLoi)
                        MessageBox.Show("Tuyến đường " + (i + 1) + " ga đầu và ga cuối không thể giống nhau");
                    break;
                }

                if (listTuyenDuong[i - 1].GaTauCuoiId.Equals(tuyenDuong.GaTauDauId) && !tuyenDuong.GaTauCuoiId.Equals(tuyenDuong.GaTauDauId))
                {
                    lbTuyenDuongText.Append(" >> ").Append(tuyenDuong.GaTauCuoi.Ten);
                }
                else
                {
                    if (baoLoi)
                        MessageBox.Show("Tuyến đường " + (i + 1) + " không tạo thành chuổi, hoặc không là 2 ga riêng biệt");
                    result = false;
                    break;
                }
            }
            
            lbLichTrinh.Text = lbTuyenDuongText.Append(" || ").ToString();
            lbLichTrinh.ForeColor = result ? Color.DarkGreen : Color.DarkRed;

            return result;
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (cbLichTrinh.SelectedIndex<0)
            {
                MessageBox.Show(Resources.ChuaNhapDuCacTruongBatBuoc, Resources.MNhapLieuSai);
                return false;
            }
            if (TuyenDuongDal.LayTuyenDuong()==null)
            {
                MessageBox.Show(Resources.KhongTonTaiTuyenDuong, Resources.MNhapLieuSai);
                return false;
            }
           
            return true;
        }

        private void CapNhatGridView()
        {
            gvExtra.DataSource = listTuyenDuong;
            gvExtra.RefreshDataSource();

            KiemTraTuyenDuongVaHienThi(false);

            HienThiThongTin();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao() && KiemTraTuyenDuongVaHienThi(true))
            {
                for (var i = 0 ; i<listTuyenDuong.Count; i++)
                {
                    var tuyenDuongModel = listTuyenDuong[i];

                    if (tuyenDuongModel.TuyenDuongId == 0)
                    {
                        var fInput = new FInputField();
                        fInput.CapNhat("Thêm thuyến đường.","Tuyến đường " + tuyenDuongModel.GaTauDau.Ten+" - "+ tuyenDuongModel.GaTauCuoi.Ten +" không tồn tại.\n Nhập vào giá trị khoảng cách để thêm mới",typeof(int),"0");
                        fInput.ShowDialog();

                        int value;

                        try
                        {
                            value = int.Parse(fInput.Value);
                        }
                        catch
                        {
                            MessageBox.Show(Resources.MNhapLieuSai, Resources.TaoDoiTuong + Resources.thatBai);
                            return;
                        }

                        var tuyenDuong = new TuyenDuong
                        {
                            GaTauDauId = tuyenDuongModel.GaTauDauId,
                            GaTauCuoiId = tuyenDuongModel.GaTauCuoiId,
                            KhoangCach = value
                        };

                        TuyenDuongDal.ThemTuyenDuong(tuyenDuong);

                        listTuyenDuong[i].TuyenDuong = tuyenDuong;
                        listTuyenDuong[i].TuyenDuongId = tuyenDuong.Id;
                        listTuyenDuong[i].GaTauDauId = tuyenDuong.GaTauDauId;
                        listTuyenDuong[i].GaTauCuoiId = tuyenDuong.GaTauCuoiId;
                    }
                }

                var result = LichTrinhTuyenDuongDal.CapNhatLichTrinhTuyenDuong((int)cbLichTrinh.SelectedValue , listTuyenDuong);

                if (chkLichTrinhMau.Checked)
                {
                    result = LichTrinhTuyenDuongDal.CapNhatLichTrinhTuyenDuongMau(cbDoanTau.SelectedValue.ToString(), "[Mẫu] "+cbLichTrinh.Text,listTuyenDuong);
                }

                MessageBox.Show(Resources.MThanhCong,
                    Resources.LuuDoiTuong + (result ? Resources.thanhCong : Resources.thatBai));

                if (result)
                    cbDoanTau_SelectionChangeCommitted(null,null);
            }
            
        }
     

        private void btnGridDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var id = (int)gridView.GetFocusedRowCellValue("Id");
            var lichTrinhTuyenDuong = LichTrinhTuyenDuongDal.LayLichTrinhTuyenDuong(id);
            if (lichTrinhTuyenDuong.DaChayQua)
            {
                MessageBox.Show("Tuyến đường này đã chạy qua, không thể sửa lịch trình", Resources.MThatBai);
                return;
            }

            listTuyenDuong.RemoveAt(gridView.FocusedRowHandle);
            CapNhatGridView();
            HienThiThongTin();
        }

        private void gridGaDau_EditValueChanged(object sender, EventArgs e)
        {
            var gaTauDauId = (int)((GridLookUpEdit)sender).EditValue;
            var gaTauCuoiId = (int)gridView.GetFocusedRowCellValue("GaTauCuoiId");
            
            var tuyenDuong = TuyenDuongDal.LayTuyenDuong(gaTauDauId,gaTauCuoiId) ?? new TuyenDuong
            {
                GaTauDauId = gaTauDauId,
                GaTauCuoiId = gaTauCuoiId,
                KhoangCach = 0,
            };

            var tuyenDuongModel = new LichTrinhTuyenDuongModelcs
            {
                LichTrinhId = (int)cbLichTrinh.SelectedValue,
                DaChayQua = false,
                GaTauDauId = gaTauDauId,
                GaTauCuoiId = gaTauCuoiId,
                TuyenDuongId = tuyenDuong.Id,
                GiaVe = 100000,
                ThoiGianDung = new TimeSpan(0, 10, 0),

            };

            tuyenDuongModel.GaTauDau = GaTauDal.LayPGaTau(tuyenDuongModel.GaTauDauId);
            tuyenDuongModel.GaTauCuoi = GaTauDal.LayPGaTau(tuyenDuongModel.GaTauCuoiId);
            tuyenDuongModel.TuyenDuong = tuyenDuong;

            listTuyenDuong[gridView.FocusedRowHandle] = tuyenDuongModel;

            KiemTraTuyenDuongVaHienThi(false);

        }

        private void gridGaCuoi_EditValueChanged(object sender, EventArgs e)
        {
            var gaTauDauId = (int)gridView.GetFocusedRowCellValue("GaTauDauId");
            var gaTauCuoiId = (int)((GridLookUpEdit)sender).EditValue;

            var tuyenDuong = TuyenDuongDal.LayTuyenDuong(gaTauDauId, gaTauCuoiId) ?? new TuyenDuong
            {
                GaTauDauId = gaTauDauId,
                GaTauCuoiId = gaTauCuoiId,
                KhoangCach = 0,
            };

            var tuyenDuongModel = new LichTrinhTuyenDuongModelcs
            {
                LichTrinhId = (int)cbLichTrinh.SelectedValue,
                DaChayQua = false,
                GaTauDauId = gaTauDauId,
                GaTauCuoiId = gaTauCuoiId,
                TuyenDuongId = tuyenDuong.Id,
                GiaVe = 100000,
                ThoiGianDung = new TimeSpan(0, 10, 0)
            };

            tuyenDuongModel.GaTauDau = GaTauDal.LayPGaTau(tuyenDuongModel.GaTauDauId);
            tuyenDuongModel.GaTauCuoi = GaTauDal.LayPGaTau(tuyenDuongModel.GaTauCuoiId);
            tuyenDuongModel.TuyenDuong = tuyenDuong;

            listTuyenDuong[gridView.FocusedRowHandle] = tuyenDuongModel;

            KiemTraTuyenDuongVaHienThi(false);
        }

        private void cbLichTrinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbLichTrinh.SelectedIndex < 0)
                return;

            var lichTrinh = cbLichTrinh.SelectedItem as LichTrinh;
            if (lichTrinh != null)
            {
                chkLichTrinhMau.Enabled = !lichTrinh.LichTrinhMau;
                chkLichTrinhMau.Checked = false;

                dtNgayKhoiHanh.Value = lichTrinh.GioChay;
                dtNgayDenNoi.Value = lichTrinh.GioDen;

                listTuyenDuong = LichTrinhTuyenDuongDal.LayLichTrinh(lichTrinh.Id);
               
                btnCapNhat.Enabled = lichTrinh.TrangThai != -1;
                btnThem.Enabled = lichTrinh.TrangThai != -1;
                
            }

            CapNhatGridView();
        }

       
    }
}
