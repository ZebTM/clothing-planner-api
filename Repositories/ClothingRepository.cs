using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothingPlanner.Repository;

public class ClothingRepository : IClothingRepository
{
    private readonly MyDatabaseContext _dbContext;

    public ClothingRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void DeleteClothing(Clothing clothing)
    {
        
        _dbContext.Clothing.Remove(clothing);
    }

    public IEnumerable<Clothing> GetClothing()
    {
        // This is not working for some reason
        // return await _dbContext.Clothing.ToListAsync();
        return _dbContext.Clothing.ToList();
    }

    public async Task<Clothing?> GetClothingByIdAsync(Guid id)
    {
        return await _dbContext.Clothing.FindAsync(id);
    }

    public  void InsertClothing(Clothing clothing)
    {
        _dbContext.Add(clothing);
    }

    public void UpdateClothing(Clothing clothing)
    {
        _dbContext.Clothing.Update(clothing);
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}