using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCHAT.API.Dtos;
using PCHAT.Domain.Entities;
using PCHAT.Domain.Interfaces;
using Microsoft.AspNetCore.SignalR;
using PCHAT.API.Hubs;

namespace PCHAT.API.Controllers
{
    [Route("api/message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IPChatRepository _repo;
        private readonly IHubContext<ChatHub> _chatHub;
        public MessageController(IPChatRepository repo, IHubContext<ChatHub> chatHub)
        {
            _repo = repo;
            _chatHub = chatHub;
        }

        [HttpPost]
        public  IActionResult Post([FromBody] MessageCreationDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var recipient = _repo.GetUser(request.RecipientId);
            var sender = _repo.GetUser(request.SenderId);

            if (recipient == null)
                return BadRequest($"Could not find user {request.RecipientId}");

            var message = JObject.FromObject(request, new JsonSerializer { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }).ToObject<Message>();
            message.Id = Guid.NewGuid().ToString();
            _repo.Add(message);

            _repo.CompleteAsync();

            _chatHub.Clients.User(message.RecipientId).SendAsync("MessageReceived", message);

            return Ok();


        }
    }
}
