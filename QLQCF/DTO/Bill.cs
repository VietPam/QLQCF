using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DTO
{
    public class Bill
    {

        public Bill(int id,DateTime? dayIn,DateTime? dayOut,int idTable,int status,int discount,int totalPrice)
        {
            this.Id = id;
            this.DayCheckIn = dayIn;    
            this.DayCheckOut = dayOut;
            this.IdTable=idTable;
            this.Status = status;
            this.Discount = discount;
            this.TotalPrice = totalPrice;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["ID_Bill"];
            this.DayCheckIn = (DateTime?)row["DateCheckIn"];
            var DateCheckOutTemp = row["DateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.DayCheckOut = (DateTime?)DateCheckOutTemp;
            this.IdTable = (int)row["ID_TableFood"];
            this.Status = (int)row["status"];
            this.TotalPrice = (int)row["totalPrice"];
            this.Discount = (int)row["discount"];
           
            
        }
        private int discount;
        private int id;
        private DateTime? dayCheckIn;
        private DateTime? dayCheckOut;
        private int idTable;
        private int status;
        private int totalPrice;
        public int Id { get => id; set => id = value; }
        public DateTime? DayCheckIn { get => dayCheckIn; set => dayCheckIn = value; }
        public DateTime? DayCheckOut { get => dayCheckOut; set => dayCheckOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
