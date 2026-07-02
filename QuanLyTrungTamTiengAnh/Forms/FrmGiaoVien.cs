using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTrungTamTiengAnh.Forms; // Đảm bảo namespace này chứa FrmMain

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmGiaoVien : Form
    {
        public FrmGiaoVien()
        {
            InitializeComponent();
            // Đăng ký sự kiện Click cho picHome thủ công để tránh lỗi Designer
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            // 1. Tạo instance của FrmMain
            FrmMain main = new FrmMain();

            // 2. Hiển thị FrmMain
            main.Show();

            // 3. Đóng form hiện tại
            this.Close();
        }
        private void txtTImKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
