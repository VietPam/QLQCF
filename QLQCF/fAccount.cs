using QLQCF.DAO;
using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCFTest
{
    public partial class fAccount : Form
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public fAccount(Account useracc)
        {
            InitializeComponent();

            acc = useracc;
            ChangeAccount(acc);
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = acc.UserName;
            txbDisplayUserName.Text = acc.DisplayName;
        }

        void UpdateAccount()
        {
            string displayName = txbDisplayUserName.Text;
            string name = txbUserName.Text;
            string password = txbPassword.Text;
            string newpass = txbNewPass.Text;
            string repass = txbRePass.Text;

            if (!newpass.Equals(repass))
            {
                MessageBox.Show("Vui long nhap lai mat khau dung voi mat khau moi");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccountProfile(name, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!");
                } 
                    
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
