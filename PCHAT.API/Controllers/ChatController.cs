using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PCHAT.API.Dtos;
using PCHAT.API.Hubs;

namespace PCHAT.API.Controllers
{
    [Route("api/chat")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatController(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("send")]
        [HttpPost]
        public IActionResult SendRequest([FromBody] MessageCreationDto msg)
        {
            _hubContext.Clients.All.SendAsync("MessageReceived", msg);
            return Ok();
        }
    }
}
