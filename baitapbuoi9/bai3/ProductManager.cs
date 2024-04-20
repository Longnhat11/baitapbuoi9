using baitapbuoi9.bai3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai3
{
    public class ProductManager : bai3.IProductManager
    {
        public void BuyProduct(Product product, int quantity)
        {
            if(quantity<=product.Quantity&&quantity>0){
                product.Quantity -= quantity;
                double discount = (quantity > 5) ? 0.05 : 0;
                double total = (product.Price * quantity) * (1 - discount);
                Console.WriteLine($"TÊN: {product.Name} | GIÁ: {product.Price} | SỐ LƯỢNG: {quantity} | ĐƠN GIÁ: {product.UnitPrice} | THÀNH TIỀN: {total} | CHIẾT KHẤU: {discount * 100}%");
            }
            else { Console.WriteLine("Số lượng mua không hợp lệ !"); }
        }
    }
}
