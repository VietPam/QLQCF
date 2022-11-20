using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            set => instance = value;
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string passWordsecurity = "";
            foreach(byte b in hashData)
            {
                passWordsecurity += b.ToString();
            }
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWordsecurity });
            return result.Rows.Count > 0;
        }
        public Account LoadUser(string UserName)
        {       
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where UserName ='" + UserName + "'");
            if (data.Rows.Count > 0)
            {
                return new Account(data.Rows[0]);
            }
            return null;
        }
        public void ChangeDisplayName(Account acc,string newDisplayName)
        {
            DataProvider.Instance.ExecuteNonQuery("update Account set DisplayName='" + newDisplayName + "' where UserName='" + acc.UserName+"'");
            
        }
    }
}
