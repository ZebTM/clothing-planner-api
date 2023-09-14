

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

    public void AddUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(Guid id)
    {
        throw new NotImplementedException();
    }

    public User GetUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetUserClothingById()
    {
        throw new NotImplementedException();
    }

    public void InsertUser(User user)
    {
        throw new NotImplementedException();
    }

    public void RemoveUserClothing(Guid userId, Guid clothingId)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}