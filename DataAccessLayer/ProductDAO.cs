using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void GenerateSampleDataset()
        {
            products.Add(new Product() { Id = 1, Name = "Coca", Quantity = 10, Price = 100 });
            products.Add(new Product() { Id = 2, Name = "Pepsi", Quantity = 30, Price = 70 });
            products.Add(new Product() { Id = 3, Name = "Sting", Quantity = 20, Price = 400 });
            products.Add(new Product() { Id = 4, Name = "RedBull", Quantity = 50, Price = 65 });
            products.Add(new Product() { Id = 5, Name = "Lavie", Quantity = 40, Price = 22 });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public bool SaveProduct(Product product)
        {
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old != null)
            
                return false;
                products.Add(product);
                return true;
            
        }
        
    }
}
