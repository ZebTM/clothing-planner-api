using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.Repository;
using ClothingPlanner.Models;

namespace ClothingPlanner.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository; 
    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }   

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(_userRepository.GetUsers());
    }

    [HttpGet]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    [HttpPut]
    public async Task<IActionResult> EditUser(User user)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteUser(User user)
    {
        throw new NotImplementedException();
    }
    
}