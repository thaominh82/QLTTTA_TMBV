using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.Forms; // Đảm bảo namespace này chứa FrmMain

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmKhoaHoc : Form
    {
        public FrmKhoaHoc()
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
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmKhoaHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
