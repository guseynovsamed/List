using Praktiki.Models;
using Praktiki.Models.Data;
using Praktiki.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAll()
        {
            return AppDbContext.Persons();
        }

        public List<Person> GetAllByDescending()
        {
            return AppDbContext.Persons().OrderByDescending(x => x.Id).ToList();
        }

        public Person GetByID(int id)
        {
            return AppDbContext.Persons().FirstOrDefault(n => n.Id == id);
        }
    }
}
