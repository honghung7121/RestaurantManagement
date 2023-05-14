using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DAL
{
    internal class TableDAO
    {
        public static List<Table> loadTableList()
        {
            List<Table> list = new List<Table>();
            string sql = "select * from [Table]";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Table(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), Convert.ToBoolean(dr[2].ToString())));
            }
            return list;
        }
    }
}
