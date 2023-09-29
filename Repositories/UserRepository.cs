using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public class UserRepository : IUserRepository
{
    private readonly MyDatabaseContext _dbContext;

    public UserRepository(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public SanitizedUser? DeleteUser(Guid id)
    {
        User? user = _dbContext.Users.Find(id);

        if ( user != null )
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        };  

        if ( user == null)
        {
            return null;
        }  

        SanitizedUser sanitizedUser = new SanitizedUser(user);

        return sanitizedUser;
    }

    public SanitizedUser? GetUserById(Guid id)
    {
        User? user = _dbContext.Users.Find(id);
    }

    public IEnumerable<SanitizedUser> GetUsers()
    {
        return _dbContext.Users.ToList();
    }

    public SanitizedUser InsertUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return user;
    }

    public SanitizedUser UpdateUser(SanitizedUser user)
    {
        _dbContext.Users.Update(user);
        _dbContext.SaveChanges();
        return user;
    }
}