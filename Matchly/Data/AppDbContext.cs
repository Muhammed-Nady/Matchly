using Matchly.Entities;
using Microsoft.EntityFrameworkCore;

namespace Matchly.Data
{
    public class AppDbContext : DbContext
    {


        public DbSet<AppUser> Users { get; set; } 

        public AppDbContext(DbContextOptions options) : base(options) { }

    }
}
