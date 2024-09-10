using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Logic.Interfaces;
using UserManager.Repository.Interfaces;
using UserManager.Repository.Models;
using UserManager.Repository.Users;


namespace UserManager.Logic.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void AddUser(UserManager.Repository.Models.Users users)
        {
           userRepository.AddUser(users);
          
        }

        public string DeleteUser(UserManager.Repository.Models.Users users)
        {
            userRepository.DeleteUser(users);
            return "User deleted";
        }

        public UserManager.Repository.Models.Users GetUser(int id)
        {
            userRepository.GetUser(id);
            return userRepository.GetUser(id);
            
        }

        public List<UserManager.Repository.Models.Users> GetUsers()
        {
            userRepository.GetUsers();
            return userRepository.GetUsers();
            
        }

        public string UpdateUser(UserManager.Repository.Models.Users users)
        {
            userRepository.UpdateUser(users);
            return "Updated Successfuly";
        }


    }
}
