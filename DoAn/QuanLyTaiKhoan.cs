using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class QuanLyTaiKhoan : Form
    {
        private DataTable dataTable;
        DataConect.DataHandle sql = new DataConect.DataHandle();
        private DataConect.DataHandle sqlProvider = new DataConect.DataHandle();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void BT_XacNhan_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(TxB_LoaiTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(TxB_TenTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(TxB_MatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                string sql = "INSERT INTO Account (LoaiTaiKhoan, TaiKhoan, MatKhau) " +
                             "VALUES (@loaiTaiKhoan, @TaiKhoan, @MatKhau)";

                try
                {
                    // Tạo một mảng các tham số
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@loaiTaiKhoan", SqlDbType.Int) { Value = int.Parse(TxB_LoaiTaiKhoan.Text) },
                new SqlParameter("@TaiKhoan", SqlDbType.NVarChar, 20) { Value = TxB_TenTaiKhoan.Text },
                new SqlParameter("@MatKhau", SqlDbType.VarChar, 20) { Value = TxB_MatKhau.Text }
                    };

                    // Thực thi câu lệnh SQL sử dụng DataHandle
                    int rowsAffected = this.sql.CapNhatDuLieu(sql, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                // Xóa dữ liệu từ các TextBox sau khi thêm vào DataGridView
                TxB_LoaiTaiKhoan.Clear();
                TxB_TenTaiKhoan.Clear();
                TxB_MatKhau.Clear();
            }
        }

        private void BT_Show_Click(object sender, EventArgs e)
        {
            DataTable dt = sql.LayDuLieu("SELECT * FROM Account");
            DTGW_Show.DataSource = dt;


        }

        private void ThayDoi_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Account " +
                         "SET LoaiTaiKhoan = @loaiTaiKhoan, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau " +
                         "WHERE ID = @ID";

            try
            {
                // Tạo một mảng các tham số
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ID", SqlDbType.Int) { Value = int.Parse(TxB_ID.Text) },
            new SqlParameter("@loaiTaiKhoan", SqlDbType.Int) { Value = int.Parse(TxB_LoaiTaiKhoan.Text) },
            new SqlParameter("@TaiKhoan", SqlDbType.NVarChar, 20) { Value = TxB_TenTaiKhoan.Text },
            new SqlParameter("@MatKhau", SqlDbType.VarChar, 20) { Value = TxB_MatKhau.Text }
                };

                // Thực thi câu lệnh SQL sử dụng DataHandle
                int rowsAffected = this.sql.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thay đổi dữ liệu thành công.");
                }
                else
                {
                    MessageBox.Show("Thay đổi dữ liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlDelete = "DELETE FROM Account " +
                    "WHERE ID = @ID"; // Câu lệnh SQL xóa dữ liệu

                SqlParameter[] parameterId = new SqlParameter[]
                    {
                        new SqlParameter("@ID", SqlDbType.Int) { Value = int.Parse(TxB_ID.Text) },
                    };
                // Thực thi câu lệnh SQL sử dụng DataHandle
                int rowsAffected = this.sql.CapNhatDuLieu(sqlDelete, parameterId);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công.");

                    // Sau khi xóa, bạn có thể gọi hàm tải lại dữ liệu từ cơ sở dữ liệu (ví dụ: LoadDuLieuTuDatabase();)
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DTGW_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một dòng hợp lệ
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTGW_Show.Rows[e.RowIndex];

                // Điền thông tin từ hàng được chọn lên các TextBox
                TxB_ID.Text = row.Cells["ID"].Value.ToString();
                TxB_LoaiTaiKhoan.Text = row.Cells["LoaiTaiKhoan"].Value.ToString();
                TxB_TenTaiKhoan.Text = row.Cells["TaiKhoan"].Value.ToString();
                TxB_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }

        private void HienThiDuLieu()
        {
            DataTable dt = sql.LayDuLieu("SELECT * FROM Account");
            DTGW_Show.DataSource = dt;
        }
    }
 }
