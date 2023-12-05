using BusinessObject.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObject
{
    public class AccountTypeRepo : IAccountType
    {
        private readonly BankAccountTypeContext _context;

        public AccountTypeRepo(BankAccountTypeContext context)
        {
            _context = context;
        }

        public AccountType GetAccountType(string id)
        {
            return _context.AccountTypes.FirstOrDefault(a => a.TypeId == id);
        }

        public bool AddAcountType(AccountType accountType)
        {
            if (_context.AccountTypes.FirstOrDefault(a => a.TypeId == accountType.TypeId) != null)
            {
                _context.AccountTypes.Add(accountType);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
        public List<AccountType> GetAccountTypes()
        {
            return _context.AccountTypes.ToList();
        }
    }
}
