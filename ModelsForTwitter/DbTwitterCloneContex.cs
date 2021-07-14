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
        public DbSet<TagsPost> Tags_post { get; set; }


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
        builder.HasData(
            new User[]
            {
                new() {Id = 1, NameUser="Tom", AliasUser = "T", SecondNameUser = "Patison" },
                new() {Id = 2, NameUser="Adam", AliasUser = "A", SecondNameUser = "Morkovkin" },
                new() {Id = 3, NameUser="Jopa", AliasUser = "J", SecondNameUser = "Kabanov" }
            });
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
