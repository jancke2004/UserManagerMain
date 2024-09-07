using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace UserManager.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(UserManager.Repository.Models.Users users);
        Task<UserManager.Repository.Models.Users> GetUser(int id);
    }
}