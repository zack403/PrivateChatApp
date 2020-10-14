using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.API.Dtos
{
    public class MessageToReturnDto
    {
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime MessageSent { get; set; }
    }
}
