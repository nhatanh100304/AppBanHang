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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn
{

    public partial class MenuQuanLy : Form
    {
        private string QuanLy;
        public MenuQuanLy(string userName1)
        {
            InitializeComponent();
            this.QuanLy = userName1;
            LoadQuanLyName();
        }

        void MoFormCon(Form f)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.Name == f.Name)
                {
                    child.Activate();
                    return;
                }
            }
            f.MdiParent = this;
            f.Show();
        }
        private void BT_ThemDuLieu_Click(object sender, EventArgs e)
        {
            ThemDuLieu themDuLieu = new ThemDuLieu();
            themDuLieu.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.ShowDialog();
        }

        private void BT_NhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap nhaCungCap = new NhaCungCap();
            nhaCungCap.ShowDialog();
        }

        private void BT_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
        }

        private void BT_QuanLyTaiKhoa_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            quanLyTaiKhoan.ShowDialog();
        }

        private void MenuQuanLy_Load(object sender, EventArgs e)
        {

        }

        public void LoadQuanLyName()
        {
            TxB_LayTen.Text = QuanLy;
        }





        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MoFormCon(new ThemDuLieu());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MoFormCon(new QuanLyNhanVien());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MoFormCon(new NhaCungCap());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MoFormCon(new ThongKe());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MoFormCon(new QuanLyTaiKhoan());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MoFormCon(new LichSuDangNhap());
        }

        private void TxB_LayTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MoFormCon(new ChiTietHoaDon());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoFormCon(new LienHeAdmin());
        }
    }
}
