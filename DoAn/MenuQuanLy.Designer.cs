namespace DoAn
{
    partial class MenuQuanLy
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
            TxB_LayTen = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton6 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TxB_LayTen
            // 
            TxB_LayTen.Location = new Point(1235, 53);
            TxB_LayTen.Name = "TxB_LayTen";
            TxB_LayTen.ReadOnly = true;
            TxB_LayTen.Size = new Size(187, 27);
            TxB_LayTen.TabIndex = 13;
            TxB_LayTen.TextChanged += TxB_LayTen_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(1245, 27);
            label3.Name = "label3";
            label3.Size = new Size(177, 23);
            label3.TabIndex = 14;
            label3.Text = "Người đang sử dụng";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1320, 633);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Liên hệ admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton6, toolStripButton5, toolStripButton4, toolStripButton3, toolStripButton2, toolStripButton1, toolStripButton7, toolStripButton8 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1434, 27);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.box;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(149, 24);
            toolStripButton6.Text = "Quản lý hàng hóa";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.id_card;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(150, 24);
            toolStripButton5.Text = "Quản lý nhân viên";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.wholesale;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(175, 24);
            toolStripButton4.Text = "Quản lý nhà cung cấp";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.browser;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(94, 24);
            toolStripButton3.Text = "Thống kê";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.decentralized;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(148, 24);
            toolStripButton2.Text = "Quản lý tài khoản";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.security;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(153, 24);
            toolStripButton1.Text = "Lịch sử đăng nhập";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton7
            // 
            toolStripButton7.Alignment = ToolStripItemAlignment.Right;
            toolStripButton7.Image = Properties.Resources.close;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(71, 24);
            toolStripButton7.Text = "Thoát";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // toolStripButton8
            // 
            toolStripButton8.Image = Properties.Resources.bill;
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(139, 24);
            toolStripButton8.Text = "Chi tiết hóa đơn";
            toolStripButton8.Click += toolStripButton8_Click;
            // 
            // MenuQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1434, 662);
            Controls.Add(toolStrip1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(TxB_LayTen);
            IsMdiContainer = true;
            Name = "MenuQuanLy";
            Text = "MenuQuanLy";
            Load += MenuQuanLy_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxB_LayTen;
        private Label label3;
        private LinkLabel linkLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
    }
}