using Microsoft.AspNetCore.Mvc;
using UserRepository.Models;

namespace BadgeApi.Controllers;

[ApiController]
[Route("/user")]
public class UserAuthController : ControllerBase
{
    private readonly ILogger<UserAuthController> _logger;
    private readonly UserRepository.Services.UserRepositoryService _userRepository;

    public UserAuthController(ILogger<UserAuthController> logger, UserRepository.Services.UserRepositoryService userRepository)
    {
        _logger = logger;
        _userRepository = userRepository;
    }

    [HttpGet("")]
    public async Task<List<UserModel>> Get()
    {
        var users = await _userRepository.GetUsers();
        return users;
    }
}
