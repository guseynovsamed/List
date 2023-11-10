using Praktiki.Services;
using Praktiki.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Controllers
{
    public class PersonController
    {
        private readonly IPersonService _personService;
        public PersonController()
        {
            _personService = new PersonService();
        }
        public void GetAll()
        {
             var datas = _personService.GetAll();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Name +" "+data.Surname);
            }
        }

        public void GetById(int id)
        {
            var data = _personService.GetByID(2);
            Console.WriteLine(data.Name + " " + data.Surname);
        }

        public void Sorting()
        {
            var datas = _personService.GetAllByDescending();

            foreach(var data in datas)
            {
                Console.WriteLine(data.Name + " " + data.Surname);
            }
        }
    }
}
