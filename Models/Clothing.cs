using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClothingPlanner.Models;

[Table("clothing")]
public class Clothing
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("original_link")]
    public Uri? OriginalLink { get; set; } = null;
    [Column("image_link")]
    public Uri? Image { get; set; } = null;
    [Column("title")]
    public string Title { get; set; } = String.Empty;
    [Column("description")]
    public string Description { get; set; } = String.Empty;
    [Column("price")]
    public double Price { get; set; } = 0;
    public virtual ICollection<User> Users { get; } = new HashSet<User>();
}

public class CreateClothing
{
    public Uri? OriginalLink { get; set; } = null;
    public Uri? Image { get; set; } = null;
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public double Price { get; set; } = 0;
}

public class ClothingViewModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Uri? OriginalLink { get; set; } = null;
    public Uri? Image { get; set; } = null;
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public double Price { get; set; } = 0;
}