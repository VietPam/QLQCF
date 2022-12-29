using QLQCF.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QLQCFTest.DAO
{
    internal class DiscountDAO
    {

        private static DiscountDAO instance;

        internal static DiscountDAO Instance {
            get { if (instance == null) instance = new DiscountDAO(); return DiscountDAO.instance; }
            set => instance = value;
        }
        public int LoadRateMoney(string rate)
        {
            return new Discount(DataProvider.Instance.ExecuteQuery("Select * from Discount where Rate=CONVERT(varchar(4),'" + rate+"')").Rows[0]).Money;
        }
        public string CreateRandCode()
        {
            string _allowedChars = "abcdefghijkmnopqrstuvwxyz0123456789ABCDEFGHIJKMNOPQRSTUVWXYZ";
            Random randNum = new Random();
            char[] chars = new char[10];
            int allowedCharCount = _allowedChars.Length;
            for (int i = 0; i < 10; i++) { chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())]; }
            return new string(chars);
        }

        public double GetDiscount(double money)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from Discount where Money<=" + money + "and Money>=0 order by Rate DESC");
            if (table.Rows.Count > 0)
            {
                return new Discount(table.Rows[0]).Rate;
            }
            return -1;
        }
        public string CreateCode(double rate)
        {
            string code = CreateRandCode();
            while (DataProvider.Instance.ExecuteQuery("select * from DiscountCode where Code ='" + code+"'").Rows.Count > 0)
            {
                code = CreateRandCode();
            }
            DataProvider.Instance.ExecuteNonQuery("USP_InsertCode @code , @rate ",new object[] {code,rate});
            return code;
        }
        public double GetRate(string code)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRate @code ", new object[] { code });
            if(data.Rows.Count == 0)
            {
                return -1;
                
            }
            return new Discount(data.Rows[0]).Rate;
        }
        
        public bool SetDiscount(string Rate,int money)
        {
            return DataProvider.Instance.ExecuteNonQuery("update Discount set Money=" + money+" where Rate = CONVERT(varchar(4), '" + Rate+"')") > 0;
        }

        
    }
}
