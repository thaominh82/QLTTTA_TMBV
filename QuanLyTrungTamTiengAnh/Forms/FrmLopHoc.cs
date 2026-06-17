using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamTiengAnh.Forms
{
    public partial class FrmLopHoc : Form
    {
        public FrmLopHoc()
        {
            InitializeComponent();
        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLopHoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMainContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelGridContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvLopHoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.dtpNgayKhaiGiang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboGiaoVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.cboKhoaHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.cboThoiGianHoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGhiChu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSiso = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaLop = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelStatsContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox5 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.panelMainContent.SuspendLayout();
            this.panelGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.panelStatsContainer.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox5)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(23, 21);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(369, 147);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(21, 22);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 3;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số lớp";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.panelMainContent.BorderRadius = 15;
            this.panelMainContent.Controls.Add(this.panelGridContainer);
            this.panelMainContent.Controls.Add(this.panelStatsContainer);
            this.panelMainContent.Controls.Add(this.panelHeader);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 0);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(1879, 1050);
            this.panelMainContent.TabIndex = 1;
            // 
            // panelGridContainer
            // 
            this.panelGridContainer.BackColor = System.Drawing.Color.White;
            this.panelGridContainer.BorderRadius = 15;
            this.panelGridContainer.Controls.Add(this.dgvLopHoc);
            this.panelGridContainer.Controls.Add(this.guna2Button1);
            this.panelGridContainer.Controls.Add(this.guna2Button2);
            this.panelGridContainer.Controls.Add(this.dtpNgayKhaiGiang);
            this.panelGridContainer.Controls.Add(this.cboGiaoVien);
            this.panelGridContainer.Controls.Add(this.btnSua);
            this.panelGridContainer.Controls.Add(this.cboKhoaHoc);
            this.panelGridContainer.Controls.Add(this.btnLuu);
            this.panelGridContainer.Controls.Add(this.cboThoiGianHoc);
            this.panelGridContainer.Controls.Add(this.btnThem);
            this.panelGridContainer.Controls.Add(this.cboTrangThai);
            this.panelGridContainer.Controls.Add(this.txtGhiChu);
            this.panelGridContainer.Controls.Add(this.txtSiso);
            this.panelGridContainer.Controls.Add(this.txtTenLop);
            this.panelGridContainer.Controls.Add(this.txtMaLop);
            this.panelGridContainer.Controls.Add(this.label16);
            this.panelGridContainer.Controls.Add(this.label15);
            this.panelGridContainer.Controls.Add(this.label14);
            this.panelGridContainer.Controls.Add(this.label13);
            this.panelGridContainer.Controls.Add(this.label12);
            this.panelGridContainer.Controls.Add(this.label11);
            this.panelGridContainer.Controls.Add(this.label10);
            this.panelGridContainer.Controls.Add(this.label9);
            this.panelGridContainer.Controls.Add(this.label8);
            this.panelGridContainer.Controls.Add(this.label7);
            this.panelGridContainer.Controls.Add(this.label6);
            this.panelGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridContainer.Location = new System.Drawing.Point(20, 298);
            this.panelGridContainer.Name = "panelGridContainer";
            this.panelGridContainer.Size = new System.Drawing.Size(1839, 732);
            this.panelGridContainer.TabIndex = 3;
            // 
            // dgvLopHoc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLopHoc.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvLopHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLopHoc.ColumnHeadersHeight = 46;
            this.dgvLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLop,
            this.colTenLop,
            this.colKhoaHoc,
            this.colGiaoVien,
            this.colThoiGianHoc,
            this.colSiSo,
            this.colTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLopHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLopHoc.Location = new System.Drawing.Point(24, 69);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.RowHeadersWidth = 82;
            this.dgvLopHoc.RowTemplate.Height = 33;
            this.dgvLopHoc.Size = new System.Drawing.Size(1753, 318);
            this.dgvLopHoc.TabIndex = 2;
            this.dgvLopHoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLopHoc.ThemeStyle.BackColor = System.Drawing.Color.LavenderBlush;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightPink;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLopHoc.ThemeStyle.HeaderStyle.Height = 46;
            this.dgvLopHoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLopHoc.ThemeStyle.RowsStyle.Height = 33;
            // 
            // colMaLop
            // 
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.MinimumWidth = 10;
            this.colMaLop.Name = "colMaLop";
            // 
            // colTenLop
            // 
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.MinimumWidth = 10;
            this.colTenLop.Name = "colTenLop";
            // 
            // colKhoaHoc
            // 
            this.colKhoaHoc.HeaderText = "Khóa học";
            this.colKhoaHoc.MinimumWidth = 10;
            this.colKhoaHoc.Name = "colKhoaHoc";
            // 
            // colGiaoVien
            // 
            this.colGiaoVien.HeaderText = "Giáo viên";
            this.colGiaoVien.MinimumWidth = 10;
            this.colGiaoVien.Name = "colGiaoVien";
            // 
            // colThoiGianHoc
            // 
            this.colThoiGianHoc.HeaderText = "Thời gian học";
            this.colThoiGianHoc.MinimumWidth = 10;
            this.colThoiGianHoc.Name = "colThoiGianHoc";
            // 
            // colSiSo
            // 
            this.colSiSo.HeaderText = "Sĩ số";
            this.colSiSo.MinimumWidth = 10;
            this.colSiSo.Name = "colSiSo";
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 10;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.guna2Button1.Location = new System.Drawing.Point(1255, 816);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(204, 45);
            this.guna2Button1.TabIndex = 27;
            this.guna2Button1.Text = "🔄 Làm mới";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.guna2Button2.Location = new System.Drawing.Point(1002, 816);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(204, 45);
            this.guna2Button2.TabIndex = 28;
            this.guna2Button2.Text = "❌ Xóa";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // dtpNgayKhaiGiang
            // 
            this.dtpNgayKhaiGiang.Checked = true;
            this.dtpNgayKhaiGiang.FillColor = System.Drawing.Color.Transparent;
            this.dtpNgayKhaiGiang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayKhaiGiang.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKhaiGiang.Location = new System.Drawing.Point(873, 568);
            this.dtpNgayKhaiGiang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKhaiGiang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKhaiGiang.Name = "dtpNgayKhaiGiang";
            this.dtpNgayKhaiGiang.Size = new System.Drawing.Size(374, 36);
            this.dtpNgayKhaiGiang.TabIndex = 23;
            this.dtpNgayKhaiGiang.Value = new System.DateTime(2026, 6, 16, 17, 24, 47, 379);
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.cboGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGiaoVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGiaoVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGiaoVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGiaoVien.ItemHeight = 30;
            this.cboGiaoVien.Location = new System.Drawing.Point(168, 716);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(371, 36);
            this.cboGiaoVien.TabIndex = 22;
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 15;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnSua.Location = new System.Drawing.Point(749, 816);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(204, 45);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhoaHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhoaHoc.ItemHeight = 30;
            this.cboKhoaHoc.Location = new System.Drawing.Point(168, 647);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(371, 36);
            this.cboKhoaHoc.TabIndex = 21;
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnLuu.Location = new System.Drawing.Point(496, 816);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(204, 45);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboThoiGianHoc
            // 
            this.cboThoiGianHoc.BackColor = System.Drawing.Color.Transparent;
            this.cboThoiGianHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboThoiGianHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThoiGianHoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThoiGianHoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboThoiGianHoc.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThoiGianHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboThoiGianHoc.ItemHeight = 30;
            this.cboThoiGianHoc.Items.AddRange(new object[] {
            "Thứ 2, 4, 6 (18:00 - 20:00)",
            "",
            "",
            "Thứ 3, 5, 7 (19:00 - 21:00)",
            "",
            "",
            "Cuối tuần (Sáng T7, CN)"});
            this.cboThoiGianHoc.Location = new System.Drawing.Point(874, 499);
            this.cboThoiGianHoc.Name = "cboThoiGianHoc";
            this.cboThoiGianHoc.Size = new System.Drawing.Size(371, 36);
            this.cboThoiGianHoc.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 15;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnThem.Location = new System.Drawing.Point(243, 816);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(204, 45);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "+ Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang học",
            "",
            "",
            "Sắp khai giảng",
            "",
            "",
            "Đã kết thúc"});
            this.cboTrangThai.Location = new System.Drawing.Point(874, 716);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(371, 36);
            this.cboTrangThai.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(1428, 499);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(6);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PlaceholderText = "Nhập ghi chú...";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(371, 253);
            this.txtGhiChu.TabIndex = 18;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // txtSiso
            // 
            this.txtSiso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSiso.DefaultText = "";
            this.txtSiso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSiso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSiso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSiso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSiso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSiso.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSiso.Location = new System.Drawing.Point(873, 635);
            this.txtSiso.Margin = new System.Windows.Forms.Padding(6);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.PlaceholderText = "";
            this.txtSiso.SelectedText = "";
            this.txtSiso.Size = new System.Drawing.Size(371, 43);
            this.txtSiso.TabIndex = 17;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLop.DefaultText = "";
            this.txtTenLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLop.Location = new System.Drawing.Point(167, 573);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.PlaceholderText = "";
            this.txtTenLop.SelectedText = "";
            this.txtTenLop.Size = new System.Drawing.Size(371, 43);
            this.txtTenLop.TabIndex = 16;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLop.DefaultText = "";
            this.txtMaLop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaLop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaLop.Location = new System.Drawing.Point(167, 499);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.PlaceholderText = "";
            this.txtMaLop.SelectedText = "";
            this.txtMaLop.Size = new System.Drawing.Size(371, 43);
            this.txtMaLop.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label16.Location = new System.Drawing.Point(40, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "THÔNG TIN LỚP HỌC";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1311, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "Ghi chú";
            this.panelStatsContainer.Size = new System.Drawing.Size(1839, 190);
            this.panelStatsContainer.TabIndex = 1;
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(648, 573);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Ngày khai giảng";
            this.dgvLopHoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(648, 721);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Trạng thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(648, 647);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Sĩ số tối đa";
            this.colMaLop.MinimumWidth = 10;
            this.colMaLop.Name = "colMaLop";
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(648, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Thời gian học";
            this.colTenLop.MinimumWidth = 10;
            this.colTenLop.Name = "colTenLop";
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 721);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giáo viên";
            this.colKhoaHoc.MinimumWidth = 10;
            this.colKhoaHoc.Name = "colKhoaHoc";
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 647);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Khoá học";
            this.colGiaoVien.MinimumWidth = 10;
            this.colGiaoVien.Name = "colGiaoVien";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tên lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "DANH SÁCH LỚP HỌC";
            // 
            // panelStatsContainer
            // 
            this.panelStatsContainer.Controls.Add(this.guna2Panel4);
            this.panelStatsContainer.Controls.Add(this.guna2Panel3);
            this.panelStatsContainer.Controls.Add(this.guna2Panel2);
            this.panelStatsContainer.Controls.Add(this.guna2Panel1);
            this.panelStatsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatsContainer.FillColor = System.Drawing.Color.Transparent;
            this.panelStatsContainer.Location = new System.Drawing.Point(20, 108);
            this.panelStatsContainer.Name = "panelStatsContainer";
            this.panelStatsContainer.Size = new System.Drawing.Size(1839, 190);
            this.panelStatsContainer.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.Controls.Add(this.guna2CirclePictureBox4);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(942, 21);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(372, 147);
            this.guna2Panel4.TabIndex = 5;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(19, 22);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 4;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp sắp khai giảng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox5);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(1389, 21);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(372, 147);
            this.guna2Panel3.TabIndex = 4;
            // 
            // guna2CirclePictureBox5
            // 
            this.guna2CirclePictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.guna2CirclePictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox5.Image")));
            this.guna2CirclePictureBox5.ImageRotate = 0F;
            this.guna2CirclePictureBox5.Location = new System.Drawing.Point(27, 22);
            this.guna2CirclePictureBox5.Name = "guna2CirclePictureBox5";
            this.guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox5.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox5.TabIndex = 5;
            this.guna2CirclePictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lớp kết thúc";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox3);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(481, 21);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(372, 147);
            this.guna2Panel2.TabIndex = 3;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(20, 22);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(100, 100);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 30;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp đang học";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnTimKiem);
            this.panelHeader.Controls.Add(this.picHome);
            this.panelHeader.Controls.Add(this.guna2TextBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.Transparent;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(20, 20);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1839, 88);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.LightPink;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnTimKiem.Location = new System.Drawing.Point(1286, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(204, 59);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.Text = "🔎Tìm kiếm";
            // 
            // picHome
            // 
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(1595, 3);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(211, 78);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 26;
            this.picHome.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 15;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(906, 14);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "Tìm kiếm lớp học...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(371, 62);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // FrmLopHoc
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1879, 1050);
            this.Controls.Add(this.panelMainContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp Học";
            this.Load += new System.EventHandler(this.FrmLopHoc_Load_1);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.panelMainContent.ResumeLayout(false);
            this.panelGridContainer.ResumeLayout(false);
            this.panelGridContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.panelStatsContainer.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox5)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
