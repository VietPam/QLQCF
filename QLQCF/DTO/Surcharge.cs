using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCFTest.DTO
{
    internal class Surcharge
    {
        public Surcharge() { } 
        public Surcharge(DataRow row) 
        {
            this.Hour = (int)row["iHour"];
            this.Day = (int)row["iDay"];
            this.DayofWeek = (int)row["iDayofWeek"];
            this.HourStart = (int)row["HourStart"];
            this.HourEnd = (int)row["HourEnd"];
            this.DayStart = (DateTime)row["DayStart"];
            this.DayEnd = (DateTime)row["DayEnd"];
            this.DateOfWeek = (string)row["DateofWeek"];
        }

        private int hour;
        private int day;
        private int dayofWeek;
        private int hourStart;
        private int hourEnd;
        private DateTime dayStart;
        private DateTime dayEnd;
        private string dateOfWeek;

        public int Hour { get => hour; set => hour = value; }
        public int Day { get => day; set => day = value; }
        public int DayofWeek { get => dayofWeek; set => dayofWeek = value; }
        public int HourStart { get => hourStart; set => hourStart = value; }
        public int HourEnd { get => hourEnd; set => hourEnd = value; }
        public DateTime DayStart { get => dayStart; set => dayStart = value; }
        public DateTime DayEnd { get => dayEnd; set => dayEnd = value; }
        public string DateOfWeek { get => dateOfWeek; set => dateOfWeek = value; }
    }
}
