
using ClothingPlanner.Models;

namespace ClothingPlanner.Repository;

public interface IUserClothingRepository
{
    UserClothing AddUserClothing(UserClothing userClothing);
    UserClothing? RemoveUserClothing(UserClothing userClothing);
    UserClothing? FindUserClothing(UserClothing userClothing);
}