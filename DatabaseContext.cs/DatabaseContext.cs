using Microsoft.EntityFrameworkCore;
using ClothingPlanner.Models;
using Microsoft.Extensions.Configuration;

namespace ClothingPlanner.DatabaseContext;

public class MyDatabaseContext : DbContext
{
    protected readonly IConfiguration _configuration;

        public MyDatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("ClothingPlannerDatabase"));
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    // }

    // public DbSet<Workout> workouts { get; set; }
    // public DbSet<Exercise> exercises { get; set; }
    // public DbSet<Post> fitness_posts { get; set; }
}