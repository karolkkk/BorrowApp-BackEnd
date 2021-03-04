using Borrow.Interfaces;
using Borrow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borrow
{
    public class DBService : IDbService
    {
        private readonly RepositoryContext _context;
        public DBService(RepositoryContext context)
        {
            _context = context;
        }

        public async Task AddUserToDb(User user) 
        {
            _context.Users.Add(user);
           await _context.SaveChangesAsync();
        }
        public User GetUserFromDb(string email) 
        {
            User userToBeReturned = _context.Users.Where(x => x.Email == email).Select(r => r).FirstOrDefault();
            return userToBeReturned;
        }
        public async Task DeleteUserFromDb(User user) 
        {
            _context.Users.Remove(user);
           await _context.SaveChangesAsync();
        }
    }
}
