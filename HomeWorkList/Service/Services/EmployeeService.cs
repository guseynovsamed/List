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
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> GetAll()
        {
            return new List<Employee>()
            {
                new Employee { Id = 1, Name= "Aqsin", Surname = "Veliyev" , Salary = 2300 , Birthday = new(1998 , 01 ,01) },
                new Employee { Id = 2, Name= "Ilham", Surname = "Abasli" , Salary = 1900 , Birthday = new(1999 , 01 ,01) },
                new Employee { Id = 3, Name= "Arzu", Surname = "Kerimova" , Salary = 2000 , Birthday = new(2001 , 01 ,01) },
                new Employee { Id = 4, Name= "Oruc", Surname = "Mehrabli" , Salary = 2100 , Birthday = new(1997 , 01 ,01) },
            };
        }
        public List<Employee> GetBirthday(DateTime startDate , DateTime endDate)
        {
            return GetAll().Where(x=>x.Birthday>startDate && endDate>x.Birthday).ToList();
        }
    }
}
