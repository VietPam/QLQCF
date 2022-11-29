using QLQCF.DAO;
using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQCF
{
    public partial class fOrderFood : Form
    {
        private Table tabel;
        private fTableManager fManager;
        public fOrderFood(Table table,fTableManager ftableManager)
        {
            fManager = ftableManager;
            tabel = table;
            InitializeComponent();
            LoadCategoryFood();
            LoadBillInfo();
            LoadTableName();
        }

        private void LoadTableName()
        {
            lbTableName.Text = tabel.Name;
        }

        private void LoadFood(int id)
        {
            List<Food> foodList = FoodDAO.Instance.GetListFoodByCateID(id);
            cbFood.DataSource=foodList;
            cbFood.DisplayMember = "name";
        }

        private void LoadCategoryFood()
        {
            List<Category> categories = CategoryDAO.Instance.GetListCategory();
            cbCategoryFood.DataSource = categories;
            cbCategoryFood.DisplayMember = "name";
        }

        private void cbCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int id=CategoryDAO.Instance.GetIdCateWithName(cbCategoryFood.Text);
            if (id == -1)
            {
                int cateid = CategoryDAO.Instance.GetFirstCate().Id;
                LoadFood(cateid);
            }
            else
            {
                LoadFood(id);
            }
        }

        private void LoadBillInfo()
        {
            Bill test = BillDAO.Instance.GetUnCheckBillwithtable(tabel);
            lsvBill.Items.Clear();
            List<BillInfo> lBilInfo = BillInfoDAO.Instance.GetListBillInfoWithTable(tabel);
            if (lBilInfo == null)
            {

            }
            else
            {
                foreach (BillInfo billInfo in lBilInfo)
                {
                    if (billInfo.Count == 0)
                    { }
                    else
                    {
                        string foodName = FoodDAO.Instance.GetFoodByBillInfo(billInfo).Name;
                        ListViewItem listView = new ListViewItem(foodName);
                        listView.SubItems.Add(FoodDAO.Instance.GetPricewithName(foodName).ToString());
                        listView.SubItems.Add((billInfo.Count).ToString());

                        listView.SubItems.Add(((int)FoodDAO.Instance.GetPricewithName(foodName) * billInfo.Count).ToString());
                        lsvBill.Items.Add(listView);
                    }
                }
            }

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
           
            int count = (int)nmFoodCount.Value;
         
            if (count == 0) { }
            else
            {
                int loop = 0;
                string foodName = cbFood.Text;
                int idFood = FoodDAO.Instance.GetFoodIdwithName(foodName);
                for (int i = 0; i < lsvBill.Items.Count; i++)
                {
                    if (foodName == lsvBill.Items[i].Text)
                    {
                        BillInfoDAO.Instance.UpdateBillInfoifOrderSameFood(count, tabel, idFood);
                        loop++;
                    }
                    else
                    {

                    }
                }
                if (loop == 0)
                {
                    Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(tabel);
                    if(bill == null)
                    {
                        BillDAO.Instance.insertBill(tabel.Id);
                        bill = BillDAO.Instance.GetUnCheckBillwithtable(tabel);
                    }
                    BillInfoDAO.Instance.InsertBillInfo(bill.Id, idFood, count);
                }
            }

            LoadBillInfo();
        }

        private void fOrderFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lsvBill.Items.Count == 0)
            {
                BillDAO.Instance.UpdateBilltoCancel(tabel);

            }
        }

        private void btnSubtractFood_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int count = (int)nmFoodCount.Value;

            if (count == 0) { }
            else
            {
                string foodName = cbFood.Text;
                int idFood = FoodDAO.Instance.GetFoodIdwithName(foodName);
                if (lsvBill.Items.Count == 1 && lsvBill.Items[0].Text == foodName && count.ToString() == lsvBill.Items[0].SubItems[2].Text)
                {
                    MessageBox.Show("Nếu Muốn Huỷ Gọi Món vui Lòng Nhấn vào nút HUỶ BILL! XINCAMON");
                }
                else
                {
                    for (int i = 0; i < lsvBill.Items.Count; i++)
                    {
                        if (foodName == lsvBill.Items[i].Text)
                        {
                            BillInfoDAO.Instance.UpdateBillInfoifOrderSameFood(-count, tabel, idFood);
                        }
                        else
                        {
                            flag++;
                        }
                    }
                    if(flag==lsvBill.Items.Count)
                    {
                        MessageBox.Show("Không Tìm Thấy Món Ăn Muốn Trừ");
                    }    
                }
                BillInfoDAO.Instance.DeleteCountequal0(tabel);
                LoadBillInfo();
                if(lsvBill.Items.Count==0)
                {
                    BillDAO.Instance.UpdateBilltoCancel(tabel);
                }    
            }
        }

        private void fOrderFood_FormClosed(object sender, FormClosedEventArgs e)
        {
            fManager.LoadForm();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            if (BillDAO.Instance.GetUnCheckBillwithtable(tabel)==null)
            {
                MessageBox.Show("Chưa có Bill để huỷ");
            }
            else
            {
                BillDAO.Instance.UpdateBilltoCancel(tabel);
                MessageBox.Show("Huỷ Bill Thành Công!");

            }
            LoadBillInfo();
        }
    }
}
