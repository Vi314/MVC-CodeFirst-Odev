using MVC_Layout.Models.Data;
using MVC_Layout.Models.Entity;
using MVC_Layout.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Layout.Models.Service
{
    public class AccountService : IAccount
    {
        DatabaseContext db = new DatabaseContext();

        public bool Authenticate(string username, string password)
        {
            try
            {
                var acc = db.Accounts.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                if (acc != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public string CreateAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return "Hesap Oluşturuldu!";
            }
            catch (System.Exception)
            {
                return "Hesap Oluşturulamadı!";
            }

        }

        public string DeleteAccount(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Account> GetAccounts()
        {
           return db.Accounts.ToList();
        }

        public string UpdateAccount(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}
