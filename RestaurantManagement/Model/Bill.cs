using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Model
{
    internal class Bill
    {
        public int Id { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int IdTable { get; set; }
        public bool Status { get; set; }
        public float Total { get;set; }

        public Bill()
        {
        }
        public Bill(int id, DateTime dateCheckIn, DateTime dateCheckOut, int idTable, bool status, float total)
        {
            Id = id;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            IdTable = idTable;
            Status = status;
            Total = total;
        }
        public Bill(int id, DateTime dateCheckIn, int idTable, bool status)
        {
            Id = id;
            DateCheckIn = dateCheckIn;
            IdTable = idTable;
            Status = status;
        }
    }
}
