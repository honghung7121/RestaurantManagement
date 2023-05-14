using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.DAL
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            string connectionStr = "server=(local);database=RestaurantManagement;user=sa;password=12345";
            return new SqlConnection(connectionStr);
        }
        public static DataTable GetDataBySql(String sql)
        {
            SqlConnection con = GetConnection();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public static DataTable GetDataBySql(String sql, params SqlParameter[] parameters)
        {
            SqlConnection con = GetConnection();
            SqlCommand command = new SqlCommand(sql, con);
            if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public static void InsertDataToSql(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, con);
                if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                con.Open();
                adapter.InsertCommand.ExecuteNonQuery();
            }
        }
        public static void UpdateDataToSql(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, con);
                if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                con.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
            }
        }
        public static void DeleteDataToSql(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, con);
                if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                con.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
            }
        }
    }
}
