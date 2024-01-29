using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace AzureBaseUser.Model
{
    public class UserDBContext : DbContext
    {
        public UserDBContext()
        {
        }

        public UserDBContext(DbContextOptions<UserDBContext> options)
        : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; } = null!;



    }
}
