using Microsoft.AspNetCore.Mvc;
using User;
using DTO.User;



[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly UserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }

    [HttpPost("create")]
    public IActionResult createCustomer([FromBody] CreateUserDto dto)
    {
        return Ok(_service.Create(dto));
    }
}