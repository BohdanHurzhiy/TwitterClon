using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProject
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>();
            modelBuilder.Entity<User>().HasKey(u => u.userIdent);
            modelBuilder.Entity<User>().HasIndex(u => u.Name).HasFilter("[Name] IS NOT NULL");
        }
    }
}
