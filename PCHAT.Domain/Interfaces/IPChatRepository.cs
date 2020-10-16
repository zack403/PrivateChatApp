using PCHAT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PCHAT.Domain.Interfaces
{
    public interface IPChatRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> CompleteAsync();
        Task<IEnumerable<User>> GetUsers();
        List<User> Get(string id);
        Task<Message> GetMessage(string id);
        Task<IEnumerable<Message>> GetMessagesForUser(string userId);
        Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId);
        User GetUser(string id);
    }
}
