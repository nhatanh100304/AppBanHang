namespace DoAn
{
    partial class ThongKe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGW_View = new DataGridView();
            TxB_TimKiem = new TextBox();
            Bt_TimKiem = new Button();
            Bt_AZ = new Button();
            BT_TangDan = new Button();
            Bt_GiamDan = new Button();
            label1 = new Label();
            label2 = new Label();
            BT_Show = new Button();
            BT_ZA = new Button();
            BT_ReNhat = new Button();
            Bt_MacNhat = new Button();
            ((System.ComponentModel.ISupportInitialize)DGW_View).BeginInit();
            SuspendLayout();
            // 
            // DGW_View
            // 
            DGW_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGW_View.Location = new Point(12, 74);
            DGW_View.Name = "DGW_View";
            DGW_View.RowHeadersWidth = 51;
            DGW_View.Size = new Size(484, 335);
            DGW_View.TabIndex = 2;
            // 
            // TxB_TimKiem
            // 
            TxB_TimKiem.Location = new Point(544, 74);
            TxB_TimKiem.Name = "TxB_TimKiem";
            TxB_TimKiem.Size = new Size(247, 27);
            TxB_TimKiem.TabIndex = 3;
            // 
            // Bt_TimKiem
            // 
            Bt_TimKiem.BackgroundImage = Properties.Resources.search_interface_symbol;
            Bt_TimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            Bt_TimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            Bt_TimKiem.Location = new Point(729, 107);
            Bt_TimKiem.Name = "Bt_TimKiem";
            Bt_TimKiem.Size = new Size(62, 44);
            Bt_TimKiem.TabIndex = 1;
            Bt_TimKiem.Text = "\r\n";
            Bt_TimKiem.UseVisualStyleBackColor = true;
            Bt_TimKiem.Click += Bt_TimKiem_Click;
            // 
            // Bt_AZ
            // 
            Bt_AZ.Location = new Point(547, 157);
            Bt_AZ.Name = "Bt_AZ";
            Bt_AZ.Size = new Size(108, 77);
            Bt_AZ.TabIndex = 5;
            Bt_AZ.Text = "Sắp xếp từ   A - Z";
            Bt_AZ.UseVisualStyleBackColor = true;
            Bt_AZ.Click += Bt_AZ_Click;
            // 
            // BT_TangDan
            // 
            BT_TangDan.Location = new Point(544, 263);
            BT_TangDan.Name = "BT_TangDan";
            BT_TangDan.Size = new Size(108, 80);
            BT_TangDan.TabIndex = 6;
            BT_TangDan.Text = "Sắp xếp số lượng tăng dần";
            BT_TangDan.UseVisualStyleBackColor = true;
            BT_TangDan.Click += BT_TangDan_Click;
            // 
            // Bt_GiamDan
            // 
            Bt_GiamDan.Location = new Point(683, 263);
            Bt_GiamDan.Name = "Bt_GiamDan";
            Bt_GiamDan.Size = new Size(108, 80);
            Bt_GiamDan.TabIndex = 10;
            Bt_GiamDan.Text = "Sắp xếp số lượng giảm dần";
            Bt_GiamDan.UseVisualStyleBackColor = true;
            Bt_GiamDan.Click += Bt_GiamDan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(103, 10);
            label1.Name = "label1";
            label1.Size = new Size(301, 41);
            label1.TabIndex = 12;
            label1.Text = "TÌM KIẾM SẢN PHẨM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Location = new Point(544, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 13;
            label2.Text = "Thanh tìm kiếm";
            // 
            // BT_Show
            // 
            BT_Show.Location = new Point(12, 415);
            BT_Show.Name = "BT_Show";
            BT_Show.Size = new Size(100, 28);
            BT_Show.TabIndex = 16;
            BT_Show.Text = "Hiển thị";
            BT_Show.UseVisualStyleBackColor = true;
            BT_Show.Click += BT_Show_Click;
            // 
            // BT_ZA
            // 
            BT_ZA.Location = new Point(683, 157);
            BT_ZA.Name = "BT_ZA";
            BT_ZA.Size = new Size(108, 77);
            BT_ZA.TabIndex = 17;
            BT_ZA.Text = "Sắp xếp từ   Z - A";
            BT_ZA.UseVisualStyleBackColor = true;
            BT_ZA.Click += BT_ZA_Click;
            // 
            // BT_ReNhat
            // 
            BT_ReNhat.Location = new Point(544, 366);
            BT_ReNhat.Name = "BT_ReNhat";
            BT_ReNhat.Size = new Size(108, 77);
            BT_ReNhat.TabIndex = 18;
            BT_ReNhat.Text = "Rẻ nhất";
            BT_ReNhat.UseVisualStyleBackColor = true;
            BT_ReNhat.Click += BT_ReNhat_Click;
            // 
            // Bt_MacNhat
            // 
            Bt_MacNhat.Location = new Point(683, 366);
            Bt_MacNhat.Name = "Bt_MacNhat";
            Bt_MacNhat.Size = new Size(108, 77);
            Bt_MacNhat.TabIndex = 19;
            Bt_MacNhat.Text = "Mắc nhất";
            Bt_MacNhat.UseVisualStyleBackColor = true;
            Bt_MacNhat.Click += Bt_MacNhat_Click;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(881, 479);
            Controls.Add(Bt_MacNhat);
            Controls.Add(BT_ReNhat);
            Controls.Add(BT_ZA);
            Controls.Add(BT_Show);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Bt_GiamDan);
            Controls.Add(BT_TangDan);
            Controls.Add(Bt_AZ);
            Controls.Add(Bt_TimKiem);
            Controls.Add(TxB_TimKiem);
            Controls.Add(DGW_View);
            Name = "ThongKe";
            Text = "BẢNG THÔNG KÊ SỐ LƯỢNG HÀNG HÓA";
            Load += ThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)DGW_View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGW_View;
        private TextBox TxB_TimKiem;
        private Button Bt_TimKiem;
        private Button Bt_AZ;
        private Button BT_TangDan;
        private Button Bt_GiamDan;
        private Label label1;
        private Label label2;
        private Button BT_Show;
        private Button BT_ZA;
        private Button BT_ReNhat;
        private Button Bt_MacNhat;
    }
}
