using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccessObject
{
    internal interface IAccountType
    {
        public List<AccountType> GetAccountTypes();
        public bool AddAcountType(AccountType accountType);
        public AccountType GetAccountType(string id);



    }
}
