using UserDomain.Contracts.Data;
using UserDomain.Contracts.Data.Repositories;
using UserDomain.Core.Data.Repositories;
using UserDomain.Migrations;

namespace UserDomain.Core.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IItemRepository Items => new ItemRepository(_context);

        public IUserRepository Users => new UserRepository(_context);

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}