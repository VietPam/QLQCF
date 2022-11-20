namespace QLQCF
{
    partial class fTableManager
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbDisplayUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalPrice = new System.Windows.Forms.Panel();
            this.btnCheckOut = new FontAwesome.Sharp.IconButton();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbTableName = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lsvBillTBMNG = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ptbAvatarUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TotalPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(-1, 171);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 150);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ptbAvatarUser);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbDisplayUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 748);
            this.panel1.TabIndex = 3;
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.Location = new System.Drawing.Point(0, 319);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 150);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(0, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 150);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lbDisplayUser
            // 
            this.lbDisplayUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDisplayUser.ForeColor = System.Drawing.Color.Black;
            this.lbDisplayUser.Location = new System.Drawing.Point(0, 30);
            this.lbDisplayUser.Name = "lbDisplayUser";
            this.lbDisplayUser.Size = new System.Drawing.Size(196, 53);
            this.lbDisplayUser.TabIndex = 6;
            this.lbDisplayUser.Text = "DisplayUser";
            this.lbDisplayUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xin Chào";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(220, 173);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(674, 576);
            this.flpTable.TabIndex = 6;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(200, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 172);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(355, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coffe Shop";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(691, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 172);
            this.panel3.TabIndex = 1;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Controls.Add(this.btnCheckOut);
            this.TotalPrice.Controls.Add(this.txtTotalPrice);
            this.TotalPrice.Controls.Add(this.btnMerge);
            this.TotalPrice.Controls.Add(this.btnOrder);
            this.TotalPrice.Controls.Add(this.lbTableName);
            this.TotalPrice.Controls.Add(this.btnSwitch);
            this.TotalPrice.Controls.Add(this.lsvBillTBMNG);
            this.TotalPrice.Location = new System.Drawing.Point(894, 173);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(474, 576);
            this.TotalPrice.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnCheckOut.IconColor = System.Drawing.Color.Black;
            this.btnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckOut.IconSize = 30;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckOut.Location = new System.Drawing.Point(243, 489);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(228, 54);
            this.btnCheckOut.TabIndex = 17;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(0, 489);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(244, 54);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(331, 86);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(60, 55);
            this.btnMerge.TabIndex = 14;
            this.btnMerge.Text = "Gộp Bàn";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(92, 86);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(60, 55);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Gọi Món";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Location = new System.Drawing.Point(223, 27);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(10, 15);
            this.lbTableName.TabIndex = 12;
            this.lbTableName.Text = " ";
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(214, 86);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(60, 55);
            this.btnSwitch.TabIndex = 11;
            this.btnSwitch.Text = "Chuyển Bàn";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lsvBillTBMNG
            // 
            this.lsvBillTBMNG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillTBMNG.Enabled = false;
            this.lsvBillTBMNG.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsvBillTBMNG.GridLines = true;
            this.lsvBillTBMNG.Location = new System.Drawing.Point(3, 147);
            this.lsvBillTBMNG.Name = "lsvBillTBMNG";
            this.lsvBillTBMNG.Size = new System.Drawing.Size(468, 297);
            this.lsvBillTBMNG.TabIndex = 0;
            this.lsvBillTBMNG.UseCompatibleStateImageBehavior = false;
            this.lsvBillTBMNG.View = System.Windows.Forms.View.Details;
            this.lsvBillTBMNG.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 119;
            // 
            // ptbAvatarUser
            // 
            this.ptbAvatarUser.Image = global::QLQCFTest.Properties.Resources.nullAvatarUser;
            this.ptbAvatarUser.Location = new System.Drawing.Point(49, 85);
            this.ptbAvatarUser.Name = "ptbAvatarUser";
            this.ptbAvatarUser.Size = new System.Drawing.Size(100, 86);
            this.ptbAvatarUser.TabIndex = 10;
            this.ptbAvatarUser.TabStop = false;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TotalPrice.ResumeLayout(false);
            this.TotalPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatarUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAdmin;
        private Panel panel1;
        private Label label1;
        private Label lbDisplayUser;
        private Button btnExit;
        private Button btnAccount;
        private FlowLayoutPanel flpTable;
        private Panel panel2;
        private Panel panel3;
        private Panel TotalPrice;
        private ListView lsvBillTBMNG;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnMerge;
        private Button btnOrder;
        private Label lbTableName;
        private Button btnSwitch;
        private TextBox txtTotalPrice;
        private FontAwesome.Sharp.IconButton btnCheckOut;
        private Label label2;
        private PictureBox ptbAvatarUser;
    }
}