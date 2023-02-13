using QLQCF;
using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        int surCharge;
        public fBill(Table tabel,int money,string TypeMoney,fTableManager fTable,Account account,int surcharge )
        {
            surCharge= surcharge;
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
            Shop shop = ShopDAO.Instance.GetShop();
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
                flpAdd.Location = new Point(flpAdd.Location.X, flpAdd.Location.Y + 30);
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 30);
                flpBillInfo.Height += 30;
                count++;
                FoodDAO.Instance.IncreaseFoodTotalCount(billinfo);
            }
            AddLabelMoneyBack(bill);
            if (table.Type == 1)
            {
                lbType.Text = ChangeMoneytoString(shop.VipCost);
            }
            else
            {
                lbType.Visible = false;
                lbVND.Visible = false;
                label17.Visible = false;
            }
            if(surCharge==0) { 
            }         
            else
            {
                
                Label lb1=new Label();
                lb1.Size =new Size(label17.Width,label17.Height);
                lb1.TextAlign = label17.TextAlign;
                lb1.Text = "Phụ Thu";
                Label lb2=new Label();
                lb2.Size =new Size(lbType.Width,lbType.Height);
                lb2.Text= ChangeMoneytoString(shop.SurCharge);
                lb2.TextAlign = lbType.TextAlign;
                Label lb3=new Label();
                lb3.Size = lbVND.Size;
                lb3.TextAlign = ContentAlignment.MiddleCenter;
                lb3.Text = "VND";
                lb3.Font = new Font(lbVND.Font,FontStyle.Bold);
                flpAdd.Controls.Add(lb1);
                flpAdd.Controls.Add(lb2);
                flpAdd.Controls.Add(lb3);
                flpAdd.Height += lb1.Height;
                this.Height += lb1.Height;
                panel4.Location=new Point(panel4.Location.X,panel4.Location.Y+lb1.Height);
                panel3.Location= new Point(panel3.Location.X, panel3.Location.Y + lb1.Height);
            }
            if (type != "VND")
            {
                lbMoneyReceive.Text = moneyReceive.ToString();
            }
            else
            {
                lbMoneyReceive.Text = ChangeMoneytoString(moneyReceive);
            }
            lbMoneyType.Text = type.ToString();
            lbTotalPrice.Text = ChangeMoneytoString(bill.TotalPrice);
            
            BillDAO.Instance.UpdateBillChecked(bill);
            
            ftableManager.LoadForm();
            
            if (shop != null)
            {
                lbShopName.Text = shop.NameShop;
                lbSlogan.Text = shop.Slogan;
                lbWifi.Text = "Wifi:"+shop.Wifi;
                lbWifiPassWord.Text = "Password:"+shop.PassWifi;
                lbAddress.Text = "Địa Chỉ:"+shop.ShopAddress;
                lbPhoneNumber.Text = "Mọi góp ý xin vui lòng liên hệ :" + shop.PhoneNumber;
            }
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
            double rate=DiscountDAO.Instance.GetDiscount(money);
            if (rate != -1) { lbCode.Text = "Giữ Hoá Đơn Để được giảm giá vào lần sau: " + DiscountDAO.Instance.CreateCode(rate); }
            else
            {
                lbCode.Visible=false;
            }    
            
            lbMoneyBack.Text = ChangeMoneytoString((money - bill.TotalPrice));
        }

        #region print
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, -6, -30);
        }

        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Bill", this.Size.Width-7, this.Size.Height-35);
            printPreviewDialog1.ShowDialog();
        }
        #endregion
        private string ChangeMoneytoString(int money)
        {
            string befdot = (money / 1000).ToString();
            string aftdot = (money - (money / 1000) * 1000).ToString();
            while(aftdot.Length<3)
            {
                aftdot += "0";
            }
            return (befdot + "." + aftdot);
        }

        private void flpTotal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
