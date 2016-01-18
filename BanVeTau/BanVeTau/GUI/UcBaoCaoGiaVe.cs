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
using Microsoft.Reporting.WinForms;

namespace BanVeTau.GUI
{
    public sealed partial class UcBaoCaoGiaVe : UserControl
    {
        public UcBaoCaoGiaVe()
        {
            InitializeComponent();
        }

        private void UcBaoCaoGiaVe_Load(object sender, EventArgs e)
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
            if(cbDoanTau.SelectedIndex<0)
                return;
            
            List<LichTrinh> dataLichTrinh;
            
            dataLichTrinh = LichTrinhDal.LayLichTrinhTheoDoanTau(cbDoanTau.SelectedValue as string, false);
            dataLichTrinh.Insert(0, new LichTrinh { Id = 0, TenLichTrinh = "Tất cả" });
           
            cbLichTrinh.DataSource = dataLichTrinh;
            cbLichTrinh.SelectedIndex = -1;
        }

        private void cbLichTrinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbLichTrinh.SelectedIndex<0 || cbLichTrinh.SelectedIndex < 0)
                return;
            try
            {
                view_GiaVeTableAdapter.FillBy(veTauDataSet.View_GiaVe, cbDoanTau.SelectedValue.ToString(),
                    (int) cbLichTrinh.SelectedValue);
                reportGiaVe.RefreshReport();
            }
            catch
            {
                
            }
        }
    }
}
