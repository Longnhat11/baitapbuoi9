using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai1.DTO
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double DiscountType { get; set; }        
        public double PriceAfterDiscount { get; set; }

        public double CalculateDiscount()
        {
            if (DiscountType == 1)
            {
                return Price*0.1;
            }
            else if (DiscountType == 2)
            {
                return Price * 0.05;
            }
            return 0;
        }
    }
}
