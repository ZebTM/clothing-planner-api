
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IUserClothingRepository
{
    IEnumerable<User> GetUserClothingById();
    User GetUserById(Guid id);
    void InsertUser(User user);
    void DeleteUser(Guid id);
    void UpdateUser(User user);
    void AddUserClothing(Guid userId, Clothing clothing);
    void RemoveUserClothing(Guid userId, Guid clothingId);
}