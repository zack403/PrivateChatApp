using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.API.Dtos
{
    public class MessageToReturnDto
    {
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime MessageSent { get; set; }
    }
}
