using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public interface IClothingService
{
    IEnumerable<Clothing> GetAllClothing();
    Task<Clothing?> GetClothingById(Guid id);
    Task<Clothing> InsertUserClothing(Guid userId, Clothing clothing);
    Task<Clothing> DeleteUserClothing(Guid userId, Clothing clothing);
    Task<Clothing> EditUserClothing(Guid userId, Clothing clothing);
    
}