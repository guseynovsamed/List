using Service.Services.Interface;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkList.Controllers
{
    public class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public bool Login()
        {
            Console.WriteLine("Add Username");
            string username = Console.ReadLine();
            Console.WriteLine("Add Password");
            string password = Console.ReadLine();
            return _accountService.Login(username, password);
        }


    }
}
