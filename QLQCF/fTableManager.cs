using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest;
using QLQCFTest.DAO;
using QLQCFTest.DTO;
using QLQCFTest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCF
{
    public partial class fTableManager : Form
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public fTableManager(Account account)
        {
            this.acc = account;

            InitializeComponent();
            LoadForm();
            LoadAccount();

            ChangeAccount(acc.Type);
        }


        void ChangeAccount(int type)
        {
            if (type == 1)
            {
                btnAdmin.Visible = false;
            }
        }

        public void LoadAccount()
        {
            lbDisplayUser.Text = Acc.DisplayName;

        }
        public void LoadForm()
        {
            Shop shop = ShopDAO.Instance.GetShop();
            lbShopName.Text = shop.NameShop;
            lbEncouragement.Text = shop.Encouragement;
            TableDAO.Instance.CheckListTableStatus();
            LoadTable();

        }

        public void LoadTable()
        {
            Shop shop = ShopDAO.Instance.GetShop();
            flpAll.Controls.Clear();
            flpEmpty.Controls.Clear();
            flpUnEmpty.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table tabel in tablelist)
            {
                Button btn = new Button();

                if (BillDAO.Instance.CheckEmpty(tabel))
                {   
                    LoadEmptyTable(tabel);
                }
                else
                {    
                    LoadUnEmptyTable(tabel);
                }
                if (tabel.Type==0)
                {
                    btn.BackColor = Color.White;              
                }
                else
                {
                    btn.BackColor = Color.Yellow;
 
                }
                btn.Text = tabel.Name + "\n" + tabel.Status;
                btn.Width = TableDAO.TableWidth;
                btn.Height = TableDAO.TableHeight;
                btn.Tag = tabel;
                flpAll.Controls.Add(btn);
                btn.Click += btn_CLick;
            }
        }

        void LoadEmptyTable(Table tabel)
        {

            Button btn = new Button();
            if (tabel.Type == 0)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Yellow;

            }
            btn.Text = tabel.Name + "\n" + tabel.Status;
            btn.Width = TableDAO.TableWidth;
            btn.Height = TableDAO.TableHeight;
            btn.Tag = tabel;
            flpEmpty.Controls.Add(btn);
            btn.Click += btn_CLick;
        }
        void LoadUnEmptyTable(Table tabel)
        {


            Button btn = new Button();
            if (tabel.Type == 0)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.Yellow;

            }
            btn.Text = tabel.Name + "\n" + tabel.Status;
            btn.Width = TableDAO.TableWidth;
            btn.Height = TableDAO.TableHeight;
            btn.Tag = tabel;
            flpUnEmpty.Controls.Add(btn);
            btn.Click += btn_CLick;
        }

        

        private void btn_CLick(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "0";
            Table tabel = (sender as Button).Tag as Table;
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(tabel);
            lbTableName.Text = tabel.Name;

            lbTableName.Tag = tabel;
            Button bt = sender as Button;
            lsvBillTBMNG.Items.Clear();
            if (bill != null)
            {
                List<BillInfo> lBilInfo = BillInfoDAO.Instance.GetListBillInfoWithTable(tabel);
                foreach (BillInfo billInfo in lBilInfo)
                {
                    string foodName = (FoodDAO.Instance.GetFoodByBillInfo(billInfo)).Name;
                    ListViewItem listView = new ListViewItem(foodName);
                    listView.SubItems.Add(FoodDAO.Instance.GetPricewithName(foodName).ToString());
                    listView.SubItems.Add((billInfo.Count).ToString());
                    listView.SubItems.Add((FoodDAO.Instance.GetPricewithName(foodName) * billInfo.Count).ToString());
                    lsvBillTBMNG.Items.Add(listView);
                }
                BillDAO.Instance.UpdatePrice(tabel, bill);
                UpdateTotalPricetxt();
            }
        }



        void UpdateTotalPricetxt()
        {
            Table table = lbTableName.Tag as Table;
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
            txtTotalPrice.Text = bill.TotalPrice.ToString();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin fadmin = new fAdmin(this);
            fadmin.ShowDialog();
            fadmin.acc = acc;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (lbTableName.Tag == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Để Order!");
            }
            else
            {
                Table tabel = lbTableName.Tag as Table;
                fOrderFood fOrder = new fOrderFood(tabel, this);
                fOrder.ShowDialog(this);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lbTableName.Tag as Table;
            if (table != null)
            {
                if (BillDAO.Instance.CheckEmpty(table)) { MessageBox.Show("Bàn không có gì để thanh toán!"); }
                else
                {

                    fCheckOut fcheckout = new fCheckOut(table, this, acc);
                    fcheckout.ShowDialog(this);
                }
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            fSwitchTable fSwitchTabel = new fSwitchTable(lbTableName.Tag as Table, this);
            fSwitchTabel.ShowDialog(this);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            Table table = lbTableName.Tag as Table;
            if (BillDAO.Instance.CheckEmpty(table))
            {
                MessageBox.Show("Không thể gộp bàn không có người");
            }
            else
            {
                List<Table> lTable = TableDAO.Instance.GetListTableUnEmptyandExceptChoose(table);
                if (lTable.Count > 0)
                {
                    fMergeTable fmergeTable = new fMergeTable(table, this);
                    fmergeTable.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Không đủ 2 bàn để gộp");
                }
            }


        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount fAccount = new fAccount(acc);
            fAccount.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = lbEncouragement.Location.X;
            x--;
            int y = lbEncouragement.Location.Y;
            lbEncouragement.Location = new Point(x, y);
            if (x <= 0 - lbEncouragement.Size.Width)
            {
                x = panel2.Width;
                lbEncouragement.Location = new Point(x, y);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            fNotification fNotification = new fNotification();
            fNotification.ShowDialog();
        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ask;
            ask = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
