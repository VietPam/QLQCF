using QLQCF;
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
    public partial class fCheckOut : Form
    {
        Table table;
        fTableManager ftableManager;
        Account acc;
        public fCheckOut(Table tabel,fTableManager fTable, Account account)
        {
            acc= account;
            ftableManager = fTable;
            table = tabel;
            InitializeComponent();
            this.acc = acc;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

                int moneyReceive;
                bool check = int.TryParse(txbMoney.Text, out moneyReceive);
                if (check)
                {
                    string type;
                    type = cbTypeMoney.Text;
                    int money = 0;
                    if (type == "VND")
                    {
                        money = moneyReceive;
                    }
                    else if (type == "USD")
                    {
                        money = (moneyReceive * 24816);
                    }
                    else if (type == "BẢNG")
                    {
                        money = (moneyReceive * 29513);
                    }
                    else if (type == "NDT")
                    {
                        money = (moneyReceive * 3481);
                    }
                    else if (type == "YÊN")
                    {
                        money = (moneyReceive * 177);
                    }
                    if (money >= (BillDAO.Instance.GetUnCheckBillwithtable(table)).TotalPrice)
                    {
                        fBill fbill = new fBill(table, Convert.ToInt32(txbMoney.Text), type, ftableManager,acc);
                        fbill.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không đủ tiền để thanh toán hoá đơn");
                    }

                }
                else
                {
                    MessageBox.Show("vui Lòng nhập vào số tiền hợp lệ!");
                }
            
        }
    }
}
