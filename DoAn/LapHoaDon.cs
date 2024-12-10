using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn
{
    public partial class LapHoaDon : Form
    {
        private DataTable dataTable;
        DataConect.DataHandle sql = new DataConect.DataHandle();
        private DataConect.DataHandle sqlProvider = new DataConect.DataHandle();
        private string TenNhanVien;
        private PrintDocument printDocument1 = new PrintDocument();
        private string printContent = string.Empty;

        public LapHoaDon(string TenNhanVien)
        {
            this.TenNhanVien = TenNhanVien;
            InitializeComponent();
            loadHangHoa();
            NhanVienTruc();
            loadHoaDon();
            createDataGV();
        }

        public void NhanVienTruc()
        {
            TxB_NhanVienTruc.Text = TenNhanVien;
        }
        void loadHangHoa()
        {
            DTW_View.DataSource = sql.LayDuLieu("select IDHangHoa,TenSanPham,SoLuong from HangHoa");
        }
        void loadHoaDon()
        {
            DTW_View.DataSource = sqlProvider.LayDuLieu("Select * from HangHoa");
        }

        private void DTW_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadHangHoa();
        }

        private void BT_xacNhan_Click(object sender, EventArgs e)
        {
            Xuat();
        }

        private void BT_DeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDelete = "DELETE FROM HoaDon"; // Câu lệnh SQL xóa toàn bộ dữ liệu

                // Thực thi câu lệnh SQL sử dụng DataHandle
                int rowsAffected = this.sql.CapNhatDuLieu(sqlDelete);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công.");

                    // Sau khi xóa, bạn có thể gọi hàm tải lại dữ liệu từ cơ sở dữ liệu (ví dụ: LoadDuLieuTuDatabase();)
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTW_Xuat.DataSource = sql.LayDuLieu("Select * from HoaDon");
        }

        private void XuatHang_Load(object sender, EventArgs e)
        {

        }


        private void BT_XacNhanHoaDon_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in DTW_Xuat.Rows)
            {
                if (!row.IsNewRow)
                {
                    int quantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["GiaTien"].Value);
                    decimal totalLinePrice = quantity * price;
                    totalPrice += totalLinePrice;
                }
            }
            TxB_TongTien.Text = totalPrice.ToString();
        }

        private void BT_ShowGiaTien_Click(object sender, EventArgs e)
        {
            string sql = "select GiaTien from HangHoa Where IDHangHoa = " + TxB_ID.Text + " ";
            DataTable dt = sqlProvider.LayDuLieu(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                TxB_GiaTien.Text = dr["GiaTien"].ToString();
            }
        }
        void Xuat()
        {
            if (string.IsNullOrWhiteSpace(TxB_SoLuong.Text) || string.IsNullOrWhiteSpace(TxB_ID.Text) || string.IsNullOrWhiteSpace(TxB_GiaTien.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                string idProduct = TxB_ID.Text;
                int soLuong = int.Parse(TxB_SoLuong.Text);
                float giaTien = float.Parse(TxB_GiaTien.Text);
                DateTime ngayLap = dateTimePicker1.Value;
                string tenNhanVienLap = TxB_NhanVienTruc.Text;

                bool productExists = false;
                foreach (DataGridViewRow row in DTW_Xuat.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string existingIdProduct = row.Cells["IDHangHoa"].Value?.ToString();

                        if (existingIdProduct == idProduct)
                        {
                            int existingQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            int newQuantity = existingQuantity + soLuong;

                            if (newQuantity > 0)
                            {
                                row.Cells["SoLuong"].Value = newQuantity;
                                row.Cells["GiaTien"].Value = giaTien * newQuantity;
                            }
                            else
                            {

                                DTW_Xuat.Rows.Remove(row);
                            }

                            productExists = true;
                            break;
                        }
                    }
                }

                if (!productExists && soLuong > 0)
                {
                    dataTable.Rows.Add(ngayLap, idProduct, soLuong, giaTien * soLuong, tenNhanVienLap);
                }
            }

        }
        void createDataGV()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("NgayLap");
            dataTable.Columns.Add("IDHangHoa");
            dataTable.Columns.Add("SoLuong");
            dataTable.Columns.Add("GiaTien");
            dataTable.Columns.Add("TenNhanVienLap");


            DTW_Xuat.DataSource = dataTable;
        }

        private void BT_ThanhToan_Click_1(object sender, EventArgs e)
        {

            string sql = "INSERT INTO HoaDon " +
           "VALUES (@ThoiGian,@SoLuong,@IDHangHoa,@NguoiLap,@GiaTien)";

            foreach (DataGridViewRow row in DTW_Xuat.Rows)
            {
                if (!row.IsNewRow)
                {
                    List<SqlParameter> parameters = new List<SqlParameter>
                        {
                            new SqlParameter("@ThoiGian", SqlDbType.Date) { Value =  Convert.ToDateTime(row.Cells["NgayLap"].Value).ToString("yyyy-MM-dd")},
                            new SqlParameter("@IDHangHoa", SqlDbType.Int) { Value = row.Cells["IDHangHoa"].Value.ToString() },
                            new SqlParameter("@SoLuong", SqlDbType.Int) { Value = Convert.ToInt32(row.Cells["SoLuong"].Value) },
                            new SqlParameter("@GiaTien", SqlDbType.Float) { Value = Convert.ToSingle(row.Cells["GiaTien"].Value) },
                            new SqlParameter("@NguoiLap", SqlDbType.NVarChar , 50) { Value = row.Cells["TenNhanVienLap"].Value.ToString() }
                        };
                    try
                    {
                        int rowsAffected = sqlProvider.CapNhatDuLieu(sql, parameters.ToArray());

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thanh toán thành công,hóa đơn đã được lưu !.");
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán thất bại!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }


                }

            }

            // Xóa dữ liệu từ các TextBox sau khi thêm vào DataGridView   

        }

        private void BT_Huy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxB_SoLuong.Text) || string.IsNullOrWhiteSpace(TxB_ID.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                string idProduct = TxB_ID.Text;
                int soLuong = int.Parse(TxB_SoLuong.Text);

                foreach (DataGridViewRow row in DTW_Xuat.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string existingIdProduct = row.Cells["IDHangHoa"].Value?.ToString();

                        if (existingIdProduct == idProduct)
                        {
                            int existingQuantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                            int newQuantity = existingQuantity - soLuong;

                            if (newQuantity > 0)
                            {
                                row.Cells["SoLuong"].Value = newQuantity;
                                float giaTien = float.Parse(TxB_GiaTien.Text);
                                row.Cells["GiaTien"].Value = giaTien * newQuantity;
                            }
                            else
                            {
                                DTW_Xuat.Rows.Remove(row);
                            }

                            break;
                        }
                    }
                }
            }
            loadHangHoa();
            
        }

        private void BT_DeleteAll_Click_1(object sender, EventArgs e)
        {

        }

        private void BT_ThanhTien_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxB_GiamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị giảm giá.");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxB_TongTien.Text))
            {
                MessageBox.Show("Vui lòng nhập tổng tiền.");
                return;
            }

            try
            {
                float totalPrice = float.Parse(TxB_TongTien.Text);
                int GiamGia = int.Parse(TxB_GiamGia.Text);

                // Corrected calculation for discount
                float TongTienSauGiam = totalPrice * (1 - (GiamGia / 100f));
                TxB_Tong.Text = TongTienSauGiam.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho tổng tiền và giảm giá.");
            }
        }

        private void BT_In_Click(object sender, EventArgs e)
        {
            PrepareInvoiceContent(); // Chuẩn bị nội dung hóa đơn
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void PrepareInvoiceContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hóa đơn");
            sb.AppendLine("======================================");
            foreach (DataGridViewRow row in DTW_Xuat.Rows)
            {
                if (!row.IsNewRow)
                {
                    sb.AppendLine($"ID: {row.Cells["IDHangHoa"].Value.ToString()}");
                    sb.AppendLine($"Số lượng: {row.Cells["SoLuong"].Value.ToString()}");
                    sb.AppendLine($"Giá tiền: {row.Cells["GiaTien"].Value.ToString()}");
                    sb.AppendLine($"Người lập: {row.Cells["TenNhanVienLap"].Value.ToString()}");
                    sb.AppendLine("--------------------------------------");
                }
            }
            sb.AppendLine($"Tổng tiền: {TxB_TongTien.Text}");
            sb.AppendLine($"Giảm giá: {TxB_GiamGia.Text}%");
            sb.AppendLine($"Tổng tiền sau giảm: {TxB_Tong.Text}");
            sb.AppendLine("======================================");
            sb.AppendLine($"Ngày lập: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");

            printContent = sb.ToString();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printContent, new Font("Arial", 12), Brushes.Black, 10, 25);
        }

        private void DTW_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTW_View.DataSource = sql.LayDuLieu("select * from HangHoa");
        }
    }
}



