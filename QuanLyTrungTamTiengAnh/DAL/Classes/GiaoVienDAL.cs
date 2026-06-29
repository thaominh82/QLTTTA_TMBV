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
            string query = "SELECT MaGV, HoTen, SDT, Email, ChuyenMon FROM GiaoVien";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemGiaoVien(string maGV, string hoTen, string sdt, string email, string chuyenMon)
        {
            string query = "INSERT INTO GiaoVien (MaGV, HoTen, SDT, Email, ChuyenMon) VALUES (@Ma, @Ten, @SDT, @Email, @ChuyenMon)";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maGV);
                cmd.Parameters.AddWithValue("@Ten", hoTen);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@ChuyenMon", chuyenMon);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}