using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.Models;
using ClothingPlanner.DatabaseContext;

namespace ClothingPlanner.Controllers;

[ApiController]
[Route("[controller]")]
public class ClothingController : ControllerBase
{
    private readonly MyDatabaseContext _dbContext;
    public ClothingController(MyDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }   

    
}