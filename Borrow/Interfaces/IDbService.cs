using Borrow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borrow.Interfaces
{
    public interface IDbService
    {
        Task AddUserToDb(User user);
    }
}
