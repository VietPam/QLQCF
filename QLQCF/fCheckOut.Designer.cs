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
            this.label1 = new System.Windows.Forms.Label();
            this.txbMoney = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.cbTypeMoney = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Tiền Khách Trả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbMoney
            // 
            this.txbMoney.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMoney.Location = new System.Drawing.Point(11, 158);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(315, 29);
            this.txbMoney.TabIndex = 1;
            this.txbMoney.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoney_KeyPress);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(139, 223);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(149, 68);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Xác Nhận Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // cbTypeMoney
            // 
            this.cbTypeMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTypeMoney.FormattingEnabled = true;
            this.cbTypeMoney.Items.AddRange(new object[] {
            "VND",
            "USD",
            "BẢNG",
            "NDT",
            "YÊN"});
            this.cbTypeMoney.Location = new System.Drawing.Point(345, 156);
            this.cbTypeMoney.Name = "cbTypeMoney";
            this.cbTypeMoney.Size = new System.Drawing.Size(75, 31);
            this.cbTypeMoney.TabIndex = 3;
            this.cbTypeMoney.Text = "VND";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập Mã Giảm Giá";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbCode
            // 
            this.txbCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCode.Location = new System.Drawing.Point(3, 38);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(315, 29);
            this.txbCode.TabIndex = 5;
            this.txbCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCode_KeyPress);
            // 
            // lbMoney
            // 
            this.lbMoney.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbMoney.Location = new System.Drawing.Point(2, 55);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(428, 29);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "Nhập Mã Giảm Giá";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Tiền Cần Phải Trả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.Location = new System.Drawing.Point(343, 38);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(75, 29);
            this.btnCheckCode.TabIndex = 8;
            this.btnCheckCode.Text = "Kiểm Tra";
            this.btnCheckCode.UseVisualStyleBackColor = true;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.txbMoney);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbMoney);
            this.panel1.Controls.Add(this.cbTypeMoney);
            this.panel1.Location = new System.Drawing.Point(1, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 318);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Lượng Phụ Thu:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(183, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMoney_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbCode);
            this.panel2.Controls.Add(this.btnCheckCode);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 122);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(3, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 108);
            this.panel3.TabIndex = 9;
            // 
            // fCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 445);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fCheckOut";
            this.Text = "fCheckOut";
            this.Load += new System.EventHandler(this.fCheckOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txbMoney;
        private Button btnCheckOut;
        private ComboBox cbTypeMoney;
        private Label label2;
        private TextBox txbCode;
        private Label lbMoney;
        private Label label4;
        private Button btnCheckCode;
        private Panel panel1;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
    }
}