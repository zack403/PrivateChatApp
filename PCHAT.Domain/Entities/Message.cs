using System;
using System.Collections.Generic;
using System.Text;

namespace PCHAT.Domain.Entities
{
    public class Message
    {
        public string Id { get; set; }
        public string SenderId { get; set; }
        public User Sender { get; set; }
        public int RecipientId { get; set; }
        public User Recipient { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
    }
}
