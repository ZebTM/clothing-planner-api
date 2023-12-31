using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IClothingRepository
{
    IEnumerable<ClothingViewModel> GetClothing();
    Clothing? GetClothingById(Guid id);
    Clothing InsertClothing(Clothing clothing);
    Clothing? DeleteClothing(Clothing clothing);
    Clothing UpdateClothing(Clothing clothing);
    Clothing? GetClothingByLink(Uri? link);
}