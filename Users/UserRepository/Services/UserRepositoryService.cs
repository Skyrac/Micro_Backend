using Microsoft.EntityFrameworkCore;
using UserRepository.Contexts;
using UserRepository.Models;

namespace UserRepository.Services
{
    public class UserRepositoryService
    {
        private readonly UserContext _userContext;

        public UserRepositoryService(UserContext userContext) {
            _userContext = userContext;
        }

        public async Task<List<UserModel>> GetUsers() {
            return await _userContext.users.ToListAsync();
        }
    }
}