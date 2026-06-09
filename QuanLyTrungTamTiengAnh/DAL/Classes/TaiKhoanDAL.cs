using System.Data.SqlClient;
using QuanLyTrungTamTiengAnh.DAL.Classes; // Thay đổi nếu namespace của bạn khác

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public class TaiKhoanDAL : DatabaseConnection
    {
        public bool KiemTraDangNhap(string username, string password)
        {
            using (SqlConnection conn = GetConnection())
            {
                // Câu lệnh SQL: Kiểm tra tài khoản có tồn tại không
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar(); // Trả về số lượng dòng tìm thấy
                return count > 0; // Nếu > 0 nghĩa là tài khoản đúng
            }
        }
    }
}