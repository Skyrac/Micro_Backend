using UserDomain.Contracts.Data.Entities;
using UserDomain.Contracts.Data.Repositories;
using UserDomain.Migrations;

namespace UserDomain.Core.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }
    }
}