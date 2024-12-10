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
    public partial class QuanLyNhanVien : Form
    {
        private DataTable dataTable;
        DataConect.DataHandle sql = new DataConect.DataHandle();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void BT_Show_Click(object sender, EventArgs e)
        {
            DTGW_NhanVien.DataSource = sql.LayDuLieu("select * from NhanVien");
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txb_LoaiTk.Text) ||
               string.IsNullOrWhiteSpace(Txb_Ten.Text) ||
               string.IsNullOrWhiteSpace(TxB_NgaySinh.Text) ||
               string.IsNullOrWhiteSpace(TxB_DiaChi.Text) ||
               string.IsNullOrWhiteSpace(TxB_SoDienThoai.Text))
            {

                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {

                string sql = "INSERT INTO NhanVien " +
               "VALUES (@LoaiTaiKhoan, @TenNhanVien, @NgaySinh, @DiaChi,@SoDienThoai)";

                try
                {
                    DateTime dateCheckin = Convert.ToDateTime(TxB_NgaySinh.Text);
                    string CovertDate = dateCheckin.ToString("yyyy-MM-dd");
                    // Tạo một mảng các tham số
                    SqlParameter[] parameters = new SqlParameter[]
                    {

            new SqlParameter("@LoaiTaiKhoan", SqlDbType.Int) { Value =int.Parse(Txb_LoaiTk.Text) },
            new SqlParameter("@TenNhanVien", SqlDbType.NVarChar, 50 ) { Value = (Txb_Ten.Text) },
            new SqlParameter("@NgaySinh", SqlDbType.Date) {Value = CovertDate},
            new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50 ) {  Value = (TxB_DiaChi.Text) },
            new SqlParameter("@SoDienThoai", SqlDbType.Int) { Value =int.Parse(TxB_SoDienThoai.Text) },

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
                TxB_ID.Clear();
                Txb_Ten.Clear();
                Txb_LoaiTk.Clear();
                TxB_NgaySinh.Clear();
                TxB_DiaChi.Clear();
                TxB_SoDienThoai.Clear();
                Txb_Ten.Focus();
            }
        }

        private void BT_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlDelete = "DELETE FROM NhanVien " +
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

        private void BT_ThayDoi_Click(object sender, EventArgs e)
        {
            string sql = "Update NhanVien" +
                " set LoaiTaiKhoan = @LoaiTaiKhoan , TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh,DiaChi = @DiaChi , SoDienThoai = @SoDienThoai " +
                "Where Id = @ID";

            try
            {
                DateTime dateCheckin = Convert.ToDateTime(TxB_NgaySinh.Text);
                string CovertDate = dateCheckin.ToString("yyyy-MM-dd");
                // Tạo một mảng các tham số
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ID", SqlDbType.Int) { Value = int.Parse(TxB_ID.Text) },
            new SqlParameter("@LoaiTaiKhoan", SqlDbType.Int) { Value =int.Parse(Txb_LoaiTk.Text) },
            new SqlParameter("@TenNhanVien", SqlDbType.NVarChar, 50 ) { Value = (Txb_Ten.Text) },
            new SqlParameter("@NgaySinh", SqlDbType.Date) {Value = CovertDate},
            new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50 ) {  Value = (TxB_DiaChi.Text) },
            new SqlParameter("@SoDienThoai", SqlDbType.Int) { Value =int.Parse(TxB_SoDienThoai.Text) },

                };
                // Thực thi câu lệnh SQL sử dụng DataHandle
                int rowsAffected = this.sql.CapNhatDuLieu(sql, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thay đổi thành công.");

                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            TxB_ID.Clear();
            Txb_Ten.Clear();
            Txb_LoaiTk.Clear();
            TxB_NgaySinh.Clear();
            TxB_DiaChi.Clear();
            TxB_SoDienThoai.Clear();
            Txb_Ten.Focus();
        }
    }
}
