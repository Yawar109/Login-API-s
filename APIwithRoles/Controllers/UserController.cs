using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIwithRoles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("you have accessed the admin controller");
        }
    }
}
