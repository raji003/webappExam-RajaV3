using Microsoft.EntityFrameworkCore;
using SamiLearnGame.Models;

namespace SamiLearnGame.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<characters> Characters { get; set; }
        public DbSet<storyAct> StoryActs { get; set; }

        public DBSet<UserProgressDb> UserProgress { get; set; }
    }
}