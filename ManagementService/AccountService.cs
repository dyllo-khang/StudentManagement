using BusinessObject.Models;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public bool AddAccount(Account account) => _accountRepository.AddAccount(account);

        public Account GetAccount(string email, string passWord)
        {
            Account account = _accountRepository.GetAccountByEmail(email);
            if (account != null)
            {
                if (account.Password.Equals(passWord))
                {
                    return account;
                }
            }
            return null;
        }
        public List<Account> GetAll() => _accountRepository.GetAll();

    }
}
