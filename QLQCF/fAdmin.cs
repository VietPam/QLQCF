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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace QLQCFTest
{
    public partial class fAdmin : Form
    {
        public Account acc;
        fTableManager ftableManager;

        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource codeList = new BindingSource();
        public fAdmin(fTableManager fTable)
        {
            ftableManager = fTable;
            InitializeComponent();
            Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Load()
        {
            dtgvCategory.DataSource = categoryList;
            dtgvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            dtgvCode.DataSource = codeList;

            LoadListFood();
            LoadListCatagory();
            LoadListAccount();
            LoadListCode();
            AddFoodBinding();
            AddCategoryBinding();
            AddAccountBinding();
            AddCodeBinding();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadDateTimePickerBill();
            LoadShopSetting();
            LoadTable();
            LoadSurcharge();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCatagory();
        }

        void LoadListCatagory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void LoadListCode()
        {
            codeList.DataSource = DiscountCodeDAO.Instance.GetListCode();
        }
        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryActive.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "active", true, DataSourceUpdateMode.Never));
        }
        void AddCodeBinding()
        {
            txbDCode.DataBindings.Add(new Binding("text", dtgvCode.DataSource, "Code", true, DataSourceUpdateMode.Never));
            cbbDRate.DataBindings.Add(new Binding("text", dtgvCode.DataSource, "Rate", true, DataSourceUpdateMode.Never));
            txbNumberCode.DataBindings.Add(new Binding("text", dtgvCode.DataSource, "Number", true, DataSourceUpdateMode.Never));
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "NameFood", true, DataSourceUpdateMode.Never));
            txbFoodID.DataBindings.Add(new Binding("text", dtgvFood.DataSource, "ID_Food", true, DataSourceUpdateMode.Never));
            cbFoodCategory.DataBindings.Add(new Binding("text", dtgvFood.DataSource, "ID_FoodCategory", true, DataSourceUpdateMode.Never));
            txbFoodPrice.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txbType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }


        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = Convert.ToInt32(cbFoodCategory.Text);
            float price = float.Parse(txbFoodPrice.Text);

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Thêm món thất bại!");
            }

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = Convert.ToInt32(cbFoodCategory.Text);
            float price = float.Parse(txbFoodPrice.Text);
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(name, categoryID, price, id))
            {
                MessageBox.Show("Sửa món thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Sửa món thất bại!");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Xóa món thất bại!");
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công!");
                LoadListCatagory();
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại!");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(name, id))
            {
                MessageBox.Show("Sửa danh mục thành công!");
                LoadListCatagory();
            }
            else
            {
                MessageBox.Show("Sửa danh mục thất bại!");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công!");
                LoadListCatagory();
            }
            else
            {
                MessageBox.Show("Xóa danh mục thất bại!");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = Convert.ToInt32(txbType.Text);

            if (AccountDAO.Instance.InsertAccount(name, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;

            if (this.acc.UserName.Equals(name))
            {
                MessageBox.Show("Không thể xóa chính bản thân!");
                return;
            }

            if (AccountDAO.Instance.DeleteAccount(name))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!");
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = Convert.ToInt32(txbType.Text);

            if (AccountDAO.Instance.UpdateAccount(name, displayName, type))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại!");
            }
        }

        private void btnResetPassWord_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            if (AccountDAO.Instance.ResetPassword(name))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
                LoadListAccount();
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
            }
        }

        void LoadDateTimePickerBill()
        {
            DateTime date = DateTime.Now;
            dtpkFromDate.Value = new DateTime(date.Year, date.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvTotalBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

            #region TinhTongDanhThu
            int tong = 0;
            int gia;
            for (int i = 0; i < dtgvTotalBill.Rows.Count - 1; i++)
            {
                gia = (int)(dtgvTotalBill.Rows[i].Cells[3].Value);
                tong += gia;
            }

            txbTotalBill.Text = tong.ToString();
            #endregion
        }

        private void btnTotalBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        public void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table tabel in tablelist)
            {

                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.BackColor = Color.White;
                if(tabel.Type== 0 ) { }
                else
                {
                    btn.BackColor = Color.Yellow;
                }
                btn.Text = tabel.Name + "\n" + tabel.Status;
                btn.Width = TableDAO.TableWidth;
                btn.Height = TableDAO.TableHeight;
                btn.Tag = tabel;
                flpTable.Controls.Add(btn);
                btn.Click += btn_CLick;
            }
        }

        void btn_CLick(object sender, EventArgs e)
        {

            Table tabel = (sender as System.Windows.Forms.Button).Tag as Table;
            lbTable.Tag = tabel;
            txbTableName.Text = tabel.Name;
            lbTable.Text = tabel.Name;
            if (tabel.Type == 0)
            {
                rdNormal.Checked = true;
            }
            else
            {
                rdVip.Checked = true;
            }

        }
        public void LoadShopSetting()
        {
            Shop shop = ShopDAO.Instance.GetShop();
            txbShopName.Text = shop.NameShop;
            txbWifi.Text = shop.Wifi;
            txbWifiPassword.Text = shop.PassWifi;
            txbTableNumber.Text = shop.NumberTable.ToString();
            txbSlogan.Text = shop.Slogan;
            txbEncouragement.Text = shop.Encouragement;
            txbByeText.Text = shop.GoodByeSentence;
            txbAddress.Text = shop.ShopAddress;
            txbPhoneNumber.Text = shop.PhoneNumber;
            txbSurcharge.Text = shop.SurCharge.ToString();
            txbVipCost.Text=shop.VipCost.ToString();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int money;
            bool flag1 = int.TryParse(txbMoneyDiscount.Text, out money);
            if (flag1 == true && (money == -1 || money > 0))
            {


                if (Convert.ToInt32(txbTableNumber.Text) <= 0 || int.TryParse(txbTableNumber.Text, out int value) == false)
                { MessageBox.Show("Số Lượng Bàn phải là số Nguyên >0"); }
                else
                {
                    if (txbPhoneNumber.Text.Length != 10 || int.TryParse(txbPhoneNumber.Text, out int values) == false)
                    {
                        MessageBox.Show("Số Điện Thoại Phải là 10 số");
                    }
                    else
                    {

                        bool flag = ShopDAO.Instance.SetShopProperties(txbShopName.Text, txbWifi.Text, txbWifiPassword.Text, Convert.ToInt32(txbTableNumber.Text), txbSlogan.Text, txbEncouragement.Text, txbAddress.Text, txbPhoneNumber.Text, txbByeText.Text, Convert.ToInt32(txbSurcharge.Text), Convert.ToInt32(txbVipCost.Text));
                        if (cbDiscount.Text == "0%")
                        {
                            cbDiscount.Tag = "0";
                        }
                        if (txbMoneyDiscount.Text != "")
                        {
                            bool flag2 = DiscountDAO.Instance.SetDiscount(cbDiscount.Tag.ToString(), Convert.ToInt32(txbMoneyDiscount.Text));
                        }
                        if (flag)
                        {
                            MessageBox.Show("Cài Đặt Thành Công!");

                            this.Close();

                        }
                        else { }
                    }
                }
            }
            else
            {
                MessageBox.Show("Số tiền bị sai!");
            }

        }
        public void btnRestore_Click(object sender, EventArgs e)
        {
            LoadShopSetting();
        }


        private void fSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            ftableManager.LoadForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lbTable.Tag == null)
            {

            }
            else
            {

                Table tabel = lbTable.Tag as Table;
                txbTableName.Text = tabel.Name;
                lbTable.Text = tabel.Name;
                if (tabel.Type == 0)
                {
                    rdNormal.Checked = true;
                }
                else
                {
                    rdVip.Checked = true;
                }
            }
            Shop shop = ShopDAO.Instance.GetShop();

        }

        private void buttDone_Click(object sender, EventArgs e)
        {

            if (lbTable.Tag == null)
            {
            }
            else
            {

                bool flag;
                if (rdNormal.Checked == true)
                {
                    flag = TableDAO.Instance.ChangeTableProperty(0, txbTableName.Text, (lbTable.Tag as Table).Id);
                }
                else
                {
                    flag = TableDAO.Instance.ChangeTableProperty(1, txbTableName.Text, (lbTable.Tag as Table).Id);
                }

                if (flag == false)
                    MessageBox.Show("Cập Nhật Không Thành Công!");
                else
                    MessageBox.Show("Cập Nhật Thành Công!");


            }
            LoadTable();

        }

        private void txbNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txbCanNotChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string flag = "0";
            switch (cbDiscount.Text)
            {
                case ("0%"):
                    flag = "0";
                    break;
                case ("5%"):
                    flag = "0.05";
                    break;
                case ("10%"):
                    flag = "0.1";
                    break;
                case ("15%"):
                    flag = "0.15";
                    break;
                case ("20%"):
                    flag = "0.2";
                    break;
                case ("25%"):
                    flag = "0.25";
                    break;
                case ("30%"):
                    flag = "0.3";
                    break;
                case ("35%"):
                    flag = "0.35";
                    break;
                case ("40%"):
                    flag = "0.4";
                    break;
                case ("45%"):
                    flag = "0.45";
                    break;
                case ("50%"):
                    flag = "0.5";
                    break;
            }
            cbDiscount.Tag = flag;
            txbMoneyDiscount.Text = DiscountDAO.Instance.LoadRateMoney(flag).ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        

        int ChangTimeToMin(int h, int m)
        {
            return h * 60 + m;
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            string Rate = GetRate();

            if (DiscountCodeDAO.Instance.AddCode(txbDCode.Text, Rate, Convert.ToInt32(txbNumberCode.Text)))
            {
                MessageBox.Show("Thêm Code Thành Công");
                LoadListCode();
            }
            else
            {
                MessageBox.Show("Thêm Code Thất Bại");
            }
        }

        private void btnDeleteCode_Click(object sender, EventArgs e)
        {
            if (DiscountCodeDAO.Instance.DeleteCode(txbDCode.Text))
            {
                MessageBox.Show("Xoá Code Thành Công");
                LoadListCode();
            }
            else
            {
                MessageBox.Show("Xoá Code Thất Bại");
            }
        }

        private void btnEditCode_Click(object sender, EventArgs e)
        {
            string Rate = GetRate();
            if (DiscountCodeDAO.Instance.EditCode(txbDCode.Text, Rate, Convert.ToInt32(txbNumberCode.Text)))
            {
                MessageBox.Show("Sửa Code Thành Công");
                LoadListCode();
            }
            else
            {
                MessageBox.Show("Sửa Code Thất Bại");
            }
        }
        private void btnShowCode_Click(object sender, EventArgs e)
        {
            LoadListCode();
        }
        string GetRate()
        {
            switch (cbbDRate.Text)
            {
                case ("0"):
                    return "0";
                case ("0,05"):
                    return "0.05";
                case ("0,1"):
                    return "0.1";
                case ("0,15"):
                    return "0.15";
                case ("0,20"):
                    return "0.2";
                case ("0,25"):
                    return "0.25";
                case ("0,3"):
                    return "0.3";
                case ("0,35"):
                    return "0.35";
                case ("0,4"):
                    return "0.4";
                case ("0,45"):
                    return "0.45";
                case ("0,5"):
                    return "0.5";
            }
            return "0.1";
        }


        private void cbbDRate_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        #region xuatFileExcel
        public void ExportFile(DataGridView data, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Tên bàn";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Ngày vào";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày ra";
            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tổng tiền";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");

            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo bảng
            for (int i = 1; i < data.Columns.Count + 1; i++)
            {
                oExcel.Cells[3, i] = data.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    if (data.Rows[i].Cells[j].Value != null)
                    {
                        oExcel.Cells[i + 5, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

        }

        private void btnToFile_Click(object sender, EventArgs e)
        {
            ExportFile(dtgvTotalBill, "DoanhSoBanRa", "QuanCaffe");
        }

        #endregion



        private void txbHour_KeyUp(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox txb = sender as System.Windows.Forms.TextBox;
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
            else { 
                string flag = txb.Text;
                if (!Char.IsControl(e.KeyChar))
                {
                    flag = "";
                    flag = txb.Text + e.KeyChar;
                }
                if (flag.Length > 2 || Convert.ToInt32(flag) > 23)
                {
                    
                        e.Handled= true;
                }
            }
        }

        private void txbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox txb = sender as System.Windows.Forms.TextBox;
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
            else
            {
                string flag = txb.Text;
                if (!Char.IsControl(e.KeyChar))
                {
                    flag = "";
                    flag = txb.Text + e.KeyChar;
                }
                if (flag.Length > 2 || Convert.ToInt32(flag) > 60)
                {

                    e.Handled = true;
                }
            }
        }
        private void LoadSurcharge()
        {
            Surcharge sur = SurchargeDAO.Instance.GetSurcharge();
            if( sur != null) {
                CheckSurcharge( sur );
                LoadHour(sur);
                LoadDay(sur);
                LoadDayofWeek(sur);
            }
        }

        private void CheckSurcharge(Surcharge sur)
        {
            if (sur.Hour == 1)
                cbHour.Checked = true;
            else
                cbHour.Checked = false;
        
            if (sur.Day == 1)
                cbDay.Checked = true;
            else
                cbDay.Checked = false;

            if(sur.DayofWeek==1)
                cbDayofWeek.Checked = true;
            else
                cbDayofWeek.Checked = false;
         }

        private void btnChooseSurCharge_Click(object sender, EventArgs e)
        {
            string flag = "";
            if (cbHour.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbDay.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbDayofWeek.Checked)
                flag += "1";
            else
                flag += "0";

            bool flag2 = SurchargeDAO.Instance.ChangeChoose(flag);
            if (flag2)
                MessageBox.Show("Cập Nhật Loại Phụ Thu Thành Công");
            else
                MessageBox.Show("Cập Nhật Loại Phụ Thu Không Thành Công");
        }

        private void LoadHour(Surcharge sur)
        {
            txbHour1.Text = ((int)(sur.HourStart / 60)).ToString();
            txbMin1.Text = ((int)(sur.HourStart % 60)).ToString();
            txbHour2.Text = ((int)(sur.HourEnd / 60)).ToString();
            txbMin2.Text = ((int)(sur.HourEnd % 60)).ToString();
        }

        private void btnHour_Click(object sender, EventArgs e)
        {
            int timeStart = ChangTimeToMin(Convert.ToInt32(txbHour1.Text), Convert.ToInt32(txbMin1.Text));
            int timeEnd = ChangTimeToMin(Convert.ToInt32(txbHour2.Text), Convert.ToInt32(txbMin2.Text));
            bool flag=SurchargeDAO.Instance.ChangeHour(timeStart, timeEnd);
            if(flag)
                MessageBox.Show("Cập Nhật Giờ Phụ Thu Thành Công");
            else
                MessageBox.Show("Cập Nhật Giờ Phụ Thu Không Thành Công");
        }

        private void LoadDay(Surcharge sur)
        {
            dtpFrom.Value = sur.DayStart;
            dtpTo.Value = sur.DayEnd;
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn hoặc bằng ngày kết thúc");

            }
            else
            {
                bool flag = SurchargeDAO.Instance.ChangeDay(dtpFrom.Value, dtpTo.Value);

                if (flag)
                    MessageBox.Show("Cập Nhật Ngày Phụ Thu Thành Công");
                else
                    MessageBox.Show("Cập Nhật Ngày Phụ Thu Không Thành Công");
            }
        }

        private void LoadDayofWeek(Surcharge sur)
        {
            if (Convert.ToInt32(sur.DateOfWeek[0].ToString()) == 1)
                cbMonday.Checked = true;
            else
                cbMonday.Checked = false;

            if (Convert.ToInt32(sur.DateOfWeek[1].ToString()) == 1)
                cbTuesday.Checked = true;
            else
                cbTuesday.Checked = false;

            if (Convert.ToInt32(sur.DateOfWeek[2].ToString()) == 1)
                cbWednesday.Checked = true;
            else
                cbWednesday.Checked = false;

            if (Convert.ToInt32(sur.DateOfWeek[3].ToString()) == 1)
                cbThursday.Checked = true;
            else
                cbThursday.Checked = false;

            if (Convert.ToInt32(sur.DateOfWeek[4].ToString()) == 1)
                cbFriday.Checked = true;
            else
                cbFriday.Checked = false;

            if (Convert.ToInt32(sur.DateOfWeek[5].ToString()) == 1)
                cbSaturday.Checked = true;
            else
                cbSaturday.Checked = false;

            if (Convert.ToInt32(sur.DateOfWeek[6].ToString()) == 1)
                cbSunday.Checked = true;
            else
                cbSunday.Checked = false;
        }

        private void btnDayofWeek_Click(object sender, EventArgs e)
        {
            string flag = "";
            if (cbMonday.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbTuesday.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbWednesday.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbThursday.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbFriday.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbSaturday.Checked)
                flag += "1";
            else
                flag += "0";
            if (cbSunday.Checked)
                flag += "1";
            else
                flag += "0";

            bool flag2 = SurchargeDAO.Instance.ChangeDateofWeek(flag);
            if (flag2)
                MessageBox.Show("Cập Nhật Thứ Phụ Thu Thành Công");
            else
                MessageBox.Show("Cập Nhật Thứ Phụ Thu Không Thành Công");
        }

        private void txbMin2_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}
