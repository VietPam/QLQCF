namespace QLQCF
{
    partial class fMergeTable
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
            this.lbNameTable = new System.Windows.Forms.Label();
            this.cbTableCanMerge = new System.Windows.Forms.ComboBox();
            this.cbTableResult = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMergeTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameTable.Location = new System.Drawing.Point(64, 41);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(79, 23);
            this.lbNameTable.TabIndex = 0;
            this.lbNameTable.Text = "Tên Bàn";
            // 
            // cbTableCanMerge
            // 
            this.cbTableCanMerge.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTableCanMerge.FormattingEnabled = true;
            this.cbTableCanMerge.Location = new System.Drawing.Point(206, 38);
            this.cbTableCanMerge.Name = "cbTableCanMerge";
            this.cbTableCanMerge.Size = new System.Drawing.Size(121, 31);
            this.cbTableCanMerge.TabIndex = 1;
            this.cbTableCanMerge.SelectedIndexChanged += new System.EventHandler(this.cbTableCanMerge_SelectedIndexChanged);
            // 
            // cbTableResult
            // 
            this.cbTableResult.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTableResult.FormattingEnabled = true;
            this.cbTableResult.Location = new System.Drawing.Point(186, 127);
            this.cbTableResult.Name = "cbTableResult";
            this.cbTableResult.Size = new System.Drawing.Size(121, 31);
            this.cbTableResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "-->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(164, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // btnMergeTable
            // 
            this.btnMergeTable.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMergeTable.Location = new System.Drawing.Point(97, 183);
            this.btnMergeTable.Name = "btnMergeTable";
            this.btnMergeTable.Size = new System.Drawing.Size(166, 50);
            this.btnMergeTable.TabIndex = 3;
            this.btnMergeTable.Text = "Gộp Bàn";
            this.btnMergeTable.UseVisualStyleBackColor = true;
            this.btnMergeTable.Click += new System.EventHandler(this.btnMergeTable_Click);
            // 
            // fMergeTable
            // 
            this.AcceptButton = this.btnMergeTable;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 256);
            this.Controls.Add(this.btnMergeTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTableResult);
            this.Controls.Add(this.cbTableCanMerge);
            this.Controls.Add(this.lbNameTable);
            this.Name = "fMergeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gộp Bàn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMergeTable_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNameTable;
        private ComboBox cbTableCanMerge;
        private ComboBox cbTableResult;
        private Label label2;
        private Label label3;
        private Button btnMergeTable;
    }
}