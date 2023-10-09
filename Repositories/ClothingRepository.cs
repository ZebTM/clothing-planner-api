using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ClothingPlanner.Repository;

public class ClothingRepository : IClothingRepository
{
    private readonly MyDatabaseContext _dbContext;

    public ClothingRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Clothing? DeleteClothing(Clothing clothing)
    {
        Clothing? oldClothing = GetClothingById( clothing.Id );
        if ( oldClothing != null )
        {
            _dbContext.Clothing.Remove(clothing);
            Save();
        }
        
        return clothing;
    }

    public IEnumerable<Clothing> GetClothing()
    {
        // This is not working for some reason
        // return await _dbContext.Clothing.ToListAsync();
        return _dbContext.Clothing.ToList();
    }

    public Clothing? GetClothingById(Guid id)
    {
        return _dbContext.Clothing.Find(id);
    }

    public Clothing InsertClothing(Clothing clothing)
    {
        _dbContext.Add(clothing);
        Save();
        return clothing;
    }

    public Clothing UpdateClothing(Clothing clothing)
    {
        Clothing? oldClothing = _dbContext.Clothing.Find(clothing.Id);

        if ( oldClothing == null)
        {
            _dbContext.Clothing.Add(clothing);
        } else
        {
            _dbContext.Clothing.Update(clothing);
        }
        Save();

        return clothing;
    }

    public Clothing? GetClothingByLink(Uri? link)
    {
        return null;
    }

    private void Save()
    {
        _dbContext.SaveChanges();
    }
}