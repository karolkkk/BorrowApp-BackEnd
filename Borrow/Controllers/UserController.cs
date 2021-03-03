using Borrow.Interfaces;
using Borrow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borrow.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IDbService _dbService;
        public UserController(IDbService dbService) 
        {
            _dbService = dbService;

        }
        [HttpGet]
        public async Task<IActionResult> AddUSer(string firstname,string email)
        {
            User newUser = new User { FirstName = firstname, Email = email };
            await _dbService.AddUserToDb(newUser);
            return (Ok(newUser));
        }
    }
}
