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
    }
}