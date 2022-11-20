using QLQCFTest.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DTO
{
    public class Account
    {
        public Account( string userName,string passWord,string displayName, int type,int active)
        {
            this.UserName = userName;
            this.PassWord = passWord;   
            this.DisplayName = displayName;
            this.Type = type;
            this.Active = active;
        }

        public Account(DataRow row)
        {
            this.UserName = (string)row["UserName"];
            this.PassWord = (string)row["PassWord"];
            this.DisplayName = (string)row["DisplayName"];
            this.Type = (int)row["Type"];
            this.Active = (int)row["Active"];
      
        }
        private string userName;
        public string UserName { get => userName; set => userName = value; }

        private string displayName;
        public string DisplayName { get => displayName; set => displayName = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private int type;
        public int Type { get => type; set => type = value; }

        private int active;
        public int Active { get => active; set => active = value; }



    }
}
