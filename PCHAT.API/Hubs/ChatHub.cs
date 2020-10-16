using Microsoft.AspNetCore.SignalR;
using PCHAT.API.Dtos;
using PCHAT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.API.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(MessageCreationDto msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
        }
    }
}
