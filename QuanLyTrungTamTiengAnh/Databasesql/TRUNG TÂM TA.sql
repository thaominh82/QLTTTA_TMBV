
-- 1. Tạo Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QuanLyTrungTamTiengAnh')
BEGIN
    CREATE DATABASE QuanLyTrungTamTiengAnh
END
GO

USE QuanLyTrungTamTiengAnh
GO

-- 2. Xóa bảng cũ (thứ tự xóa ngược với thứ tự tạo để tránh lỗi khóa ngoại)
IF OBJECT_ID('dbo.DangKyHoc', 'U') IS NOT NULL DROP TABLE dbo.DangKyHoc;
IF OBJECT_ID('dbo.HocVien', 'U') IS NOT NULL DROP TABLE dbo.HocVien;
IF OBJECT_ID('dbo.TaiKhoan', 'U') IS NOT NULL DROP TABLE dbo.TaiKhoan;
IF OBJECT_ID('dbo.GiaoVien', 'U') IS NOT NULL DROP TABLE dbo.GiaoVien;
IF OBJECT_ID('dbo.KhoaHoc', 'U') IS NOT NULL DROP TABLE dbo.KhoaHoc;

GO
GO

-- 3. Tạo các bảng
CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
    Quyen NVARCHAR(20) NOT NULL DEFAULT N'User'
)

CREATE TABLE HocVien (
    MaHV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    SDT VARCHAR(15) UNIQUE,
    Email VARCHAR(100) UNIQUE,
    DiaChi NVARCHAR(200),
    TrangThai NVARCHAR(50) DEFAULT N'Đang học'
)

CREATE TABLE GiaoVien (
    MaGV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15) UNIQUE,
    Email VARCHAR(100) UNIQUE,
    ChuyenMon NVARCHAR(100),
    TrangThai NVARCHAR(50) DEFAULT N'Đang giảng dạy'
)
GO

CREATE TABLE KhoaHoc (
    MaKH VARCHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    TrinhDo NVARCHAR(50),
    HocPhi DECIMAL(18,2),
    ThoiLuong INT,
    MoTa NVARCHAR(255)
)

CREATE TABLE DangKyHoc (
    MaDangKy INT IDENTITY(1,1) PRIMARY KEY,
    MaHV VARCHAR(10) NOT NULL,
    MaKH VARCHAR(10) NOT NULL,
    NgayDangKy DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_DangKyHoc_HocVien FOREIGN KEY (MaHV) REFERENCES HocVien(MaHV),
    CONSTRAINT FK_DangKyHoc_KhoaHoc FOREIGN KEY (MaKH) REFERENCES KhoaHoc(MaKH),
    CONSTRAINT UQ_DangKyHoc UNIQUE(MaHV, MaKH)
)
GO

-- 4. Chèn dữ liệu mẫu
INSERT INTO KhoaHoc VALUES
('KH001',N'Tiếng Anh A1',N'Cơ bản',2500000,30,N'Dành cho người mới'),
('KH002',N'Tiếng Anh A2',N'Cơ bản',3000000,35,N'Hoàn thiện nền tảng'),
('KH003',N'TOEIC 450+',N'Trung cấp',4500000,45,N'Luyện TOEIC'),
('KH004',N'TOEIC 650+',N'Nâng cao',5500000,60,N'Luyện đề'),
('KH005',N'IELTS 5.5',N'Trung cấp',7000000,70,N'IELTS cơ bản'),
('KH006',N'IELTS 6.5',N'Nâng cao',9000000,90,N'IELTS nâng cao');

INSERT INTO HocVien (MaHV, HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi, TrangThai) VALUES
('HV001', N'Nguyễn Văn An', '2005-01-10', N'Nam', '0901000001', 'an.nguyen@email.com', N'Hà Nội', N'Đang học'),
('HV002', N'Trần Thị Bích', '2006-02-15', N'Nữ', '0901000002', 'bich.tran@email.com', N'Đà Nẵng', N'Đang học'),
('HV003', N'Lê Văn Cường', '2004-03-20', N'Nam', '0901000003', 'cuong.le@email.com', N'TP.HCM', N'Hoàn thành'),
('HV004', N'Phạm Thị Duyên', '2005-04-25', N'Nữ', '0901000004', 'duyen.pham@email.com', N'Cần Thơ', N'Đang học'),
('HV005', N'Hoàng Văn Em', '2006-05-30', N'Nam', '0901000005', 'em.hoang@email.com', N'Huế', N'Đang học'),
('HV006', N'Đặng Thị Phương', '2004-06-05', N'Nữ', '0901000006', 'phuong.dang@email.com', N'Hải Phòng', N'Đang học'),
('HV007', N'Bùi Văn Giang', '2005-07-10', N'Nam', '0901000007', 'giang.bui@email.com', N'Huế', N'Hoàn thành'),
('HV008', N'Nguyễn Thị Hồng', '2006-08-15', N'Nữ', '0901000008', 'hong.nguyen@email.com', N'Nghệ An', N'Đang học'),
('HV009', N'Vũ Văn Ích', '2004-09-20', N'Nam', '0901000009', 'ich.vu@email.com', N'Đà Lạt', N'Đang học'),
('HV010', N'Lý Thị Kiều', '2005-10-25', N'Nữ', '0901000010', 'kieu.ly@email.com', N'Huế', N'Đang học');

INSERT INTO GiaoVien (MaGV, HoTen, SDT, Email, ChuyenMon, TrangThai) VALUES 
('GV001', N'Trần Minh Tâm', '0912000001', 'tam.tran@gmail.com', N'Tiếng Anh cơ bản', N'Đang giảng dạy'),
('GV002', N'Lê Thị Thu Thảo', '0912000002', 'thao.le@gmail.com', N'Luyện thi TOEIC', N'Đang giảng dạy'),
('GV003', N'Phạm Văn Hùng', '0912000003', 'hung.pham@gmail.com', N'Luyện thi IELTS', N'Đang giảng dạy');

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Quyen) VALUES
('admin', '123456', N'Admin'),
('giaovien01', '123456', N'Giáo viên'),
('hocvien01', '123456', N'User');

INSERT INTO DangKyHoc (MaHV, MaKH, NgayDangKy) VALUES
('HV001', 'KH001', GETDATE()),
('HV002', 'KH002', GETDATE()),
('HV005', 'KH003', GETDATE()),
('HV007', 'KH005', GETDATE()),
('HV010', 'KH006', GETDATE());
GO



SELECT * FROM GiaoVien