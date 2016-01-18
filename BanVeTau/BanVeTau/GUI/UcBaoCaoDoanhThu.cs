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

namespace BanVeTau.GUI
{
    public partial class UcBaoCaoDoanhThu : UserControl
    {
        public UcBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void UcBaoCaoDoanhThuTC_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var dataDoantau = DoanTauDal.LayTatCa();
            dataDoantau.Insert(0, new DoanTau { Id = string.Empty, Name = "Tất cả" });


            cbDoanTau.DataSource = dataDoantau;
            cbDoanTau.DisplayMember = "Name";
            cbDoanTau.ValueMember = "Id";
            cbDoanTau.SelectedIndex = -1;
           
        }

        private void cbDoanTau_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cbDoanTau.SelectedIndex < 0)
                return;

            view_DoanhThuTableAdapter.Fill(veTauDataSet.View_DoanhThu, cbDoanTau.SelectedValue.ToString(),tbNam.Text.Trim(), tbThang.Text.Trim());
            reportViewer1.RefreshReport();
        }
    }
}