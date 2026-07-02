using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmDangKyHoc : Form
    {
        public FrmDangKyHoc()
        {
            InitializeComponent();
            // Nối sự kiện cho picHome
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Close();
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpThongTin_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangKyHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
