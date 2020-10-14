using PCHAT.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PCHAT.DataAccess.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly PChatContext _context;
        public UnitOfWorkRepository(PChatContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
