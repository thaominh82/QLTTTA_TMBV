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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chartThongKe.Series["Series1"].Points.Clear();

            chartThongKe.Series["Series1"].Points.AddXY("Tháng 2", 120);
            chartThongKe.Series["Series1"].Points.AddXY("Tháng 3", 150);
            chartThongKe.Series["Series1"].Points.AddXY("Tháng 4", 140);
            chartThongKe.Series["Series1"].Points.AddXY("Tháng 5", 180);
            chartThongKe.Series["Series1"].Points.AddXY("Tháng 6", 256); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpDateTime.Value = DateTime.Now;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
        }

        private void pnlThongBao_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chartThongKe_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}