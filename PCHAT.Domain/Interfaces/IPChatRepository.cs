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
        Task<User> GetUser(string id);
        Task<Message> GetMessage(int id);
        Task<IEnumerable<Message>> GetMessagesForUser(int userId);
        Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId);
    }
}
