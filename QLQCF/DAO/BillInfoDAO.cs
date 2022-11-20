using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DAO
{
    internal class BillInfoDAO
    {
        private static BillInfoDAO instance;

        internal static BillInfoDAO Instance {
            get { if (instance == null) instance = new BillInfoDAO();return BillInfoDAO.instance; }
            set => instance = value; }
        private BillInfoDAO() { }


        public void InsertBillInfo(int billId,int foodId,int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBillInfo , @idFood , @count", new object[] { billId, foodId, count });
        }
        public List<BillInfo> GetListBillInfoWithTable(Table table)
        {

            Bill bill = BillDAO.Instance.GetUnCheckBillwithtable(table);
            if (bill == null)
                return null;
            List<BillInfo> list = new List<BillInfo>();
            
                DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where ID_Bill='" + bill.Id.ToString() + "'");
                foreach(DataRow row in data.Rows)
                {
                    
                    BillInfo billinfo = new BillInfo(row); 
                   
                    list.Add(billinfo);
                }
            return list;
            
        }

        public void UpdateBillInfoifOrderSameFood(int count,Table table,int idFood)
        {
            BillInfo bill = GetBillInfowithTableIDandFoodID(idFood, table);
            if (count >= 0)
            {
                DataProvider.Instance.ExecuteNonQuery("update BillInfo set count=count+" + count.ToString() + " where ID_BillInfo='" + bill.Id + "'");
            }
            else
            {
                if(count+bill.Count >= 0)
                {
                    DataProvider.Instance.ExecuteNonQuery("update BillInfo set count=count+" + count.ToString() + " where ID_BillInfo='" + bill.Id + "'");
                }
                else 
                {
                    MessageBox.Show("Không thể trừ thêm!");
                }
                

            }
            
        }
        public BillInfo GetBillInfowithTableIDandFoodID(int idFood,Table table)
        {
            List<BillInfo> lBill=GetListBillInfoWithTable(table);
            foreach(BillInfo bill in lBill)
            {
                if(bill.IdFood==idFood)
                {
                    return bill;
                }
            }
            return null;
        }

        public void DeleteCountequal0(Table table)
        {
            List<BillInfo> lBillInfo = GetListBillInfoWithTable(table);
            if (lBillInfo!=null)
            {
                foreach (BillInfo billInfo in lBillInfo)
                {
                    if (billInfo.Count == 0)
                    {
                        DataProvider.Instance.ExecuteNonQuery("delete from BillInfo where ID_BillInfo='" + billInfo.Id + "'");
                    }
                }
            }
            { }

        }
    }
}
