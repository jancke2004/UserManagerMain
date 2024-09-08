using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace UserManager.Repository.Interfaces
{
    public interface IUserRepository
    {
        public List<UserManager.Repository.Models.Users> GetUsers();
        void AddUser(UserManager.Repository.Models.Users users);
        public UserManager.Repository.Models.Users GetUser(int id);

        public string UpdateUser(UserManager.Repository.Models.Users users);
        public string DeleteUser(UserManager.Repository.Models.Users users);
    }
}