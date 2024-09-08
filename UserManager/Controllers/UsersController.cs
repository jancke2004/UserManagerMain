using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManager.Logic.Interfaces;


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

        //[HttpGet]
        //[Route("GetUsers")]
        //public List<Users> GetUsers()
        //{
        //    return userContext.Users.ToList();
        //}
        //[HttpGet]
        //[Route("GetUser")]
        //public Users GetUser(int id)
        //{
        //    return (Users)userContext.Users.Where(x => x.Id == id).FirstOrDefault();
        //}

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
        //[HttpDelete]
        //[Route("DeleteUser")]
        //public string DeleteUser(Users user) 
        //{
        //    userContext.Users.Remove(user);
        //    userContext.SaveChanges();
        //    return "User deleted";
        //}

    }
}
