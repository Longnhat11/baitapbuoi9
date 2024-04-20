using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai1.DTO
{
    public abstract class ProductManager:baitapbuoi9.bai1.DTO.Product
    {
        public abstract void InputProductInfo();
        public abstract void DisplayProductByDiscountType(int discountType);
        public abstract void DisplayProductByDescendingDiscount();
        public abstract void SearchProductByName(string name);
    }
}
