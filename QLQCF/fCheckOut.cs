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
        int sizeheight;
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
                        fBill fbill = new fBill(table, Convert.ToInt32(txbMoney.Text), type, ftableManager,acc,Convert.ToInt32(txbNumSurcharge.Text));
                        fbill.ShowDialog();
                        this.Close();
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
                lbMoney.Text = (Convert.ToInt32(lbMoney.Text) + Convert.ToInt32(shop.SurCharge) * Convert.ToInt32(txbNumSurcharge.Text)).ToString();
                txbCode.Tag =txbCode.Text;
            }
        }

        private void fCheckOut_Load(object sender, EventArgs e)
        {
            Surcharge sur = SurchargeDAO.Instance.GetSurcharge();
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
            Shop shop = ShopDAO.Instance.GetShop();
            lbMoney.Text = bill.TotalPrice.ToString();
            txbCode.Tag = null;
            bool flag = CheckSurcharge(sur);
            sizeheight = this.Size.Height;
            if (flag==true)
            {
                panel3.Visible = true;
                panel2.Visible = false;
                panel1.Visible = false;
                panel5.Visible= false;
                this.Size = new Size(panel3.Width, panel3.Height+30);
                this.AcceptButton = btnNumSurcharge;
            }
            else
            {
                panel3.Visible= false;
            }
        }

        private void btnNumSurcharge_Click(object sender, EventArgs e)
        {
            int num = -1;
            int.TryParse(txbNumSurcharge.Text, out num);
            if (num >= 0)
            {
                panel3.Visible = false;
                panel2.Visible = true;
                panel1.Visible = true;
                panel5.Visible= true;
                this.Size = new Size(449, sizeheight);
                Shop shop = ShopDAO.Instance.GetShop();
                lbMoney.Text = (Convert.ToInt32(lbMoney.Text) + Convert.ToInt32(shop.SurCharge) * Convert.ToInt32(txbNumSurcharge.Text)).ToString();
                this.AcceptButton = btnCheckOut;
            }
        }

        private bool CheckSurcharge(Surcharge sur)
        {
            DateTime dt = DateTime.Now;
            int time = dt.Hour * 60 + dt.Minute;
            if (sur.Hour == 1)
            {
                if (sur.HourEnd >= sur.HourStart)
                {
                    if (time >= sur.HourStart && time <= sur.HourEnd)
                    {
                        return true;
                    }
                }
                else
                {
                    if (time >= sur.HourStart || time <= sur.HourEnd)
                    {
                        return true;
                    }
                }
            }
            if (sur.Day == 1)
                if (dt <= sur.DayEnd && dt >= sur.DayStart)
                    return true;
            if (sur.DayofWeek == 1)
            {
                DayOfWeek[] dayOfWeeks = new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
                int flag = -1;
                for (int i = 0; i < 7; i++)
                {
                    if (dt.DayOfWeek == dayOfWeeks[i])
                    {
                        flag = i;
                        break;
                    }
                }
                if (flag != -1)
                    return true;
            }
            return false;
            
        }

        

        private void cbTypeMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
