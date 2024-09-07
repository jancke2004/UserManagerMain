using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Repository.Interfaces;
using UserManager.Repository.Models;
using UserManager.Repository.UserContext;


namespace UserManager.Repository.Users


{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext userContext;
        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public Task AddUser(UserManager.Repository.Models.Users users)
        {
            string response = string.empty;
            usercontext.users.add(users);
            usercontext.savechanges();

        }
        public List<Users> GetUsers()
        {
            return userContext.Users.ToList();
        }

        public Task<UserManager.Repository.Models.Users> GetUser(int id)
        {
            return (UserManager.Repository.Models.Users)userContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public string UpdateUser(Users user)
        {
            userContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userContext.SaveChanges();
            return "User Updated";
        }

        public string DeleteUser(Users user)
        {
            userContext.Users.Remove(user);
            userContext.SaveChanges();
            return "User deleted";
        }



    }
}