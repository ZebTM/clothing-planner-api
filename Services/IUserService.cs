using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public interface IUserService
{
    IEnumerable<SanitizedUser> GetUsers();
    SanitizedUser? GetUserById(Guid id);
    SanitizedUser CreateUser(CreateUser user);
    SanitizedUser EditUser(SanitizedUser user);
    SanitizedUser? DeleteUser(SanitizedUser user);
}