using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class LienHeAdmin : Form
    {
        public LienHeAdmin()
        {
            InitializeComponent();
        }

        private void BT_Gui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxB_YeuCau.Text))
            {
                MessageBox.Show("Chưa có yêu cầu");
            }
            else
            {
                string emailFrom = "nguyenhuynhnhatanh100304@gmail.com";
                string emailPassword = "aiwcmgobzydhmwxq";

                string emailTo = "nguyenhuynhnhatanh100304@gmail.com";  // Địa chỉ email người nhận

                // Nội dung email
                string subject = "Ứng dụng gặp sự cố"; // Tiêu đề email
                string body = TxB_YeuCau.Text;

                try
                {
                    // Tạo đối tượng MailMessage
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;

                    // Cấu hình SmtpClient
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // SMTP server của Gmail
                    smtpClient.Port = 587; // Cổng SMTP của Gmail cho TLS
                    smtpClient.Credentials = new NetworkCredential(emailFrom, emailPassword);
                    smtpClient.EnableSsl = true; // Sử dụng SSL

                    // Gửi email
                    smtpClient.Send(mail);

                    MessageBox.Show("Yêu cầu đã được gửi đến admin.Chờ từ 10-15p sẽ có đội ngũ hỗ trợ và liên lạc cho bạn");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gửi thất bại. Mã lỗi: " + ex.Message);
                }
                TxB_YeuCau.Clear();
            }

        }

        private void LienHeAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}

