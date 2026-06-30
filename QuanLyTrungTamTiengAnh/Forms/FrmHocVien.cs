using System;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.DAL; // Đảm bảo đã có namespace này

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmHocVien : Form
    {
        // 1. Khai báo biến DAL ở đây (trong class, ngoài các hàm)
        HocVienDAL hvDAL = new HocVienDAL();

        public FrmHocVien()
        {
            InitializeComponent();
        }

        private void FrmHocVien_Load(object sender, EventArgs e)
        {
            // 2. Gọi code trong hàm Load
            dgvLopHoc.AutoGenerateColumns = false;
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            dgvLopHoc.DataSource = hvDAL.LayDanhSach();

            // Các label phải nằm trong class FrmHocVien thì mới nhận diện được
            lblTong.Text = hvDAL.DemHocVien("").ToString();
            lblDangHoc.Text = hvDAL.DemHocVien("WHERE TrangThai = N'Đang học'").ToString();
            lblHoanThanh.Text = hvDAL.DemHocVien("WHERE TrangThai = N'Hoàn thành'").ToString();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Close();
        }
    }
}