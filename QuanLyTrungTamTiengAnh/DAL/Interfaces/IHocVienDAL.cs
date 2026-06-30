using System.Data;

namespace QuanLyTrungTamTiengAnh.DAL
{
    public interface IHocVienDAL
    {
        DataTable LayDanhSach();
        int DemHocVien(string dieuKien);
    }
}