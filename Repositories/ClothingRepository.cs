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
            _dbContext.Clothings.Remove(clothing);
            Save();
        }
        
        return clothing;
    }

    public IEnumerable<ClothingViewModel> GetClothing()
    {
        // This is not working for some reason
        // return await _dbContext.Clothing.ToListAsync();
        return _dbContext.Clothings.Where(c => c.Id != null)
            .Select(c => new ClothingViewModel
                {               
                    Id = c.Id,
                    OriginalLink = c.OriginalLink,
                    Image = c.Image,
                    Title = c.Title,
                    Description = c.Description,
                    Price = c.Price
                }  
            ).ToList();
    }

    public Clothing? GetClothingById(Guid id)
    {
        return _dbContext.Clothings.Find(id);
    }

    public Clothing InsertClothing(Clothing clothing)
    {
        _dbContext.Add(clothing);
        Save();
        return clothing;
    }

    public Clothing UpdateClothing(Clothing clothing)
    {
        Clothing? oldClothing = _dbContext.Clothings.Find(clothing.Id);

        if ( oldClothing == null)
        {
            _dbContext.Clothings.Add(clothing);
        } else
        {
            _dbContext.Clothings.Update(clothing);
        }
        Save();

        return clothing;
    }

    public Clothing? GetClothingByLink(Uri? link)
    {   
        return _dbContext.Clothings.Where(c => c.OriginalLink == link ).FirstOrDefault();
    }

    private void Save()
    {
        _dbContext.SaveChanges();
    }

    public IEnumerable<ClothingViewModel> GetClothingByUserId(Guid userId)
    {
        IEnumerable<ClothingViewModel> test = from user in _dbContext.Users
            where user.Id == userId
            from clothing in user.Clothing
            select new ClothingViewModel
            {
                Id = clothing.Id,
                OriginalLink = clothing.OriginalLink,
                Image = clothing.Image,
                Title = clothing.Title,
                Description = clothing.Description,
                Price = clothing.Price,

            };
        
        return test.ToList();
    }

    public Boolean DoesUserHaveSpecificClothing(Guid userId, Guid clothingId)
    {
        return false;
    }
}