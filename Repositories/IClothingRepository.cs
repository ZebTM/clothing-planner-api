using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IClothingRepository
{
    IEnumerable<Clothing> GetClothing();
    Task<Clothing?> GetClothingByIdAsync(Guid id);
    void InsertClothing(Clothing clothing);
    void DeleteClothing(Clothing clothing);
    void UpdateClothing(Clothing clothing);
    Task SaveAsync();
}