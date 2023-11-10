using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IEmployeeService
    {
        public List<Employee> GetAll();
        public List<Employee> GetBirthday(DateTime startDate, DateTime endDate);

    }
}
