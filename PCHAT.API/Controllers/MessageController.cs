using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PCHAT.API.Dtos;
using PCHAT.Domain.Interfaces;

namespace PCHAT.API.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IPChatRepository _repo;
        public MessageController(IPChatRepository repo)
        {
            _repo = repo;
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] MessageCreationDto request)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var created = _repo.cre

        //}
    }
}
