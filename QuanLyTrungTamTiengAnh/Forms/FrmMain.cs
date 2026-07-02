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
            this.btnHocVien.Click += new System.EventHandler(this.btnHocVien_Click);
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            this.btnKhoaHoc.Click += new System.EventHandler(this.btnKhoaHoc_Click);
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            this.btnDangKyHoc.Click += new System.EventHandler(this.btnDangKyHoc_Click);

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

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            // Tạo form Học viên
            QuanLyTrungTamTiengAnh.Forms.FrmHocVien hv = new QuanLyTrungTamTiengAnh.Forms.FrmHocVien();
            // Hiển thị nó
            hv.Show();
            // Ẩn form Main hiện tại
            this.Hide();
        }
        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            FrmGiaoVien gv = new FrmGiaoVien();
            gv.Show();
            this.Hide();
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            FrmKhoaHoc kh = new FrmKhoaHoc();
            kh.Show();
            this.Hide();
        }
        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            FrmLopHoc kh = new FrmLopHoc();
            kh.Show();
            this.Hide();
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTaiKhoan kh = new FrmTaiKhoan();
            kh.Show();
            this.Hide();
        }
        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            FrmDangKyHoc kh = new FrmDangKyHoc();
            kh.Show();
            this.Hide();
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