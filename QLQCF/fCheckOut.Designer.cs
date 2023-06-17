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
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.cbTypeMoney = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNumSurcharge = new System.Windows.Forms.Button();
            this.txbNumSurcharge = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMoney
            // 
            this.txbMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbMoney.Location = new System.Drawing.Point(0, 40);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(325, 32);
            this.txbMoney.TabIndex = 1;
            this.txbMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbMoney.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoney_KeyPress);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(109, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(219, 55);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Xác Nhận Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // cbTypeMoney
            // 
            this.cbTypeMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTypeMoney.FormattingEnabled = true;
            this.cbTypeMoney.Items.AddRange(new object[] {
            "VND",
            "USD",
            "BẢNG",
            "NDT",
            "YÊN"});
            this.cbTypeMoney.Location = new System.Drawing.Point(335, 40);
            this.cbTypeMoney.Name = "cbTypeMoney";
            this.cbTypeMoney.Size = new System.Drawing.Size(82, 32);
            this.cbTypeMoney.TabIndex = 3;
            this.cbTypeMoney.Text = "VND";
            this.cbTypeMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTypeMoney_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập Mã Giảm Giá";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbCode
            // 
            this.txbCode.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbCode.Location = new System.Drawing.Point(3, 48);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(325, 32);
            this.txbCode.TabIndex = 5;
            this.txbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCode_KeyPress);
            // 
            // lbMoney
            // 
            this.lbMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbMoney.Location = new System.Drawing.Point(188, 3);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(240, 43);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "Nhập Mã Giảm Giá";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckCode.Location = new System.Drawing.Point(338, 23);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(82, 57);
            this.btnCheckCode.TabIndex = 8;
            this.btnCheckCode.Text = "Check";
            this.btnCheckCode.UseVisualStyleBackColor = true;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Location = new System.Drawing.Point(3, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 73);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnNumSurcharge);
            this.panel3.Controls.Add(this.txbNumSurcharge);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 139);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng Phụ Thu:";
            // 
            // btnNumSurcharge
            // 
            this.btnNumSurcharge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNumSurcharge.Location = new System.Drawing.Point(163, 74);
            this.btnNumSurcharge.Name = "btnNumSurcharge";
            this.btnNumSurcharge.Size = new System.Drawing.Size(74, 31);
            this.btnNumSurcharge.TabIndex = 11;
            this.btnNumSurcharge.Text = "Xong";
            this.btnNumSurcharge.UseVisualStyleBackColor = true;
            this.btnNumSurcharge.Click += new System.EventHandler(this.btnNumSurcharge_Click);
            // 
            // txbNumSurcharge
            // 
            this.txbNumSurcharge.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumSurcharge.Location = new System.Drawing.Point(194, 23);
            this.txbNumSurcharge.Name = "txbNumSurcharge";
            this.txbNumSurcharge.Size = new System.Drawing.Size(206, 32);
            this.txbNumSurcharge.TabIndex = 1;
            this.txbNumSurcharge.Text = "0";
            this.txbNumSurcharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbNumSurcharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoney_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbCode);
            this.panel2.Controls.Add(this.btnCheckCode);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 83);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lbMoney);
            this.panel4.Location = new System.Drawing.Point(3, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 46);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số Tiền Cần Phải Trả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txbMoney);
            this.panel5.Controls.Add(this.cbTypeMoney);
            this.panel5.Location = new System.Drawing.Point(3, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 103);
            this.panel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập Số Tiền Khách Trả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 2);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(3, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 2);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // fCheckOut
            // 
            this.AcceptButton = this.btnCheckOut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 371);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.fCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txbMoney;
        private Button btnCheckOut;
        private ComboBox cbTypeMoney;
        private Label label2;
        private TextBox txbCode;
        private Label lbMoney;
        private Button btnCheckCode;
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