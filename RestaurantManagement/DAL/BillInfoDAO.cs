using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement.DAL
{
    internal class BillInfoDAO
    {
        public static List<BillInfo> getListBillInfo(int idBill)
        {
            List<BillInfo> list = new List<BillInfo>();
            string sql = "select * from BillInfo where idBill = @idBill";
            SqlParameter parameter1 = new SqlParameter("@idBill", DbType.Int32);
            parameter1.Value = idBill;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new BillInfo(Convert.ToInt32(dr[0]), Convert.ToInt32(dr[1]), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[3])));
            }
            return list;
        }
        public static void InsertNewBillInfo(int idBill, int idFood, int count)
        {
            SqlConnection con = DAO.GetConnection();
            string sql = "USP_InsertBillInfo @idBill, @idFood, @count";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add("@idBill", SqlDbType.Int).Value = idBill;
            command.Parameters.Add("@idFood", SqlDbType.Int).Value = idFood;
            command.Parameters.Add("@count", SqlDbType.Int).Value = count;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
