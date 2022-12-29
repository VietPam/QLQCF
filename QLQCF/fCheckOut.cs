using QLQCF;
using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
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
                    if (money >=Convert.ToInt32(lbMoney.Text))
                    {
                        BillDAO.Instance.UpdatePriceAfterDiscount(bill, Convert.ToInt32(lbMoney.Text));
                        if (txbCode.Tag != null)
                        {
                           DiscountCodeDAO.Instance.UpdateCode((txbCode.Tag).ToString());
                        
                        }
                        fBill fbill = new fBill(table, Convert.ToInt32(txbMoney.Text), type, ftableManager,acc,Convert.ToInt32(textBox1.Text));
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

        private void txbMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        

        private void txbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txbCode.Text.Length >= 10 && !Char.IsControl(e.KeyChar)) { 

                e.Handled = true;
            }
           
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
            double money = bill.TotalPrice;
            double rate =DiscountDAO.Instance.GetRate(txbCode.Text);
            if (rate == -1)
            {
                MessageBox.Show("Mã Có Vấn Đề");
                txbCode.Tag= null;
            }
            else
            {
                lbMoney.Text = (money - money * rate).ToString();              
                Shop shop = ShopDAO.Instance.GetShop();
                lbMoney.Text = (Convert.ToInt32(lbMoney.Text) + Convert.ToInt32(shop.SurCharge) * Convert.ToInt32(textBox1.Text)).ToString();
                txbCode.Tag =txbCode.Text;
            }
        }

        private void fCheckOut_Load(object sender, EventArgs e)
        {
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
            lbMoney.Text = bill.TotalPrice.ToString();
            txbCode.Tag = null;

            DateTime dt = DateTime.Now;
            
            int time = dt.Hour * 60 + dt.Minute;
            Shop shop = ShopDAO.Instance.GetShop();
            bool flag = false;
            if(shop.TimeEnd>=shop.TimeStart) 
            {
                if(time>=shop.TimeStart && time<=shop.TimeEnd)
                {
                    flag = true;
                }
            }
            else
            {
                if(time>=shop.TimeStart || time<=shop.TimeEnd)
                {
                    flag = true;
                }
            }
            if(flag==true)
            {
                label3.Text = "Số Lượng Phụ Thu";
                label3.AutoSize = false;
                label3.Font = new Font("Times", 16f);   
                label3.Height = 29;
                label3.Width = 180;
                label3.TextAlign = ContentAlignment.MiddleCenter;
                
                panel2.Visible = false;
                panel1.Visible = false;
                this.Size = new Size(449, 300);
            }
            else
            {
                panel3.Visible= false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false; 
            panel2.Visible = true;
            panel1.Visible = true;
            this.Size = new Size(449, 484);
            Shop shop=ShopDAO.Instance.GetShop();
            lbMoney.Text=(Convert.ToInt32(lbMoney.Text)+Convert.ToInt32(shop.SurCharge)* Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}
