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

        public static CategoryDAO Instance {
            get { if (instance == null) instance = new CategoryDAO();return CategoryDAO.instance;
            } set => instance = value; }
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
            string query = string.Format("delete dbo.FoodCategory where ID_FoodCategory = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
