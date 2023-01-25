using QLQCF.DTO;
using QLQCFTest.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance { 
            get{ if (instance == null) instance =new BillDAO();
                return BillDAO.instance;}
            set => instance = value; }

        private BillDAO() { }
        public void insertBill(int idtable)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { idtable });
        }

        public Bill GetUnCheckBillwithtable(Table table)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where ID_TableFood='" + table.Id.ToString() + "' and status='0'");
            if (data.Rows.Count == 0)
            {
                return null;
            }
            Bill bill = new Bill(data.Rows[0]);

            return bill;
        }
        public bool CheckEmpty(Table table)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where ID_TableFood='" +table.Id + "' and status ='0'");
            if (data.Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        public void UpdateBilltoCancel(Table table)
        {
            Bill bill = GetUnCheckBillwithtable(table);
            if(bill != null)
            {
                DataProvider.Instance.ExecuteNonQuery("update Bill set status='2' where ID_Bill='" + bill.Id + "'");
            }

        }
        public void UpdatePrice(Table table,Bill bill)
        {
            Shop shop = ShopDAO.Instance.GetShop();
            int totalPrice = 0;
            List<BillInfo> lbillInfo =BillInfoDAO.Instance.GetListBillInfoWithTable(table);
            foreach (BillInfo billInfo in lbillInfo)
            {
                Food food=FoodDAO.Instance.GetFoodByBillInfo(billInfo);
                totalPrice += (int)FoodDAO.Instance.GetPricewithName(food.Name)*billInfo.Count;
            }
            if (table.Type == 1)
            {
                totalPrice += shop.VipCost;
            }
            DataProvider.Instance.ExecuteNonQuery("update Bill set totalPrice='" + totalPrice + "' where ID_Bill='"+bill.Id+"'");
        }

        public void UpdatePriceAfterDiscount(Bill bill,int money)
        {
            DataProvider.Instance.ExecuteQuery("update Bill set totalPrice= "+money+" where ID_Bill="+bill.Id);    
        }

        public void SwitchTableBill(int idTable1, int idTable2)
        {
            DataTable data1 = DataProvider.Instance.ExecuteQuery("select *  from Bill where ID_TableFood='" + idTable1 + "'");
            DataTable data2 = DataProvider.Instance.ExecuteQuery("select *  from Bill where ID_TableFood='" + idTable2 + "'");
            if (data1.Rows.Count != 0 && data2.Rows.Count != 0)
            {
                DataProvider.Instance.ExecuteNonQuery("update Bill set ID_TableFood='" + idTable1 + "' where ID_TableFood='" + idTable2 + "'");
                foreach (DataRow row in data1.Rows)
                {
                    Bill bill = new Bill(row);
                    DataProvider.Instance.ExecuteNonQuery("update Bill set Id_TableFood='" + idTable2 + "' where ID_TableFood='" + idTable1 + "' and ID_Bill='" + bill.Id + "'");

                }
            }
            else if (data2.Rows.Count != 0 && data1.Rows.Count == 0)
            {
                DataProvider.Instance.ExecuteNonQuery("update Bill set ID_TableFood='" + idTable1 + "' where ID_TableFood='" + idTable2 + "'");

            }
            else if (data1.Rows.Count != 0 && data2.Rows.Count == 0)
            {
                DataProvider.Instance.ExecuteNonQuery("update Bill set ID_TableFood='" + idTable2 + "' where ID_TableFood='" + idTable1 + "'");

            }
            else
            {
                MessageBox.Show("Không thể chuyển bàn vì cả 2 bàn đều không có người");
            }
        }
        public void Mergetable(Table table1, Table table2)
        {
            List<BillInfo> lbillInfo = BillInfoDAO.Instance.GetListBillInfoWithTable(table2);
            Bill bill1=GetUnCheckBillwithtable(table1);
            foreach(BillInfo billInfo in lbillInfo)
            {
                DataProvider.Instance.ExecuteNonQuery("update BillInfo set ID_Bill='" + bill1.Id + "' where ID_BillInfo='" + billInfo.Id + "'");
            }
            UpdateBilltoCancel(table2);
            List<BillInfo> billInfoList = BillInfoDAO.Instance.GetListBillInfoWithTable(table1);
            
            for (int i = 0; i < billInfoList.Count - 1; i++) //truong hop 2 ban cung ten thuc an 
            {
                if (billInfoList[i + 1] != null)
                {
                    for (int j = i + 1; j < billInfoList.Count; j++)
                    {
                        if (billInfoList[i].IdFood == billInfoList[j].IdFood)
                        {
                            DataProvider.Instance.ExecuteNonQuery("update BillInfo set count=count+" + billInfoList[j].Count + " where ID_BillInfo='" + billInfoList[i].Id + "'");
                            DataProvider.Instance.ExecuteNonQuery("update BillInfo set count=0 where ID_BillInfo='" + billInfoList[j].Id + "'");
                        }
                    }
                }
            }
            DataProvider.Instance.ExecuteNonQuery("delete BillInfo where count='0'");
            MessageBox.Show("Gộp bàn thành công!");

        }

        public void UpdateBillChecked(Bill bill)
        {
            DataProvider.Instance.ExecuteNonQuery("update Bill set status ='1' ,DateCheckOut=GetDate() where ID_Bill='" + bill.Id + "'");
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

    }
}
