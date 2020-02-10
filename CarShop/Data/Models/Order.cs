using System;
using System.Collections.Generic;

namespace CarShop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderList { get; set; }
    }
}
