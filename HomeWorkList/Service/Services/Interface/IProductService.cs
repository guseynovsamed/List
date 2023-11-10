using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public List<Product> GetBySearchText(string name);

    }
}
