using Domain.Models;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthorService : IAuthorService
    {
        public List<Author> GetAll()
        {
            return new List<Author>()
            {
                new Author { Name = "Hüseyn", Surname = "Cavid", Age = 42, Id = 1 },
                new Author { Name = "Uzeyir", Surname = "Hacibeyov", Age = 73, Id = 2 },
                new Author { Name = "Ehmed", Surname = "Cavad", Age = 32, Id = 3 },
                new Author { Name = "Sovket", Surname = "Elekberova", Age = 40, Id = 4 }
            };
        }

        public List<Author> GetByAge(int age)
        {
            return GetAll().Where(x=>x.Age>age).ToList();
        }
    }
}
