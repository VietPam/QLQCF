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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Markup;

namespace QLQCFTest
{
    public partial class fAdmin : Form
    {
        public Account acc;

        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource accountList = new BindingSource();

        public fAdmin()
        {
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
            LoadListFood();
            LoadListCatagory();
            LoadListAccount();
            AddFoodBinding();
            AddCategoryBinding();
            AddAccountBinding();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadDateTimePickerBill();
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCatagory();
        }

        void LoadListCatagory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryActive.DataBindings.Add(new Binding("text", dtgvCategory.DataSource, "active", true, DataSourceUpdateMode.Never));
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

        void LoadDateTimePickerBill ()
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
    }
}
