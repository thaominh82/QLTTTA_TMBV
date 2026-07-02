using System.Windows.Forms;

namespace QuanLyTrungTamTiengAnh.Forms
{
    partial class FrmGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiaoVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDaHuy = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDangHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlTong = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.txtTImKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLopHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(guna2CirclePictureBox4)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlDaHuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.pnlDangHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnlTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox4
            // 
            guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            guna2CirclePictureBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            guna2CirclePictureBox4.ImageRotate = 0F;
<<<<<<< Updated upstream
            guna2CirclePictureBox4.Location = new System.Drawing.Point(6, 18);
            guna2CirclePictureBox4.Margin = new System.Windows.Forms.Padding(2);
=======
            guna2CirclePictureBox4.Location = new System.Drawing.Point(8, 22);
            guna2CirclePictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox4.Size = new System.Drawing.Size(100, 100);
            guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox4.TabIndex = 4;
            guna2CirclePictureBox4.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.pnlDaHuy);
            this.guna2Panel1.Controls.Add(this.pnlDangHoc);
            this.guna2Panel1.Controls.Add(this.pnlTong);
            this.guna2Panel1.Controls.Add(this.btnTimKiem);
            this.guna2Panel1.Controls.Add(this.picHome);
            this.guna2Panel1.Controls.Add(this.txtTImKiem);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
<<<<<<< Updated upstream
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
=======
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1824, 316);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 37);
            this.label6.TabIndex = 39;
            this.label6.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // pnlDaHuy
            // 
            this.pnlDaHuy.BorderRadius = 20;
            this.pnlDaHuy.Controls.Add(this.guna2CirclePictureBox3);
            this.pnlDaHuy.Controls.Add(this.label5);
            this.pnlDaHuy.FillColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.pnlDaHuy.Location = new System.Drawing.Point(966, 84);
            this.pnlDaHuy.Margin = new System.Windows.Forms.Padding(2);
=======
            this.pnlDaHuy.Location = new System.Drawing.Point(1288, 105);
            this.pnlDaHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.pnlDaHuy.Name = "pnlDaHuy";
            this.pnlDaHuy.Size = new System.Drawing.Size(372, 148);
            this.pnlDaHuy.TabIndex = 38;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
<<<<<<< Updated upstream
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(6, 18);
            this.guna2CirclePictureBox3.Margin = new System.Windows.Forms.Padding(2);
=======
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(8, 22);
            this.guna2CirclePictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 4;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đã nghỉ";
            // 
            // pnlDangHoc
            // 
            this.pnlDangHoc.BorderRadius = 20;
            this.pnlDangHoc.Controls.Add(this.label2);
            this.pnlDangHoc.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlDangHoc.FillColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.pnlDangHoc.Location = new System.Drawing.Point(472, 84);
            this.pnlDangHoc.Margin = new System.Windows.Forms.Padding(2);
=======
            this.pnlDangHoc.Location = new System.Drawing.Point(629, 105);
            this.pnlDangHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.pnlDangHoc.Name = "pnlDangHoc";
            this.pnlDangHoc.Size = new System.Drawing.Size(372, 148);
            this.pnlDangHoc.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đang giảng dạy";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
<<<<<<< Updated upstream
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(6, 18);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
=======
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(8, 22);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pnlTong
            // 
            this.pnlTong.BorderRadius = 20;
            this.pnlTong.Controls.Add(guna2CirclePictureBox4);
            this.pnlTong.Controls.Add(this.label4);
            this.pnlTong.FillColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.pnlTong.Location = new System.Drawing.Point(16, 84);
            this.pnlTong.Margin = new System.Windows.Forms.Padding(2);
=======
            this.pnlTong.Location = new System.Drawing.Point(21, 105);
            this.pnlTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.pnlTong.Name = "pnlTong";
            this.pnlTong.Size = new System.Drawing.Size(372, 148);
            this.pnlTong.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng giáo viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.LightBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
<<<<<<< Updated upstream
            this.btnTimKiem.Location = new System.Drawing.Point(882, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnTimKiem.Location = new System.Drawing.Point(1176, 28);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(260, 59);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "🔎Tìm kiếm";
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
<<<<<<< Updated upstream
            this.picHome.Location = new System.Drawing.Point(1192, 10);
            this.picHome.Margin = new System.Windows.Forms.Padding(2);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(158, 62);
=======
            this.picHome.Location = new System.Drawing.Point(1589, 12);
            this.picHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(211, 78);
>>>>>>> Stashed changes
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 32;
            this.picHome.TabStop = false;
            // 
            // txtTImKiem
            // 
            this.txtTImKiem.BorderRadius = 15;
            this.txtTImKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTImKiem.DefaultText = "";
            this.txtTImKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTImKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTImKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTImKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTImKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTImKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTImKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTImKiem.Location = new System.Drawing.Point(797, 28);
            this.txtTImKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTImKiem.Name = "txtTImKiem";
            this.txtTImKiem.PlaceholderText = "Tìm kiếm giáo viên...";
            this.txtTImKiem.SelectedText = "";
            this.txtTImKiem.Size = new System.Drawing.Size(371, 62);
            this.txtTImKiem.TabIndex = 31;
            this.txtTImKiem.TextChanged += new System.EventHandler(this.txtTImKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 59);
            this.label7.TabIndex = 2;
            this.label7.Text = "QUẢN LÝ GIÁO VIÊN";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.btnXoa);
            this.guna2Panel2.Controls.Add(this.btnSua);
            this.guna2Panel2.Controls.Add(this.btnThem);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
<<<<<<< Updated upstream
            this.guna2Panel2.Location = new System.Drawing.Point(0, 733);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
=======
            this.guna2Panel2.Location = new System.Drawing.Point(0, 916);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1824, 134);
            this.guna2Panel2.TabIndex = 6;
            // 
<<<<<<< Updated upstream
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BorderRadius = 15;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.Pink;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnHuy.Location = new System.Drawing.Point(977, 36);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(153, 36);
            this.btnHuy.TabIndex = 47;
            this.btnHuy.Text = "🔄 Huỷ";
            // 
=======
>>>>>>> Stashed changes
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Pink;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
<<<<<<< Updated upstream
            this.btnXoa.Location = new System.Drawing.Point(788, 36);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnXoa.Location = new System.Drawing.Point(915, 45);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(204, 45);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "❌ Xóa";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 15;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.Pink;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
<<<<<<< Updated upstream
            this.btnSua.Location = new System.Drawing.Point(598, 36);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnSua.Location = new System.Drawing.Point(585, 45);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(204, 45);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "✏️ Sửa";
            // 
<<<<<<< Updated upstream
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.Pink;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnLuu.Location = new System.Drawing.Point(408, 36);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(153, 36);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "💾 Lưu";
            // 
=======
>>>>>>> Stashed changes
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 15;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.Pink;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
<<<<<<< Updated upstream
            this.btnThem.Location = new System.Drawing.Point(218, 36);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
=======
            this.btnThem.Location = new System.Drawing.Point(211, 45);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 45);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "+ Thêm mới";
            // 
            // dgvLopHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLopHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLopHoc.ColumnHeadersHeight = 46;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGV,
            this.colHoTen,
            this.colSDT,
            this.colEmail,
            this.colChuyenMon,
            this.colTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
<<<<<<< Updated upstream
            this.dgvLopHoc.Location = new System.Drawing.Point(0, 253);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(2);
=======
            this.dgvLopHoc.Location = new System.Drawing.Point(0, 316);
            this.dgvLopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
>>>>>>> Stashed changes
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowHeadersWidth = 82;
            this.dgvLopHoc.RowTemplate.Height = 33;
            this.dgvLopHoc.Size = new System.Drawing.Size(1824, 600);
            this.dgvLopHoc.TabIndex = 7;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Height = 46;
            this.dgvLopHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.RowsStyle.Height = 33;
<<<<<<< Updated upstream
            this.dgvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellContentClick);
=======
            this.dgvLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellContentClick_1);
>>>>>>> Stashed changes
            // 
            // colMaGV
            // 
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.HeaderText = "Mã giáo viên";
            this.colMaGV.MinimumWidth = 10;
            this.colMaGV.Name = "colMaGV";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và Tên";
            this.colHoTen.MinimumWidth = 10;
            this.colHoTen.Name = "colHoTen";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "Số Điện Thoại";
            this.colSDT.MinimumWidth = 10;
            this.colSDT.Name = "colSDT";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 10;
            this.colEmail.Name = "colEmail";
            // 
            // colChuyenMon
            // 
            this.colChuyenMon.DataPropertyName = "ChuyenMon";
            this.colChuyenMon.HeaderText = "Chuyên môn";
            this.colChuyenMon.MinimumWidth = 10;
            this.colChuyenMon.Name = "colChuyenMon";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 10;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // FrmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1050);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
<<<<<<< Updated upstream
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
=======
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> Stashed changes
            this.Name = "FrmGiaoVien";
            this.Text = "Quản lí giáo viên";
            ((System.ComponentModel.ISupportInitialize)(guna2CirclePictureBox4)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlDaHuy.ResumeLayout(false);
            this.pnlDaHuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.pnlDangHoc.ResumeLayout(false);
            this.pnlDangHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnlTong.ResumeLayout(false);
            this.pnlTong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel pnlDaHuy;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel pnlDangHoc;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlTong;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTImKiem;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLopHoc;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}