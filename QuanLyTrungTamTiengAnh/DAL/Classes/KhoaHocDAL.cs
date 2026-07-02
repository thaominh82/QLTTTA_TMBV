using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class KhoaHocDAL : IKhoaHocDAL
    {
        // 1. Lấy danh sách - Thêm try-catch để bắt lỗi kết nối
        public DataTable LayDanhSachKhoaHoc()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaKH, TenKH, TrinhDo, HocPhi, ThoiLuong, MoTa FROM KhoaHoc";
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
                // Ghi log lỗi tại đây nếu cần
                Console.WriteLine("Lỗi DAL: " + ex.Message);
            }
            return dt;
        }

        // 2. Thêm - Sử dụng Add để chỉ định kiểu dữ liệu rõ ràng (tốt hơn AddWithValue)
        public bool ThemKhoaHoc(string maKH, string tenKH, string trinhDo, decimal hocPhi, int thoiLuong, string moTa)
        {
            string query = "INSERT INTO KhoaHoc (MaKH, TenKH, TrinhDo, HocPhi, ThoiLuong, MoTa) VALUES (@Ma, @Ten, @TrinhDo, @HocPhi, @ThoiLuong, @MoTa)";
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@Ma", SqlDbType.VarChar).Value = maKH;
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = tenKH;
                    cmd.Parameters.Add("@TrinhDo", SqlDbType.NVarChar).Value = (object)trinhDo ?? DBNull.Value;
                    cmd.Parameters.Add("@HocPhi", SqlDbType.Decimal).Value = hocPhi;
                    cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = thoiLuong;
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = (object)moTa ?? DBNull.Value;

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // 3. Sửa - Tương tự như Thêm
        public bool SuaKhoaHoc(string maKH, string tenKH, string trinhDo, decimal hocPhi, int thoiLuong, string moTa)
        {
            string query = "UPDATE KhoaHoc SET TenKH=@Ten, TrinhDo=@TrinhDo, HocPhi=@HocPhi, ThoiLuong=@ThoiLuong, MoTa=@MoTa WHERE MaKH=@Ma";
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@Ma", SqlDbType.VarChar).Value = maKH;
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = tenKH;
                    cmd.Parameters.Add("@TrinhDo", SqlDbType.NVarChar).Value = (object)trinhDo ?? DBNull.Value;
                    cmd.Parameters.Add("@HocPhi", SqlDbType.Decimal).Value = hocPhi;
                    cmd.Parameters.Add("@ThoiLuong", SqlDbType.Int).Value = thoiLuong;
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = (object)moTa ?? DBNull.Value;

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // 4. Xóa
        public bool XoaKhoaHoc(string maKH)
        {
            string query = "DELETE FROM KhoaHoc WHERE MaKH=@Ma";
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@Ma", SqlDbType.VarChar).Value = maKH;
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }
    }
}