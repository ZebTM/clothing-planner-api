using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User?> GetUserById(Guid id);
    Task<User> CreateUser(User user);
    Task<User> EditUser(User user);
    Task<User> DeleteUser(User user);
}