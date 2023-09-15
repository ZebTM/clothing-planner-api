using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingPlanner.Models;

[Table("users")]
public class User
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("first_name")]
    public string FirstName { get; set; } = String.Empty;
    [Column("last_name")]
    public string LastName { get; set; } = String.Empty;
    [Column("user_name")]
    public string Username { get; set; } = String.Empty;
    [Column("hashed_password")]
    public string HashedPassword { get; set; } = String.Empty;
}