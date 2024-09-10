using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManager.Logic.Interfaces;
using UserManager.Repository.Models;
using UserManager.Repository.Users;


namespace UserManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("GetUsers")]
        public ActionResult<List<UserManager.Repository.Models.Users>> GetUsers(int pageNumber = 1, int pageSize = 5)
        {
            var users = userService.GetUsers(pageNumber, pageSize);
            return Ok(users);  
        }

        [HttpGet]
        [Route("GetUser")]
        public UserManager.Repository.Models.Users GetUser(int id)
        {
            userService.GetUser(id);
            return userService.GetUser(id);
        }

        [HttpPost]
        [Route("AddUser")]
        public string AddUser(UserManager.Repository.Models.Users users)
        {
            userService.AddUser(users);
            return "User added Successfully";

        }
        [HttpPut]
        [Route("UpdateUser")]
        public string UpdateUser(UserManager.Repository.Models.Users users)
        {
            userService.UpdateUser(users);
           return "User Updated";      
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public string DeleteUser(UserManager.Repository.Models.Users users)
        {
            userService.DeleteUser(users);
            return "User deleted";
        }

    }
}
