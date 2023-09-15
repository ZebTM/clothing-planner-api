using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.Repository;
using ClothingPlanner.Models;

namespace ClothingPlanner.Controllers;

[ApiController]
[Route("[controller]")]
public class ClothingController : ControllerBase
{
    private readonly IClothingRepository _clothingRepository; 
    public ClothingController(IClothingRepository clothingRepository)
    {
        _clothingRepository = clothingRepository;
    }   

    [HttpGet]
    public IActionResult GetClothing()
    {
        return Ok( _clothingRepository.GetClothing() );
    }
    
    [HttpGet("id")]
    public IActionResult GetClothingById(Guid id)
    {
        return Ok( _clothingRepository.GetClothingById( id ) );
    }
}