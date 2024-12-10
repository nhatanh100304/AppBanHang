namespace DoAn
{
    partial class LapHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DTW_View = new DataGridView();
            DTW_Xuat = new DataGridView();
            BT_xacNhan = new Button();
            TxB_ID = new TextBox();
            BT_ThanhToan = new Button();
            label5 = new Label();
            label6 = new Label();
            TxB_SoLuong = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            TxB_NhanVienTruc = new TextBox();
            label4 = new Label();
            BT_Huy = new Button();
            TxB_TongTien = new TextBox();
            TxB_GiamGia = new TextBox();
            TxB_Tong = new TextBox();
            BT_XacNhanHoaDon = new Button();
            BT_ThanhTien = new Button();
            TxB_GiaTien = new TextBox();
            lbGiaTien = new Label();
            BT_ShowGiaTien = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BT_In = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)DTW_View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTW_Xuat).BeginInit();
            SuspendLayout();
            // 
            // DTW_View
            // 
            DTW_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTW_View.Location = new Point(12, 57);
            DTW_View.Name = "DTW_View";
            DTW_View.RowHeadersWidth = 51;
            DTW_View.Size = new Size(452, 381);
            DTW_View.TabIndex = 0;
            DTW_View.CellClick += DTW_View_CellClick;
            DTW_View.CellContentClick += DTW_View_CellContentClick;
            // 
            // DTW_Xuat
            // 
            DTW_Xuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTW_Xuat.Location = new Point(805, 57);
            DTW_Xuat.Name = "DTW_Xuat";
            DTW_Xuat.RowHeadersWidth = 51;
            DTW_Xuat.Size = new Size(492, 381);
            DTW_Xuat.TabIndex = 1;
            // 
            // BT_xacNhan
            // 
            BT_xacNhan.Location = new Point(495, 366);
            BT_xacNhan.Name = "BT_xacNhan";
            BT_xacNhan.Size = new Size(82, 33);
            BT_xacNhan.TabIndex = 2;
            BT_xacNhan.Text = "Xác nhận";
            BT_xacNhan.UseVisualStyleBackColor = true;
            BT_xacNhan.Click += BT_xacNhan_Click;
            // 
            // TxB_ID
            // 
            TxB_ID.Location = new Point(495, 137);
            TxB_ID.Name = "TxB_ID";
            TxB_ID.Size = new Size(238, 27);
            TxB_ID.TabIndex = 3;
            // 
            // BT_ThanhToan
            // 
            BT_ThanhToan.Location = new Point(1429, 318);
            BT_ThanhToan.Name = "BT_ThanhToan";
            BT_ThanhToan.Size = new Size(87, 92);
            BT_ThanhToan.TabIndex = 5;
            BT_ThanhToan.Text = "Thanh Toán";
            BT_ThanhToan.UseVisualStyleBackColor = true;
            BT_ThanhToan.Click += BT_ThanhToan_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(690, 357);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 114);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 13;
            label6.Text = "ID";
            // 
            // TxB_SoLuong
            // 
            TxB_SoLuong.Location = new Point(495, 202);
            TxB_SoLuong.Name = "TxB_SoLuong";
            TxB_SoLuong.Size = new Size(238, 27);
            TxB_SoLuong.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(495, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 179);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 16;
            label1.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 17;
            label2.Text = "Danh sách sản phẩm ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(805, 34);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 18;
            label3.Text = "Danh sách hàng được thêm ";
            // 
            // button1
            // 
            button1.Location = new Point(805, 444);
            button1.Name = "button1";
            button1.Size = new Size(117, 27);
            button1.TabIndex = 19;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxB_NhanVienTruc
            // 
            TxB_NhanVienTruc.Location = new Point(1412, 12);
            TxB_NhanVienTruc.Name = "TxB_NhanVienTruc";
            TxB_NhanVienTruc.ReadOnly = true;
            TxB_NhanVienTruc.Size = new Size(138, 27);
            TxB_NhanVienTruc.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1266, 22);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 21;
            label4.Text = "Nhân viên đang trực";
            // 
            // BT_Huy
            // 
            BT_Huy.Location = new Point(645, 321);
            BT_Huy.Name = "BT_Huy";
            BT_Huy.Size = new Size(82, 33);
            BT_Huy.TabIndex = 22;
            BT_Huy.Text = "Hủy";
            BT_Huy.UseVisualStyleBackColor = true;
            BT_Huy.Click += BT_Huy_Click;
            // 
            // TxB_TongTien
            // 
            TxB_TongTien.Location = new Point(1319, 76);
            TxB_TongTien.Name = "TxB_TongTien";
            TxB_TongTien.Size = new Size(187, 27);
            TxB_TongTien.TabIndex = 23;
            // 
            // TxB_GiamGia
            // 
            TxB_GiamGia.Location = new Point(1319, 137);
            TxB_GiamGia.Name = "TxB_GiamGia";
            TxB_GiamGia.Size = new Size(187, 27);
            TxB_GiamGia.TabIndex = 24;
            // 
            // TxB_Tong
            // 
            TxB_Tong.Location = new Point(1319, 202);
            TxB_Tong.Name = "TxB_Tong";
            TxB_Tong.Size = new Size(187, 27);
            TxB_Tong.TabIndex = 25;
            // 
            // BT_XacNhanHoaDon
            // 
            BT_XacNhanHoaDon.Location = new Point(1319, 267);
            BT_XacNhanHoaDon.Name = "BT_XacNhanHoaDon";
            BT_XacNhanHoaDon.Size = new Size(87, 33);
            BT_XacNhanHoaDon.TabIndex = 26;
            BT_XacNhanHoaDon.Text = "Thành tiền";
            BT_XacNhanHoaDon.UseVisualStyleBackColor = true;
            BT_XacNhanHoaDon.Click += BT_XacNhanHoaDon_Click;
            // 
            // BT_ThanhTien
            // 
            BT_ThanhTien.Location = new Point(1429, 267);
            BT_ThanhTien.Name = "BT_ThanhTien";
            BT_ThanhTien.Size = new Size(87, 33);
            BT_ThanhTien.TabIndex = 27;
            BT_ThanhTien.Text = "Xác nhận";
            BT_ThanhTien.UseVisualStyleBackColor = true;
            BT_ThanhTien.Click += BT_ThanhTien_Click;
            // 
            // TxB_GiaTien
            // 
            TxB_GiaTien.Location = new Point(495, 270);
            TxB_GiaTien.Name = "TxB_GiaTien";
            TxB_GiaTien.ReadOnly = true;
            TxB_GiaTien.Size = new Size(238, 27);
            TxB_GiaTien.TabIndex = 29;
            // 
            // lbGiaTien
            // 
            lbGiaTien.AutoSize = true;
            lbGiaTien.Location = new Point(495, 247);
            lbGiaTien.Name = "lbGiaTien";
            lbGiaTien.Size = new Size(63, 20);
            lbGiaTien.TabIndex = 28;
            lbGiaTien.Text = "Giá Tiền";
            // 
            // BT_ShowGiaTien
            // 
            BT_ShowGiaTien.Location = new Point(495, 321);
            BT_ShowGiaTien.Name = "BT_ShowGiaTien";
            BT_ShowGiaTien.Size = new Size(125, 27);
            BT_ShowGiaTien.TabIndex = 30;
            BT_ShowGiaTien.Text = "Hiện thị giá tiền";
            BT_ShowGiaTien.UseVisualStyleBackColor = true;
            BT_ShowGiaTien.Click += BT_ShowGiaTien_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1319, 53);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 31;
            label7.Text = "Thành tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1318, 114);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 32;
            label8.Text = "Giảm giá";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1318, 179);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 33;
            label9.Text = "Giá tổng";
            // 
            // BT_In
            // 
            BT_In.Location = new Point(1319, 321);
            BT_In.Name = "BT_In";
            BT_In.Size = new Size(94, 89);
            BT_In.TabIndex = 34;
            BT_In.Text = "In hóa đơn";
            BT_In.UseVisualStyleBackColor = true;
            BT_In.Click += BT_In_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 445);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 35;
            button2.Text = "Hiển thị";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LapHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1562, 498);
            Controls.Add(button2);
            Controls.Add(BT_In);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(BT_ShowGiaTien);
            Controls.Add(TxB_GiaTien);
            Controls.Add(lbGiaTien);
            Controls.Add(BT_ThanhTien);
            Controls.Add(BT_XacNhanHoaDon);
            Controls.Add(TxB_Tong);
            Controls.Add(TxB_GiamGia);
            Controls.Add(TxB_TongTien);
            Controls.Add(BT_Huy);
            Controls.Add(label4);
            Controls.Add(TxB_NhanVienTruc);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(TxB_SoLuong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BT_ThanhToan);
            Controls.Add(TxB_ID);
            Controls.Add(BT_xacNhan);
            Controls.Add(DTW_Xuat);
            Controls.Add(DTW_View);
            Name = "LapHoaDon";
            Text = "Lập hóa đơn";
            Load += XuatHang_Load;
            ((System.ComponentModel.ISupportInitialize)DTW_View).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTW_Xuat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DTW_View;
        private DataGridView DTW_Xuat;
        private Button BT_xacNhan;
        private TextBox TxB_ID;
        private Button BT_ThanhToan;
        private Label label5;
        private Label label6;
        private TextBox TxB_SoLuong;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox TxB_NhanVienTruc;
        private Label label4;
        private Button BT_Huy;
        private TextBox TxB_TongTien;
        private TextBox TxB_GiamGia;
        private TextBox TxB_Tong;
        private Button BT_XacNhanHoaDon;
        private Button BT_ThanhTien;
        private TextBox TxB_GiaTien;
        private Label lbGiaTien;
        private Button BT_ShowGiaTien;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button BT_In;
        private Button button2;
    }
}