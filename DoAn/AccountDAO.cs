using System;
using System.Data.SqlClient;

namespace DoAn
{
    public class AccountDAO
    {
        private string connectionString = File.ReadAllText(Application.StartupPath + "\\Connect\\Connect.txt");

        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
        }

        private AccountDAO() { }

        public string KiemTraDangNhap(string userName, string password)
        {
            string loaiTaiKhoan = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT LoaiTaiKhoan FROM Account WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@TaiKhoan", userName);
                command.Parameters.AddWithValue("@MatKhau", password);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null) // Nếu có kết quả trả về
                    {
                        loaiTaiKhoan = result.ToString(); // Lấy loại tài khoản
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi đăng nhập: " + ex.Message);
                }
            }
            return loaiTaiKhoan; // Trả về loại tài khoản của người dùng sau khi đăng nhập thành công
        }
    }
}