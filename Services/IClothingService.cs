using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public interface IClothingService
{
    IEnumerable<ClothingViewModel> GetAllClothing();
    ClothingViewModel? GetClothingById(Guid id);
    ClothingViewModel InsertUserClothing(Guid userId, CreateClothing clothing);
    ClothingViewModel DeleteUserClothing(Guid userId, Clothing clothing);
    ClothingViewModel EditUserClothing(Guid userId, Clothing clothing);
    
}