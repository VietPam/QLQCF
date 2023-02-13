using System;
using QLQCF.DAO;
using QLQCF.DTO;
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
    public partial class fSwitchTable : Form
    {
        Table tabel;
        fTableManager ftableManager;
        public fSwitchTable(Table table,fTableManager fManager)
        {
            ftableManager = fManager;
            tabel = table;
            InitializeComponent();
            LoadFSwitchTable();
        }

        
        private void LoadFSwitchTable()
        {
            lbTableName.Text = tabel.Name;
            List<Table> tables = TableDAO.Instance.LoadTableListExcept(tabel.Id);
            cbListTableCanSwitch.DataSource = tables;
            cbListTableCanSwitch.DisplayMember = "name";
        }
        
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            
            string nameTableChangTo=cbListTableCanSwitch.Text;
            Table tableChangeTo = TableDAO.Instance.GetTableWithName(nameTableChangTo);
            if (BillDAO.Instance.CheckEmpty(tabel) && BillDAO.Instance.CheckEmpty(tableChangeTo))
            {
                MessageBox.Show("Không thể chuyển bàn vì cả 2 bàn đều không có người");
            }
            else
            {
                BillDAO.Instance.SwitchTableBill(tabel.Id, tableChangeTo.Id);
                MessageBox.Show("Chuyển bàn thành công!");
                this.Hide();
                ftableManager.LoadForm();
            }
            
        }

        private void fSwitchTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            ftableManager.LoadForm();
        }
    }
}
