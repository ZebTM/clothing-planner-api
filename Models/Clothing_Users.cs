using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClothingPlanner.Models;

[PrimaryKey(nameof(UsersId), nameof(ClothingId))]
[Table("clothing_users")]
public class UserClothing
{
    [Column("clothing_id")]
    public Guid ClothingId { get; set; }
    [Column("users_id")]
    public Guid UsersId { get; set; }
    public User User { get; set; } = null!;
    public Clothing Clothing { get; set; } = null!;
}