using Microsoft.EntityFrameworkCore;
using PCHAT.Domain.Entities;
using PCHAT.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHAT.DataAccess.Repositories
{
    public class PChatRepository : IPChatRepository
    {
        protected readonly PChatContext _context;
        public PChatRepository(PChatContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public async Task<bool> CompleteAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Message> GetMessage(string id)
        {
            return await _context.Messages.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Message>> GetMessagesForUser(string userId)
        {
            var messages = _context.Messages
            .Include(s => s.Sender).Include(s => s.Recipient).Where(x => x.RecipientId == userId).AsQueryable();

            return messages;
        }

        public Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId)
        {
            throw new NotImplementedException();
        }

        public List<User> Get(string userId)
        {
            var user =  _context.Users.Where(x => x.Id != userId).ToList();
           
            return user;
            
        }


        public async Task<IEnumerable<User>> GetUsers()
        {
          return _context.Users.AsEnumerable(); 
        }

        public User GetUser(string id)
        {
            var user = _context.Users.Where(x => x.Id == id).SingleOrDefault();

            return user;
        }
    }
}
