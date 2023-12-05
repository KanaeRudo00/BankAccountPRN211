using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessObject
{
    public class BankAccountRepo : IBankAccount
    {
        BankAccountTypeContext _context;

        public BankAccountRepo(BankAccountTypeContext context)
        {
            _context = context;
        }

        public List<BankAccount> GetAccounts(Expression<Func<BankAccount, bool>> dele)
        {
            return _context.BankAccounts.Include(u => u.Type).Where(dele).ToList();
        }

        public BankAccount GetAccount(string id)

        {
            return _context.BankAccounts.FirstOrDefault(a => a.AccountId == id);
        }

        public bool AddAccount(BankAccount bankAccount)
        {
            if (GetAccount(bankAccount.AccountId) == null)
            {
                _context.BankAccounts.Add(bankAccount);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateAccount(BankAccount bankAccount)
        {
            var item = _context.BankAccounts.FirstOrDefault(f => f.AccountId == bankAccount.AccountId);
            if (item != null)
            {
                item.AccountName = bankAccount.AccountName;
                item.BranchName = bankAccount.BranchName;
                item.OpenDate = bankAccount.OpenDate;
                item.TypeId = bankAccount.TypeId;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool RemoveAccount(string id)
        {
            BankAccount item = GetAccount(id);
            if (item != null)
            {
                _context.Remove(item);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
