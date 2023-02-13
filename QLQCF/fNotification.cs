using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCFTest
{
    public partial class fNotification : Form
    {
        public fNotification()
        {
            InitializeComponent();
            LoadComboBox();
        }

        public string FolderDir = @"D:\hoc\C#\Sound\New Sound Audio";

        public void LoadComboBox()
        {
            DirectoryInfo d = new DirectoryInfo(FolderDir);
            FileInfo[] Files = d.GetFiles("*.wav"); //Chỉ nhận các file .wav
            /*File âm thanh .wav có chất lượng đầu ra tốt hơn file.mp3
                Ta có thể lưu ý điều này trong phần cài đặt
                Ngoài ra hãy thêm đường dẫn đến web convert mp3->wav cho khách(tùy khác sẽ cói nhu cầu)*/

            cbNotification.DataSource = Files;
            cbNotification.DisplayMember = "Name";
            
            cbFileAudio.DataSource = Files;
            cbFileAudio.DisplayMember = "Name";

            txbFolderDir.Text = FolderDir;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = FolderDir + "\\" + cbNotification.Text;
            player.Play();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fNotification_Load(object sender, EventArgs e)
        {
        }

        private void btnChangeFileName_Click(object sender, EventArgs e)
        {
            string oldfilename = FolderDir + "\\" + cbFileAudio.Text;
            string newfilename = FolderDir + "\\" + txbNewFileName.Text;

            System.IO.File.Move(oldfilename, newfilename);
            LoadComboBox();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FolderDir = txbFolderDir.Text;
            MessageBox.Show("Bạn đã xác nhận thành công!");
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = FolderDir,
                FileName = "explorer.exe"
            };

        Process.Start(startInfo);
        }
    }
}
