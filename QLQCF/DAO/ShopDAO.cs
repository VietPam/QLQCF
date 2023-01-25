using QLQCF.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace QLQCFTest.DAO
{
    internal class ShopDAO
    {
        private static ShopDAO instance;

        internal static ShopDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShopDAO();
                return instance;
            }
            set => instance = value;
        }
        private ShopDAO() { }

        public Shop GetShop()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("Select * from Shop");
            if (dataTable.Rows.Count > 0) { return new Shop(dataTable.Rows[0]); }
            return null;
        }

        public bool SetShopProperties(string nameShop, string wifi, string passwifi, int numberTable, string slogan, string encouragement, string shopAddress, string phoneNumber, string goodByeSentence, int surcharge,int vipCost)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("USP_InsertShop @nameShop , @wifi , @passwifi , @numberTable , @slogan , @encouragement , @shopAddress , @phoneNumber , @goodByeSentence , @surcharge , @vipcost", new object[] { nameShop, wifi, passwifi, numberTable, slogan, encouragement, shopAddress, phoneNumber, goodByeSentence,surcharge,vipCost});

            ChangeTableNumber(numberTable);
            return true;
            return data > 0;
        }

        public void ChangeTableNumber(int numberTable)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from TableFood");
            int maxTableNumber = dataTable.Rows.Count;
            if (maxTableNumber == numberTable)
            {
               
            }
            else if (maxTableNumber > numberTable)
            {
                DataProvider.Instance.ExecuteNonQuery("update TableFood set Active=0 where ID_TableFood>" + numberTable);
                
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("USP_InsertTable @sl", new object[] { numberTable - maxTableNumber });
                
            }
            DataProvider.Instance.ExecuteNonQuery("update TableFood set Active=1 where ID_TableFood<=" + numberTable);
        }
    }
}
