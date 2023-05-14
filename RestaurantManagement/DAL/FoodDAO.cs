using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement.DAL
{
    internal class FoodDAO
    {
        public static List<Food> GetAllFood()
        {
            List<Food> list = new List<Food>();
            string sql = "select * from Food where status = 1";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Food(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3])));
            }
            return list;
        }
        public static List<Food> GetFoodByCategory(int foodCategory)
        {
            List<Food> list = new List<Food>();
            string sql = "select * from Food where idCategory = @idCategory and status = 1";
            SqlParameter parameter1 = new SqlParameter("@idCategory", SqlDbType.Int);
            parameter1.Value = foodCategory;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Food(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToDouble(dr[3])));
            }
            return list;
        }
        public static void AddnewFood(string foodName, int foodCategory, double price)
        {
            string sql = "insert into Food values(@foodName, @foodCategory, @price)";
            SqlParameter parameter1 = new("@foodName", DbType.String);
            SqlParameter parameter2 = new("@foodCategory", DbType.Int32);
            SqlParameter parameter3 = new("@price", DbType.Double);
            parameter1.Value = foodName;
            parameter2.Value = foodCategory;
            parameter3.Value = price;
            DAO.InsertDataToSql(sql, parameter1, parameter2, parameter3);
        }
        public void DeleteFood(int idFood)
        {
            string sql = "update Food set status = 0 where id = @idFood";
            SqlParameter parameter1 = new("@idFood", DbType.Int32);
            parameter1.Value = idFood;
            DAO.UpdateDataToSql(sql, parameter1);
        }
        public void UpdateFood(int idFood, string foodName, int idCategory, double price)
        {
            string sql = "update Food set name = @foodName, idCategory = @idCategory, price = @price where id = @id";
            SqlParameter parameter1 = new("@foodName", SqlDbType.NVarChar);
            SqlParameter parameter2 = new("@idCategory", SqlDbType.Int);
            SqlParameter parameter3 = new("@price", SqlDbType.Float);
            SqlParameter parameter4 = new("@id", SqlDbType.Int);
            parameter1.Value = foodName;
            parameter2.Value = idCategory;
            parameter3.Value = price;
            parameter4.Value = idFood;
            DAO.UpdateDataToSql(sql, parameter1, parameter2, parameter3, parameter4);
        }
    }
}
