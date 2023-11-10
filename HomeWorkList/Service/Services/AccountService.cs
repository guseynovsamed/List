using Domain.Models;
using Service.Services.Interface;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public List<Account> GetAll()
        {
            return new List<Account>()
            {
                new Account() {Username = "SemedHusey" , Password = "12345S!" , Id = 1}
            };
        }
        public bool Login(string username , string password)
        {
             return GetAll().Exists(n=>n.Username==username && n.Password == password);
        }
    }
}
