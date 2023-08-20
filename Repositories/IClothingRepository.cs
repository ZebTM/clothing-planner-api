using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IClothingRepository : IDisposable
{
    IEnumerable<Clothing> GetClothing();
    Clothing? GetClothingById(Guid id);
    void InsertClothingAsync(Clothing clothing);
    void DeleteClothingAsync(Guid id);
    void UpdateClothingAsync(Clothing clothing);
    void SaveAsync();
}