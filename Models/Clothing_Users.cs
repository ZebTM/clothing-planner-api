using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClothingPlanner.Models;

[Table("clothing_users")]
public class UserClothing
{
    [Column("clothing_id")]
    public Guid ClothingId { get; set; }
    [Column("users_id")]
    public Guid UserId { get; set; }
}