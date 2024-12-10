using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class LichSuDangNhap : Form
    {
        public LichSuDangNhap()
        {
            InitializeComponent();
        }

        public void LoadDataFromFile(string filePathInfo)
        {
            string[] lines = File.ReadAllLines(filePathInfo);

            // Tạo DataTable để lưu dữ liệu từ tập tin
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Date");



            // Thêm dữ liệu từ tập tin vào DataTable
            foreach (string line in lines)
            {
                string[] fields = line.Split('\t'); // Phân tách dữ liệu bằng dấu tab (\t) hoặc ký tự phù hợp khác
                dataTable.Rows.Add(fields);
            }

            // Hiển thị dữ liệu trong DataTable lên DataGridView
            DTGW_Check.DataSource = dataTable;
        }

        private void BT_Check_Click(object sender, EventArgs e)
        {
            string filePathInfo = @"E:\C#\DoAn\DoAn\bin\Debug\net8.0-windows8.0\LichSuDangNhap.txt";
            LichSuDangNhap b = new LichSuDangNhap();
            b.LoadDataFromFile(filePathInfo);
            b.Show();

        }

        private void LichSuDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

