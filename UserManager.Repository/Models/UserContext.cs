using Microsoft.EntityFrameworkCore;
using UserManager.Repository.Models;

namespace UserManager.Repository.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserManager.Repository.Models.Users> Users { get; set; }
    }
}
