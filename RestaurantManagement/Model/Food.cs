using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    internal class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdFoodCategory { get; set; }
        public double Price { get; set; }

        public Food()
        {
        }

        public Food(int id, string name, int idFoodCategory, double price)
        {
            Id = id;
            Name = name;
            IdFoodCategory = idFoodCategory;
            Price = price;
        }
    }
}
