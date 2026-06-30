using System.Data;
using System.Data.SqlClient;

public class HocVienDAL : QuanLyTrungTamTiengAnh.DAL.IHocVienDAL
{
    string connString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyTrungTamTiengAnh;Integrated Security=True;TrustServerCertificate=True";

    public DataTable LayDanhSach()
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = new SqlConnection(connString))
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HocVien", conn);
            da.Fill(dt);
        }
        return dt;
    }

    public int DemHocVien(string dieuKien)
    {
        using (SqlConnection conn = new SqlConnection(connString))
        {
            conn.Open();
            string sql = "SELECT COUNT(*) FROM HocVien " + dieuKien;
            SqlCommand cmd = new SqlCommand(sql, conn);
            return (int)cmd.ExecuteScalar();
        }
    }
}