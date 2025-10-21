using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FirstMVC.Models; // <- for at Character, StoryAct osv. skal finnes

namespace FirstMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Characters> Characters { get; set; }
<<<<<<< HEAD:FirstMVC/Data/ApplicationDbContext.cs
        public DbSet<storyAct> StoryActs { get; set; }
=======
        public DbSet<StoryAct> StoryActs { get; set; }

>>>>>>> b7fb39c29e6f77df7668494814390d289fb047d9:FirstMVC/Models/DbContext.cs
        public DbSet<UserProgressDB> UserProgress { get; set; }
    }
}
