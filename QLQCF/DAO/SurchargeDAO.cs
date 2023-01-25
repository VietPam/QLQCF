
using QLQCF.DAO;
using QLQCFTest.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCFTest.DAO
{
    internal class SurchargeDAO
    {
        private static SurchargeDAO instance;

        internal static SurchargeDAO Instance {
            get
            {
                if (instance == null)
                    instance = new SurchargeDAO();
                return instance;
            }
            set => instance = value;
        }

        private SurchargeDAO() { }


        public Surcharge GetSurcharge()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("Select * from SurCharge");
            if (table.Rows.Count > 0)
            {
                return new Surcharge(table.Rows[0]);
            }
            return null;

        }
        public bool ChangeChoose(string choose)
        {
            int i1 = int.Parse(choose[0].ToString());
            int i2 = int.Parse(choose[1].ToString());
            int i3= int.Parse(choose[2].ToString());
            string query = string.Format("Update SurCharge set iHour={0},iDay={1},iDayofWeek={2}", i1, i2, i3);
            
            return DataProvider.Instance.ExecuteNonQuery(query)>0;
        }

        public bool ChangeHour(int timeStart,int timeEnd)
        {
            string query = string.Format("Update SurCharge set HourStart={0},HourEnd={1}", timeStart, timeEnd);

            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ChangeDay(DateTime timeStart,DateTime timeEnd)
        {

            return DataProvider.Instance.ExecuteNonQuery("exec USP_ChangeDay @datestart , @dateend ",new object[] {timeStart,timeEnd }) > 0;
        }
        public bool ChangeDateofWeek(string dateofweek)
        {
            return DataProvider.Instance.ExecuteNonQuery("Update SurCharge set DateofWeek='" + dateofweek + "'") > 0;
        }
    }
}
