using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkList.Controllers
{
    public class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();   
        }
        public void GetEmployeeBySalary()
        {
            int count = 0;
            DateTime start = new(1999, 01, 01);
            DateTime end = new(2005, 01, 01);

            var res = _employeeService.GetBirthday(start , end);

            foreach (var item in res)
            {
                if( item.Salary > 200)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }


    }
}
