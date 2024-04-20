using baitapbuoi9.bai3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai3
{
    public interface IProductManager
    {
        void BuyProduct(Product product, int quantity);
    }
}
