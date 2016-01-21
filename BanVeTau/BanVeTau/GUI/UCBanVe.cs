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
using BanVeTau.Models;
using BanVeTau.Properties;
using BanVeTau.Utils;

namespace BanVeTau.GUI
{
    public partial class UcBanVe : UserControl
    {
        internal List<LichTrinhTuyenDuongModelcs> SelectedListTuyenDuong { get; private set; }

        public UcBanVe()
        {
            InitializeComponent();
            gridControl.DataSource = new List<GheModel>();
            lbDoanTau.Text = "";
            
        }

        private void UCBanVe_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            cbGaDi.DataSource = GaTauDal.LayTatCa();
            cbGaDi.DisplayMember = "Ten";
            cbGaDi.ValueMember = "Id";
            cbGaDi.SelectedIndex = -1;


            cbGaDen.DataSource = GaTauDal.LayTatCa();
            cbGaDen.DisplayMember = "Ten";
            cbGaDen.ValueMember = "Id";
            cbGaDen.SelectedIndex = -1;

            cbLichTrinh.DisplayMember = "TenLichTrinh";
            cbLichTrinh.ValueMember = "Id";

            var listLoaiGhe = LoaiGheDal.LayTatCa();
            listLoaiGhe.Insert(0, new LoaiGhe { Id = 0, Ten = "Tất cả" });

            cbLoaiGhe.DataSource = listLoaiGhe;
            cbLoaiGhe.DisplayMember = "Ten";
            cbLoaiGhe.ValueMember = "Id";
            cbLoaiGhe.SelectedIndex = 0;

            cbLichTrinh.DataSource = new List<LichTrinh>();

            SelectedListTuyenDuong = new List<LichTrinhTuyenDuongModelcs>();

            CapNhatListAnh();

        }

        private void CapNhatListAnh()
        {
            var listLoaiGhe = LoaiGheDal.LayTatCa();
            listLoaiGhe.ForEach(lg => imageListLoaiGhe.Images.Add(lg.Id.ToString(), MyUtil.ByteArrayToImage(lg.Anh)));
        }
        private void cbGaDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatLichTrinh();
        }

        private void cbGaDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatLichTrinh();
        }

        private void dtNgayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            CapNhatLichTrinh();
        }

        private void CapNhatLichTrinh()
        {
            if (cbGaDi.SelectedIndex < 0 || cbGaDen.SelectedIndex < 0)
            {
                return;
            }
            var listLichTrinh = LichTrinhDal.LayLichTrinhTheoGaDenVaDi(int.Parse(cbGaDi.SelectedValue.ToString()),
               int.Parse(cbGaDen.SelectedValue.ToString()), dtNgayKhoiHanh.Value);

            

            cbLichTrinh.DataSource = listLichTrinh;
           
            if (listLichTrinh.Count > 0)
            {
                cbLichTrinh.SelectedIndex = 0;
            }
            else
            {
                cbLichTrinh.SelectedIndex = -1;
                SelectedListTuyenDuong = new List<LichTrinhTuyenDuongModelcs>();
                CapNhatDanhSachGhe();
            }
        }

        private void cbLichTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListTuyenDuong =
                LichTrinhTuyenDuongDal.LayTuyenDuongTheoLichTrinhGaDauGaCuoi(cbLichTrinh.SelectedValue as int? ?? 0,
                    cbGaDi.SelectedValue as int? ?? 0, cbGaDen.SelectedValue as int? ?? 0);
            
            
            CapNhatDanhSachGhe();
        }

        private void cbLoaiGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatDanhSachGhe();
        }

        private void CapNhatDanhSachGhe()
        {
            if (SelectedListTuyenDuong == null || SelectedListTuyenDuong.Count < 1)
            {
                gridControl.DataSource = new List<GheModel>();
                return;
            }

            var ghes = new List<GheModel>();

            var dsLoaiGhe = DoanTauGheDal.LayTatCa(null);

            

            if (cbLoaiGhe.SelectedIndex != 0)
            {
                dsLoaiGhe = DoanTauGheDal.LayTatCa(cbLoaiGhe.SelectedValue as int? ?? 0);
            }

            foreach (var loaiGhe in dsLoaiGhe)
            {
                for (var i = 0; i < loaiGhe.SoLuong; i++)
                {
                    var lg = LoaiGheDal.LayLoaiGhe(loaiGhe.LoaiGheId);

                    var ghe = new GheModel
                    {
                        Anh = imageListLoaiGhe.Images[imageListLoaiGhe.Images.IndexOfKey(loaiGhe.LoaiGheId.ToString())],
                        LoaiGheId = loaiGhe.LoaiGheId,
                        GhiChu = string.Empty,
                        Ten = lg.Ten,
                        DaDuocDat = false,
                        CoTheDat = true,
                        HeSo = lg.HeSo,
                        SoShe = i,
                        HuyGhe = false,
                        MaGhe = "LT" + cbLichTrinh.SelectedValue + "-" + loaiGhe.LoaiGheId + (i + 1),
                        KhachHangId = "NaN"

                    };
                    ghe.MaGhe = "LT" + cbLichTrinh.SelectedValue + "-" + loaiGhe.LoaiGheId + (i+1);
                    ghe.SoTien = SelectedListTuyenDuong.Sum(t => t.GiaVe)*ghe.HeSo;
                    ghe.TenKhachHang = "Ghế trống";
                  
                    var listGiaoDich = GiaoDichDal.LayGiaoDichTrenTuyenDuong(false,loaiGhe.LoaiGheId, i,
                        SelectedListTuyenDuong.Select(td=>td.Id).ToList());

                    if (listGiaoDich.Count > 0)
                    {
                        var khs = KhachHangDal.Lay(listGiaoDich.Select(gd=>gd.KhachHangId).ToList());
                        ghe.TenKhachHang = string.Join(",", khs.Select(kh => kh.Id).ToList());
                        ghe.CoTheDat = false;
                        ghe.SoTien = listGiaoDich.Sum(gd=>gd.SoTien);
                    }
                    ghes.Add(ghe);
                }
            }
            
            gridControl.DataSource = ghes;
        }

        private void btnDatGhe_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLeVaThongBao())
                return;

            var dataSource = tileView.DataSource as List<GheModel>;

            if (dataSource != null)
            {
                var dsGhe = dataSource.Where(g => g.DaDuocDat).ToList();

                foreach (var ghe in dsGhe)
                {
                    var fChinh = ParentForm as FChinh;

                    if (fChinh != null)
                    {
                        var nhanVienId = fChinh.UserId;
                        var fCapNhatThongTin = new FCapNhatThongTinVe(SelectedListTuyenDuong, ghe, nhanVienId);

                        fCapNhatThongTin.ShowDialog();

                        CapNhatLichTrinh();
                    }

                }
            }
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (SelectedListTuyenDuong.Count < 1)
                return false;

            var dsGhe = tileView.DataSource as List<GheModel>;

            if (dsGhe==null ||!dsGhe.Any(g=>g.DaDuocDat))
            {
                MessageBox.Show(Resources.MNhapLieuSai, Resources.BanChuaChonGheDeDatVe);
                return false;
            }

            var lichTrinh = LichTrinhDal.Lay((int) cbLichTrinh.SelectedValue);
            var listTuyenDuong = LichTrinhTuyenDuongDal.LayLichTrinh(lichTrinh.Id);
            var tuyenDuongDau = listTuyenDuong.SingleOrDefault(gd => gd.GaTauDauId == (int)cbLichTrinh.SelectedValue);
            if (lichTrinh.GioDen < DateTime.Now)
            {
                MessageBox.Show(Resources.MCanhBao, "Chuyến tàu này đã kết thúc vào thời gian hiện tại");
                return false;
            }
            if (tuyenDuongDau != null && tuyenDuongDau.DaChayQua)
            {
                MessageBox.Show(Resources.MCanhBao, "Da chạy qua ga này không thể đặt vé");
                return false;
            }

            return true;
        }
    }

}
