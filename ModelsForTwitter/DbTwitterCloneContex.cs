using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelsForTwitter
{
    public class DbTwitterCloneContex : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Repost> RePosts { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Liked> Likeds { get; set; }
        public DbSet<LikedAnswer> LikedsAnswer { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Relationships_user> Relationships { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Tags_post> Tags_post { get; set; }


        public DbTwitterCloneContex()
        { 
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DbTwitterClone;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(UserConfigure);
            modelBuilder.Entity<Post>(PostConfigure);
            modelBuilder.Entity<Repost>(RePostConfigure);
        }
        // конфигурация для типа User
        public void UserConfigure(EntityTypeBuilder<User> builder)
        {
            
        }
        // конфигурация для типа Post
        public void PostConfigure(EntityTypeBuilder<Post> builder)
        {
          

        }
        public void RePostConfigure(EntityTypeBuilder<Repost> builder)
        {
            
        }
    }
}
