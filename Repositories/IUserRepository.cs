
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IUserRepository
{
    IEnumerable<SanitizedUser> GetUsers();
    SanitizedUser? GetUserById(Guid id);
    SanitizedUser InsertUser(User user);
    SanitizedUser? DeleteUser(Guid id);
    SanitizedUser UpdateUser(SanitizedUser user);
}