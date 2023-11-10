using Domain.Models;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkList.Controllers
{
    public class AuthorController
    {
        private readonly IAuthorService _authorService;

        public AuthorController()
        {
            _authorService = new AuthorService();
        }

        public void GetAuthor()
        {
           var res = _authorService.GetByAge(40);

            foreach (var item in res)
            {
                Console.WriteLine(item.Name +" "+item.Surname);
            }
            
        }

    }
}
