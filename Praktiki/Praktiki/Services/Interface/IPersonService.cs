using Praktiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Services.Interface
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetByID(int id);
        List<Person> GetAllByDescending();

    }
}
