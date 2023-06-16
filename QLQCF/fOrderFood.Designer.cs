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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel4 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbFindFood = new TextBox();
            button1 = new Button();
            btnCancel = new Button();
            btnSubtractFood = new Button();
            btnAddFood = new Button();
            txbFoodCount = new NumericUpDown();
            cbFood = new ComboBox();
            cbCategoryFood = new ComboBox();
            lbTableName = new Label();
            pictureFood = new PictureBox();
            panel3 = new Panel();
            lsvHotFood = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            timer1 = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            lbHot = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbFoodCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFood).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lsvBill);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 856);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(947, 287);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 568);
            panel4.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.CheckBoxes = true;
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(330, 0);
            lsvBill.Margin = new Padding(3, 4, 3, 4);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(610, 853);
            lsvBill.TabIndex = 6;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            lsvBill.ItemCheck += lsvBill_ItemCheck;
            lsvBill.ItemChecked += lsvBill_ItemChecked;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Món";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Giá";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Lượng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành Tiền";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 134;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbFindFood);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnSubtractFood);
            panel2.Controls.Add(btnAddFood);
            panel2.Controls.Add(txbFoodCount);
            panel2.Controls.Add(cbFood);
            panel2.Controls.Add(cbCategoryFood);
            panel2.Controls.Add(lbTableName);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 855);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 163);
            label1.Name = "label1";
            label1.Size = new Size(93, 31);
            label1.TabIndex = 10;
            label1.Text = "Tìm";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 389);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 9;
            label3.Text = "Món";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 273);
            label2.Name = "label2";
            label2.Size = new Size(93, 31);
            label2.TabIndex = 8;
            label2.Text = "Loại";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txbFindFood
            // 
            txbFindFood.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txbFindFood.Location = new Point(115, 159);
            txbFindFood.Margin = new Padding(3, 4, 3, 4);
            txbFindFood.Name = "txbFindFood";
            txbFindFood.Size = new Size(189, 38);
            txbFindFood.TabIndex = 0;
            txbFindFood.TextChanged += txbFindFood_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(40, 764);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 63);
            button1.TabIndex = 7;
            button1.Text = "Xong";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Yellow;
            btnCancel.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(177, 764);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 63);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Huỷ Bill";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubtractFood
            // 
            btnSubtractFood.BackColor = Color.Red;
            btnSubtractFood.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtractFood.Location = new Point(40, 683);
            btnSubtractFood.Margin = new Padding(3, 4, 3, 4);
            btnSubtractFood.Name = "btnSubtractFood";
            btnSubtractFood.Size = new Size(253, 63);
            btnSubtractFood.TabIndex = 5;
            btnSubtractFood.Text = "-";
            btnSubtractFood.UseVisualStyleBackColor = false;
            btnSubtractFood.Click += btnSubtractFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Lime;
            btnAddFood.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFood.Location = new Point(40, 597);
            btnAddFood.Margin = new Padding(3, 4, 3, 4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(253, 63);
            btnAddFood.TabIndex = 4;
            btnAddFood.Text = "+";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // txbFoodCount
            // 
            txbFoodCount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txbFoodCount.Location = new Point(82, 485);
            txbFoodCount.Margin = new Padding(3, 4, 3, 4);
            txbFoodCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txbFoodCount.Name = "txbFoodCount";
            txbFoodCount.Size = new Size(165, 47);
            txbFoodCount.TabIndex = 3;
            txbFoodCount.TextAlign = HorizontalAlignment.Right;
            txbFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txbFoodCount.KeyPress += NumOnly;
            // 
            // cbFood
            // 
            cbFood.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbFood.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbFood.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(115, 379);
            cbFood.Margin = new Padding(3, 4, 3, 4);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(189, 37);
            cbFood.TabIndex = 2;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            cbFood.KeyPress += cbPress;
            // 
            // cbCategoryFood
            // 
            cbCategoryFood.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCategoryFood.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbCategoryFood.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoryFood.FormattingEnabled = true;
            cbCategoryFood.Location = new Point(115, 269);
            cbCategoryFood.Margin = new Padding(3, 4, 3, 4);
            cbCategoryFood.Name = "cbCategoryFood";
            cbCategoryFood.Size = new Size(189, 37);
            cbCategoryFood.TabIndex = 1;
            cbCategoryFood.SelectedIndexChanged += cbCategoryFood_SelectedIndexChanged;
            cbCategoryFood.KeyPress += cbPress;
            // 
            // lbTableName
            // 
            lbTableName.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbTableName.Location = new Point(0, 35);
            lbTableName.Name = "lbTableName";
            lbTableName.Size = new Size(330, 53);
            lbTableName.TabIndex = 0;
            lbTableName.Text = "Tên Bàn";
            lbTableName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureFood
            // 
            pictureFood.Location = new Point(0, 0);
            pictureFood.Margin = new Padding(3, 4, 3, 4);
            pictureFood.Name = "pictureFood";
            pictureFood.Size = new Size(253, 215);
            pictureFood.TabIndex = 1;
            pictureFood.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureFood);
            panel3.Location = new Point(942, 1);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 217);
            panel3.TabIndex = 1;
            // 
            // lsvHotFood
            // 
            lsvHotFood.CheckBoxes = true;
            lsvHotFood.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader5 });
            lsvHotFood.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lsvHotFood.GridLines = true;
            lsvHotFood.Location = new Point(942, 271);
            lsvHotFood.Margin = new Padding(3, 4, 3, 4);
            lsvHotFood.MultiSelect = false;
            lsvHotFood.Name = "lsvHotFood";
            lsvHotFood.Size = new Size(254, 584);
            lsvHotFood.TabIndex = 2;
            lsvHotFood.UseCompatibleStateImageBehavior = false;
            lsvHotFood.View = View.Details;
            lsvHotFood.ItemChecked += lsvHotFood_ItemChecked;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tên Món";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 154;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SL Gọi";
            columnHeader5.Width = 65;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel5
            // 
            panel5.Controls.Add(lbHot);
            panel5.Location = new Point(942, 220);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 52);
            panel5.TabIndex = 4;
            // 
            // lbHot
            // 
            lbHot.BackColor = Color.White;
            lbHot.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbHot.ForeColor = SystemColors.ControlText;
            lbHot.Location = new Point(0, 0);
            lbHot.Name = "lbHot";
            lbHot.Size = new Size(253, 52);
            lbHot.TabIndex = 3;
            lbHot.Text = "Hot";
            lbHot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fOrderFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 853);
            Controls.Add(panel5);
            Controls.Add(lsvHotFood);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fOrderFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gọi Món";
            FormClosing += fOrderFood_FormClosing;
            FormClosed += fOrderFood_FormClosed;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbFoodCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFood).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
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