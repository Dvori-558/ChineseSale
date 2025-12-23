using ChineseSaleApi.Dtos;
using ChineseSaleApi.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService userService)
        {
            _service = userService;
        }
        //read
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _service.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        //create
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto userDto)
        {
            await _service.AddUser(userDto);
            return CreatedAtAction(nameof(GetUser), new { Id = userDto.UserName }, userDto);

        }
        //update
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto userDto)
        {
            await _service.UpdateUser(userDto);
            return NoContent();
        }
    }
}
