using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Repository.Interfaces;
using UserManager.Repository.Models;
using System.ComponentModel.DataAnnotations;


namespace UserManager.Repository.Users


{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext userContext;
        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public string AddUser(UserManager.Repository.Models.Users users)
        {
             // Manual validation before saving to the database
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(users);
            bool isValid = Validator.TryValidateObject(users, validationContext, validationResults, true);

            if (!isValid)
            {
                // Return or throw validation error messages
                var errorMessages = string.Join("; ", validationResults.Select(result => result.ErrorMessage));
                return $"User data is invalid: {errorMessages}";
            }

            // Proceed with adding the user if validation passes
            users.Date_Created = DateTime.Now;
            userContext.Users.Add(users);
            userContext.SaveChanges();

            return "User added successfully";

        }
        public List<UserManager.Repository.Models.Users> GetUsers(int pageNumber, int pageSize)
        {
            return userContext.Users
                       .Skip((pageNumber - 1) * pageSize)  
                       .Take(pageSize)                     
                       .ToList();
        }

        public UserManager.Repository.Models.Users? GetUser(int id)
        {
            return (UserManager.Repository.Models.Users?)userContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public string UpdateUser(UserManager.Repository.Models.Users users)
        {
            users.Date_Updated = DateTime.Now;
            //users.Updated_By = currentUser;
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