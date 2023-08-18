namespace ClothingPlanner.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Username { get; set; } = String.Empty;
    public string HashedPassword { get; set; } = String.Empty;
}