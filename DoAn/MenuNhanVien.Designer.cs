namespace DoAn
{
    partial class MenuNhanVien
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
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TxB_LayTen
            // 
            TxB_LayTen.Location = new Point(1660, 53);
            TxB_LayTen.Name = "TxB_LayTen";
            TxB_LayTen.ReadOnly = true;
            TxB_LayTen.Size = new Size(171, 27);
            TxB_LayTen.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(1660, 27);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 15;
            label2.Text = "Người đang sử dụng";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1837, 27);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.browser;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(94, 24);
            toolStripButton2.Text = "Tìm kiếm";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.bill;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(116, 24);
            toolStripButton1.Text = "Lập hóa đơn";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // MenuNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1837, 572);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(TxB_LayTen);
            IsMdiContainer = true;
            Name = "MenuNhanVien";
            Text = "MenuNhanVien";
            WindowState = FormWindowState.Maximized;
            Load += MenuNhanVien_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxB_LayTen;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
    }
}