using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace UserManager.Repository.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(UserManager.Repository.Models.Users users);
        UserManager.Repository.Models.Users GetUser(int id);
    }
}