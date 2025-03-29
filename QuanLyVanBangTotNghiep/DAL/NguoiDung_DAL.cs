using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVanBangTotNghiep.DAL
{
    public class NguoiDung_DAL
    {
        private string connectionString = "Data Source = 192.168.0.112, 1433; Initial Catalog = QuanLyVanBang; User ID = HN; Password = 180805";
        public string DangNhap (string tenDangNhap, string matKhau)
        {
            string loaiNguoiDung = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT Loai_NguoiDung FROM dbo.dm_NguoiDung WHERE Ten_Dang_Nhap = @tenDangNhap AND Mat_Khau = @matKhau";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@matKhau", matKhau);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        loaiNguoiDung = result.ToString();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi đăng nhập: " + ex.Message);
                }
            }
            return loaiNguoiDung;
        }

    }
}
