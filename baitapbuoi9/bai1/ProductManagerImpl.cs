using baitapbuoi9.bai1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai1
{
    public class ProductManagerImpl : baitapbuoi9.bai1.DTO.ProductManager
    {
        
        List<Product> products = new List<Product>();
        public override void DisplayProductByDescendingDiscount()
        {
            var sortedProducts = products.OrderByDescending(p => p.CalculateDiscount());
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Tên: {product.Name}, Giá: {product.Price}, Chiết khấu: {product.Discount}, Giá sau chiết khấu: {product.PriceAfterDiscount}");
            }
        }

        public override void DisplayProductByDiscountType(int discountType)
        {
            if( discountType <0||discountType>3 ) {
                Console.WriteLine("loai chiet khau khong hop le");
                return;
            }
            var sortedProducts = products.OrderByDescending(p => p.CalculateDiscount());
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Tên: {product.Name}, Giá: {product.Price}, Chiết khấu: {product.Price-product.PriceAfterDiscount}, Giá sau chiết khấu: {product.PriceAfterDiscount}");
            }
        }

        public override void InputProductInfo()
        {
            // Tạo một sản phẩm mới và nhập thông tin
            bool check;
            Product product = new Product();
            Console.Write("Nhập tên sản phẩm: ");
            string tenSanPham;
            do
            {
                tenSanPham = Console.ReadLine();
                if (checkInput.CheckContainSpecialChar(tenSanPham) || checkInput.CheckIsNullOrWhiteSpace(tenSanPham) || checkInput.ContainsNumber(tenSanPham))
                    check = false;
                else check = true;
            } while (!check);
            product.Name = tenSanPham;
            Console.Write("Nhập giá sản phẩm: ");
            string giaSanPham;
            double Gia;
            do
            {
                Console.Write("Tổng Tiền Thanh Toán:");
                giaSanPham = Console.ReadLine();
                if (checkInput.CheckNumber(giaSanPham, out Gia))
                    check = true;
                else check = false;
            } while (!check);
            product.Price = Gia;
            string Loaichietkhau;
            double Type;
            Console.Write("Nhập loại chiết khấu (1 hoac 2): ");
            do {
                Console.WriteLine("1 cho giá tu 10000 đến 100000,2 cho giá từ 100000 trở lên, và 0 cho giá dưới 10000: ");
                Loaichietkhau = Console.ReadLine();
                if (checkInput.CheckNumber(Loaichietkhau, out Type))
                    check = true;
                else check = false;
                product.DiscountType = Type;
                if (product.DiscountType == 1 && product.Price >= 10000 && product.Price < 100000)
                {
                    product.PriceAfterDiscount = product.Price - product.CalculateDiscount();
                    check = true;
                }
                else
                if (product.DiscountType == 2 && product.Price >= 100000)
                {
                    product.PriceAfterDiscount = product.Price - product.CalculateDiscount();
                    check = true;
                }
                else check = false;
            } while (!check);
            product.Discount= product.CalculateDiscount();
            // Thêm sản phẩm vào danh sách
            products.Add(product);
        }

        public override void SearchProductByName(string name)
        {
            
            if (checkInput.CheckContainSpecialChar(name) || checkInput.CheckIsNullOrWhiteSpace(name) || checkInput.ContainsNumber(name))
            {
                Console.WriteLine("Tên không đúng định dạng!");
                return ;
            }      
            var foundProduct = products.FirstOrDefault(p => p.Name == name);
            if (foundProduct != null)
            {
                Console.WriteLine($"Tên: {foundProduct.Name}, Giá: {foundProduct.Price}, Chiết khấu: {foundProduct.Discount}, Giá sau chiết khấu: {foundProduct.PriceAfterDiscount}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm");
            }
        }
    }
}
