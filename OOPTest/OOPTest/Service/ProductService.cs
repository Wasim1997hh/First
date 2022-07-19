using OOPTest.Models;
using System.Collections.Generic;

namespace OOPTest.Service
{
    public class ProductService
    {
        public List<Product> Products { get; set; }

        public ProductService()
        {
            Products  = new List<Product>();
        }
        public List<Product> GetAll()
        {
            return Products;
        }
        public List<Product> Create(string name , float price)
        {
            var product = new Product()
            {
                Id = 1,
                Name = name,
                Price = price
            };
            Products.Add(product);
            return Products;    
        }


    }
}
