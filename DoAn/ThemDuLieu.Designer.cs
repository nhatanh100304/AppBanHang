namespace DoAn
{
    partial class ThemDuLieu
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
            TxB_SoLuong = new TextBox();
            TxB_SanPham = new TextBox();
            TxB_GiaTien = new TextBox();
            BT_ThayDoi = new Button();
            DTGV_HienThi = new DataGridView();
            Lb_Soluong = new Label();
            Lb_TenSanPham = new Label();
            Lb_GiaTien = new Label();
            label9 = new Label();
            Bt_Xoa = new Button();
            LB_DonVi = new Label();
            TXB_DonVi = new TextBox();
            LB_NhaCungCap = new Label();
            TxB_NhaCungCap = new TextBox();
            button1 = new Button();
            BT_ADD = new Button();
            label2 = new Label();
            TXB_ID = new TextBox();
            DATE_Ngay = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BT_File = new Button();
            ((System.ComponentModel.ISupportInitialize)DTGV_HienThi).BeginInit();
            SuspendLayout();
            // 
            // TxB_SoLuong
            // 
            TxB_SoLuong.Location = new Point(35, 187);
            TxB_SoLuong.Name = "TxB_SoLuong";
            TxB_SoLuong.Size = new Size(211, 27);
            TxB_SoLuong.TabIndex = 3;
            // 
            // TxB_SanPham
            // 
            TxB_SanPham.Location = new Point(35, 128);
            TxB_SanPham.Name = "TxB_SanPham";
            TxB_SanPham.Size = new Size(211, 27);
            TxB_SanPham.TabIndex = 2;
            // 
            // TxB_GiaTien
            // 
            TxB_GiaTien.Location = new Point(280, 129);
            TxB_GiaTien.Name = "TxB_GiaTien";
            TxB_GiaTien.Size = new Size(211, 27);
            TxB_GiaTien.TabIndex = 5;
            // 
            // BT_ThayDoi
            // 
            BT_ThayDoi.Location = new Point(145, 249);
            BT_ThayDoi.Name = "BT_ThayDoi";
            BT_ThayDoi.Size = new Size(90, 27);
            BT_ThayDoi.TabIndex = 8;
            BT_ThayDoi.Text = "Thay đổi";
            BT_ThayDoi.UseVisualStyleBackColor = true;
            BT_ThayDoi.Click += Bt_ThayDoi_Click;
            // 
            // DTGV_HienThi
            // 
            DTGV_HienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGV_HienThi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGV_HienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGV_HienThi.Location = new Point(508, 35);
            DTGV_HienThi.Name = "DTGV_HienThi";
            DTGV_HienThi.RowHeadersWidth = 51;
            DTGV_HienThi.Size = new Size(621, 352);
            DTGV_HienThi.TabIndex = 4;
            DTGV_HienThi.CellClick += DTGV_HienThi_CellClick;
            // 
            // Lb_Soluong
            // 
            Lb_Soluong.AutoSize = true;
            Lb_Soluong.Location = new Point(35, 164);
            Lb_Soluong.Name = "Lb_Soluong";
            Lb_Soluong.Size = new Size(69, 20);
            Lb_Soluong.TabIndex = 9;
            Lb_Soluong.Text = "Số lượng";
            // 
            // Lb_TenSanPham
            // 
            Lb_TenSanPham.AutoSize = true;
            Lb_TenSanPham.Location = new Point(35, 105);
            Lb_TenSanPham.Name = "Lb_TenSanPham";
            Lb_TenSanPham.Size = new Size(100, 20);
            Lb_TenSanPham.TabIndex = 10;
            Lb_TenSanPham.Text = "Tên sản phẩm";
            // 
            // Lb_GiaTien
            // 
            Lb_GiaTien.AutoSize = true;
            Lb_GiaTien.Location = new Point(280, 106);
            Lb_GiaTien.Name = "Lb_GiaTien";
            Lb_GiaTien.Size = new Size(60, 20);
            Lb_GiaTien.TabIndex = 11;
            Lb_GiaTien.Text = "Giá tiền";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(710, 12);
            label9.Name = "label9";
            label9.Size = new Size(190, 20);
            label9.TabIndex = 17;
            label9.Text = "BẢNG DỮ LIỆU HÀNG HÓA";
            // 
            // Bt_Xoa
            // 
            Bt_Xoa.Location = new Point(35, 292);
            Bt_Xoa.Name = "Bt_Xoa";
            Bt_Xoa.Size = new Size(89, 24);
            Bt_Xoa.TabIndex = 9;
            Bt_Xoa.Text = "Xóa";
            Bt_Xoa.UseVisualStyleBackColor = true;
            Bt_Xoa.Click += Bt_Xoa_Click;
            // 
            // LB_DonVi
            // 
            LB_DonVi.AutoSize = true;
            LB_DonVi.Location = new Point(280, 46);
            LB_DonVi.Name = "LB_DonVi";
            LB_DonVi.Size = new Size(52, 20);
            LB_DonVi.TabIndex = 21;
            LB_DonVi.Text = "Đơn vị";
            // 
            // TXB_DonVi
            // 
            TXB_DonVi.Location = new Point(280, 69);
            TXB_DonVi.Name = "TXB_DonVi";
            TXB_DonVi.Size = new Size(211, 27);
            TXB_DonVi.TabIndex = 4;
            // 
            // LB_NhaCungCap
            // 
            LB_NhaCungCap.AutoSize = true;
            LB_NhaCungCap.Location = new Point(280, 164);
            LB_NhaCungCap.Name = "LB_NhaCungCap";
            LB_NhaCungCap.Size = new Size(100, 20);
            LB_NhaCungCap.TabIndex = 23;
            LB_NhaCungCap.Text = "Nhà cung cấp";
            // 
            // TxB_NhaCungCap
            // 
            TxB_NhaCungCap.Location = new Point(280, 187);
            TxB_NhaCungCap.Name = "TxB_NhaCungCap";
            TxB_NhaCungCap.Size = new Size(211, 27);
            TxB_NhaCungCap.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(1008, 392);
            button1.Name = "button1";
            button1.Size = new Size(121, 25);
            button1.TabIndex = 24;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // BT_ADD
            // 
            BT_ADD.Location = new Point(35, 249);
            BT_ADD.Name = "BT_ADD";
            BT_ADD.Size = new Size(89, 27);
            BT_ADD.TabIndex = 7;
            BT_ADD.Text = "Thêm";
            BT_ADD.UseVisualStyleBackColor = true;
            BT_ADD.Click += BT_ADD_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 53);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 27;
            label2.Text = "ID";
            // 
            // TXB_ID
            // 
            TXB_ID.Location = new Point(35, 76);
            TXB_ID.Name = "TXB_ID";
            TXB_ID.Size = new Size(211, 27);
            TXB_ID.TabIndex = 1;
            // 
            // DATE_Ngay
            // 
            DATE_Ngay.Location = new Point(35, 23);
            DATE_Ngay.Name = "DATE_Ngay";
            DATE_Ngay.Size = new Size(211, 27);
            DATE_Ngay.TabIndex = 28;
            // 
            // BT_File
            // 
            BT_File.Location = new Point(508, 393);
            BT_File.Name = "BT_File";
            BT_File.Size = new Size(104, 29);
            BT_File.TabIndex = 29;
            BT_File.Text = "Thêm từ file";
            BT_File.UseVisualStyleBackColor = true;
            BT_File.Click += BT_File_Click;
            // 
            // ThemDuLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1160, 470);
            Controls.Add(BT_File);
            Controls.Add(DATE_Ngay);
            Controls.Add(label2);
            Controls.Add(TXB_ID);
            Controls.Add(BT_ADD);
            Controls.Add(button1);
            Controls.Add(LB_NhaCungCap);
            Controls.Add(TxB_NhaCungCap);
            Controls.Add(LB_DonVi);
            Controls.Add(TXB_DonVi);
            Controls.Add(Bt_Xoa);
            Controls.Add(label9);
            Controls.Add(Lb_GiaTien);
            Controls.Add(Lb_TenSanPham);
            Controls.Add(Lb_Soluong);
            Controls.Add(DTGV_HienThi);
            Controls.Add(BT_ThayDoi);
            Controls.Add(TxB_GiaTien);
            Controls.Add(TxB_SanPham);
            Controls.Add(TxB_SoLuong);
            Name = "ThemDuLieu";
            Text = "Thêm Hàng Hóa";
            Load += ThemDuLieu_Load;
            ((System.ComponentModel.ISupportInitialize)DTGV_HienThi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxB_SoLuong;
        private TextBox TxB_SanPham;
        private TextBox TxB_GiaTien;
        private Button BT_ThayDoi;
        private DataGridView DTGV_HienThi;
        private Label Lb_Soluong;
        private Label Lb_TenSanPham;
        private Label Lb_GiaTien;
        private Label label9;
        private Button Bt_Xoa;
        private Label LB_DonVi;
        private TextBox TXB_DonVi;
        private Label LB_NhaCungCap;
        private TextBox TxB_NhaCungCap;
        private Button button1;
        private Button BT_ADD;
        private Label label2;
        private TextBox TXB_ID;
        private DateTimePicker DATE_Ngay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button BT_File;
    }
}