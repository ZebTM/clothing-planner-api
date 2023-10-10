
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
    
    public Clothing DeleteUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public Clothing EditUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Clothing> GetAllClothing()
    {
        return _clothingRepository.GetClothing();
    }

    public Clothing? GetClothingById(Guid id)
    {
        return _clothingRepository.GetClothingById(id);
    }

    public Clothing InsertUserClothing(Guid userId, CreateClothing newClothing)
    {
        Clothing? existingClothing = _clothingRepository.GetClothingByLink(newClothing.OriginalLink);


        Clothing clothing = existingClothing != null ? existingClothing : new Clothing
        {
            Id = Guid.NewGuid(),
            OriginalLink = newClothing.OriginalLink,
            Image = newClothing.Image,
            Title = newClothing.Title,
            Description = newClothing.Description,
            Price = newClothing.Price
        };

        if (existingClothing == null)
        {
            _clothingRepository.InsertClothing(clothing);
        }
        
        UserClothing userClothing = new UserClothing
        {
            clothing_id = clothing.Id,
            users_id = userId
        };

        UserClothing? existingRelation = _userClothingRepository.FindUserClothing(userClothing);

        if ( existingRelation == null)
        {
            _userClothingRepository.AddUserClothing(userClothing);
        }

        return clothing;
    }
}