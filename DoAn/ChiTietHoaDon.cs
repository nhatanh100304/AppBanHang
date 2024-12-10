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
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        DataConect.DataHandle P = new DataConect.DataHandle();   
        private void BT_Test_Click(object sender, EventArgs e)
        {
            DTGV_Test.DataSource = P.LayDuLieu("Select * from ChiTietHoaDon");
        }
    }
}
