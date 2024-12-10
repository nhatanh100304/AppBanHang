namespace DoAn
{
    partial class NhaCungCap
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
            DTGW_NhaCungCap = new DataGridView();
            TxB_TenNhaCungCap = new TextBox();
            TxB_SanPhamCungCap = new TextBox();
            TxB_DiaChi = new TextBox();
            TxB_Gmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BT_Them = new Button();
            BT_ThayDoi = new Button();
            BT_Xoa = new Button();
            TxB_ID = new TextBox();
            label6 = new Label();
            BT_SHOW = new Button();
            ((System.ComponentModel.ISupportInitialize)DTGW_NhaCungCap).BeginInit();
            SuspendLayout();
            // 
            // DTGW_NhaCungCap
            // 
            DTGW_NhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGW_NhaCungCap.Location = new Point(32, 208);
            DTGW_NhaCungCap.Name = "DTGW_NhaCungCap";
            DTGW_NhaCungCap.RowHeadersWidth = 51;
            DTGW_NhaCungCap.Size = new Size(1037, 237);
            DTGW_NhaCungCap.TabIndex = 0;
            DTGW_NhaCungCap.CellClick += DTGW_NhaCungCap_CellClick;
            DTGW_NhaCungCap.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TxB_TenNhaCungCap
            // 
            TxB_TenNhaCungCap.Location = new Point(36, 49);
            TxB_TenNhaCungCap.Name = "TxB_TenNhaCungCap";
            TxB_TenNhaCungCap.Size = new Size(269, 27);
            TxB_TenNhaCungCap.TabIndex = 1;
            // 
            // TxB_SanPhamCungCap
            // 
            TxB_SanPhamCungCap.Location = new Point(36, 105);
            TxB_SanPhamCungCap.Name = "TxB_SanPhamCungCap";
            TxB_SanPhamCungCap.Size = new Size(269, 27);
            TxB_SanPhamCungCap.TabIndex = 2;
            // 
            // TxB_DiaChi
            // 
            TxB_DiaChi.Location = new Point(368, 49);
            TxB_DiaChi.Name = "TxB_DiaChi";
            TxB_DiaChi.Size = new Size(269, 27);
            TxB_DiaChi.TabIndex = 3;
            // 
            // TxB_Gmail
            // 
            TxB_Gmail.Location = new Point(368, 108);
            TxB_Gmail.Name = "TxB_Gmail";
            TxB_Gmail.Size = new Size(269, 27);
            TxB_Gmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 82);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 6;
            label2.Text = "Sản phẩm cung cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 26);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 85);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Gmail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 179);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 9;
            label5.Text = "Danh sách nhà cung cấp";
            // 
            // BT_Them
            // 
            BT_Them.Location = new Point(533, 141);
            BT_Them.Name = "BT_Them";
            BT_Them.Size = new Size(93, 28);
            BT_Them.TabIndex = 10;
            BT_Them.Text = "Thêm";
            BT_Them.UseVisualStyleBackColor = true;
            BT_Them.Click += BT_Them_Click;
            // 
            // BT_ThayDoi
            // 
            BT_ThayDoi.Location = new Point(913, 115);
            BT_ThayDoi.Name = "BT_ThayDoi";
            BT_ThayDoi.Size = new Size(93, 28);
            BT_ThayDoi.TabIndex = 11;
            BT_ThayDoi.Text = "Thay đổi";
            BT_ThayDoi.UseVisualStyleBackColor = true;
            BT_ThayDoi.Click += BT_ThayDoi_Click;
            // 
            // BT_Xoa
            // 
            BT_Xoa.Location = new Point(814, 114);
            BT_Xoa.Name = "BT_Xoa";
            BT_Xoa.Size = new Size(93, 28);
            BT_Xoa.TabIndex = 12;
            BT_Xoa.Text = "Xóa";
            BT_Xoa.UseVisualStyleBackColor = true;
            BT_Xoa.Click += BT_Xoa_Click;
            // 
            // TxB_ID
            // 
            TxB_ID.Location = new Point(814, 59);
            TxB_ID.Name = "TxB_ID";
            TxB_ID.Size = new Size(192, 27);
            TxB_ID.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(814, 31);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 14;
            label6.Text = "Nhâp ID cần sửa/xóa";
            // 
            // BT_SHOW
            // 
            BT_SHOW.Location = new Point(32, 451);
            BT_SHOW.Name = "BT_SHOW";
            BT_SHOW.Size = new Size(148, 26);
            BT_SHOW.TabIndex = 15;
            BT_SHOW.Text = "Hiển thị";
            BT_SHOW.UseVisualStyleBackColor = true;
            BT_SHOW.Click += BT_SHOW_Click;
            // 
            // NhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1160, 482);
            Controls.Add(BT_SHOW);
            Controls.Add(label6);
            Controls.Add(TxB_ID);
            Controls.Add(BT_Xoa);
            Controls.Add(BT_ThayDoi);
            Controls.Add(BT_Them);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxB_Gmail);
            Controls.Add(TxB_DiaChi);
            Controls.Add(TxB_SanPhamCungCap);
            Controls.Add(TxB_TenNhaCungCap);
            Controls.Add(DTGW_NhaCungCap);
            Name = "NhaCungCap";
            Text = "Nhà Cung Cấp";
            Load += NhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)DTGW_NhaCungCap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DTGW_NhaCungCap;
        private TextBox TxB_TenNhaCungCap;
        private TextBox TxB_SanPhamCungCap;
        private TextBox TxB_DiaChi;
        private TextBox TxB_Gmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BT_Them;
        private Button BT_ThayDoi;
        private Button BT_Xoa;
        private TextBox TxB_ID;
        private Label label6;
        private Button BT_SHOW;
    }
}