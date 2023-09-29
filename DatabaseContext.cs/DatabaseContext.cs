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

    public DbSet<Clothing> Clothing => Set<Clothing>();
    public DbSet<User> Users => Set<User>();
    public DbSet<UserClothing> UserClothing => Set<UserClothing>();
}