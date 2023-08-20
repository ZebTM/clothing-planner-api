using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.Repository;

namespace ClothingPlanner.Controllers;

[ApiController]
[Route("[controller]")]
public class ClothingController : ControllerBase
{
    private IClothingRepository clothingRepository; 
    public ClothingController(IClothingRepository clothingRepository)
    {
        this.clothingRepository = clothingRepository;
    }   

    [HttpGet]
    public async Task<IActionResult> GetClothing()
    {
        try {
            return Ok(clothingRepository.GetClothing());
        } catch (Exception e )
        {
            return BadRequest(e);
        }
    }
    
}