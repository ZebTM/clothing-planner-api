using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.Repository;
using ClothingPlanner.Models;
using ClothingPlanner.Services;

namespace ClothingPlanner.Controllers;

[ApiController]
[Route("[controller]")]
public class ClothingController : ControllerBase
{
    private readonly IClothingService _clothingService;
    public ClothingController(IClothingService clothingService)
    {
        _clothingService = clothingService;
    }   

    [HttpGet]
    public IActionResult GetClothing()
    {
        return Ok( _clothingService.GetAllClothing() );
    }
    
    [HttpGet("id")]
    public IActionResult GetClothingById(Guid id)
    {
        return Ok( _clothingService.GetClothingById( id ) );
    }

    [HttpPost]
    public IActionResult InsertClothing(CreateClothing clothing , Guid userId )
    {
        return Ok( _clothingService.InsertUserClothing(userId, clothing) );
    }
}