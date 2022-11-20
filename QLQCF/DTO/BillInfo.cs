using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DTO
{
    public class BillInfo
    {
        public BillInfo(int id,int idFood,int idBill,int count)
        {
            this.Id = id;
            this.IdFood = idFood;
            this.IdBill = idBill;
            this.Count=count;
        }
        public BillInfo(DataRow data)
        {
            this.Id = (int)data["ID_BillInfo"];
            this.IdFood = (int)data["ID_Food"];
            this.IdBill = (int)data["ID_Bill"];
            this.Count = (int)data["count"];
        }
        private int id;
        private int idFood;
        private int idBill;
        private int count;
        
        public int Id { get => id; set => id = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int Count { get => count; set => count = value; }
    }
}
