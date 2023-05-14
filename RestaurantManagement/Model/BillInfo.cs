using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    internal class BillInfo
    {
        public int Id { get; set; }
        public int IdBill { get; set; }
        public int IdFood { get; set; }
        public int Count { get; set; }
        public BillInfo() { }
        public BillInfo(int id, int idBill, int idFood, int count)
        {
            Id = id;
            IdBill = idBill;
            IdFood = idFood;
            Count = count;
        }
    }
}
