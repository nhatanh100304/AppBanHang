namespace DoAn
{
    partial class LichSuDangNhap
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
            DTGW_Check = new DataGridView();
            BT_Check = new Button();
            ((System.ComponentModel.ISupportInitialize)DTGW_Check).BeginInit();
            SuspendLayout();
            // 
            // DTGW_Check
            // 
            DTGW_Check.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGW_Check.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGW_Check.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGW_Check.Location = new Point(24, 25);
            DTGW_Check.Name = "DTGW_Check";
            DTGW_Check.RowHeadersWidth = 51;
            DTGW_Check.Size = new Size(332, 413);
            DTGW_Check.TabIndex = 0;
            // 
            // BT_Check
            // 
            BT_Check.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            BT_Check.Location = new Point(362, 25);
            BT_Check.Name = "BT_Check";
            BT_Check.Size = new Size(168, 44);
            BT_Check.TabIndex = 1;
            BT_Check.Text = "Xem lịch sử";
            BT_Check.UseVisualStyleBackColor = true;
            BT_Check.Click += BT_Check_Click;
            // 
            // LichSuDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(600, 450);
            Controls.Add(BT_Check);
            Controls.Add(DTGW_Check);
            Name = "LichSuDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch Sử Đăng Nhập";
            Load += LichSuDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)DTGW_Check).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DTGW_Check;
        private Button BT_Check;
    }
}