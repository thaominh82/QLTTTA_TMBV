using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Interfaces;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class HocVienDAL : IHocVienDAL
    {
        public DataTable LayDanhSachHocVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaHV, HoTen, NgaySinh, GioiTinh, SDT FROM HocVien";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public bool ThemHocVien(string maHV, string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, string email, string diaChi, string trangThai)
        {
            string query = "INSERT INTO HocVien (MaHV, HoTen, NgaySinh, GioiTinh, SDT) VALUES (@Ma, @Ten, @NgaySinh, @GioiTinh, @SDT)";
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maHV);
                cmd.Parameters.AddWithValue("@Ten", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}