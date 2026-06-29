using System.Data.SqlClient;

namespace QuanLyTrungTamTiengAnh.DAL.Classes
{
    public static class DatabaseConnection
    {
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyTrungTamTiengAnh;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}