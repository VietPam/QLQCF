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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số Tiền Khách Trả";
            // 
            // txbMoney
            // 
            this.txbMoney.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMoney.Location = new System.Drawing.Point(25, 80);
            this.txbMoney.Name = "txbMoney";
            this.txbMoney.Size = new System.Drawing.Size(315, 29);
            this.txbMoney.TabIndex = 1;
            this.txbMoney.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(149, 201);
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
            this.cbTypeMoney.Location = new System.Drawing.Point(346, 78);
            this.cbTypeMoney.Name = "cbTypeMoney";
            this.cbTypeMoney.Size = new System.Drawing.Size(75, 31);
            this.cbTypeMoney.TabIndex = 3;
            this.cbTypeMoney.Text = "VND";
            // 
            // fCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 292);
            this.Controls.Add(this.cbTypeMoney);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txbMoney);
            this.Controls.Add(this.label1);
            this.Name = "fCheckOut";
            this.Text = "fCheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbMoney;
        private Button btnCheckOut;
        private ComboBox cbTypeMoney;
    }
}