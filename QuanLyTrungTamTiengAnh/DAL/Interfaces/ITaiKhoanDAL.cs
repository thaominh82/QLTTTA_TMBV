using System.Data;

namespace QuanLyTrungTamTiengAnh.DAL.Interfaces
{
    public interface ITaiKhoanDAL
    {
        bool KiemTraDangNhap(string tenDangNhap, string matKhau);
        DataTable LayDanhSachTaiKhoan();
        bool ThemTaiKhoan(string tenDN, string matKhau, string hoTen, string email, string vaiTro, string trangThai, string ghiChu);
    }
}