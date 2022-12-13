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
        public Table(int id,string name,string status,int active, int type )
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Active = active;
            this.Type = type;
        }

        public Table(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.Name = row["Tên Bàn"].ToString();
            this.Status = row["Trạng Thái"].ToString();
            this.Active = (int)row["Active"];
            this.Type = (int)row["Type"];
        }
        private int id;
        private string name;
        private string status;
        private int active;
        private int type;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Active { get => active; set => active = value; }
        public int Type { get => type; set => type = value; }
    }

}
