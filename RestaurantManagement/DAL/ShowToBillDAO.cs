using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DAL
{
    internal class ShowToBillDAO
    {
        public static List<BillToShow> ShowBill(int tableID)
        {
            List<BillToShow> list = new List<BillToShow>();
            string sql = "select f.name, f.price, bii.count, f.price * bii.count as Total " +
                "from Food as f, Bill as bi, BillInfo as bii " +
                "where bi.idTable = @idTable and bi.status = 0 and bii.idBill = bi.id and bii.idFood = f.id";
            SqlParameter parameter1 = new SqlParameter("@idTable", DbType.Int32);
            parameter1.Value = tableID;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new BillToShow(dr[0].ToString(), Convert.ToDouble(dr[1]), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3])));
            }
            return list;
        }
    }
}
