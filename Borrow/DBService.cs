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
        RepositoryContext _context;
        public DBService(RepositoryContext context)
        {
            _context = context;
        }

        public async Task AddUserToDb(User user) 
        {
            _context.Users.Add(user);
           await _context.SaveChangesAsync();
        }
    }
}
