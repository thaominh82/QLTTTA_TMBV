using QuanLyTrungTamTiengAnh.Forms;
using System;
using System.Windows.Forms;

namespace QuanLyTrungTamTiengAnhTM_BV.GUI.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // Code khởi tạo khi form chạy (nếu có)
        }

        // Sự kiện này đã được liên kết với btnDangNhap trong Designer
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Tài khoản Admin cố định
            string adminUser = "admin";
            string adminPass = "123456";

            // Sử dụng tên đúng: txtUsername và txtPassword
            if (txtUsername.Text == adminUser && txtPassword.Text == adminPass)
            {
                MessageBox.Show("Chào mừng Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở Form Main
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}