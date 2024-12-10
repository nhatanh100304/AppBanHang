namespace DoAn
{
    partial class QuanLyTaiKhoan
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
            DTGW_Show = new DataGridView();
            TxB_TenTaiKhoan = new TextBox();
            TxB_MatKhau = new TextBox();
            TxB_LoaiTaiKhoan = new TextBox();
            TxB_ID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BT_XacNhan = new Button();
            ThayDoi = new Button();
            BT_Show = new Button();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DTGW_Show).BeginInit();
            SuspendLayout();
            // 
            // DTGW_Show
            // 
            DTGW_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGW_Show.Location = new Point(12, 41);
            DTGW_Show.Name = "DTGW_Show";
            DTGW_Show.RowHeadersWidth = 51;
            DTGW_Show.Size = new Size(718, 384);
            DTGW_Show.TabIndex = 0;
            DTGW_Show.CellClick += DTGW_Show_CellClick;
            // 
            // TxB_TenTaiKhoan
            // 
            TxB_TenTaiKhoan.Location = new Point(736, 125);
            TxB_TenTaiKhoan.Name = "TxB_TenTaiKhoan";
            TxB_TenTaiKhoan.Size = new Size(265, 27);
            TxB_TenTaiKhoan.TabIndex = 1;
            // 
            // TxB_MatKhau
            // 
            TxB_MatKhau.Location = new Point(736, 190);
            TxB_MatKhau.Name = "TxB_MatKhau";
            TxB_MatKhau.Size = new Size(265, 27);
            TxB_MatKhau.TabIndex = 2;
            // 
            // TxB_LoaiTaiKhoan
            // 
            TxB_LoaiTaiKhoan.Location = new Point(736, 67);
            TxB_LoaiTaiKhoan.Name = "TxB_LoaiTaiKhoan";
            TxB_LoaiTaiKhoan.Size = new Size(265, 27);
            TxB_LoaiTaiKhoan.TabIndex = 3;
            // 
            // TxB_ID
            // 
            TxB_ID.Location = new Point(1035, 67);
            TxB_ID.Name = "TxB_ID";
            TxB_ID.Size = new Size(265, 27);
            TxB_ID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1035, 44);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 5;
            label1.Text = "ID người cần đổi/ xóa tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 102);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 167);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 44);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 8;
            label4.Text = "Loại tài khoản";
            // 
            // BT_XacNhan
            // 
            BT_XacNhan.Location = new Point(736, 238);
            BT_XacNhan.Name = "BT_XacNhan";
            BT_XacNhan.Size = new Size(117, 29);
            BT_XacNhan.TabIndex = 9;
            BT_XacNhan.Text = "Xác nhận";
            BT_XacNhan.UseVisualStyleBackColor = true;
            BT_XacNhan.Click += BT_XacNhan_Click;
            // 
            // ThayDoi
            // 
            ThayDoi.Location = new Point(1035, 113);
            ThayDoi.Name = "ThayDoi";
            ThayDoi.Size = new Size(117, 29);
            ThayDoi.TabIndex = 10;
            ThayDoi.Text = "Thay đổi";
            ThayDoi.UseVisualStyleBackColor = true;
            ThayDoi.Click += ThayDoi_Click;
            // 
            // BT_Show
            // 
            BT_Show.Location = new Point(12, 431);
            BT_Show.Name = "BT_Show";
            BT_Show.Size = new Size(117, 29);
            BT_Show.TabIndex = 11;
            BT_Show.Text = "Hiển thị";
            BT_Show.UseVisualStyleBackColor = true;
            BT_Show.Click += BT_Show_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 18);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 12;
            label5.Text = "Danh sách tài khoản";
            // 
            // button1
            // 
            button1.Location = new Point(1174, 113);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 13;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1309, 468);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(BT_Show);
            Controls.Add(ThayDoi);
            Controls.Add(BT_XacNhan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxB_ID);
            Controls.Add(TxB_LoaiTaiKhoan);
            Controls.Add(TxB_MatKhau);
            Controls.Add(TxB_TenTaiKhoan);
            Controls.Add(DTGW_Show);
            Name = "QuanLyTaiKhoan";
            Text = "Quản lý tài khoản";
            ((System.ComponentModel.ISupportInitialize)DTGW_Show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DTGW_Show;
        private TextBox TxB_TenTaiKhoan;
        private TextBox TxB_MatKhau;
        private TextBox TxB_LoaiTaiKhoan;
        private TextBox TxB_ID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BT_XacNhan;
        private Button ThayDoi;
        private Button BT_Show;
        private Label label5;
        private Button button1;
    }
}