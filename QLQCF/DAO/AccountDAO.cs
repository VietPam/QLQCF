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

        private string hashPass(string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string passWordsecurity = "";
            foreach (byte b in hashData)
            {
                passWordsecurity += b.ToString();
            }
            return passWordsecurity;
        }
        public bool Login(string userName, string passWord)
        {
            string passWordsecurity = hashPass(passWord);
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

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select UserName, DisplayName, Type, Picture from Account");
        }

        public bool InsertAccount(string name, string displayname, int type)
        {
            string query = string.Format("INSERT dbo.Account (UserName, DisplayName, Type, PassWord, Active) VALUES ( N'{0}', N'{1}', {2}, N'{3}', 1)", name, displayname, type, "1962026656160185351301320480154111117132155");
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE FROM dbo.Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE dbo.Account SET PassWord = N'1962026656160185351301320480154111117132155' WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccountProfile(string userName, string displayName, string pass, string newpass)
        {
            string password = hashPass(pass);
            string newpassword=hashPass(newpass);
            int kq = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] {userName, displayName, password, newpassword });
            return kq > 0;
        }
    }
}
