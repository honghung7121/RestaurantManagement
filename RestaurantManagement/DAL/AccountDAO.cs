using Microsoft.VisualBasic.ApplicationServices;
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
    internal class AccountDAO
    {
        public Account CheckLogin(string userName, string password)
        {
            Account account;
            string sql = "select * from Account where userName = @userName and password = @password";
            SqlParameter parameter1 = new SqlParameter("@userName", DbType.String);
            SqlParameter parameter2 = new SqlParameter("@password", DbType.String);
            parameter1.Value = userName;
            parameter2.Value = password;
            DataTable dt = DAO.GetDataBySql(sql, parameter1, parameter2);
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                return account = new Account(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            return null;
        }
        public Account GetAccount(string userName)
        {
            Account account;
            string sql = "select * from Account where userName = @userName";
            SqlParameter parameter1 = new SqlParameter("@userName", DbType.String);
            parameter1.Value = userName;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                return account = new Account(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            return null;
        }
    }
}
