using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<User> User { get; set; }
    }
}
