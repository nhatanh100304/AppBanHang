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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();

        }

        private void Bt_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = TxB_TaiKhoan.Text;
            string password = TxB_MatKhau.Text;

            if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
            }
            else
            {
                // Kiểm tra đăng nhập và lấy loại tài khoản
                string loaiTaiKhoan = AccountDAO.Instance.KiemTraDangNhap(userName, password);
                int type = Convert.ToInt32(loaiTaiKhoan);
                if (loaiTaiKhoan != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    // Xử lý theo loại tài khoản (ví dụ: mở form tương ứng)
                    if (type == 1)
                    {

                        MenuQuanLy menuQuanLy = new MenuQuanLy(userName);
                        menuQuanLy.ShowDialog();
                    }
                    else if (type == 0)
                    {
                        (new MenuNhanVien(userName)).ShowDialog();
                    }
                    else
                    {
                        // Xử lý trường hợp loại tài khoản khác
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
            List<string> content = new List<string>();

            string dateTimeString = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");

            content.Add($"Ngày và giờ: {dateTimeString}");
            content.Add("Name Account: " + userName + "\n");

            String filePathInfo = Path.Combine(Application.StartupPath, "LichSuDangNhap.txt");


            using (StreamWriter writer = new StreamWriter(filePathInfo, append: true))
            {
                foreach (var line in content)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát? ", "Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TxB_MatKhau.PasswordChar = '\0';
            }
            else
            {
                TxB_MatKhau.PasswordChar = '*';
            }
        }

        private void TxB_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


