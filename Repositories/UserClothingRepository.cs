

using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public class UserClothingRepository : IUserClothingRepository
{
    private readonly MyDatabaseContext _dbContext;
    public UserClothingRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public UserClothing AddUserClothing(UserClothing userClothing)
    {
        _dbContext.UserClothing.Add(userClothing);
        _dbContext.SaveChanges();

        return userClothing;
    }

    public UserClothing? FindUserClothing(UserClothing userClothing)
    {
        return _dbContext.UserClothing.Find(userClothing.users_id, userClothing.clothing_id);
    }

    public UserClothing? RemoveUserClothing(UserClothing userClothing)
    {
        UserClothing? oldUserClothing = FindUserClothing(userClothing);
        if ( oldUserClothing != null )
        {
            _dbContext.UserClothing.Remove(oldUserClothing);
            Save();
        }
        
        return oldUserClothing;
    }
    private void Save()
    {
        _dbContext.SaveChanges();
    }
}