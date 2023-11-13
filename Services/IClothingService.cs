using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public interface IClothingService
{
    IEnumerable<ClothingViewModel> GetAllClothing();
    ClothingViewModel? GetClothingById(Guid id);
    IEnumerable<ClothingViewModel> GetClothingByUserId(Guid userId);
    ClothingViewModel InsertUserClothing(Guid userId, CreateClothing clothing);
    UserClothing? DeleteUserClothing(Guid userId, Clothing clothing);
}