using QLQCF;
using QLQCF.DAO;
using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCFTest
{
    public partial class fBill : Form
    {
        Table table;
        int moneyReceive;
        string type;
        fTableManager ftableManager;
        Account acc;
        public fBill(Table tabel,int money,string TypeMoney,fTableManager fTable,Account account )
        {
            acc=account;
            ftableManager = fTable;
            moneyReceive=money;
            type=TypeMoney;
            table = tabel;
            InitializeComponent();
            LoadBill();
        }

        private void LoadBill()
        {
            int count = 1;
            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
            lbIDBill.Text = bill.Id.ToString();
            lbTableName.Text = table.Name;
            lbDisplayAccount.Text = acc.DisplayName;
            lbDateIn.Text = bill.DayCheckIn.ToString();
            List<BillInfo> lbillinfo=BillInfoDAO.Instance.GetListBillInfoWithTable(table);
            foreach(BillInfo billinfo in lbillinfo)
            {
                AddLabelNumber(count);
                AddLabelName(count, billinfo);
                AddLabelAmount(count,billinfo);
                AddLabelPrice(count,billinfo);
                AddLabelTotal(count, billinfo);
                
                this.Height += 30;
                panel4.Location = new Point(panel4.Location.X, panel4.Location.Y+30);
                flpBillInfo.Height += 30;
                count++;

            }
            AddLabelType();
            AddLabelMoneyBack(bill);
            if (table.Type == 1)
            {
                lbType.Text = "5000";
            }
            else if (table.Type == 0)
            {
                lbType.Text = "0000";
            }
            lbMoneyReceive.Text = moneyReceive.ToString();
            lbMoneyType.Text = type.ToString();
            lbTotalPrice.Text = bill.TotalPrice.ToString();
            BillDAO.Instance.UpdateBillChecked(bill);
            lbDateOut.Text = DateTime.Now.ToString();
            ftableManager.LoadForm();
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void AddLabelNumber(int i)
        {
            Label label = new Label();
            label.Text = i.ToString();
            label.Height = 30;
            label.Width = 30;
            label.TextAlign = ContentAlignment.MiddleCenter;
            flpNumber.Controls.Add(label);
            flpNumber.Height = 30 * i;
        }

        private void AddLabelName(int i,BillInfo billinfo)
        {
            Label label = new Label();
            label.Text = FoodDAO.Instance.GetFoodByBillInfo(billinfo).Name;
            label.Height = 30;
            label.Width = 130;
            label.TextAlign=ContentAlignment.MiddleCenter;
            flpFoodName.Controls.Add(label);
            flpFoodName.Height = 30 * i;
        }
        private void AddLabelAmount(int i,BillInfo billinfo)
        {
            Label label = new Label();
            label.Text = billinfo.Count.ToString();
            label.Height = 30;
            label.Width = 75;
            label.TextAlign = ContentAlignment.MiddleCenter;
            flpAmount.Controls.Add(label);
            flpAmount.Height = 30 * i;
        }
        private void AddLabelPrice(int i, BillInfo billinfo)
        {
            Label label = new Label();
            label.Text = FoodDAO.Instance.GetFoodByBillInfo(billinfo).Price.ToString();
            label.Height = 30;
            label.Width = 85;
            label.TextAlign = ContentAlignment.MiddleCenter;
            flpPrice.Controls.Add(label);
            flpPrice.Height = 30 * i;
        }
        private void AddLabelTotal(int i, BillInfo billinfo)
        {
            Label label = new Label();
            label.Text = (FoodDAO.Instance.GetFoodByBillInfo(billinfo).Price*billinfo.Count).ToString();
            label.Height = 30;
            label.Width = 107;
            label.TextAlign = ContentAlignment.MiddleCenter;
            flpTotal.Controls.Add(label);
            flpTotal.Height = 30 * i;
        }

        private void AddLabelType()
        {
            Label label = new Label();
            label.Text = "5000";
            label.Height = 30;
            label.Width = 107;
            label.TextAlign = ContentAlignment.MiddleCenter;
            flpTotal.Controls.Add(label);
            flpTotal.Height = 30;
        }

        private void AddLabelMoneyBack(Bill bill)
        {
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
            lbMoneyBack.Text = (money-bill.TotalPrice).ToString();
        }
    }
}
