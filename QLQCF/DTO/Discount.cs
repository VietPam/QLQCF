using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCFTest.DTO
{
    internal class Discount
    {
        public Discount() { }
        public Discount(DataRow row) 
        {
            this.Rate = (double)row["Rate"];
            this.Money = (int)row["Money"];
        }
        private double rate;
        private int money;

        public double Rate { get => rate; set => rate = value; }
        public int Money { get => money; set => money = value; }
    }
}
