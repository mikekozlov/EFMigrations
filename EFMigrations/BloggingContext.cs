using Microsoft.EntityFrameworkCore;

namespace EFMigrations
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("blog");
            modelBuilder.Entity<Post>().ToTable("post");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Data Source=.\sqlexpress;Initial Catalog=EFMigrations;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connection);
        }
    }
}

