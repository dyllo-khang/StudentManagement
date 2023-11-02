using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private AccountDAO() { }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }

        public List<Account> GetAll()
        {
            using (var context = new StudentManagementContext())
            {
                return context.Accounts.ToList();
            }
        }

        public Account GetAccountByEmail(string email)
        {
            using (var context = new StudentManagementContext())
            {
                return context.Accounts.SingleOrDefault(m => m.Email.Equals(email));
            }
        }

        public bool AddAccount(Account account)
        {
            try
            {
                using (var context = new StudentManagementContext())
                {
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
