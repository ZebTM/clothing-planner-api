using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClothingPlanner.Models;

// [PrimaryKey(nameof(users_id), nameof(clothing_id))]
// [Table("clothing_users")]
public class UserClothing
{
    public Guid clothing_id { get; set; }
    public Guid users_id { get; set; }
    public User User { get; set; } = null!;
    public Clothing Clothing { get; set; } = null!;
}