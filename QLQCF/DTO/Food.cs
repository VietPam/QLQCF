using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DTO
{
    public class Food
    {
        public Food(int id, string name, int idCate, float price, int active, int totalCount)
        {
            this.Id = id;
            this.Name = name;
            this.IdCate = idCate;
            this.Price = price;
            this.Active = active;
            this.TotalCount = totalCount;
        }
        public Food(DataRow row)
        {
            this.Id = (int)row["ID_Food"];
            this.Name = (string)row["NameFood"];
            this.IdCate = (int)row["ID_FoodCategory"];
            this.price = (float)Convert.ToDouble(row["Price"]);
            this.Active = (int)row["Active"];
            this.TotalCount = (int)row["TotalCount"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCate { get => idCate; set => idCate = value; }
        public float Price { get => price; set => price = value; }
        public int Active { get => active; set => active = value; }
        public int TotalCount { get => totalCount; set => totalCount = value; }

        private int id;

        private string name;

        private int idCate;

        private float price;

        private int active;
        private int totalCount;
    }
}
