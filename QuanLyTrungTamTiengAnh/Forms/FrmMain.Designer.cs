namespace QuanLyTrungTamTiengAnh.Forms
{
    partial class FrmMain
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHocVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiaoVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnLopHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhoaHoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKi = new Guna.UI2.WinForms.Guna2Button();
            this.plnContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel2.Controls.Add(this.btnDangKi);
            this.guna2Panel2.Controls.Add(this.btnTrangChu);
            this.guna2Panel2.Controls.Add(this.btnTaiKhoan);
            this.guna2Panel2.Controls.Add(this.btnHocVien);
            this.guna2Panel2.Controls.Add(this.btnKhoaHoc);
            this.guna2Panel2.Controls.Add(this.btnGiaoVien);
            this.guna2Panel2.Controls.Add(this.btnLopHoc);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 602);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BorderRadius = 15;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.FillColor = System.Drawing.Color.HotPink;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Location = new System.Drawing.Point(17, 112);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(180, 47);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            // 
            // btnHocVien
            // 
            this.btnHocVien.BorderRadius = 15;
            this.btnHocVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHocVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHocVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHocVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHocVien.FillColor = System.Drawing.Color.LightPink;
            this.btnHocVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHocVien.ForeColor = System.Drawing.Color.White;
            this.btnHocVien.Location = new System.Drawing.Point(14, 182);
            this.btnHocVien.Name = "btnHocVien";
            this.btnHocVien.Size = new System.Drawing.Size(180, 45);
            this.btnHocVien.TabIndex = 0;
            this.btnHocVien.Text = "Học viên";
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BorderRadius = 15;
            this.btnGiaoVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGiaoVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGiaoVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGiaoVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGiaoVien.FillColor = System.Drawing.Color.LightPink;
            this.btnGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnGiaoVien.Location = new System.Drawing.Point(14, 250);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(180, 45);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo viên";
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.BorderRadius = 15;
            this.btnLopHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLopHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLopHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLopHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLopHoc.FillColor = System.Drawing.Color.LightPink;
            this.btnLopHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLopHoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLopHoc.Location = new System.Drawing.Point(12, 320);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(180, 45);
            this.btnLopHoc.TabIndex = 2;
            this.btnLopHoc.Text = "Lớp học\r\n";
            // 
            // btnKhoaHoc
            // 
            this.btnKhoaHoc.BorderRadius = 15;
            this.btnKhoaHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoaHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhoaHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhoaHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhoaHoc.FillColor = System.Drawing.Color.LightPink;
            this.btnKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnKhoaHoc.Location = new System.Drawing.Point(14, 392);
            this.btnKhoaHoc.Name = "btnKhoaHoc";
            this.btnKhoaHoc.Size = new System.Drawing.Size(180, 45);
            this.btnKhoaHoc.TabIndex = 3;
            this.btnKhoaHoc.Text = "Khóa học";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BorderRadius = 15;
            this.btnTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaiKhoan.FillColor = System.Drawing.Color.LightPink;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(12, 464);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(180, 45);
            this.btnTaiKhoan.TabIndex = 4;
            this.btnTaiKhoan.Text = "Tài khoản";
            // 
            // btnDangKi
            // 
            this.btnDangKi.BorderRadius = 15;
            this.btnDangKi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKi.FillColor = System.Drawing.Color.LightPink;
            this.btnDangKi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKi.ForeColor = System.Drawing.Color.White;
            this.btnDangKi.Location = new System.Drawing.Point(12, 527);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(180, 45);
            this.btnDangKi.TabIndex = 5;
            this.btnDangKi.Text = "Đăng kí học";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // plnContainer
            // 
            this.plnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plnContainer.Location = new System.Drawing.Point(200, 0);
            this.plnContainer.Name = "plnContainer";
            this.plnContainer.Size = new System.Drawing.Size(1411, 602);
            this.plnContainer.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1611, 602);
            this.Controls.Add(this.plnContainer);
            this.Controls.Add(this.guna2Panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FrmMain";
            this.Text = "Trang chủ";
            this.guna2Panel2.ResumeLayout(false);
=======
            this.SuspendLayout();
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
>>>>>>> 86b15820a4ad494e8317966a5edcf7774e8f8f19
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnDangKi;
        private Guna.UI2.WinForms.Guna2Button btnTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnKhoaHoc;
        private Guna.UI2.WinForms.Guna2Button btnLopHoc;
        private Guna.UI2.WinForms.Guna2Button btnGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnHocVien;
        private Guna.UI2.WinForms.Guna2Panel plnContainer;
    }
}