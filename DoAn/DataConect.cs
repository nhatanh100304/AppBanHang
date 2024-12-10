using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    class DataConect
    {
        internal class DataHandle
        {
            private string connectionString = File.ReadAllText(Application.StartupPath + "\\Connect\\Connect.txt");

            public DataTable LayDuLieu(string sql, SqlParameter[] parameters = null)
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        if (parameters != null)
                        {
                            adapter.SelectCommand.Parameters.AddRange(parameters);
                        }
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi lấy dữ liệu: " + ex.Message);
                    }
                }
                return dt;
            }

            public int CapNhatDuLieu(string sql, SqlParameter[] parameters = null)
            {
                int kq = -1;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        kq = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
                    }
                }
                return kq;
            }

            internal int CapNhatDuLieu(string sqlDelete, SqlParameter parameterId)
            {
                throw new NotImplementedException();
            }

            internal int CapNhatDuLieu(string sqlDeleteChiTiet, SqlParameter[] parameterId, SqlTransaction transaction)
            {
                throw new NotImplementedException();
            }
        }

        internal DataTable LayDuLieu(string sql)
        {
            throw new NotImplementedException();
        }
    }
}