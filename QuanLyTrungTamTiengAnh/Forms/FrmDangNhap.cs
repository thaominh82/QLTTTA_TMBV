using System;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.DAL.Classes; // Phải có để gọi TaiKhoanDAL
using QuanLyTrungTamTiengAnh.Forms;       // Phải có để gọi FrmMain

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Gọi DAL
            TaiKhoanDAL tkDAL = new TaiKhoanDAL();

            if (tkDAL.KiemTraDangNhap(txtUsername.Text, txtPassword.Text))
            {
                // Đăng nhập thành công
                this.Hide();
                FrmMain frm = new FrmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}