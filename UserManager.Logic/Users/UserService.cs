using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Logic.Interfaces;
using UserManager.Repository.Interfaces;
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

      

       
    }
}
