using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest.DAO;
using QLQCFTest.DTO;

namespace QLQCF
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord =  txbPassWord.Text;
            if (Login(userName, passWord))
            {
                Account acc = AccountDAO.Instance.LoadUser(userName);
                fTableManager f = new fTableManager(acc);
                this.Hide();
                f.ShowDialog();
                this.Show();
                txbPassWord.Text = null;
            }
            else
            {
                MessageBox.Show("Sai tài khoản mật khẩu");
            }

        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void chbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassWord.Checked)
            {
                txbPassWord.UseSystemPasswordChar = false;
            }
            else
                txbPassWord.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            Shop shop = ShopDAO.Instance.GetShop();
            lbNameShop.Text = shop.NameShop;
        }
    }
}