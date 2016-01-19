using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeTau.DAL;
using BanVeTau.Properties;
using BanVeTau.Utils;

namespace BanVeTau.GUI
{
    public partial class UCLoaiGhe : UserControl
    {
        public UCLoaiGhe()
        {
            InitializeComponent();
        }

        private void UCLoaiGhe_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            listViewLoaiGhe.MultiSelect = false;
            CapNhatGv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraHopLeVaThongBao())
            {
                var loaiGhe = new LoaiGhe
                {
                    Ten = tbTenLoaiGhe.Text,
                    Anh = MyUtil.ImageToByteArray(pbAnh.Image),
                    HeSo = (numSoLuong.Value / 10f),
                    Id = (int) tbTenLoaiGhe.Tag
                };
                if (loaiGhe.Id > 0)
                {
                    if (LoaiGheDal.CapNhatLoaiGhe(loaiGhe) > 0)
                    {
                        MessageBox.Show(Resources.CapNhat + Resources.thanhCong, Resources.MThanhCong);
                        CapNhatGv();
                        return;
                    }
                    MessageBox.Show(Resources.CapNhat + Resources.thatBai, Resources.MThatBai);
                }
                else
                {
                    if (LoaiGheDal.ThemLoaiGhe(loaiGhe) > 0)
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
        }

        private void CapNhatGv()
        {
            var listLoaiGhe  = LoaiGheDal.LayTatCa();

            listViewLoaiGhe.Items.Clear();
            imageListLoaiGhe.Images.Clear();

            for (int i = 0; i < listLoaiGhe.Count; i++)
            {
                imageListLoaiGhe.Images.Add(listLoaiGhe[i].Id.ToString(), MyUtil.ByteArrayToImage(listLoaiGhe[i].Anh));

                ListViewItem item = new ListViewItem();
                item.Text = listLoaiGhe[i].Ten +"["+listLoaiGhe[i].HeSo.ToString("F1")+"]";
                item.ImageKey = listLoaiGhe[i].Id.ToString();                
                listViewLoaiGhe.Items.Add(item);
            }
            
        }

        private bool KiemTraHopLeVaThongBao()
        {
            if (tbTenLoaiGhe.Text.Equals(string.Empty))
            {
                MessageBox.Show(Resources.KhongDeTrong, Resources.MNhapLieuSai);
                return false;
            }
            return true;
        }

        private void pbAnh_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = "Chọn icon";
            fileDialog.Filter = "icon files (*.icon, *.png)|*.icon; *.png; *.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = Bitmap.FromFile(fileDialog.FileName);
                pbAnh.Image = MyUtil.ResizeImage(image, 64,64);
            }

        }
    
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listViewLoaiGhe.SelectedItems.Count > 0 && DialogResult.Yes == MessageBox.Show("Bạn muốn xoá đối tượng này", Resources.MCanhBao, MessageBoxButtons.YesNo))
            {
                if (LoaiGheDal.XoaLoaiGhe(int.Parse(listViewLoaiGhe.SelectedItems[0].ImageKey)) > 0)
                {
                    CapNhatGv();
                    MessageBox.Show(Resources.XoaDoiTuong + Resources.thanhCong, Resources.MThanhCong);
                    
                }
                else
                {
                    MessageBox.Show(Resources.XoaDoiTuong + Resources.thatBai, Resources.MThanhCong);
                }
            }
        }
      
        private void tbTenLoaiGhe_Enter(object sender, EventArgs e)
        {
            listViewLoaiGhe.SelectedItems.Clear();
        }

        private void numSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            lbSoLuongGhe.Text = (numSoLuong.Value/10f).ToString("F1");
        }

        private void listViewLoaiGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnThem.Text = "Thêm";
            tbTenLoaiGhe.Tag = 0;
            tbTenLoaiGhe.Text = string.Empty;
            pbAnh.Image = pbAnh.InitialImage;
            numSoLuong.Value = 10;
            if (listViewLoaiGhe.SelectedItems.Count > 0)
            {
                btnXoa.Enabled = true;
                btnThem.Text = "Sửa";
                CapNhatControl(Convert.ToInt32(listViewLoaiGhe.SelectedItems[0].ImageKey));
            }
        }

        private void CapNhatControl(int id)
        {
            var selectedItem = LoaiGheDal.LayLoaiGhe(id);
            tbTenLoaiGhe.Text = selectedItem.Ten;
            pbAnh.Image = MyUtil.ByteArrayToImage(selectedItem.Anh);
            numSoLuong.Value = Convert.ToInt32(selectedItem.HeSo*10);
            tbTenLoaiGhe.Tag = selectedItem.Id;
        }
    }
}
