using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    internal class FoodCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodCategory() { }
        public FoodCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public FoodCategory(string name)
        {
            Name = name;
        }
    }
}
