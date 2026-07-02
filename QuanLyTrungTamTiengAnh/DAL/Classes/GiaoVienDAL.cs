using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class GiaoVienDAL : IGiaoVienDAL
    {
        public DataTable LayDanhSachGiaoVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaGV, HoTen, SDT, Email, ChuyenMon, TrangThai FROM GiaoVien";
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi để bạn biết tại sao bảng trống
                System.Diagnostics.Debug.WriteLine("Lỗi DAL LayDanhSach: " + ex.Message);
            }
            return dt;
        }

        public bool ThemGiaoVien(string maGV, string hoTen, string sdt, string email, string chuyenMon, string trangThai)
        {
            // Thêm kiểm tra trùng lặp trước khi INSERT để tránh crash
            if (KiemTraTonTai(maGV)) return false;

            string query = "INSERT INTO GiaoVien (MaGV, HoTen, SDT, Email, ChuyenMon, TrangThai) VALUES (@Ma, @Ten, @SDT, @Email, @ChuyenMon, @TrangThai)";
            return ExecuteCommand(query, maGV, hoTen, sdt, email, chuyenMon, trangThai);
        }

        public bool SuaGiaoVien(string maGV, string hoTen, string sdt, string email, string chuyenMon, string trangThai)
        {
            string query = "UPDATE GiaoVien SET HoTen=@Ten, SDT=@SDT, Email=@Email, ChuyenMon=@ChuyenMon, TrangThai=@TrangThai WHERE MaGV=@Ma";
            return ExecuteCommand(query, maGV, hoTen, sdt, email, chuyenMon, trangThai);
        }

        public bool XoaGiaoVien(string maGV)
        {
            string query = "DELETE FROM GiaoVien WHERE MaGV=@Ma";
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", maGV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // Hàm kiểm tra trùng lặp (Cần thiết cho nút Thêm)
        private bool KiemTraTonTai(string maGV)
        {
            string query = "SELECT COUNT(*) FROM GiaoVien WHERE MaGV = @Ma";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maGV);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool ExecuteCommand(string query, string ma, string ten, string sdt, string email, string cm, string tt)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", ma);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@ChuyenMon", cm);
                    cmd.Parameters.AddWithValue("@TrangThai", tt);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
        }
    }
}