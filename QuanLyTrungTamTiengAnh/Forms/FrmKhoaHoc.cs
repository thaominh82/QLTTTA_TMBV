using System;
using System.Data;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.DAL.Classes;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmKhoaHoc : Form
    {
        private IKhoaHocDAL khoaHocDAL = new KhoaHocDAL();

        public FrmKhoaHoc()
        {
            InitializeComponent();
        }

        private void FrmKhoaHoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhoaHoc();
            XoaTrangThongTin();
        }

        // --- CÁC HÀM XỬ LÝ DỮ LIỆU ---
        private void LoadDanhSachKhoaHoc()
        {
            try
            {
                DataTable dt = khoaHocDAL.LayDanhSachKhoaHoc();
                dgvLopHoc.DataSource = null; // 1. Xóa nguồn cũ để tránh treo
                dgvLopHoc.AutoGenerateColumns = false;
                dgvLopHoc.DataSource = dt;   // 2. Gán nguồn mới
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load dữ liệu: " + ex.Message); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            decimal h = 0; decimal.TryParse(cboHocPhi.Text, out h);
            int t = 0; int.TryParse(cboThoiLuong.Text, out t);

            if (khoaHocDAL.ThemKhoaHoc(txtKhoaHoc.Text, txtTenKHoaHoc.Text, txtTrinhDo.Text, h, t, txtMoTa.Text))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDanhSachKhoaHoc();
                XoaTrangThongTin();
            }
            else MessageBox.Show("Thêm thất bại! (Có thể trùng mã khóa học)");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhoaHoc.Text)) { MessageBox.Show("Vui lòng chọn dòng cần sửa!"); return; }
            if (!KiemTraDuLieu()) return;

            decimal h = 0; decimal.TryParse(cboHocPhi.Text, out h);
            int t = 0; int.TryParse(cboThoiLuong.Text, out t);

            if (khoaHocDAL.SuaKhoaHoc(txtKhoaHoc.Text, txtTenKHoaHoc.Text, txtTrinhDo.Text, h, t, txtMoTa.Text))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSachKhoaHoc();
            }
            else MessageBox.Show("Lỗi cập nhật!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhoaHoc.Text)) { MessageBox.Show("Chọn khóa học muốn xóa!"); return; }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (khoaHocDAL.XoaKhoaHoc(txtKhoaHoc.Text))
                {
                    MessageBox.Show("Đã xóa thành công!");
                    LoadDanhSachKhoaHoc();
                    XoaTrangThongTin();
                }
                else MessageBox.Show("Xóa thất bại!");
            }
        }

        // --- TÌM KIẾM ---
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTImKiem.Text.Trim();
            if (dgvLopHoc.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Format("MaKH LIKE '%{0}%' OR TenKH LIKE '%{0}%'", tuKhoa);
            }
        }

        private void txtTImKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTImKiem.Text) && dgvLopHoc.DataSource is DataTable dt)
                dt.DefaultView.RowFilter = "";
        }

        // --- HỖ TRỢ GIAO DIỆN ---
        private void DgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];
                txtKhoaHoc.Text = row.Cells["colMaKH"].Value?.ToString();
                txtTenKHoaHoc.Text = row.Cells["colTenKH"].Value?.ToString();
                txtTrinhDo.Text = row.Cells["colTrinhDo"].Value?.ToString();
                cboHocPhi.Text = row.Cells["colHocPhi"].Value?.ToString();
                cboThoiLuong.Text = row.Cells["Column1colThoiLuong"].Value?.ToString();
                txtMoTa.Text = row.Cells["colMoTa"].Value?.ToString();
            }
        }

        private void XoaTrangThongTin()
        {
            txtKhoaHoc.Clear(); txtTenKHoaHoc.Clear(); txtTrinhDo.Clear();
            cboHocPhi.SelectedIndex = -1; cboThoiLuong.SelectedIndex = -1; txtMoTa.Clear();
            txtKhoaHoc.Focus();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtKhoaHoc.Text) || string.IsNullOrWhiteSpace(txtTenKHoaHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên!");
                return false;
            }
            return true;
        }

        private void picHome_Click(object sender, EventArgs e) { this.Close(); }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
    }
}