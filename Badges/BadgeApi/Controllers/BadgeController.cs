using Microsoft.AspNetCore.Mvc;
using BadgeContract;

namespace BadgeApi.Controllers;

[ApiController]
[Route("/badge")]
public class BadgeController : ControllerBase
{
    private static List<BadgeDto> badges = new() {
        new BadgeDto("Test", 5, 15, 5, 15, 5, 4)
    };

    private readonly ILogger<BadgeController> _logger;

    public BadgeController(ILogger<BadgeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public ActionResult<List<BadgeDto>> Get()
    {
        return Ok(badges);
    }
}
