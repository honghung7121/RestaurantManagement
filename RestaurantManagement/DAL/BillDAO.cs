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
    internal class BillDAO
    {
        public static int CheckOutBillTableId(int tableID)
        {
            string sql = "select * from Bill where idTable = @tableID and status = 0";
            SqlParameter parameter1 = new SqlParameter("@tableID", SqlDbType.Int);
            parameter1.Value = tableID;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return Convert.ToInt32(dr[0]);
            }
            return -1;
        }
        public static void InsertNewBill(int tableID)
        {
            SqlConnection con = DAO.GetConnection();
            string sql = "exec USP_InsertBill @idTable";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.Add("@idTable", SqlDbType.Int).Value = tableID;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            string sql2 = "update [Table] set status = 1 where id = @idTable";
            SqlParameter parameter3 = new SqlParameter("@idTable", SqlDbType.Int);
            parameter3.Value = tableID;
            DAO.UpdateDataToSql(sql2, parameter3);
        }
        public static int GetMaxIdBill()
        {
            SqlConnection con = DAO.GetConnection();
            string sql = "select MAX(id) from Bill";
            SqlCommand command = new SqlCommand(sql, con);
            con.Open();
            int result = (int)command.ExecuteScalar();
            con.Close();
            return result;
        }
        public static void CheckOutBill(int idBill, int idTable)
        {
            string sql1 = "update Bill set status = 1, dateCheckOut = @dateCheckOut where id = @idBill " +
                           "update [Table] set status = 0 where id = @idTable";
            SqlParameter parameter1 = new SqlParameter("@dateCheckOut", SqlDbType.Date);
            SqlParameter parameter2 = new SqlParameter("@idBill", SqlDbType.Int);
            SqlParameter parameter3 = new SqlParameter("@idTable", SqlDbType.Int);
            parameter1.Value = DateTime.Today;
            parameter2.Value = idBill;
            parameter3.Value = idTable;
            DAO.UpdateDataToSql(sql1, parameter1, parameter2, parameter3);
        }
        public static void SwapTable(int idBill, int idTable, int idNewTable)
        {
            string sql1 = "update Bill set idTable = @idNewTable where id = @idBill";
            SqlParameter parameter1 = new SqlParameter("@idNewTable", SqlDbType.Int);
            SqlParameter parameter2 = new SqlParameter("@idBill", SqlDbType.Int);
            parameter1.Value = idNewTable;
            parameter2.Value = idBill;
            DAO.UpdateDataToSql(sql1, parameter1, parameter2);
            string sql2 = "update [Table] set status = 0 where id = @idTable";
            SqlParameter parameter3 = new SqlParameter("@idTable", SqlDbType.Int);
            parameter3.Value = idTable;
            DAO.UpdateDataToSql(sql2, parameter3);
            string sql3 = "update [Table] set status = 1 where id = @idNewTable";
            SqlParameter parameter4 = new SqlParameter("@idNewTable", SqlDbType.Int);
            parameter4.Value = idNewTable;
            DAO.UpdateDataToSql(sql3, parameter4);
        }
    }
}
