using Microsoft.EntityFrameworkCore;
using UserManager.Repository.Models;

namespace UserManager.Model
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
