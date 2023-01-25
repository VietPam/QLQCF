using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLQCFTest.DTO
{
    internal class Shop
    {
        public Shop(string nameShop, string wifi, string passwifi, int numberTable, string slogan, string encouragement, string shopAddress, string phoneNumber, string goodByeSentence)
        {

            this.NameShop = nameShop;
            this.Wifi = wifi;
            this.PassWifi = passwifi;
            this.NumberTable = numberTable;
            this.Slogan = slogan;
            this.Encouragement = encouragement;
            this.ShopAddress = shopAddress;
            this.PhoneNumber = phoneNumber;
            this.GoodByeSentence = goodByeSentence;

        }
        public Shop(DataRow row)
        {

            this.NameShop = (string)row["NameShop"];
            this.Wifi = (string)row["Wifi"];
            this.PassWifi = (string)row["PassWifi"];
            this.NumberTable = (int)row["NumberTable"];
            this.Slogan = (string)row["Slogan"];
            this.Encouragement = (string)row["Encouragement"];
            this.ShopAddress = (string)row["ShopAddress"];
            this.PhoneNumber = (string)row["PhoneNumber"];
            this.GoodByeSentence = (string)row["GoodByeSentence"];
            this.SurCharge = (int)row["SurCharge"];
            this.vipCost = (int)row["VipCost"];
        }

        public string NameShop { get => nameShop; set => nameShop = value; }
        public string Wifi { get => wifi; set => wifi = value; }
        public string PassWifi { get => passWifi; set => passWifi = value; }
        public int NumberTable { get => numberTable; set => numberTable = value; }
        public string Slogan { get => slogan; set => slogan = value; }
        public string Encouragement { get => encouragement; set => encouragement = value; }
        public string ShopAddress { get => shopAddress; set => shopAddress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string GoodByeSentence { get => goodByeSentence; set => goodByeSentence = value; }      
        public int SurCharge { get => surCharge; set => surCharge = value; }
        public int VipCost { get => vipCost; set => vipCost = value; }

        private string nameShop;
        private string wifi;
        private string passWifi;
        private int numberTable;
        private string slogan;
        private string encouragement;
        private string shopAddress;
        private string phoneNumber;
        private string goodByeSentence;
        private int vipCost;
        private int surCharge;
    }
}
