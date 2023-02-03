namespace QLQCFTest
{
    partial class fNotification
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.flpPlaying = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbNotification = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNotification = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.flpSetting = new System.Windows.Forms.TabPage();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFileAudio = new System.Windows.Forms.ComboBox();
            this.txbNewFileName = new System.Windows.Forms.TextBox();
            this.btnChangeFileName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFolderDir = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.flpPlaying.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotification)).BeginInit();
            this.panel1.SuspendLayout();
            this.flpSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.flpPlaying);
            this.tabControl1.Controls.Add(this.flpSetting);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(535, 310);
            this.tabControl1.TabIndex = 0;
            // 
            // flpPlaying
            // 
            this.flpPlaying.Controls.Add(this.label6);
            this.flpPlaying.Controls.Add(this.panel2);
            this.flpPlaying.Controls.Add(this.panel1);
            this.flpPlaying.Location = new System.Drawing.Point(4, 24);
            this.flpPlaying.Name = "flpPlaying";
            this.flpPlaying.Padding = new System.Windows.Forms.Padding(3);
            this.flpPlaying.Size = new System.Drawing.Size(527, 282);
            this.flpPlaying.TabIndex = 0;
            this.flpPlaying.Text = "Chạy thông báo";
            this.flpPlaying.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lưu ý: Chỉ nhận file.wav \r\nnhằm có chất lượng \r\nâm thanh tốt nhất";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbNotification);
            this.panel2.Location = new System.Drawing.Point(151, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 186);
            this.panel2.TabIndex = 4;
            // 
            // pbNotification
            // 
            this.pbNotification.Image = global::QLQCFTest.Properties.Resources.volume_high_solid;
            this.pbNotification.Location = new System.Drawing.Point(5, 5);
            this.pbNotification.Name = "pbNotification";
            this.pbNotification.Size = new System.Drawing.Size(220, 176);
            this.pbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNotification.TabIndex = 0;
            this.pbNotification.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNotification);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Location = new System.Drawing.Point(8, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 105);
            this.panel1.TabIndex = 3;
            // 
            // cbNotification
            // 
            this.cbNotification.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNotification.FormattingEnabled = true;
            this.cbNotification.Location = new System.Drawing.Point(72, 23);
            this.cbNotification.Name = "cbNotification";
            this.cbNotification.Size = new System.Drawing.Size(316, 48);
            this.cbNotification.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(394, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 50);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // flpSetting
            // 
            this.flpSetting.Controls.Add(this.btnOpenFolder);
            this.flpSetting.Controls.Add(this.label5);
            this.flpSetting.Controls.Add(this.cbFileAudio);
            this.flpSetting.Controls.Add(this.txbNewFileName);
            this.flpSetting.Controls.Add(this.btnChangeFileName);
            this.flpSetting.Controls.Add(this.label4);
            this.flpSetting.Controls.Add(this.label3);
            this.flpSetting.Controls.Add(this.label2);
            this.flpSetting.Controls.Add(this.btnConfirm);
            this.flpSetting.Controls.Add(this.label1);
            this.flpSetting.Controls.Add(this.txbFolderDir);
            this.flpSetting.Location = new System.Drawing.Point(4, 24);
            this.flpSetting.Name = "flpSetting";
            this.flpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.flpSetting.Size = new System.Drawing.Size(527, 282);
            this.flpSetting.TabIndex = 1;
            this.flpSetting.Text = "Cài đặt";
            this.flpSetting.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFolder.Location = new System.Drawing.Point(368, 65);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(150, 50);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "Mở Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lưu ý: Vui lòng thêm \".wav\"\r\nở cuối tên để tránh gặp lỗi";
            // 
            // cbFileAudio
            // 
            this.cbFileAudio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFileAudio.FormattingEnabled = true;
            this.cbFileAudio.Location = new System.Drawing.Point(137, 148);
            this.cbFileAudio.Name = "cbFileAudio";
            this.cbFileAudio.Size = new System.Drawing.Size(381, 33);
            this.cbFileAudio.TabIndex = 8;
            // 
            // txbNewFileName
            // 
            this.txbNewFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNewFileName.Location = new System.Drawing.Point(137, 187);
            this.txbNewFileName.Name = "txbNewFileName";
            this.txbNewFileName.Size = new System.Drawing.Size(381, 33);
            this.txbNewFileName.TabIndex = 7;
            // 
            // btnChangeFileName
            // 
            this.btnChangeFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeFileName.Location = new System.Drawing.Point(368, 226);
            this.btnChangeFileName.Name = "btnChangeFileName";
            this.btnChangeFileName.Size = new System.Drawing.Size(150, 50);
            this.btnChangeFileName.TabIndex = 6;
            this.btnChangeFileName.Text = "Xong";
            this.btnChangeFileName.UseVisualStyleBackColor = true;
            this.btnChangeFileName.Click += new System.EventHandler(this.btnChangeFileName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đổi tên file âm thanh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn file:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(212, 65);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 50);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ Folder \r\nchứa file âm thanh:";
            // 
            // txbFolderDir
            // 
            this.txbFolderDir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFolderDir.Location = new System.Drawing.Point(194, 26);
            this.txbFolderDir.Name = "txbFolderDir";
            this.txbFolderDir.Size = new System.Drawing.Size(324, 33);
            this.txbFolderDir.TabIndex = 0;
            // 
            // fNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Báo";
            this.Load += new System.EventHandler(this.fNotification_Load);
            this.tabControl1.ResumeLayout(false);
            this.flpPlaying.ResumeLayout(false);
            this.flpPlaying.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotification)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flpSetting.ResumeLayout(false);
            this.flpSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage flpPlaying;
        private Panel panel2;
        private PictureBox pbNotification;
        private Panel panel1;
        private ComboBox cbNotification;
        private Button btnPlay;
        private TabPage flpSetting;
        private TextBox txbFolderDir;
        private Label label1;
        private Button btnConfirm;
        private ComboBox cbFileAudio;
        private TextBox txbNewFileName;
        private Button btnChangeFileName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnOpenFolder;
        private Label label6;
    }
}