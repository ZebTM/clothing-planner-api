using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public class UserRepository : IUserRepository
{
    private readonly MyDatabaseContext _dbContext;
    private readonly ClothingRepository _clothingRepository;

    public UserRepository(MyDatabaseContext dbContext, ClothingRepository clothingRepository)
    {
        _dbContext = dbContext;
        _clothingRepository = clothingRepository;
    }

    public void AddUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public User? DeleteUser(Guid id)
    {
        User? user = _dbContext.Users.Find(id);

        if ( user != null )
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        };

        return user;
    }

    public User? GetUserById(Guid id)
    {
        return _dbContext.Users.Find(id);
    }

    public IEnumerable<User> GetUsers()
    {
        return _dbContext.Users.ToList();
    }

    public User InsertUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return user;
    }

    public void RemoveUserClothing(Guid userId, Guid clothingId)
    {
        throw new NotImplementedException();
    }

    public User UpdateUser(User user)
    {
        _dbContext.Users.Update(user);
        _dbContext.SaveChanges();
        return user;
    }
}