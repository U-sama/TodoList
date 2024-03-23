using Microsoft.EntityFrameworkCore;
using TodoApi.Data.Models;

namespace TodoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // For IdentityDbContext to work
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem { Id = 1, Name = "Do Home work", IsComplete = true },
                new TodoItem { Id = 2, Name = "Play Football", IsComplete = false },
                new TodoItem { Id = 3, Name = "Eat Breakfast", IsComplete = false }
                );
        }
    }
}
