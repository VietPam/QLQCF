using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest;
using QLQCFTest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            lsvBillTBMNG.Controls.Clear();
            flpTable.Controls.Clear();
            TableDAO.Instance.CheckListTableStatus();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach (Table tabel in tablelist)
            {
                Button btn = new Button();
                if (BillDAO.Instance.CheckEmpty(tabel))
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    
                    btn.BackColor = Color.YellowGreen;
                }
                btn.Text = tabel.Name + "\n" + tabel.Status;
                btn.Width = TableDAO.TableWidth;
                btn.Height = TableDAO.TableHeight;
                flpTable.Controls.Add(btn);
                btn.Tag = tabel;
                
                btn.Click += btn_CLick;     
            }
           
            
        }

        private void btn_CLick(object sender, EventArgs e)
        {
            txtTotalPrice.Text = "0";
            Table tabel = (sender as Button).Tag as Table;
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(tabel);
            lbTableName.Text = tabel.Name;
            lbTableName.Font = new Font("Times", 16f);
            lbTableName.TextAlign = ContentAlignment.MiddleCenter;
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
                txtTotalPrice.Text = bill.TotalPrice.ToString();
            }
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            fAdmin fadmin = new fAdmin();
            fadmin.Show();
            fadmin.acc = acc;
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                fOrder.Show();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lbTableName.Tag as Table;
            fCheckOut fcheckout= new fCheckOut(table,this);
            fcheckout.Show(this);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            fSwitchTable fSwitchTabel=new fSwitchTable(lbTableName.Tag as Table,this);
            fSwitchTabel.Show();
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
                fMergeTable fmergeTable = new fMergeTable(table, this);
                fmergeTable.Show();
            }

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fAccount fAccount = new fAccount();
            fAccount.Show();
        }
    }
}
