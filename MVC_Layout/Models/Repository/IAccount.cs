using MVC_Layout.Models.Entity;
using System.Collections.Generic;

namespace MVC_Layout.Models.Repository
{
    public interface IAccount
    {
        List<Account> GetAccounts();
        string CreateAccount(Account account);
        string UpdateAccount(Account account);
        string DeleteAccount(int id);
        bool Authenticate(string username, string password);
    }
}
