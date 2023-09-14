
using ClothingPlanner.Models;
using ClothingPlanner.Repository;

namespace ClothingPlanner.Services;

public class ClothingService : IClothingService
{
    private readonly IClothingRepository _clothingRepository;
    private readonly IUserRepository _userRepository;
    private readonly IUserClothingRepository _userClothingRepository;
    public ClothingService(IClothingRepository clothingRepository, IUserRepository userRepository, IUserClothingRepository userClothingRepository)
    {
        _userClothingRepository = userClothingRepository;
        _clothingRepository = clothingRepository;
        _userRepository = userRepository;
    }
    public Task<Clothing> DeleteUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public Task<Clothing> EditUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Clothing> GetAllClothing()
    {
        throw new NotImplementedException();
    }

    public Task<Clothing?> GetClothingById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Clothing> InsertUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }
}