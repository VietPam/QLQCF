using QLQCF.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace QLQCFTest.DAO
{
    internal class DiscountCodeDAO
    {
        private static DiscountCodeDAO instance;

        internal static DiscountCodeDAO Instance {get { if (instance == null) instance =new DiscountCodeDAO();
                return DiscountCodeDAO.instance;}
                set => instance = value; }
        private DiscountCodeDAO() { }

        public List<DiscountCode> GetListCode()
        {
            List<DiscountCode> ldiscountCode=new List<DiscountCode>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from DiscountCode");
            
                foreach(DataRow row in dataTable.Rows)
                {
                    DiscountCode dc= new DiscountCode(row);
                    ldiscountCode.Add(dc);
                }
                return ldiscountCode;
            
            
        }

        public bool AddCode(string code,string rate, int number)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DiscountCode where Code='" + code + "'");
            
            if (data.Rows.Count==0)
            {
               
                return DataProvider.Instance.ExecuteNonQuery("exec USP_InsertCode2 @code , @rate , @number ", new object[] { code, rate, number }) > 0;
            }
            else
            {               
                
                return false;
            }
            
        }
        public bool DeleteCode(string code)
        {
            return (DataProvider.Instance.ExecuteNonQuery("delete  from DiscountCode where Code = '" + code + "'")) > 0;
        }
        public bool EditCode(string code, string rate, int number)
        {
            return DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateCode @code , @rate , @number ", new object[] { code, rate, number }) > 0;
        }
        public void UpdateCode(string code)
        {
            DiscountCode dc = new DiscountCode(DataProvider.Instance.ExecuteQuery("select * from DiscountCode where Code='" + code + "'").Rows[0]);
            if (dc.Number == 1) {
                DeleteCode(code); 
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("update DiscountCode set Number=Number-1 where Code='" + code + "'");
            }
        }
    }
}
