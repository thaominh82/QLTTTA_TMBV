using System;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.Forms; // Đảm bảo namespace này khớp với project của bạn

namespace QuanLyTrungTamTiengAnh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form Đăng nhập đầu tiên
            Application.Run(new FrmDangNhap());
        }
    }
}