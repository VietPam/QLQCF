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
            this.components = new System.ComponentModel.Container();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.ptbAvatarUser = new System.Windows.Forms.PictureBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.lbDisplayUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpAll = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpUnEmpty = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flpEmpty = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbEncouragement = new System.Windows.Forms.Label();
            this.lbShopName = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatarUser)).BeginInit();
            this.flpTable.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.ptbAvatarUser);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnNotification);
            this.panel1.Controls.Add(this.lbDisplayUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 745);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(-1, 597);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 140);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccount.Location = new System.Drawing.Point(0, 319);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(200, 150);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.White;
            this.btnNotification.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotification.Location = new System.Drawing.Point(0, 461);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(200, 140);
            this.btnNotification.TabIndex = 9;
            this.btnNotification.Text = "Thông báo ";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
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
            this.flpTable.Controls.Add(this.tabControl1);
            this.flpTable.Location = new System.Drawing.Point(200, 173);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(694, 573);
            this.flpTable.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpAll);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tất Cả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpAll
            // 
            this.flpAll.AutoScroll = true;
            this.flpAll.Location = new System.Drawing.Point(6, 6);
            this.flpAll.Name = "flpAll";
            this.flpAll.Size = new System.Drawing.Size(648, 533);
            this.flpAll.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flpUnEmpty);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Có Người";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flpUnEmpty
            // 
            this.flpUnEmpty.AutoScroll = true;
            this.flpUnEmpty.Location = new System.Drawing.Point(6, 5);
            this.flpUnEmpty.Name = "flpUnEmpty";
            this.flpUnEmpty.Size = new System.Drawing.Size(648, 533);
            this.flpUnEmpty.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flpEmpty);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(660, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trống";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flpEmpty
            // 
            this.flpEmpty.AutoScroll = true;
            this.flpEmpty.Location = new System.Drawing.Point(6, 5);
            this.flpEmpty.Name = "flpEmpty";
            this.flpEmpty.Size = new System.Drawing.Size(648, 533);
            this.flpEmpty.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.lbEncouragement);
            this.panel2.Controls.Add(this.lbShopName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(200, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 172);
            this.panel2.TabIndex = 0;
            // 
            // lbEncouragement
            // 
            this.lbEncouragement.AutoSize = true;
            this.lbEncouragement.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEncouragement.ForeColor = System.Drawing.Color.Yellow;
            this.lbEncouragement.Location = new System.Drawing.Point(1095, 113);
            this.lbEncouragement.Name = "lbEncouragement";
            this.lbEncouragement.Size = new System.Drawing.Size(70, 27);
            this.lbEncouragement.TabIndex = 3;
            this.lbEncouragement.Text = "label2";
            this.lbEncouragement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbShopName
            // 
            this.lbShopName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.lbShopName.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbShopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbShopName.Location = new System.Drawing.Point(0, 40);
            this.lbShopName.Name = "lbShopName";
            this.lbShopName.Size = new System.Drawing.Size(1168, 40);
            this.lbShopName.TabIndex = 2;
            this.lbShopName.Text = "Coffe Shop";
            this.lbShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnCheckOut.IconColor = System.Drawing.Color.Black;
            this.btnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckOut.IconSize = 30;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckOut.Location = new System.Drawing.Point(243, 468);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(228, 71);
            this.btnCheckOut.TabIndex = 17;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Red;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Location = new System.Drawing.Point(0, 468);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(244, 71);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMerge.Location = new System.Drawing.Point(324, 86);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(90, 55);
            this.btnMerge.TabIndex = 14;
            this.btnMerge.Text = "Gộp Bàn";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Image = global::QLQCFTest.Properties.Resources.Order_ImgCaPheTrung;
            this.btnOrder.Location = new System.Drawing.Point(72, 86);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 55);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Gọi Món";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbTableName
            // 
            this.lbTableName.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTableName.Location = new System.Drawing.Point(0, 27);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(471, 38);
            this.lbTableName.TabIndex = 12;
            this.lbTableName.Text = "Tên Bàn";
            this.lbTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSwitch.Location = new System.Drawing.Point(197, 86);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(90, 55);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatarUser)).EndInit();
            this.flpTable.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TotalPrice.ResumeLayout(false);
            this.TotalPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAdmin;
        private Panel panel1;
        private Label label1;
        private Label lbDisplayUser;
        private Button btnNotification;
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
        private Label lbShopName;
        private PictureBox ptbAvatarUser;
        private Label lbEncouragement;
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel flpAll;
        private TabPage tabPage2;
        private FlowLayoutPanel flpUnEmpty;
        private TabPage tabPage3;
        private FlowLayoutPanel flpEmpty;
        private Button btnExit;
    }
}