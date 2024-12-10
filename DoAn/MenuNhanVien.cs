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
    public partial class MenuNhanVien : Form
    {
        private string NhanVien;
        public MenuNhanVien(string NhanVien)
        {
            InitializeComponent();
            this.NhanVien = NhanVien;
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


        private void button1_Click(object sender, EventArgs e)
        {
            string TenNhanVien = TxB_LayTen.Text;
            LapHoaDon xuatHang = new LapHoaDon(TenNhanVien);
            xuatHang.ShowDialog();

        }
        public void LoadQuanLyName()
        {
            TxB_LayTen.Text = NhanVien;
        }

        private void MenuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MoFormCon(new ThongKe());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String LayTen = TxB_LayTen.Text;
            MoFormCon(new LapHoaDon(LayTen));
        }

    }
}
