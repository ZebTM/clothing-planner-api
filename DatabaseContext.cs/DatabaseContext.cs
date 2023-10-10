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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UserClothing>()
            .ToTable("clothing_users");

        modelBuilder.Entity<UserClothing>()
            .Property( uc => uc.clothing_id)
            .HasColumnName("clothing_id");

        modelBuilder.Entity<UserClothing>()
            .Property( uc => uc.users_id )
            .HasColumnName("users_id");

        modelBuilder.Entity<UserClothing>()
            .HasKey( uc => new { uc.clothing_id, uc.users_id } );

        modelBuilder.Entity<UserClothing>()
            .HasOne(uc => uc.Clothing)
            .WithMany(c => c.UserClothing)
            .HasForeignKey(uc => uc.clothing_id);

        modelBuilder.Entity<UserClothing>()
            .HasOne(uc => uc.User)
            .WithMany(u => u.UserClothing)
            .HasForeignKey(uc => uc.users_id);   
    }

    public DbSet<Clothing> Clothing => Set<Clothing>();
    public DbSet<User> Users => Set<User>();
    public DbSet<UserClothing> UserClothing => Set<UserClothing>();
}