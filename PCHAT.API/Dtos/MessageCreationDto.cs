using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.API.Dtos
{
    public class MessageCreationDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime MessageSent { get; set; }
        public string Content { get; set; }

        public MessageCreationDto()
        {
            MessageSent = DateTime.Now;
        }
    }
}
