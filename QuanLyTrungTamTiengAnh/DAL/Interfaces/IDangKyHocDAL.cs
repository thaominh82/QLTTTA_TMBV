using System;
using System.Data;

namespace QuanLyTrungTamTiengAnh.DAL.Interfaces
{
    public interface IDangKyHocDAL
    {
        DataTable LayDanhSachDangKy();
        bool ThemDangKy(string maDK, string maHV, string maKH, DateTime ngayDK, decimal hocPhi, string trangThai, string ghiChu);
    }
}