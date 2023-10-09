using ClothingPlanner.DatabaseContext;
using ClothingPlanner.Models;
using Microsoft.EntityFrameworkCore;

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
        return _dbContext.Users.Where(u => u.Id == id)
            .Select( u => new SanitizedUser(u))
            .FirstOrDefault();
    }

    public IEnumerable<SanitizedUser> GetUsers()
    {
        return _dbContext.Users
            .Select(u => new SanitizedUser(u))
            .ToList();
    }

    public SanitizedUser InsertUser(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
        return new SanitizedUser(user);
    }

    public SanitizedUser UpdateUser(SanitizedUser user)
    {   
        _dbContext.Users.Where(u => u.Id == user.Id)
            .ExecuteUpdate(u => u
                .SetProperty( u => u.FirstName, user.FirstName)
                .SetProperty( u => u.LastName, user.LastName)
                .SetProperty( u => u.Username, user.Username)
            );
            
        return user;
    }
}