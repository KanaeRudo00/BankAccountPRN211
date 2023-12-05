using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessObject
{
    public class UserRepo : IUser
    {
        private readonly BankAccountTypeContext _context;
        public UserRepo(BankAccountTypeContext context)
        {
            _context = context;
        }

        public User Login(string userId, string password)
        {
            var item = _context.Users.FirstOrDefault(u => u.UserId == userId && u.Password == password && u.UserRole == 1);
            return item;
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public List<User> SearchUser(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Where(predicate).ToList();
        }
        public bool AddUser(User user)
        {
            if (SearchUser(u => u.UserId == user.UserId).FirstOrDefault() == null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateUser(User user)
        {
            User item = SearchUser(u => u.UserId == user.UserId).FirstOrDefault();
            if (item != null)
            {
                item.UserName = user.UserName;
                item.Password = user.Password;
                item.UserRole = user.UserRole;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool RemoveUser(string userId)
        {
            User item = SearchUser(u => u.UserId == userId).FirstOrDefault();
            if (item != null)
            {
                //Code
                return true;
            }
            return false;
        }
    }
}
