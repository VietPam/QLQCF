using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLQCF.DAO;
using QLQCF.DTO;

namespace QLQCF
{
   
    public partial class fMergeTable : Form
    {
        fTableManager ftableManager;
        Table table;
        public fMergeTable(Table tabel,fTableManager ftablemanager)
        {
            ftableManager = ftablemanager;
            table = tabel;
            InitializeComponent();
            LoadfMergeTable();

        }

        private void LoadfMergeTable()
        {
            cbTableResult.Items.Clear();
            lbNameTable.Text=table.Name;
            List<Table> lTable = TableDAO.Instance.GetListTableUnEmptyandExceptChoose(table);

                cbTableCanMerge.DataSource = lTable;
                cbTableCanMerge.DisplayMember = "name";
                cbTableResult.Items.Clear();
                cbTableResult.Items.Add(table);
                Table tablefirstchoose = lTable[0];
                cbTableResult.Items.Add(tablefirstchoose);
                cbTableResult.Tag = tablefirstchoose;
                cbTableResult.DisplayMember = "name";

            
        }


        private void btnMergeTable_Click(object sender, EventArgs e)
        {
            if(cbTableResult.Text=="")
            {
                MessageBox.Show("vui lòng chọn bàn muốn chuyển qua");
            }
            else
            {
                
                Table table1 = cbTableResult.Tag as Table;
                if (BillDAO.Instance.CheckEmpty(table) || BillDAO.Instance.CheckEmpty(table1))
                {
                    MessageBox.Show("1 trong 2 bàn không còn gì để gộp!");
                }
                else
                {
                    if (cbTableResult.Text == table.Name)
                    {
                        BillDAO.Instance.Mergetable(table, table1);
                    }
                    else
                    {
                        BillDAO.Instance.Mergetable(table1, table);
                    }
                    MessageBox.Show("Gộp bàn thành công!");
                    ftableManager.LoadForm();
                    this.Hide();
                    
                }
                
            }
        }

        private void cbTableCanMerge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TableDAO.Instance.GetTableWithName(cbTableCanMerge.Text) == null)
            { }
            else
            {
                cbTableResult.Items.Clear();
                cbTableResult.Items.Add(table);
                cbTableResult.Items.Add(TableDAO.Instance.GetTableWithName(cbTableCanMerge.Text));
                cbTableResult.DisplayMember = "name";
                cbTableResult.Tag=TableDAO.Instance.GetTableWithName(cbTableCanMerge.Text);
            }
        }

        private void fMergeTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            ftableManager.LoadForm();
        }
    }
}
