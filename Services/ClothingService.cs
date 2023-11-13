
using ClothingPlanner.Models;
using ClothingPlanner.Repository;

namespace ClothingPlanner.Services;

public class ClothingService : IClothingService
{
    private readonly IClothingRepository _clothingRepository;
    // private readonly IUserClothingRepository _userClothingRepository;
    public ClothingService(IClothingRepository clothingRepository)
    {
        _clothingRepository = clothingRepository;
    }
    
    public UserClothing? DeleteUserClothing(Guid userId, Clothing clothing)
    {
        throw new NotImplementedException();
        UserClothing userClothing = new UserClothing
        {
            users_id = userId,
            clothing_id = clothing.Id
        };

        // return _userClothingRepository.RemoveUserClothing(userClothing);
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

        if ( _clothingRepository.DoesUserHaveSpecificClothing(userId, clothing.Id))
        {
            // _userClothingRepository.AddUserClothing(userClothing);
        };

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

    public IEnumerable<ClothingViewModel> GetClothingByUserId(Guid userId)
    {
        return _clothingRepository.GetClothingByUserId(userId);
    }
}