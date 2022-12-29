using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCFTest.DTO
{
    internal class DiscountCode
    {
        public DiscountCode() { }
        public DiscountCode(DataRow row) 
        {
            this.Code = (string)row["Code"];
            this.Rate = (double)row["Rate"];
            this.Number = (int)row["Number"];
        }
        private string code;
        private double rate;
        private int number;

        public string Code { get => code; set => code = value; }
        public double Rate { get => rate; set => rate = value; }
        public int Number { get => number; set => number = value; }
    }
}
