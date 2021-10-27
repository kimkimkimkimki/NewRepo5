using Hepsiburada.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hepsiburada.Infrastructure.Contexts
{
    public class EfDbContext:DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserList> TopLists { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
