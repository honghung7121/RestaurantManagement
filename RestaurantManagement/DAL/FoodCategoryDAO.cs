using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement.DAL
{
    internal class FoodCategoryDAO
    {
        public static List<FoodCategory> GetAllFoodCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();
            string sql = "select * from FoodCategory";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new FoodCategory(Convert.ToInt32(dr[0]), dr[1].ToString()));
            }
            return list;
        }
        public static string GetCategoryByID(int id)
        {
            string sql = "select name from FoodCategory where id = @idCategory";
            SqlParameter parameter1 = new SqlParameter("@idCategory", SqlDbType.Int);
            parameter1.Value = id;
            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            DataRow dr = dt.Rows[0];
            string foodCategory = dr[0].ToString();
            return foodCategory;
        }
    }
}
