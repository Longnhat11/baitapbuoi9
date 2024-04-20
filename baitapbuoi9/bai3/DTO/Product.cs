using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai3.DTO
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public Product(string name, double price, int quantity, double unitPrice)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
