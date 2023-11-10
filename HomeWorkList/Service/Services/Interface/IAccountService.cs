using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IAccountService
    {
        public List<Account> GetAll();
        public bool Login(string username, string password);
    }
}
