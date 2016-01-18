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
using BanVeTau.Utils;
using DevExpress.XtraEditors.Controls;

namespace BanVeTau.GUI
{
    public partial class UCGhe : UserControl
    {
        public UCGhe()
        {
            InitializeComponent();
        }

        private void UCGhe_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            cbDoanTau.DataSource = DoanTauDal.LayTatCa();
            cbDoanTau.DisplayMember = "Name";
            cbDoanTau.ValueMember = "Id";

            cbLoaiGhe.DataSource = LoaiGheDal.LayTatCa();
            cbLoaiGhe.DisplayMember = "Ten";
            cbLoaiGhe.ValueMember = "Id";

            cbLoaiGhe.SelectedIndex = -1;
            cbDoanTau.SelectedIndex = -1;
            CapNhatListAnh();
            
        }

        private void CapNhatListAnh()
        {
            var listLoaiGhe = LoaiGheDal.LayTatCa();
            listLoaiGhe.ForEach(lg => imageListLoaiGhe.Images.Add(lg.Id.ToString(), MyUtil.ByteArrayToImage(lg.Anh)));
        }

        private void CapNhatListView()
        {
            lvGhe.Items.Clear();

            var dsLoaiGhe = DoanTauGheDal.LayTatCa(null);

            foreach (var loaiGhe in dsLoaiGhe)
            {
                for (var i = 0; i < loaiGhe.SoLuong; i++)
                {
                    lvGhe.Items.Add(new ListViewItem
                    {
                        Text = loaiGhe.DoanTauId + loaiGhe.LoaiGheId+(i+1),
                        ImageKey = loaiGhe.LoaiGheId.ToString(),
                        Tag = loaiGhe.DoanTauId +"-"+ loaiGhe.LoaiGheId +"-"+ i
                    });
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbDoanTau.SelectedIndex < 0 || cbLoaiGhe.SelectedIndex < 0)
                MessageBox.Show(Resources.MCanhBao, Resources.ChuaNhapDuCacTruongBatBuoc);
            else
            {
                DoanTauGheDal.CapNhatDoanTauLoaiGhe((string)cbDoanTau.SelectedValue, (int)cbLoaiGhe.SelectedValue,numSoLuong.Value);
                CapNhatListView();
            }
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            lbSoLuongGhe.Text = numSoLuong.Value + " ghế";
        }


        private void cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Name.Equals(cbDoanTau.Name))
                CapNhatListView();

            if (cbDoanTau.SelectedIndex < 0 || cbLoaiGhe.SelectedIndex < 0)
                return;
            var ojb = DoanTauGheDal.LayHoacTao((string)cbDoanTau.SelectedValue, (int)cbLoaiGhe.SelectedValue);
            numSoLuong.Value = ojb.SoLuong;
            lbSoLuongGhe.Text = numSoLuong.Value + " ghế";
           

        }
    }
}
