using QLQCF.DAO;
using QLQCF.DTO;
using QLQCFTest.DAO;
using QLQCFTest.DTO;
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
        public fOrderFood(Table table, fTableManager ftableManager)
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
            cbFood.DataSource = foodList;
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

            int id = CategoryDAO.Instance.GetIdCateWithName(cbCategoryFood.Text);
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
            
            if (lsvHotFood.Items.Count == 0)
            {
                List<Food> foods = FoodDAO.Instance.GetListFoodHot();
                for (int i = 0; i < 15; i++)
                {
                    if (foods[i] != null)
                    {

                        ListViewItem listViewItem = new ListViewItem(foods[i].Name);
                        listViewItem.SubItems.Add(foods[i].TotalCount.ToString());
                        lsvHotFood.Items.Add(listViewItem);
                    }

                }
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            int count = (int)txbFoodCount.Value;

            if (count == 0) { }
            else
            {
                int loop = 0;
                string foodName = cbFood.Text;
                int idFood = FoodDAO.Instance.GetFoodwithName(foodName).Id;
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
                    if (bill == null)
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
            int count = (int)txbFoodCount.Value;

            if (count == 0) { }
            else
            {
                string foodName = cbFood.Text;
                int idFood = FoodDAO.Instance.GetFoodwithName(foodName).Id;
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
                    if (flag == lsvBill.Items.Count)
                    {
                        MessageBox.Show("Không Tìm Thấy Món Ăn Muốn Trừ");
                    }
                }
                BillInfoDAO.Instance.DeleteCountequal0(tabel);
                LoadBillInfo();
                if (lsvBill.Items.Count == 0)
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
            DialogResult ask;
            ask = MessageBox.Show("Bạn Có Muốn Huỷ Bill?", "Thông Báo Huỷ Bill!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                if (BillDAO.Instance.GetUnCheckBillwithtable(tabel) == null)
                {
                    MessageBox.Show("Chưa có Bill để huỷ");
                }
                else
                {
                    BillDAO.Instance.UpdateBilltoCancel(tabel);
                    MessageBox.Show("Huỷ Bill Thành Công!");
                    this.Close();
                }
                LoadBillInfo();
            }

        }

        private void txbFindFood_TextChanged(object sender, EventArgs e)
        {
            List<Food> foods = FoodDAO.Instance.FindListFood(txbFindFood.Text);
            if (foods != null)
            {
                cbFood.DataSource = foods;
                cbFood.DisplayMember = "Name";
            }
        }

        private void lsvHotFood_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            for (int i = 0; i < 15; i++)
            {
                if (lsvHotFood.Items[i].Checked == true)
                {
                    cbFood.Text = lsvHotFood.Items[i].Text;

                    if (FoodDAO.Instance.GetFoodwithName(cbFood.Text) == null)
                    { }
                    else
                    {
                        cbCategoryFood.Text = CategoryDAO.Instance.GetCateWithFood(FoodDAO.Instance.GetFoodwithName(cbFood.Text)).Name;
                    }
                    cbFood.Text= lsvHotFood.Items[i].Text;
                    lsvHotFood.Items[i].Checked = false;
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Rand();
            int b = Rand();
            int c = Rand();
            lbHot.ForeColor = Color.FromArgb(a, b, c, 1);

        }
        int Rand()
        {
            Random random = new Random();

            return (random.Next(255));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txbFindFood.Text != "")
            {
                string NameFood = cbFood.Text;
                Food food = FoodDAO.Instance.GetFoodwithName(NameFood);
                Category category = CategoryDAO.Instance.GetCateWithFood(food);
                if (category != null)
                {
                    cbCategoryFood.Text = category.Name;
                    cbFood.Text = food.Name;
                }
            }
        }

        private void cbPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
