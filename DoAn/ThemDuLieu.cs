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
    public partial class ThemDuLieu : Form
    {
        private DataTable dataTable;
        DataConect.DataHandle sql = new DataConect.DataHandle();
        public ThemDuLieu()
        {
            InitializeComponent();
            DTGV_HienThi.CellClick += DTGV_HienThi_CellClick;
        }
        private void ThemDuLieu_Load(object sender, EventArgs e)
        {

            DTGV_HienThi.DataSource = sql.LayDuLieu("select * from HangHoa");

        }

        private void Bt_ThayDoi_Click(object sender, EventArgs e)
        {
            string sql = "Update HangHoa " +
                "set TenSanPham = @TenSanPham, SoLuong = @SoLuong, DonVi = @DonVi,GiaTien = @GiaTien , TenNhaCungCap = @TenNhaCungCap " +
                "Where IDHangHoa = @IDHangHoa";

            try
            {
                // Tạo một mảng các tham số
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDHangHoa", SqlDbType.Int) { Value = int.Parse(TXB_ID.Text) },
                    new SqlParameter("@TenSanPham", SqlDbType.NVarChar, 20) { Value = TxB_SanPham.Text },
                    new SqlParameter("@SoLuong", SqlDbType.Int) { Value = int.Parse(TxB_SoLuong.Text) },
                    new SqlParameter("@DonVi", SqlDbType.NVarChar, 20) { Value = (TXB_DonVi.Text) },
                    new SqlParameter("@GiaTien", SqlDbType.Float) { Value = float.Parse(TxB_GiaTien.Text) },
                    new SqlParameter("@TenNhaCungCap", SqlDbType.NVarChar, 50) { Value = TxB_NhaCungCap.Text }
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

            // Xóa dữ liệu từ các TextBox sau khi thêm vào DataGridView
            //TxB_NhaCungCap.Clear();
            //TxB_SoLuong.Clear();
            //TXB_DonVi.Clear();
            //TxB_GiaTien.Clear();
            //TxB_NhaCungCap.Clear();
            //TxB_SanPham.Focus();

        }


        void HienThi()
        {
            DTGV_HienThi.DataSource = sql.LayDuLieu("select * from HangHoa");
        }




        private void BT_ADD_Click_1(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(TXB_ID.Text) ||
                string.IsNullOrWhiteSpace(TxB_SanPham.Text) ||
                string.IsNullOrWhiteSpace(TxB_SoLuong.Text) ||
                string.IsNullOrWhiteSpace(TXB_DonVi.Text) ||
                string.IsNullOrWhiteSpace(TxB_GiaTien.Text) ||
                string.IsNullOrWhiteSpace(TxB_NhaCungCap.Text))
            {

                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {

                string sql = "INSERT INTO HangHoa " +
               "VALUES (@IDHangHoa,@TenSanPham, @SoLuong, @DonVi, @GiaTien, @NhaCungCap,@ThoiGian)";

                try
                {
                    DateTime dateCheckin = Convert.ToDateTime(DATE_Ngay.Value);
                    string CovertDate = dateCheckin.ToString("yyyy-MM-dd");
                    // Tạo một mảng các tham số
                    SqlParameter[] parameters = new SqlParameter[]
                    {
            new SqlParameter("@IDHangHoa", SqlDbType.Int) { Value = TXB_ID.Text },
            new SqlParameter("@TenSanPham", SqlDbType.NVarChar, 20) { Value = TxB_SanPham.Text },
            new SqlParameter("@SoLuong", SqlDbType.Int) { Value = int.Parse(TxB_SoLuong.Text) },
            new SqlParameter("@DonVi", SqlDbType.NVarChar, 20) { Value = (TXB_DonVi.Text) },
            new SqlParameter("@GiaTien", SqlDbType.Float) { Value = float.Parse(TxB_GiaTien.Text) },
            new SqlParameter("@NhaCungCap", SqlDbType.NVarChar,50) { Value = TxB_NhaCungCap.Text },
            new SqlParameter("@ThoiGian", SqlDbType.Date) { Value = CovertDate}
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
                TxB_NhaCungCap.Clear();
                TxB_SoLuong.Clear();
                TXB_DonVi.Clear();
                TxB_GiaTien.Clear();
                TxB_SanPham.Clear();
                TxB_SanPham.Focus();
            }
            HienThi();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HienThi();
        }


        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu ID nhập vào là hợp lệ
                if (!int.TryParse(TXB_ID.Text, out int idToDelete))
                {
                    MessageBox.Show("Vui lòng nhập một ID hợp lệ để xóa.");
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // ID hợp lệ, sử dụng ID này cho truy vấn
                    int IDhang = idToDelete;

                    using (SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=QuanLyKho;Integrated Security=True"))
                    {
                        conn.Open();

                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Xóa các bản ghi liên quan trong bảng ChiTietHoaDon
                                string deleteDetailsQuery = "DELETE FROM ChiTietHoaDon WHERE ID_HangHoa = @IDHangHoa";
                                using (SqlCommand cmdDeleteDetails = new SqlCommand(deleteDetailsQuery, conn, transaction))
                                {
                                    cmdDeleteDetails.Parameters.AddWithValue("@IDHangHoa", IDhang);
                                    cmdDeleteDetails.ExecuteNonQuery();
                                }

                                // Xóa các bản ghi liên quan trong bảng HoaDon
                                string deleteInvoicesQuery = "DELETE FROM HoaDon WHERE ID_HangHoa = @IDHangHoa";
                                using (SqlCommand cmdDeleteInvoices = new SqlCommand(deleteInvoicesQuery, conn, transaction))
                                {
                                    cmdDeleteInvoices.Parameters.AddWithValue("@IDHangHoa", IDhang);
                                    cmdDeleteInvoices.ExecuteNonQuery();
                                }

                                // Xóa bản ghi trong bảng HangHoa
                                string deleteQuery = "DELETE FROM HangHoa WHERE IDHangHoa = @IDHangHoa";
                                using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn, transaction))
                                {
                                    cmdDelete.Parameters.AddWithValue("@IDHangHoa", IDhang);
                                    int rowsAffected = cmdDelete.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Xóa dữ liệu thành công.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có dữ liệu nào được xóa.");
                                    }
                                }

                                // Commit transaction
                                transaction.Commit();
                            }
                            catch (Exception ex)
                            {
                                // Rollback transaction nếu có lỗi
                                transaction.Rollback();
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }

                        // Gọi hàm hiển thị lại dữ liệu sau khi xóa thành công
                        HienThi();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DTGV_HienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTGV_HienThi.Rows[e.RowIndex];

                // Điền thông tin từ hàng được chọn lên các TextBox
                TXB_ID.Text = row.Cells["IDHangHoa"].Value.ToString();
                TxB_SanPham.Text = row.Cells["TenSanPham"].Value.ToString();
                TxB_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                TXB_DonVi.Text = row.Cells["DonVi"].Value.ToString();
                TxB_GiaTien.Text = row.Cells["GiaTien"].Value.ToString();
                TxB_NhaCungCap.Text = row.Cells["TenNhaCungCap"].Value.ToString();
            }
        }

        private void BT_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Chọn file dữ liệu để thêm vào";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');

                        // Kiểm tra độ dài của mảng data phải là 6 (nếu không thì dữ liệu không hợp lệ)
                        if (data.Length == 6)
                        {
                            // Kiểm tra và chuyển đổi dữ liệu
                            int idHangHoa;
                            if (!int.TryParse(data[0], out idHangHoa))
                            {
                                throw new ArgumentException("ID sản phẩm không hợp lệ.");
                            }

                            string tenSanPham = data[1];

                            int soLuong;
                            if (!int.TryParse(data[2], out soLuong))
                            {
                                throw new ArgumentException("Số lượng không hợp lệ.");
                            }

                            string donVi = data[3];

                            float giaTien;
                            if (!float.TryParse(data[4], out giaTien))
                            {
                                throw new ArgumentException("Giá tiền không hợp lệ.");
                            }

                            string tenNhaCungCap = data[5];

                            // Thực hiện thêm vào cơ sở dữ liệu
                            string sql = "INSERT INTO HangHoa (IDHangHoa, TenSanPham, SoLuong, DonVi, GiaTien, TenNhaCungCap) " +
                                         "VALUES (@IDHangHoa, @TenSanPham, @SoLuong, @DonVi, @GiaTien, @TenNhaCungCap)";

                            SqlParameter[] parameters = new SqlParameter[]
                            {
                        new SqlParameter("@IDHangHoa", SqlDbType.Int) { Value = idHangHoa },
                        new SqlParameter("@TenSanPham", SqlDbType.NVarChar, 20) { Value = tenSanPham },
                        new SqlParameter("@SoLuong", SqlDbType.Int) { Value = soLuong },
                        new SqlParameter("@DonVi", SqlDbType.NVarChar, 20) { Value = donVi },
                        new SqlParameter("@GiaTien", SqlDbType.Float) { Value = giaTien },
                        new SqlParameter("@TenNhaCungCap", SqlDbType.NVarChar, 50) { Value = tenNhaCungCap }
                            };

                            int rowsAffected = this.sql.CapNhatDuLieu(sql, parameters);

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Thêm dữ liệu thành công từ file.");
                            }
                            else
                            {
                                MessageBox.Show("Thêm dữ liệu từ file thất bại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu từ file không hợp lệ. Vui lòng kiểm tra lại định dạng file.");
                        }
                    }

                    // Hiển thị lại dữ liệu sau khi thêm thành công
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        }
    }
}




