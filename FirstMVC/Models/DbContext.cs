using Microsoft.EntityFrameworkCore;
using FirstMVC.Models;

namespace FirstMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Characters> Characters { get; set; }
        public DbSet<storyAct> StoryActs { get; set; }

        public DbSet<UserProgressDB> UserProgress { get; set; }
    }
}