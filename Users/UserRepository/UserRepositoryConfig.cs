using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserRepository.Contexts;
using UserRepository.Services;

namespace UserRepository
{
    public static class UserRepositoryConfig
    {
        public static void ConfigureRepository(IServiceCollection services, string connectionString) {
            services.AddDbContext<UserContext>(options => options.UseNpgsql(connectionString));
            services.AddTransient<UserRepositoryService>();
        }
    }
}