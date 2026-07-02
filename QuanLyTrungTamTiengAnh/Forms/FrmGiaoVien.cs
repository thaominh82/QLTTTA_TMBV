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
            // Đảm bảo bạn đã đặt tên các nút đúng trong Designer
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        }

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            DataTable dt = giaoVienDAL.LayDanhSachGiaoVien();
            dgvLopHoc.AutoGenerateColumns = false;
            dgvLopHoc.DataSource = dt;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Close();
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow == null) return;

            string ma = dgvLopHoc.CurrentRow.Cells["colMaGV"].Value?.ToString() ?? "";
            string ten = dgvLopHoc.CurrentRow.Cells["colHoTen"].Value?.ToString() ?? "";
            string sdt = dgvLopHoc.CurrentRow.Cells["colSDT"].Value?.ToString() ?? "";
            string email = dgvLopHoc.CurrentRow.Cells["colEmail"].Value?.ToString() ?? "";
            string cm = dgvLopHoc.CurrentRow.Cells["colChuyenMon"].Value?.ToString() ?? "";
            string tt = dgvLopHoc.CurrentRow.Cells["colTrangThai"].Value?.ToString() ?? "";

            if (giaoVienDAL.SuaGiaoVien(ma, ten, sdt, email, cm, tt))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSach();
            }
        }

        // --- NÚT XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.CurrentRow == null) return;

            string maGV = dgvLopHoc.CurrentRow.Cells["colMaGV"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(maGV)) return;

            if (MessageBox.Show("Xóa giáo viên " + maGV + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (giaoVienDAL.XoaGiaoVien(maGV))
                {
                    LoadDanhSach();
                }
            }
        }

        // --- NÚT TÌM KIẾM ---
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.DataSource is DataTable dt)
            {
                string tuKhoa = txtTImKiem.Text.Trim();
                // Thay 'MaGV' và 'HoTen' bằng tên cột chính xác trong CSDL của bạn
                dt.DefaultView.RowFilter = string.Format("MaGV LIKE '%{0}%' OR HoTen LIKE '%{0}%'", tuKhoa);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thêm dữ liệu trực tiếp vào một dòng trống trên bảng.");
        }
    }
}