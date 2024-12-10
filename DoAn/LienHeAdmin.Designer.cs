namespace DoAn
{
    partial class LienHeAdmin
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
            BT_Gui = new Button();
            TxB_YeuCau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BT_Gui
            // 
            BT_Gui.Location = new Point(53, 142);
            BT_Gui.Name = "BT_Gui";
            BT_Gui.Size = new Size(92, 39);
            BT_Gui.TabIndex = 0;
            BT_Gui.Text = "Gửi";
            BT_Gui.UseVisualStyleBackColor = true;
            BT_Gui.Click += BT_Gui_Click;
            // 
            // TxB_YeuCau
            // 
            TxB_YeuCau.Location = new Point(53, 109);
            TxB_YeuCau.Name = "TxB_YeuCau";
            TxB_YeuCau.Size = new Size(282, 27);
            TxB_YeuCau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(598, 38);
            label1.TabIndex = 2;
            label1.Text = "GỬI YÊU CẦU HỖ TRỢ ĐẾN ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 86);
            label2.Name = "label2";
            label2.Size = new Size(275, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhập yêu cầu hoặc vấn đề bạn gặp phải";
            // 
            // LienHeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(757, 246);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxB_YeuCau);
            Controls.Add(BT_Gui);
            Name = "LienHeAdmin";
            Text = "LienHeAdmin";
            Load += LienHeAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Gui;
        private TextBox TxB_YeuCau;
        private Label label1;
        private Label label2;
    }
}