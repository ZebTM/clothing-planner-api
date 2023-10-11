
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
    
    public ClothingViewModel DeleteUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public ClothingViewModel EditUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ClothingViewModel> GetAllClothing()
    {
        return _clothingRepository.GetClothing();
    }

    public ClothingViewModel? GetClothingById(Guid id)
    {
        Clothing? clothing = _clothingRepository.GetClothingById(id);
        if ( clothing == null )
        {
            return null;
        }

        return new ClothingViewModel
        {
            Id = clothing.Id,
            OriginalLink = clothing.OriginalLink,
            Image = clothing.Image,
            Title = clothing.Title,
            Description = clothing.Description,
            Price = clothing.Price
        };
    }

    public ClothingViewModel InsertUserClothing(Guid userId, CreateClothing newClothing)
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

        return new ClothingViewModel
        {
            Id = clothing.Id,
            OriginalLink = clothing.OriginalLink,
            Image = clothing.Image,
            Title = clothing.Title,
            Description = clothing.Description,
            Price = clothing.Price
        };
    }
}