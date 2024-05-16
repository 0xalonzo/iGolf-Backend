using Microsoft.EntityFrameworkCore;
using IgolfBackend.Models;

namespace IgolfBackend.Data
{
    public class GolfContext : DbContext
    {
        public GolfContext(DbContextOptions<GolfContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
