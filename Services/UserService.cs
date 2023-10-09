using ClothingPlanner.Models;
using ClothingPlanner.Repository;
using ClothingPlanner.Services.Util;

namespace ClothingPlanner.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public SanitizedUser CreateUser(CreateUser user)
    {
        User createdUser = new User
        {
            Id = Guid.NewGuid(),
            FirstName = user.FirstName,
            LastName = user.LastName,
            Username = user.Username,
            HashedPassword = PasswordHashingService.Hash( user.Password ) 
        };

        return _userRepository.InsertUser(createdUser);
    }

    public SanitizedUser? DeleteUser(SanitizedUser user)
    {
        return _userRepository.DeleteUser( user.Id );
    }

    public SanitizedUser EditUser(SanitizedUser user)
    {
        return _userRepository.UpdateUser(user);
    }

    public SanitizedUser? GetUserById(Guid id)
    {
        return _userRepository.GetUserById(id);
    }

    public IEnumerable<SanitizedUser> GetUsers()
    {
        return _userRepository.GetUsers();
    }
}