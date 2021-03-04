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
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDbService _dbService;
        public UserController(IDbService dbService) 
        {
            _dbService = dbService;
        }
        [HttpGet, Route("AddUser")]
        public async Task<IActionResult> AddUser(string firstname,string email)
        {
            User newUser = new User { FirstName = firstname, Email = email };
            await _dbService.AddUserToDb(newUser);
            return (Ok(newUser));
        }
        [HttpGet, Route("RemoveUser")]
        public async Task<IActionResult> RemoveUser(string email)
        {
            User userToBeDeleted = _dbService.GetUserFromDb(email);
            await _dbService.DeleteUserFromDb(userToBeDeleted);
            return (Ok(userToBeDeleted));
        }
        [HttpGet, Route("GetUser")]
        public IActionResult GetUser(string email)
        {
            
            User UserToBeReturned = _dbService.GetUserFromDb(email);
            return Ok(UserToBeReturned);
        }
    }
}
