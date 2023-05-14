using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    internal class BillToShow
    {
        public string FoodName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public BillToShow() { }

        public BillToShow(string foodName, double price, int count, double total)
        {
            FoodName = foodName;
            Count = count;
            Price = price;
            Total = total;
        }
    }
}
