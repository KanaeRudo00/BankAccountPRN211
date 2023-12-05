using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessObject
{
    public interface IUser
    {
        public User Login(string username, string password);
        public List<User> GetUsers();
        public List<User> SearchUser(Expression<Func<User, bool>> predicate);
        public bool AddUser(User user);
        public bool UpdateUser(User user);
        public bool RemoveUser(string userId);

    }
}
