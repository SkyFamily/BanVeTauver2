using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeTau.Properties;

namespace BanVeTau.GUI
{
    public partial class FInputField : Form
    {
        public Type Type { get; private set; }
        public string Value { get; private set; }

        public FInputField()
        {
            InitializeComponent();
        }

        private void FInputField_Load(object sender, EventArgs e)
        {

        }

        public void CapNhat(string tieuDe, string noiDungHienThi, Type typeDuLieu, string giaTri)
        {
            Text = tieuDe;
            lbNoiDung.Text = noiDungHienThi;
            Type = typeDuLieu;
            tbValue.Text = giaTri;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (Type == typeof (int))
            {
                try
                {
                    int.Parse(tbValue.Text);
                    Value = tbValue.Text;
                }
                catch
                {
                    MessageBox.Show(Resources.MNhapLieuSai, Resources.GiaTriNhapKhongHopLe);
                    return;
                }
            }
            else
            {
                Value = tbValue.Text;
            }
            Hide();
        }
    }
}
