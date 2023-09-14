
using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public class UserService : IUserService
{
    public Task<User> CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> DeleteUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> EditUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}