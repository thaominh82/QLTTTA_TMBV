namespace QuanLyTrungTamTiengAnh.Forms
{
    partial class FrmHocVien
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTongHV = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongHV = new System.Windows.Forms.Label();
            this.lblSo = new System.Windows.Forms.Label();
            this.pnlTongHocVien = new System.Windows.Forms.Label();
            this.pnlBaoLuu = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDangHoc = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDangHoc = new System.Windows.Forms.Label();
            this.lblSoDangHoc = new System.Windows.Forms.Label();
            this.lblHV = new System.Windows.Forms.Label();
            this.TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHocVien1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDSHV = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.pnlTongHV.SuspendLayout();
            this.pnlBaoLuu.SuspendLayout();
            this.pnlDangHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnLamMoi);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.lblDSHV);
            this.pnlMain.Controls.Add(this.dgvHocVien1);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.TxtSearch);
            this.pnlMain.Controls.Add(this.pnlDangHoc);
            this.pnlMain.Controls.Add(this.pnlBaoLuu);
            this.pnlMain.Controls.Add(this.pnlTongHV);
            this.pnlMain.Controls.Add(this.btnHome);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1814, 694);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DeepPink;
            this.lblTitle.Location = new System.Drawing.Point(43, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Học Viên";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BorderRadius = 15;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.HotPink;
            this.btnHome.Location = new System.Drawing.Point(1000, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(130, 45);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Trang chủ";
            // 
            // pnlTongHV
            // 
            this.pnlTongHV.BorderRadius = 30;
            this.pnlTongHV.Controls.Add(this.pnlTongHocVien);
            this.pnlTongHV.Controls.Add(this.lblTongHV);
            this.pnlTongHV.Controls.Add(this.lblSo);
            this.pnlTongHV.FillColor = System.Drawing.Color.White;
            this.pnlTongHV.Location = new System.Drawing.Point(53, 112);
            this.pnlTongHV.Name = "pnlTongHV";
            this.pnlTongHV.Size = new System.Drawing.Size(300, 77);
            this.pnlTongHV.TabIndex = 2;
            this.pnlTongHV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTongHV_Paint);
            // 
            // lblTongHV
            // 
            this.lblTongHV.AutoSize = true;
            this.lblTongHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHV.Location = new System.Drawing.Point(4, 24);
            this.lblTongHV.Name = "lblTongHV";
            this.lblTongHV.Size = new System.Drawing.Size(120, 20);
            this.lblTongHV.TabIndex = 3;
            this.lblTongHV.Text = "Tổng học viên";
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSo.Location = new System.Drawing.Point(129, 7);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(38, 40);
            this.lblSo.TabIndex = 4;
            this.lblSo.Text = "0";
            // 
            // pnlTongHocVien
            // 
            this.pnlTongHocVien.AutoSize = true;
            this.pnlTongHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTongHocVien.Location = new System.Drawing.Point(195, 24);
            this.pnlTongHocVien.Name = "pnlTongHocVien";
            this.pnlTongHocVien.Size = new System.Drawing.Size(78, 20);
            this.pnlTongHocVien.TabIndex = 5;
            this.pnlTongHocVien.Text = "Học viên";
            // 
            // pnlBaoLuu
            // 
            this.pnlBaoLuu.BorderRadius = 30;
            this.pnlBaoLuu.Controls.Add(this.label1);
            this.pnlBaoLuu.Controls.Add(this.label2);
            this.pnlBaoLuu.Controls.Add(this.label4);
            this.pnlBaoLuu.FillColor = System.Drawing.Color.White;
            this.pnlBaoLuu.Location = new System.Drawing.Point(773, 116);
            this.pnlBaoLuu.Name = "pnlBaoLuu";
            this.pnlBaoLuu.Size = new System.Drawing.Size(300, 77);
            this.pnlBaoLuu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bảo lưu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // pnlDangHoc
            // 
            this.pnlDangHoc.BorderRadius = 30;
            this.pnlDangHoc.Controls.Add(this.lblHV);
            this.pnlDangHoc.Controls.Add(this.lblDangHoc);
            this.pnlDangHoc.Controls.Add(this.lblSoDangHoc);
            this.pnlDangHoc.FillColor = System.Drawing.Color.White;
            this.pnlDangHoc.Location = new System.Drawing.Point(424, 112);
            this.pnlDangHoc.Name = "pnlDangHoc";
            this.pnlDangHoc.Size = new System.Drawing.Size(300, 80);
            this.pnlDangHoc.TabIndex = 4;
            // 
            // lblDangHoc
            // 
            this.lblDangHoc.AutoSize = true;
            this.lblDangHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangHoc.Location = new System.Drawing.Point(17, 17);
            this.lblDangHoc.Name = "lblDangHoc";
            this.lblDangHoc.Size = new System.Drawing.Size(86, 20);
            this.lblDangHoc.TabIndex = 0;
            this.lblDangHoc.Text = "Đang học";
            // 
            // lblSoDangHoc
            // 
            this.lblSoDangHoc.AutoSize = true;
            this.lblSoDangHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDangHoc.Location = new System.Drawing.Point(129, 17);
            this.lblSoDangHoc.Name = "lblSoDangHoc";
            this.lblSoDangHoc.Size = new System.Drawing.Size(38, 40);
            this.lblSoDangHoc.TabIndex = 5;
            this.lblSoDangHoc.Text = "0";
            // 
            // lblHV
            // 
            this.lblHV.AutoSize = true;
            this.lblHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHV.Location = new System.Drawing.Point(213, 17);
            this.lblHV.Name = "lblHV";
            this.lblHV.Size = new System.Drawing.Size(78, 20);
            this.lblHV.TabIndex = 6;
            this.lblHV.Text = "Học viên";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderRadius = 10;
            this.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearch.DefaultText = "";
            this.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSearch.Location = new System.Drawing.Point(1140, 133);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Nhập tên học viên, SDT, email,...";
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.Size = new System.Drawing.Size(300, 45);
            this.TxtSearch.TabIndex = 5;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.HotPink;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1532, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 45);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // dgvHocVien1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvHocVien1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocVien1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHocVien1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.SDT,
            this.Email,
            this.DiaChi,
            this.TrangThai});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocVien1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHocVien1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHocVien1.Location = new System.Drawing.Point(397, 233);
            this.dgvHocVien1.Name = "dgvHocVien1";
            this.dgvHocVien1.RowHeadersVisible = false;
            this.dgvHocVien1.RowHeadersWidth = 62;
            this.dgvHocVien1.RowTemplate.Height = 28;
            this.dgvHocVien1.Size = new System.Drawing.Size(1100, 300);
            this.dgvHocVien1.TabIndex = 7;
            this.dgvHocVien1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHocVien1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocVien1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien1.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvHocVien1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHocVien1.ThemeStyle.RowsStyle.Height = 28;
            // 
            // MaHV
            // 
            this.MaHV.HeaderText = "Mã học viên";
            this.MaHV.MinimumWidth = 8;
            this.MaHV.Name = "MaHV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 8;
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 8;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 8;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            // 
            // lblDSHV
            // 
            this.lblDSHV.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHV.ForeColor = System.Drawing.Color.DeepPink;
            this.lblDSHV.Location = new System.Drawing.Point(125, 233);
            this.lblDSHV.Name = "lblDSHV";
            this.lblDSHV.Size = new System.Drawing.Size(250, 70);
            this.lblDSHV.TabIndex = 8;
            this.lblDSHV.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.DeepPink;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(399, 582);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 45);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1197, 591);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 45);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Crimson;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(892, 591);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 45);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.Orange;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(641, 582);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 45);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            // 
            // FrmHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1814, 694);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí học viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTongHV.ResumeLayout(false);
            this.pnlTongHV.PerformLayout();
            this.pnlBaoLuu.ResumeLayout(false);
            this.pnlBaoLuu.PerformLayout();
            this.pnlDangHoc.ResumeLayout(false);
            this.pnlDangHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Panel pnlTongHV;
        private System.Windows.Forms.Label pnlTongHocVien;
        private System.Windows.Forms.Label lblTongHV;
        private System.Windows.Forms.Label lblSo;
        private Guna.UI2.WinForms.Guna2Panel pnlDangHoc;
        private Guna.UI2.WinForms.Guna2Panel pnlBaoLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHV;
        private System.Windows.Forms.Label lblSoDangHoc;
        private System.Windows.Forms.Label lblDangHoc;
        private Guna.UI2.WinForms.Guna2TextBox TxtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHocVien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label lblDSHV;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnThem;
    }
}