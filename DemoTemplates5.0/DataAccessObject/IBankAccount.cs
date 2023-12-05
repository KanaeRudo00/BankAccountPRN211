using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessObject
{
    internal interface IBankAccount
    {
        public BankAccount GetAccount(string id);
        public List<BankAccount> GetAccounts(Expression<Func<BankAccount, bool>> predicate);
        public bool AddAccount(BankAccount user);
        public bool UpdateAccount(BankAccount user);
        public bool RemoveAccount(string userId);
    }
}
