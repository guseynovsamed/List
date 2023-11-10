using Domain.Models;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product() { Name = "Iphone" , Count = 2 , Price = 2000 , Id = 1 },
                new Product() { Name = "Samsung" , Count = 21 , Price = 900 , Id = 2 },
                new Product() { Name = "Sony" , Count = 12 , Price = 1000 , Id = 3 },
                new Product() { Name = "Asus" , Count = 8 , Price = 2020 , Id = 4 },
                new Product() { Name = "Bosch" , Count = 0 , Price = 200 , Id = 5 },
            };
        }

        public List<Product> GetBySearchText(string text)
        {
            return GetAll().Where(x=>x.Name.Contains(text.ToLower().Trim())).ToList();
        }
    }
}
