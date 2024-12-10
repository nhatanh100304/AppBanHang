namespace DoAn
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            TxB_TaiKhoan = new TextBox();
            TxB_MatKhau = new TextBox();
            Bt_DangNhap = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(450, 38);
            label1.TabIndex = 0;
            label1.Text = "PHẦN MỀM BÁN TẠP HÓA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Tài Khoản";
            // 
            // TxB_TaiKhoan
            // 
            TxB_TaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            TxB_TaiKhoan.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            TxB_TaiKhoan.Location = new Point(32, 111);
            TxB_TaiKhoan.Name = "TxB_TaiKhoan";
            TxB_TaiKhoan.Size = new Size(260, 27);
            TxB_TaiKhoan.TabIndex = 3;
            // 
            // TxB_MatKhau
            // 
            TxB_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            TxB_MatKhau.Location = new Point(32, 185);
            TxB_MatKhau.Name = "TxB_MatKhau";
            TxB_MatKhau.PasswordChar = '*';
            TxB_MatKhau.Size = new Size(260, 27);
            TxB_MatKhau.TabIndex = 4;
            TxB_MatKhau.TextChanged += TxB_MatKhau_TextChanged;
            // 
            // Bt_DangNhap
            // 
            Bt_DangNhap.Location = new Point(32, 246);
            Bt_DangNhap.Name = "Bt_DangNhap";
            Bt_DangNhap.Size = new Size(99, 38);
            Bt_DangNhap.TabIndex = 5;
            Bt_DangNhap.Text = "Đăng Nhập";
            Bt_DangNhap.UseVisualStyleBackColor = true;
            Bt_DangNhap.Click += Bt_DangNhap_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 218);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Thiết_kế_chưa_có_tên__1_;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(324, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label4.Location = new Point(35, 161);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 8;
            label4.Text = "Mật Khẩu";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(677, 413);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(Bt_DangNhap);
            Controls.Add(TxB_MatKhau);
            Controls.Add(TxB_TaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP";
            FormClosing += DangNhap_FormClosing;
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxB_TaiKhoan;
        private TextBox TxB_MatKhau;
        private Button Bt_DangNhap;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}