using Microsoft.Extensions.Logging.Abstractions;

namespace ClothingPlanner.Models;

public class Clothing
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Uri? OriginalLink { get; set; } = null;
    public Uri? Image { get; set; } = null;
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public float Price { get; set; } = 0;
}