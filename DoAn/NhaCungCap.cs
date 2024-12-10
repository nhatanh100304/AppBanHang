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
    public partial class NhaCungCap : Form
    {
        private DataTable dataTable;
        DataConect.DataHandle sql = new DataConect.DataHandle();
        private DataConect.DataHandle sqlProvider = new DataConect.DataHandle();
        public NhaCungCap()
        {
            InitializeComponent();
            DTGW_NhaCungCap.CellClick += DTGW_NhaCungCap_CellClick;

        }

        private void BT_Them_Click(object sender, EventArgs e)
        {
            if (
            string.IsNullOrWhiteSpace(TxB_TenNhaCungCap.Text) ||
            string.IsNullOrWhiteSpace(TxB_SanPhamCungCap.Text) ||
            string.IsNullOrWhiteSpace(TxB_Gmail.Text) ||
            string.IsNullOrWhiteSpace(TxB_DiaChi.Text))


            {

                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {

                string sql = "INSERT INTO NhaCungCap " +
               "VALUES (@TenNhaCungCap,@TenSanPhamCungCap, @DiaChi, @Gmail)";

                try
                {
                    // Tạo một mảng các tham số
                    SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@TenNhaCungCap", SqlDbType.NVarChar, 50) { Value = TxB_TenNhaCungCap.Text },
            new SqlParameter("@TenSanPhamCungCap", SqlDbType.NVarChar, 50) { Value = TxB_SanPhamCungCap.Text },
            new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50) { Value = TxB_DiaChi.Text },
            new SqlParameter("@Gmail", SqlDbType.NVarChar, 50) { Value = (TxB_Gmail.Text) },
                    };


                    // Thực thi câu lệnh SQL sử dụng DataHandle
                    int rowsAffected = sqlProvider.CapNhatDuLieu(sql, parameters);
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

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_SHOW_Click(object sender, EventArgs e)
        {
            DTGW_NhaCungCap.DataSource = sqlProvider.LayDuLieu("select * from NhaCungCap");
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            string sql = " DELETE FROM NhaCungCap " +
                    "WHERE ID = @IDNhaCungCap";

            try
            {
                // Tạo một mảng các tham số
                SqlParameter[] parameters = new SqlParameter[]
                {
                        new SqlParameter("@IDNhaCungCap", SqlDbType.Int) { Value = int.Parse(TxB_ID.Text) },
                        new SqlParameter("@TenNhaCungCap", SqlDbType.NVarChar, 50) { Value = TxB_TenNhaCungCap.Text },
                        new SqlParameter("@SanPhamCungCap", SqlDbType.NVarChar, 50) { Value = TxB_SanPhamCungCap.Text },
                        new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50) { Value = TxB_DiaChi.Text },
                        new SqlParameter("@gmail", SqlDbType.NVarChar,100) { Value = (TxB_Gmail.Text) },
                };
                // Thực thi câu lệnh SQL sử dụng DataHandle
                int rowsAffected = this.sql.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công.");

                }
                else
                {
                    MessageBox.Show("Xóa dự liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BT_ThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate = "Update NhaCungCap " +
                "set TenNhaCungCap = @TenNhaCungCap, SanPhamCungCap = @SanPhamCungCap , DiaChi = @DiaChi , Gmail = @gmail " +
                "Where ID = @IDNhaCungCap"; // Câu lệnh SQL cập nhật dữ liệu

                SqlParameter[] parameterId = new SqlParameter[]
                    {
                new SqlParameter("@IDNhaCungCap", SqlDbType.Int) { Value = int.Parse(TxB_ID.Text) },
                new SqlParameter("@TenNhaCungCap", SqlDbType.NVarChar, 50) { Value = TxB_TenNhaCungCap.Text },
                new SqlParameter("@SanPhamCungCap", SqlDbType.NVarChar, 50) { Value = TxB_SanPhamCungCap.Text },
                new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50) { Value = TxB_DiaChi.Text },
                new SqlParameter("@gmail", SqlDbType.NVarChar,100) { Value = TxB_Gmail.Text }
                    };

                // Thực thi câu lệnh SQL sử dụng DataHandle
                int rowsAffected = sqlProvider.CapNhatDuLieu(sqlUpdate, parameterId);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DTGW_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTGW_NhaCungCap.Rows[e.RowIndex];

                // Điền thông tin từ hàng được chọn lên các TextBox
                TxB_TenNhaCungCap.Text = row.Cells["TenNhaCungCap"].Value.ToString();
                TxB_SanPhamCungCap.Text = row.Cells["SanPhamCungCap"].Value.ToString();
                TxB_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                TxB_Gmail.Text = row.Cells["Gmail"].Value.ToString();
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }
    }
}
