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
        public fCheckOut(Table tabel,fTableManager fTable)
        {
            ftableManager = fTable;
            table = tabel;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int value;
            bool check =int.TryParse(txbMoney.Text, out  value);
            if( check)
            {
                string type;
                type = cbTypeMoney.Text;
                if (value >= (BillDAO.Instance.GetUnCheckBillwithtable(table)).TotalPrice)
                {
                    fBill fbill = new fBill(table, Convert.ToInt32(txbMoney.Text), type,ftableManager);
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
