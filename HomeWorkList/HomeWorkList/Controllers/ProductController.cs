using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkList.Controllers
{
    public class ProductController
    {
        private IProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public void PrintAll()
        {

            var res  = _productService.GetAll();
            foreach (var item in res)
            {
                Console.WriteLine(item.Name+" "+item.Count+" "+item.Price);
            }
        }

        public void PrintBySearch()
        {
            Console.WriteLine("Enter search text");
            string text = Console.ReadLine();
            var res = _productService.GetBySearchText(text);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name + " " + item.Count + " " + item.Price);
            }
        }

    }
}
