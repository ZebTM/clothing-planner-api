using ClothingPlanner.Models;

namespace ClothingPlanner.Services;

public interface IClothingService
{
    IEnumerable<Clothing> GetAllClothing();
    Clothing? GetClothingById(Guid id);
    Clothing InsertUserClothing(Guid userId, Clothing clothing);
    Clothing DeleteUserClothing(Guid userId, Clothing clothing);
    Clothing EditUserClothing(Guid userId, Clothing clothing);
    
}