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
            // Lấy thêm cột TrangThai để hiển thị lên DataGridView
            string query = "SELECT MaGV, HoTen, SDT, Email, ChuyenMon, TrangThai FROM GiaoVien";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemGiaoVien(string maGV, string hoTen, string sdt, string email, string chuyenMon, string trangThai)
        {
            string query = "INSERT INTO GiaoVien VALUES (@Ma, @Ten, @SDT, @Email, @ChuyenMon, @TrangThai)";
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
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maGV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Hàm hỗ trợ dùng chung để tránh lặp code
        private bool ExecuteCommand(string query, string ma, string ten, string sdt, string email, string cm, string tt)
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
    }
}