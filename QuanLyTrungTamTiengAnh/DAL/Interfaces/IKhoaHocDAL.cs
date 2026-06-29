using System.Data;

namespace QuanLyTrungTamTiengAnh.DAL.Interfaces
{
    public interface IKhoaHocDAL
    {
        DataTable LayDanhSachKhoaHoc();
        bool ThemKhoaHoc(string maKH, string tenKH, string trinhDo, decimal hocPhi, int thoiLuong, string moTa);
        bool SuaKhoaHoc(string maKH, string tenKH, string trinhDo, decimal hocPhi, int thoiLuong, string moTa);
        bool XoaKhoaHoc(string maKH);
    }
}