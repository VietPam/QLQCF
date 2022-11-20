using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DTO
{
    public class Category
    {
        public Category(int id, string name,int active)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }
        public Category(DataRow row)
        {
            this.id=(int)row["ID_FoodCategory"];
            this.Name=(string)row["name"];
            this.Active=(int)row["Active"];
        }

        private int id;
        public int Id { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private int active;
        public int Active { get => active; set => active = value; }
    }
}
