using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniPin_DataAccess.Configurations;

namespace UniPin_DataAccess
{
    public class UniPin_Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-POQOTV0\SQLEXPRESS;Initial Catalog=UniPin;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new PictureConfiguration());
            modelBuilder.ApplyConfiguration(new RuleConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            modelBuilder.Entity<Comment>()
                .HasOne(u => u.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Comment>()
            //    .HasOne(c => c.Post)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
