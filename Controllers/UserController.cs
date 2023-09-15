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

    [HttpGet("id")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        User? user = _userRepository.GetUserById(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(User user)
    {
        _userRepository.InsertUser(user);
        return Ok(user);
    }

    [HttpPut]
    public async Task<IActionResult> EditUser(User user)
    {
        _userRepository.UpdateUser(user);
        return Ok(user);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteUser(User user)
    {
        var tmp = _userRepository.DeleteUser(user.Id);
        return Ok(tmp);
    }
    
}