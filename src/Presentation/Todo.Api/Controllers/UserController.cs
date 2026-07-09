using Microsoft.AspNetCore.Mvc;
using Todo.Application.Contracts;
using Todo.Application.DTOs.Request;

namespace Todo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateUserDto userDto)
    {
        var response = userService.CreateUserAsync(userDto);
        return Created();
    }
}
