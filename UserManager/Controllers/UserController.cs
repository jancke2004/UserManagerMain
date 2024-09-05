using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManager.Services;

namespace UserManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task AddUser()
        {
            await _user.AddUser();
        }
    }
}
