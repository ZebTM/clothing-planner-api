
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IUserRepository
{
    IEnumerable<User> GetUsers();
    User? GetUserById(Guid id);
    User InsertUser(User user);
    User? DeleteUser(Guid id);
    User UpdateUser(User user);
    void AddUserClothing(Guid userId, Clothing clothing);
    void RemoveUserClothing(Guid userId, Guid clothingId);
}