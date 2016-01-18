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
    public partial class UcBaoCaoGiaoDichTC : UserControl
    {
        public UcBaoCaoGiaoDichTC()
        {
            InitializeComponent();
        }

        private void UcBaoCaoGiaoDich_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;

            var dataDoantau = DoanTauDal.LayTatCa();
            dataDoantau.Insert(0, new DoanTau { Id = string.Empty, Name = "Tất cả" });


            cbDoanTau.DataSource = dataDoantau;
            cbDoanTau.DisplayMember = "Name";
            cbDoanTau.ValueMember = "Id";
            cbDoanTau.SelectedIndex = -1;

            cbLichTrinh.DisplayMember = "TenLichTrinh";
            cbLichTrinh.ValueMember = "Id";
        }

        private void cbDoanTau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDoanTau.SelectedIndex < 0)
                return;

            List<LichTrinh> dataLichTrinh;

            dataLichTrinh = LichTrinhDal.LayLichTrinhTheoDoanTau(cbDoanTau.SelectedValue as string, false);
            dataLichTrinh.Insert(0, new LichTrinh { Id = 0, TenLichTrinh = "Tất cả" });

            cbLichTrinh.DataSource = dataLichTrinh;
            cbLichTrinh.SelectedIndex = -1;
        }

        private void cbLichTrinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbLichTrinh.SelectedIndex < 0 || cbLichTrinh.SelectedIndex < 0)
                return;
            try
            {
                view_GiaoDichTableAdapter.Fill(veTauDataSet.View_GiaoDich, (int) cbLichTrinh.SelectedValue,
                    cbDoanTau.SelectedValue.ToString(), false);
                reportViewer1.RefreshReport();
            }
            catch
            {
                view_GiaoDichTableAdapter.Fill(veTauDataSet.View_GiaoDich, (int)cbLichTrinh.SelectedValue,
                    cbDoanTau.SelectedValue.ToString(), false);
                reportViewer1.RefreshReport();
            }

        }
    }
}
