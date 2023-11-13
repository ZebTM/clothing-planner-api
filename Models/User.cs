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
    public virtual ICollection<Clothing> Clothing { get; set; } = new HashSet<Clothing>();
}

public class CreateUser
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Username { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
}

public class SanitizedUser
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public string Username { get; set; } = String.Empty;
    public SanitizedUser(User user)
    {
        Id = user.Id;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Username = user.Username;
    }
}