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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoAn

{
    public partial class ThongKe : Form

    {
        private DataTable dataTable;
        DataConect.DataHandle sql = new DataConect.DataHandle();


        public ThongKe()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThemDuLieu F2 = new ThemDuLieu();
            F2.ShowDialog();
            this.Hide();
        }

        private void BT_Show_Click(object sender, EventArgs e)
        {
            DGW_View.DataSource = sql.LayDuLieu("select TenSanPham,SoLuong,DonVi,GiaTien from HangHoa");
        }

        private void Bt_TimKiem_Click(object sender, EventArgs e)
        {
            string sqlDelete = "SELECT TenSanPham,SoLuong from HangHoa WHERE TenSanPham like N'%" + TxB_TimKiem.Text + "%'";
            DGW_View.DataSource = sql.LayDuLieu(sqlDelete);

        }

        private void BT_TangDan_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TenSanPham AS N'Tên Sản Phẩm', SoLuong AS N'Số Lượng', GiaTien AS N'Giá tiền'" +
                       " FROM HangHoa" +
                       " ORDER BY SoLuong ASC";

            DGW_View.DataSource = sql.LayDuLieu(sqlSelect);

        }

        private void Bt_GiamDan_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TenSanPham AS N'Tên Sản Phẩm', SoLuong AS N'Số Lượng', GiaTien AS N'Giá tiền'" +
                       " FROM HangHoa" +
                       " ORDER BY SoLuong DESC";

            DGW_View.DataSource = sql.LayDuLieu(sqlSelect);
        }

        private void Bt_AZ_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TenSanPham AS N'Tên Sản Phẩm', SoLuong AS N'Đếm'" +
                       " FROM HangHoa" +
                       " ORDER BY TenSanPham COLLATE Vietnamese_CI_AI, SoLuong ASC";

            DGW_View.DataSource = sql.LayDuLieu(sqlSelect);
        }

        private void BT_ZA_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TenSanPham AS N'Tên Sản Phẩm', SoLuong AS N'Đếm'" +
                       " FROM HangHoa" +
                       " ORDER BY TenSanPham COLLATE Vietnamese_CI_AI DESC, SoLuong ASC";

            DGW_View.DataSource = sql.LayDuLieu(sqlSelect);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void BT_ReNhat_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TenSanPham AS N'Tên Sản Phẩm', SoLuong AS N'Số Lượng',GiaTien AS N'Giá tiền'" +
              " FROM HangHoa" +
              " ORDER BY GiaTien ASC";

            DGW_View.DataSource = sql.LayDuLieu(sqlSelect);
        }

        private void Bt_MacNhat_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT TenSanPham AS N'Tên Sản Phẩm', SoLuong AS N'Số Lượng', GiaTien AS N'Giá tiền'" +
               " FROM HangHoa" +
               " ORDER BY GiaTien DESC";

            DGW_View.DataSource = sql.LayDuLieu(sqlSelect);
        }
    }
}
