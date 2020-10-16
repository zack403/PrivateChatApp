using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.UI.Shared
{
    public class MessageDto
    {
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public DateTime MessageSent { get; set; }
        public string Content { get; set; }

        public MessageDto()
        {
            MessageSent = DateTime.Now;
        }
    }
}
