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
            // Code khởi tạo khi form chạy
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Kiểm tra các tài khoản hợp lệ
            bool isAuthenticated = false;

            if ((user == "admin" && pass == "123456") ||
                (user == "Thảo Minh" && pass == "080206") ||
                (user == "Bảo Vy" && pass == "102"))
            {
                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                // Nhảy thẳng tới FrmMain không qua thông báo
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                // Giữ lại thông báo lỗi nếu nhập sai
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}