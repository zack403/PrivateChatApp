using System;
using System.Collections.Generic;
using System.Text;

namespace PCHAT.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string  Gender { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesRecieved { get; set; }
    }
}
