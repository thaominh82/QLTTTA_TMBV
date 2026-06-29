using System;
using System.Data;

namespace QuanLyTrungTamTiengAnh.DAL.Interfaces
{
    public interface IHocVienDAL
    {
        DataTable LayDanhSachHocVien();
        bool ThemHocVien(string maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, string email, string diaChi, string trangThai);
    }
}