    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class TypeDAO
    {
        private string connectionString = "Data Source=MSI;Initial Catalog=QuanLyKho;Integrated Security=True";

        private static TypeDAO instance;

        public static TypeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TypeDAO();
                return instance;
            }
        }

        private TypeDAO() { }

        public int LayTypeTheoUsername(string username)
        {
            int userType = 0 ; // Giá trị mặc định

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT LoaiTaiKhoan FROM Account " +
                    "WHERE TaiKhoan = @TaiKhoan";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@TaiKhoan", username);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        userType = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi lấy giá trị Type từ cơ sở dữ liệu: " + ex.Message);
                }
            }

            return userType;
        }
    }
}
