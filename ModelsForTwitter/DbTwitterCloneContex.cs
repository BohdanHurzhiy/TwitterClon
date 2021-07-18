﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<RelationshipsUser> Relationships { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagsPost> TagsPosts { get; set; }


        public DbTwitterCloneContex()
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb;Database = DbTwitterClone;Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(UserConfigure);
            modelBuilder.Entity<Post>(PostConfigure);
            modelBuilder.Entity<Liked>(LikedConfigure);
        }
        // конфигурация для типа User
        public void UserConfigure(EntityTypeBuilder<User> builder)
        {
        builder.HasData(
            new User[]
            {
                new() {Id = 1, NameUser = "Tom", AliasUser = "T", SecondNameUser = "Patison" },
                new() {Id = 2, NameUser = "Adam", AliasUser = "A", SecondNameUser = "Morkovkin" },
                new() {Id = 3, NameUser = "Jopa", AliasUser = "J", SecondNameUser = "Kabanov" },
                new() {Id = 4, NameUser = "Petr", AliasUser = "P", SecondNameUser = "Moroshko" },
                new() {Id = 5, NameUser = "Lola", AliasUser = "L", SecondNameUser = "Sharifov" },
                new() {Id = 6, NameUser = "Kolya", AliasUser = "K", SecondNameUser = "Moroz" },
                new() {Id = 7, NameUser = "Edison", AliasUser = "E", SecondNameUser = "Ivanov" },
                new() {Id = 8, NameUser = "Paramon", AliasUser = "Pa", SecondNameUser = "Lunin" },
                new() {Id = 9, NameUser = "Kostya", AliasUser = "Ko", SecondNameUser = "Kabachkov" },
                new() {Id = 11, NameUser = "Bohdan", AliasUser = "B", SecondNameUser = "Bulgakov" },
                new() {Id = 12, NameUser = "Alla", AliasUser = "Al", SecondNameUser = "Patison" }
            });
        }
        public void PostConfigure(EntityTypeBuilder<Post> builder)
        {
           builder.HasData(
              new Post[]
              {
                new() {Id = 1, UserId = 1, TextPost = "Some Text User 1" },
                new() {Id = 2, UserId = 1, TextPost = "Some Text User 1" },
                new() {Id = 3, UserId = 2, TextPost = "Some Text User 2" },
                new() {Id = 4, UserId = 4, TextPost = "Some Text User 4" },
                new() {Id = 5, UserId = 5, TextPost = "Some Text User 5" },
                new() {Id = 6, UserId = 6, TextPost = "Some Text User 6" },
                new() {Id = 7, UserId = 1, TextPost = "Some Text User 1" },
                new() {Id = 8, UserId = 7, TextPost = "Some Text User 7" },
                new() {Id = 9, UserId = 12, TextPost = "Some Text User 23" },
                new() {Id = 10, UserId = 5, TextPost = "Some Text User 5" },
                new() {Id = 11, UserId = 2, TextPost = "Some Text User 2" },
                new() {Id = 12, UserId = 7, TextPost = "Some Text User 7" },
                new() {Id = 13, UserId = 8, TextPost = "Some Text User 8" },
                new() {Id = 14, UserId = 2, TextPost = "Some Text User 2" },
                new() {Id = 15, UserId = 4, TextPost = "Some Text User 4" },
                new() {Id = 16, UserId = 1, TextPost = "Some Text User 1" }
              });

        }
        public void LikedConfigure(EntityTypeBuilder<Liked> builder)
        {
            builder.HasData(
             new Liked[]
             {
                new() {Id = 1, UserId = 1, PostId = 1 },
                new() {Id = 2, UserId = 1, PostId = 2 },
                new() {Id = 3, UserId = 1, PostId = 3 },
                new() {Id = 4, UserId = 4, PostId = 4 },
                new() {Id = 5, UserId = 4, PostId = 5 },
                new() {Id = 6, UserId = 2, PostId = 6 },
                new() {Id = 7, UserId = 2, PostId = 2 },
                new() {Id = 8, UserId = 3, PostId = 6 },
                new() {Id = 9, UserId = 2, PostId = 2 },
                new() {Id = 10, UserId = 2, PostId = 7 },
                new() {Id = 11, UserId = 7, PostId = 8 },
                new() {Id = 12, UserId = 6, PostId = 1 },
                new() {Id = 13, UserId = 3, PostId = 1 },
                new() {Id = 14, UserId = 12, PostId = 1 },
                new() {Id = 15, UserId = 5, PostId = 2 }
             });
        }


    }
}
