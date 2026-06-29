using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class TaiKhoanDAL : ITaiKhoanDAL
    {
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string query = "SELECT COUNT(*) FROM Taikhoan WHERE TenDangNhap = @User AND MatKhau = @Pass";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@User", tenDangNhap);
                cmd.Parameters.AddWithValue("@Pass", matKhau);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public DataTable LayDanhSachTaiKhoan()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TenDangNhap, Quyen FROM Taikhoan";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemTaiKhoan(string tenDN, string matKhau, string hoTen, string email, string vaiTro, string trangThai, string ghiChu)
        {
            string query = "INSERT INTO Taikhoan (TenDangNhap, MatKhau, Quyen) VALUES (@TenDN, @MatKhau, @Quyen)";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDN", tenDN);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@Quyen", vaiTro);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}