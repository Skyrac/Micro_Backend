using UserDomain.Contracts.Data.Repositories;

namespace UserDomain.Contracts.Data
{
    public interface IUnitOfWork
    {
        IItemRepository Items { get; }
        IUserRepository Users { get; }
        Task CommitAsync();
    }
}