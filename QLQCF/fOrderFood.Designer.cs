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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubtractFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategoryFood = new System.Windows.Forms.ComboBox();
            this.pictureFood = new System.Windows.Forms.PictureBox();
            this.lbTableName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 637);
            this.panel1.TabIndex = 0;
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
            this.lsvBill.Location = new System.Drawing.Point(289, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(534, 635);
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
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSubtractFood);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Controls.Add(this.nmFoodCount);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Controls.Add(this.cbCategoryFood);
            this.panel2.Controls.Add(this.pictureFood);
            this.panel2.Controls.Add(this.lbTableName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 638);
            this.panel2.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(35, 573);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(221, 47);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Huỷ Bill";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubtractFood
            // 
            this.btnSubtractFood.BackColor = System.Drawing.Color.Red;
            this.btnSubtractFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtractFood.Location = new System.Drawing.Point(35, 512);
            this.btnSubtractFood.Name = "btnSubtractFood";
            this.btnSubtractFood.Size = new System.Drawing.Size(221, 47);
            this.btnSubtractFood.TabIndex = 5;
            this.btnSubtractFood.Text = "-";
            this.btnSubtractFood.UseVisualStyleBackColor = false;
            this.btnSubtractFood.Click += new System.EventHandler(this.btnSubtractFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Red;
            this.btnAddFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(35, 448);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(221, 47);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "+";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmFoodCount.Location = new System.Drawing.Point(90, 395);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(119, 29);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(35, 334);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(221, 31);
            this.cbFood.TabIndex = 2;
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Location = new System.Drawing.Point(35, 266);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.Size = new System.Drawing.Size(221, 31);
            this.cbCategoryFood.TabIndex = 1;
            this.cbCategoryFood.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFood_SelectedIndexChanged);
            // 
            // pictureFood
            // 
            this.pictureFood.Location = new System.Drawing.Point(35, 86);
            this.pictureFood.Name = "pictureFood";
            this.pictureFood.Size = new System.Drawing.Size(221, 161);
            this.pictureFood.TabIndex = 1;
            this.pictureFood.TabStop = false;
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTableName.Location = new System.Drawing.Point(65, 26);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(144, 40);
            this.lbTableName.TabIndex = 0;
            this.lbTableName.Text = "Tên Bàn";
            this.lbTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 639);
            this.Controls.Add(this.panel1);
            this.Name = "fOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fOrderFood";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fOrderFood_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fOrderFood_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ListView lsvBill;
        private Panel panel2;
        private Button btnAddFood;
        private NumericUpDown nmFoodCount;
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
    }
}