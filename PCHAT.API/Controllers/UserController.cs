using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCHAT.Domain.Interfaces;

namespace PCHAT.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPChatRepository _repo;
        
        public UserController(IPChatRepository repo)
        {
            _repo = repo;
        }

        public IActionResult GetUsers([FromQuery] string id)
        {
            var users = _repo.Get(id);
            if(users.Count > 0)
            {
                return Ok(users);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(string id)
        {
            var user = _repo.GetUser(id);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }
    }
}
