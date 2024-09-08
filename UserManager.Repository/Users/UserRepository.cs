using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Repository.Interfaces;
using UserManager.Repository.Models;


namespace UserManager.Repository.Users


{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext userContext;
        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public void AddUser(UserManager.Repository.Models.Users users)
        {
            string response = string.Empty;
             userContext.Users.Add(users);
             userContext.SaveChanges();

        }
        public List<UserManager.Repository.Models.Users> GetUsers()
        {
            return userContext.Users.ToList();
        }

        public UserManager.Repository.Models.Users? GetUser(int id)
        {
            return (UserManager.Repository.Models.Users?)userContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public string UpdateUser(UserManager.Repository.Models.Users users)
        {
            userContext.Entry(users).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            userContext.SaveChanges();
            return "User Updated";
        }

        public string DeleteUser(UserManager.Repository.Models.Users users)
        {
            userContext.Users.Remove(users);
            userContext.SaveChanges();
            return "User deleted";
        }



    }
}