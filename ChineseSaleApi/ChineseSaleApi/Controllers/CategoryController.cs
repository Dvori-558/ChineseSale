using ChineseSaleApi.Dtos;
using ChineseSaleApi.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChineseSaleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        //read
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _service.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpGet]

        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _service.GetAllCategories();
            return Ok(categories);
        }
        //create
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CreateCategoryDto category)
        {
            await _service.AddCategory(category);
            return Created(nameof(GetCategory), category);
        }
        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _service.DeleteCategory(id);
            return NoContent();
        }
    }
}