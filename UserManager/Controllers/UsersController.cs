using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManager.Logic.DTOs.Users;
using UserManager.Logic.Interfaces;
using UserManager.Repository.Models;
using UserManager.Repository.Users;
using AutoMapper;
using UserManager.Logic.DTOs.Users;
using UserManager.Repository.Models;


namespace UserManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper _mapper;
        public UsersController(IUserService userService, IMapper mapper)

        {
            this.userService = userService;
            _mapper = mapper;
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
            var user = userService.GetUser(id);
            return user;
        }

        [HttpPost]
        [Route("AddUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] 
        public IActionResult AddUser(AddUser userDto)
        {
             try
            {
                if (userDto == null)
                {
                    return BadRequest("User data is null.");
                }

                // Use AutoMapper to map AddUser DTO to Users entity
                var dbUser = _mapper.Map<Users>(userDto);

                // Call the service to add the user
                userService.AddUser(dbUser);

                return Ok("User added successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

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
