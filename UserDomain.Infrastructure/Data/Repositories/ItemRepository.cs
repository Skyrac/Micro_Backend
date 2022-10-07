using UserDomain.Contracts.Data.Entities;
using UserDomain.Contracts.Data.Repositories;
using UserDomain.Migrations;

namespace UserDomain.Core.Data.Repositories
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(DatabaseContext context) : base(context)
        {
        }
    }
}