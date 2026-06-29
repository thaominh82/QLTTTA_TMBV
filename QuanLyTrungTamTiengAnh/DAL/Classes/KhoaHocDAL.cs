using System.Data;
using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class KhoaHocDAL : IKhoaHocDAL
    {
        public DataTable LayDanhSachKhoaHoc()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaKH, TenKH, TrinhDo, HocPhi, ThoiLuong, MoTa FROM KhoaHoc";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemKhoaHoc(string maKH, string tenKH, string trinhDo, decimal hocPhi, int thoiLuong, string moTa)
        {
            string query = "INSERT INTO KhoaHoc VALUES (@Ma, @Ten, @TrinhDo, @HocPhi, @ThoiLuong, @MoTa)";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maKH);
                cmd.Parameters.AddWithValue("@Ten", tenKH);
                cmd.Parameters.AddWithValue("@TrinhDo", trinhDo);
                cmd.Parameters.AddWithValue("@HocPhi", hocPhi);
                cmd.Parameters.AddWithValue("@ThoiLuong", thoiLuong);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool SuaKhoaHoc(string maKH, string tenKH, string trinhDo, decimal hocPhi, int thoiLuong, string moTa)
        {
            string query = "UPDATE KhoaHoc SET TenKH=@Ten, TrinhDo=@TrinhDo, HocPhi=@HocPhi, ThoiLuong=@ThoiLuong, MoTa=@MoTa WHERE MaKH=@Ma";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maKH);
                cmd.Parameters.AddWithValue("@Ten", tenKH);
                cmd.Parameters.AddWithValue("@TrinhDo", trinhDo);
                cmd.Parameters.AddWithValue("@HocPhi", hocPhi);
                cmd.Parameters.AddWithValue("@ThoiLuong", thoiLuong);
                cmd.Parameters.AddWithValue("@MoTa", moTa);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool XoaKhoaHoc(string maKH)
        {
            string query = "DELETE FROM KhoaHoc WHERE MaKH=@Ma";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maKH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}