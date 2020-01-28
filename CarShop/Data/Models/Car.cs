using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Models
{
    public class Car
    {
        public int id { get; set; }

        public string name { get; set; }

        public string shortDescription { get; set; }

        public string longDescription { get; set; }

        public string image { get; set; }

        public ushort price { get; set; }

        public int available { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
