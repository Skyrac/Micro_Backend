using Microsoft.EntityFrameworkCore;
using UserRepository.Models;

namespace UserRepository.Contexts
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) {

        }
    }
}