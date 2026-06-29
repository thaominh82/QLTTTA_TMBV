using System;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.Forms; 

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

     
            Application.Run(new QuanLyTrungTamTiengAnhTM_BV.GUI.Forms.FrmDangNhap());
        }
    }
}