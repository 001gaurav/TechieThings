using Microsoft.EntityFrameworkCore;
using TechieThings.API.Models.Domain;

namespace TechieThings.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TechPost> TechPosts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
