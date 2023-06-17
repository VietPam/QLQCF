namespace QLQCFTest
{
    partial class fCheckOut
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
            txbMoney = new TextBox();
            btnCheckOut = new Button();
            cbTypeMoney = new ComboBox();
            label2 = new Label();
            txbCode = new TextBox();
            lbMoney = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            btnNumSurcharge = new Button();
            txbNumSurcharge = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txbMoney
            // 
            txbMoney.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbMoney.Location = new Point(0, 53);
            txbMoney.Margin = new Padding(3, 4, 3, 4);
            txbMoney.Name = "txbMoney";
            txbMoney.Size = new Size(371, 38);
            txbMoney.TabIndex = 1;
            txbMoney.TextAlign = HorizontalAlignment.Center;
            txbMoney.TextChanged += textBox1_TextChanged;
            txbMoney.KeyPress += txbMoney_KeyPress;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.Location = new Point(125, 4);
            btnCheckOut.Margin = new Padding(3, 4, 3, 4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(250, 73);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Xác Nhận Thanh Toán";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // cbTypeMoney
            // 
            cbTypeMoney.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbTypeMoney.FormattingEnabled = true;
            cbTypeMoney.Items.AddRange(new object[] { "VND", "USD", "BẢNG", "NDT", "YÊN" });
            cbTypeMoney.Location = new Point(383, 53);
            cbTypeMoney.Margin = new Padding(3, 4, 3, 4);
            cbTypeMoney.Name = "cbTypeMoney";
            cbTypeMoney.Size = new Size(93, 38);
            cbTypeMoney.TabIndex = 3;
            cbTypeMoney.Text = "VND";
            cbTypeMoney.KeyPress += cbTypeMoney_KeyPress;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(342, 39);
            label2.TabIndex = 4;
            label2.Text = "Nhập Mã Giảm Giá";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txbCode
            // 
            txbCode.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbCode.Location = new Point(3, 64);
            txbCode.Margin = new Padding(3, 4, 3, 4);
            txbCode.Name = "txbCode";
            txbCode.Size = new Size(371, 38);
            txbCode.TabIndex = 5;
            txbCode.TextAlign = HorizontalAlignment.Center;
            txbCode.KeyPress += txbCode_KeyPress;
            // 
            // lbMoney
            // 
            lbMoney.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbMoney.ForeColor = Color.FromArgb(255, 128, 0);
            lbMoney.Location = new Point(215, 4);
            lbMoney.Name = "lbMoney";
            lbMoney.Size = new Size(274, 57);
            lbMoney.TabIndex = 6;
            lbMoney.Text = "Nhập Mã Giảm Giá";
            lbMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCheckOut);
            panel1.Location = new Point(3, 395);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 97);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnNumSurcharge);
            panel3.Controls.Add(txbNumSurcharge);
            panel3.Location = new Point(-1, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 185);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 36);
            label3.Name = "label3";
            label3.Size = new Size(217, 43);
            label3.TabIndex = 0;
            label3.Text = "Số Lượng Phụ Thu:";
            // 
            // btnNumSurcharge
            // 
            btnNumSurcharge.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumSurcharge.Location = new Point(186, 99);
            btnNumSurcharge.Margin = new Padding(3, 4, 3, 4);
            btnNumSurcharge.Name = "btnNumSurcharge";
            btnNumSurcharge.Size = new Size(85, 41);
            btnNumSurcharge.TabIndex = 11;
            btnNumSurcharge.Text = "Xong";
            btnNumSurcharge.UseVisualStyleBackColor = true;
            btnNumSurcharge.Click += btnNumSurcharge_Click;
            // 
            // txbNumSurcharge
            // 
            txbNumSurcharge.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbNumSurcharge.Location = new Point(222, 31);
            txbNumSurcharge.Margin = new Padding(3, 4, 3, 4);
            txbNumSurcharge.Name = "txbNumSurcharge";
            txbNumSurcharge.Size = new Size(235, 38);
            txbNumSurcharge.TabIndex = 1;
            txbNumSurcharge.Text = "0";
            txbNumSurcharge.TextAlign = HorizontalAlignment.Right;
            txbNumSurcharge.KeyPress += txbMoney_KeyPress;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbCode);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 111);
            panel2.TabIndex = 12;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lbMoney);
            panel4.Location = new Point(3, 151);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(489, 61);
            panel4.TabIndex = 13;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(240, 57);
            label1.TabIndex = 7;
            label1.Text = "Số Tiền Cần Phải Trả";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txbMoney);
            panel5.Controls.Add(cbTypeMoney);
            panel5.Location = new Point(3, 252);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(489, 137);
            panel5.TabIndex = 14;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(338, 39);
            label5.TabIndex = 4;
            label5.Text = "Nhập Số Tiền Khách Trả";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(3, 121);
            label4.Name = "label4";
            label4.Size = new Size(490, 3);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(3, 245);
            label6.Name = "label6";
            label6.Size = new Size(490, 3);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // fCheckOut
            // 
            AcceptButton = btnCheckOut;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 495);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fCheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            Load += fCheckOut_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txbMoney;
        private Button btnCheckOut;
        private ComboBox cbTypeMoney;
        private Label label2;
        private TextBox txbCode;
        private Label lbMoney;
        private Panel panel1;
        private Label label3;
        private TextBox txbNumSurcharge;
        private Button btnNumSurcharge;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label6;
    }
}