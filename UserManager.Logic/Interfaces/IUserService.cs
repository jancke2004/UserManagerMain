using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager.Logic.Interfaces
{
    public interface IUserService
    {
        void AddUser(UserManager.Repository.Models.Users users);
        public List<UserManager.Repository.Models.Users> GetUsers();
        public UserManager.Repository.Models.Users GetUser(int id);
        string UpdateUser(UserManager.Repository.Models.Users users);
       
        public string DeleteUser(UserManager.Repository.Models.Users users);
    }
}