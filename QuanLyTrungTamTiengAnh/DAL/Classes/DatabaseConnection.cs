using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyTrungTamTiengAnh.DAL
{
    public class DatabaseConnection
    {
        // Lấy chuỗi kết nối từ App.config
        protected SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}