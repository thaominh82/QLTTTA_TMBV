using System.Configuration; // Phải có dòng này
using System.Data.SqlClient;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public static class DatabaseConnection
    {
        // Lấy chuỗi kết nối từ App.config thay vì để cứng
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyDbConn"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}