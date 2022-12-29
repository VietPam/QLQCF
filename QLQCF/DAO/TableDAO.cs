using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QLQCF.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            set => instance = value;
        }
        public static int TableWidth = 150;
        public static int TableHeight = 150;
        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec USP_LoadTableFood");
            foreach (DataRow row in data.Rows)
            {
                Table tableFood = new Table(row);
                tableList.Add(tableFood);
            }
            return tableList;
        }

        public void ChangeStatustoEmpty(Table table)
        {
            DataProvider.Instance.ExecuteNonQuery("update TableFood set StatusTable =N'Trống' where ID_TableFood='" + table.Id + "'");
        }
        public void ChangeStatustoUnEmpty(Table table)
        {
            DataProvider.Instance.ExecuteNonQuery("update TableFood set StatusTable =N'Có Người' where ID_TableFood='" + table.Id + "'");
        }
 

        public void CheckListTableStatus()
        {
            List<Table> tablelist = TableDAO.Instance.LoadTableList();
            foreach(Table table in tablelist)
            {
                if (BillDAO.Instance.CheckEmpty(table)) { 
                    ChangeStatustoEmpty(table);
                }
                else
                {
                    ChangeStatustoUnEmpty(table);
                }
            }
        }

        public List<Table> LoadTableListExcept(int idTable)
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select ID_TableFood as [ID], NameTable as [Tên Bàn], StatusTable as [Trạng Thái], Active, Type from TableFood where ID_TableFood !='"+idTable+ "' and Active='1'");
            foreach (DataRow row in data.Rows)
            {
                Table tableFood = new Table(row);
                tableList.Add(tableFood);
            }
            return tableList;
        }
        public Table GetTableWithName(string nameTable)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select ID_TableFood as [ID], NameTable as [Tên Bàn] ,StatusTable as [Trạng Thái],Active, Type from TableFood where NameTable='" + nameTable + "'");
            if(data.Rows.Count==0)
            {
                return null;
            }
            Table table = new Table(data.Rows[0]);
            return table;

        }

        public List<Table>  GetListTableUnEmptyandExceptChoose(Table table)
        {
            List<Table> tables = new List<Table>();
            tables=LoadTableListExcept(table.Id);
            List<Table> tablesresult = new List<Table>();
            foreach(Table table1 in tables)
            {
                if(BillDAO.Instance.CheckEmpty(table1)==true)
                {
                }
                else
                {
                    tablesresult.Add(table1);
                }
            }
            return tablesresult;
            
        }

        public bool ChangeTableProperty(int type,string Name,int ID)
        {
            
            
                return DataProvider.Instance.ExecuteNonQuery("update TableFood set Type=" + type + ", NameTable=' " + Name + "' where ID_TableFood=" + ID) > 0;
            
        }

        
    }
}
