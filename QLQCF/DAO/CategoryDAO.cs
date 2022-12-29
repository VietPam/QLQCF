using QLQCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQCF.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance;
            }
            set => instance = value;
        }
        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> Catelist = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where Active='1'");
            foreach (DataRow row in data.Rows)
            {
                Category cate = new Category(row);
                Catelist.Add(cate);
            }
            return Catelist;
        }
        public int GetIdCateWithName(string name)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where name=N'" + name + "' and Active='1'");
            if (data.Rows.Count > 0)
            {
                return new Category(data.Rows[0]).Id;
            }

            else return -1;
        }
        public Category GetFirstCate()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select min(ID_FoodCategory) from FoodCategory where Active='1'");
            DataTable dta = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where ID_FoodCategory='" + (int)data.Rows[0][0] + "' ");
            return new Category(dta.Rows[0]);
        }

        public Category GetCateWithFood(Food food)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from FoodCategory where ID_FoodCategory='" + food.IdCate + "' and Active='1'");
            if (data.Rows.Count > 0)
            {
                return new Category(data.Rows[0]);
            }
            return null;
        }

        //cua Dong
        public bool InsertCategory(string name)
        {
            string query = string.Format("Insert into dbo.FoodCategory(name,active) values (N'{0}', 1)", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(string name, int id)
        {
            string query = string.Format("update dbo.FoodCategory set name = N'{0}' where ID_FoodCategory = {1}", name, id.ToString());
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {

            string query = string.Format("update FoodCategory set Active=0 where ID_FoodCategory='" + id + "'");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
