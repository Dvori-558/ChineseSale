using ChineseSaleApi.Dtos;
using ChineseSaleApi.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;
using static ChineseSaleApi.Dtos.CreateForUserAddressDto;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;
        public AddressController(IAddressService addressService)
        {
            _service = addressService;
        }
        //read
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var address = await _service.GetAddressById(id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }
        //create
        [HttpPost]
        [Route("user")]
        public async Task<IActionResult> AddForUserAddress([FromBody] CreateForUserAddressDto address)
        {
            await _service.AddForUserAddress(address);
            return CreatedAtAction(nameof(GetAddress), new { id = address }, address);
        }
        [HttpPost]
        [Route("donor")]
        public async Task<IActionResult> AddForDonorAddress([FromBody] CreateForDonorAddressDto address)
        {
            await _service.AddForDonorAddress(address);
            return CreatedAtAction(nameof(GetAddress), new { id = address }, address);
        }
    }
}