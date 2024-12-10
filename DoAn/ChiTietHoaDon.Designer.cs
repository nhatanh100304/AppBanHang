namespace DoAn
{
    partial class ChiTietHoaDon
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
            DTGV_Test = new DataGridView();
            BT_Test = new Button();
            ((System.ComponentModel.ISupportInitialize)DTGV_Test).BeginInit();
            SuspendLayout();
            // 
            // DTGV_Test
            // 
            DTGV_Test.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGV_Test.Location = new Point(28, 56);
            DTGV_Test.Name = "DTGV_Test";
            DTGV_Test.RowHeadersWidth = 51;
            DTGV_Test.Size = new Size(642, 345);
            DTGV_Test.TabIndex = 0;
            // 
            // BT_Test
            // 
            BT_Test.Location = new Point(676, 343);
            BT_Test.Name = "BT_Test";
            BT_Test.Size = new Size(112, 58);
            BT_Test.TabIndex = 1;
            BT_Test.Text = "Xem";
            BT_Test.UseVisualStyleBackColor = true;
            BT_Test.Click += BT_Test_Click;
            // 
            // ChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(BT_Test);
            Controls.Add(DTGV_Test);
            Name = "ChiTietHoaDon";
            Text = "Chi tiết hóa đơn";
            ((System.ComponentModel.ISupportInitialize)DTGV_Test).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DTGV_Test;
        private Button BT_Test;
    }
}