using RestaurantManagement.DAL;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    internal class LinQ
    {
        public LinQ() { }
        List<Food> foods = FoodDAO.GetAllFood();
        public List<Food> GetFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            foreach (Food food in foods)
            {
                if (food.Name.ToLower().Contains(name.ToLower()))
                {
                    list.Add(food);
                }
            }
            return list;
        }
    }
}
