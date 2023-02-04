namespace QLQCF
{
    partial class fOrderFood
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFindFood = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubtractFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.txbFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategoryFood = new System.Windows.Forms.ComboBox();
            this.lbTableName = new System.Windows.Forms.Label();
            this.pictureFood = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvHotFood = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbHot = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 856);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(947, 287);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 568);
            this.panel4.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(330, 0);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(610, 853);
            this.lsvBill.TabIndex = 6;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 134;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbFindFood);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubtractFood);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Controls.Add(this.txbFoodCount);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Controls.Add(this.cbCategoryFood);
            this.panel2.Controls.Add(this.lbTableName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 855);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Món";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbFindFood
            // 
            this.txbFindFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFindFood.Location = new System.Drawing.Point(115, 159);
            this.txbFindFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFindFood.Name = "txbFindFood";
            this.txbFindFood.Size = new System.Drawing.Size(189, 38);
            this.txbFindFood.TabIndex = 0;
            this.txbFindFood.TextChanged += new System.EventHandler(this.txbFindFood_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(40, 764);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xong";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(177, 764);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 63);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Huỷ Bill";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubtractFood
            // 
            this.btnSubtractFood.BackColor = System.Drawing.Color.Red;
            this.btnSubtractFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtractFood.Location = new System.Drawing.Point(40, 683);
            this.btnSubtractFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubtractFood.Name = "btnSubtractFood";
            this.btnSubtractFood.Size = new System.Drawing.Size(253, 63);
            this.btnSubtractFood.TabIndex = 5;
            this.btnSubtractFood.Text = "-";
            this.btnSubtractFood.UseVisualStyleBackColor = false;
            this.btnSubtractFood.Click += new System.EventHandler(this.btnSubtractFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Lime;
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(40, 597);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(253, 63);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "+";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // txbFoodCount
            // 
            this.txbFoodCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFoodCount.Location = new System.Drawing.Point(82, 485);
            this.txbFoodCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFoodCount.Name = "txbFoodCount";
            this.txbFoodCount.Size = new System.Drawing.Size(165, 47);
            this.txbFoodCount.TabIndex = 3;
            this.txbFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbFood
            // 
            this.cbFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(115, 379);
            this.cbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(189, 37);
            this.cbFood.TabIndex = 2;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.cbFood_SelectedIndexChanged);
            this.cbFood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPress);
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCategoryFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCategoryFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Location = new System.Drawing.Point(115, 269);
            this.cbCategoryFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.Size = new System.Drawing.Size(189, 37);
            this.cbCategoryFood.TabIndex = 1;
            this.cbCategoryFood.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFood_SelectedIndexChanged);
            this.cbCategoryFood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPress);
            // 
            // lbTableName
            // 
            this.lbTableName.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTableName.Location = new System.Drawing.Point(0, 35);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(330, 53);
            this.lbTableName.TabIndex = 0;
            this.lbTableName.Text = "Tên Bàn";
            this.lbTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureFood
            // 
            this.pictureFood.Location = new System.Drawing.Point(0, 0);
            this.pictureFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureFood.Name = "pictureFood";
            this.pictureFood.Size = new System.Drawing.Size(253, 215);
            this.pictureFood.TabIndex = 1;
            this.pictureFood.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureFood);
            this.panel3.Location = new System.Drawing.Point(942, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 217);
            this.panel3.TabIndex = 1;
            // 
            // lsvHotFood
            // 
            this.lsvHotFood.CheckBoxes = true;
            this.lsvHotFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader5});
            this.lsvHotFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lsvHotFood.GridLines = true;
            this.lsvHotFood.Location = new System.Drawing.Point(942, 271);
            this.lsvHotFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvHotFood.MultiSelect = false;
            this.lsvHotFood.Name = "lsvHotFood";
            this.lsvHotFood.Size = new System.Drawing.Size(254, 584);
            this.lsvHotFood.TabIndex = 2;
            this.lsvHotFood.UseCompatibleStateImageBehavior = false;
            this.lsvHotFood.View = System.Windows.Forms.View.Details;
            this.lsvHotFood.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsvHotFood_ItemChecked);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Món";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 154;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SL Gọi";
            this.columnHeader5.Width = 65;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbHot);
            this.panel5.Location = new System.Drawing.Point(942, 220);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 52);
            this.panel5.TabIndex = 4;
            // 
            // lbHot
            // 
            this.lbHot.BackColor = System.Drawing.Color.White;
            this.lbHot.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHot.Location = new System.Drawing.Point(0, 0);
            this.lbHot.Name = "lbHot";
            this.lbHot.Size = new System.Drawing.Size(253, 52);
            this.lbHot.TabIndex = 3;
            this.lbHot.Text = "Hot";
            this.lbHot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 856);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lsvHotFood);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi Món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fOrderFood_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fOrderFood_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListView lsvBill;
        private Panel panel2;
        private Button btnAddFood;
        private NumericUpDown txbFoodCount;
        private ComboBox cbFood;
        private ComboBox cbCategoryFood;
        private PictureBox pictureFood;
        private Label lbTableName;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnSubtractFood;
        private Button btnCancel;
        private Panel panel3;
        private TextBox txbFindFood;
        private Panel panel4;
        private ListView lsvHotFood;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Label lbHot;
    }
}