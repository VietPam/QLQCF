using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DTO
{
    public class Table
    {
        public Table(int id,string name,string status,int active )
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Active = active;
        }

        public Table(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["Tên Bàn"].ToString();
            this.Status = row["Trạng Thái"].ToString();
            this.Active = (int)row["Active"];
        }
        private int id;

        public int Id { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string status;

        public string Status { get => status; set => status = value; }
        public int Active { get => active; set => active = value; }

        private int active;

    }

}
