using System.Data;

namespace QuanLyTrungTamTiengAnh.DAL.Interfaces
{
    public interface IGiaoVienDAL
    {
        DataTable LayDanhSachGiaoVien();
        bool ThemGiaoVien(string maGV, string hoTen, string sdt, string email, string chuyenMon, string trangThai);
        bool SuaGiaoVien(string maGV, string hoTen, string sdt, string email, string chuyenMon, string trangThai);
        bool XoaGiaoVien(string maGV);
    }
}