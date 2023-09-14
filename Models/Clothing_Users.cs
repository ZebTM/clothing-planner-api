using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClothingPlanner.Models;

[Table("clothing_users")]
public class UserClothing
{
    public Guid ClothingId { get; set; }
}