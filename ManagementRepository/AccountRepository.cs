using BusinessObject.Models;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class AccountRepository : IAccountRepository
    {
        public bool AddAccount(Account account) => AccountDAO.Instance.AddAccount(account);

        public Account GetAccountByEmail(string email) => AccountDAO.Instance.GetAccountByEmail(email);
       

        public List<Account> GetAll() => AccountDAO.Instance.GetAll();
        
    }
}
