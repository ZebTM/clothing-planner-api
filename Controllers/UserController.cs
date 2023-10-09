using Microsoft.AspNetCore.Mvc;
using ClothingPlanner.Repository;
using ClothingPlanner.Models;
using ClothingPlanner.Services;

namespace ClothingPlanner.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository; 
    private readonly IUserService _userService;
    public UserController(IUserRepository userRepository, IUserService userService)
    {
        _userRepository = userRepository;
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(_userService.GetUsers());
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        return Ok(_userService.GetUserById(id));
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUser user)
    {
        return Ok(_userService.CreateUser(user));
    }

    [HttpPut]
    public async Task<IActionResult> EditUser(SanitizedUser user)
    {
        _userService.EditUser(user);
        return Ok(user);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteUser(SanitizedUser user)
    {
        var tmp = _userService.DeleteUser(user);
        return Ok(tmp);
    }
    
    [HttpPut("id")]
    public async Task<IActionResult> ResetUserPassword(string password)
    {
        throw new NotImplementedException();
    }
}