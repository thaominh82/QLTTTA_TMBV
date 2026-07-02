using System;
using System.Data;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.DAL.Classes;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmGiaoVien : Form
    {
        private IGiaoVienDAL giaoVienDAL = new GiaoVienDAL();

        public FrmGiaoVien()
        {
            InitializeComponent();

            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            DataTable dt = giaoVienDAL.LayDanhSachGiaoVien();

            // In ra danh sách tên cột thực sự mà C# nhận được từ SQL
            string columns = "";
            foreach (DataColumn col in dt.Columns)
            {
                columns += col.ColumnName + ", ";
            }
            MessageBox.Show("Các cột trong DataTable là: " + columns);

            dgvLopHoc.AutoGenerateColumns = false;
            dgvLopHoc.DataSource = dt;
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Close();
        }

        // --- XỬ LÝ DỮ LIỆU ---

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Vì không dùng TextBox, hãy thông báo hướng dẫn người dùng
            MessageBox.Show("Hãy thêm dữ liệu trực tiếp vào một dòng trống trên bảng, sau đó hệ thống sẽ lưu.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow == null) return;

            string ma = dgvLopHoc.CurrentRow.Cells["colMaGV"].Value.ToString();
            string ten = dgvLopHoc.CurrentRow.Cells["colHoTen"].Value.ToString();
            string sdt = dgvLopHoc.CurrentRow.Cells["colSDT"].Value.ToString();
            string email = dgvLopHoc.CurrentRow.Cells["colEmail"].Value.ToString();
            string cm = dgvLopHoc.CurrentRow.Cells["colChuyenMon"].Value.ToString();
            string tt = dgvLopHoc.CurrentRow.Cells["colTrangThai"].Value.ToString();

            if (giaoVienDAL.SuaGiaoVien(ma, ten, sdt, email, cm, tt))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow != null)
            {
                string maGV = dgvLopHoc.CurrentRow.Cells["colMaGV"].Value.ToString();
                if (MessageBox.Show("Xóa giáo viên " + maGV + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (giaoVienDAL.XoaGiaoVien(maGV))
                    {
                        LoadDanhSach();
                    }
                }
            }
        }

        private void txtTImKiem_TextChanged(object sender, EventArgs e)
        {
            if (dgvLopHoc.DataSource is DataTable dt)
            {
                string tuKhoa = txtTImKiem.Text.Trim();
                dt.DefaultView.RowFilter = string.Format("HoTen LIKE '%{0}%' OR MaGV LIKE '%{0}%'", tuKhoa);
            }
        }

        private void dgvLopHoc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}