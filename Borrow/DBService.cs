using Borrow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borrow
{
    public class DBService
    {
        RepositoryContext _context;
        DBService(RepositoryContext context)
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
