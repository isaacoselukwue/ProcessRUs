using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProcessRUs.Controllers;

[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,BackOffice")]
[Route("api/[controller]")]
[ApiController]
public class AccessController : ControllerBase
{
    [HttpGet("getfruits")]
    public IActionResult Get()
    {
        var fruits = new[] { "Apple", "Banana", "Mango", "Papaya", "Pear" };
        return Ok(fruits);
    }
}

