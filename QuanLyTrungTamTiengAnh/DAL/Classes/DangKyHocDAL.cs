using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class DangKyHocDAL : IDangKyHocDAL
    {
        public DataTable LayDanhSachDangKy()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaDK, MaHV, MaKH, NgayDangKy, HocPhi, TrangThai, GhiChu FROM DangKyHoc";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemDangKy(string maDK, string maHV, string maKH, DateTime ngayDK, decimal hocPhi, string trangThai, string ghiChu)
        {
            string query = "INSERT INTO DangKyHoc (MaDK, MaHV, MaKH, NgayDangKy, HocPhi, TrangThai, GhiChu) " +
                           "VALUES (@MaDK, @MaHV, @MaKH, @NgayDK, @HocPhi, @TrangThai, @GhiChu)";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaDK", maDK);
                cmd.Parameters.AddWithValue("@MaHV", maHV);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@NgayDK", ngayDK);
                cmd.Parameters.AddWithValue("@HocPhi", hocPhi);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}