using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Models.Data
{
    public static class AppDbContext
    {
        public static  List<Person> Persons()
        {
            return new List<Person>()
            {
                new Person {Name = "Semed" , Id = 1 , Surname = "Huseynov",Age=23},
                new Person {Name = "Eli" , Id = 2 , Surname = "Eliyev",Age=23},
                new Person {Name = "Veli" , Id = 3 , Surname = "Alili",Age=23},
                new Person {Name = "Anar" , Id = 4 , Surname = "Rustemli",Age=23}
            };
        }
    }
}
